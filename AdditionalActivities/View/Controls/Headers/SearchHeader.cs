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

        public void DidClickCell(ICell cell)
        {
            this.parent.ShowDetails(((SimpleCell)cell).obj);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            //TODO: change parent cells to a filtered list of cells
        }

        //TODO: Filter/Order()
        //TODO: MultiSelection()
        //TODO: NavUp()
        //TODO: AddItem()
    }
}
