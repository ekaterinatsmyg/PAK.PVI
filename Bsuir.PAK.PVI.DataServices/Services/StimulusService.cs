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
    public class StimulusService : IStimulusService
    {
        private readonly IStimulusRepository _stimulusRepository;

        public StimulusService(IStimulusRepository stimulusRepository)
        {
            _stimulusRepository = stimulusRepository;
        }

        public StimulusModel GetById(int id)
        {
            return _stimulusRepository.GetById(id);
        }

        public IList<StimulusModel> GetByTestSettingsId(int id)
        {
            return _stimulusRepository.GetByTestSettingsId(id);
        }
    }
}
