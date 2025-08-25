namespace KuryeSistem
{
    partial class Arayuz
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
            kuryebtn = new Button();
            groupBox1 = new GroupBox();
            guncelpaketdtgridview = new DataGridView();
            groupBox2 = new GroupBox();
            aktifkuryelist = new ListBox();
            paketadd = new Button();
            logbtn = new Button();
            gunlukraporbtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guncelpaketdtgridview).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // kuryebtn
            // 
            kuryebtn.Font = new Font("Segoe UI", 15F);
            kuryebtn.Location = new Point(570, 19);
            kuryebtn.Name = "kuryebtn";
            kuryebtn.Size = new Size(233, 45);
            kuryebtn.TabIndex = 0;
            kuryebtn.Text = "Kurye Ekle";
            kuryebtn.UseVisualStyleBackColor = true;
            kuryebtn.Click += kuryebtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(guncelpaketdtgridview);
            groupBox1.Location = new Point(8, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(798, 380);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Son Paketler";
            // 
            // guncelpaketdtgridview
            // 
            guncelpaketdtgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            guncelpaketdtgridview.Dock = DockStyle.Fill;
            guncelpaketdtgridview.Location = new Point(3, 23);
            guncelpaketdtgridview.MultiSelect = false;
            guncelpaketdtgridview.Name = "guncelpaketdtgridview";
            guncelpaketdtgridview.RowHeadersWidth = 51;
            guncelpaketdtgridview.Size = new Size(792, 354);
            guncelpaketdtgridview.TabIndex = 0;
            guncelpaketdtgridview.MouseDoubleClick += guncelpaketdtgridview_MouseDoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(aktifkuryelist);
            groupBox2.Location = new Point(809, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(286, 524);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Aktif Kuryeler";
            // 
            // aktifkuryelist
            // 
            aktifkuryelist.FormattingEnabled = true;
            aktifkuryelist.Location = new Point(6, 26);
            aktifkuryelist.Name = "aktifkuryelist";
            aktifkuryelist.Size = new Size(274, 484);
            aktifkuryelist.TabIndex = 0;
            // 
            // paketadd
            // 
            paketadd.Font = new Font("Segoe UI", 15F);
            paketadd.Location = new Point(8, 91);
            paketadd.Name = "paketadd";
            paketadd.Size = new Size(257, 62);
            paketadd.TabIndex = 1;
            paketadd.Text = "Paket Ekle";
            paketadd.UseVisualStyleBackColor = true;
            paketadd.Click += paketadd_Click;
            // 
            // logbtn
            // 
            logbtn.Font = new Font("Segoe UI", 15F);
            logbtn.Location = new Point(574, 121);
            logbtn.Name = "logbtn";
            logbtn.Size = new Size(229, 46);
            logbtn.TabIndex = 3;
            logbtn.Text = "Log Kayıtları";
            logbtn.UseVisualStyleBackColor = true;
            logbtn.Click += logbtn_Click;
            // 
            // gunlukraporbtn
            // 
            gunlukraporbtn.Font = new Font("Segoe UI", 15F);
            gunlukraporbtn.Location = new Point(574, 70);
            gunlukraporbtn.Name = "gunlukraporbtn";
            gunlukraporbtn.Size = new Size(229, 45);
            gunlukraporbtn.TabIndex = 4;
            gunlukraporbtn.Text = "Günlük Rapor Çıkar";
            gunlukraporbtn.UseVisualStyleBackColor = true;
            gunlukraporbtn.Click += gunlukraporbtn_Click;
            // 
            // Arayuz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 540);
            Controls.Add(gunlukraporbtn);
            Controls.Add(logbtn);
            Controls.Add(paketadd);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(kuryebtn);
            Name = "Arayuz";
            Text = "Arayuz";
            FormClosed += Arayuz_FormClosed;
            Load += Arayuz_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guncelpaketdtgridview).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button kuryebtn;
        private GroupBox groupBox1;
        private DataGridView guncelpaketdtgridview;
        private GroupBox groupBox2;
        private ListBox aktifkuryelist;
        private Button paketadd;
        private Button logbtn;
        private Button gunlukraporbtn;
    }
}