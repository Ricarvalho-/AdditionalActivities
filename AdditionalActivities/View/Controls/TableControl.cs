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
using AdditionalActivities.Model.Persistent;

namespace AdditionalActivities.View.Controls
{
    public partial class TableControl : UserControl
    {
        UserControl headerControl;
        MainForm parent;
        private List<ICell> tableCells = new List<ICell>();

        public TableControl(MainForm parent)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.parent = parent;
        }

        public List<ICell> TableCells
        {
            set
            {
                tableCells = value;
                this.tableLayoutPanel.Controls.Clear();
                foreach (UserControl control in tableCells)
                    this.tableLayoutPanel.Controls.Add(control);
            }
        }

        public void SetHeader(IHeader header)
        {
            this.header.Controls.Remove(this.headerControl);
            this.headerControl = (UserControl)header;
            this.header.Controls.Add(this.headerControl);
        }

        public void ShowDetails(IPersistentObjectModel obj)
        {
            this.parent.showDetails(obj);
        }
    }
}
