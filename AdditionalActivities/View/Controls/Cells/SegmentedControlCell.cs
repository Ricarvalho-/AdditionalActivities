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

        public bool IsLast { get; set; }

        public SegmentedControlCell(IFilterOrder parent)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            this.parent = parent;
            IsLast = true;
            panel.Controls.Add(new FilterControl(this));
        }

        public void AddNew()
        {
            IsLast = false;
            parent.AddNew();
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

        private void filterButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new FilterControl(this));
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new OrderControl(this));
        }
    }
}
