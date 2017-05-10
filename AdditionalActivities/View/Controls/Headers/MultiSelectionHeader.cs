using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.View.Controls.Cells;

namespace AdditionalActivities.View.Controls.Headers
{
    public partial class MultiSelectionHeader : UserControl, IHeader
    {
        public MultiSelectionHeader()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public void DidClickCell(ICell cell)
        {
            throw new NotImplementedException();
        }
    }
}
