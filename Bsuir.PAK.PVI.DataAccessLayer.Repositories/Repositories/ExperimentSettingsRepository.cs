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
    public class ExperimentSettingsRepository : IExperimentSettingsRepository 
    {
        private readonly DbContext _dbContext;

        public ExperimentSettingsRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ExperimentSettingsModel GetEntityById(int id)
        {
            var settings = _dbContext.Set<ExperimentSettingsEntity>().FirstOrDefault(l => l.Id == id);
            return Mapper.Map<ExperimentSettingsEntity, ExperimentSettingsModel>(settings);
        }

        public IList<ExperimentSettingsModel> GetAllEntities()
        {
            var settings = _dbContext.Set<ExperimentSettingsEntity>().ToList();
            return Mapper.Map<List<ExperimentSettingsEntity>, List<ExperimentSettingsModel>>(settings);
        }

        public IList<ExperimentSettingsModel> GetAllSettingsByExperimentId(int id)
        {
            var settings = _dbContext.Set<ExperimentSettingsEntity>().Where(l => l.ExperimentId == id).ToList();
            return Mapper.Map<List<ExperimentSettingsEntity>, List<ExperimentSettingsModel>>(settings);
        }
    }
}
