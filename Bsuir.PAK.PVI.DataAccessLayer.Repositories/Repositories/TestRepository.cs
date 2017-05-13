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
    public class TestRepository: ITestRepository
    {
        private readonly DbContext _dbContext;

        public TestRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TestModel GetEntityById(int id)
        {
            var test = _dbContext.Set<TestEntity>().FirstOrDefault(l => l.Id == id);
            return Mapper.Map<TestEntity, TestModel>(test); 
        }

        public IList<TestModel> GetAllEntities()
        {
            var tests = _dbContext.Set<TestEntity>().ToList();
            return new List<TestModel>();
        }

        public IList<TestModel> GetAllTestsByExperimentId(int id)
        {
            var tests = _dbContext.Set<TestEntity>().Where(l => l.ExperimentId == id).ToList();
            return Mapper.Map<List<TestEntity>, List<TestModel>>(tests);
        }
    }
}
