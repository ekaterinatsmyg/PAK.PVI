using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bsuir.PAK.PVI.DataAccessLayer.Models.Models;

namespace Bsuir.PAK.PVI.DataServices.Interfaces
{
    public interface IExperimentSettingsService 
    {
        ExperimentSettingsModel GetEntityById(int id);
        IList<ExperimentSettingsModel> GetAllEntities();
        IList<ExperimentSettingsModel> GetAllSettingsByExperimentId(int id);
    }
}
