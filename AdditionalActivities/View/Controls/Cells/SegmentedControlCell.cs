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

namespace AdditionalActivities.View.Controls.Cells
{
    public partial class SegmentedControlCell : UserControl, ICell, IFilterOrder
    {
        IFilterOrder parent;

        public SegmentedControlCell(IFilterOrder parent)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.parent = parent;
        }

        public void AddNew()
        {
            this.parent.AddNew();
        }

        public FilterOrderCriteria GetCriteria()
        {
            //return this.child.GetCriteria();
            throw new NotImplementedException();
        }

        public void Remove(IFilterOrder filterOrder)
        {
            parent.Remove(filterOrder);//TBD: Or this
        }

        //TODO: SwitchToFilter()
        //TODO: SwitchToOrder()
    }
}
