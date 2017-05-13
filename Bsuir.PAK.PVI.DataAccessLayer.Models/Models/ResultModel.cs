using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsuir.PAK.PVI.DataAccessLayer.Models.Models
{
    [Serializable]
    public class ResultModel : IModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ExperimentId { get; set; }
        public int TestId { get; set; }
        public int ExperimentSettingsId { get; set; }
        public int TestSettingsId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Results { get; set; }

    }
}
