using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;

namespace QueryPerformance
{
    public class EFCompiledQueryBenchmark
    {
  
        public List<Province> AllProvince_District_Ward_NoTracking()
        {
            using (var context = new AppDbContext())
            {
                return context.Set<Province>().Include(x => x.District).ThenInclude(x => x.Ward).AsNoTracking().ToList();
            }
        }

        [Benchmark]
        public List<Province> AllProvince_District_Ward()
        {
            using (var context = new AppDbContext())
            {
                return context.Set<Province>().Include(x => x.District).ThenInclude(x => x.Ward).ToList();
            }
        }

        public static Func<AppDbContext, IEnumerable<Province>> query = EF.CompileQuery((AppDbContext dbContext) => dbContext.Set<Province>().Include(x => x.District).ThenInclude(x => x.Ward).AsNoTracking());
        public List<Province> AllProvince_District_Ward_NoTracking_CompiledQuery()
        {
           
            using (var context = new AppDbContext())
            {
                return query(context).ToList();
            }
        }

        public static Func<AppDbContext, IEnumerable<Province>> query1 = EF.CompileQuery((AppDbContext dbContext) => dbContext.Set<Province>().Include(x => x.District).ThenInclude(x => x.Ward));
        [Benchmark]
        public List<Province> AllProvince_District_Ward_CompiledQuery()
        {

            using (var context = new AppDbContext())
            {
                return query1(context).ToList();
            }
        }
    }
}
