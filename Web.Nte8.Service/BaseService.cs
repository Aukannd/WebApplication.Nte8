using AutoMapper;
using Test.net8.IService;
using Test.net8.Model;
using Test.net8.Repository.Base;
using Web.Nte8.Repository.Base;

namespace Test.net8.Service
{
    //依赖项有哪些
    public class BaseService<TEntity, TVo> : IBaseService<TEntity, TVo> where TEntity : class,new()
    {
        private readonly IMapper _mapper;
        private readonly IBaserepository<TEntity> _baseRepository;

        public BaseService(IMapper mapper, IBaserepository<TEntity> baseRepository)
        {
            _mapper = mapper;
            _baseRepository = baseRepository;
        }

        /// <summary>
        ///查询，方法，
        /// </summary>
        /// <returns></returns>
        public async Task<List<TVo>>Query()
        {
            var entities = await _baseRepository.Query();
            var llout = _mapper.Map<List<TVo>>(entities);
            return llout;


        }
    }
}
