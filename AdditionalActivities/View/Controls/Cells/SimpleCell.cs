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

            this.titleLabel.Text = this.obj.GetTitle().Control.Text;
            this.detailLabel.Text = this.obj.GetSubtitle().Control.Text;
            object image = this.obj.IsParent() ? Resources.ResourceManager.GetObject("") : Resources.ResourceManager.GetObject("");
            this.pictureBox.Image = (Image)image;
        }

        private void SimpleCell_Click(object sender, EventArgs e)
        {
            parent.DidClickCell(this);
        }
    }
}
