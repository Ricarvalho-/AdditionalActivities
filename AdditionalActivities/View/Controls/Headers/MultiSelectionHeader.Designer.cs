namespace AdditionalActivities.View.Controls.Headers
{
    partial class MultiSelectionHeader
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
            this.actionComboBox = new System.Windows.Forms.ComboBox();
            this.performActionButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.detailLabel = new System.Windows.Forms.Label();
            this.toggleSelectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // actionComboBox
            // 
            this.actionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionComboBox.FormattingEnabled = true;
            this.actionComboBox.Location = new System.Drawing.Point(3, 4);
            this.actionComboBox.Name = "actionComboBox";
            this.actionComboBox.Size = new System.Drawing.Size(132, 21);
            this.actionComboBox.TabIndex = 0;
            // 
            // performActionButton
            // 
            this.performActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.performActionButton.Location = new System.Drawing.Point(141, 3);
            this.performActionButton.Name = "performActionButton";
            this.performActionButton.Size = new System.Drawing.Size(75, 23);
            this.performActionButton.TabIndex = 1;
            this.performActionButton.Text = "Do";
            this.performActionButton.UseVisualStyleBackColor = true;
            this.performActionButton.Click += new System.EventHandler(this.performActionButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(222, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(4, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(23, 13);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "title";
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Location = new System.Drawing.Point(4, 49);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(32, 13);
            this.detailLabel.TabIndex = 4;
            this.detailLabel.Text = "detail";
            // 
            // toggleSelectionButton
            // 
            this.toggleSelectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleSelectionButton.Location = new System.Drawing.Point(222, 39);
            this.toggleSelectionButton.Name = "toggleSelectionButton";
            this.toggleSelectionButton.Size = new System.Drawing.Size(75, 23);
            this.toggleSelectionButton.TabIndex = 5;
            this.toggleSelectionButton.Text = "Toggle All";
            this.toggleSelectionButton.UseVisualStyleBackColor = true;
            this.toggleSelectionButton.Click += new System.EventHandler(this.toggleSelectionButton_Click);
            // 
            // MultiSelectionHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.toggleSelectionButton);
            this.Controls.Add(this.detailLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.performActionButton);
            this.Controls.Add(this.actionComboBox);
            this.MinimumSize = new System.Drawing.Size(300, 65);
            this.Name = "MultiSelectionHeader";
            this.Size = new System.Drawing.Size(300, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox actionComboBox;
        private System.Windows.Forms.Button performActionButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label detailLabel;
        private System.Windows.Forms.Button toggleSelectionButton;
    }
}
