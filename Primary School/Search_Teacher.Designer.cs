namespace Primary_School
{
    partial class Search_Teacher
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
            this.Delete_Teacher = new System.Windows.Forms.Button();
            this.Referesh_Teacher = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textbox_search_teacher_name = new System.Windows.Forms.TextBox();
            this.Teacher_name = new System.Windows.Forms.Label();
            this.dataGridView1_search = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_search)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.Delete_Teacher);
            this.panel1.Controls.Add(this.Referesh_Teacher);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textbox_search_teacher_name);
            this.panel1.Controls.Add(this.Teacher_name);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 246);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.OnClickTeacher);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Delete_Teacher
            // 
            this.Delete_Teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Teacher.Location = new System.Drawing.Point(136, 161);
            this.Delete_Teacher.Name = "Delete_Teacher";
            this.Delete_Teacher.Size = new System.Drawing.Size(75, 23);
            this.Delete_Teacher.TabIndex = 9;
            this.Delete_Teacher.Text = "Delete";
            this.Delete_Teacher.UseVisualStyleBackColor = true;
            this.Delete_Teacher.Click += new System.EventHandler(this.Delete_Teacher_Click);
            // 
            // Referesh_Teacher
            // 
            this.Referesh_Teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Referesh_Teacher.Location = new System.Drawing.Point(136, 114);
            this.Referesh_Teacher.Name = "Referesh_Teacher";
            this.Referesh_Teacher.Size = new System.Drawing.Size(75, 23);
            this.Referesh_Teacher.TabIndex = 8;
            this.Referesh_Teacher.Text = "Refresh";
            this.Referesh_Teacher.UseVisualStyleBackColor = true;
            this.Referesh_Teacher.Click += new System.EventHandler(this.Referesh_Teacher_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(30, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnBackClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbox_search_teacher_name
            // 
            this.textbox_search_teacher_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_search_teacher_name.Location = new System.Drawing.Point(84, 45);
            this.textbox_search_teacher_name.Name = "textbox_search_teacher_name";
            this.textbox_search_teacher_name.Size = new System.Drawing.Size(150, 22);
            this.textbox_search_teacher_name.TabIndex = 3;
            // 
            // Teacher_name
            // 
            this.Teacher_name.AutoSize = true;
            this.Teacher_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_name.Location = new System.Drawing.Point(27, 48);
            this.Teacher_name.Name = "Teacher_name";
            this.Teacher_name.Size = new System.Drawing.Size(57, 16);
            this.Teacher_name.TabIndex = 0;
            this.Teacher_name.Text = "Name :";
            // 
            // dataGridView1_search
            // 
            this.dataGridView1_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_search.Location = new System.Drawing.Point(1, 253);
            this.dataGridView1_search.Name = "dataGridView1_search";
            this.dataGridView1_search.Size = new System.Drawing.Size(821, 259);
            this.dataGridView1_search.TabIndex = 3;
            this.dataGridView1_search.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_search_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Search_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1_search);
            this.Name = "Search_Teacher";
            this.Text = "Search_Teacher";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textbox_search_teacher_name;
        private System.Windows.Forms.Label Teacher_name;
        private System.Windows.Forms.DataGridView dataGridView1_search;
        private System.Windows.Forms.Button Delete_Teacher;
        private System.Windows.Forms.Button Referesh_Teacher;
        private System.Windows.Forms.Button button3;
    }
}