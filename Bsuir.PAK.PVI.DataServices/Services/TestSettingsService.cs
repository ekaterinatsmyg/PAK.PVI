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
    public class TestSettingsService : ITestSettingsService
    {
        private readonly ITestSettingsRepository _testSettingsRepository;

        public TestSettingsService(ITestSettingsRepository testSettingsRepository)
        {
            _testSettingsRepository = testSettingsRepository;
        }
        public TestSettingsModel GetEntityById(int id)
        {
            return _testSettingsRepository.GetEntityById(id);
        }

        public IList<TestSettingsModel> GetAllEntities()
        {
            return _testSettingsRepository.GetAllEntities();
        }

        public IList<TestSettingsModel> GetAllSettingsByTestId(int id)
        {
            return _testSettingsRepository.GetAllSettingsByTestId(id);
        }
    }
}
