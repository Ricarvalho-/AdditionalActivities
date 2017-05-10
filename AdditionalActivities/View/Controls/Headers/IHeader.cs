using AdditionalActivities.View.Controls.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.View.Controls.Headers
{
    public interface IHeader
    {
        void DidClickCell(ICell cell);
    }
}
