namespace lab_2
{
    partial class EncodeAnythingInImg
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
            this.label3 = new System.Windows.Forms.Label();
            this.takenLabel = new System.Windows.Forms.Label();
            this.maxsizeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.decodeLabel = new System.Windows.Forms.Label();
            this.encodeLabel = new System.Windows.Forms.Label();
            this.loadFileToBeEncoded = new System.Windows.Forms.Button();
            this.loadFile = new System.Windows.Forms.Button();
            this.encode = new System.Windows.Forms.Button();
            this.pictureEncodeBefore = new System.Windows.Forms.PictureBox();
            this.isSteganograph = new System.Windows.Forms.Label();
            this.pictureEncodeAfter = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maxSizeOfImg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEncodeBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEncodeAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(801, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "/";
            // 
            // takenLabel
            // 
            this.takenLabel.AutoSize = true;
            this.takenLabel.Location = new System.Drawing.Point(819, 226);
            this.takenLabel.Name = "takenLabel";
            this.takenLabel.Size = new System.Drawing.Size(0, 13);
            this.takenLabel.TabIndex = 75;
            // 
            // maxsizeLabel
            // 
            this.maxsizeLabel.AutoSize = true;
            this.maxsizeLabel.Location = new System.Drawing.Point(749, 226);
            this.maxsizeLabel.Name = "maxsizeLabel";
            this.maxsizeLabel.Size = new System.Drawing.Size(0, 13);
            this.maxsizeLabel.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(680, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Wybież na ilu bitach plik będzie zakodowany";
            this.label7.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(919, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(688, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Zajęto:";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.progressBar1.Location = new System.Drawing.Point(734, 187);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(179, 23);
            this.progressBar1.TabIndex = 70;
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
            this.comboBox3.Location = new System.Drawing.Point(834, 152);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(46, 21);
            this.comboBox3.TabIndex = 69;
            this.comboBox3.Text = "1";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.onValueHange);
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
            this.comboBox2.Location = new System.Drawing.Point(767, 152);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(46, 21);
            this.comboBox2.TabIndex = 68;
            this.comboBox2.Text = "1";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.onValueHange);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
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
            this.comboBox1.Location = new System.Drawing.Point(703, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(46, 21);
            this.comboBox1.TabIndex = 67;
            this.comboBox1.Text = "1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.onValueHange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(852, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Blue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(777, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Green";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(700, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Red";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(668, 327);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 63;
            // 
            // decodeLabel
            // 
            this.decodeLabel.AutoSize = true;
            this.decodeLabel.Location = new System.Drawing.Point(688, 46);
            this.decodeLabel.Name = "decodeLabel";
            this.decodeLabel.Size = new System.Drawing.Size(0, 13);
            this.decodeLabel.TabIndex = 62;
            // 
            // encodeLabel
            // 
            this.encodeLabel.AutoSize = true;
            this.encodeLabel.Location = new System.Drawing.Point(12, 42);
            this.encodeLabel.Name = "encodeLabel";
            this.encodeLabel.Size = new System.Drawing.Size(0, 13);
            this.encodeLabel.TabIndex = 61;
            // 
            // loadFileToBeEncoded
            // 
            this.loadFileToBeEncoded.Location = new System.Drawing.Point(689, 20);
            this.loadFileToBeEncoded.Name = "loadFileToBeEncoded";
            this.loadFileToBeEncoded.Size = new System.Drawing.Size(209, 23);
            this.loadFileToBeEncoded.TabIndex = 60;
            this.loadFileToBeEncoded.Text = "Wybeż plik do zakodowania";
            this.loadFileToBeEncoded.UseVisualStyleBackColor = true;
            this.loadFileToBeEncoded.Click += new System.EventHandler(this.loadFileToBeEncoded_Click);
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(13, 15);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(276, 23);
            this.loadFile.TabIndex = 59;
            this.loadFile.Text = "Wybeż zdjęcie w którym będzie zakodowany plik";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // encode
            // 
            this.encode.Location = new System.Drawing.Point(689, 288);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(209, 23);
            this.encode.TabIndex = 58;
            this.encode.Text = "Zakodój";
            this.encode.UseVisualStyleBackColor = true;
            this.encode.Click += new System.EventHandler(this.encode_Click);
            // 
            // pictureEncodeBefore
            // 
            this.pictureEncodeBefore.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureEncodeBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureEncodeBefore.Location = new System.Drawing.Point(12, 74);
            this.pictureEncodeBefore.Name = "pictureEncodeBefore";
            this.pictureEncodeBefore.Size = new System.Drawing.Size(654, 651);
            this.pictureEncodeBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEncodeBefore.TabIndex = 56;
            this.pictureEncodeBefore.TabStop = false;
            this.pictureEncodeBefore.Click += new System.EventHandler(this.pictureEncodeBefore_Click);
            // 
            // isSteganograph
            // 
            this.isSteganograph.AutoSize = true;
            this.isSteganograph.Location = new System.Drawing.Point(295, 20);
            this.isSteganograph.Name = "isSteganograph";
            this.isSteganograph.Size = new System.Drawing.Size(0, 13);
            this.isSteganograph.TabIndex = 77;
            // 
            // pictureEncodeAfter
            // 
            this.pictureEncodeAfter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureEncodeAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureEncodeAfter.Location = new System.Drawing.Point(965, 74);
            this.pictureEncodeAfter.Name = "pictureEncodeAfter";
            this.pictureEncodeAfter.Size = new System.Drawing.Size(680, 651);
            this.pictureEncodeAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEncodeAfter.TabIndex = 78;
            this.pictureEncodeAfter.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(962, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 79;
            this.label8.Text = "Wynik ukrycia pliku w zdjęciu:\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(700, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 13);
            this.label9.TabIndex = 82;
            this.label9.Text = "Maksymalna pojemnośc zdjęcia:";
            // 
            // maxSizeOfImg
            // 
            this.maxSizeOfImg.AutoSize = true;
            this.maxSizeOfImg.Location = new System.Drawing.Point(865, 256);
            this.maxSizeOfImg.Name = "maxSizeOfImg";
            this.maxSizeOfImg.Size = new System.Drawing.Size(0, 13);
            this.maxSizeOfImg.TabIndex = 81;
            // 
            // EncodeAnythingInImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 811);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maxSizeOfImg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureEncodeAfter);
            this.Controls.Add(this.isSteganograph);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.takenLabel);
            this.Controls.Add(this.maxsizeLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.message);
            this.Controls.Add(this.decodeLabel);
            this.Controls.Add(this.encodeLabel);
            this.Controls.Add(this.loadFileToBeEncoded);
            this.Controls.Add(this.loadFile);
            this.Controls.Add(this.encode);
            this.Controls.Add(this.pictureEncodeBefore);
            this.Name = "EncodeAnythingInImg";
            this.Text = "EncodeAnythingInImg";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEncodeBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEncodeAfter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label takenLabel;
        private System.Windows.Forms.Label maxsizeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label decodeLabel;
        private System.Windows.Forms.Label encodeLabel;
        private System.Windows.Forms.Button loadFileToBeEncoded;
        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.Button encode;
        private System.Windows.Forms.PictureBox pictureEncodeBefore;
        private System.Windows.Forms.Label isSteganograph;
        private System.Windows.Forms.PictureBox pictureEncodeAfter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label maxSizeOfImg;
    }
}