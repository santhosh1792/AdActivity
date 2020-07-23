using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AdActivity.Domain.Models
{
    [Table("Campaign")]
    public class Campaign
    {
        [Key]
        public int CAMId { get; set; }
        public string CAMName { get; set; }
        public string CAMDesc { get; set; }
        [ForeignKey("Brand")]
        public int BRNId { get; set; }
        public virtual Brand Brand { get; set; }
        [ForeignKey("FundingType")]
        public int FundingTypeId { get; set; }
        public virtual FundingType FundingType { get; set; }
        public string ActiveStatus { get; set; }
        public bool IsPlaceholder { get; set; }
        public DateTime AddDate { get; set; }
    }
}
