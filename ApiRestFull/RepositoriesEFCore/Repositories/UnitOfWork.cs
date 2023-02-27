using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoriesEFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly Context _context;

        public UnitOfWork(Context context)
        {
            _context = context;
        }

        public Task<int> SaveChange()
        {
            try
            {
                return _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
