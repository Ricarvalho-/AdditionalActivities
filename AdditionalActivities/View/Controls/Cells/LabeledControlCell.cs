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
        FieldModel field;

        public LabeledControlCell(FieldModel field)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.titleLabel.Text = field.Title;
            this.field = field;
            this.panel.Controls.Add(field.Control);
        }

        public FieldModel Field
        {
            get
            {
                return field;
            }
        }

        public DatabaseObject GetObject()
        {
            return null;
        }
    }
}
