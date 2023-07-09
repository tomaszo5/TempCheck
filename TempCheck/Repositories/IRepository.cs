using AmplituderChecker;
namespace AmplituderChecker.Repositories;
 
public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T> where T : class , IEntity
{


}
