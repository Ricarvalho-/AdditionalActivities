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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dashButton = new System.Windows.Forms.Button();
            this.coursesButton = new System.Windows.Forms.Button();
            this.studentsButton = new System.Windows.Forms.Button();
            this.portfoliosButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dashButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.coursesButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.studentsButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.portfoliosButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.settingsButton, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(81, 311);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dashButton
            // 
            this.dashButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dashButton.Location = new System.Drawing.Point(3, 3);
            this.dashButton.Name = "dashButton";
            this.dashButton.Size = new System.Drawing.Size(75, 56);
            this.dashButton.TabIndex = 0;
            this.dashButton.Text = "Dashboard";
            this.dashButton.UseVisualStyleBackColor = true;
            this.dashButton.Click += new System.EventHandler(this.dashButton_Click);
            // 
            // coursesButton
            // 
            this.coursesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coursesButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.coursesButton.Location = new System.Drawing.Point(3, 65);
            this.coursesButton.Name = "coursesButton";
            this.coursesButton.Size = new System.Drawing.Size(75, 56);
            this.coursesButton.TabIndex = 1;
            this.coursesButton.Text = "Cursos";
            this.coursesButton.UseVisualStyleBackColor = true;
            this.coursesButton.Click += new System.EventHandler(this.coursesButton_Click);
            // 
            // studentsButton
            // 
            this.studentsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.studentsButton.Location = new System.Drawing.Point(3, 127);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(75, 56);
            this.studentsButton.TabIndex = 2;
            this.studentsButton.Text = "Alunos";
            this.studentsButton.UseVisualStyleBackColor = true;
            this.studentsButton.Click += new System.EventHandler(this.studentsButton_Click);
            // 
            // portfoliosButton
            // 
            this.portfoliosButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portfoliosButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.portfoliosButton.Location = new System.Drawing.Point(3, 189);
            this.portfoliosButton.Name = "portfoliosButton";
            this.portfoliosButton.Size = new System.Drawing.Size(75, 56);
            this.portfoliosButton.TabIndex = 3;
            this.portfoliosButton.Text = "Portifólios";
            this.portfoliosButton.UseVisualStyleBackColor = true;
            this.portfoliosButton.Click += new System.EventHandler(this.portfoliosButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.settingsButton.Location = new System.Drawing.Point(3, 251);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 57);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "Configurações";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(81, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(503, 311);
            this.panel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "MainForm";
            this.Text = "Atividades Complementares";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button dashButton;
        private System.Windows.Forms.Button coursesButton;
        private System.Windows.Forms.Button studentsButton;
        private System.Windows.Forms.Button portfoliosButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Panel panel;
    }
}