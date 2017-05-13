using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsuir.PAK.PVI.DataAccessLayer.Entities.Entities
{
    [Table("Test")]
    public class TestEntity : BaseEntity
    {
        [Required]
        public string TestName { get; set; }
        [Required]
        public int ExperimentId { get; set; }

        public virtual ExperimentEntity ExperimentEntity { get; set; }
        public virtual ICollection<ResultsEntity> Results{ get; set; }
        public virtual ICollection<TestSettingsEntity> TestSettings { get; set; }
    }
}
