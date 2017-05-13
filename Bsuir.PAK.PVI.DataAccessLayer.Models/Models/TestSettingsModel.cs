using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bsuir.PAK.PVI.DataAccessLayer.Entities.Enums;

namespace Bsuir.PAK.PVI.DataAccessLayer.Models.Models
{
    [Serializable]
    public class TestSettingsModel : IModel
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public TimeSpan TimeStimulus { get; set; }
        public SettingsState SettingsSate { get; set; }
        public int? StimulusId { get; set; }
        public TimeSpan? TimeBetweenStimulus { get; set; }
    }
}
