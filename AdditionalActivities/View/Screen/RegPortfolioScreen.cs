using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalActivities.View.Screen
{
    public partial class RegPortfolioScreen : UserControl, IScreen
    {
        public bool IsEditing { get; private set; }

        public RegPortfolioScreen()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
    }
}
