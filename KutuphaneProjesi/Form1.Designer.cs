namespace KutuphaneProjesi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_kulad = new Bunifu.Framework.UI.BunifuTextbox();
            this.txt_sifre = new Bunifu.Framework.UI.BunifuTextbox();
            this.btn_giris = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // txt_kulad
            // 
            this.txt_kulad.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_kulad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_kulad.BackgroundImage")));
            this.txt_kulad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_kulad.ForeColor = System.Drawing.Color.Black;
            this.txt_kulad.Icon = ((System.Drawing.Image)(resources.GetObject("txt_kulad.Icon")));
            this.txt_kulad.Location = new System.Drawing.Point(233, 79);
            this.txt_kulad.Name = "txt_kulad";
            this.txt_kulad.Size = new System.Drawing.Size(250, 42);
            this.txt_kulad.TabIndex = 0;
            this.txt_kulad.text = "Username";
            // 
            // txt_sifre
            // 
            this.txt_sifre.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_sifre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_sifre.BackgroundImage")));
            this.txt_sifre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_sifre.ForeColor = System.Drawing.Color.Black;
            this.txt_sifre.Icon = ((System.Drawing.Image)(resources.GetObject("txt_sifre.Icon")));
            this.txt_sifre.Location = new System.Drawing.Point(233, 141);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(250, 42);
            this.txt_sifre.TabIndex = 1;
            this.txt_sifre.text = "Password";
            // 
            // btn_giris
            // 
            this.btn_giris.ActiveBorderThickness = 1;
            this.btn_giris.ActiveCornerRadius = 20;
            this.btn_giris.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_giris.ActiveForecolor = System.Drawing.Color.Linen;
            this.btn_giris.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_giris.BackColor = System.Drawing.SystemColors.Control;
            this.btn_giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_giris.BackgroundImage")));
            this.btn_giris.ButtonText = "Log In";
            this.btn_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_giris.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_giris.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_giris.IdleBorderThickness = 1;
            this.btn_giris.IdleCornerRadius = 20;
            this.btn_giris.IdleFillColor = System.Drawing.Color.White;
            this.btn_giris.IdleForecolor = System.Drawing.Color.Black;
            this.btn_giris.IdleLineColor = System.Drawing.Color.Black;
            this.btn_giris.Location = new System.Drawing.Point(292, 203);
            this.btn_giris.Margin = new System.Windows.Forms.Padding(5);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(130, 41);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kulad);
            this.Name = "Form1";
            this.Text = "Giriş Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox txt_kulad;
        private Bunifu.Framework.UI.BunifuTextbox txt_sifre;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_giris;
    }
}

