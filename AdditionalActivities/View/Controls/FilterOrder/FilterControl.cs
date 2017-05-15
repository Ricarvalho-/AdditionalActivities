using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalActivities.Model;
using AdditionalActivities.Model.Persistent;

namespace AdditionalActivities.View.Controls.FilterOrder
{
    public partial class FilterControl : UserControl, IFilterOrder
    {
        IFilterOrder parent;

        public FilterControl(IFilterOrder parent)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.parent = parent;
        }

        public void AddNew()
        {
            parent.AddNew();
        }

        public FilterOrderCriteria GetCriteria()
        {//FIXME:
            if (((Property)propertyComboBox.SelectedItem).Type == Property.PropertyType.Numeric)
                return new NumericFilterCriteriaType((Property)propertyComboBox.SelectedItem, (NumericFilterCriteriaType.NumericFilterCriteria)criteriaComboBox.SelectedItem, decimal.Parse(parameterTextBox.Text));//TODO: TryParse
            else if (((Property)propertyComboBox.SelectedItem).Type == Property.PropertyType.Textual)
                return new TextualFilterCriteriaType((Property)propertyComboBox.SelectedItem, (TextualFilterCriteriaType.TextualFilterCriteria)criteriaComboBox.SelectedItem, parameterTextBox.Text);
            throw new NotImplementedException();
        }

        public void Remove(IFilterOrder filterOrder)
        {
            parent.Remove(this);
        }
    }
}
