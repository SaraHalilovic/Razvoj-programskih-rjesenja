namespace DaisyKlinika
{
    partial class Kartoncic
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
            this.labelAlergije = new System.Windows.Forms.Label();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.labelJMBG = new System.Windows.Forms.Label();
            this.labelPrez = new System.Windows.Forms.Label();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelPorodicnininin = new System.Windows.Forms.Label();
            this.label2Prijasnje = new System.Windows.Forms.Label();
            this.label3Sad = new System.Windows.Forms.Label();
            this.labelterapija = new System.Windows.Forms.Label();
            this.labelMisljenje = new System.Windows.Forms.Label();
            this.textBoxAlergija = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxJMBG = new System.Windows.Forms.TextBox();
            this.textBoxPrez = new System.Windows.Forms.TextBox();
            this.textBoxImee = new System.Windows.Forms.TextBox();
            this.textBoxPorodica = new System.Windows.Forms.TextBox();
            this.textBoxPrijasnje = new System.Windows.Forms.TextBox();
            this.textBoxSadasnja = new System.Windows.Forms.TextBox();
            this.richTextBoxTrenutna = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMisljenje = new System.Windows.Forms.RichTextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAlergije
            // 
            this.labelAlergije.AutoSize = true;
            this.labelAlergije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAlergije.Location = new System.Drawing.Point(339, 20);
            this.labelAlergije.Name = "labelAlergije";
            this.labelAlergije.Size = new System.Drawing.Size(54, 15);
            this.labelAlergije.TabIndex = 0;
            this.labelAlergije.Text = "Alergije: ";
            this.labelAlergije.Click += new System.EventHandler(this.labelAlergije_Click);
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAdresa.Location = new System.Drawing.Point(10, 108);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(101, 15);
            this.labelAdresa.TabIndex = 1;
            this.labelAdresa.Text = "Adresa pacijenta:";
            // 
            // labelJMBG
            // 
            this.labelJMBG.AutoSize = true;
            this.labelJMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelJMBG.Location = new System.Drawing.Point(10, 78);
            this.labelJMBG.Name = "labelJMBG";
            this.labelJMBG.Size = new System.Drawing.Size(97, 15);
            this.labelJMBG.TabIndex = 2;
            this.labelJMBG.Text = "JMBG pacijenta:";
            this.labelJMBG.Click += new System.EventHandler(this.labelJMBG_Click);
            // 
            // labelPrez
            // 
            this.labelPrez.AutoSize = true;
            this.labelPrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrez.Location = new System.Drawing.Point(10, 47);
            this.labelPrez.Name = "labelPrez";
            this.labelPrez.Size = new System.Drawing.Size(109, 15);
            this.labelPrez.TabIndex = 3;
            this.labelPrez.Text = "Prezime pacijenta:";
            this.labelPrez.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIme.Location = new System.Drawing.Point(10, 20);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(84, 15);
            this.labelIme.TabIndex = 4;
            this.labelIme.Text = "Ime pacijenta:";
            this.labelIme.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelPorodicnininin
            // 
            this.labelPorodicnininin.AutoSize = true;
            this.labelPorodicnininin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPorodicnininin.Location = new System.Drawing.Point(339, 108);
            this.labelPorodicnininin.Name = "labelPorodicnininin";
            this.labelPorodicnininin.Size = new System.Drawing.Size(104, 15);
            this.labelPorodicnininin.TabIndex = 5;
            this.labelPorodicnininin.Text = "Bolesti u porodici:";
            this.labelPorodicnininin.Click += new System.EventHandler(this.labelPorodicnininin_Click);
            // 
            // label2Prijasnje
            // 
            this.label2Prijasnje.AutoSize = true;
            this.label2Prijasnje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2Prijasnje.Location = new System.Drawing.Point(339, 78);
            this.label2Prijasnje.Name = "label2Prijasnje";
            this.label2Prijasnje.Size = new System.Drawing.Size(97, 15);
            this.label2Prijasnje.TabIndex = 6;
            this.label2Prijasnje.Text = "Prijašnje bolesti:";
            this.label2Prijasnje.Click += new System.EventHandler(this.label2Prijasnje_Click);
            // 
            // label3Sad
            // 
            this.label3Sad.AutoSize = true;
            this.label3Sad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3Sad.Location = new System.Drawing.Point(339, 47);
            this.label3Sad.Name = "label3Sad";
            this.label3Sad.Size = new System.Drawing.Size(101, 15);
            this.label3Sad.TabIndex = 7;
            this.label3Sad.Text = "Sadašnje bolesti:";
            this.label3Sad.Click += new System.EventHandler(this.label3Sad_Click);
            // 
            // labelterapija
            // 
            this.labelterapija.AutoSize = true;
            this.labelterapija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelterapija.Location = new System.Drawing.Point(70, 168);
            this.labelterapija.Name = "labelterapija";
            this.labelterapija.Size = new System.Drawing.Size(103, 15);
            this.labelterapija.TabIndex = 8;
            this.labelterapija.Text = "Trenutna terapija:";
            this.labelterapija.Click += new System.EventHandler(this.labelterapija_Click);
            // 
            // labelMisljenje
            // 
            this.labelMisljenje.AutoSize = true;
            this.labelMisljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMisljenje.Location = new System.Drawing.Point(69, 243);
            this.labelMisljenje.Name = "labelMisljenje";
            this.labelMisljenje.Size = new System.Drawing.Size(104, 15);
            this.labelMisljenje.TabIndex = 9;
            this.labelMisljenje.Text = "Misljenje doktora:";
            this.labelMisljenje.Click += new System.EventHandler(this.labelMisljenje_Click);
            // 
            // textBoxAlergija
            // 
            this.textBoxAlergija.Location = new System.Drawing.Point(470, 15);
            this.textBoxAlergija.Name = "textBoxAlergija";
            this.textBoxAlergija.Size = new System.Drawing.Size(113, 20);
            this.textBoxAlergija.TabIndex = 10;
            this.textBoxAlergija.TextChanged += new System.EventHandler(this.textBoxAlergija_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(115, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxJMBG
            // 
            this.textBoxJMBG.Location = new System.Drawing.Point(125, 77);
            this.textBoxJMBG.Name = "textBoxJMBG";
            this.textBoxJMBG.ReadOnly = true;
            this.textBoxJMBG.Size = new System.Drawing.Size(115, 20);
            this.textBoxJMBG.TabIndex = 12;
            // 
            // textBoxPrez
            // 
            this.textBoxPrez.Location = new System.Drawing.Point(125, 46);
            this.textBoxPrez.Name = "textBoxPrez";
            this.textBoxPrez.ReadOnly = true;
            this.textBoxPrez.Size = new System.Drawing.Size(115, 20);
            this.textBoxPrez.TabIndex = 13;
            // 
            // textBoxImee
            // 
            this.textBoxImee.Location = new System.Drawing.Point(124, 20);
            this.textBoxImee.Name = "textBoxImee";
            this.textBoxImee.ReadOnly = true;
            this.textBoxImee.Size = new System.Drawing.Size(116, 20);
            this.textBoxImee.TabIndex = 14;
            this.textBoxImee.TextChanged += new System.EventHandler(this.textBoxImee_TextChanged);
            // 
            // textBoxPorodica
            // 
            this.textBoxPorodica.Location = new System.Drawing.Point(470, 108);
            this.textBoxPorodica.Name = "textBoxPorodica";
            this.textBoxPorodica.Size = new System.Drawing.Size(113, 20);
            this.textBoxPorodica.TabIndex = 15;
            this.textBoxPorodica.TextChanged += new System.EventHandler(this.textBoxPorodica_TextChanged);
            // 
            // textBoxPrijasnje
            // 
            this.textBoxPrijasnje.Location = new System.Drawing.Point(470, 78);
            this.textBoxPrijasnje.Name = "textBoxPrijasnje";
            this.textBoxPrijasnje.Size = new System.Drawing.Size(113, 20);
            this.textBoxPrijasnje.TabIndex = 16;
            this.textBoxPrijasnje.TextChanged += new System.EventHandler(this.textBoxPrijasnje_TextChanged);
            // 
            // textBoxSadasnja
            // 
            this.textBoxSadasnja.Location = new System.Drawing.Point(470, 47);
            this.textBoxSadasnja.Name = "textBoxSadasnja";
            this.textBoxSadasnja.Size = new System.Drawing.Size(113, 20);
            this.textBoxSadasnja.TabIndex = 17;
            this.textBoxSadasnja.TextChanged += new System.EventHandler(this.textBoxSadasnja_TextChanged);
            // 
            // richTextBoxTrenutna
            // 
            this.richTextBoxTrenutna.Location = new System.Drawing.Point(195, 155);
            this.richTextBoxTrenutna.Name = "richTextBoxTrenutna";
            this.richTextBoxTrenutna.Size = new System.Drawing.Size(364, 60);
            this.richTextBoxTrenutna.TabIndex = 18;
            this.richTextBoxTrenutna.Text = "";
            this.richTextBoxTrenutna.TextChanged += new System.EventHandler(this.richTextBoxTrenutna_TextChanged);
            // 
            // richTextBoxMisljenje
            // 
            this.richTextBoxMisljenje.Location = new System.Drawing.Point(195, 226);
            this.richTextBoxMisljenje.Name = "richTextBoxMisljenje";
            this.richTextBoxMisljenje.Size = new System.Drawing.Size(364, 55);
            this.richTextBoxMisljenje.TabIndex = 19;
            this.richTextBoxMisljenje.Text = "";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(278, 307);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 20;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Kartoncic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 369);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.richTextBoxMisljenje);
            this.Controls.Add(this.richTextBoxTrenutna);
            this.Controls.Add(this.textBoxSadasnja);
            this.Controls.Add(this.textBoxPrijasnje);
            this.Controls.Add(this.textBoxPorodica);
            this.Controls.Add(this.textBoxImee);
            this.Controls.Add(this.textBoxPrez);
            this.Controls.Add(this.textBoxJMBG);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxAlergija);
            this.Controls.Add(this.labelMisljenje);
            this.Controls.Add(this.labelterapija);
            this.Controls.Add(this.label3Sad);
            this.Controls.Add(this.label2Prijasnje);
            this.Controls.Add(this.labelPorodicnininin);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.labelPrez);
            this.Controls.Add(this.labelJMBG);
            this.Controls.Add(this.labelAdresa);
            this.Controls.Add(this.labelAlergije);
            this.Name = "Kartoncic";
            this.Text = "Karton";
            this.Load += new System.EventHandler(this.Kartoncic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlergije;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.Label labelJMBG;
        private System.Windows.Forms.Label labelPrez;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelPorodicnininin;
        private System.Windows.Forms.Label label2Prijasnje;
        private System.Windows.Forms.Label label3Sad;
        private System.Windows.Forms.Label labelterapija;
        private System.Windows.Forms.Label labelMisljenje;
        private System.Windows.Forms.TextBox textBoxAlergija;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxJMBG;
        private System.Windows.Forms.TextBox textBoxPrez;
        private System.Windows.Forms.TextBox textBoxImee;
        private System.Windows.Forms.TextBox textBoxPorodica;
        private System.Windows.Forms.TextBox textBoxPrijasnje;
        private System.Windows.Forms.TextBox textBoxSadasnja;
        private System.Windows.Forms.RichTextBox richTextBoxTrenutna;
        private System.Windows.Forms.RichTextBox richTextBoxMisljenje;
        private System.Windows.Forms.Button buttonOK;
    }
}