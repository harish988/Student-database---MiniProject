namespace Office_Server
{
    partial class Form2
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
            this.student_id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.dept_id = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.TextBox();
            this.degree = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.TextBox();
            this.insert_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // student_id
            // 
            this.student_id.Location = new System.Drawing.Point(90, 46);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(100, 20);
            this.student_id.TabIndex = 0;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(90, 94);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 1;
            // 
            // dept_id
            // 
            this.dept_id.Location = new System.Drawing.Point(319, 46);
            this.dept_id.Name = "dept_id";
            this.dept_id.Size = new System.Drawing.Size(100, 20);
            this.dept_id.TabIndex = 2;
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(319, 94);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(100, 20);
            this.dob.TabIndex = 3;
            // 
            // degree
            // 
            this.degree.Location = new System.Drawing.Point(90, 139);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(100, 20);
            this.degree.TabIndex = 4;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(319, 138);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(100, 20);
            this.address.TabIndex = 5;
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(90, 190);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(100, 20);
            this.gender.TabIndex = 6;
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(188, 250);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(101, 31);
            this.insert_btn.TabIndex = 7;
            this.insert_btn.Text = "INSERT";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student ⁯Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Degree";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Department ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "DOB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Address";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 31);
            this.button2.TabIndex = 16;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(468, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 31);
            this.button3.TabIndex = 17;
            this.button3.Text = "Get Details";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(604, 293);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.address);
            this.Controls.Add(this.degree);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.dept_id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.student_id);
            this.Name = "Form2";
            this.Text = "Insert Student";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox student_id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox dept_id;
        private System.Windows.Forms.TextBox dob;
        private System.Windows.Forms.TextBox degree;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}