using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalActivities.Model
{
    public class FieldModel
    {
        public string title;
        public Control control;
        public Enum prop;

        public FieldModel(Enum prop, string title, Control control)
        {
            this.prop = prop;
            this.title = title;
            this.control = control;
            this.control.Dock = DockStyle.Fill;
        }
    }
}
