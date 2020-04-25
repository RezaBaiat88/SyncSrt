namespace UntertitelHilferApp
{
    partial class frmSrtFixer
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtSrtFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetEnd = new System.Windows.Forms.Button();
            this.endHour = new System.Windows.Forms.NumericUpDown();
            this.endMinute = new System.Windows.Forms.NumericUpDown();
            this.endSecond = new System.Windows.Forms.NumericUpDown();
            this.endMillisecond = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.startHour = new System.Windows.Forms.NumericUpDown();
            this.startMinute = new System.Windows.Forms.NumericUpDown();
            this.startSecond = new System.Windows.Forms.NumericUpDown();
            this.startMilisecond = new System.Windows.Forms.NumericUpDown();
            this.btnSelectSrtFile = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDelay = new System.Windows.Forms.Label();
            this.rtxtPreview = new System.Windows.Forms.RichTextBox();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.endHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMillisecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMilisecond)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtSrtFilePath
            // 
            this.txtSrtFilePath.Location = new System.Drawing.Point(131, 20);
            this.txtSrtFilePath.Name = "txtSrtFilePath";
            this.txtSrtFilePath.Size = new System.Drawing.Size(508, 20);
            this.txtSrtFilePath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "srt file:";
            // 
            // btnSetEnd
            // 
            this.btnSetEnd.Location = new System.Drawing.Point(371, 142);
            this.btnSetEnd.Name = "btnSetEnd";
            this.btnSetEnd.Size = new System.Drawing.Size(49, 23);
            this.btnSetEnd.TabIndex = 21;
            this.btnSetEnd.Text = "Set";
            this.btnSetEnd.UseVisualStyleBackColor = true;
            this.btnSetEnd.Click += new System.EventHandler(this.btnSetEnd_Click);
            // 
            // endHour
            // 
            this.endHour.Location = new System.Drawing.Point(131, 145);
            this.endHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.endHour.Name = "endHour";
            this.endHour.Size = new System.Drawing.Size(54, 20);
            this.endHour.TabIndex = 14;
            this.endHour.ValueChanged += new System.EventHandler(this.showPreviewChange);
            // 
            // endMinute
            // 
            this.endMinute.Location = new System.Drawing.Point(191, 145);
            this.endMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.endMinute.Name = "endMinute";
            this.endMinute.Size = new System.Drawing.Size(54, 20);
            this.endMinute.TabIndex = 16;
            this.endMinute.ValueChanged += new System.EventHandler(this.showPreviewChange);
            // 
            // endSecond
            // 
            this.endSecond.Location = new System.Drawing.Point(251, 145);
            this.endSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.endSecond.Name = "endSecond";
            this.endSecond.Size = new System.Drawing.Size(54, 20);
            this.endSecond.TabIndex = 18;
            this.endSecond.ValueChanged += new System.EventHandler(this.showPreviewChange);
            // 
            // endMillisecond
            // 
            this.endMillisecond.Location = new System.Drawing.Point(311, 145);
            this.endMillisecond.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.endMillisecond.Name = "endMillisecond";
            this.endMillisecond.Size = new System.Drawing.Size(54, 20);
            this.endMillisecond.TabIndex = 20;
            this.endMillisecond.ValueChanged += new System.EventHandler(this.showPreviewChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "hour:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "minute:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "second:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "milisecond:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "hour:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "minute:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "second:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "milisecond:";
            // 
            // startHour
            // 
            this.startHour.Location = new System.Drawing.Point(131, 80);
            this.startHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.startHour.Name = "startHour";
            this.startHour.Size = new System.Drawing.Size(54, 20);
            this.startHour.TabIndex = 5;
            // 
            // startMinute
            // 
            this.startMinute.Location = new System.Drawing.Point(191, 80);
            this.startMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.startMinute.Name = "startMinute";
            this.startMinute.Size = new System.Drawing.Size(54, 20);
            this.startMinute.TabIndex = 7;
            // 
            // startSecond
            // 
            this.startSecond.Location = new System.Drawing.Point(251, 80);
            this.startSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.startSecond.Name = "startSecond";
            this.startSecond.Size = new System.Drawing.Size(54, 20);
            this.startSecond.TabIndex = 9;
            // 
            // startMilisecond
            // 
            this.startMilisecond.Location = new System.Drawing.Point(311, 80);
            this.startMilisecond.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.startMilisecond.Name = "startMilisecond";
            this.startMilisecond.Size = new System.Drawing.Size(54, 20);
            this.startMilisecond.TabIndex = 11;
            // 
            // btnSelectSrtFile
            // 
            this.btnSelectSrtFile.Location = new System.Drawing.Point(655, 18);
            this.btnSelectSrtFile.Name = "btnSelectSrtFile";
            this.btnSelectSrtFile.Size = new System.Drawing.Size(67, 23);
            this.btnSelectSrtFile.TabIndex = 2;
            this.btnSelectSrtFile.Text = "browse";
            this.btnSelectSrtFile.UseVisualStyleBackColor = true;
            this.btnSelectSrtFile.Click += new System.EventHandler(this.btnSelectSrtFile_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "I have heard at:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "but I should hear at:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "srt file:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 410);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "delay rate:";
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(94, 410);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(13, 13);
            this.lblDelay.TabIndex = 29;
            this.lblDelay.Text = "0";
            // 
            // rtxtPreview
            // 
            this.rtxtPreview.Location = new System.Drawing.Point(27, 209);
            this.rtxtPreview.Name = "rtxtPreview";
            this.rtxtPreview.Size = new System.Drawing.Size(695, 179);
            this.rtxtPreview.TabIndex = 27;
            this.rtxtPreview.Text = "";
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(635, 170);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(87, 23);
            this.btnFindNext.TabIndex = 25;
            this.btnFindNext.Text = "Find Next (F3)";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(500, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "search for:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(503, 144);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(219, 20);
            this.txtSearch.TabIndex = 23;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(542, 170);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(87, 23);
            this.btnFind.TabIndex = 24;
            this.btnFind.Text = "Find (F2)";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Fix it";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // frmSrtFixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.rtxtPreview);
            this.Controls.Add(this.startMilisecond);
            this.Controls.Add(this.endMillisecond);
            this.Controls.Add(this.startSecond);
            this.Controls.Add(this.endSecond);
            this.Controls.Add(this.startMinute);
            this.Controls.Add(this.endMinute);
            this.Controls.Add(this.startHour);
            this.Controls.Add(this.endHour);
            this.Controls.Add(this.btnSelectSrtFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSetEnd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtSrtFilePath);
            this.KeyPreview = true;
            this.Name = "frmSrtFixer";
            this.Text = "Srt delay fixer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSrtFixer_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSrtFixer_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.endHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMillisecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMilisecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtSrtFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetEnd;
        private System.Windows.Forms.NumericUpDown endHour;
        private System.Windows.Forms.NumericUpDown endMinute;
        private System.Windows.Forms.NumericUpDown endSecond;
        private System.Windows.Forms.NumericUpDown endMillisecond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown startHour;
        private System.Windows.Forms.NumericUpDown startMinute;
        private System.Windows.Forms.NumericUpDown startSecond;
        private System.Windows.Forms.NumericUpDown startMilisecond;
        private System.Windows.Forms.Button btnSelectSrtFile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.RichTextBox rtxtPreview;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button button1;
    }
}

