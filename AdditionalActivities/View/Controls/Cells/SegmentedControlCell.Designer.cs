﻿namespace AdditionalActivities.View.Controls.Cells
{
    partial class SegmentedControlCell
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.segmentedTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.segmentedTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // segmentedTableLayout
            // 
            this.segmentedTableLayout.ColumnCount = 2;
            this.segmentedTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.segmentedTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.segmentedTableLayout.Controls.Add(this.button1, 0, 0);
            this.segmentedTableLayout.Controls.Add(this.button2, 1, 0);
            this.segmentedTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.segmentedTableLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.segmentedTableLayout.Location = new System.Drawing.Point(8, 8);
            this.segmentedTableLayout.Name = "segmentedTableLayout";
            this.segmentedTableLayout.RowCount = 1;
            this.segmentedTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.segmentedTableLayout.Size = new System.Drawing.Size(295, 29);
            this.segmentedTableLayout.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(147, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(8, 37);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(295, 87);
            this.panel.TabIndex = 1;
            // 
            // SegmentedControlCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.segmentedTableLayout);
            this.Name = "SegmentedControlCell";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(311, 132);
            this.segmentedTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel segmentedTableLayout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel;
    }
}
