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
    public partial class DetailsHeader : UserControl, IHeader
    {
        TableControl parent;
        IPersistentObjectModel obj;

        public DetailsHeader(TableControl parent, IPersistentObjectModel obj)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.parent = parent;
            this.obj = obj;
            this.titleLabel.Text = obj.GetTitle();

            List<ICell> cells = new List<ICell>();

            foreach (FieldModel field in obj.GetFields(false))
                cells.Add(new LabeledControlCell(field));

            this.parent.TableCells = cells;
        }

        public void DidClickCell(ICell cell) { }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.parent.SetHeader(new DetailsEditingHeader(this.parent, obj));
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void moreButton_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.ShowImageMargin = false;
            //foreach(action in obj.actions)
            //  menu.Items.Add(action.label, null, action.Action);
            menu.Show(moreButton, new Point(0, moreButton.Height));
        }
    }
}
