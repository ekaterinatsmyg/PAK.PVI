using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsuir.PAK.PVI.DataAccessLayer.Repositories.UOW
{
    public class PakUnitOfWork: IPakUnitOfWork
    {
        public DbContext Context { get; }

        public PakUnitOfWork(DbContext context)
        {
            Context = context;
        }

        public void Commit()
        {
            Context?.SaveChanges();
        }

        public void Dispose()
        {
            Context?.Dispose();
        }
    }
}
