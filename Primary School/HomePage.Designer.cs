namespace Primary_School
{
    partial class HomePage
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
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.Subject_comboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Gurdian_comboBox = new System.Windows.Forms.ComboBox();
            this.Teacher_comboBox = new System.Windows.Forms.ComboBox();
            this.Teach_ComboBox = new System.Windows.Forms.ComboBox();
            this.St_ComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.know = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBox_class);
            this.panel1.Controls.Add(this.Subject_comboBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Gurdian_comboBox);
            this.panel1.Controls.Add(this.Teacher_comboBox);
            this.panel1.Controls.Add(this.Teach_ComboBox);
            this.panel1.Controls.Add(this.St_ComboBox);
            this.panel1.Location = new System.Drawing.Point(48, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 366);
            this.panel1.TabIndex = 0;
            // 
            // comboBox_class
            // 
            this.comboBox_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Items.AddRange(new object[] {
            "Search class",
            "Add New"});
            this.comboBox_class.Location = new System.Drawing.Point(12, 311);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(195, 24);
            this.comboBox_class.TabIndex = 14;
            this.comboBox_class.Text = "Class";
            this.comboBox_class.SelectedIndexChanged += new System.EventHandler(this.comboBox_class_SelectedIndexChanged);
            // 
            // Subject_comboBox
            // 
            this.Subject_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_comboBox.FormattingEnabled = true;
            this.Subject_comboBox.Items.AddRange(new object[] {
            "Search Subject",
            "Add New"});
            this.Subject_comboBox.Location = new System.Drawing.Point(12, 251);
            this.Subject_comboBox.Name = "Subject_comboBox";
            this.Subject_comboBox.Size = new System.Drawing.Size(195, 24);
            this.Subject_comboBox.TabIndex = 10;
            this.Subject_comboBox.Text = "Subject";
            this.Subject_comboBox.SelectedIndexChanged += new System.EventHandler(this.Subject_comboBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 106);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(67, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 92);
            this.label2.TabIndex = 0;
            this.label2.Text = "Insert \r\nUpdate  \r\nDelete\r\nSearch";
            // 
            // Gurdian_comboBox
            // 
            this.Gurdian_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gurdian_comboBox.FormattingEnabled = true;
            this.Gurdian_comboBox.Items.AddRange(new object[] {
            "Search Gurdian"});
            this.Gurdian_comboBox.Location = new System.Drawing.Point(12, 221);
            this.Gurdian_comboBox.Name = "Gurdian_comboBox";
            this.Gurdian_comboBox.Size = new System.Drawing.Size(195, 24);
            this.Gurdian_comboBox.TabIndex = 9;
            this.Gurdian_comboBox.Text = "Gurdian";
            this.Gurdian_comboBox.SelectedIndexChanged += new System.EventHandler(this.Gurdian_comboBox_SelectedIndexChanged);
            // 
            // Teacher_comboBox
            // 
            this.Teacher_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_comboBox.FormattingEnabled = true;
            this.Teacher_comboBox.Items.AddRange(new object[] {
            "Search Teaches",
            "Add New"});
            this.Teacher_comboBox.Location = new System.Drawing.Point(12, 281);
            this.Teacher_comboBox.Name = "Teacher_comboBox";
            this.Teacher_comboBox.Size = new System.Drawing.Size(195, 24);
            this.Teacher_comboBox.TabIndex = 8;
            this.Teacher_comboBox.Text = "Teaches";
            // 
            // Teach_ComboBox
            // 
            this.Teach_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teach_ComboBox.FormattingEnabled = true;
            this.Teach_ComboBox.Items.AddRange(new object[] {
            "Search Teacher",
            "Add New"});
            this.Teach_ComboBox.Location = new System.Drawing.Point(15, 191);
            this.Teach_ComboBox.Name = "Teach_ComboBox";
            this.Teach_ComboBox.Size = new System.Drawing.Size(192, 24);
            this.Teach_ComboBox.TabIndex = 7;
            this.Teach_ComboBox.Text = "Teacher";
            this.Teach_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Teach_ComboBox_SelectedIndexChanged);
            // 
            // St_ComboBox
            // 
            this.St_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.St_ComboBox.FormattingEnabled = true;
            this.St_ComboBox.Items.AddRange(new object[] {
            "Search Information",
            "Admit New"});
            this.St_ComboBox.Location = new System.Drawing.Point(15, 161);
            this.St_ComboBox.Name = "St_ComboBox";
            this.St_ComboBox.Size = new System.Drawing.Size(192, 24);
            this.St_ComboBox.TabIndex = 6;
            this.St_ComboBox.Text = "Student";
            this.St_ComboBox.SelectedIndexChanged += new System.EventHandler(this.St_ComboBox_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(15, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.OnBackClick);
            // 
            // know
            // 
            this.know.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.know.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.know.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.know.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.know.Location = new System.Drawing.Point(295, 180);
            this.know.Name = "know";
            this.know.Size = new System.Drawing.Size(327, 38);
            this.know.TabIndex = 0;
            this.know.Text = "Know About School\'";
            this.know.UseVisualStyleBackColor = false;
            this.know.Click += new System.EventHandler(this.Know);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.ForestGreen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(295, 377);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 169);
            this.panel3.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Single Student",
            "Class wise"});
            this.comboBox1.Location = new System.Drawing.Point(107, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Get Result";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.On_SaveData_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(317, 61);
            this.panel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(99, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Result";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.button3);
            this.panel5.Location = new System.Drawing.Point(12, 556);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(683, 42);
            this.panel5.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Pink;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(295, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(327, 38);
            this.button4.TabIndex = 15;
            this.button4.Text = "Get Statistics on Male Student";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(295, 257);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(327, 38);
            this.button5.TabIndex = 16;
            this.button5.Text = "Get Statistics on Female Student";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Pink;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(295, 295);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(327, 38);
            this.button6.TabIndex = 17;
            this.button6.Text = "Top Students of School";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(295, 335);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(327, 38);
            this.button7.TabIndex = 18;
            this.button7.Text = "See Teacher Information";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.T_Info);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::Primary_School.Properties.Resources.Capture;
            this.panel6.Location = new System.Drawing.Point(12, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(678, 149);
            this.panel6.TabIndex = 19;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(708, 617);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.know);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox Teach_ComboBox;
        private System.Windows.Forms.ComboBox St_ComboBox;
        private System.Windows.Forms.ComboBox Subject_comboBox;
        private System.Windows.Forms.ComboBox Gurdian_comboBox;
        private System.Windows.Forms.ComboBox Teacher_comboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button know;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox comboBox_class;
    }
}