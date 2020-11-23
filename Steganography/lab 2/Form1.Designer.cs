namespace lab_2
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // decodeTextFromImg
            // 
            this.decodeTextFromImg.Location = new System.Drawing.Point(29, 55);
            this.decodeTextFromImg.Name = "decodeTextFromImg";
            this.decodeTextFromImg.Size = new System.Drawing.Size(164, 26);
            this.decodeTextFromImg.TabIndex = 14;
            this.decodeTextFromImg.Text = "Zdekodój tekst z zdjęcia";
            this.decodeTextFromImg.UseVisualStyleBackColor = true;
            this.decodeTextFromImg.Click += new System.EventHandler(this.decodeTextFromImg_Click);
            // 
            // decodeImgFromImg
            // 
            this.decodeImgFromImg.Location = new System.Drawing.Point(199, 55);
            this.decodeImgFromImg.Name = "decodeImgFromImg";
            this.decodeImgFromImg.Size = new System.Drawing.Size(165, 26);
            this.decodeImgFromImg.TabIndex = 15;
            this.decodeImgFromImg.Text = "Zdekodój zdjęcie z zdjęcia";
            this.decodeImgFromImg.UseVisualStyleBackColor = true;
            this.decodeImgFromImg.Click += new System.EventHandler(this.decodeImgFromImg_Click);
            // 
            // decodeTextFromwav
            // 
            this.decodeTextFromwav.Location = new System.Drawing.Point(570, 55);
            this.decodeTextFromwav.Name = "decodeTextFromwav";
            this.decodeTextFromwav.Size = new System.Drawing.Size(164, 26);
            this.decodeTextFromwav.TabIndex = 16;
            this.decodeTextFromwav.Text = "Zdekodój tekst z pliku wav";
            this.decodeTextFromwav.UseVisualStyleBackColor = true;
            this.decodeTextFromwav.Click += new System.EventHandler(this.decodeTextFromwav_Click);
            // 
            // encodeTextInImg
            // 
            this.encodeTextInImg.Location = new System.Drawing.Point(29, 23);
            this.encodeTextInImg.Name = "encodeTextInImg";
            this.encodeTextInImg.Size = new System.Drawing.Size(164, 26);
            this.encodeTextInImg.TabIndex = 17;
            this.encodeTextInImg.Text = "Zakodój tekst w zdjęciu";
            this.encodeTextInImg.UseVisualStyleBackColor = true;
            this.encodeTextInImg.Click += new System.EventHandler(this.encodeTextInImg_Click);
            // 
            // encodeTextInWav
            // 
            this.encodeTextInWav.Location = new System.Drawing.Point(570, 23);
            this.encodeTextInWav.Name = "encodeTextInWav";
            this.encodeTextInWav.Size = new System.Drawing.Size(164, 26);
            this.encodeTextInWav.TabIndex = 18;
            this.encodeTextInWav.Text = "Zakodój tekst w pliku wav";
            this.encodeTextInWav.UseVisualStyleBackColor = true;
            this.encodeTextInWav.Click += new System.EventHandler(this.encodeTextInWav_Click);
            // 
            // encodeImgInImg
            // 
            this.encodeImgInImg.Location = new System.Drawing.Point(199, 23);
            this.encodeImgInImg.Name = "encodeImgInImg";
            this.encodeImgInImg.Size = new System.Drawing.Size(165, 26);
            this.encodeImgInImg.TabIndex = 19;
            this.encodeImgInImg.Text = "Zakodój zdjęciew zdjęciu";
            this.encodeImgInImg.UseVisualStyleBackColor = true;
            this.encodeImgInImg.Click += new System.EventHandler(this.encodeImgInImg_Click);
            // 
            // checkSteganographyInImg
            // 
            this.checkSteganographyInImg.Location = new System.Drawing.Point(946, 23);
            this.checkSteganographyInImg.Name = "checkSteganographyInImg";
            this.checkSteganographyInImg.Size = new System.Drawing.Size(197, 26);
            this.checkSteganographyInImg.TabIndex = 20;
            this.checkSteganographyInImg.Text = "Sprawdź stegannografie w obrazie";
            this.checkSteganographyInImg.UseVisualStyleBackColor = true;
            this.checkSteganographyInImg.Click += new System.EventHandler(this.checkSteganographyInImg_Click);
            // 
            // checkSteganographyInWav
            // 
            this.checkSteganographyInWav.Location = new System.Drawing.Point(946, 55);
            this.checkSteganographyInWav.Name = "checkSteganographyInWav";
            this.checkSteganographyInWav.Size = new System.Drawing.Size(197, 26);
            this.checkSteganographyInWav.TabIndex = 21;
            this.checkSteganographyInWav.Text = "Sprawdź stegannografie w pliku wav";
            this.checkSteganographyInWav.UseVisualStyleBackColor = true;
            this.checkSteganographyInWav.Click += new System.EventHandler(this.checkSteganographyInWav_Click);
            // 
            // encodeAnythingInImage
            // 
            this.encodeAnythingInImage.Location = new System.Drawing.Point(370, 23);
            this.encodeAnythingInImage.Name = "encodeAnythingInImage";
            this.encodeAnythingInImage.Size = new System.Drawing.Size(164, 26);
            this.encodeAnythingInImage.TabIndex = 22;
            this.encodeAnythingInImage.Text = "Zakodój cokolwiek w zdjęciu";
            this.encodeAnythingInImage.UseVisualStyleBackColor = true;
            this.encodeAnythingInImage.Click += new System.EventHandler(this.encodeAnythingInImage_Click);
            // 
            // decodeAnythingFromImage
            // 
            this.decodeAnythingFromImage.Location = new System.Drawing.Point(370, 55);
            this.decodeAnythingFromImage.Name = "decodeAnythingFromImage";
            this.decodeAnythingFromImage.Size = new System.Drawing.Size(164, 26);
            this.decodeAnythingFromImage.TabIndex = 23;
            this.decodeAnythingFromImage.Text = "Zdekodój cokolwiek z zdjęcia";
            this.decodeAnythingFromImage.UseVisualStyleBackColor = true;
            this.decodeAnythingFromImage.Click += new System.EventHandler(this.decodeAnythingFromImage_Click);
            // 
            // decodeAnythingFromWav
            // 
            this.decodeAnythingFromWav.Location = new System.Drawing.Point(740, 55);
            this.decodeAnythingFromWav.Name = "decodeAnythingFromWav";
            this.decodeAnythingFromWav.Size = new System.Drawing.Size(164, 26);
            this.decodeAnythingFromWav.TabIndex = 25;
            this.decodeAnythingFromWav.Text = "Zdekodój cokolwiek z wav";
            this.decodeAnythingFromWav.UseVisualStyleBackColor = true;
            this.decodeAnythingFromWav.Click += new System.EventHandler(this.decodeAnythingFromWav_Click);
            // 
            // encodeAnythingInWav
            // 
            this.encodeAnythingInWav.Location = new System.Drawing.Point(740, 23);
            this.encodeAnythingInWav.Name = "encodeAnythingInWav";
            this.encodeAnythingInWav.Size = new System.Drawing.Size(164, 26);
            this.encodeAnythingInWav.TabIndex = 24;
            this.encodeAnythingInWav.Text = "Zakodój cokolwiek w wav";
            this.encodeAnythingInWav.UseVisualStyleBackColor = true;
            this.encodeAnythingInWav.Click += new System.EventHandler(this.encodeAnythingInWav_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 683);
            this.Controls.Add(this.decodeAnythingFromWav);
            this.Controls.Add(this.encodeAnythingInWav);
            this.Controls.Add(this.decodeAnythingFromImage);
            this.Controls.Add(this.encodeAnythingInImage);
            this.Controls.Add(this.checkSteganographyInWav);
            this.Controls.Add(this.checkSteganographyInImg);
            this.Controls.Add(this.encodeImgInImg);
            this.Controls.Add(this.encodeTextInWav);
            this.Controls.Add(this.encodeTextInImg);
            this.Controls.Add(this.decodeTextFromwav);
            this.Controls.Add(this.decodeImgFromImg);
            this.Controls.Add(this.decodeTextFromImg);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

