using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AdActivity.Domain.Models
{
    public class FundingType
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
