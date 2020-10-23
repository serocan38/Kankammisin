using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class CozulenTestModel
    {
        [Key]
        public int id { get; set; }
        public string cozen { get; set; }
        public int testId { get; set; }
        public string secilenCevaplar { get; set; }
    }
}
