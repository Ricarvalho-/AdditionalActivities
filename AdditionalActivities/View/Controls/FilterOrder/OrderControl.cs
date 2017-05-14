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
        IFilterOrder parent;

        public OrderControl(IFilterOrder parent)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.parent = parent;
        }

        public void AddNew()
        {
            parent.AddNew();
        }

        public FilterOrderCriteria GetCriteria()
        {
            throw new NotImplementedException();
        }

        public void Remove(IFilterOrder filterOrder)
        {
            this.parent.Remove(this);
        }
    }
}
