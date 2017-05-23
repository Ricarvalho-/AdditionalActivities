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

namespace AdditionalActivities.View.Controls.FilterOrder
{
    public partial class FilterOrderTableControl : UserControl, IFilterOrder
    {
        //public IFilterOrderDelegate Delegate { get; set; }
        List<SegmentedControlCell> segmentedCells = new List<SegmentedControlCell>();
        private bool IsLast { get; set; }

        public FilterOrderTableControl()//IFilterOrderDelegate foDelegate)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            SegmentedCells.Add(new SegmentedControlCell(this));
            SegmentedCells = segmentedCells;
        }

        public List<SegmentedControlCell> SegmentedCells
        {
            get
            {
                return segmentedCells;
            }
            set
            {
                segmentedCells = value;
                tableLayoutPanel.Controls.Clear();
                foreach (SegmentedControlCell cell in segmentedCells)
                    tableLayoutPanel.Controls.Add(cell);
                foreach (RowStyle style in tableLayoutPanel.RowStyles)
                    style.SizeType = SizeType.AutoSize;
            }
        }
        
        public void AddNew()
        {
            segmentedCells.Add(new SegmentedControlCell(this));
            SegmentedCells = segmentedCells;
        }

        public void Remove(IFilterOrder filterOrder)
        {
            segmentedCells.Remove((SegmentedControlCell)filterOrder);
            SegmentedCells = segmentedCells;
        }

        FilterOrderCriteria IFilterOrder.GetCriteria()
        {
            throw new NotImplementedException();
        }
    }
}
