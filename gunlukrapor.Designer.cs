namespace KuryeSistem
{
    partial class gunlukrapor
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
            label1 = new Label();
            kuryesecbox = new ComboBox();
            label2 = new Label();
            paketListGridView = new DataGridView();
            label3 = new Label();
            ortuttarlbl = new Label();
            kuryepktlist = new RadioButton();
            comboBox1 = new ComboBox();
            tumpktlist = new RadioButton();
            button1 = new Button();
            label4 = new Label();
            toplamtutarlbl = new Label();
            tarihsec = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)paketListGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(411, 83);
            label1.Name = "label1";
            label1.Size = new Size(25, 30);
            label1.TabIndex = 0;
            label1.Text = "0";
            // 
            // kuryesecbox
            // 
            kuryesecbox.FormattingEnabled = true;
            kuryesecbox.Location = new Point(12, 12);
            kuryesecbox.Name = "kuryesecbox";
            kuryesecbox.Size = new Size(151, 28);
            kuryesecbox.TabIndex = 1;
            kuryesecbox.SelectedIndexChanged += kuryesecbox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(265, 78);
            label2.Name = "label2";
            label2.Size = new Size(147, 35);
            label2.TabIndex = 2;
            label2.Text = "Paket Sayısı:";
            // 
            // paketListGridView
            // 
            paketListGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paketListGridView.Location = new Point(12, 148);
            paketListGridView.Name = "paketListGridView";
            paketListGridView.RowHeadersWidth = 51;
            paketListGridView.Size = new Size(888, 326);
            paketListGridView.TabIndex = 3;
            paketListGridView.MouseDoubleClick += paketListGridView_MouseDoubleClick_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(218, 43);
            label3.Name = "label3";
            label3.Size = new Size(194, 35);
            label3.TabIndex = 4;
            label3.Text = "Ortalama Tutar: ";
            // 
            // ortuttarlbl
            // 
            ortuttarlbl.AutoSize = true;
            ortuttarlbl.Font = new Font("Segoe UI", 13F);
            ortuttarlbl.Location = new Point(411, 50);
            ortuttarlbl.Name = "ortuttarlbl";
            ortuttarlbl.Size = new Size(25, 30);
            ortuttarlbl.TabIndex = 5;
            ortuttarlbl.Text = "0";
            // 
            // kuryepktlist
            // 
            kuryepktlist.AutoSize = true;
            kuryepktlist.Location = new Point(755, 50);
            kuryepktlist.Name = "kuryepktlist";
            kuryepktlist.Size = new Size(145, 24);
            kuryepktlist.TabIndex = 6;
            kuryepktlist.TabStop = true;
            kuryepktlist.Text = "Kuryeninkini getir";
            kuryepktlist.UseVisualStyleBackColor = true;
            kuryepktlist.CheckedChanged += kuryepktlist_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Hepsi", "Günlük", "Aylık", "Yıllık" });
            comboBox1.Location = new Point(759, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 28);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tumpktlist
            // 
            tumpktlist.AutoSize = true;
            tumpktlist.Location = new Point(755, 18);
            tumpktlist.Name = "tumpktlist";
            tumpktlist.Size = new Size(68, 24);
            tumpktlist.TabIndex = 8;
            tumpktlist.TabStop = true;
            tumpktlist.Text = "Hepsi";
            tumpktlist.UseVisualStyleBackColor = true;
            tumpktlist.CheckedChanged += tumpktlist_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 64);
            button1.Name = "button1";
            button1.Size = new Size(115, 72);
            button1.TabIndex = 9;
            button1.Text = "EXCEL' E\r\nAKTAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(239, 7);
            label4.Name = "label4";
            label4.Size = new Size(166, 35);
            label4.TabIndex = 10;
            label4.Text = "Toplam Tutar:";
            // 
            // toplamtutarlbl
            // 
            toplamtutarlbl.AutoSize = true;
            toplamtutarlbl.Font = new Font("Segoe UI", 13F);
            toplamtutarlbl.Location = new Point(411, 12);
            toplamtutarlbl.Name = "toplamtutarlbl";
            toplamtutarlbl.Size = new Size(25, 30);
            toplamtutarlbl.TabIndex = 11;
            toplamtutarlbl.Text = "0";
            // 
            // tarihsec
            // 
            tarihsec.CustomFormat = "";
            tarihsec.Location = new Point(616, 84);
            tarihsec.Name = "tarihsec";
            tarihsec.Size = new Size(137, 27);
            tarihsec.TabIndex = 12;
            tarihsec.ValueChanged += tarihsec_ValueChanged;
            // 
            // gunlukrapor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 483);
            Controls.Add(tarihsec);
            Controls.Add(toplamtutarlbl);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(tumpktlist);
            Controls.Add(comboBox1);
            Controls.Add(kuryepktlist);
            Controls.Add(ortuttarlbl);
            Controls.Add(label3);
            Controls.Add(paketListGridView);
            Controls.Add(label2);
            Controls.Add(kuryesecbox);
            Controls.Add(label1);
            Name = "gunlukrapor";
            Text = "gunlukrapor";
            Load += gunlukrapor_Load;
            ((System.ComponentModel.ISupportInitialize)paketListGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox kuryesecbox;
        private Label label2;
        private DataGridView paketListGridView;
        private Label label3;
        private Label ortuttarlbl;
        private RadioButton kuryepktlist;
        private ComboBox comboBox1;
        private RadioButton tumpktlist;
        private Button button1;
        private Label label4;
        private Label toplamtutarlbl;
        private DateTimePicker tarihsec;
    }
}