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
        IPersistentObjectModel obj;

        public SearchHeader(TableControl parent, PersistentObjectModelType objectType)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.parent = parent;

            List<ICell> cells = new List<ICell>();

            foreach (IPersistentObjectModel obj in ModelMediator.ReadAll(objectType))
                cells.Add(new SimpleCell(obj, this));

            this.parent.TableCells = cells;
        }

        public SearchHeader(TableControl parent, IPersistentObjectModel obj)//TODO: change to stack<obj>
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.parent = parent;
            this.obj = obj;

            List<ICell> cells = new List<ICell>();

            foreach (IPersistentObjectModel child in ModelMediator.ReadChildren(obj))
                cells.Add(new SimpleCell(obj, this));

            this.parent.TableCells = cells;
        }

        public void DidClickCell(ICell cell)
        {
            if (obj != null && obj.IsParent())
                this.parent.ShowNavigation(((SimpleCell)cell).obj);
            this.parent.ShowDetails(((SimpleCell)cell).obj);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void moreButton_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.ShowImageMargin = false;
            menu.Items.Add("Filter/Order", null, FilterOrder);
            menu.Items.Add("Multi Selection", null, MultiSelection);
            menu.Show(moreButton, new Point(0, moreButton.Height));
        }

        private void MultiSelection(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FilterOrder(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void navUpButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.parent.NewDetails(new Model.Persistent.Rule("", "", 0, 0).GetObjectModelType());//FIXME
        }
    }
}
