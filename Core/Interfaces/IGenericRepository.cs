using Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    //Note that we are only interested in the Query Operations in this Repository Implementation.
    //Hence, we will only look in to the GetById and GetAll Methods here.
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        IEnumerable<T> FindWithSpecificationPattern(ISpecification<T> specification = null);
    }
}
