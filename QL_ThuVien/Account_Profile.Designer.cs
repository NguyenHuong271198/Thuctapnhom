namespace QL_ThuVien
{
    partial class fAccount_Profile
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name_Login = new System.Windows.Forms.TextBox();
            this.txt_Name_Display = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pass_new = new System.Windows.Forms.TextBox();
            this.txt_Pass_Check = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÊN ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÊN HIỂN THỊ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MẬT KHẨU";
            // 
            // txt_name_Login
            // 
            this.txt_name_Login.Location = new System.Drawing.Point(140, 46);
            this.txt_name_Login.Name = "txt_name_Login";
            this.txt_name_Login.Size = new System.Drawing.Size(156, 20);
            this.txt_name_Login.TabIndex = 3;
            // 
            // txt_Name_Display
            // 
            this.txt_Name_Display.Location = new System.Drawing.Point(140, 96);
            this.txt_Name_Display.Name = "txt_Name_Display";
            this.txt_Name_Display.Size = new System.Drawing.Size(156, 20);
            this.txt_Name_Display.TabIndex = 4;
            this.txt_Name_Display.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(140, 141);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(156, 20);
            this.txt_pass.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "MẬT KHẨU MỚI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "XÁC NHẬN MẬT KHẨU";
            // 
            // txt_pass_new
            // 
            this.txt_pass_new.Location = new System.Drawing.Point(140, 181);
            this.txt_pass_new.Name = "txt_pass_new";
            this.txt_pass_new.Size = new System.Drawing.Size(156, 20);
            this.txt_pass_new.TabIndex = 8;
            // 
            // txt_Pass_Check
            // 
            this.txt_Pass_Check.Location = new System.Drawing.Point(154, 221);
            this.txt_Pass_Check.Name = "txt_Pass_Check";
            this.txt_Pass_Check.Size = new System.Drawing.Size(142, 20);
            this.txt_Pass_Check.TabIndex = 9;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(121, 270);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "UpDate";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(233, 270);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // fAccount_Profile
            // 
            this.AcceptButton = this.btn_update;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(351, 317);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_Pass_Check);
            this.Controls.Add(this.txt_pass_new);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_Name_Display);
            this.Controls.Add(this.txt_name_Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fAccount_Profile";
            this.Text = "Account_Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name_Login;
        private System.Windows.Forms.TextBox txt_Name_Display;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pass_new;
        private System.Windows.Forms.TextBox txt_Pass_Check;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Exit;
    }
}