namespace UrolojiApp.Fonksiyonlar
{
    partial class frmDoktor
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
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.clbListe = new System.Windows.Forms.CheckedListBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.brnSil = new System.Windows.Forms.Button();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.txtDoktor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pnlOrta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlAlt.SuspendLayout();
            this.pnlUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrta
            // 
            this.pnlOrta.BackColor = System.Drawing.Color.Gray;
            this.pnlOrta.Controls.Add(this.splitContainer1);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 85);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(800, 219);
            this.pnlOrta.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.clbListe);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnAktar);
            this.splitContainer1.Size = new System.Drawing.Size(800, 219);
            this.splitContainer1.SplitterDistance = 739;
            this.splitContainer1.TabIndex = 0;
            // 
            // clbListe
            // 
            this.clbListe.CheckOnClick = true;
            this.clbListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbListe.FormattingEnabled = true;
            this.clbListe.Location = new System.Drawing.Point(0, 0);
            this.clbListe.Name = "clbListe";
            this.clbListe.Size = new System.Drawing.Size(735, 215);
            this.clbListe.TabIndex = 0;
            // 
            // btnAktar
            // 
            this.btnAktar.BackColor = System.Drawing.Color.SlateGray;
            this.btnAktar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAktar.Location = new System.Drawing.Point(0, 0);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(53, 215);
            this.btnAktar.TabIndex = 0;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = false;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlAlt.Controls.Add(this.btnKapat);
            this.pnlAlt.Controls.Add(this.brnSil);
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 304);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(800, 100);
            this.pnlAlt.TabIndex = 2;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.SlateGray;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKapat.Location = new System.Drawing.Point(0, 70);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(800, 30);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // brnSil
            // 
            this.brnSil.BackColor = System.Drawing.Color.SlateGray;
            this.brnSil.Dock = System.Windows.Forms.DockStyle.Top;
            this.brnSil.Location = new System.Drawing.Point(0, 0);
            this.brnSil.Name = "brnSil";
            this.brnSil.Size = new System.Drawing.Size(800, 29);
            this.brnSil.TabIndex = 0;
            this.brnSil.Text = "Sil";
            this.brnSil.UseVisualStyleBackColor = false;
            this.brnSil.Click += new System.EventHandler(this.brnSil_Click);
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlUst.Controls.Add(this.txtDoktor);
            this.pnlUst.Controls.Add(this.label1);
            this.pnlUst.Controls.Add(this.btnKaydet);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(800, 85);
            this.pnlUst.TabIndex = 3;
            // 
            // txtDoktor
            // 
            this.txtDoktor.Location = new System.Drawing.Point(126, 56);
            this.txtDoktor.Name = "txtDoktor";
            this.txtDoktor.Size = new System.Drawing.Size(236, 20);
            this.txtDoktor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doktor:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.SlateGray;
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKaydet.Location = new System.Drawing.Point(0, 0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(800, 36);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.Name = "frmDoktor";
            this.Text = "frmDoktor";
            this.Load += new System.EventHandler(this.frmDoktor_Load);
            this.pnlOrta.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlAlt.ResumeLayout(false);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox clbListe;
        public System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button brnSil;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.TextBox txtDoktor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
    }
}