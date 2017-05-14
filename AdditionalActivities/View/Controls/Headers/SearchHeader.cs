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
using AdditionalActivities.Controller;
using AdditionalActivities.View.Controls.Cells;

namespace AdditionalActivities.View.Controls.Headers
{
    public partial class SearchHeader : UserControl, IHeader
    {
        TableControl parent;
        DatabaseObject parentObj;
        List<DatabaseObject> childrenObjs;

        public SearchHeader(TableControl parent, DatabaseObject parentObj, List<DatabaseObject> childrenObjs)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            this.parent = parent;
            this.parentObj = parentObj;
            this.childrenObjs = childrenObjs;

            List<ICell> cells = new List<ICell>();

            foreach (DatabaseObject obj in childrenObjs)
                cells.Add(new SimpleCell(obj, this));

            this.parent.TableCells = cells;

            titleLabel.Text = parentObj.GetTitle(false).Control.Text;
            detailLabel.Text = parentObj.GetSubtitle(false).Control.Text;
        }

        public SearchHeader(TableControl parent, Type objsType, List<DatabaseObject> objs)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            this.parent = parent;
            childrenObjs = objs;

            List<ICell> cells = new List<ICell>();

            foreach (DatabaseObject obj in childrenObjs)
                cells.Add(new SimpleCell(obj, this));

            this.parent.TableCells = cells;
            //TODO: Show objType name and detail (TBD)
            //titleLabel.Text = ;
            //detailLabel.Text = ;
            navUpButton.Hide();
        }

        public void DidClickCell(ICell cell)
        {
            //if (cell.GetObject() != null)
            ViewMediator.NavInto(cell.GetObject());
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            //TODO: show filtered objs
        }

        private void moreButton_Click(object sender, EventArgs e)
        {
            moreContextMenu.Show(moreButton, new Point(0, moreButton.Height));
        }

        private void navUpButton_Click(object sender, EventArgs e)
        {
            ViewMediator.NavUp();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(parentObj != null)
                ViewMediator.Add(parentObj.GetType());
            else
                ViewMediator.Add(null);
        }

        private void filterOrderMenuItem_Click(object sender, EventArgs e)
        {
            ViewMediator.FilterOrder(parentObj);
        }

        private void multipleSelectionMenuItem_Click(object sender, EventArgs e)
        {
            ViewMediator.MultiSelect(parentObj, childrenObjs, this);
        }
    }
}
