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

namespace AdditionalActivities.View.Controls.Cells
{
    public partial class LabeledControlCell : UserControl, ICell
    {
        public FieldModel Field { get; private set; }

        public LabeledControlCell(FieldModel field)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            titleLabel.Text = field.Title;
            Field = field;
            panel.Controls.Add(field.Control);
        }

        public DatabaseObject GetObject()
        {
            return null;
        }
    }
}
