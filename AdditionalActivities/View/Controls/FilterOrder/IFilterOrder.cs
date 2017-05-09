using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.View.Controls.FilterOrder
{
    public interface IFilterOrder
    {
        void AddNew();
        void Remove(IFilterOrder filterOrder);
        //IFilterOrderCriteria GetCriteria();
        IFilterOrder GetParent();
        void SetParent(IFilterOrder parent);
    }
}
