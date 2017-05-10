namespace AdditionalActivities.View.Controls.Cells
{
    partial class SimpleCell
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.detailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox.Location = new System.Drawing.Point(149, 8);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(33, 33);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Location = new System.Drawing.Point(8, 8);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(23, 13);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "title";
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailLabel.Location = new System.Drawing.Point(8, 21);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(32, 13);
            this.detailLabel.TabIndex = 4;
            this.detailLabel.Text = "detail";
            // 
            // SimpleCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.detailLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox);
            this.Name = "SimpleCell";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(190, 49);
            this.Click += new System.EventHandler(this.SimpleCell_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label detailLabel;
    }
}
