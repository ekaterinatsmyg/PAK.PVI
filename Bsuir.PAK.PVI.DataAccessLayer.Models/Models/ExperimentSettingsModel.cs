using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bsuir.PAK.PVI.DataAccessLayer.Entities.Enums;

namespace Bsuir.PAK.PVI.DataAccessLayer.Models.Models
{
    [Serializable]
    public class ExperimentSettingsModel: IModel
    {
        public int Id { get; set; }
        public int ExperimentId { get; set; }
        public TimeSpan TimeBetweenTests { get; set; }
        public SettingsState SettingsState { get; set; }
    }
}
