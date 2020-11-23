namespace lab_2
{
    partial class Steganografia
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.decodeTextFromImg = new System.Windows.Forms.Button();
            this.decodeImgFromImg = new System.Windows.Forms.Button();
            this.decodeTextFromwav = new System.Windows.Forms.Button();
            this.encodeTextInImg = new System.Windows.Forms.Button();
            this.encodeTextInWav = new System.Windows.Forms.Button();
            this.encodeImgInImg = new System.Windows.Forms.Button();
            this.checkSteganographyInImg = new System.Windows.Forms.Button();
            this.checkSteganographyInWav = new System.Windows.Forms.Button();
            this.encodeAnythingInImage = new System.Windows.Forms.Button();
            this.decodeAnythingFromImage = new System.Windows.Forms.Button();
            this.decodeAnythingFromWav = new System.Windows.Forms.Button();
            this.encodeAnythingInWav = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // decodeTextFromImg
            // 
            this.decodeTextFromImg.Location = new System.Drawing.Point(12, 530);
            this.decodeTextFromImg.Name = "decodeTextFromImg";
            this.decodeTextFromImg.Size = new System.Drawing.Size(164, 26);
            this.decodeTextFromImg.TabIndex = 14;
            this.decodeTextFromImg.Text = "Zdekodój tekst z zdjęcia";
            this.decodeTextFromImg.UseVisualStyleBackColor = true;
            this.decodeTextFromImg.Visible = false;
            this.decodeTextFromImg.Click += new System.EventHandler(this.decodeTextFromImg_Click);
            // 
            // decodeImgFromImg
            // 
            this.decodeImgFromImg.Location = new System.Drawing.Point(182, 530);
            this.decodeImgFromImg.Name = "decodeImgFromImg";
            this.decodeImgFromImg.Size = new System.Drawing.Size(165, 26);
            this.decodeImgFromImg.TabIndex = 15;
            this.decodeImgFromImg.Text = "Zdekodój zdjęcie z zdjęcia";
            this.decodeImgFromImg.UseVisualStyleBackColor = true;
            this.decodeImgFromImg.Visible = false;
            this.decodeImgFromImg.Click += new System.EventHandler(this.decodeImgFromImg_Click);
            // 
            // decodeTextFromwav
            // 
            this.decodeTextFromwav.Location = new System.Drawing.Point(353, 530);
            this.decodeTextFromwav.Name = "decodeTextFromwav";
            this.decodeTextFromwav.Size = new System.Drawing.Size(164, 26);
            this.decodeTextFromwav.TabIndex = 16;
            this.decodeTextFromwav.Text = "Zdekodój tekst z pliku wav";
            this.decodeTextFromwav.UseVisualStyleBackColor = true;
            this.decodeTextFromwav.Visible = false;
            this.decodeTextFromwav.Click += new System.EventHandler(this.decodeTextFromwav_Click);
            // 
            // encodeTextInImg
            // 
            this.encodeTextInImg.Location = new System.Drawing.Point(12, 498);
            this.encodeTextInImg.Name = "encodeTextInImg";
            this.encodeTextInImg.Size = new System.Drawing.Size(164, 26);
            this.encodeTextInImg.TabIndex = 17;
            this.encodeTextInImg.Text = "Zakodój tekst w zdjęciu";
            this.encodeTextInImg.UseVisualStyleBackColor = true;
            this.encodeTextInImg.Visible = false;
            this.encodeTextInImg.Click += new System.EventHandler(this.encodeTextInImg_Click);
            // 
            // encodeTextInWav
            // 
            this.encodeTextInWav.Location = new System.Drawing.Point(353, 498);
            this.encodeTextInWav.Name = "encodeTextInWav";
            this.encodeTextInWav.Size = new System.Drawing.Size(164, 26);
            this.encodeTextInWav.TabIndex = 18;
            this.encodeTextInWav.Text = "Zakodój tekst w pliku wav";
            this.encodeTextInWav.UseVisualStyleBackColor = true;
            this.encodeTextInWav.Visible = false;
            this.encodeTextInWav.Click += new System.EventHandler(this.encodeTextInWav_Click);
            // 
            // encodeImgInImg
            // 
            this.encodeImgInImg.Location = new System.Drawing.Point(182, 498);
            this.encodeImgInImg.Name = "encodeImgInImg";
            this.encodeImgInImg.Size = new System.Drawing.Size(165, 26);
            this.encodeImgInImg.TabIndex = 19;
            this.encodeImgInImg.Text = "Zakodój zdjęciew zdjęciu";
            this.encodeImgInImg.UseVisualStyleBackColor = true;
            this.encodeImgInImg.Visible = false;
            this.encodeImgInImg.Click += new System.EventHandler(this.encodeImgInImg_Click);
            // 
            // checkSteganographyInImg
            // 
            this.checkSteganographyInImg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkSteganographyInImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkSteganographyInImg.FlatAppearance.BorderSize = 0;
            this.checkSteganographyInImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkSteganographyInImg.Location = new System.Drawing.Point(608, 13);
            this.checkSteganographyInImg.Name = "checkSteganographyInImg";
            this.checkSteganographyInImg.Padding = new System.Windows.Forms.Padding(3);
            this.checkSteganographyInImg.Size = new System.Drawing.Size(218, 35);
            this.checkSteganographyInImg.TabIndex = 20;
            this.checkSteganographyInImg.Text = "Sprawdź stegannografie w obrazie";
            this.checkSteganographyInImg.UseVisualStyleBackColor = false;
            this.checkSteganographyInImg.Click += new System.EventHandler(this.checkSteganographyInImg_Click);
            // 
            // checkSteganographyInWav
            // 
            this.checkSteganographyInWav.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkSteganographyInWav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkSteganographyInWav.FlatAppearance.BorderSize = 0;
            this.checkSteganographyInWav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkSteganographyInWav.Location = new System.Drawing.Point(1277, 13);
            this.checkSteganographyInWav.Margin = new System.Windows.Forms.Padding(0);
            this.checkSteganographyInWav.Name = "checkSteganographyInWav";
            this.checkSteganographyInWav.Size = new System.Drawing.Size(218, 35);
            this.checkSteganographyInWav.TabIndex = 21;
            this.checkSteganographyInWav.Text = "Sprawdź stegannografie w pliku wav";
            this.checkSteganographyInWav.UseVisualStyleBackColor = false;
            this.checkSteganographyInWav.Click += new System.EventHandler(this.checkSteganographyInWav_Click);
            // 
            // encodeAnythingInImage
            // 
            this.encodeAnythingInImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.encodeAnythingInImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encodeAnythingInImage.FlatAppearance.BorderSize = 0;
            this.encodeAnythingInImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encodeAnythingInImage.Location = new System.Drawing.Point(160, 13);
            this.encodeAnythingInImage.Name = "encodeAnythingInImage";
            this.encodeAnythingInImage.Padding = new System.Windows.Forms.Padding(3);
            this.encodeAnythingInImage.Size = new System.Drawing.Size(218, 35);
            this.encodeAnythingInImage.TabIndex = 22;
            this.encodeAnythingInImage.Text = "Zakodój plik w zdjęciu";
            this.encodeAnythingInImage.UseVisualStyleBackColor = false;
            this.encodeAnythingInImage.Click += new System.EventHandler(this.encodeAnythingInImage_Click);
            // 
            // decodeAnythingFromImage
            // 
            this.decodeAnythingFromImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.decodeAnythingFromImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decodeAnythingFromImage.FlatAppearance.BorderSize = 0;
            this.decodeAnythingFromImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decodeAnythingFromImage.Location = new System.Drawing.Point(384, 13);
            this.decodeAnythingFromImage.Name = "decodeAnythingFromImage";
            this.decodeAnythingFromImage.Padding = new System.Windows.Forms.Padding(3);
            this.decodeAnythingFromImage.Size = new System.Drawing.Size(218, 35);
            this.decodeAnythingFromImage.TabIndex = 23;
            this.decodeAnythingFromImage.Text = "Zdekodój plik z zdjęcia";
            this.decodeAnythingFromImage.UseVisualStyleBackColor = false;
            this.decodeAnythingFromImage.Click += new System.EventHandler(this.decodeAnythingFromImage_Click);
            // 
            // decodeAnythingFromWav
            // 
            this.decodeAnythingFromWav.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.decodeAnythingFromWav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decodeAnythingFromWav.FlatAppearance.BorderSize = 0;
            this.decodeAnythingFromWav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decodeAnythingFromWav.Location = new System.Drawing.Point(1056, 13);
            this.decodeAnythingFromWav.Name = "decodeAnythingFromWav";
            this.decodeAnythingFromWav.Padding = new System.Windows.Forms.Padding(3);
            this.decodeAnythingFromWav.Size = new System.Drawing.Size(218, 35);
            this.decodeAnythingFromWav.TabIndex = 25;
            this.decodeAnythingFromWav.Text = "Zdekodój plik z wav";
            this.decodeAnythingFromWav.UseVisualStyleBackColor = false;
            this.decodeAnythingFromWav.Click += new System.EventHandler(this.decodeAnythingFromWav_Click);
            // 
            // encodeAnythingInWav
            // 
            this.encodeAnythingInWav.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.encodeAnythingInWav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encodeAnythingInWav.FlatAppearance.BorderSize = 0;
            this.encodeAnythingInWav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encodeAnythingInWav.Location = new System.Drawing.Point(832, 13);
            this.encodeAnythingInWav.Name = "encodeAnythingInWav";
            this.encodeAnythingInWav.Padding = new System.Windows.Forms.Padding(3);
            this.encodeAnythingInWav.Size = new System.Drawing.Size(218, 35);
            this.encodeAnythingInWav.TabIndex = 24;
            this.encodeAnythingInWav.Text = "Zakodój plik w wav";
            this.encodeAnythingInWav.UseVisualStyleBackColor = false;
            this.encodeAnythingInWav.Click += new System.EventHandler(this.encodeAnythingInWav_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.ForestGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.label1.Size = new System.Drawing.Size(131, 41);
            this.label1.TabIndex = 26;
            this.label1.Text = "Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1657, 892);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.checkSteganographyInImg);
            this.panel2.Controls.Add(this.checkSteganographyInWav);
            this.panel2.Controls.Add(this.decodeAnythingFromWav);
            this.panel2.Controls.Add(this.encodeAnythingInImage);
            this.panel2.Controls.Add(this.encodeAnythingInWav);
            this.panel2.Controls.Add(this.decodeAnythingFromImage);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1685, 65);
            this.panel2.TabIndex = 28;
            // 
            // Steganografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1679, 970);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.encodeImgInImg);
            this.Controls.Add(this.encodeTextInWav);
            this.Controls.Add(this.encodeTextInImg);
            this.Controls.Add(this.decodeTextFromwav);
            this.Controls.Add(this.decodeImgFromImg);
            this.Controls.Add(this.decodeTextFromImg);
            this.Name = "Steganografia";
            this.Text = "Steganografia";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button decodeTextFromImg;
        private System.Windows.Forms.Button decodeImgFromImg;
        private System.Windows.Forms.Button decodeTextFromwav;
        private System.Windows.Forms.Button encodeTextInImg;
        private System.Windows.Forms.Button encodeTextInWav;
        private System.Windows.Forms.Button encodeImgInImg;
        private System.Windows.Forms.Button checkSteganographyInImg;
        private System.Windows.Forms.Button checkSteganographyInWav;
        private System.Windows.Forms.Button encodeAnythingInImage;
        private System.Windows.Forms.Button decodeAnythingFromImage;
        private System.Windows.Forms.Button decodeAnythingFromWav;
        private System.Windows.Forms.Button encodeAnythingInWav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

