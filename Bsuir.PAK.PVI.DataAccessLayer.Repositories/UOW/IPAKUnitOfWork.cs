using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsuir.PAK.PVI.DataAccessLayer.Repositories.UOW
{
    public interface IPakUnitOfWork: IDisposable
    {
        void Commit();
    }
}
