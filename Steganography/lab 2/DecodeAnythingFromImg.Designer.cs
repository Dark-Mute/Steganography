﻿namespace lab_2
{
    partial class DecodeAnythingFromImg
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
            this.decode = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loadFile = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.pictureEncodeBefore = new System.Windows.Forms.PictureBox();
            this.isSteganograph = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEncodeBefore)).BeginInit();
            this.SuspendLayout();
            // 
            // decode
            // 
            this.decode.Location = new System.Drawing.Point(15, 178);
            this.decode.Name = "decode";
            this.decode.Size = new System.Drawing.Size(170, 23);
            this.decode.TabIndex = 47;
            this.decode.Text = "Dekodój";
            this.decode.UseVisualStyleBackColor = true;
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Wybież na ilu bitach plik został zakodowany";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 57;
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(18, 21);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(170, 23);
            this.loadFile.TabIndex = 56;
            this.loadFile.Text = "Wybież zdjęcie do dekodowania";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox3.Location = new System.Drawing.Point(157, 119);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(46, 21);
            this.comboBox3.TabIndex = 55;
            this.comboBox3.Text = "1";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox2.Location = new System.Drawing.Point(90, 119);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(46, 21);
            this.comboBox2.TabIndex = 54;
            this.comboBox2.Text = "1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox1.Location = new System.Drawing.Point(26, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(46, 21);
            this.comboBox1.TabIndex = 53;
            this.comboBox1.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Blue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Green";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Red";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(15, 215);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 49;
            // 
            // pictureEncodeBefore
            // 
            this.pictureEncodeBefore.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureEncodeBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureEncodeBefore.Location = new System.Drawing.Point(356, 61);
            this.pictureEncodeBefore.Name = "pictureEncodeBefore";
            this.pictureEncodeBefore.Size = new System.Drawing.Size(1192, 781);
            this.pictureEncodeBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEncodeBefore.TabIndex = 48;
            this.pictureEncodeBefore.TabStop = false;
            this.pictureEncodeBefore.Click += new System.EventHandler(this.pictureEncodeBefore_Click);
            // 
            // isSteganograph
            // 
            this.isSteganograph.AutoSize = true;
            this.isSteganograph.Location = new System.Drawing.Point(203, 26);
            this.isSteganograph.Name = "isSteganograph";
            this.isSteganograph.Size = new System.Drawing.Size(0, 13);
            this.isSteganograph.TabIndex = 59;
            // 
            // DecodeAnythingFromImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 854);
            this.Controls.Add(this.isSteganograph);
            this.Controls.Add(this.decode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadFile);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.message);
            this.Controls.Add(this.pictureEncodeBefore);
            this.Name = "DecodeAnythingFromImg";
            this.Text = "DecodeAnythingFromImg";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEncodeBefore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button decode;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.PictureBox pictureEncodeBefore;
        private System.Windows.Forms.Label isSteganograph;
    }
}