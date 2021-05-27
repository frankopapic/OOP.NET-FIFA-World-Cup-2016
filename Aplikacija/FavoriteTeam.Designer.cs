namespace Aplikacija
{
    partial class FavoriteTeam
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lboxPlayerList = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lboxFavoriteList = new System.Windows.Forms.ListBox();
            this.lbKod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDrzava = new System.Windows.Forms.Label();
            this.lbGrupa = new System.Windows.Forms.Label();
            this.lblAllPlayers = new System.Windows.Forms.Label();
            this.lblSelectedPlayers = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboxPlayerList
            // 
            this.lboxPlayerList.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lboxPlayerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboxPlayerList.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxPlayerList.ForeColor = System.Drawing.Color.White;
            this.lboxPlayerList.FormattingEnabled = true;
            this.lboxPlayerList.ItemHeight = 29;
            this.lboxPlayerList.Location = new System.Drawing.Point(309, 94);
            this.lboxPlayerList.Margin = new System.Windows.Forms.Padding(4);
            this.lboxPlayerList.Name = "lboxPlayerList";
            this.lboxPlayerList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lboxPlayerList.Size = new System.Drawing.Size(356, 290);
            this.lboxPlayerList.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(309, 453);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 44);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lboxFavoriteList
            // 
            this.lboxFavoriteList.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lboxFavoriteList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboxFavoriteList.Font = new System.Drawing.Font("Bebas Neue", 14.25F);
            this.lboxFavoriteList.ForeColor = System.Drawing.Color.White;
            this.lboxFavoriteList.FormattingEnabled = true;
            this.lboxFavoriteList.ItemHeight = 29;
            this.lboxFavoriteList.Location = new System.Drawing.Point(673, 94);
            this.lboxFavoriteList.Margin = new System.Windows.Forms.Padding(4);
            this.lboxFavoriteList.Name = "lboxFavoriteList";
            this.lboxFavoriteList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lboxFavoriteList.Size = new System.Drawing.Size(356, 290);
            this.lboxFavoriteList.TabIndex = 3;
            // 
            // lbKod
            // 
            this.lbKod.AutoSize = true;
            this.lbKod.Font = new System.Drawing.Font("Bebas Neue", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKod.ForeColor = System.Drawing.Color.White;
            this.lbKod.Location = new System.Drawing.Point(32, 123);
            this.lbKod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKod.Name = "lbKod";
            this.lbKod.Size = new System.Drawing.Size(59, 41);
            this.lbKod.TabIndex = 17;
            this.lbKod.Text = "KOD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 41);
            this.label2.TabIndex = 16;
            this.label2.Text = "GROUP";
            // 
            // lbDrzava
            // 
            this.lbDrzava.AutoSize = true;
            this.lbDrzava.Font = new System.Drawing.Font("Bebas Neue", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDrzava.ForeColor = System.Drawing.Color.White;
            this.lbDrzava.Location = new System.Drawing.Point(24, 46);
            this.lbDrzava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDrzava.Name = "lbDrzava";
            this.lbDrzava.Size = new System.Drawing.Size(210, 90);
            this.lbDrzava.TabIndex = 15;
            this.lbDrzava.Text = "DRZAVA";
            this.lbDrzava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGrupa
            // 
            this.lbGrupa.AutoSize = true;
            this.lbGrupa.Font = new System.Drawing.Font("Bebas Neue", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrupa.ForeColor = System.Drawing.Color.White;
            this.lbGrupa.Location = new System.Drawing.Point(115, 162);
            this.lbGrupa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGrupa.Name = "lbGrupa";
            this.lbGrupa.Size = new System.Drawing.Size(32, 41);
            this.lbGrupa.TabIndex = 18;
            this.lbGrupa.Text = "D";
            // 
            // lblAllPlayers
            // 
            this.lblAllPlayers.AutoSize = true;
            this.lblAllPlayers.Font = new System.Drawing.Font("Bebas Neue", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllPlayers.ForeColor = System.Drawing.Color.White;
            this.lblAllPlayers.Location = new System.Drawing.Point(301, 50);
            this.lblAllPlayers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllPlayers.Name = "lblAllPlayers";
            this.lblAllPlayers.Size = new System.Drawing.Size(124, 41);
            this.lblAllPlayers.TabIndex = 19;
            this.lblAllPlayers.Tag = "t";
            this.lblAllPlayers.Text = "SVI IGRAČI";
            // 
            // lblSelectedPlayers
            // 
            this.lblSelectedPlayers.AutoSize = true;
            this.lblSelectedPlayers.Font = new System.Drawing.Font("Bebas Neue", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedPlayers.ForeColor = System.Drawing.Color.White;
            this.lblSelectedPlayers.Location = new System.Drawing.Point(665, 50);
            this.lblSelectedPlayers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedPlayers.Name = "lblSelectedPlayers";
            this.lblSelectedPlayers.Size = new System.Drawing.Size(197, 41);
            this.lblSelectedPlayers.TabIndex = 20;
            this.lblSelectedPlayers.Tag = "t";
            this.lblSelectedPlayers.Text = "ODABRANI IGRAČI";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDelete.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(673, 453);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 44);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "IZBRIŠI";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(923, 453);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 44);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "SPREMI";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FavoriteTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSelectedPlayers);
            this.Controls.Add(this.lblAllPlayers);
            this.Controls.Add(this.lbGrupa);
            this.Controls.Add(this.lbKod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDrzava);
            this.Controls.Add(this.lboxFavoriteList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lboxPlayerList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FavoriteTeam";
            this.Size = new System.Drawing.Size(1067, 523);
            this.Load += new System.EventHandler(this.FavoriteTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxPlayerList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lboxFavoriteList;
        private System.Windows.Forms.Label lbKod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDrzava;
        private System.Windows.Forms.Label lbGrupa;
        private System.Windows.Forms.Label lblAllPlayers;
        private System.Windows.Forms.Label lblSelectedPlayers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}
