namespace lab_2
{
    partial class EncodeAnythingInWav
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
            this.label5 = new System.Windows.Forms.Label();
            this.playSteganograph = new System.Windows.Forms.Button();
            this.maxsizeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Play = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.encode = new System.Windows.Forms.Button();
            this.decodeLabel = new System.Windows.Forms.Label();
            this.encodeLabel = new System.Windows.Forms.Label();
            this.loadFileToBeEncoded = new System.Windows.Forms.Button();
            this.loadFile = new System.Windows.Forms.Button();
            this.isSteganograph = new System.Windows.Forms.Label();
            this.maxSizeOfWav = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "/";
            // 
            // takenLabel
            // 
            this.takenLabel.AutoSize = true;
            this.takenLabel.Location = new System.Drawing.Point(195, 263);
            this.takenLabel.Name = "takenLabel";
            this.takenLabel.Size = new System.Drawing.Size(0, 13);
            this.takenLabel.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Odsłuchaj plik wave po zakodowaniu pliku\r\n";
            this.label5.UseMnemonic = false;
            this.label5.Visible = false;
            // 
            // playSteganograph
            // 
            this.playSteganograph.Location = new System.Drawing.Point(291, 398);
            this.playSteganograph.Name = "playSteganograph";
            this.playSteganograph.Size = new System.Drawing.Size(75, 23);
            this.playSteganograph.TabIndex = 69;
            this.playSteganograph.Text = "Play";
            this.playSteganograph.UseVisualStyleBackColor = true;
            this.playSteganograph.Visible = false;
            this.playSteganograph.Click += new System.EventHandler(this.playSteganograph_Click);
            // 
            // maxsizeLabel
            // 
            this.maxsizeLabel.AutoSize = true;
            this.maxsizeLabel.Location = new System.Drawing.Point(118, 263);
            this.maxsizeLabel.Name = "maxsizeLabel";
            this.maxsizeLabel.Size = new System.Drawing.Size(0, 13);
            this.maxsizeLabel.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Zajęto:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(93, 225);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(179, 23);
            this.progressBar1.TabIndex = 65;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(321, 18);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 63;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(281, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(46, 21);
            this.comboBox1.TabIndex = 62;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.onValueHange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Wybież na ilu bitach plik będzie zakodowany";
            this.label1.Visible = false;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(12, 361);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 60;
            // 
            // encode
            // 
            this.encode.Location = new System.Drawing.Point(93, 328);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(179, 23);
            this.encode.TabIndex = 58;
            this.encode.Text = "Zakodój";
            this.encode.UseVisualStyleBackColor = true;
            this.encode.Click += new System.EventHandler(this.encode_Click);
            // 
            // decodeLabel
            // 
            this.decodeLabel.AutoSize = true;
            this.decodeLabel.Location = new System.Drawing.Point(51, 149);
            this.decodeLabel.Name = "decodeLabel";
            this.decodeLabel.Size = new System.Drawing.Size(0, 13);
            this.decodeLabel.TabIndex = 57;
            // 
            // encodeLabel
            // 
            this.encodeLabel.AutoSize = true;
            this.encodeLabel.Location = new System.Drawing.Point(55, 53);
            this.encodeLabel.Name = "encodeLabel";
            this.encodeLabel.Size = new System.Drawing.Size(0, 13);
            this.encodeLabel.TabIndex = 56;
            // 
            // loadFileToBeEncoded
            // 
            this.loadFileToBeEncoded.Location = new System.Drawing.Point(54, 111);
            this.loadFileToBeEncoded.Name = "loadFileToBeEncoded";
            this.loadFileToBeEncoded.Size = new System.Drawing.Size(261, 23);
            this.loadFileToBeEncoded.TabIndex = 55;
            this.loadFileToBeEncoded.Text = "Wybeż plik który będzie zakodowany";
            this.loadFileToBeEncoded.UseVisualStyleBackColor = true;
            this.loadFileToBeEncoded.Click += new System.EventHandler(this.loadFileToBeEncoded_Click);
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(54, 18);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(261, 23);
            this.loadFile.TabIndex = 54;
            this.loadFile.Text = "Wybeż plik wav w którym ma być zakodowany tekst";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // isSteganograph
            // 
            this.isSteganograph.AutoSize = true;
            this.isSteganograph.Location = new System.Drawing.Point(55, 75);
            this.isSteganograph.Name = "isSteganograph";
            this.isSteganograph.Size = new System.Drawing.Size(0, 13);
            this.isSteganograph.TabIndex = 78;
            // 
            // maxSizeOfWav
            // 
            this.maxSizeOfWav.AutoSize = true;
            this.maxSizeOfWav.Location = new System.Drawing.Point(267, 299);
            this.maxSizeOfWav.Name = "maxSizeOfWav";
            this.maxSizeOfWav.Size = new System.Drawing.Size(0, 13);
            this.maxSizeOfWav.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Maksymalna pojemnośc pliku wav:";
            // 
            // EncodeAnythingInWav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 425);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maxSizeOfWav);
            this.Controls.Add(this.isSteganograph);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.takenLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.playSteganograph);
            this.Controls.Add(this.maxsizeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.message);
            this.Controls.Add(this.encode);
            this.Controls.Add(this.decodeLabel);
            this.Controls.Add(this.encodeLabel);
            this.Controls.Add(this.loadFileToBeEncoded);
            this.Controls.Add(this.loadFile);
            this.Name = "EncodeAnythingInWav";
            this.Text = "EncodeAnythingInWav";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EncodeAnythingInWav_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label takenLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button playSteganograph;
        private System.Windows.Forms.Label maxsizeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button encode;
        private System.Windows.Forms.Label decodeLabel;
        private System.Windows.Forms.Label encodeLabel;
        private System.Windows.Forms.Button loadFileToBeEncoded;
        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.Label isSteganograph;
        private System.Windows.Forms.Label maxSizeOfWav;
        private System.Windows.Forms.Label label6;
    }
}