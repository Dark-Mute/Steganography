namespace lab_2
{
    partial class EncodeImgInImg
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
            this.decodeLabel = new System.Windows.Forms.Label();
            this.encodeLabel = new System.Windows.Forms.Label();
            this.loadFileToBeEncoded = new System.Windows.Forms.Button();
            this.loadFile = new System.Windows.Forms.Button();
            this.encode = new System.Windows.Forms.Button();
            this.pictureEncodeAfter = new System.Windows.Forms.PictureBox();
            this.pictureEncodeBefore = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureEncodeBefore2 = new System.Windows.Forms.PictureBox();
            this.message = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.takenLabel = new System.Windows.Forms.Label();
            this.maxsizeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isSteganograph = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEncodeAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEncodeBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEncodeBefore2)).BeginInit();
            this.SuspendLayout();
            // 
            // decodeLabel
            // 
            this.decodeLabel.AutoSize = true;
            this.decodeLabel.Location = new System.Drawing.Point(404, 52);
            this.decodeLabel.Name = "decodeLabel";
            this.decodeLabel.Size = new System.Drawing.Size(0, 13);
            this.decodeLabel.TabIndex = 21;
            // 
            // encodeLabel
            // 
            this.encodeLabel.AutoSize = true;
            this.encodeLabel.Location = new System.Drawing.Point(20, 42);
            this.encodeLabel.Name = "encodeLabel";
            this.encodeLabel.Size = new System.Drawing.Size(0, 13);
            this.encodeLabel.TabIndex = 20;
            // 
            // loadFileToBeEncoded
            // 
            this.loadFileToBeEncoded.Location = new System.Drawing.Point(407, 7);
            this.loadFileToBeEncoded.Name = "loadFileToBeEncoded";
            this.loadFileToBeEncoded.Size = new System.Drawing.Size(206, 23);
            this.loadFileToBeEncoded.TabIndex = 19;
            this.loadFileToBeEncoded.Text = "Wybeż zdjęcie które będzie zakodowane";
            this.loadFileToBeEncoded.UseVisualStyleBackColor = true;
            this.loadFileToBeEncoded.Click += new System.EventHandler(this.loadFileToBeEncoded_Click);
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(23, 7);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(283, 23);
            this.loadFile.TabIndex = 18;
            this.loadFile.Text = "Wybeż zdjęcie w którym będzie zakodowane zdjęcie";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // encode
            // 
            this.encode.Location = new System.Drawing.Point(56, 631);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(170, 23);
            this.encode.TabIndex = 16;
            this.encode.Text = "Zakodój";
            this.encode.UseVisualStyleBackColor = true;
            this.encode.Click += new System.EventHandler(this.encode_Click);
            // 
            // pictureEncodeAfter
            // 
            this.pictureEncodeAfter.Location = new System.Drawing.Point(824, 34);
            this.pictureEncodeAfter.Name = "pictureEncodeAfter";
            this.pictureEncodeAfter.Size = new System.Drawing.Size(721, 692);
            this.pictureEncodeAfter.TabIndex = 15;
            this.pictureEncodeAfter.TabStop = false;
            // 
            // pictureEncodeBefore
            // 
            this.pictureEncodeBefore.Location = new System.Drawing.Point(12, 107);
            this.pictureEncodeBefore.Name = "pictureEncodeBefore";
            this.pictureEncodeBefore.Size = new System.Drawing.Size(369, 351);
            this.pictureEncodeBefore.TabIndex = 14;
            this.pictureEncodeBefore.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureEncodeBefore2
            // 
            this.pictureEncodeBefore2.Location = new System.Drawing.Point(396, 107);
            this.pictureEncodeBefore2.Name = "pictureEncodeBefore2";
            this.pictureEncodeBefore2.Size = new System.Drawing.Size(411, 351);
            this.pictureEncodeBefore2.TabIndex = 31;
            this.pictureEncodeBefore2.TabStop = false;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(57, 681);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 32;
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
            this.comboBox3.Location = new System.Drawing.Point(195, 523);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(46, 21);
            this.comboBox3.TabIndex = 40;
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
            this.comboBox2.Location = new System.Drawing.Point(128, 523);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(46, 21);
            this.comboBox2.TabIndex = 39;
            this.comboBox2.Text = "1";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.onValueHange);
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
            this.comboBox1.Location = new System.Drawing.Point(64, 523);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(46, 21);
            this.comboBox1.TabIndex = 38;
            this.comboBox1.Text = "1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.onValueHange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Blue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Green";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Red";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(59, 565);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(212, 23);
            this.progressBar1.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Zajęto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 570);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Wybież na ilu bitach plik będzie zakodowany";
            this.label7.Visible = false;
            // 
            // takenLabel
            // 
            this.takenLabel.AutoSize = true;
            this.takenLabel.Location = new System.Drawing.Point(174, 602);
            this.takenLabel.Name = "takenLabel";
            this.takenLabel.Size = new System.Drawing.Size(0, 13);
            this.takenLabel.TabIndex = 54;
            // 
            // maxsizeLabel
            // 
            this.maxsizeLabel.AutoSize = true;
            this.maxsizeLabel.Location = new System.Drawing.Point(58, 602);
            this.maxsizeLabel.Name = "maxsizeLabel";
            this.maxsizeLabel.Size = new System.Drawing.Size(0, 13);
            this.maxsizeLabel.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 602);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "/";
            // 
            // isSteganograph
            // 
            this.isSteganograph.AutoSize = true;
            this.isSteganograph.Location = new System.Drawing.Point(20, 72);
            this.isSteganograph.Name = "isSteganograph";
            this.isSteganograph.Size = new System.Drawing.Size(0, 13);
            this.isSteganograph.TabIndex = 78;
            // 
            // EncodeImgInImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 738);
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
            this.Controls.Add(this.pictureEncodeBefore2);
            this.Controls.Add(this.decodeLabel);
            this.Controls.Add(this.encodeLabel);
            this.Controls.Add(this.loadFileToBeEncoded);
            this.Controls.Add(this.loadFile);
            this.Controls.Add(this.encode);
            this.Controls.Add(this.pictureEncodeAfter);
            this.Controls.Add(this.pictureEncodeBefore);
            this.Name = "EncodeImgInImg";
            this.Text = "EncodeImgInImg";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEncodeAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEncodeBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEncodeBefore2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label decodeLabel;
        private System.Windows.Forms.Label encodeLabel;
        private System.Windows.Forms.Button loadFileToBeEncoded;
        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.Button encode;
        private System.Windows.Forms.PictureBox pictureEncodeAfter;
        private System.Windows.Forms.PictureBox pictureEncodeBefore;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureEncodeBefore2;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label takenLabel;
        private System.Windows.Forms.Label maxsizeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label isSteganograph;
    }
}