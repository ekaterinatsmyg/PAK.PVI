using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Bsuir.PAK.PVI.DataAccessLayer.Entities.Enums;

namespace Bsuir.PAK.PVI.DataAccessLayer.Entities.Entities
{
    [Table("ExperimentSettings")]
    public class ExperimentSettingsEntity : BaseEntity
    {
        [Required]
        public int ExperimentId { get; set; }
        [Required]
        public TimeSpan TimeBetweenTests { get; set; }
        [Required]
        public SettingsState SettingsState { get; set; }

        public virtual  ExperimentEntity ExperimentEntity { get; set; }
        public virtual ICollection<ResultsEntity> Results { get; set; }


    }
}
