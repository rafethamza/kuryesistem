namespace KuryeSistem
{
    partial class KuryeLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            usertxt = new TextBox();
            psswordtxt = new TextBox();
            loginbtn = new Button();
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(121, 133);
            label1.Name = "label1";
            label1.Size = new Size(209, 46);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(227, 212);
            label2.Name = "label2";
            label2.Size = new Size(103, 46);
            label2.TabIndex = 1;
            label2.Text = "Şifre :";
            // 
            // usertxt
            // 
            usertxt.Font = new Font("Segoe UI", 15F);
            usertxt.Location = new Point(336, 138);
            usertxt.Name = "usertxt";
            usertxt.Size = new Size(251, 41);
            usertxt.TabIndex = 2;
            usertxt.Text = "Rafet";
            // 
            // psswordtxt
            // 
            psswordtxt.Font = new Font("Segoe UI", 15F);
            psswordtxt.Location = new Point(336, 217);
            psswordtxt.Name = "psswordtxt";
            psswordtxt.Size = new Size(251, 41);
            psswordtxt.TabIndex = 3;
            psswordtxt.Text = "test1";
            psswordtxt.UseSystemPasswordChar = true;
            // 
            // loginbtn
            // 
            loginbtn.Font = new Font("Segoe UI", 13F);
            loginbtn.Location = new Point(336, 282);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(251, 42);
            loginbtn.TabIndex = 4;
            loginbtn.Text = "Giriş YAP";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 479);
            Controls.Add(loginbtn);
            Controls.Add(psswordtxt);
            Controls.Add(usertxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Yönetici Girişi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usertxt;
        private TextBox psswordtxt;
        private Button loginbtn;
    }
}
