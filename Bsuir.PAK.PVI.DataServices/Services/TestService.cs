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
    public class TestService: ITestService
    {
        private readonly ITestRepository _testRepository;

        public TestService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }
        public TestModel GetTestById(int id)
        {
            return _testRepository.GetEntityById(id);
        }

        public IList<TestModel> GetAllTests()
        {
            return _testRepository.GetAllEntities();
        }

        public IList<TestModel> GetAllTestsByExperimentId(int id)
        {
            return _testRepository.GetAllTestsByExperimentId(id);
        }
    }
}
