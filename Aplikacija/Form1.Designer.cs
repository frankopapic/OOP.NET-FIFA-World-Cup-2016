namespace Aplikacija
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
            this.btnLanguage = new System.Windows.Forms.Button();
            this.btnRussia = new System.Windows.Forms.PictureBox();
            this.btnFrance = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblChooseCompetition = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnRussia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFrance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLanguage.BackgroundImage = global::Aplikacija.Properties.Resources.croatia;
            this.btnLanguage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLanguage.FlatAppearance.BorderSize = 0;
            this.btnLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanguage.Location = new System.Drawing.Point(961, 21);
            this.btnLanguage.Margin = new System.Windows.Forms.Padding(0);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(67, 62);
            this.btnLanguage.TabIndex = 0;
            this.btnLanguage.UseVisualStyleBackColor = false;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // btnRussia
            // 
            this.btnRussia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRussia.BackgroundImage")));
            this.btnRussia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRussia.Image = ((System.Drawing.Image)(resources.GetObject("btnRussia.Image")));
            this.btnRussia.Location = new System.Drawing.Point(436, 97);
            this.btnRussia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRussia.Name = "btnRussia";
            this.btnRussia.Size = new System.Drawing.Size(143, 150);
            this.btnRussia.TabIndex = 1;
            this.btnRussia.TabStop = false;
            this.btnRussia.Tag = "men";
            this.btnRussia.Click += new System.EventHandler(this.btnRussia_Click);
            // 
            // btnFrance
            // 
            this.btnFrance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFrance.BackgroundImage")));
            this.btnFrance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFrance.Image = ((System.Drawing.Image)(resources.GetObject("btnFrance.Image")));
            this.btnFrance.Location = new System.Drawing.Point(436, 347);
            this.btnFrance.Margin = new System.Windows.Forms.Padding(0);
            this.btnFrance.Name = "btnFrance";
            this.btnFrance.Size = new System.Drawing.Size(143, 153);
            this.btnFrance.TabIndex = 2;
            this.btnFrance.TabStop = false;
            this.btnFrance.Tag = "women";
            this.btnFrance.Click += new System.EventHandler(this.btnFrance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(281, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "FIFA WORLD CUP RUSSIA 2018";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(236, 500);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(528, 56);
            this.label2.TabIndex = 4;
            this.label2.Text = "WOMEN\'S WORLD CUP FRANCE 2019";
            // 
            // lblChooseCompetition
            // 
            this.lblChooseCompetition.AutoSize = true;
            this.lblChooseCompetition.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseCompetition.ForeColor = System.Drawing.Color.White;
            this.lblChooseCompetition.Location = new System.Drawing.Point(332, 28);
            this.lblChooseCompetition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChooseCompetition.Name = "lblChooseCompetition";
            this.lblChooseCompetition.Size = new System.Drawing.Size(351, 56);
            this.lblChooseCompetition.TabIndex = 5;
            this.lblChooseCompetition.Text = "IZABERITE NATJECANJE:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1051, 581);
            this.Controls.Add(this.lblChooseCompetition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFrance);
            this.Controls.Add(this.btnRussia);
            this.Controls.Add(this.btnLanguage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnRussia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFrance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.PictureBox btnRussia;
        private System.Windows.Forms.PictureBox btnFrance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChooseCompetition;
    }
}

