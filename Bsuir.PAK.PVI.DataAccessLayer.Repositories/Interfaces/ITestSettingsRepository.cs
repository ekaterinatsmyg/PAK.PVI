using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bsuir.PAK.PVI.DataAccessLayer.Models.Models;

namespace Bsuir.PAK.PVI.DataAccessLayer.Repositories.Interfaces
{
    public interface ITestSettingsRepository
    {
        TestSettingsModel GetEntityById(int id);
        IList<TestSettingsModel> GetAllEntities();
        IList<TestSettingsModel> GetAllSettingsByTestId(int id);
    }
}
