namespace KuryeSistem
{
    partial class LogPanel
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
            logPanelGridView = new DataGridView();
            excelbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)logPanelGridView).BeginInit();
            SuspendLayout();
            // 
            // logPanelGridView
            // 
            logPanelGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            logPanelGridView.Location = new Point(0, 0);
            logPanelGridView.Name = "logPanelGridView";
            logPanelGridView.RowHeadersWidth = 51;
            logPanelGridView.Size = new Size(681, 559);
            logPanelGridView.TabIndex = 2;
            // 
            // excelbtn
            // 
            excelbtn.Location = new Point(687, 0);
            excelbtn.Name = "excelbtn";
            excelbtn.Size = new Size(222, 102);
            excelbtn.TabIndex = 3;
            excelbtn.Text = "EXCEL'E AKTAR";
            excelbtn.UseVisualStyleBackColor = true;
            excelbtn.Click += excelbtn_Click;
            // 
            // LogPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 498);
            Controls.Add(excelbtn);
            Controls.Add(logPanelGridView);
            Name = "LogPanel";
            Text = "LogPanel";
            Load += LogPanel_Load;
            ((System.ComponentModel.ISupportInitialize)logPanelGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView logPanelGridView;
        private Button excelbtn;
    }
}