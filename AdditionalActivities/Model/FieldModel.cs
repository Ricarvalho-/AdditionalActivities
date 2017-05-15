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
        public string Title { get; private set; }
        public Control Control { get; private set; }
        private Func<object> ctrlGetter;
        private Action<object> propSetter;

        public FieldModel(string title, Control control, Func<object> controlGetter, Action<object> propertySetter)
        {
            ctrlGetter = controlGetter;
            propSetter = propertySetter;
            Title = title;
            Control = control;
            Control.Dock = DockStyle.Fill;
        }

        public void Save()
        {
            propSetter(ctrlGetter);
        }
    }
}
