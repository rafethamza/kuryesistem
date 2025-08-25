namespace KuryeSistem
{
    partial class PaketEkle
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
            packcost = new TextBox();
            packadress = new TextBox();
            pakettarihi = new DateTimePicker();
            kuryesecbox = new ComboBox();
            packadd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // packcost
            // 
            packcost.Location = new Point(185, 67);
            packcost.Name = "packcost";
            packcost.Size = new Size(148, 27);
            packcost.TabIndex = 0;
            // 
            // packadress
            // 
            packadress.Location = new Point(353, 67);
            packadress.Name = "packadress";
            packadress.Size = new Size(241, 27);
            packadress.TabIndex = 1;
            // 
            // pakettarihi
            // 
            pakettarihi.Font = new Font("Segoe UI", 10F);
            pakettarihi.Location = new Point(615, 68);
            pakettarihi.Name = "pakettarihi";
            pakettarihi.Size = new Size(142, 30);
            pakettarihi.TabIndex = 2;
            // 
            // kuryesecbox
            // 
            kuryesecbox.FormattingEnabled = true;
            kuryesecbox.Location = new Point(12, 67);
            kuryesecbox.Name = "kuryesecbox";
            kuryesecbox.Size = new Size(151, 28);
            kuryesecbox.TabIndex = 3;
            // 
            // packadd
            // 
            packadd.Location = new Point(631, 138);
            packadd.Name = "packadd";
            packadd.Size = new Size(126, 29);
            packadd.TabIndex = 4;
            packadd.Text = "Paket Ekle";
            packadd.UseVisualStyleBackColor = true;
            packadd.Click += packadd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(185, 44);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 5;
            label1.Text = "tutarı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(353, 44);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 6;
            label2.Text = "Adresi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 37);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 7;
            label3.Text = "Kurye:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(615, 44);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 8;
            label4.Text = "Tarihi:";
            // 
            // PaketEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 179);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(packadd);
            Controls.Add(kuryesecbox);
            Controls.Add(pakettarihi);
            Controls.Add(packadress);
            Controls.Add(packcost);
            Name = "PaketEkle";
            Text = "PaketEkle";
            Load += PaketEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox packcost;
        private TextBox packadress;
        private DateTimePicker pakettarihi;
        private ComboBox kuryesecbox;
        private Button packadd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}