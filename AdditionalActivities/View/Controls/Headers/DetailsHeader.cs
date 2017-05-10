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

        public DetailsHeader(TableControl parent, IPersistentObjectModel obj)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.parent = parent;

            List<ICell> cells = new List<ICell>();

            foreach (FieldModel field in obj.GetFields(false))
                cells.Add(new LabeledControlCell(field));

            this.parent.TableCells = cells;
        }

        public void DidClickCell(ICell cell)
        {
            throw new NotImplementedException();
        }
    }
}
