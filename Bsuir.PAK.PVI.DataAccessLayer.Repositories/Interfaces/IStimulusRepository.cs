using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bsuir.PAK.PVI.DataAccessLayer.Models.Models;

namespace Bsuir.PAK.PVI.DataAccessLayer.Repositories.Interfaces
{
    public interface IStimulusRepository
    {
        StimulusModel GetById(int id);
        IList<StimulusModel> GetByTestSettingsId(int id);
    }
}
