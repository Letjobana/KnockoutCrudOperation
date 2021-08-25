using KnockoutJs.Repositories.Abstracts;

namespace KnockoutJs.Repositories.Descretes
{
    public class UnitOfWork : IUnitOfWork
    {
        public IApiRepository ApiRepository { get; private set; }
        public UnitOfWork()
        {
            ApiRepository = new ApiRepository();
        }
    }
}
