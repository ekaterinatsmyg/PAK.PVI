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
    public class StimulusRepository : IStimulusRepository
    {
        private readonly DbContext _dbContext;

        public StimulusRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public StimulusModel GetById(int id)
        {
            var stimulus = _dbContext.Set<StimulusEntity>().FirstOrDefault(s => s.Id == id);
            return Mapper.Map<StimulusEntity, StimulusModel>(stimulus);

        }

        public IList<StimulusModel> GetByTestSettingsId(int id)
        {
            var stimuluses = _dbContext.Set<StimulusEntity>().Where(s => s.TestSettingsId == id).ToList();
            return Mapper.Map<List<StimulusEntity>, List<StimulusModel>>(stimuluses);
        }
    }
}
