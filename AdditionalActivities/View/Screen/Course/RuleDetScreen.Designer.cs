namespace AdditionalActivities.View.Screen.Course
{
    partial class RuleDetScreen
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.activitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.TableLayoutPanel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.backButton = new System.Windows.Forms.Button();
            this.editSaveButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.requiredHoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.header.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requiredHoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(242, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar atividades";
            // 
            // label2
            // 
            label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(label2, 2);
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(65, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(118, 29);
            label2.TabIndex = 4;
            label2.Text = "Regra";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(label3, 2);
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(3, 29);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(118, 13);
            label3.TabIndex = 5;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(label4, 2);
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(127, 29);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(118, 13);
            label4.TabIndex = 7;
            label4.Text = "Ano";
            // 
            // label5
            // 
            label5.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(label5, 4);
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Location = new System.Drawing.Point(3, 68);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(242, 13);
            label5.TabIndex = 9;
            label5.Text = "Curso";
            // 
            // label6
            // 
            label6.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(label6, 4);
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Location = new System.Drawing.Point(3, 107);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(242, 13);
            label6.TabIndex = 11;
            label6.Text = "Horas necessárias";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.activitiesDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Panel1.Controls.Add(this.header);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2MinSize = 200;
            this.splitContainer1.Size = new System.Drawing.Size(500, 500);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.TabIndex = 0;
            // 
            // activitiesDataGridView
            // 
            this.activitiesDataGridView.AllowUserToAddRows = false;
            this.activitiesDataGridView.AllowUserToDeleteRows = false;
            this.activitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitiesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activitiesDataGridView.Location = new System.Drawing.Point(0, 41);
            this.activitiesDataGridView.Name = "activitiesDataGridView";
            this.activitiesDataGridView.ReadOnly = true;
            this.activitiesDataGridView.Size = new System.Drawing.Size(248, 430);
            this.activitiesDataGridView.TabIndex = 2;
            this.activitiesDataGridView.SelectionChanged += new System.EventHandler(this.activitiesDataGridView_SelectionChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.addButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.removeButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.openButton, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 471);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(248, 29);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(76, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Adicionar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(85, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(76, 23);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remover";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // openButton
            // 
            this.openButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openButton.Enabled = false;
            this.openButton.Location = new System.Drawing.Point(167, 3);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(78, 23);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Abrir";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.ColumnCount = 1;
            this.header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.header.Controls.Add(label1, 0, 0);
            this.header.Controls.Add(this.searchTextBox, 0, 1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.RowCount = 2;
            this.header.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.header.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.header.Size = new System.Drawing.Size(248, 41);
            this.header.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextBox.Location = new System.Drawing.Point(3, 18);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(242, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.backButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.editSaveButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.courseTextBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.requiredHoursNumericUpDown, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.yearNumericUpDown, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(248, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Voltar";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // editSaveButton
            // 
            this.editSaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editSaveButton.Location = new System.Drawing.Point(189, 3);
            this.editSaveButton.Name = "editSaveButton";
            this.editSaveButton.Size = new System.Drawing.Size(56, 23);
            this.editSaveButton.TabIndex = 3;
            this.editSaveButton.Text = "Editar";
            this.editSaveButton.UseVisualStyleBackColor = true;
            this.editSaveButton.Click += new System.EventHandler(this.editSaveButton_Click);
            // 
            // nameTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.nameTextBox, 2);
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(3, 45);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(118, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // courseTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.courseTextBox, 4);
            this.courseTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseTextBox.Location = new System.Drawing.Point(3, 84);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.ReadOnly = true;
            this.courseTextBox.Size = new System.Drawing.Size(242, 20);
            this.courseTextBox.TabIndex = 10;
            // 
            // requiredHoursNumericUpDown
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.requiredHoursNumericUpDown, 4);
            this.requiredHoursNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requiredHoursNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.requiredHoursNumericUpDown.Location = new System.Drawing.Point(3, 123);
            this.requiredHoursNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.requiredHoursNumericUpDown.Name = "requiredHoursNumericUpDown";
            this.requiredHoursNumericUpDown.Size = new System.Drawing.Size(242, 20);
            this.requiredHoursNumericUpDown.TabIndex = 12;
            // 
            // yearNumericUpDown
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.yearNumericUpDown, 2);
            this.yearNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yearNumericUpDown.Location = new System.Drawing.Point(127, 45);
            this.yearNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(118, 20);
            this.yearNumericUpDown.TabIndex = 8;
            this.yearNumericUpDown.ThousandsSeparator = true;
            this.yearNumericUpDown.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // RuleDetScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "RuleDetScreen";
            this.Size = new System.Drawing.Size(500, 500);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requiredHoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView activitiesDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button editSaveButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.NumericUpDown requiredHoursNumericUpDown;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
    }
}
