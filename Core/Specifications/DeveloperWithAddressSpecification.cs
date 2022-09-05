using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    //Another specification that returns a list of developers with an experience of N or above along with their addresses.
    public class DeveloperWithAddressSpecification : BaseSpecifcation<Developer>
    {
        public DeveloperWithAddressSpecification(int years) : base(x => x.EstimatedIncome > years)
        {
            AddInclude(x => x.Address);
        }
    }
}
