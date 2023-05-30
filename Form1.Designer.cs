namespace Practice
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
            this.button1 = new System.Windows.Forms.Button();
            this.RAWDATA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MRB = new System.Windows.Forms.TabControl();
            this.Raw_data = new System.Windows.Forms.TabPage();
            this.ee = new System.Windows.Forms.TabPage();
            this.Summary = new System.Windows.Forms.DataGridView();
            this.MRB_100 = new System.Windows.Forms.TabPage();
            this.MRB100 = new System.Windows.Forms.DataGridView();
            this.hhh = new System.Windows.Forms.TabPage();
            this.RTC30 = new System.Windows.Forms.DataGridView();
            this.kkk = new System.Windows.Forms.TabPage();
            this.RTC50 = new System.Windows.Forms.DataGridView();
            this.uuu = new System.Windows.Forms.TabPage();
            this.RTC100 = new System.Windows.Forms.DataGridView();
            this.xx = new System.Windows.Forms.TabPage();
            this.RTV50 = new System.Windows.Forms.DataGridView();
            this.ccc = new System.Windows.Forms.TabPage();
            this.RTV100 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.Loaded_file_label = new System.Windows.Forms.Label();
            this.Target_WC_Combobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RAWDATA)).BeginInit();
            this.MRB.SuspendLayout();
            this.Raw_data.SuspendLayout();
            this.ee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Summary)).BeginInit();
            this.MRB_100.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MRB100)).BeginInit();
            this.hhh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTC30)).BeginInit();
            this.kkk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTC50)).BeginInit();
            this.uuu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTC100)).BeginInit();
            this.xx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTV50)).BeginInit();
            this.ccc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTV100)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Age report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RAWDATA
            // 
            this.RAWDATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.RAWDATA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.RAWDATA.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.RAWDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RAWDATA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RAWDATA.Location = new System.Drawing.Point(3, 3);
            this.RAWDATA.Margin = new System.Windows.Forms.Padding(0);
            this.RAWDATA.Name = "RAWDATA";
            this.RAWDATA.ReadOnly = true;
            this.RAWDATA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.RAWDATA.Size = new System.Drawing.Size(845, 460);
            this.RAWDATA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // MRB
            // 
            this.MRB.Controls.Add(this.Raw_data);
            this.MRB.Controls.Add(this.ee);
            this.MRB.Controls.Add(this.MRB_100);
            this.MRB.Controls.Add(this.hhh);
            this.MRB.Controls.Add(this.kkk);
            this.MRB.Controls.Add(this.uuu);
            this.MRB.Controls.Add(this.xx);
            this.MRB.Controls.Add(this.ccc);
            this.MRB.Location = new System.Drawing.Point(12, 81);
            this.MRB.Name = "MRB";
            this.MRB.SelectedIndex = 0;
            this.MRB.Size = new System.Drawing.Size(859, 492);
            this.MRB.TabIndex = 8;
            // 
            // Raw_data
            // 
            this.Raw_data.Controls.Add(this.RAWDATA);
            this.Raw_data.Location = new System.Drawing.Point(4, 22);
            this.Raw_data.Name = "Raw_data";
            this.Raw_data.Padding = new System.Windows.Forms.Padding(3);
            this.Raw_data.Size = new System.Drawing.Size(851, 466);
            this.Raw_data.TabIndex = 0;
            this.Raw_data.Text = "Raw data";
            this.Raw_data.UseVisualStyleBackColor = true;
            // 
            // ee
            // 
            this.ee.Controls.Add(this.Summary);
            this.ee.Location = new System.Drawing.Point(4, 22);
            this.ee.Name = "ee";
            this.ee.Padding = new System.Windows.Forms.Padding(3);
            this.ee.Size = new System.Drawing.Size(851, 466);
            this.ee.TabIndex = 1;
            this.ee.Text = "Summary";
            this.ee.UseVisualStyleBackColor = true;
            // 
            // Summary
            // 
            this.Summary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Summary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Summary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.Summary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Summary.Location = new System.Drawing.Point(-1, 0);
            this.Summary.Margin = new System.Windows.Forms.Padding(0);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(855, 460);
            this.Summary.TabIndex = 0;
            // 
            // MRB_100
            // 
            this.MRB_100.Controls.Add(this.MRB100);
            this.MRB_100.Location = new System.Drawing.Point(4, 22);
            this.MRB_100.Name = "MRB_100";
            this.MRB_100.Padding = new System.Windows.Forms.Padding(3);
            this.MRB_100.Size = new System.Drawing.Size(851, 466);
            this.MRB_100.TabIndex = 2;
            this.MRB_100.Text = "MRB 100%";
            this.MRB_100.UseVisualStyleBackColor = true;
            // 
            // MRB100
            // 
            this.MRB100.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MRB100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MRB100.Location = new System.Drawing.Point(3, 3);
            this.MRB100.Margin = new System.Windows.Forms.Padding(0);
            this.MRB100.Name = "MRB100";
            this.MRB100.Size = new System.Drawing.Size(845, 460);
            this.MRB100.TabIndex = 0;
            // 
            // hhh
            // 
            this.hhh.Controls.Add(this.RTC30);
            this.hhh.Location = new System.Drawing.Point(4, 22);
            this.hhh.Name = "hhh";
            this.hhh.Size = new System.Drawing.Size(851, 466);
            this.hhh.TabIndex = 3;
            this.hhh.Text = "RTC 30%";
            this.hhh.UseVisualStyleBackColor = true;
            // 
            // RTC30
            // 
            this.RTC30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RTC30.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RTC30.Location = new System.Drawing.Point(-3, 0);
            this.RTC30.Margin = new System.Windows.Forms.Padding(0);
            this.RTC30.Name = "RTC30";
            this.RTC30.Size = new System.Drawing.Size(854, 466);
            this.RTC30.TabIndex = 1;
            // 
            // kkk
            // 
            this.kkk.Controls.Add(this.RTC50);
            this.kkk.Location = new System.Drawing.Point(4, 22);
            this.kkk.Name = "kkk";
            this.kkk.Size = new System.Drawing.Size(851, 466);
            this.kkk.TabIndex = 4;
            this.kkk.Text = "RTC 50%";
            this.kkk.UseVisualStyleBackColor = true;
            // 
            // RTC50
            // 
            this.RTC50.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RTC50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTC50.Location = new System.Drawing.Point(0, 0);
            this.RTC50.Margin = new System.Windows.Forms.Padding(0);
            this.RTC50.Name = "RTC50";
            this.RTC50.Size = new System.Drawing.Size(851, 466);
            this.RTC50.TabIndex = 2;
            // 
            // uuu
            // 
            this.uuu.Controls.Add(this.RTC100);
            this.uuu.Location = new System.Drawing.Point(4, 22);
            this.uuu.Name = "uuu";
            this.uuu.Padding = new System.Windows.Forms.Padding(3);
            this.uuu.Size = new System.Drawing.Size(851, 466);
            this.uuu.TabIndex = 5;
            this.uuu.Text = "RTC 100%";
            this.uuu.UseVisualStyleBackColor = true;
            // 
            // RTC100
            // 
            this.RTC100.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RTC100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTC100.Location = new System.Drawing.Point(3, 3);
            this.RTC100.Margin = new System.Windows.Forms.Padding(0);
            this.RTC100.Name = "RTC100";
            this.RTC100.Size = new System.Drawing.Size(845, 460);
            this.RTC100.TabIndex = 3;
            // 
            // xx
            // 
            this.xx.Controls.Add(this.RTV50);
            this.xx.Location = new System.Drawing.Point(4, 22);
            this.xx.Name = "xx";
            this.xx.Padding = new System.Windows.Forms.Padding(3);
            this.xx.Size = new System.Drawing.Size(851, 466);
            this.xx.TabIndex = 6;
            this.xx.Text = "RTV 50%";
            this.xx.UseVisualStyleBackColor = true;
            // 
            // RTV50
            // 
            this.RTV50.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RTV50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTV50.Location = new System.Drawing.Point(3, 3);
            this.RTV50.Name = "RTV50";
            this.RTV50.Size = new System.Drawing.Size(845, 460);
            this.RTV50.TabIndex = 3;
            // 
            // ccc
            // 
            this.ccc.Controls.Add(this.RTV100);
            this.ccc.Location = new System.Drawing.Point(4, 22);
            this.ccc.Name = "ccc";
            this.ccc.Padding = new System.Windows.Forms.Padding(3);
            this.ccc.Size = new System.Drawing.Size(851, 466);
            this.ccc.TabIndex = 7;
            this.ccc.Text = "RTV 100%";
            this.ccc.UseVisualStyleBackColor = true;
            // 
            // RTV100
            // 
            this.RTV100.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RTV100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTV100.Location = new System.Drawing.Point(3, 3);
            this.RTV100.Margin = new System.Windows.Forms.Padding(0);
            this.RTV100.Name = "RTV100";
            this.RTV100.Size = new System.Drawing.Size(845, 460);
            this.RTV100.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.IndianRed;
            this.progressBar1.Location = new System.Drawing.Point(488, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(379, 36);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Loaded file:";
            // 
            // Loaded_file_label
            // 
            this.Loaded_file_label.AutoSize = true;
            this.Loaded_file_label.Location = new System.Drawing.Point(74, 59);
            this.Loaded_file_label.Name = "Loaded_file_label";
            this.Loaded_file_label.Size = new System.Drawing.Size(10, 13);
            this.Loaded_file_label.TabIndex = 13;
            this.Loaded_file_label.Text = "-";
            // 
            // Target_WC_Combobox
            // 
            this.Target_WC_Combobox.FormattingEnabled = true;
            this.Target_WC_Combobox.Location = new System.Drawing.Point(322, 17);
            this.Target_WC_Combobox.Name = "Target_WC_Combobox";
            this.Target_WC_Combobox.Size = new System.Drawing.Size(121, 21);
            this.Target_WC_Combobox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(218, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Create report for:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(883, 585);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Target_WC_Combobox);
            this.Controls.Add(this.Loaded_file_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MRB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aging forecast";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RAWDATA)).EndInit();
            this.MRB.ResumeLayout(false);
            this.Raw_data.ResumeLayout(false);
            this.ee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Summary)).EndInit();
            this.MRB_100.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MRB100)).EndInit();
            this.hhh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RTC30)).EndInit();
            this.kkk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RTC50)).EndInit();
            this.uuu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RTC100)).EndInit();
            this.xx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RTV50)).EndInit();
            this.ccc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RTV100)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView RAWDATA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl MRB;
        private System.Windows.Forms.TabPage Raw_data;
        private System.Windows.Forms.TabPage ee;
        private System.Windows.Forms.TabPage MRB_100;
        private System.Windows.Forms.TabPage hhh;
        private System.Windows.Forms.TabPage kkk;
        private System.Windows.Forms.DataGridView Summary;
        private System.Windows.Forms.DataGridView MRB100;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage uuu;
        private System.Windows.Forms.TabPage xx;
        private System.Windows.Forms.TabPage ccc;
        private System.Windows.Forms.DataGridView RTC30;
        private System.Windows.Forms.DataGridView RTC50;
        private System.Windows.Forms.DataGridView RTC100;
        private System.Windows.Forms.DataGridView RTV50;
        private System.Windows.Forms.DataGridView RTV100;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Loaded_file_label;
        private System.Windows.Forms.ComboBox Target_WC_Combobox;
        private System.Windows.Forms.Label label6;
    }
}

