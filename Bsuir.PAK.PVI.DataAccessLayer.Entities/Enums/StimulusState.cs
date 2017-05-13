using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsuir.PAK.PVI.DataAccessLayer.Entities.Enums
{
    public enum StimulusState
    {
        [Description("The range of incentives that is used by default")]
        Default,

        [Description("The range of incentives that is used as tarining session")]
        Training,

        [Description("The range of incentives that is used as homogeneous range")]
        Homogeneous,

        [Description("The range of incentives that is reproduced by user imediately after presentation")]
        ReproducedByUserAfterPresentation,

        [Description("The range of incentives that is reproduced by user  after 15 second")]
        ReproducedByUserAfterPause,

        [Description("The range of incentives that is reproduced by user  after multiply two-digi numbers")]
        ReproducedByUserAfterMultiply,

        [Description("The range of incentives that is reproduced by user  after presentation homogeneous range")]
        ReproducedByUserAfterHomogeneousRange

    }
}
