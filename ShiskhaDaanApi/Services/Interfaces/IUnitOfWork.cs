using Data.Interfaces;

namespace Services.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ISetupAccountRepository SuperAdmins { get; }
        int Complete();
    }
}
