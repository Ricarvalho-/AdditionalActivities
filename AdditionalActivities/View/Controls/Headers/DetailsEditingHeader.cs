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

namespace AdditionalActivities.View.Controls.Headers
{
    public partial class DetailsEditingHeader : UserControl, IHeader
    {
        TableControl parent;
        IPersistentObjectModel obj;

        public DetailsEditingHeader(TableControl parent, IPersistentObjectModel obj)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.parent = parent;
            this.obj = obj;
            this.titleTextBox.Text = obj.GetTitle();

            List<ICell> cells = new List<ICell>();

            foreach(FieldModel field in obj.GetFields(true))
                cells.Add(new LabeledControlCell(field));

            this.parent.TableCells = cells;
        }

        public void DidClickCell(ICell cell)
        {
            throw new NotImplementedException();
        }

        //TODO: Save()
        //TODO: Cancel()
    }
}
