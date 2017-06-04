namespace AdditionalActivities.View.Screen.Course
{
    partial class ActivityDetScreen
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
            System.Windows.Forms.Label label7;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.backButton = new System.Windows.Forms.Button();
            this.editSaveButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.ruleTextBox = new System.Windows.Forms.TextBox();
            this.stepCheckBox = new System.Windows.Forms.CheckBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.minHoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxHoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stepHoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minHoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepHoursNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(169, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(160, 29);
            label1.TabIndex = 4;
            label1.Text = "Atividade";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(label2, 3);
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(3, 29);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(494, 13);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(label3, 3);
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(3, 68);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(494, 13);
            label3.TabIndex = 7;
            label3.Text = "Curso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(label4, 3);
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(3, 107);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(494, 13);
            label4.TabIndex = 9;
            label4.Text = "Regra";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Location = new System.Drawing.Point(3, 146);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(160, 17);
            label5.TabIndex = 11;
            label5.Text = "Mínimo de horas";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Location = new System.Drawing.Point(169, 146);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(160, 17);
            label6.TabIndex = 13;
            label6.Text = "Máximo de horas";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(label7, 3);
            label7.Dock = System.Windows.Forms.DockStyle.Fill;
            label7.Location = new System.Drawing.Point(3, 189);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(494, 13);
            label7.TabIndex = 18;
            label7.Text = "Descrição";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.backButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.editSaveButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.courseTextBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ruleTextBox, 0, 6);
            this.tableLayoutPanel1.Controls.Add(label5, 0, 7);
            this.tableLayoutPanel1.Controls.Add(label6, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.stepCheckBox, 2, 7);
            this.tableLayoutPanel1.Controls.Add(label7, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.descriptionTextBox, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.minHoursNumericUpDown, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.maxHoursNumericUpDown, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.stepHoursNumericUpDown, 2, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(160, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Voltar";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // editSaveButton
            // 
            this.editSaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editSaveButton.Location = new System.Drawing.Point(335, 3);
            this.editSaveButton.Name = "editSaveButton";
            this.editSaveButton.Size = new System.Drawing.Size(162, 23);
            this.editSaveButton.TabIndex = 3;
            this.editSaveButton.Text = "Editar";
            this.editSaveButton.UseVisualStyleBackColor = true;
            this.editSaveButton.Click += new System.EventHandler(this.editSaveButton_Click);
            // 
            // nameTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.nameTextBox, 3);
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(3, 45);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(494, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // courseTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.courseTextBox, 3);
            this.courseTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseTextBox.Location = new System.Drawing.Point(3, 84);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.ReadOnly = true;
            this.courseTextBox.Size = new System.Drawing.Size(494, 20);
            this.courseTextBox.TabIndex = 8;
            // 
            // ruleTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ruleTextBox, 3);
            this.ruleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ruleTextBox.Location = new System.Drawing.Point(3, 123);
            this.ruleTextBox.Name = "ruleTextBox";
            this.ruleTextBox.ReadOnly = true;
            this.ruleTextBox.Size = new System.Drawing.Size(494, 20);
            this.ruleTextBox.TabIndex = 10;
            // 
            // stepCheckBox
            // 
            this.stepCheckBox.AutoSize = true;
            this.stepCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepCheckBox.Location = new System.Drawing.Point(335, 146);
            this.stepCheckBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.stepCheckBox.Name = "stepCheckBox";
            this.stepCheckBox.Size = new System.Drawing.Size(162, 17);
            this.stepCheckBox.TabIndex = 16;
            this.stepCheckBox.Text = "Passo";
            this.stepCheckBox.UseVisualStyleBackColor = true;
            this.stepCheckBox.CheckedChanged += new System.EventHandler(this.stepCheckBox_CheckedChanged);
            // 
            // descriptionTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.descriptionTextBox, 3);
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.Location = new System.Drawing.Point(3, 205);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(494, 292);
            this.descriptionTextBox.TabIndex = 19;
            // 
            // minHoursNumericUpDown
            // 
            this.minHoursNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minHoursNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.minHoursNumericUpDown.Location = new System.Drawing.Point(3, 166);
            this.minHoursNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.minHoursNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minHoursNumericUpDown.Name = "minHoursNumericUpDown";
            this.minHoursNumericUpDown.Size = new System.Drawing.Size(160, 20);
            this.minHoursNumericUpDown.TabIndex = 12;
            this.minHoursNumericUpDown.ThousandsSeparator = true;
            this.minHoursNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maxHoursNumericUpDown
            // 
            this.maxHoursNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxHoursNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.maxHoursNumericUpDown.Location = new System.Drawing.Point(169, 166);
            this.maxHoursNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.maxHoursNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxHoursNumericUpDown.Name = "maxHoursNumericUpDown";
            this.maxHoursNumericUpDown.Size = new System.Drawing.Size(160, 20);
            this.maxHoursNumericUpDown.TabIndex = 14;
            this.maxHoursNumericUpDown.ThousandsSeparator = true;
            this.maxHoursNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // stepHoursNumericUpDown
            // 
            this.stepHoursNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepHoursNumericUpDown.Enabled = false;
            this.stepHoursNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.stepHoursNumericUpDown.Location = new System.Drawing.Point(335, 166);
            this.stepHoursNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.stepHoursNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepHoursNumericUpDown.Name = "stepHoursNumericUpDown";
            this.stepHoursNumericUpDown.Size = new System.Drawing.Size(162, 20);
            this.stepHoursNumericUpDown.TabIndex = 16;
            this.stepHoursNumericUpDown.ThousandsSeparator = true;
            this.stepHoursNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ActivityDetScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ActivityDetScreen";
            this.Size = new System.Drawing.Size(500, 500);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minHoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepHoursNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button editSaveButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.TextBox ruleTextBox;
        private System.Windows.Forms.CheckBox stepCheckBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.NumericUpDown minHoursNumericUpDown;
        private System.Windows.Forms.NumericUpDown maxHoursNumericUpDown;
        private System.Windows.Forms.NumericUpDown stepHoursNumericUpDown;
    }
}
