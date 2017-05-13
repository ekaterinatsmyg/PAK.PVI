using System;
using Bsuir.PAK.PVI.DataAccessLayer.Entities.Enums;

namespace Bsuir.PAK.PVI.DataAccessLayer.Models.Models
{
    [Serializable]
    public class StimulusModel : IModel
    {
        public int Id { get; set; }
        public string RangeOfIncentives { get; set; }
        public DateTime CreatedDate { get; set; }
        public StimulusState StimulusState { get; set; }
        public int? TestSettingsId { get; set; }
    }
}
