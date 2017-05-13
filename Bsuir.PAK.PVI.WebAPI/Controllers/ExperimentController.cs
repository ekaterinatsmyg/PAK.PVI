using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Http;
using Bsuir.PAK.PVI.DataAccessLayer.Models.Models;
using Bsuir.PAK.PVI.DataServices.Interfaces;
using Newtonsoft.Json;

namespace Bsuir.PAK.PVI.WebAPI.Controllers
{
    public class ExperimentController : ApiController
    {
        private readonly IExperimentService _experimentService;
        private readonly ITestService _testService;
        private readonly IExperimentSettingsService _experimentSettingsService;

        public ExperimentController(IExperimentService experimentService, ITestService testService, IExperimentSettingsService experimentSettingsService)
        {
            _experimentService = experimentService;
            _testService = testService;
            _experimentSettingsService = experimentSettingsService;
        }

        [HttpGet]
        [Route("api/experiment/{id:int}")]
        public string Get(int id)
        {
            var experiment = _experimentService.GetExperimentById(id);
            return JsonConvert.SerializeObject(experiment);
        }

        [HttpGet]
        [Route("api/experiment")]
        public string Get()
        {
            var experiments = _experimentService.GetAllExperiments(); 
            return JsonConvert.SerializeObject(experiments);
        }

        [HttpGet]
        [Route("api/experiment/{id:int?}/tests")]
        public string GetTests(int? id)
        {
            if (id != null)
            {
                var tests = _testService.GetAllTestsByExperimentId(id.Value);
                return JsonConvert.SerializeObject(tests);
            }

            var allTests = _testService.GetAllTests();
            return JsonConvert.SerializeObject(allTests);
        }


        [HttpGet]
        [Route("api/experiment/{id:int?}/settings")]
        public string GetSettings(int? id)
        {
            if (id != null)
            {
                var settings = _experimentSettingsService.GetAllSettingsByExperimentId(id.Value);
                return JsonConvert.SerializeObject(settings);
            }
            return String.Empty;
        }

        // POST: api/Experiment
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Experiment/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Experiment/5
        public void Delete(int id)
        {
        }
    }
}
