using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bsuir.PAK.PVI.DataServices.Interfaces;

namespace Bsuir.PAK.PVI.WebAPI.Controllers
{
    public class TestController : ApiController
    {
        private readonly ITestService _testService;
        private readonly ITestSettingsService _testSettingsService;

        public TestController(ITestService testService, ITestSettingsService testSettingsService)
        {
            _testService = testService;
            _testSettingsService = testSettingsService;
        }
        

       [HttpGet]
        public string Get(int id)
        {
            var test = _testService.GetTestById(id);
            return Newtonsoft.Json.JsonConvert.SerializeObject(test);
        }

        [HttpGet]
        [Route("api/test/{id:int?}/settings")]
        public string GetSettings(int? id)
        {
            if (id != null)
            {
                var settings = _testSettingsService.GetAllSettingsByTestId(id.Value);
                return Newtonsoft.Json.JsonConvert.SerializeObject(settings);
            }
            return String.Empty;
        }

        // POST: api/Test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }
    }
}
