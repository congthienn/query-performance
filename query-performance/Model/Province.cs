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
    public class Province
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Code { get; set; }
        [Unicode(true)]
        public string Name { get; set; } = null!;
        public string CodeName { get; set; } = null!;
        public string DivisionType { get; set; } = null!;
        public int PhoneCode { get; set; }
        public List<District>? District { get; set; }
    }
}
