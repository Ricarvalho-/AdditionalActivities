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

namespace AdditionalActivities.View.Controls.Cells
{
    public partial class LabeledControlCell : UserControl, ICell
    {
        public LabeledControlCell(FieldModel field)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.titleLabel.Text = field.title;
            this.panel.Controls.Add(field.control);
        }
    }
}
