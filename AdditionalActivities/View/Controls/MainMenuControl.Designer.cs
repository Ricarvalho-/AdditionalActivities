namespace AdditionalActivities.View.Controls
{
    partial class MainMenuControl
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
            this.toggleSizeButton = new System.Windows.Forms.Button();
            this.studentsButton = new System.Windows.Forms.Button();
            this.rulesButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toggleSizeButton
            // 
            this.toggleSizeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.toggleSizeButton.Location = new System.Drawing.Point(0, 0);
            this.toggleSizeButton.Name = "toggleSizeButton";
            this.toggleSizeButton.Size = new System.Drawing.Size(80, 35);
            this.toggleSizeButton.TabIndex = 0;
            this.toggleSizeButton.Text = "Toggle Size";
            this.toggleSizeButton.UseVisualStyleBackColor = true;
            this.toggleSizeButton.Click += new System.EventHandler(this.toggleSizeButton_Click);
            // 
            // studentsButton
            // 
            this.studentsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentsButton.Location = new System.Drawing.Point(0, 35);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(80, 35);
            this.studentsButton.TabIndex = 1;
            this.studentsButton.Text = "Students";
            this.studentsButton.UseVisualStyleBackColor = true;
            this.studentsButton.Click += new System.EventHandler(this.studentsButton_Click);
            // 
            // rulesButton
            // 
            this.rulesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.rulesButton.Location = new System.Drawing.Point(0, 70);
            this.rulesButton.Name = "rulesButton";
            this.rulesButton.Size = new System.Drawing.Size(80, 35);
            this.rulesButton.TabIndex = 2;
            this.rulesButton.Text = "Rules";
            this.rulesButton.UseVisualStyleBackColor = true;
            this.rulesButton.Click += new System.EventHandler(this.rulesButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.helpButton.Location = new System.Drawing.Point(0, 165);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(80, 35);
            this.helpButton.TabIndex = 4;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsButton.Location = new System.Drawing.Point(0, 130);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(80, 35);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // MainMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.rulesButton);
            this.Controls.Add(this.studentsButton);
            this.Controls.Add(this.toggleSizeButton);
            this.MinimumSize = new System.Drawing.Size(80, 200);
            this.Name = "MainMenuControl";
            this.Size = new System.Drawing.Size(80, 200);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toggleSizeButton;
        private System.Windows.Forms.Button studentsButton;
        private System.Windows.Forms.Button rulesButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button settingsButton;
    }
}
