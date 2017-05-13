using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bsuir.PAK.PVI.DataServices.Interfaces;
using Newtonsoft.Json;

namespace Bsuir.PAK.PVI.WebAPI.Controllers
{
    public class TestSettingsController : ApiController
    {

        private readonly ITestSettingsService _testSettingsService;
        private readonly IStimulusService _stimulusService;

        public TestSettingsController(ITestSettingsService testSettingsService, IStimulusService stimulusService)
        {
            _stimulusService = stimulusService;
            _testSettingsService = testSettingsService;
        }

        // GET: api/TestSettings/5
        [HttpGet]
        public string Get(int id)
        {
            var setting = _testSettingsService.GetEntityById(id);
            return JsonConvert.SerializeObject(setting);
        }

        [HttpGet]
        [Route("api/test/{id:int?}/settings/stimulus")]
        public string GetStimulus(int id)
        {
            var stimulus = _stimulusService.GetByTestSettingsId(id);
            return JsonConvert.SerializeObject(stimulus);
        }

        // POST: api/TestSettings
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TestSettings/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TestSettings/5
        public void Delete(int id)
        {
        }
    }
}
