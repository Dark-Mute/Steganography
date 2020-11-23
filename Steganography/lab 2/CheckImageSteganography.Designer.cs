namespace lab_2
{
    partial class CheckImageSteganography
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
            this.pictureEncodeBefore2 = new System.Windows.Forms.PictureBox();
            this.decodeLabel = new System.Windows.Forms.Label();
            this.loadFileSteganograph = new System.Windows.Forms.Button();
            this.checkSteaganography = new System.Windows.Forms.Button();
            this.isSteganograpny = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEncodeBefore2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEncodeBefore2
            // 
            this.pictureEncodeBefore2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureEncodeBefore2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureEncodeBefore2.Location = new System.Drawing.Point(53, 77);
            this.pictureEncodeBefore2.Name = "pictureEncodeBefore2";
            this.pictureEncodeBefore2.Size = new System.Drawing.Size(1384, 740);
            this.pictureEncodeBefore2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEncodeBefore2.TabIndex = 37;
            this.pictureEncodeBefore2.TabStop = false;
            this.pictureEncodeBefore2.Click += new System.EventHandler(this.pictureEncodeBefore2_Click);
            // 
            // decodeLabel
            // 
            this.decodeLabel.AutoSize = true;
            this.decodeLabel.Location = new System.Drawing.Point(61, 48);
            this.decodeLabel.Name = "decodeLabel";
            this.decodeLabel.Size = new System.Drawing.Size(0, 13);
            this.decodeLabel.TabIndex = 36;
            // 
            // loadFileSteganograph
            // 
            this.loadFileSteganograph.Location = new System.Drawing.Point(53, 12);
            this.loadFileSteganograph.Name = "loadFileSteganograph";
            this.loadFileSteganograph.Size = new System.Drawing.Size(206, 23);
            this.loadFileSteganograph.TabIndex = 34;
            this.loadFileSteganograph.Text = "Wybeż zdjęcie które jest steganografem";
            this.loadFileSteganograph.UseVisualStyleBackColor = true;
            this.loadFileSteganograph.Click += new System.EventHandler(this.loadFileSteganograph_Click);
            // 
            // checkSteaganography
            // 
            this.checkSteaganography.Location = new System.Drawing.Point(380, 12);
            this.checkSteaganography.Name = "checkSteaganography";
            this.checkSteaganography.Size = new System.Drawing.Size(178, 23);
            this.checkSteaganography.TabIndex = 38;
            this.checkSteaganography.Text = "Sprawdź czy jest steganografem";
            this.checkSteaganography.UseVisualStyleBackColor = true;
            this.checkSteaganography.Click += new System.EventHandler(this.checkSteaganography_Click);
            // 
            // isSteganograpny
            // 
            this.isSteganograpny.AutoSize = true;
            this.isSteganograpny.Location = new System.Drawing.Point(564, 17);
            this.isSteganograpny.Name = "isSteganograpny";
            this.isSteganograpny.Size = new System.Drawing.Size(0, 13);
            this.isSteganograpny.TabIndex = 39;
            // 
            // CheckImageSteganography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 828);
            this.Controls.Add(this.isSteganograpny);
            this.Controls.Add(this.checkSteaganography);
            this.Controls.Add(this.pictureEncodeBefore2);
            this.Controls.Add(this.decodeLabel);
            this.Controls.Add(this.loadFileSteganograph);
            this.Name = "CheckImageSteganography";
            this.Text = "CheckImageSteganography";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEncodeBefore2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureEncodeBefore2;
        private System.Windows.Forms.Label decodeLabel;
        private System.Windows.Forms.Button loadFileSteganograph;
        private System.Windows.Forms.Button checkSteaganography;
        private System.Windows.Forms.Label isSteganograpny;
    }
}