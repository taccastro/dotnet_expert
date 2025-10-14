namespace SolidPrinciples.Isp
{
    public interface IReadOnlyRepository<T>
    {
        IEnumerable<T> GetAll(Guid id);
        T GetById(Guid id);
    }
}