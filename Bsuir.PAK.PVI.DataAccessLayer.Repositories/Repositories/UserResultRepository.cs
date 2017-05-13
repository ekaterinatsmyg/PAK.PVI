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
    public class UserResultRepository : IUserResultRepository
    {
        private readonly DbContext _dbContext;

        public UserResultRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<ResultModel> GetResultsByUserId(int userId)
        {
            var results = _dbContext.Set<ResultsEntity>().Where(r => r.UserId == userId).ToList();
            return Mapper.Map<List<ResultsEntity>, List<ResultModel>>(results);
        }

        public IList<ResultModel> GetResultsByExperimentId(int experimentId)
        {
            var results = _dbContext.Set<ResultsEntity>().Where(r => r.ExperimentId == experimentId).ToList();
            return Mapper.Map<List<ResultsEntity>, List<ResultModel>>(results);
        }

        public IList<ResultModel> GetResultByTestId(int testId)
        {
            var results = _dbContext.Set<ResultsEntity>().Where(r => r.TestId == testId).ToList();
            return Mapper.Map<List<ResultsEntity>, List<ResultModel>>(results);
        }

        public ResultModel GetById(int id)
        {
            var result = _dbContext.Set<ResultsEntity>().FirstOrDefault(r => r.Id == id);
            return Mapper.Map<ResultsEntity, ResultModel>(result);
        }

        public int Create(ResultModel result)
        {
            throw new NotImplementedException();
        }

        public int Update(ResultModel result)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
