﻿namespace AdditionalActivities.View.Screen.Portfolio
{
    partial class PortfolioListScreen
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.newStudentButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.portfoliosDataGridView = new System.Windows.Forms.DataGridView();
            this.studentDetFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.registerNumberLabel = new System.Windows.Forms.Label();
            this.ruleLabel = new System.Windows.Forms.Label();
            this.registerStateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portfoliosDataGridView)).BeginInit();
            this.studentDetFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(480, 13);
            label1.TabIndex = 0;
            label1.Text = "Curso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(label3, 2);
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(3, 40);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(480, 13);
            label3.TabIndex = 2;
            label3.Text = "Aluno";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.courseComboBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.studentComboBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.newStudentButton, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 82);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // courseComboBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.courseComboBox, 2);
            this.courseComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(3, 16);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(480, 21);
            this.courseComboBox.TabIndex = 1;
            // 
            // studentComboBox
            // 
            this.studentComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.studentComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(3, 56);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(399, 21);
            this.studentComboBox.TabIndex = 3;
            this.studentComboBox.SelectedIndexChanged += new System.EventHandler(this.studentComboBox_SelectedIndexChanged);
            this.studentComboBox.TextUpdate += new System.EventHandler(this.studentComboBox_TextUpdate);
            // 
            // newStudentButton
            // 
            this.newStudentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newStudentButton.Location = new System.Drawing.Point(408, 56);
            this.newStudentButton.Name = "newStudentButton";
            this.newStudentButton.Size = new System.Drawing.Size(75, 23);
            this.newStudentButton.TabIndex = 4;
            this.newStudentButton.Text = "Novo Aluno";
            this.newStudentButton.UseVisualStyleBackColor = true;
            this.newStudentButton.Click += new System.EventHandler(this.newStudentButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.addButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.removeButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.openButton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 521);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(486, 29);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(156, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Adicionar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(165, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(156, 23);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remover";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // openButton
            // 
            this.openButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openButton.Enabled = false;
            this.openButton.Location = new System.Drawing.Point(327, 3);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(156, 23);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Abrir";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // portfoliosDataGridView
            // 
            this.portfoliosDataGridView.AllowUserToAddRows = false;
            this.portfoliosDataGridView.AllowUserToDeleteRows = false;
            this.portfoliosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.portfoliosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portfoliosDataGridView.Location = new System.Drawing.Point(0, 101);
            this.portfoliosDataGridView.Name = "portfoliosDataGridView";
            this.portfoliosDataGridView.ReadOnly = true;
            this.portfoliosDataGridView.Size = new System.Drawing.Size(486, 420);
            this.portfoliosDataGridView.TabIndex = 2;
            this.portfoliosDataGridView.SelectionChanged += new System.EventHandler(this.portfoliosDataGridView_SelectionChanged);
            // 
            // studentDetFlowLayoutPanel
            // 
            this.studentDetFlowLayoutPanel.AutoSize = true;
            this.studentDetFlowLayoutPanel.Controls.Add(this.nameLabel);
            this.studentDetFlowLayoutPanel.Controls.Add(this.registerNumberLabel);
            this.studentDetFlowLayoutPanel.Controls.Add(this.ruleLabel);
            this.studentDetFlowLayoutPanel.Controls.Add(this.registerStateLabel);
            this.studentDetFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentDetFlowLayoutPanel.Location = new System.Drawing.Point(0, 82);
            this.studentDetFlowLayoutPanel.Name = "studentDetFlowLayoutPanel";
            this.studentDetFlowLayoutPanel.Size = new System.Drawing.Size(486, 19);
            this.studentDetFlowLayoutPanel.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 3);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(3, 3, 32, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nome:";
            // 
            // registerNumberLabel
            // 
            this.registerNumberLabel.AutoSize = true;
            this.registerNumberLabel.Location = new System.Drawing.Point(76, 3);
            this.registerNumberLabel.Margin = new System.Windows.Forms.Padding(3, 3, 32, 3);
            this.registerNumberLabel.Name = "registerNumberLabel";
            this.registerNumberLabel.Size = new System.Drawing.Size(58, 13);
            this.registerNumberLabel.TabIndex = 1;
            this.registerNumberLabel.Text = "Prontuário:";
            // 
            // ruleLabel
            // 
            this.ruleLabel.AutoSize = true;
            this.ruleLabel.Location = new System.Drawing.Point(169, 3);
            this.ruleLabel.Margin = new System.Windows.Forms.Padding(3, 3, 32, 3);
            this.ruleLabel.Name = "ruleLabel";
            this.ruleLabel.Size = new System.Drawing.Size(39, 13);
            this.ruleLabel.TabIndex = 2;
            this.ruleLabel.Text = "Regra:";
            // 
            // registerStateLabel
            // 
            this.registerStateLabel.AutoSize = true;
            this.registerStateLabel.Location = new System.Drawing.Point(243, 3);
            this.registerStateLabel.Margin = new System.Windows.Forms.Padding(3, 3, 32, 3);
            this.registerStateLabel.Name = "registerStateLabel";
            this.registerStateLabel.Size = new System.Drawing.Size(43, 13);
            this.registerStateLabel.TabIndex = 3;
            this.registerStateLabel.Text = "Estado:";
            // 
            // PortfolioListScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.portfoliosDataGridView);
            this.Controls.Add(this.studentDetFlowLayoutPanel);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PortfolioListScreen";
            this.Size = new System.Drawing.Size(486, 550);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.portfoliosDataGridView)).EndInit();
            this.studentDetFlowLayoutPanel.ResumeLayout(false);
            this.studentDetFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button newStudentButton;
        private System.Windows.Forms.DataGridView portfoliosDataGridView;
        private System.Windows.Forms.FlowLayoutPanel studentDetFlowLayoutPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label registerNumberLabel;
        private System.Windows.Forms.Label ruleLabel;
        private System.Windows.Forms.Label registerStateLabel;
    }
}
