namespace lab_2
{
    partial class EncodeTextInWav
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.mesaage = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.maxsizeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pauseSteganograph = new System.Windows.Forms.Button();
            this.playSteganograph = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.takenLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isSteganograph = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // decodeLabel
            // 
            this.decodeLabel.AutoSize = true;
            this.decodeLabel.Location = new System.Drawing.Point(9, 139);
            this.decodeLabel.Name = "decodeLabel";
            this.decodeLabel.Size = new System.Drawing.Size(0, 13);
            this.decodeLabel.TabIndex = 13;
            // 
            // encodeLabel
            // 
            this.encodeLabel.AutoSize = true;
            this.encodeLabel.Location = new System.Drawing.Point(13, 47);
            this.encodeLabel.Name = "encodeLabel";
            this.encodeLabel.Size = new System.Drawing.Size(0, 13);
            this.encodeLabel.TabIndex = 12;
            // 
            // loadFileToBeEncoded
            // 
            this.loadFileToBeEncoded.Location = new System.Drawing.Point(12, 101);
            this.loadFileToBeEncoded.Name = "loadFileToBeEncoded";
            this.loadFileToBeEncoded.Size = new System.Drawing.Size(261, 23);
            this.loadFileToBeEncoded.TabIndex = 11;
            this.loadFileToBeEncoded.Text = "Wybeż plik tekstowy który będzie zakodowany";
            this.loadFileToBeEncoded.UseVisualStyleBackColor = true;
            this.loadFileToBeEncoded.Click += new System.EventHandler(this.loadFileToBeEncoded_Click);
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(12, 12);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(261, 23);
            this.loadFile.TabIndex = 10;
            this.loadFile.Text = "Wybeż plik wav w którym ma być zakodowany tekst";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // encode
            // 
            this.encode.Location = new System.Drawing.Point(327, 165);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(179, 23);
            this.encode.TabIndex = 14;
            this.encode.Text = "Zakodój";
            this.encode.UseVisualStyleBackColor = true;
            this.encode.Click += new System.EventHandler(this.encode_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mesaage
            // 
            this.mesaage.AutoSize = true;
            this.mesaage.Location = new System.Drawing.Point(329, 202);
            this.mesaage.Name = "mesaage";
            this.mesaage.Size = new System.Drawing.Size(0, 13);
            this.mesaage.TabIndex = 32;
            this.mesaage.Click += new System.EventHandler(this.mesaage_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(13, 223);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 33;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(46, 21);
            this.comboBox1.TabIndex = 38;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.onValueHange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Wybież na ilu bitach plik będzie zakodowany";
            this.label1.Visible = false;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(335, 12);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 39;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(416, 12);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 23);
            this.Pause.TabIndex = 40;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // maxsizeLabel
            // 
            this.maxsizeLabel.AutoSize = true;
            this.maxsizeLabel.Location = new System.Drawing.Point(334, 139);
            this.maxsizeLabel.Name = "maxsizeLabel";
            this.maxsizeLabel.Size = new System.Drawing.Size(0, 13);
            this.maxsizeLabel.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 47;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Zajęto:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(327, 101);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(179, 23);
            this.progressBar1.TabIndex = 45;
            // 
            // pauseSteganograph
            // 
            this.pauseSteganograph.Location = new System.Drawing.Point(335, 245);
            this.pauseSteganograph.Name = "pauseSteganograph";
            this.pauseSteganograph.Size = new System.Drawing.Size(75, 23);
            this.pauseSteganograph.TabIndex = 50;
            this.pauseSteganograph.Text = "Pause";
            this.pauseSteganograph.UseVisualStyleBackColor = true;
            this.pauseSteganograph.Click += new System.EventHandler(this.pauseSteganograph_Click);
            // 
            // playSteganograph
            // 
            this.playSteganograph.Location = new System.Drawing.Point(254, 245);
            this.playSteganograph.Name = "playSteganograph";
            this.playSteganograph.Size = new System.Drawing.Size(75, 23);
            this.playSteganograph.TabIndex = 49;
            this.playSteganograph.Text = "Play";
            this.playSteganograph.UseVisualStyleBackColor = true;
            this.playSteganograph.Click += new System.EventHandler(this.playSteganograph_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Odsłuchaj plik wave po zakodowaniu tekstu";
            // 
            // takenLabel
            // 
            this.takenLabel.AutoSize = true;
            this.takenLabel.Location = new System.Drawing.Point(450, 139);
            this.takenLabel.Name = "takenLabel";
            this.takenLabel.Size = new System.Drawing.Size(0, 13);
            this.takenLabel.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "/";
            // 
            // isSteganograph
            // 
            this.isSteganograph.AutoSize = true;
            this.isSteganograph.Location = new System.Drawing.Point(13, 69);
            this.isSteganograph.Name = "isSteganograph";
            this.isSteganograph.Size = new System.Drawing.Size(0, 13);
            this.isSteganograph.TabIndex = 54;
            // 
            // EncodeTextInWav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 291);
            this.Controls.Add(this.isSteganograph);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.takenLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pauseSteganograph);
            this.Controls.Add(this.playSteganograph);
            this.Controls.Add(this.maxsizeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.message);
            this.Controls.Add(this.mesaage);
            this.Controls.Add(this.encode);
            this.Controls.Add(this.decodeLabel);
            this.Controls.Add(this.encodeLabel);
            this.Controls.Add(this.loadFileToBeEncoded);
            this.Controls.Add(this.loadFile);
            this.Name = "EncodeTextInWav";
            this.Text = "EncodeTextInWav";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EncodeTextInWav_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label decodeLabel;
        private System.Windows.Forms.Label encodeLabel;
        private System.Windows.Forms.Button loadFileToBeEncoded;
        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.Button encode;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label mesaage;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Label maxsizeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button pauseSteganograph;
        private System.Windows.Forms.Button playSteganograph;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label takenLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label isSteganograph;
    }
}