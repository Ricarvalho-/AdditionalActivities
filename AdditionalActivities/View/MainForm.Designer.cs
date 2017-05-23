namespace AdditionalActivities.View
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.studentsButton = new System.Windows.Forms.Button();
            this.activityPortfoliosButton = new System.Windows.Forms.Button();
            this.activityItemsButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.activitiesButton = new System.Windows.Forms.Button();
            this.rulesButton = new System.Windows.Forms.Button();
            this.coursesButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.mainMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainMenuPanel.Controls.Add(this.studentsButton);
            this.mainMenuPanel.Controls.Add(this.activityPortfoliosButton);
            this.mainMenuPanel.Controls.Add(this.activityItemsButton);
            this.mainMenuPanel.Controls.Add(this.settingsButton);
            this.mainMenuPanel.Controls.Add(this.activitiesButton);
            this.mainMenuPanel.Controls.Add(this.rulesButton);
            this.mainMenuPanel.Controls.Add(this.coursesButton);
            this.mainMenuPanel.Controls.Add(this.dashboardButton);
            this.mainMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(86, 261);
            this.mainMenuPanel.TabIndex = 1;
            // 
            // studentsButton
            // 
            this.studentsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.studentsButton.Location = new System.Drawing.Point(0, 167);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(84, 23);
            this.studentsButton.TabIndex = 4;
            this.studentsButton.Text = "Alunos";
            this.studentsButton.UseVisualStyleBackColor = true;
            this.studentsButton.Click += new System.EventHandler(this.studentsButton_Click);
            // 
            // activityPortfoliosButton
            // 
            this.activityPortfoliosButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.activityPortfoliosButton.Location = new System.Drawing.Point(0, 190);
            this.activityPortfoliosButton.Name = "activityPortfoliosButton";
            this.activityPortfoliosButton.Size = new System.Drawing.Size(84, 23);
            this.activityPortfoliosButton.TabIndex = 5;
            this.activityPortfoliosButton.Text = "Portifólios";
            this.activityPortfoliosButton.UseVisualStyleBackColor = true;
            this.activityPortfoliosButton.Click += new System.EventHandler(this.activityPortfoliosButton_Click);
            // 
            // activityItemsButton
            // 
            this.activityItemsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.activityItemsButton.Location = new System.Drawing.Point(0, 213);
            this.activityItemsButton.Name = "activityItemsButton";
            this.activityItemsButton.Size = new System.Drawing.Size(84, 23);
            this.activityItemsButton.TabIndex = 6;
            this.activityItemsButton.Text = "Atividades";
            this.activityItemsButton.UseVisualStyleBackColor = true;
            this.activityItemsButton.Click += new System.EventHandler(this.activityItemsButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsButton.Location = new System.Drawing.Point(0, 236);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(84, 23);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.Text = "Configurações";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // activitiesButton
            // 
            this.activitiesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.activitiesButton.Location = new System.Drawing.Point(0, 69);
            this.activitiesButton.Name = "activitiesButton";
            this.activitiesButton.Size = new System.Drawing.Size(84, 23);
            this.activitiesButton.TabIndex = 3;
            this.activitiesButton.Text = "Itens";
            this.activitiesButton.UseVisualStyleBackColor = true;
            this.activitiesButton.Click += new System.EventHandler(this.activitiesButton_Click);
            // 
            // rulesButton
            // 
            this.rulesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.rulesButton.Location = new System.Drawing.Point(0, 46);
            this.rulesButton.Name = "rulesButton";
            this.rulesButton.Size = new System.Drawing.Size(84, 23);
            this.rulesButton.TabIndex = 2;
            this.rulesButton.Text = "Regras";
            this.rulesButton.UseVisualStyleBackColor = true;
            this.rulesButton.Click += new System.EventHandler(this.rulesButton_Click);
            // 
            // coursesButton
            // 
            this.coursesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.coursesButton.Location = new System.Drawing.Point(0, 23);
            this.coursesButton.Name = "coursesButton";
            this.coursesButton.Size = new System.Drawing.Size(84, 23);
            this.coursesButton.TabIndex = 1;
            this.coursesButton.Text = "Cursos";
            this.coursesButton.UseVisualStyleBackColor = true;
            this.coursesButton.Click += new System.EventHandler(this.coursesButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.Location = new System.Drawing.Point(0, 0);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(84, 23);
            this.dashboardButton.TabIndex = 0;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(86, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Panel1MinSize = 250;
            this.splitContainer.Panel2MinSize = 250;
            this.splitContainer.Size = new System.Drawing.Size(508, 261);
            this.splitContainer.SplitterDistance = 250;
            this.splitContainer.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 261);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.mainMenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(610, 300);
            this.Name = "MainForm";
            this.Text = "Additional Activities";
            this.mainMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button studentsButton;
        private System.Windows.Forms.Button activityPortfoliosButton;
        private System.Windows.Forms.Button activityItemsButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button activitiesButton;
        private System.Windows.Forms.Button rulesButton;
        private System.Windows.Forms.Button coursesButton;
        private System.Windows.Forms.Button dashboardButton;
    }
}