using Test.net8.Model;

namespace Web.Nte8.Repository.Base
{
    public interface IBaserepository<TEntity> where TEntity : class
    {
        //  泛型基类接口
        public Task<List<TEntity>> Query();
    }

}
