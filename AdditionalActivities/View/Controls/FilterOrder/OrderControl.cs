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

namespace AdditionalActivities.View.Controls.FilterOrder
{
    public partial class OrderControl : UserControl, IFilterOrder
    {
        SegmentedControlCell parent;

        public bool IsLast { get; set; }

        public OrderControl(SegmentedControlCell parent)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            this.parent = parent;
            if(!parent.IsLast)
                addRemoveButton.Text = "Remove";
        }

        public void AddNew()
        {
            addRemoveButton.Text = "Remove";
            parent.AddNew();
        }

        public FilterOrderCriteria GetCriteria()
        {
            throw new NotImplementedException();
        }

        public void Remove(IFilterOrder filterOrder)
        {
            parent.Remove(filterOrder);
        }

        private void addRemoveButton_Click(object sender, EventArgs e)
        {
            if (parent.IsLast)
                AddNew();
            else
                Remove(this);
        }

    }
}
