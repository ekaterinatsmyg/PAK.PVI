using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsuir.PAK.PVI.DataAccessLayer.Entities.Enums
{
    public enum SettingsState
    {
        [Description("The settings that are used by default")]
        Default,
        [Description("The settings that are created by user")]
        Custom
    }
}
