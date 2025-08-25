namespace KuryeSistem
{
    partial class KuryeGiris
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
            groupBox1 = new GroupBox();
            dtGridViewLog = new DataGridView();
            kuryekayitgrp = new GroupBox();
            kuryetcnotxt = new TextBox();
            kuryeEkleBtn = new Button();
            baslangictarihlabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            kuryeadrestxt = new RichTextBox();
            kuryenotxt = new RichTextBox();
            kuryeisimtxt = new RichTextBox();
            TCnolabel = new Label();
            Adreslabel = new Label();
            NumaraLabel = new Label();
            kuryeisimlbl = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridViewLog).BeginInit();
            kuryekayitgrp.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtGridViewLog);
            groupBox1.Location = new Point(12, 300);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1037, 251);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Son İşlemler";
            // 
            // dtGridViewLog
            // 
            dtGridViewLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridViewLog.Dock = DockStyle.Fill;
            dtGridViewLog.Location = new Point(3, 23);
            dtGridViewLog.Name = "dtGridViewLog";
            dtGridViewLog.RowHeadersWidth = 51;
            dtGridViewLog.Size = new Size(1031, 225);
            dtGridViewLog.TabIndex = 0;
            dtGridViewLog.CellDoubleClick += dtGridViewLog_CellDoubleClick;
            // 
            // kuryekayitgrp
            // 
            kuryekayitgrp.Controls.Add(kuryetcnotxt);
            kuryekayitgrp.Controls.Add(kuryeEkleBtn);
            kuryekayitgrp.Controls.Add(baslangictarihlabel);
            kuryekayitgrp.Controls.Add(dateTimePicker1);
            kuryekayitgrp.Controls.Add(kuryeadrestxt);
            kuryekayitgrp.Controls.Add(kuryenotxt);
            kuryekayitgrp.Controls.Add(kuryeisimtxt);
            kuryekayitgrp.Controls.Add(TCnolabel);
            kuryekayitgrp.Controls.Add(Adreslabel);
            kuryekayitgrp.Controls.Add(NumaraLabel);
            kuryekayitgrp.Controls.Add(kuryeisimlbl);
            kuryekayitgrp.Location = new Point(15, 5);
            kuryekayitgrp.Name = "kuryekayitgrp";
            kuryekayitgrp.Size = new Size(1026, 289);
            kuryekayitgrp.TabIndex = 1;
            kuryekayitgrp.TabStop = false;
            kuryekayitgrp.Text = "Kurye Kayıt";
            // 
            // kuryetcnotxt
            // 
            kuryetcnotxt.Location = new Point(140, 224);
            kuryetcnotxt.MaxLength = 11;
            kuryetcnotxt.Name = "kuryetcnotxt";
            kuryetcnotxt.Size = new Size(244, 27);
            kuryetcnotxt.TabIndex = 11;
            kuryetcnotxt.Text = " ";
            // 
            // kuryeEkleBtn
            // 
            kuryeEkleBtn.Font = new Font("Segoe UI", 20F);
            kuryeEkleBtn.Location = new Point(541, 131);
            kuryeEkleBtn.Name = "kuryeEkleBtn";
            kuryeEkleBtn.Size = new Size(247, 109);
            kuryeEkleBtn.TabIndex = 10;
            kuryeEkleBtn.Text = "Kurye Ekle";
            kuryeEkleBtn.UseVisualStyleBackColor = true;
            kuryeEkleBtn.Click += kuryeEkleBtn_Click;
            // 
            // baslangictarihlabel
            // 
            baslangictarihlabel.AutoSize = true;
            baslangictarihlabel.Font = new Font("Segoe UI", 15F);
            baslangictarihlabel.Location = new Point(488, 41);
            baslangictarihlabel.Name = "baslangictarihlabel";
            baslangictarihlabel.Size = new Size(210, 35);
            baslangictarihlabel.TabIndex = 9;
            baslangictarihlabel.Text = "İşe Başlama Tarihi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(704, 48);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(139, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // kuryeadrestxt
            // 
            kuryeadrestxt.Location = new Point(140, 165);
            kuryeadrestxt.Name = "kuryeadrestxt";
            kuryeadrestxt.Size = new Size(244, 30);
            kuryeadrestxt.TabIndex = 6;
            kuryeadrestxt.Text = "";
            // 
            // kuryenotxt
            // 
            kuryenotxt.Location = new Point(140, 99);
            kuryenotxt.MaxLength = 11;
            kuryenotxt.Name = "kuryenotxt";
            kuryenotxt.Size = new Size(244, 30);
            kuryenotxt.TabIndex = 5;
            kuryenotxt.Text = "";
            // 
            // kuryeisimtxt
            // 
            kuryeisimtxt.Location = new Point(140, 45);
            kuryeisimtxt.Name = "kuryeisimtxt";
            kuryeisimtxt.Size = new Size(244, 30);
            kuryeisimtxt.TabIndex = 4;
            kuryeisimtxt.Text = "";
            // 
            // TCnolabel
            // 
            TCnolabel.AutoSize = true;
            TCnolabel.Font = new Font("Segoe UI", 15F);
            TCnolabel.Location = new Point(24, 216);
            TCnolabel.Name = "TCnolabel";
            TCnolabel.Size = new Size(92, 35);
            TCnolabel.TabIndex = 3;
            TCnolabel.Text = "TC NO:";
            // 
            // Adreslabel
            // 
            Adreslabel.AutoSize = true;
            Adreslabel.Font = new Font("Segoe UI", 15F);
            Adreslabel.Location = new Point(24, 156);
            Adreslabel.Name = "Adreslabel";
            Adreslabel.Size = new Size(84, 35);
            Adreslabel.TabIndex = 2;
            Adreslabel.Text = "Adres:";
            // 
            // NumaraLabel
            // 
            NumaraLabel.AutoSize = true;
            NumaraLabel.Font = new Font("Segoe UI", 15F);
            NumaraLabel.Location = new Point(24, 94);
            NumaraLabel.Name = "NumaraLabel";
            NumaraLabel.Size = new Size(110, 35);
            NumaraLabel.TabIndex = 1;
            NumaraLabel.Text = "Numara:";
            // 
            // kuryeisimlbl
            // 
            kuryeisimlbl.AutoSize = true;
            kuryeisimlbl.Font = new Font("Segoe UI", 15F);
            kuryeisimlbl.Location = new Point(24, 40);
            kuryeisimlbl.Name = "kuryeisimlbl";
            kuryeisimlbl.Size = new Size(66, 35);
            kuryeisimlbl.TabIndex = 0;
            kuryeisimlbl.Text = "İsmi:";
            // 
            // KuryeGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 558);
            Controls.Add(kuryekayitgrp);
            Controls.Add(groupBox1);
            Name = "KuryeGiris";
            Text = "KuryeGiris";
            FormClosed += KuryeGiris_FormClosed;
            Load += KuryeGiris_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGridViewLog).EndInit();
            kuryekayitgrp.ResumeLayout(false);
            kuryekayitgrp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dtGridViewLog;
        private GroupBox kuryekayitgrp;
        private Label baslangictarihlabel;
        private DateTimePicker dateTimePicker1;
        private RichTextBox kuryeadrestxt;
        private RichTextBox kuryenotxt;
        private RichTextBox kuryeisimtxt;
        private Label TCnolabel;
        private Label Adreslabel;
        private Label NumaraLabel;
        private Label kuryeisimlbl;
        private Button kuryeEkleBtn;
        private TextBox kuryetcnotxt;
    }
}