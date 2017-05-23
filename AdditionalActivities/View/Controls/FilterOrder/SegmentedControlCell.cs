using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.Model;
using AdditionalActivities.Model.Persistent;

namespace AdditionalActivities.View.Controls.FilterOrder
{
    public partial class SegmentedControlCell : UserControl, IFilterOrder
    {
        IFilterOrder parent;

        public bool IsLast { get; set; }

        public SegmentedControlCell(IFilterOrder parent)
        {
            InitializeComponent();
            Dock = DockStyle.Top;
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
