using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.BL.Service
{
    public interface IGenericServiceDto<T, TDto, TCreateDto, TUpdateDto, TListDto, TDetailDto>
        where T : class
        where TDto : class
        where TCreateDto : class
        where TUpdateDto : class
        where TListDto : class
        where TDetailDto : class
    {
        void Add(TCreateDto createDto);
        void Update(TUpdateDto updateDto);
        void Delete(TDto dto);
        void DeleteById(int id);
        List<TListDto> GetAll(Expression<Func<T, bool>> filter = null);
        TDto? Get(Expression<Func<T, bool>> predicate);
        TDto? GetById(int id);
        TDetailDto GetDetailById(int id);
    }
}
