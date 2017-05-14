using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalActivities.Model.Persistent;

namespace AdditionalActivities.View.Controls.Cells
{
    public interface ICell
    {
        DatabaseObject GetObject();
    }
}
