using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bsuir.PAK.PVI.DataAccessLayer.Entities.Enums;

namespace Bsuir.PAK.PVI.DataAccessLayer.Entities.Entities
{
    [Table("Stimulus")]
    public class StimulusEntity : BaseEntity
    {
        [Required]
        public string RangeOfIncentives { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public StimulusState StimulusState { get; set; }
        public int? TestSettingsId { get; set; }
        
        public virtual ICollection<TestSettingsEntity> TestSettings { get; set; }
    }
}
