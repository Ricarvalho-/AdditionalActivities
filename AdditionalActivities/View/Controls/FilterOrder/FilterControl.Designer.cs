namespace AdditionalActivities.View.Controls.FilterOrder
{
    partial class FilterControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.propertyComboBox = new System.Windows.Forms.ComboBox();
            this.criteriaComboBox = new System.Windows.Forms.ComboBox();
            this.parameterTextBox = new System.Windows.Forms.TextBox();
            this.addRemoveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.propertyComboBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.criteriaComboBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 27);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // propertyComboBox
            // 
            this.propertyComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.propertyComboBox.FormattingEnabled = true;
            this.propertyComboBox.Location = new System.Drawing.Point(3, 3);
            this.propertyComboBox.Name = "propertyComboBox";
            this.propertyComboBox.Size = new System.Drawing.Size(84, 21);
            this.propertyComboBox.TabIndex = 0;
            // 
            // criteriaComboBox
            // 
            this.criteriaComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.criteriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.criteriaComboBox.FormattingEnabled = true;
            this.criteriaComboBox.Location = new System.Drawing.Point(93, 3);
            this.criteriaComboBox.Name = "criteriaComboBox";
            this.criteriaComboBox.Size = new System.Drawing.Size(84, 21);
            this.criteriaComboBox.TabIndex = 1;
            // 
            // parameterTextBox
            // 
            this.parameterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parameterTextBox.Location = new System.Drawing.Point(3, 30);
            this.parameterTextBox.Name = "parameterTextBox";
            this.parameterTextBox.Size = new System.Drawing.Size(94, 20);
            this.parameterTextBox.TabIndex = 2;
            // 
            // addRemoveButton
            // 
            this.addRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addRemoveButton.Location = new System.Drawing.Point(103, 29);
            this.addRemoveButton.Name = "addRemoveButton";
            this.addRemoveButton.Size = new System.Drawing.Size(75, 22);
            this.addRemoveButton.TabIndex = 3;
            this.addRemoveButton.Text = "Add";
            this.addRemoveButton.UseVisualStyleBackColor = true;
            this.addRemoveButton.Click += new System.EventHandler(this.addRemoveButton_Click);
            // 
            // FilterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.addRemoveButton);
            this.Controls.Add(this.parameterTextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(180, 54);
            this.Name = "FilterControl";
            this.Size = new System.Drawing.Size(180, 54);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox propertyComboBox;
        private System.Windows.Forms.ComboBox criteriaComboBox;
        private System.Windows.Forms.TextBox parameterTextBox;
        private System.Windows.Forms.Button addRemoveButton;
    }
}
