
namespace EsiniBul
{
    partial class YeniOyunForm
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
            this.gboSeviye = new System.Windows.Forms.GroupBox();
            this.rbZor = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbKolay = new System.Windows.Forms.RadioButton();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnOyundanCik = new System.Windows.Forms.Button();
            this.gboSeviye.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboSeviye
            // 
            this.gboSeviye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboSeviye.Controls.Add(this.rbZor);
            this.gboSeviye.Controls.Add(this.rbOrta);
            this.gboSeviye.Controls.Add(this.rbKolay);
            this.gboSeviye.Location = new System.Drawing.Point(189, 77);
            this.gboSeviye.Margin = new System.Windows.Forms.Padding(6);
            this.gboSeviye.Name = "gboSeviye";
            this.gboSeviye.Padding = new System.Windows.Forms.Padding(6);
            this.gboSeviye.Size = new System.Drawing.Size(212, 212);
            this.gboSeviye.TabIndex = 0;
            this.gboSeviye.TabStop = false;
            this.gboSeviye.Text = "Zorluk Seviyesi";
            // 
            // rbZor
            // 
            this.rbZor.AutoSize = true;
            this.rbZor.Location = new System.Drawing.Point(27, 141);
            this.rbZor.Margin = new System.Windows.Forms.Padding(6);
            this.rbZor.Name = "rbZor";
            this.rbZor.Size = new System.Drawing.Size(117, 30);
            this.rbZor.TabIndex = 2;
            this.rbZor.Text = "Zor (8x8)";
            this.rbZor.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(27, 99);
            this.rbOrta.Margin = new System.Windows.Forms.Padding(6);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(127, 30);
            this.rbOrta.TabIndex = 1;
            this.rbOrta.Text = "Orta (6x6)";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKolay
            // 
            this.rbKolay.AutoSize = true;
            this.rbKolay.Checked = true;
            this.rbKolay.Location = new System.Drawing.Point(27, 57);
            this.rbKolay.Margin = new System.Windows.Forms.Padding(6);
            this.rbKolay.Name = "rbKolay";
            this.rbKolay.Size = new System.Drawing.Size(140, 30);
            this.rbKolay.TabIndex = 0;
            this.rbKolay.TabStop = true;
            this.rbKolay.Text = "Kolay (4x4)";
            this.rbKolay.UseVisualStyleBackColor = true;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBaslat.Location = new System.Drawing.Point(189, 298);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(212, 38);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "OYUNU BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnOyundanCik
            // 
            this.btnOyundanCik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOyundanCik.Location = new System.Drawing.Point(189, 342);
            this.btnOyundanCik.Name = "btnOyundanCik";
            this.btnOyundanCik.Size = new System.Drawing.Size(212, 38);
            this.btnOyundanCik.TabIndex = 2;
            this.btnOyundanCik.Text = "OYUNDAN ÇIK";
            this.btnOyundanCik.UseVisualStyleBackColor = true;
            this.btnOyundanCik.Click += new System.EventHandler(this.btnOyundanCik_Click);
            // 
            // YeniOyunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 439);
            this.Controls.Add(this.btnOyundanCik);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.gboSeviye);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "YeniOyunForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eşini Bul";
            this.gboSeviye.ResumeLayout(false);
            this.gboSeviye.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboSeviye;
        private System.Windows.Forms.RadioButton rbZor;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbKolay;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnOyundanCik;
    }
}