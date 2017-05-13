using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bsuir.PAK.PVI.DataAccessLayer.Entities.Entities;
using Bsuir.PAK.PVI.DataAccessLayer.Models.Models;

namespace Bsuir.PAK.PVI.DataAccessLayer.Repositories.Interfaces
{
    public interface ITestRepository
    {
        TestModel GetEntityById(int id);
        IList<TestModel> GetAllEntities();
        IList<TestModel> GetAllTestsByExperimentId(int id);
    }
}
