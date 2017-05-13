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
    [Table("TestSettings")]
    public class TestSettingsEntity : BaseEntity
    {
        [Required]
        public int TestId { get; set; }
        [Required]
        public TimeSpan TimeStimulus { get; set; }
        [Required]
        public SettingsState SettingsSate { get; set; }
        public int? StimulusId { get; set; }
        public int? ResultsId { get; set; }
        public TimeSpan? TimeBetweenStimulus { get; set; }

        public virtual TestEntity TestEntity { get; set; }
        public virtual ICollection<ResultsEntity> Results { get; set; }
        public virtual StimulusEntity StimulusEntity { get; set; }


    }
}
