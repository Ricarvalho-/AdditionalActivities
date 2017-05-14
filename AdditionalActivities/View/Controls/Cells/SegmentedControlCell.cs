using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.View.Controls.FilterOrder;
using AdditionalActivities.Model;
using AdditionalActivities.Model.Persistent;

namespace AdditionalActivities.View.Controls.Cells
{
    public partial class SegmentedControlCell : UserControl, ICell, IFilterOrder
    {
        IFilterOrder parent;

        public SegmentedControlCell(IFilterOrder parent)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            this.parent = parent;
        }

        public void AddNew()
        {
            this.parent.AddNew();
        }

        public FilterOrderCriteria GetCriteria()
        {
            //TODO: return this.child.GetCriteria();
            throw new NotImplementedException();
        }

        public DatabaseObject GetObject()
        {
            return null;
        }

        public void Remove(IFilterOrder filterOrder)
        {
            parent.Remove(this);
        }

        //TODO: SwitchToFilter()
        //TODO: SwitchToOrder()
    }
}
