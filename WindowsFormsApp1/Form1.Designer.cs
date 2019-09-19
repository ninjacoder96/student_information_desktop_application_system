namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_view_student = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(105, 49);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(115, 20);
            this.txt_name.TabIndex = 4;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(105, 90);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(115, 20);
            this.txt_email.TabIndex = 5;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(105, 139);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(115, 20);
            this.txt_address.TabIndex = 6;
            this.txt_address.TextChanged += new System.EventHandler(this.txt_address_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_view_student
            // 
            this.btn_view_student.Location = new System.Drawing.Point(145, 185);
            this.btn_view_student.Name = "btn_view_student";
            this.btn_view_student.Size = new System.Drawing.Size(75, 35);
            this.btn_view_student.TabIndex = 8;
            this.btn_view_student.Text = "View Student";
            this.btn_view_student.UseVisualStyleBackColor = true;
            this.btn_view_student.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_view_student);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_view_student;
    }
}

