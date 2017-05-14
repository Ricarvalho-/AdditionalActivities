using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.View.Controls.FilterOrder;
using AdditionalActivities.Model;
using AdditionalActivities.View.Controls.Cells;
using AdditionalActivities.Model.Persistent;
using AdditionalActivities.Controller;

namespace AdditionalActivities.View.Controls.Headers
{
    public partial class FilterOrderHeader : UserControl, IHeader, IFilterOrder
    {
        TableControl parent;
        DatabaseObject parentObj;
        List<DatabaseObject> childrenObjs;

        public FilterOrderHeader(TableControl parent, DatabaseObject parentObj, List<DatabaseObject> childrenObjs)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            this.parent = parent;
            this.parentObj = parentObj;
            this.childrenObjs = childrenObjs;

            List<ICell> cells = new List<ICell>();

            //foreach (DatabaseObject obj in childrenObjs)
            //    cells.Add(new SimpleCell(obj, this));
            //TODO: Show first segmentedControlCell

            this.parent.TableCells = cells;
        }

        public void AddNew()
        {
            //TODO: Add new segmentedControlCell
        }

        public void Remove(IFilterOrder filterOrder)
        {
            //TODO: Remove segmentedControlCell
        }

        public FilterOrderCriteria GetCriteria()
        {
            return null;
            //UNDONE: Build filter/order criteria
        }

        public void DidClickCell(ICell cell) {
            //TODO: If in nav mode, NavInto(childObj)
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //TODO: GetCriteria(), filter childrenObjs and switch to nav mode
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ViewMediator.NavInto(parentObj);
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            //TODO: Switch to filter/order building mode if not already in
        }

        //TODO: AddItem()
        //TODO: NavUp()
        //TODO: MultiSelection()
        //TODO: BackToSimpleSearch()
        //TBD: SaveFilterOrder()
        //TBD: LoadFilterOrder()
    }
}
