namespace AdditionalActivities.View.Controls.Headers
{
    partial class SearchHeader
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
            this.components = new System.ComponentModel.Container();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.moreButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.detailLabel = new System.Windows.Forms.Label();
            this.navUpButton = new System.Windows.Forms.Button();
            this.moreContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.filterOrderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multipleSelectionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(3, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(132, 20);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // moreButton
            // 
            this.moreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moreButton.Location = new System.Drawing.Point(141, 3);
            this.moreButton.Name = "moreButton";
            this.moreButton.Size = new System.Drawing.Size(75, 23);
            this.moreButton.TabIndex = 1;
            this.moreButton.Text = "More";
            this.moreButton.UseVisualStyleBackColor = true;
            this.moreButton.Click += new System.EventHandler(this.moreButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(222, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(4, 31);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(23, 13);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "title";
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Location = new System.Drawing.Point(4, 48);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(32, 13);
            this.detailLabel.TabIndex = 4;
            this.detailLabel.Text = "detail";
            // 
            // navUpButton
            // 
            this.navUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.navUpButton.Location = new System.Drawing.Point(222, 38);
            this.navUpButton.Name = "navUpButton";
            this.navUpButton.Size = new System.Drawing.Size(75, 23);
            this.navUpButton.TabIndex = 5;
            this.navUpButton.Text = "Nav Up";
            this.navUpButton.UseVisualStyleBackColor = true;
            this.navUpButton.Click += new System.EventHandler(this.navUpButton_Click);
            // 
            // moreContextMenu
            // 
            this.moreContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterOrderMenuItem,
            this.multipleSelectionMenuItem});
            this.moreContextMenu.Name = "moreContextMenu";
            this.moreContextMenu.ShowImageMargin = false;
            this.moreContextMenu.Size = new System.Drawing.Size(145, 48);
            // 
            // filterOrderMenuItem
            // 
            this.filterOrderMenuItem.Name = "filterOrderMenuItem";
            this.filterOrderMenuItem.Size = new System.Drawing.Size(144, 22);
            this.filterOrderMenuItem.Text = "Filter/Order";
            this.filterOrderMenuItem.Click += new System.EventHandler(this.filterOrderMenuItem_Click);
            // 
            // multipleSelectionMenuItem
            // 
            this.multipleSelectionMenuItem.Name = "multipleSelectionMenuItem";
            this.multipleSelectionMenuItem.Size = new System.Drawing.Size(144, 22);
            this.multipleSelectionMenuItem.Text = "Multiple Selection";
            this.multipleSelectionMenuItem.Click += new System.EventHandler(this.multipleSelectionMenuItem_Click);
            // 
            // SearchHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.navUpButton);
            this.Controls.Add(this.detailLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.moreButton);
            this.Controls.Add(this.searchTextBox);
            this.MinimumSize = new System.Drawing.Size(300, 65);
            this.Name = "SearchHeader";
            this.Size = new System.Drawing.Size(300, 65);
            this.moreContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button moreButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label detailLabel;
        private System.Windows.Forms.Button navUpButton;
        private System.Windows.Forms.ContextMenuStrip moreContextMenu;
        private System.Windows.Forms.ToolStripMenuItem filterOrderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multipleSelectionMenuItem;
    }
}
