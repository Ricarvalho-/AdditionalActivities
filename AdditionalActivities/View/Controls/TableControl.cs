using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.View.Controls.Headers;
using AdditionalActivities.View.Controls.Cells;

namespace AdditionalActivities.View.Controls
{
    public partial class TableControl : UserControl
    {
        private IHeader headerControl;
        private List<ICell> tableCells = new List<ICell>();

        public TableControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public IHeader HeaderControl
        {
            set
            {
                header.Controls.Remove((UserControl)headerControl);
                headerControl = value;
                header.Controls.Add((UserControl)value);
            }
        }

        public List<ICell> TableCells
        {
            set
            {
                tableCells = value;
                tableLayoutPanel.Controls.Clear();
                foreach (UserControl control in tableCells)
                    tableLayoutPanel.Controls.Add(control);
                foreach (RowStyle style in tableLayoutPanel.RowStyles)
                    style.SizeType = SizeType.AutoSize;
            }
        }
    }
}
