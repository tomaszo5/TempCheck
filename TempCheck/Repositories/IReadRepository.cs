using AmplituderChecker.Entities;
 
namespace AmplituderChecker.Repositories
{
    public interface IReadRepository<out T> where T : class, IEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);


    }
}
