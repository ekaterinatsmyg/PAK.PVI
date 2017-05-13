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
    public class UserResultService : IUserResultService
    {
        private readonly IUserResultRepository _userResultRepository;

        public UserResultService(IUserResultRepository userResultRepository)
        {
            _userResultRepository = userResultRepository;
        }
        public IList<ResultModel> GetResultsByUserId(int userId)
        {
            return _userResultRepository.GetResultsByUserId(userId);
        }

        public IList<ResultModel> GetResultsByExperimentId(int experimentId)
        {
            return _userResultRepository.GetResultsByExperimentId(experimentId);
        }

        public IList<ResultModel> GetResultByTestId(int testId)
        {
            return _userResultRepository.GetResultByTestId(testId);
        }

        public ResultModel GetById(int id)
        {
            return _userResultRepository.GetById(id);
        }

        public int Create(ResultModel result)
        {
            return _userResultRepository.Create(result);
        }

        public int Update(ResultModel result)
        {
            return _userResultRepository.Update(result);
        }

        public bool Delete(int id)
        {
            return _userResultRepository.Delete(id);
        }
    }
}
