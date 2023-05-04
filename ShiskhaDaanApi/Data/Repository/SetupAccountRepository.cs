using Data.Interfaces;
using Database;
using Entity;

namespace Data.Repository
{
    public class SetupAccountRepository : GenericRepository<SetupAccount>, ISetupAccountRepository
    {
        public SetupAccountRepository(ApplicationContext context) : base(context)
        {
        }
        public IEnumerable<SetupAccount> postSuperAdmin()
        {
            return _context.SuperAdmins.OrderByDescending(x => x.Id).ToList();
        }
    }
}
