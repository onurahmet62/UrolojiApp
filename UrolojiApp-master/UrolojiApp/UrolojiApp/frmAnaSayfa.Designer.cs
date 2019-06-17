namespace UrolojiApp
{
    partial class frmAnaSayfa
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
            this.pnlUst = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnUc = new System.Windows.Forms.Button();
            this.btnIki = new System.Windows.Forms.Button();
            this.btnBir = new System.Windows.Forms.Button();
            this.gbSol = new System.Windows.Forms.GroupBox();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btnOpTur = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnHastaBul = new System.Windows.Forms.Button();
            this.btnHastaGiris = new System.Windows.Forms.Button();
            this.btnUrolojiList = new System.Windows.Forms.Button();
            this.pnlUst.SuspendLayout();
            this.gbSol.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlUst.Controls.Add(this.btnUrolojiList);
            this.pnlUst.Controls.Add(this.btnKapat);
            this.pnlUst.Controls.Add(this.btnUc);
            this.pnlUst.Controls.Add(this.btnIki);
            this.pnlUst.Controls.Add(this.btnBir);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(800, 65);
            this.pnlUst.TabIndex = 0;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.Location = new System.Drawing.Point(701, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 37);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnUc
            // 
            this.btnUc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUc.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnUc.Location = new System.Drawing.Point(224, 11);
            this.btnUc.Name = "btnUc";
            this.btnUc.Size = new System.Drawing.Size(75, 37);
            this.btnUc.TabIndex = 2;
            this.btnUc.Text = "ÜÇ";
            this.btnUc.UseVisualStyleBackColor = true;
            this.btnUc.Click += new System.EventHandler(this.btnUc_Click);
            // 
            // btnIki
            // 
            this.btnIki.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIki.ForeColor = System.Drawing.Color.DarkRed;
            this.btnIki.Location = new System.Drawing.Point(111, 11);
            this.btnIki.Name = "btnIki";
            this.btnIki.Size = new System.Drawing.Size(75, 37);
            this.btnIki.TabIndex = 1;
            this.btnIki.Text = "Bilgi Giriş";
            this.btnIki.UseVisualStyleBackColor = true;
            this.btnIki.Click += new System.EventHandler(this.btnIki_Click);
            // 
            // btnBir
            // 
            this.btnBir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBir.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnBir.Location = new System.Drawing.Point(12, 11);
            this.btnBir.Name = "btnBir";
            this.btnBir.Size = new System.Drawing.Size(75, 37);
            this.btnBir.TabIndex = 0;
            this.btnBir.Text = "Böbrek";
            this.btnBir.UseVisualStyleBackColor = true;
            this.btnBir.Click += new System.EventHandler(this.btnBir_Click);
            // 
            // gbSol
            // 
            this.gbSol.Controls.Add(this.pnl3);
            this.gbSol.Controls.Add(this.pnl2);
            this.gbSol.Controls.Add(this.pnl1);
            this.gbSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbSol.Location = new System.Drawing.Point(0, 65);
            this.gbSol.Name = "gbSol";
            this.gbSol.Size = new System.Drawing.Size(174, 385);
            this.gbSol.TabIndex = 1;
            this.gbSol.TabStop = false;
            this.gbSol.Text = "groupBox1";
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.Blue;
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl3.Location = new System.Drawing.Point(357, 16);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(200, 366);
            this.pnl3.TabIndex = 2;
            this.pnl3.Visible = false;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.Maroon;
            this.pnl2.Controls.Add(this.btnOpTur);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl2.Location = new System.Drawing.Point(186, 16);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(171, 366);
            this.pnl2.TabIndex = 1;
            this.pnl2.Visible = false;
            // 
            // btnOpTur
            // 
            this.btnOpTur.Location = new System.Drawing.Point(9, 58);
            this.btnOpTur.Name = "btnOpTur";
            this.btnOpTur.Size = new System.Drawing.Size(124, 23);
            this.btnOpTur.TabIndex = 0;
            this.btnOpTur.Text = "Operasyon Tür Giriş";
            this.btnOpTur.UseVisualStyleBackColor = true;
            this.btnOpTur.Click += new System.EventHandler(this.btnOpTur_Click);
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnl1.Controls.Add(this.btnHastaBul);
            this.pnl1.Controls.Add(this.btnHastaGiris);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl1.Location = new System.Drawing.Point(3, 16);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(183, 366);
            this.pnl1.TabIndex = 0;
            // 
            // btnHastaBul
            // 
            this.btnHastaBul.Location = new System.Drawing.Point(32, 58);
            this.btnHastaBul.Name = "btnHastaBul";
            this.btnHastaBul.Size = new System.Drawing.Size(75, 23);
            this.btnHastaBul.TabIndex = 1;
            this.btnHastaBul.Text = "Hasta Bul";
            this.btnHastaBul.UseVisualStyleBackColor = true;
            this.btnHastaBul.Click += new System.EventHandler(this.btnHastaBul_Click);
            // 
            // btnHastaGiris
            // 
            this.btnHastaGiris.Location = new System.Drawing.Point(32, 28);
            this.btnHastaGiris.Name = "btnHastaGiris";
            this.btnHastaGiris.Size = new System.Drawing.Size(75, 23);
            this.btnHastaGiris.TabIndex = 0;
            this.btnHastaGiris.Text = "Hasta Giriş";
            this.btnHastaGiris.UseVisualStyleBackColor = true;
            this.btnHastaGiris.Click += new System.EventHandler(this.btnHastaGiris_Click);
            // 
            // btnUrolojiList
            // 
            this.btnUrolojiList.Location = new System.Drawing.Point(357, 12);
            this.btnUrolojiList.Name = "btnUrolojiList";
            this.btnUrolojiList.Size = new System.Drawing.Size(75, 36);
            this.btnUrolojiList.TabIndex = 4;
            this.btnUrolojiList.Text = "Üroloji Listesi";
            this.btnUrolojiList.UseVisualStyleBackColor = true;
            this.btnUrolojiList.Click += new System.EventHandler(this.btnUrolojiList_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbSol);
            this.Controls.Add(this.pnlUst);
            this.IsMdiContainer = true;
            this.Name = "frmAnaSayfa";
            this.Text = "frmAnaSayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlUst.ResumeLayout(false);
            this.gbSol.ResumeLayout(false);
            this.pnl2.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.GroupBox gbSol;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnUc;
        private System.Windows.Forms.Button btnIki;
        private System.Windows.Forms.Button btnBir;
        private System.Windows.Forms.Button btnHastaBul;
        private System.Windows.Forms.Button btnHastaGiris;
        private System.Windows.Forms.Button btnOpTur;
        private System.Windows.Forms.Button btnUrolojiList;
    }
}