namespace Primary_School
{
    partial class Search_Gurdian
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
            this.textbox2_search_gurdian = new System.Windows.Forms.TextBox();
            this.textbox1_Search_Gurdian = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.dataGridView_gurdian = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_gurdian)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox2_search_gurdian
            // 
            this.textbox2_search_gurdian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox2_search_gurdian.Location = new System.Drawing.Point(123, 63);
            this.textbox2_search_gurdian.Name = "textbox2_search_gurdian";
            this.textbox2_search_gurdian.Size = new System.Drawing.Size(100, 22);
            this.textbox2_search_gurdian.TabIndex = 8;
            // 
            // textbox1_Search_Gurdian
            // 
            this.textbox1_Search_Gurdian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox1_Search_Gurdian.Location = new System.Drawing.Point(123, 24);
            this.textbox1_Search_Gurdian.Name = "textbox1_Search_Gurdian";
            this.textbox1_Search_Gurdian.Size = new System.Drawing.Size(100, 22);
            this.textbox1_Search_Gurdian.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Student Id :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(35, 111);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 9;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(148, 111);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 10;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // dataGridView_gurdian
            // 
            this.dataGridView_gurdian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_gurdian.Location = new System.Drawing.Point(12, 182);
            this.dataGridView_gurdian.Name = "dataGridView_gurdian";
            this.dataGridView_gurdian.Size = new System.Drawing.Size(453, 180);
            this.dataGridView_gurdian.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.textbox1_Search_Gurdian);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.textbox2_search_gurdian);
            this.panel1.Location = new System.Drawing.Point(106, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 164);
            this.panel1.TabIndex = 12;
            // 
            // Search_Gurdian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(466, 374);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_gurdian);
            this.Name = "Search_Gurdian";
            this.Text = "Search_Gurdian";
            this.Load += new System.EventHandler(this.Search_Gurdian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_gurdian)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textbox2_search_gurdian;
        private System.Windows.Forms.TextBox textbox1_Search_Gurdian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView dataGridView_gurdian;
        private System.Windows.Forms.Panel panel1;
    }
}