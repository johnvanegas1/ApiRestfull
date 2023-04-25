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
        readonly BancoDbContext _context;

        public UnitOfWork(BancoDbContext context)
        {
            _context = context;
        }

        public Task<int> SaveChange()
        {
            try
            {
                return _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
