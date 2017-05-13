using System.Collections.Generic;
using Bsuir.PAK.PVI.DataAccessLayer.Models.Models;

namespace Bsuir.PAK.PVI.DataAccessLayer.Repositories.Interfaces
{
    public interface IExperimentRepository
    {
        ExperimentModel GetEntityById(int id);
        IList<ExperimentModel> GetAllEntities();
    }
}
