namespace Aplikacija
{
    partial class RankList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankList));
            this.pboxIgrac = new System.Windows.Forms.PictureBox();
            this.btnYellowSort = new System.Windows.Forms.Button();
            this.btnGoalsSort = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.PictureBox();
            this.lbDrzava = new System.Windows.Forms.Label();
            this.lbKod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbGrupa = new System.Windows.Forms.Label();
            this.lboxIgraci = new System.Windows.Forms.ListBox();
            this.tbPozicija = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbBroj = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbKapetan = new System.Windows.Forms.TextBox();
            this.tbYellowCard = new System.Windows.Forms.TextBox();
            this.lbYellowCard = new System.Windows.Forms.Label();
            this.lbGoals = new System.Windows.Forms.Label();
            this.tbGoals = new System.Windows.Forms.TextBox();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.izađiIzAplikacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROMJENIPRVENSTVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pboxIgrac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pboxIgrac
            // 
            this.pboxIgrac.Location = new System.Drawing.Point(400, 146);
            this.pboxIgrac.Margin = new System.Windows.Forms.Padding(4);
            this.pboxIgrac.Name = "pboxIgrac";
            this.pboxIgrac.Size = new System.Drawing.Size(231, 330);
            this.pboxIgrac.TabIndex = 4;
            this.pboxIgrac.TabStop = false;
            // 
            // btnYellowSort
            // 
            this.btnYellowSort.Location = new System.Drawing.Point(32, 551);
            this.btnYellowSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnYellowSort.Name = "btnYellowSort";
            this.btnYellowSort.Size = new System.Drawing.Size(291, 28);
            this.btnYellowSort.TabIndex = 15;
            this.btnYellowSort.Text = "Yellow Cards";
            this.btnYellowSort.UseVisualStyleBackColor = true;
            this.btnYellowSort.Click += new System.EventHandler(this.btnYellowSort_Click);
            // 
            // btnGoalsSort
            // 
            this.btnGoalsSort.Location = new System.Drawing.Point(32, 587);
            this.btnGoalsSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoalsSort.Name = "btnGoalsSort";
            this.btnGoalsSort.Size = new System.Drawing.Size(291, 28);
            this.btnGoalsSort.TabIndex = 16;
            this.btnGoalsSort.Text = "Goals Scored";
            this.btnGoalsSort.UseVisualStyleBackColor = true;
            this.btnGoalsSort.Click += new System.EventHandler(this.btnGoalsSort_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::Aplikacija.Properties.Resources.print;
            this.btnPrint.Location = new System.Drawing.Point(927, 574);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(53, 49);
            this.btnPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPrint.TabIndex = 18;
            this.btnPrint.TabStop = false;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrintGolovi_Click);
            // 
            // lbDrzava
            // 
            this.lbDrzava.AutoSize = true;
            this.lbDrzava.Font = new System.Drawing.Font("Bebas Neue", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDrzava.ForeColor = System.Drawing.Color.White;
            this.lbDrzava.Location = new System.Drawing.Point(17, 25);
            this.lbDrzava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDrzava.Name = "lbDrzava";
            this.lbDrzava.Size = new System.Drawing.Size(210, 90);
            this.lbDrzava.TabIndex = 20;
            this.lbDrzava.Text = "DRZAVA";
            this.lbDrzava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbKod
            // 
            this.lbKod.AutoSize = true;
            this.lbKod.Font = new System.Drawing.Font("Bebas Neue", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKod.ForeColor = System.Drawing.Color.White;
            this.lbKod.Location = new System.Drawing.Point(25, 101);
            this.lbKod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKod.Name = "lbKod";
            this.lbKod.Size = new System.Drawing.Size(59, 41);
            this.lbKod.TabIndex = 22;
            this.lbKod.Text = "KOD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 41);
            this.label1.TabIndex = 21;
            this.label1.Text = "GROUP";
            // 
            // lbGrupa
            // 
            this.lbGrupa.AutoSize = true;
            this.lbGrupa.Font = new System.Drawing.Font("Bebas Neue", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrupa.ForeColor = System.Drawing.Color.White;
            this.lbGrupa.Location = new System.Drawing.Point(111, 140);
            this.lbGrupa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGrupa.Name = "lbGrupa";
            this.lbGrupa.Size = new System.Drawing.Size(32, 41);
            this.lbGrupa.TabIndex = 23;
            this.lbGrupa.Text = "D";
            // 
            // lboxIgraci
            // 
            this.lboxIgraci.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lboxIgraci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboxIgraci.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxIgraci.ForeColor = System.Drawing.Color.White;
            this.lboxIgraci.FormattingEnabled = true;
            this.lboxIgraci.ItemHeight = 29;
            this.lboxIgraci.Location = new System.Drawing.Point(33, 206);
            this.lboxIgraci.Margin = new System.Windows.Forms.Padding(4);
            this.lboxIgraci.Name = "lboxIgraci";
            this.lboxIgraci.Size = new System.Drawing.Size(359, 290);
            this.lboxIgraci.TabIndex = 24;
            this.lboxIgraci.SelectedIndexChanged += new System.EventHandler(this.lboxIgraci_SelectedIndexChanged);
            // 
            // tbPozicija
            // 
            this.tbPozicija.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tbPozicija.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPozicija.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPozicija.ForeColor = System.Drawing.Color.White;
            this.tbPozicija.Location = new System.Drawing.Point(663, 321);
            this.tbPozicija.Margin = new System.Windows.Forms.Padding(4);
            this.tbPozicija.Name = "tbPozicija";
            this.tbPozicija.ReadOnly = true;
            this.tbPozicija.Size = new System.Drawing.Size(149, 36);
            this.tbPozicija.TabIndex = 29;
            this.tbPozicija.Text = "POZICIJA";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Bebas Neue", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(663, 239);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(33, 96);
            this.textBox3.TabIndex = 28;
            this.textBox3.Text = "#";
            // 
            // tbBroj
            // 
            this.tbBroj.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tbBroj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBroj.Font = new System.Drawing.Font("Bebas Neue", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBroj.ForeColor = System.Drawing.Color.White;
            this.tbBroj.Location = new System.Drawing.Point(703, 239);
            this.tbBroj.Margin = new System.Windows.Forms.Padding(4);
            this.tbBroj.Name = "tbBroj";
            this.tbBroj.ReadOnly = true;
            this.tbBroj.Size = new System.Drawing.Size(79, 96);
            this.tbBroj.TabIndex = 27;
            this.tbBroj.Text = "00";
            // 
            // tbPrezime
            // 
            this.tbPrezime.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tbPrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrezime.Font = new System.Drawing.Font("Bebas Neue", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrezime.ForeColor = System.Drawing.Color.White;
            this.tbPrezime.Location = new System.Drawing.Point(663, 180);
            this.tbPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.ReadOnly = true;
            this.tbPrezime.Size = new System.Drawing.Size(328, 72);
            this.tbPrezime.TabIndex = 26;
            this.tbPrezime.Text = "PREZIME";
            // 
            // tbIme
            // 
            this.tbIme.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tbIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIme.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIme.ForeColor = System.Drawing.Color.White;
            this.tbIme.Location = new System.Drawing.Point(663, 146);
            this.tbIme.Margin = new System.Windows.Forms.Padding(4);
            this.tbIme.Name = "tbIme";
            this.tbIme.ReadOnly = true;
            this.tbIme.Size = new System.Drawing.Size(328, 41);
            this.tbIme.TabIndex = 25;
            this.tbIme.Text = "IME";
            // 
            // tbKapetan
            // 
            this.tbKapetan.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tbKapetan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKapetan.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKapetan.ForeColor = System.Drawing.Color.White;
            this.tbKapetan.Location = new System.Drawing.Point(639, 364);
            this.tbKapetan.Margin = new System.Windows.Forms.Padding(4);
            this.tbKapetan.Name = "tbKapetan";
            this.tbKapetan.ReadOnly = true;
            this.tbKapetan.Size = new System.Drawing.Size(149, 36);
            this.tbKapetan.TabIndex = 30;
            // 
            // tbYellowCard
            // 
            this.tbYellowCard.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tbYellowCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbYellowCard.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYellowCard.ForeColor = System.Drawing.Color.White;
            this.tbYellowCard.Location = new System.Drawing.Point(852, 364);
            this.tbYellowCard.Margin = new System.Windows.Forms.Padding(4);
            this.tbYellowCard.Name = "tbYellowCard";
            this.tbYellowCard.ReadOnly = true;
            this.tbYellowCard.Size = new System.Drawing.Size(69, 36);
            this.tbYellowCard.TabIndex = 31;
            this.tbYellowCard.Text = "0";
            // 
            // lbYellowCard
            // 
            this.lbYellowCard.AutoSize = true;
            this.lbYellowCard.Font = new System.Drawing.Font("Bebas Neue", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYellowCard.ForeColor = System.Drawing.Color.White;
            this.lbYellowCard.Location = new System.Drawing.Point(655, 363);
            this.lbYellowCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbYellowCard.Name = "lbYellowCard";
            this.lbYellowCard.Size = new System.Drawing.Size(179, 41);
            this.lbYellowCard.TabIndex = 32;
            this.lbYellowCard.Text = "YELLOW CARDS:";
            // 
            // lbGoals
            // 
            this.lbGoals.AutoSize = true;
            this.lbGoals.Font = new System.Drawing.Font("Bebas Neue", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGoals.ForeColor = System.Drawing.Color.White;
            this.lbGoals.Location = new System.Drawing.Point(655, 404);
            this.lbGoals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGoals.Name = "lbGoals";
            this.lbGoals.Size = new System.Drawing.Size(90, 41);
            this.lbGoals.TabIndex = 34;
            this.lbGoals.Text = "GOALS:";
            // 
            // tbGoals
            // 
            this.tbGoals.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tbGoals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGoals.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGoals.ForeColor = System.Drawing.Color.White;
            this.tbGoals.Location = new System.Drawing.Point(852, 405);
            this.tbGoals.Margin = new System.Windows.Forms.Padding(4);
            this.tbGoals.Name = "tbGoals";
            this.tbGoals.ReadOnly = true;
            this.tbGoals.Size = new System.Drawing.Size(69, 36);
            this.tbGoals.TabIndex = 33;
            this.tbGoals.Text = "0";
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.PrintDocument_EndPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.toolStrip1.Font = new System.Drawing.Font("Bebas Neue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(996, 27);
            this.toolStrip1.TabIndex = 35;
            this.toolStrip1.Text = "SettingsToolStrip";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izađiIzAplikacijeToolStripMenuItem,
            this.pROMJENIPRVENSTVOToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::Aplikacija.Properties.Resources.settings;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // izađiIzAplikacijeToolStripMenuItem
            // 
            this.izađiIzAplikacijeToolStripMenuItem.Name = "izađiIzAplikacijeToolStripMenuItem";
            this.izađiIzAplikacijeToolStripMenuItem.Size = new System.Drawing.Size(220, 28);
            this.izađiIzAplikacijeToolStripMenuItem.Text = "Izađi iz aplikacije";
            this.izađiIzAplikacijeToolStripMenuItem.Click += new System.EventHandler(this.izađiIzAplikacijeToolStripMenuItem_Click);
            // 
            // pROMJENIPRVENSTVOToolStripMenuItem
            // 
            this.pROMJENIPRVENSTVOToolStripMenuItem.Name = "pROMJENIPRVENSTVOToolStripMenuItem";
            this.pROMJENIPRVENSTVOToolStripMenuItem.Size = new System.Drawing.Size(220, 28);
            this.pROMJENIPRVENSTVOToolStripMenuItem.Text = "PROMJENI PRVENSTVO";
            this.pROMJENIPRVENSTVOToolStripMenuItem.Click += new System.EventHandler(this.pROMJENIPRVENSTVOToolStripMenuItem_Click);
            // 
            // RankList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(996, 638);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbGoals);
            this.Controls.Add(this.tbGoals);
            this.Controls.Add(this.lbYellowCard);
            this.Controls.Add(this.tbYellowCard);
            this.Controls.Add(this.tbKapetan);
            this.Controls.Add(this.tbPozicija);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbBroj);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.lboxIgraci);
            this.Controls.Add(this.lbGrupa);
            this.Controls.Add(this.lbKod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDrzava);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnGoalsSort);
            this.Controls.Add(this.btnYellowSort);
            this.Controls.Add(this.pboxIgrac);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RankList";
            this.Text = "RankList";
            this.Load += new System.EventHandler(this.RankList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxIgrac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pboxIgrac;
        private System.Windows.Forms.Button btnYellowSort;
        private System.Windows.Forms.Button btnGoalsSort;
        private System.Windows.Forms.PictureBox btnPrint;
        private System.Windows.Forms.Label lbDrzava;
        private System.Windows.Forms.Label lbKod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbGrupa;
        private System.Windows.Forms.ListBox lboxIgraci;
        private System.Windows.Forms.TextBox tbPozicija;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbBroj;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbKapetan;
        private System.Windows.Forms.TextBox tbYellowCard;
        private System.Windows.Forms.Label lbYellowCard;
        private System.Windows.Forms.Label lbGoals;
        private System.Windows.Forms.TextBox tbGoals;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem izađiIzAplikacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROMJENIPRVENSTVOToolStripMenuItem;
    }
}