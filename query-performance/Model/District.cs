using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryPerformance
{
    public class District
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Code { get; set; }
        [Unicode(true)]
        public string Name { get; set; } = null!;
        public string CodeName { get; set; } = null!;
        public string DivisionType { get; set; } = null!;
        public int ProvinceId { get; set; }
        public Province? Province { get; set; }
        public List<Ward>? Ward { get; set; }
    }
}
