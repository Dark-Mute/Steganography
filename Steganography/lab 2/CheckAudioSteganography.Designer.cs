namespace lab_2
{
    partial class CheckAudioSteganography
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
            this.fille2Label = new System.Windows.Forms.Label();
            this.loadSteganographWav = new System.Windows.Forms.Button();
            this.playSteganograph = new System.Windows.Forms.Button();
            this.isSteganograpny = new System.Windows.Forms.Label();
            this.checkSteaganography = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fille2Label
            // 
            this.fille2Label.AutoSize = true;
            this.fille2Label.Location = new System.Drawing.Point(12, 47);
            this.fille2Label.Name = "fille2Label";
            this.fille2Label.Size = new System.Drawing.Size(0, 13);
            this.fille2Label.TabIndex = 17;
            // 
            // loadSteganographWav
            // 
            this.loadSteganographWav.Location = new System.Drawing.Point(47, 12);
            this.loadSteganographWav.Name = "loadSteganographWav";
            this.loadSteganographWav.Size = new System.Drawing.Size(261, 23);
            this.loadSteganographWav.TabIndex = 15;
            this.loadSteganographWav.Text = "Wybeż plik wav który może być steganografem";
            this.loadSteganographWav.UseVisualStyleBackColor = true;
            this.loadSteganographWav.Click += new System.EventHandler(this.loadSteganographWav_Click);
            // 
            // playSteganograph
            // 
            this.playSteganograph.Location = new System.Drawing.Point(323, 12);
            this.playSteganograph.Name = "playSteganograph";
            this.playSteganograph.Size = new System.Drawing.Size(75, 23);
            this.playSteganograph.TabIndex = 43;
            this.playSteganograph.Text = "Play";
            this.playSteganograph.UseVisualStyleBackColor = true;
            this.playSteganograph.Click += new System.EventHandler(this.playSteganograph_Click);
            // 
            // isSteganograpny
            // 
            this.isSteganograpny.AutoSize = true;
            this.isSteganograpny.Location = new System.Drawing.Point(234, 81);
            this.isSteganograpny.Name = "isSteganograpny";
            this.isSteganograpny.Size = new System.Drawing.Size(0, 13);
            this.isSteganograpny.TabIndex = 46;
            // 
            // checkSteaganography
            // 
            this.checkSteaganography.Location = new System.Drawing.Point(50, 76);
            this.checkSteaganography.Name = "checkSteaganography";
            this.checkSteaganography.Size = new System.Drawing.Size(178, 23);
            this.checkSteaganography.TabIndex = 45;
            this.checkSteaganography.Text = "Sprawdź czy jest steganografem";
            this.checkSteaganography.UseVisualStyleBackColor = true;
            this.checkSteaganography.Click += new System.EventHandler(this.checkSteaganography_Click);
            // 
            // CheckAudioSteganography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 107);
            this.Controls.Add(this.isSteganograpny);
            this.Controls.Add(this.checkSteaganography);
            this.Controls.Add(this.playSteganograph);
            this.Controls.Add(this.fille2Label);
            this.Controls.Add(this.loadSteganographWav);
            this.Name = "CheckAudioSteganography";
            this.Text = "CheckAudioSteganography";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckAudioSteganography_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fille2Label;
        private System.Windows.Forms.Button loadSteganographWav;
        private System.Windows.Forms.Button playSteganograph;
        private System.Windows.Forms.Label isSteganograpny;
        private System.Windows.Forms.Button checkSteaganography;
    }
}