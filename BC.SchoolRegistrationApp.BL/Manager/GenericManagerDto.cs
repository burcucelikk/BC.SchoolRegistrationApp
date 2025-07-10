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
    public class GenericManagerDto<T, TDto, TCreateDto, TUpdateDto, TListDto, TDetailDto>
        : IGenericServiceDto<T, TDto, TCreateDto, TUpdateDto, TListDto, TDetailDto>
        where T : class, IEntity
        where TDto : class
        where TCreateDto : class
        where TUpdateDto : class
        where TListDto : class
        where TDetailDto : class
    {
        private readonly IMapper _mapper;
        private readonly IUow _uow;

        public GenericManagerDto(IUow uow, IMapper mapper)
        {
            _mapper = mapper;
            _uow = uow;
        }

        public void Add(TCreateDto createDto)
        {
            var entity = _mapper.Map<T>(createDto);
            _uow.GetRepository<T>().Add(entity);
            _uow.SaveChanges();
        }

        public void Update(TUpdateDto updateDto)
        {
            var idProp = typeof(TUpdateDto).GetProperty("Id");
            var idValue = (int)idProp.GetValue(updateDto);
            var entity = _uow.GetRepository<T>().GetById(idValue);
            _mapper.Map(updateDto, entity);
            _uow.GetRepository<T>().Update(entity);
            _uow.SaveChanges();
        }

        public void Delete(TDto tDto)
        {
            var idProp = typeof(TDto).GetProperty("Id");
            var idValue = (int)idProp.GetValue(tDto);
            var entity = _uow.GetRepository<T>().GetById(idValue);
            _mapper.Map(tDto, entity);
            _uow.GetRepository<T>().Delete(entity);
            _uow.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var entity = _uow.GetRepository<T>().GetById(id);
            if (entity != null)
            {
                _uow.GetRepository<T>().Delete(entity);
                _uow.SaveChanges();
            }
        }

        public List<TListDto> GetAll(Expression<Func<T, bool>> filter = null)
        {
            var entities = _uow.GetRepository<T>().GetAll(filter);
            return _mapper.Map<List<TListDto>>(entities);
        }

        public TDto? Get(Expression<Func<T, bool>> predicate)
        {
            var entity = _uow.GetRepository<T>().Get(predicate);
            return entity != null ? _mapper.Map<TDto>(entity) : null;
        }

        public TDto GetById(int id)
        {
            var entity = _uow.GetRepository<T>().GetById(id);
            return _mapper.Map<TDto>(entity);
        }

        public TDetailDto GetDetailById(int id)
        {
            var entity = _uow.GetRepository<T>().GetById(id);
            return _mapper.Map<TDetailDto>(entity);
        }
    }
}
