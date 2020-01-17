using System.Threading.Tasks;

namespace unitofwork.UOW
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; }
        IProductRepository Product { get; }
        Task<int> CompleteAsync();
        int Complete();
        void Dispose();
    }
}