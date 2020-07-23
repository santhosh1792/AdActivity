using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AdActivity.Domain.Models
{
    [Table("Brand")]
    public class Brand
    {
        [Key]
        public int BRNId { get; set; }
        public string BRNType { get; set; }
        public DateTime BRNEffectDate { get; set; }
        public DateTime BRNEndDate { get; set; }
    }
}
