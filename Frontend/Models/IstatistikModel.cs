using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class IstatistikModel
    {
        [Key]
        public int IstatistikId { get; set; }
        public string cozen { get; set; }
        public string cozulen { get; set; }
        public string testAdi { get; set; }
        public int testId { get; set; }
        public int DogruSayisi { get; set; }
        public int YanlisSayisi { get; set; }
        public string Kankalik { get; set; }
    }
}
