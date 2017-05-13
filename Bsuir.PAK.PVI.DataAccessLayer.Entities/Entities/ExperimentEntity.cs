using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bsuir.PAK.PVI.DataAccessLayer.Entities.Entities
{
    [Table("Experiment")]
    public class ExperimentEntity : BaseEntity
    {
        [Required]
        public string ExperimentName { get; set; }

        public virtual ICollection<ResultsEntity> Results { get; set; }
        public virtual ICollection<TestEntity> Tests { get; set; }
        public virtual ICollection<ExperimentSettingsEntity> ExperimentSettings { get; set; }
    }
}
