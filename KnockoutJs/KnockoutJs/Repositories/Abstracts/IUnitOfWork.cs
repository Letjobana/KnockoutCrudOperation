namespace KnockoutJs.Repositories.Abstracts
{
    public interface IUnitOfWork
    {
        IApiRepository ApiRepository { get; }
    }
}
