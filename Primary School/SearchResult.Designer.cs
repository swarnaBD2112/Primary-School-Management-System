namespace Primary_School
{
    partial class SearchResult
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
            this.panel_student = new System.Windows.Forms.Panel();
            this.st_textBox_Stu_ID = new System.Windows.Forms.TextBox();
            this.st_comboBox_class = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.st_comboBox_term = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_class = new System.Windows.Forms.Panel();
            this.cls_comboBox_class = new System.Windows.Forms.ComboBox();
            this.cls_comboBox_term = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_student.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_class.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_student
            // 
            this.panel_student.Controls.Add(this.st_textBox_Stu_ID);
            this.panel_student.Controls.Add(this.st_comboBox_class);
            this.panel_student.Controls.Add(this.label5);
            this.panel_student.Controls.Add(this.st_comboBox_term);
            this.panel_student.Controls.Add(this.label3);
            this.panel_student.Controls.Add(this.label4);
            this.panel_student.Location = new System.Drawing.Point(47, 6);
            this.panel_student.Name = "panel_student";
            this.panel_student.Size = new System.Drawing.Size(228, 100);
            this.panel_student.TabIndex = 1;
            this.panel_student.Visible = false;
            // 
            // st_textBox_Stu_ID
            // 
            this.st_textBox_Stu_ID.Location = new System.Drawing.Point(72, 13);
            this.st_textBox_Stu_ID.Name = "st_textBox_Stu_ID";
            this.st_textBox_Stu_ID.Size = new System.Drawing.Size(121, 20);
            this.st_textBox_Stu_ID.TabIndex = 11;
            // 
            // st_comboBox_class
            // 
            this.st_comboBox_class.FormattingEnabled = true;
            this.st_comboBox_class.Items.AddRange(new object[] {
            "Nursery",
            "Class 1",
            "Class 2",
            "Class 3",
            "Class 4",
            "Class 5"});
            this.st_comboBox_class.Location = new System.Drawing.Point(72, 42);
            this.st_comboBox_class.Name = "st_comboBox_class";
            this.st_comboBox_class.Size = new System.Drawing.Size(121, 21);
            this.st_comboBox_class.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Term :";
            // 
            // st_comboBox_term
            // 
            this.st_comboBox_term.FormattingEnabled = true;
            this.st_comboBox_term.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "All"});
            this.st_comboBox_term.Location = new System.Drawing.Point(72, 69);
            this.st_comboBox_term.Name = "st_comboBox_term";
            this.st_comboBox_term.Size = new System.Drawing.Size(121, 21);
            this.st_comboBox_term.TabIndex = 8;
            this.st_comboBox_term.SelectedIndexChanged += new System.EventHandler(this.On_Term);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Class :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Student Id : ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel_student);
            this.panel3.Controls.Add(this.panel_class);
            this.panel3.Location = new System.Drawing.Point(12, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 122);
            this.panel3.TabIndex = 1;
            // 
            // panel_class
            // 
            this.panel_class.Controls.Add(this.cls_comboBox_class);
            this.panel_class.Controls.Add(this.cls_comboBox_term);
            this.panel_class.Controls.Add(this.label2);
            this.panel_class.Controls.Add(this.label1);
            this.panel_class.Location = new System.Drawing.Point(281, 6);
            this.panel_class.Name = "panel_class";
            this.panel_class.Size = new System.Drawing.Size(236, 100);
            this.panel_class.TabIndex = 2;
            this.panel_class.Visible = false;
            // 
            // cls_comboBox_class
            // 
            this.cls_comboBox_class.FormattingEnabled = true;
            this.cls_comboBox_class.Items.AddRange(new object[] {
            "Nursery",
            "Class 1",
            "Class 2",
            "Class 3",
            "Class 4",
            "Class 5"});
            this.cls_comboBox_class.Location = new System.Drawing.Point(83, 19);
            this.cls_comboBox_class.Name = "cls_comboBox_class";
            this.cls_comboBox_class.Size = new System.Drawing.Size(121, 21);
            this.cls_comboBox_class.TabIndex = 5;
            this.cls_comboBox_class.SelectedIndexChanged += new System.EventHandler(this.cls_comboBox_class_SelectedIndexChanged);
            // 
            // cls_comboBox_term
            // 
            this.cls_comboBox_term.FormattingEnabled = true;
            this.cls_comboBox_term.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "All"});
            this.cls_comboBox_term.Location = new System.Drawing.Point(83, 52);
            this.cls_comboBox_term.Name = "cls_comboBox_term";
            this.cls_comboBox_term.Size = new System.Drawing.Size(121, 21);
            this.cls_comboBox_term.TabIndex = 4;
            this.cls_comboBox_term.SelectedIndexChanged += new System.EventHandler(this.cls_comboBox_term_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Term : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(12, 477);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(764, 43);
            this.panel4.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.On_Back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 223);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Primary_School.Properties.Resources.sr;
            this.panel1.Location = new System.Drawing.Point(59, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 89);
            this.panel1.TabIndex = 0;
            // 
            // SearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(788, 530);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "SearchResult";
            this.Text = "SearchResult";
            this.Load += new System.EventHandler(this.SearchResult_Load);
            this.panel_student.ResumeLayout(false);
            this.panel_student.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel_class.ResumeLayout(false);
            this.panel_class.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_student;
        private System.Windows.Forms.ComboBox st_comboBox_term;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_class;
        private System.Windows.Forms.ComboBox cls_comboBox_class;
        private System.Windows.Forms.ComboBox cls_comboBox_term;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox st_textBox_Stu_ID;
        private System.Windows.Forms.ComboBox st_comboBox_class;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}