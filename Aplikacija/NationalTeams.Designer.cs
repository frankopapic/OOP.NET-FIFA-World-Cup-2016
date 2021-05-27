namespace Aplikacija
{
    partial class NationalTeams
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
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.lblFavorite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTeams
            // 
            this.cbTeams.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTeams.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(369, 223);
            this.cbTeams.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(349, 37);
            this.cbTeams.TabIndex = 0;
            this.cbTeams.SelectedIndexChanged += new System.EventHandler(this.cbTeams_SelectedIndexChanged);
            // 
            // lblFavorite
            // 
            this.lblFavorite.AutoSize = true;
            this.lblFavorite.Font = new System.Drawing.Font("Bebas Neue", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavorite.ForeColor = System.Drawing.Color.White;
            this.lblFavorite.Location = new System.Drawing.Point(258, 166);
            this.lblFavorite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFavorite.Name = "lblFavorite";
            this.lblFavorite.Size = new System.Drawing.Size(639, 53);
            this.lblFavorite.TabIndex = 1;
            this.lblFavorite.Text = "Odaberite svoju omiljenu reprezentaciju: ";
            // 
            // NationalTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1051, 581);
            this.Controls.Add(this.lblFavorite);
            this.Controls.Add(this.cbTeams);
            this.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NationalTeams";
            this.Text = "NationalTeams";
            this.Load += new System.EventHandler(this.NationalTeams_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTeams;
        private System.Windows.Forms.Label lblFavorite;
    }
}