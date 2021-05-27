namespace Aplikacija
{
    partial class PlayerInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerInfo));
            this.lboxIgraci = new System.Windows.Forms.ListBox();
            this.pboxIgrac = new System.Windows.Forms.PictureBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbBroj = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbPozicija = new System.Windows.Forms.TextBox();
            this.tbKapetan = new System.Windows.Forms.TextBox();
            this.lbDrzava = new System.Windows.Forms.Label();
            this.lbKod = new System.Windows.Forms.Label();
            this.tbSave = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxIgrac)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxIgraci
            // 
            this.lboxIgraci.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lboxIgraci.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxIgraci.ForeColor = System.Drawing.Color.White;
            this.lboxIgraci.FormattingEnabled = true;
            this.lboxIgraci.ItemHeight = 31;
            this.lboxIgraci.Location = new System.Drawing.Point(33, 90);
            this.lboxIgraci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lboxIgraci.Name = "lboxIgraci";
            this.lboxIgraci.Size = new System.Drawing.Size(399, 345);
            this.lboxIgraci.TabIndex = 0;
            this.lboxIgraci.SelectedIndexChanged += new System.EventHandler(this.lboxIgraci_SelectedIndexChanged);
            // 
            // pboxIgrac
            // 
            this.pboxIgrac.Location = new System.Drawing.Point(441, 90);
            this.pboxIgrac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pboxIgrac.Name = "pboxIgrac";
            this.pboxIgrac.Size = new System.Drawing.Size(284, 287);
            this.pboxIgrac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxIgrac.TabIndex = 1;
            this.pboxIgrac.TabStop = false;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(441, 425);
            this.btnDodajSliku.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(284, 39);
            this.btnDodajSliku.TabIndex = 2;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(733, 425);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(203, 39);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Dalje";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbIme
            // 
            this.tbIme.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tbIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIme.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIme.ForeColor = System.Drawing.Color.White;
            this.tbIme.Location = new System.Drawing.Point(733, 129);
            this.tbIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIme.Name = "tbIme";
            this.tbIme.ReadOnly = true;
            this.tbIme.Size = new System.Drawing.Size(328, 41);
            this.tbIme.TabIndex = 3;
            this.tbIme.Text = "IME";
            // 
            // tbPrezime
            // 
            this.tbPrezime.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tbPrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrezime.Font = new System.Drawing.Font("Bebas Neue", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrezime.ForeColor = System.Drawing.Color.White;
            this.tbPrezime.Location = new System.Drawing.Point(733, 162);
            this.tbPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.ReadOnly = true;
            this.tbPrezime.Size = new System.Drawing.Size(328, 72);
            this.tbPrezime.TabIndex = 8;
            this.tbPrezime.Text = "PREZIME";
            // 
            // tbBroj
            // 
            this.tbBroj.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tbBroj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBroj.Font = new System.Drawing.Font("Bebas Neue", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBroj.ForeColor = System.Drawing.Color.White;
            this.tbBroj.Location = new System.Drawing.Point(773, 222);
            this.tbBroj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBroj.Name = "tbBroj";
            this.tbBroj.ReadOnly = true;
            this.tbBroj.Size = new System.Drawing.Size(79, 96);
            this.tbBroj.TabIndex = 9;
            this.tbBroj.Text = "00";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Bebas Neue", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(733, 222);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(33, 96);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "#";
            // 
            // tbPozicija
            // 
            this.tbPozicija.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tbPozicija.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPozicija.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPozicija.ForeColor = System.Drawing.Color.White;
            this.tbPozicija.Location = new System.Drawing.Point(733, 304);
            this.tbPozicija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPozicija.Name = "tbPozicija";
            this.tbPozicija.ReadOnly = true;
            this.tbPozicija.Size = new System.Drawing.Size(149, 36);
            this.tbPozicija.TabIndex = 11;
            this.tbPozicija.Text = "POZICIJA";
            // 
            // tbKapetan
            // 
            this.tbKapetan.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tbKapetan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKapetan.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKapetan.ForeColor = System.Drawing.Color.White;
            this.tbKapetan.Location = new System.Drawing.Point(733, 341);
            this.tbKapetan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKapetan.Name = "tbKapetan";
            this.tbKapetan.ReadOnly = true;
            this.tbKapetan.Size = new System.Drawing.Size(149, 36);
            this.tbKapetan.TabIndex = 12;
            // 
            // lbDrzava
            // 
            this.lbDrzava.AutoSize = true;
            this.lbDrzava.Font = new System.Drawing.Font("Bebas Neue", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDrzava.ForeColor = System.Drawing.Color.White;
            this.lbDrzava.Location = new System.Drawing.Point(20, 20);
            this.lbDrzava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDrzava.Name = "lbDrzava";
            this.lbDrzava.Size = new System.Drawing.Size(167, 72);
            this.lbDrzava.TabIndex = 13;
            this.lbDrzava.Text = "drzava";
            this.lbDrzava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbKod
            // 
            this.lbKod.AutoSize = true;
            this.lbKod.Font = new System.Drawing.Font("Bebas Neue", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKod.ForeColor = System.Drawing.Color.White;
            this.lbKod.Location = new System.Drawing.Point(725, 90);
            this.lbKod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKod.Name = "lbKod";
            this.lbKod.Size = new System.Drawing.Size(59, 41);
            this.lbKod.TabIndex = 21;
            this.lbKod.Text = "KOD";
            // 
            // tbSave
            // 
            this.tbSave.Location = new System.Drawing.Point(441, 386);
            this.tbSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(283, 22);
            this.tbSave.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(733, 384);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(203, 39);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PlayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1003, 510);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbSave);
            this.Controls.Add(this.lbKod);
            this.Controls.Add(this.lbDrzava);
            this.Controls.Add(this.tbKapetan);
            this.Controls.Add(this.tbPozicija);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbBroj);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.pboxIgrac);
            this.Controls.Add(this.lboxIgraci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PlayerInfo";
            this.Text = "PlayerInfo";
            this.Load += new System.EventHandler(this.PlayerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxIgrac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxIgraci;
        private System.Windows.Forms.PictureBox pboxIgrac;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbBroj;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbPozicija;
        private System.Windows.Forms.TextBox tbKapetan;
        private System.Windows.Forms.Label lbDrzava;
        private System.Windows.Forms.Label lbKod;
        private System.Windows.Forms.TextBox tbSave;
        private System.Windows.Forms.Button btnSave;
    }
}