namespace Primary_School
{
    partial class Search
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView_search = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.Update_Student = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.search_comboBox = new System.Windows.Forms.ComboBox();
            this.text_search_Student_Id = new System.Windows.Forms.TextBox();
            this.text_search_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Search_name = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.search_Id = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_search)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dataGridView_search);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Search_name);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.search_Id);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 703);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(3, 471);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1113, 32);
            this.panel4.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(28, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView_search
            // 
            this.dataGridView_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_search.Location = new System.Drawing.Point(0, 371);
            this.dataGridView_search.Name = "dataGridView_search";
            this.dataGridView_search.Size = new System.Drawing.Size(1116, 90);
            this.dataGridView_search.TabIndex = 3;
            this.dataGridView_search.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.Update_Student);
            this.panel3.Controls.Add(this.Refresh);
            this.panel3.Controls.Add(this.delete);
            this.panel3.Controls.Add(this.search_comboBox);
            this.panel3.Controls.Add(this.text_search_Student_Id);
            this.panel3.Controls.Add(this.text_search_name);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(244, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(516, 232);
            this.panel3.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(451, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Enter the Name , Student_Id and Class of the student here :";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // Update_Student
            // 
            this.Update_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Student.Location = new System.Drawing.Point(389, 102);
            this.Update_Student.Name = "Update_Student";
            this.Update_Student.Size = new System.Drawing.Size(75, 23);
            this.Update_Student.TabIndex = 27;
            this.Update_Student.Text = "Update";
            this.Update_Student.UseVisualStyleBackColor = true;
            this.Update_Student.Click += new System.EventHandler(this.Update_Student_Click_1);
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(389, 59);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 26;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click_1);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(389, 141);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 23;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click_1);
            // 
            // search_comboBox
            // 
            this.search_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_comboBox.FormattingEnabled = true;
            this.search_comboBox.Items.AddRange(new object[] {
            "Nursery",
            "Class 1",
            "Class 2",
            "Class 3",
            "Class 4",
            "Class 5"});
            this.search_comboBox.Location = new System.Drawing.Point(160, 141);
            this.search_comboBox.Name = "search_comboBox";
            this.search_comboBox.Size = new System.Drawing.Size(100, 24);
            this.search_comboBox.TabIndex = 20;
            this.search_comboBox.SelectedIndexChanged += new System.EventHandler(this.search_comboBox_SelectedIndexChanged);
            // 
            // text_search_Student_Id
            // 
            this.text_search_Student_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_search_Student_Id.Location = new System.Drawing.Point(160, 102);
            this.text_search_Student_Id.Name = "text_search_Student_Id";
            this.text_search_Student_Id.Size = new System.Drawing.Size(100, 22);
            this.text_search_Student_Id.TabIndex = 19;
            // 
            // text_search_name
            // 
            this.text_search_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_search_name.Location = new System.Drawing.Point(160, 63);
            this.text_search_name.Name = "text_search_name";
            this.text_search_name.Size = new System.Drawing.Size(100, 22);
            this.text_search_name.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Class :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Student_Id :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name :";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Primary_School.Properties.Resources.p12;
            this.panel2.Location = new System.Drawing.Point(13, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 91);
            this.panel2.TabIndex = 15;
            // 
            // Search_name
            // 
            this.Search_name.Location = new System.Drawing.Point(910, 254);
            this.Search_name.Name = "Search_name";
            this.Search_name.Size = new System.Drawing.Size(75, 23);
            this.Search_name.TabIndex = 24;
            this.Search_name.Text = "Search...";
            this.Search_name.UseVisualStyleBackColor = true;
            this.Search_name.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(910, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // search_Id
            // 
            this.search_Id.Location = new System.Drawing.Point(910, 206);
            this.search_Id.Name = "search_Id";
            this.search_Id.Size = new System.Drawing.Size(75, 23);
            this.search_Id.TabIndex = 25;
            this.search_Id.Text = "Search...";
            this.search_Id.UseVisualStyleBackColor = true;
            this.search_Id.Visible = false;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 515);
            this.Controls.Add(this.panel1);
            this.Name = "Search";
            this.Text = "Search_Student";
            this.Load += new System.EventHandler(this.Search_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_search)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Update_Student;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ComboBox search_comboBox;
        private System.Windows.Forms.TextBox text_search_Student_Id;
        private System.Windows.Forms.TextBox text_search_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search_name;
        private System.Windows.Forms.Button search_Id;
        private System.Windows.Forms.Button button1;
    }
}