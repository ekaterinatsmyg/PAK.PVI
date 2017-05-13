using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bsuir.PAK.PVI.DataAccessLayer.Models.Models;
using Bsuir.PAK.PVI.DataAccessLayer.Repositories.Interfaces;
using Bsuir.PAK.PVI.DataServices.Interfaces;

namespace Bsuir.PAK.PVI.DataServices.Services
{
    public class ExperimentSettingsService : IExperimentSettingsService
    {
        private readonly IExperimentSettingsRepository _experimentSettingsRepository;

        public ExperimentSettingsService(IExperimentSettingsRepository experimentSettingsRepository)
        {
            _experimentSettingsRepository = experimentSettingsRepository;
        }
        public ExperimentSettingsModel GetEntityById(int id)
        {
            return _experimentSettingsRepository.GetEntityById(id);
        }

        public IList<ExperimentSettingsModel> GetAllEntities()
        {
            return _experimentSettingsRepository.GetAllEntities();
        }

        public IList<ExperimentSettingsModel> GetAllSettingsByExperimentId(int id)
        {
            return _experimentSettingsRepository.GetAllSettingsByExperimentId(id);
        }
    }
}
