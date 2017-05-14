using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.View.Controls.Cells;
using AdditionalActivities.Model.Persistent;
using AdditionalActivities.Controller;

namespace AdditionalActivities.View.Controls.Headers
{
    public partial class MultiSelectionHeader : UserControl, IHeader
    {
        TableControl parent;
        DatabaseObject parentObj;
        List<DatabaseObject> childrenObjs;
        List<DatabaseObject> selectedObjs = new List<DatabaseObject>();
        IHeader previousHeader;
        ActionType[] actions;

        public MultiSelectionHeader(TableControl parent, DatabaseObject parentObj, List<DatabaseObject> childrenObjs, List<ActionType> actions, IHeader previousHeader)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            this.parent = parent;
            this.parentObj = parentObj;
            this.childrenObjs = childrenObjs;
            this.previousHeader = previousHeader;

            List<ICell> cells = new List<ICell>();

            foreach (DatabaseObject obj in childrenObjs)
                cells.Add(new SimpleCell(obj, this));//UNDONE: SimpleCell with checkbox image

            this.parent.TableCells = cells;

            this.actions = actions.ToArray();
            actionComboBox.Items.AddRange(this.actions);
        }

        public void DidClickCell(ICell cell)
        {
            //TODO: Add/remove to/from selectedObjs and show/hide cell checkmark
        }

        private void toggleSelectionButton_Click(object sender, EventArgs e)
        {
            //TODO: Select/Deselect all
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ViewMediator.ExitMultiSelect(parentObj, previousHeader);
        }

        private void performActionButton_Click(object sender, EventArgs e)
        {
            ViewMediator.PerformMultiItemAction(parentObj, childrenObjs, previousHeader, selectedObjs, actions[actionComboBox.SelectedIndex]);
        }
    }
}
