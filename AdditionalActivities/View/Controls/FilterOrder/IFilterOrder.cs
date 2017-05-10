using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalActivities.Model;

namespace AdditionalActivities.View.Controls.FilterOrder
{
    public interface IFilterOrder
    {
        void AddNew();
        void Remove(IFilterOrder filterOrder);
        FilterOrderCriteria GetCriteria();
    }
}
