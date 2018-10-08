namespace DaisyKlinika
{
    partial class Pocetak
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
            this.labelKime = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textKIme = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.buttonKreni = new System.Windows.Forms.Button();
            this.labelDaisy = new System.Windows.Forms.Label();
            this.labelKlinika = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelKime
            // 
            this.labelKime.AutoSize = true;
            this.labelKime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKime.Location = new System.Drawing.Point(93, 175);
            this.labelKime.Name = "labelKime";
            this.labelKime.Size = new System.Drawing.Size(91, 15);
            this.labelKime.TabIndex = 0;
            this.labelKime.Text = "Korisničko ime:";
            this.labelKime.Click += new System.EventHandler(this.labelKime_Click);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(93, 216);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(35, 15);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "Šifra:";
            this.labelPass.Click += new System.EventHandler(this.labelPass_Click);
            // 
            // textKIme
            // 
            this.textKIme.Location = new System.Drawing.Point(225, 174);
            this.textKIme.Name = "textKIme";
            this.textKIme.Size = new System.Drawing.Size(138, 20);
            this.textKIme.TabIndex = 2;
            this.textKIme.TextChanged += new System.EventHandler(this.textKIme_TextChanged);
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(225, 215);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(138, 20);
            this.textPass.TabIndex = 3;
            this.textPass.UseSystemPasswordChar = true;
            this.textPass.TextChanged += new System.EventHandler(this.textPass_TextChanged);
            // 
            // buttonKreni
            // 
            this.buttonKreni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKreni.Location = new System.Drawing.Point(169, 280);
            this.buttonKreni.Name = "buttonKreni";
            this.buttonKreni.Size = new System.Drawing.Size(75, 23);
            this.buttonKreni.TabIndex = 4;
            this.buttonKreni.Text = "Kreni";
            this.buttonKreni.UseVisualStyleBackColor = true;
            this.buttonKreni.Click += new System.EventHandler(this.buttonKreni_Click);
            // 
            // labelDaisy
            // 
            this.labelDaisy.AutoSize = true;
            this.labelDaisy.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaisy.ForeColor = System.Drawing.Color.Yellow;
            this.labelDaisy.Location = new System.Drawing.Point(216, 29);
            this.labelDaisy.Name = "labelDaisy";
            this.labelDaisy.Size = new System.Drawing.Size(111, 49);
            this.labelDaisy.TabIndex = 5;
            this.labelDaisy.Text = "Daisy";
            this.labelDaisy.Click += new System.EventHandler(this.labelDaisy_Click);
            // 
            // labelKlinika
            // 
            this.labelKlinika.AutoSize = true;
            this.labelKlinika.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKlinika.ForeColor = System.Drawing.Color.Yellow;
            this.labelKlinika.Location = new System.Drawing.Point(270, 78);
            this.labelKlinika.Name = "labelKlinika";
            this.labelKlinika.Size = new System.Drawing.Size(93, 36);
            this.labelKlinika.TabIndex = 6;
            this.labelKlinika.Text = "klinika";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 315);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(430, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Pocetak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(430, 337);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelKlinika);
            this.Controls.Add(this.labelDaisy);
            this.Controls.Add(this.buttonKreni);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textKIme);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelKime);
            this.Name = "Pocetak";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.Pocetak_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKime;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textKIme;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button buttonKreni;
        private System.Windows.Forms.Label labelDaisy;
        private System.Windows.Forms.Label labelKlinika;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}