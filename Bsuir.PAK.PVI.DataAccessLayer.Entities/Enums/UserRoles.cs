using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsuir.PAK.PVI.DataAccessLayer.Entities.Enums
{
    public enum UserRoles
    {
        [Description ("Some functionality is available")]
        Student,
        [Description("All functionality is available")]
        Admin
    }
}
