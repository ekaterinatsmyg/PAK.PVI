using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Bsuir.PAK.PVI.DataAccessLayer.Entities;
using Bsuir.PAK.PVI.DataAccessLayer.Entities.Entities;
using Bsuir.PAK.PVI.DataAccessLayer.Models.Models;
using Bsuir.PAK.PVI.DataAccessLayer.Repositories.Interfaces;
using Ninject;

namespace Bsuir.PAK.PVI.DataAccessLayer.Repositories.Repositories
{
    public class ExperimentRepository : IExperimentRepository
    {
        private readonly DbContext _dbContext;
        //private readonly ITestRepository _testRepository;

        public ExperimentRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ExperimentModel GetEntityById(int id)
        {
            var experiment = _dbContext.Set<ExperimentEntity>().FirstOrDefault(l => l.Id == id);
            var experimnetModel = Mapper.Map<ExperimentEntity, ExperimentModel>(experiment);
            return experimnetModel;
        }

        public IList<ExperimentModel> GetAllEntities()
        {
            var experiments = _dbContext.Set<ExperimentEntity>().ToList();
            return Mapper.Map<List<ExperimentEntity>, List<ExperimentModel>>(experiments);
        }
    }
}
