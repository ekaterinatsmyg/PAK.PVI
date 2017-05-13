using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsuir.PAK.PVI.DataAccessLayer.Models.Models
{
    [Serializable]
    public class TestModel : IModel
    {
        public int Id { get; set; }
        public string TestName { get; set; }
        public int ExperimentId { get; set; }
    }
}
