using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.Model.Persistent;
using AdditionalActivities.Model;
using AdditionalActivities.View.Controls.Cells;
using AdditionalActivities.Controller;

namespace AdditionalActivities.View.Controls.Headers
{
    public partial class DetailsEditingHeader : UserControl, IHeader
    {
        TableControl parent;
        DatabaseObject obj;
        List<ICell> cells;

        public DetailsEditingHeader(TableControl parent, DatabaseObject obj)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            this.parent = parent;
            this.obj = obj;

            cells = new List<ICell>();

            foreach(FieldModel field in obj.GetFields(true))
                cells.Add(new LabeledControlCell(field));

            this.parent.TableCells = cells;

            //HACK: Mock
            //titlePanel.Controls.Add(obj.GetTitle(true).Control);
        }

        public void DidClickCell(ICell cell) { }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ViewMediator.Save(obj);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ViewMediator.ShowDetails(obj);
        }
    }
}
