using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AdActivity.Domain.Models
{
    [Table("FundingType")]
    public class FundingType
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
