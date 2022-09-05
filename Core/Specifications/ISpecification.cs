using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{

    public interface ISpecification<T>
    {
        //Criteria – This is where you can add in the expressions based on your entity.
        //Includes – If you want to include foreign keyed table data, you could add it using this method.
        //OrderBy and OrderByDescending are quite self-explanatory.
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
    }
}
