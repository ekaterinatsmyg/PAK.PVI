using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Bsuir.PAK.PVI.DataAccessLayer.Entities.Entities;
using Bsuir.PAK.PVI.DataAccessLayer.Models.Models;
using Bsuir.PAK.PVI.DataAccessLayer.Repositories.Interfaces;

namespace Bsuir.PAK.PVI.DataAccessLayer.Repositories.Repositories
{
    public class TestSettingsRepository : ITestSettingsRepository
    {
        private readonly DbContext _dbContext;

        public TestSettingsRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }   

        public TestSettingsModel GetEntityById(int id)
        {
            var settings = _dbContext.Set<TestSettingsEntity>().FirstOrDefault(l => l.Id == id);
            return Mapper.Map<TestSettingsEntity, TestSettingsModel>(settings);
        }

        public IList<TestSettingsModel> GetAllEntities()
        {
            var settings = _dbContext.Set<TestSettingsEntity>().ToList();
            return Mapper.Map<List<TestSettingsEntity>, List<TestSettingsModel>>(settings);
        }

        public IList<TestSettingsModel> GetAllSettingsByTestId(int id)
        {
            var settings = _dbContext.Set<TestSettingsEntity>().Where(l => l.TestId == id).ToList();
            return Mapper.Map<List<TestSettingsEntity>, List<TestSettingsModel>>(settings);
        }
    }
}
