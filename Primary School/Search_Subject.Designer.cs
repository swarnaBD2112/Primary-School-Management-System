namespace Primary_School
{
    partial class Search_Subject
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
            this.Class_name = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.Label();
            this.class_search_comboBox = new System.Windows.Forms.ComboBox();
            this.Sub_comboBox2 = new System.Windows.Forms.ComboBox();
            this.Sub_search = new System.Windows.Forms.Button();
            this.search_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewSubject = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Class_name
            // 
            this.Class_name.AutoSize = true;
            this.Class_name.Location = new System.Drawing.Point(68, 16);
            this.Class_name.Name = "Class_name";
            this.Class_name.Size = new System.Drawing.Size(74, 13);
            this.Class_name.TabIndex = 0;
            this.Class_name.Text = "Classs Name :";
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Location = new System.Drawing.Point(93, 53);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(49, 13);
            this.Subject.TabIndex = 1;
            this.Subject.Text = "Subject :";
            // 
            // class_search_comboBox
            // 
            this.class_search_comboBox.FormattingEnabled = true;
            this.class_search_comboBox.Items.AddRange(new object[] {
            "Nursery",
            "Class 1",
            "Class 2",
            "Class 3",
            "Class 4",
            "Class 5"});
            this.class_search_comboBox.Location = new System.Drawing.Point(145, 12);
            this.class_search_comboBox.Name = "class_search_comboBox";
            this.class_search_comboBox.Size = new System.Drawing.Size(121, 21);
            this.class_search_comboBox.TabIndex = 6;
            // 
            // Sub_comboBox2
            // 
            this.Sub_comboBox2.FormattingEnabled = true;
            this.Sub_comboBox2.Items.AddRange(new object[] {
            "Bangla",
            "English",
            "Math",
            "Social Science",
            "Science",
            "Religious studies",
            "Fine Arts",
            "ICT"});
            this.Sub_comboBox2.Location = new System.Drawing.Point(145, 49);
            this.Sub_comboBox2.Name = "Sub_comboBox2";
            this.Sub_comboBox2.Size = new System.Drawing.Size(121, 21);
            this.Sub_comboBox2.TabIndex = 7;
            // 
            // Sub_search
            // 
            this.Sub_search.Location = new System.Drawing.Point(191, 94);
            this.Sub_search.Name = "Sub_search";
            this.Sub_search.Size = new System.Drawing.Size(75, 23);
            this.Sub_search.TabIndex = 8;
            this.Sub_search.Text = "Search";
            this.Sub_search.UseVisualStyleBackColor = true;
            this.Sub_search.Click += new System.EventHandler(this.OnClickSubjectSearch);
            // 
            // search_back
            // 
            this.search_back.Location = new System.Drawing.Point(26, 12);
            this.search_back.Name = "search_back";
            this.search_back.Size = new System.Drawing.Size(75, 23);
            this.search_back.TabIndex = 9;
            this.search_back.Text = "Back";
            this.search_back.UseVisualStyleBackColor = true;
            this.search_back.Click += new System.EventHandler(this.OnBackSubject);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Class_name);
            this.panel1.Controls.Add(this.Subject);
            this.panel1.Controls.Add(this.Sub_search);
            this.panel1.Controls.Add(this.class_search_comboBox);
            this.panel1.Controls.Add(this.Sub_comboBox2);
            this.panel1.Location = new System.Drawing.Point(230, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 128);
            this.panel1.TabIndex = 10;
            // 
            // dataGridViewSubject
            // 
            this.dataGridViewSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubject.Location = new System.Drawing.Point(12, 235);
            this.dataGridViewSubject.Name = "dataGridViewSubject";
            this.dataGridViewSubject.Size = new System.Drawing.Size(731, 190);
            this.dataGridViewSubject.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.search_back);
            this.panel3.Location = new System.Drawing.Point(12, 431);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(755, 47);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Primary_School.Properties.Resources.p90;
            this.panel2.Location = new System.Drawing.Point(12, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 76);
            this.panel2.TabIndex = 12;
            // 
            // Search_Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(752, 490);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewSubject);
            this.Controls.Add(this.panel1);
            this.Name = "Search_Subject";
            this.Text = "Search_Subject";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Class_name;
        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.ComboBox class_search_comboBox;
        private System.Windows.Forms.ComboBox Sub_comboBox2;
        private System.Windows.Forms.Button Sub_search;
        private System.Windows.Forms.Button search_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewSubject;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}