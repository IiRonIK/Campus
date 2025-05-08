namespace Campus
{
    partial class CuratorsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuratorsWindow));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbGroup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clearButton = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.tbStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbInspectionGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pbInspectionClear = new System.Windows.Forms.PictureBox();
            this.pbInspectionSearch = new System.Windows.Forms.PictureBox();
            this.tbInspectionStudent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInspectionClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInspectionSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 434);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbGroup);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.clearButton);
            this.tabPage1.Controls.Add(this.searchButton);
            this.tabPage1.Controls.Add(this.tbStudent);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(801, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Студенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbGroup
            // 
            this.tbGroup.Location = new System.Drawing.Point(455, 9);
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Size = new System.Drawing.Size(100, 20);
            this.tbGroup.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Группа:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(786, 367);
            this.dataGridView1.TabIndex = 4;
            // 
            // clearButton
            // 
            this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
            this.clearButton.Location = new System.Drawing.Point(614, 9);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(20, 20);
            this.clearButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clearButton.TabIndex = 3;
            this.clearButton.TabStop = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(577, 9);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(20, 20);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchButton.TabIndex = 2;
            this.searchButton.TabStop = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tbStudent
            // 
            this.tbStudent.Location = new System.Drawing.Point(119, 9);
            this.tbStudent.Name = "tbStudent";
            this.tbStudent.Size = new System.Drawing.Size(269, 20);
            this.tbStudent.TabIndex = 1;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО студента:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbInspectionGroup);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.pbInspectionClear);
            this.tabPage2.Controls.Add(this.pbInspectionSearch);
            this.tabPage2.Controls.Add(this.tbInspectionStudent);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(801, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Инспекция";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbInspectionGroup
            // 
            this.tbInspectionGroup.Location = new System.Drawing.Point(455, 9);
            this.tbInspectionGroup.Name = "tbInspectionGroup";
            this.tbInspectionGroup.Size = new System.Drawing.Size(100, 20);
            this.tbInspectionGroup.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Группа:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(786, 367);
            this.dataGridView2.TabIndex = 5;
            // 
            // pbInspectionClear
            // 
            this.pbInspectionClear.Image = ((System.Drawing.Image)(resources.GetObject("pbInspectionClear.Image")));
            this.pbInspectionClear.Location = new System.Drawing.Point(614, 9);
            this.pbInspectionClear.Name = "pbInspectionClear";
            this.pbInspectionClear.Size = new System.Drawing.Size(20, 20);
            this.pbInspectionClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInspectionClear.TabIndex = 4;
            this.pbInspectionClear.TabStop = false;
            this.pbInspectionClear.Click += new System.EventHandler(this.pbInspectionClear_Click);
            // 
            // pbInspectionSearch
            // 
            this.pbInspectionSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbInspectionSearch.Image")));
            this.pbInspectionSearch.Location = new System.Drawing.Point(577, 9);
            this.pbInspectionSearch.Name = "pbInspectionSearch";
            this.pbInspectionSearch.Size = new System.Drawing.Size(20, 20);
            this.pbInspectionSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInspectionSearch.TabIndex = 3;
            this.pbInspectionSearch.TabStop = false;
            this.pbInspectionSearch.Click += new System.EventHandler(this.pbInspectionSearch_Click);
            // 
            // tbInspectionStudent
            // 
            this.tbInspectionStudent.Location = new System.Drawing.Point(119, 9);
            this.tbInspectionStudent.Name = "tbInspectionStudent";
            this.tbInspectionStudent.Size = new System.Drawing.Size(269, 20);
            this.tbInspectionStudent.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО студента:";
            // 
            // CuratorsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "CuratorsWindow";
            this.Text = "Окно куратора";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CuratorsWindow_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInspectionClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInspectionSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox clearButton;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.TextBox tbStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbInspectionStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbInspectionSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pbInspectionClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbInspectionGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGroup;
    }
}