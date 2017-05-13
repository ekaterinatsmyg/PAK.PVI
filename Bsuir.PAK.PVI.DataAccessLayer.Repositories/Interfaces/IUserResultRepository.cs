using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bsuir.PAK.PVI.DataAccessLayer.Models.Models;

namespace Bsuir.PAK.PVI.DataAccessLayer.Repositories.Interfaces
{
    public interface IUserResultRepository
    {
        IList<ResultModel> GetResultsByUserId(int userId);
        IList<ResultModel> GetResultsByExperimentId(int experimentId);
        IList<ResultModel> GetResultByTestId(int testId);
        ResultModel GetById(int id);
        int Create(ResultModel result);
        int Update(ResultModel result);
        bool Delete(int id);
    }
}
