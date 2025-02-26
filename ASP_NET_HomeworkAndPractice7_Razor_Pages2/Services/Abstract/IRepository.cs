namespace ASP_NET_HomeworkAndPractice7_Razor_Pages2.Services.Abstract
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T Create(T entity);
    }
}
