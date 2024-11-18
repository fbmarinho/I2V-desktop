namespace I2V
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txbFolderPath = new System.Windows.Forms.TextBox();
            this.cmbCompression = new System.Windows.Forms.ComboBox();
            this.btnGenerateVideo = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filesList = new System.Windows.Forms.ListBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txfOutputHeight = new System.Windows.Forms.TextBox();
            this.txfOutputWidth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFramesPerSecond = new System.Windows.Forms.ComboBox();
            this.statusStrip.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(143, 267);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(61, 23);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Change";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txbFolderPath
            // 
            this.txbFolderPath.Enabled = false;
            this.txbFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFolderPath.Location = new System.Drawing.Point(6, 269);
            this.txbFolderPath.Name = "txbFolderPath";
            this.txbFolderPath.Size = new System.Drawing.Size(131, 18);
            this.txbFolderPath.TabIndex = 1;
            // 
            // cmbCompression
            // 
            this.cmbCompression.Enabled = false;
            this.cmbCompression.FormattingEnabled = true;
            this.cmbCompression.Location = new System.Drawing.Point(182, 196);
            this.cmbCompression.Name = "cmbCompression";
            this.cmbCompression.Size = new System.Drawing.Size(65, 21);
            this.cmbCompression.TabIndex = 2;
            // 
            // btnGenerateVideo
            // 
            this.btnGenerateVideo.Location = new System.Drawing.Point(9, 253);
            this.btnGenerateVideo.Name = "btnGenerateVideo";
            this.btnGenerateVideo.Size = new System.Drawing.Size(238, 23);
            this.btnGenerateVideo.TabIndex = 3;
            this.btnGenerateVideo.Text = "Generate Video";
            this.btnGenerateVideo.UseVisualStyleBackColor = true;
            this.btnGenerateVideo.Click += new System.EventHandler(this.btnGenerateVideo_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.Lime;
            this.txtLog.Location = new System.Drawing.Point(6, 296);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(457, 95);
            this.txtLog.TabIndex = 4;
            // 
            // txbOutput
            // 
            this.txbOutput.Location = new System.Drawing.Point(64, 227);
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.Size = new System.Drawing.Size(83, 20);
            this.txbOutput.TabIndex = 5;
            this.txbOutput.Text = "output_video";
            this.txbOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Location = new System.Drawing.Point(224, 225);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(23, 23);
            this.btnBackgroundColor.TabIndex = 6;
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status,
            this.progressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 394);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(471, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 7;
            // 
            // status
            // 
            this.status.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.status.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.status.Margin = new System.Windows.Forms.Padding(3, 3, 0, 2);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(351, 17);
            this.status.Spring = true;
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Image sequence:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Background:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Codec:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Filename:";
            // 
            // filesList
            // 
            this.filesList.FormattingEnabled = true;
            this.filesList.Location = new System.Drawing.Point(6, 25);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(198, 238);
            this.filesList.TabIndex = 12;
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.cmbFramesPerSecond);
            this.grpOutput.Controls.Add(this.label9);
            this.grpOutput.Controls.Add(this.label8);
            this.grpOutput.Controls.Add(this.label7);
            this.grpOutput.Controls.Add(this.label6);
            this.grpOutput.Controls.Add(this.label5);
            this.grpOutput.Controls.Add(this.txfOutputHeight);
            this.grpOutput.Controls.Add(this.txfOutputWidth);
            this.grpOutput.Controls.Add(this.label4);
            this.grpOutput.Controls.Add(this.txbOutput);
            this.grpOutput.Controls.Add(this.label2);
            this.grpOutput.Controls.Add(this.label3);
            this.grpOutput.Controls.Add(this.btnGenerateVideo);
            this.grpOutput.Controls.Add(this.cmbCompression);
            this.grpOutput.Controls.Add(this.btnBackgroundColor);
            this.grpOutput.Location = new System.Drawing.Point(210, 4);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(253, 286);
            this.grpOutput.TabIndex = 13;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Height:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Width:";
            // 
            // txfOutputHeight
            // 
            this.txfOutputHeight.Location = new System.Drawing.Point(54, 45);
            this.txfOutputHeight.Name = "txfOutputHeight";
            this.txfOutputHeight.Size = new System.Drawing.Size(50, 20);
            this.txfOutputHeight.TabIndex = 13;
            this.txfOutputHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txfOutputWidth
            // 
            this.txfOutputWidth.Location = new System.Drawing.Point(54, 21);
            this.txfOutputWidth.Name = "txfOutputWidth";
            this.txfOutputWidth.Size = new System.Drawing.Size(50, 20);
            this.txfOutputWidth.TabIndex = 12;
            this.txfOutputWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "pixels";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "pixels";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Frames/sec:";
            // 
            // cmbFramesPerSecond
            // 
            this.cmbFramesPerSecond.Enabled = false;
            this.cmbFramesPerSecond.FormattingEnabled = true;
            this.cmbFramesPerSecond.Location = new System.Drawing.Point(82, 193);
            this.cmbFramesPerSecond.Name = "cmbFramesPerSecond";
            this.cmbFramesPerSecond.Size = new System.Drawing.Size(44, 21);
            this.cmbFramesPerSecond.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 416);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.filesList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txbFolderPath);
            this.Controls.Add(this.btnSelectFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Image to Video Converter (I2V) v1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txbFolderPath;
        private System.Windows.Forms.ComboBox cmbCompression;
        private System.Windows.Forms.Button btnGenerateVideo;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txbOutput;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox filesList;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.TextBox txfOutputHeight;
        private System.Windows.Forms.TextBox txfOutputWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFramesPerSecond;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.StatusStrip statusStrip;
    }
}

