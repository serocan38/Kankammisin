using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class TestBilgi
    {
        [Key]
        public int TestId { get; set; }
        public string SahipUsername { get; set; }
    }
}
