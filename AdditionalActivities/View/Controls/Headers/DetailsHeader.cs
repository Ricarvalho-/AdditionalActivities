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
    public partial class DetailsHeader : UserControl, IHeader
    {
        TableControl parent;
        DatabaseObject obj;

        public DetailsHeader(TableControl parent, DatabaseObject obj)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            this.parent = parent;
            this.obj = obj;

            foreach (ActionType action in obj.Actions)
                actionsContextMenu.Items.Add(action.Label, null, action.ActionHandler);

            List<ICell> cells = new List<ICell>();

            foreach (FieldModel field in obj.GetFields(false))
                cells.Add(new LabeledControlCell(field));

            this.parent.TableCells = cells;

            titleLabel.Text = obj.GetTitle(false).Control.Text;
        }

        public DetailsHeader(TableControl parent, Type objType)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            this.parent = parent;

            List<ICell> cells = new List<ICell>();

            //TODO: Get obj type details (TBD)

            this.parent.TableCells = cells;

            titleLabel.Hide();//UNDONE: Get obj type title or hide (TBD)
            deleteButton.Hide();
            editButton.Hide();
            moreButton.Hide();
        }

        public void DidClickCell(ICell cell) { }

        private void editButton_Click(object sender, EventArgs e)
        {
            ViewMediator.EditDetails(obj);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ViewMediator.Delete(obj);
        }

        private void moreButton_Click(object sender, EventArgs e)
        {
            actionsContextMenu.Show(moreButton, new Point(0, moreButton.Height));
        }
    }
}
