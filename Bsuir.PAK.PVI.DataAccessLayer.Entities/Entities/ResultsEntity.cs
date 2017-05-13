using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsuir.PAK.PVI.DataAccessLayer.Entities.Entities
{
    [Table("UserResult")]
    public class ResultsEntity : BaseEntity
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public int ExperimentId { get; set; }
        [Required]
        public int TestId { get; set; }
        [Required]
        public int ExperimentSettingsId { get; set; }
        [Required]
        public int TestSettingsId { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }

        public string Result { get; set; }


        public virtual UserEntity UserEntity { get; set; }
        public virtual ExperimentEntity ExperimentEntity { get; set; }
        public virtual TestEntity TestEntity { get; set; }
        public virtual ExperimentSettingsEntity ExperimentSettingEntity{ get; set; }
        public virtual TestSettingsEntity TestSettingEntity { get; set; }

    }
}
