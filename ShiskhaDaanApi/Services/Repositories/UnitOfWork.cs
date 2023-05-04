using Data.Interfaces;
using Data.Repository;
using Database;
using Services.Interfaces;

namespace Services.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            SuperAdmins = new SetupAccountRepository(_context);
        }
        public ISetupAccountRepository SuperAdmins { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
