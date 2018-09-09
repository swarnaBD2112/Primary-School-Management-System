namespace Primary_School
{
    partial class Add_Subject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Class_comboBox = new System.Windows.Forms.ComboBox();
            this.Sub_name_comboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_teacher_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Class_name = new System.Windows.Forms.Label();
            this.Subject_name = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 430);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBox_year);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Class_comboBox);
            this.panel2.Controls.Add(this.Sub_name_comboBox);
            this.panel2.Controls.Add(this.textBox_teacher_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Class_name);
            this.panel2.Controls.Add(this.Subject_name);
            this.panel2.Controls.Add(this.OK);
            this.panel2.Location = new System.Drawing.Point(81, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 226);
            this.panel2.TabIndex = 0;
            // 
            // textBox_year
            // 
            this.textBox_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_year.Location = new System.Drawing.Point(204, 133);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(153, 22);
            this.textBox_year.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Year :";
            // 
            // Class_comboBox
            // 
            this.Class_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class_comboBox.FormattingEnabled = true;
            this.Class_comboBox.Items.AddRange(new object[] {
            "Nursery",
            "Class 1",
            "Class 2",
            "Class 3",
            "Class 4",
            "Class 5"});
            this.Class_comboBox.Location = new System.Drawing.Point(203, 57);
            this.Class_comboBox.Name = "Class_comboBox";
            this.Class_comboBox.Size = new System.Drawing.Size(154, 24);
            this.Class_comboBox.TabIndex = 19;
            // 
            // Sub_name_comboBox
            // 
            this.Sub_name_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sub_name_comboBox.FormattingEnabled = true;
            this.Sub_name_comboBox.Items.AddRange(new object[] {
            "Bangla",
            "English",
            "Math",
            "Social Science",
            "Science",
            "Religious studies",
            "Fine Arts",
            "ICT"});
            this.Sub_name_comboBox.Location = new System.Drawing.Point(203, 17);
            this.Sub_name_comboBox.Name = "Sub_name_comboBox";
            this.Sub_name_comboBox.Size = new System.Drawing.Size(154, 24);
            this.Sub_name_comboBox.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(24, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox_teacher_name
            // 
            this.textBox_teacher_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_teacher_name.Location = new System.Drawing.Point(203, 96);
            this.textBox_teacher_name.Name = "textBox_teacher_name";
            this.textBox_teacher_name.Size = new System.Drawing.Size(154, 22);
            this.textBox_teacher_name.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Teacher Name :";
            // 
            // Class_name
            // 
            this.Class_name.AutoSize = true;
            this.Class_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class_name.Location = new System.Drawing.Point(100, 61);
            this.Class_name.Name = "Class_name";
            this.Class_name.Size = new System.Drawing.Size(100, 16);
            this.Class_name.TabIndex = 15;
            this.Class_name.Text = "Class Name :";
            // 
            // Subject_name
            // 
            this.Subject_name.AutoSize = true;
            this.Subject_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_name.Location = new System.Drawing.Point(87, 20);
            this.Subject_name.Name = "Subject_name";
            this.Subject_name.Size = new System.Drawing.Size(113, 16);
            this.Subject_name.TabIndex = 14;
            this.Subject_name.Text = "Subject Name :";
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(282, 173);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 12;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Primary_School.Properties.Resources.p4;
            this.panel3.Location = new System.Drawing.Point(14, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 95);
            this.panel3.TabIndex = 14;
            // 
            // Add_Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 431);
            this.Controls.Add(this.panel1);
            this.Name = "Add_Subject";
            this.Text = "Add_Subject";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Class_comboBox;
        private System.Windows.Forms.ComboBox Sub_name_comboBox;
        private System.Windows.Forms.TextBox textBox_teacher_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Class_name;
        private System.Windows.Forms.Label Subject_name;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
    }
}