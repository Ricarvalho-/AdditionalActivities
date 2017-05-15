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
using AdditionalActivities.Properties;
using AdditionalActivities.View.Controls.Headers;

namespace AdditionalActivities.View.Controls.Cells
{
    public partial class SimpleCell : UserControl, ICell
    {
        IHeader parent;
        public DatabaseObject obj;

        public SimpleCell(DatabaseObject obj, IHeader parent)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.parent = parent;
            this.obj = obj;

            titleLabel.Text = this.obj.GetTitle(false).Control.Text;
            detailLabel.Text = this.obj.GetSubtitle(false).Control.Text;
            object image = this.obj.IsParent ? Resources.ResourceManager.GetObject("") : Resources.ResourceManager.GetObject(""); //UNDONE: Set images
            pictureBox.Image = (Image)image;
        }

        private void SimpleCell_Click(object sender, EventArgs e)
        {
            parent.DidClickCell(this);
        }

        public DatabaseObject GetObject()
        {
            return obj;
        }
    }
}
