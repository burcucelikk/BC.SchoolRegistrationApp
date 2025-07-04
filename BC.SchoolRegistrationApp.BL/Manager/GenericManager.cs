using AutoMapper;
using BC.SchoolRegistrationApp.BL.Service;
using BC.SchoolRegistrationApp.DAL.Abstract;
using BC.SchoolRegistrationApp.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Manager
{
    public class GenericManager<T, TDto> :IGenericService<T, TDto> where T: class, IEntity
        where TDto : class
    {
        protected readonly IMapper _mapper;
        protected readonly IUow _uow;
        public GenericManager(IUow uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public void Add(TDto dto)
        {
            var entity = _mapper.Map<T>(dto);
            _uow.GetRepository<T>().Add(entity);
            _uow.SaveChanges();
        }
        public void Delete(TDto dto) 
        {   
            var entity= _mapper.Map<T>(dto);
            _uow.GetRepository<T>().Delete(entity);
            _uow.SaveChanges();
        }
        public TDto? Get(Expression<Func<T, bool>> predicate)
        {
            var entity = _uow.GetRepository<T>().Get(predicate);
           return entity!= null ? _mapper.Map<TDto>(entity) : null;
        }
        public virtual List<TDto> GetAll(Expression<Func<T, bool>> filter = null)
        {
            var entities = _uow.GetRepository<T>().GetAll(filter);
            return _mapper.Map<List<TDto>>(entities);
        }
        public TDto? GetById(int id)
        {
            var entity = _uow.GetRepository<T>().GetById(id);
            return _mapper.Map<TDto>(entity);
        }

        public void Update(TDto dto)
        {
            var entity = _mapper.Map<T>(dto);
            _uow.GetRepository<T>().Update(entity);
            _uow.SaveChanges();
        }

    }
}
