namespace DaisyKlinika
{
    partial class Pacijent_forma
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
            this.tabControlPacijent = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.label1Por = new System.Windows.Forms.Label();
            this.label1Sadasnje = new System.Windows.Forms.Label();
            this.textBoxPordo = new System.Windows.Forms.TextBox();
            this.labelAlergije = new System.Windows.Forms.Label();
            this.label1Prija = new System.Windows.Forms.Label();
            this.textBoxAlergije = new System.Windows.Forms.TextBox();
            this.textBoxPrija = new System.Windows.Forms.TextBox();
            this.textBoxPrijasnje = new System.Windows.Forms.TextBox();
            this.groupBoxLpodaci = new System.Windows.Forms.GroupBox();
            this.textBoxIm = new System.Windows.Forms.TextBox();
            this.labelAdres = new System.Windows.Forms.Label();
            this.textBoxPrez = new System.Windows.Forms.TextBox();
            this.labelDat = new System.Windows.Forms.Label();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.label1JMBG = new System.Windows.Forms.Label();
            this.textBoxJMBG = new System.Windows.Forms.TextBox();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.textBoxDatum = new System.Windows.Forms.TextBox();
            this.labelIme = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelPregledi = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Pregledi = new System.Windows.Forms.TabPage();
            this.labelObavljeni = new System.Windows.Forms.Label();
            this.richTextBoxJu = new System.Windows.Forms.RichTextBox();
            this.pictureBoxPac = new System.Windows.Forms.PictureBox();
            this.richTextBoxTerapija = new System.Windows.Forms.RichTextBox();
            this.labelTerapija = new System.Windows.Forms.Label();
            this.tabControlPacijent.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxLpodaci.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.Pregledi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPac)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPacijent
            // 
            this.tabControlPacijent.Controls.Add(this.tabPage2);
            this.tabControlPacijent.Controls.Add(this.tabPage3);
            this.tabControlPacijent.Controls.Add(this.Pregledi);
            this.tabControlPacijent.Location = new System.Drawing.Point(0, 0);
            this.tabControlPacijent.Name = "tabControlPacijent";
            this.tabControlPacijent.SelectedIndex = 0;
            this.tabControlPacijent.Size = new System.Drawing.Size(678, 308);
            this.tabControlPacijent.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxInfo);
            this.tabPage2.Controls.Add(this.groupBoxLpodaci);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(670, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Moj Karton";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelTerapija);
            this.groupBoxInfo.Controls.Add(this.richTextBoxTerapija);
            this.groupBoxInfo.Controls.Add(this.label1Por);
            this.groupBoxInfo.Controls.Add(this.label1Sadasnje);
            this.groupBoxInfo.Controls.Add(this.textBoxPordo);
            this.groupBoxInfo.Controls.Add(this.labelAlergije);
            this.groupBoxInfo.Controls.Add(this.label1Prija);
            this.groupBoxInfo.Controls.Add(this.textBoxAlergije);
            this.groupBoxInfo.Controls.Add(this.textBoxPrija);
            this.groupBoxInfo.Controls.Add(this.textBoxPrijasnje);
            this.groupBoxInfo.Location = new System.Drawing.Point(335, 6);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(314, 257);
            this.groupBoxInfo.TabIndex = 19;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Dodatne Informacije";
            // 
            // label1Por
            // 
            this.label1Por.AutoSize = true;
            this.label1Por.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1Por.Location = new System.Drawing.Point(21, 163);
            this.label1Por.Name = "label1Por";
            this.label1Por.Size = new System.Drawing.Size(104, 15);
            this.label1Por.TabIndex = 18;
            this.label1Por.Text = "Bolesti u porodici:";
            // 
            // label1Sadasnje
            // 
            this.label1Sadasnje.AutoSize = true;
            this.label1Sadasnje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1Sadasnje.Location = new System.Drawing.Point(21, 87);
            this.label1Sadasnje.Name = "label1Sadasnje";
            this.label1Sadasnje.Size = new System.Drawing.Size(98, 15);
            this.label1Sadasnje.TabIndex = 14;
            this.label1Sadasnje.Text = "Sadašnja bolest:";
            // 
            // textBoxPordo
            // 
            this.textBoxPordo.Location = new System.Drawing.Point(137, 160);
            this.textBoxPordo.Name = "textBoxPordo";
            this.textBoxPordo.ReadOnly = true;
            this.textBoxPordo.Size = new System.Drawing.Size(100, 20);
            this.textBoxPordo.TabIndex = 17;
            // 
            // labelAlergije
            // 
            this.labelAlergije.AutoSize = true;
            this.labelAlergije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAlergije.Location = new System.Drawing.Point(21, 47);
            this.labelAlergije.Name = "labelAlergije";
            this.labelAlergije.Size = new System.Drawing.Size(51, 15);
            this.labelAlergije.TabIndex = 12;
            this.labelAlergije.Text = "Alergije:";
            this.labelAlergije.Click += new System.EventHandler(this.labelAlergije_Click);
            // 
            // label1Prija
            // 
            this.label1Prija.AutoSize = true;
            this.label1Prija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1Prija.Location = new System.Drawing.Point(21, 128);
            this.label1Prija.Name = "label1Prija";
            this.label1Prija.Size = new System.Drawing.Size(97, 15);
            this.label1Prija.TabIndex = 16;
            this.label1Prija.Text = "Prijašnje bolesti:";
            // 
            // textBoxAlergije
            // 
            this.textBoxAlergije.Location = new System.Drawing.Point(137, 47);
            this.textBoxAlergije.Name = "textBoxAlergije";
            this.textBoxAlergije.ReadOnly = true;
            this.textBoxAlergije.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlergije.TabIndex = 2;
            this.textBoxAlergije.TextChanged += new System.EventHandler(this.textBoxAlergije_TextChanged);
            // 
            // textBoxPrija
            // 
            this.textBoxPrija.Location = new System.Drawing.Point(137, 121);
            this.textBoxPrija.Name = "textBoxPrija";
            this.textBoxPrija.ReadOnly = true;
            this.textBoxPrija.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrija.TabIndex = 15;
            // 
            // textBoxPrijasnje
            // 
            this.textBoxPrijasnje.Location = new System.Drawing.Point(137, 84);
            this.textBoxPrijasnje.Name = "textBoxPrijasnje";
            this.textBoxPrijasnje.ReadOnly = true;
            this.textBoxPrijasnje.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrijasnje.TabIndex = 13;
            this.textBoxPrijasnje.TextChanged += new System.EventHandler(this.textBoxPrijasnje_TextChanged);
            // 
            // groupBoxLpodaci
            // 
            this.groupBoxLpodaci.Controls.Add(this.textBoxIm);
            this.groupBoxLpodaci.Controls.Add(this.labelAdres);
            this.groupBoxLpodaci.Controls.Add(this.textBoxPrez);
            this.groupBoxLpodaci.Controls.Add(this.labelDat);
            this.groupBoxLpodaci.Controls.Add(this.textBoxAdresa);
            this.groupBoxLpodaci.Controls.Add(this.label1JMBG);
            this.groupBoxLpodaci.Controls.Add(this.textBoxJMBG);
            this.groupBoxLpodaci.Controls.Add(this.labelPrezime);
            this.groupBoxLpodaci.Controls.Add(this.textBoxDatum);
            this.groupBoxLpodaci.Controls.Add(this.labelIme);
            this.groupBoxLpodaci.Location = new System.Drawing.Point(19, 6);
            this.groupBoxLpodaci.Name = "groupBoxLpodaci";
            this.groupBoxLpodaci.Size = new System.Drawing.Size(292, 270);
            this.groupBoxLpodaci.TabIndex = 11;
            this.groupBoxLpodaci.TabStop = false;
            this.groupBoxLpodaci.Text = "Lični podaci";
            // 
            // textBoxIm
            // 
            this.textBoxIm.Location = new System.Drawing.Point(137, 47);
            this.textBoxIm.Name = "textBoxIm";
            this.textBoxIm.ReadOnly = true;
            this.textBoxIm.Size = new System.Drawing.Size(100, 20);
            this.textBoxIm.TabIndex = 0;
            this.textBoxIm.TextChanged += new System.EventHandler(this.textBoxIm_TextChanged);
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAdres.Location = new System.Drawing.Point(16, 201);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(110, 15);
            this.labelAdres.TabIndex = 10;
            this.labelAdres.Text = "Adresa stanovanja:";
            this.labelAdres.Click += new System.EventHandler(this.labelAdres_Click);
            // 
            // textBoxPrez
            // 
            this.textBoxPrez.Location = new System.Drawing.Point(137, 84);
            this.textBoxPrez.Name = "textBoxPrez";
            this.textBoxPrez.ReadOnly = true;
            this.textBoxPrez.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrez.TabIndex = 1;
            this.textBoxPrez.TextChanged += new System.EventHandler(this.textBoxPrez_TextChanged);
            // 
            // labelDat
            // 
            this.labelDat.AutoSize = true;
            this.labelDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDat.Location = new System.Drawing.Point(16, 165);
            this.labelDat.Name = "labelDat";
            this.labelDat.Size = new System.Drawing.Size(92, 15);
            this.labelDat.TabIndex = 9;
            this.labelDat.Text = "Datum rođenja:";
            this.labelDat.Click += new System.EventHandler(this.labelDat_Click);
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(137, 200);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.ReadOnly = true;
            this.textBoxAdresa.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdresa.TabIndex = 3;
            this.textBoxAdresa.TextChanged += new System.EventHandler(this.textBoxAdresa_TextChanged);
            // 
            // label1JMBG
            // 
            this.label1JMBG.AutoSize = true;
            this.label1JMBG.Location = new System.Drawing.Point(16, 128);
            this.label1JMBG.Name = "label1JMBG";
            this.label1JMBG.Size = new System.Drawing.Size(39, 13);
            this.label1JMBG.TabIndex = 8;
            this.label1JMBG.Text = "JMBG:";
            this.label1JMBG.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxJMBG
            // 
            this.textBoxJMBG.Location = new System.Drawing.Point(137, 124);
            this.textBoxJMBG.Name = "textBoxJMBG";
            this.textBoxJMBG.ReadOnly = true;
            this.textBoxJMBG.Size = new System.Drawing.Size(100, 20);
            this.textBoxJMBG.TabIndex = 4;
            this.textBoxJMBG.TextChanged += new System.EventHandler(this.textBoxJMBG_TextChanged);
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrezime.Location = new System.Drawing.Point(16, 84);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(56, 15);
            this.labelPrezime.TabIndex = 7;
            this.labelPrezime.Text = "Prezime:";
            this.labelPrezime.Click += new System.EventHandler(this.labelPrezime_Click);
            // 
            // textBoxDatum
            // 
            this.textBoxDatum.Location = new System.Drawing.Point(137, 164);
            this.textBoxDatum.Name = "textBoxDatum";
            this.textBoxDatum.ReadOnly = true;
            this.textBoxDatum.Size = new System.Drawing.Size(100, 20);
            this.textBoxDatum.TabIndex = 5;
            this.textBoxDatum.TextChanged += new System.EventHandler(this.textBoxDatum_TextChanged);
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIme.Location = new System.Drawing.Point(21, 47);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(33, 16);
            this.labelIme.TabIndex = 6;
            this.labelIme.Text = "Ime:";
            this.labelIme.Click += new System.EventHandler(this.labelIme_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelPregledi);
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(670, 282);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Moj Raspored";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelPregledi
            // 
            this.labelPregledi.AutoSize = true;
            this.labelPregledi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPregledi.Location = new System.Drawing.Point(8, 19);
            this.labelPregledi.Name = "labelPregledi";
            this.labelPregledi.Size = new System.Drawing.Size(119, 16);
            this.labelPregledi.TabIndex = 1;
            this.labelPregledi.Text = "Zakazani pregledi:";
            this.labelPregledi.Click += new System.EventHandler(this.labelPregledi_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(630, 217);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Pregledi
            // 
            this.Pregledi.Controls.Add(this.labelObavljeni);
            this.Pregledi.Controls.Add(this.richTextBoxJu);
            this.Pregledi.Location = new System.Drawing.Point(4, 22);
            this.Pregledi.Name = "Pregledi";
            this.Pregledi.Size = new System.Drawing.Size(670, 282);
            this.Pregledi.TabIndex = 4;
            this.Pregledi.Text = "Historija Pregleda";
            this.Pregledi.UseVisualStyleBackColor = true;
            // 
            // labelObavljeni
            // 
            this.labelObavljeni.AutoSize = true;
            this.labelObavljeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelObavljeni.Location = new System.Drawing.Point(8, 18);
            this.labelObavljeni.Name = "labelObavljeni";
            this.labelObavljeni.Size = new System.Drawing.Size(121, 16);
            this.labelObavljeni.TabIndex = 1;
            this.labelObavljeni.Text = "Obavljeni pregledi:";
            this.labelObavljeni.Click += new System.EventHandler(this.labelObavljeni_Click);
            // 
            // richTextBoxJu
            // 
            this.richTextBoxJu.Location = new System.Drawing.Point(8, 40);
            this.richTextBoxJu.Name = "richTextBoxJu";
            this.richTextBoxJu.ReadOnly = true;
            this.richTextBoxJu.Size = new System.Drawing.Size(626, 217);
            this.richTextBoxJu.TabIndex = 0;
            this.richTextBoxJu.Text = "";
            this.richTextBoxJu.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // pictureBoxPac
            // 
            this.pictureBoxPac.InitialImage = global::DaisyKlinika.Properties.Resources.daisy;
            this.pictureBoxPac.Location = new System.Drawing.Point(705, 40);
            this.pictureBoxPac.Name = "pictureBoxPac";
            this.pictureBoxPac.Size = new System.Drawing.Size(100, 106);
            this.pictureBoxPac.TabIndex = 20;
            this.pictureBoxPac.TabStop = false;
            this.pictureBoxPac.Click += new System.EventHandler(this.pictureBoxPac_Click);
            // 
            // richTextBoxTerapija
            // 
            this.richTextBoxTerapija.Location = new System.Drawing.Point(137, 192);
            this.richTextBoxTerapija.Name = "richTextBoxTerapija";
            this.richTextBoxTerapija.ReadOnly = true;
            this.richTextBoxTerapija.Size = new System.Drawing.Size(100, 59);
            this.richTextBoxTerapija.TabIndex = 19;
            this.richTextBoxTerapija.Text = "";
            // 
            // labelTerapija
            // 
            this.labelTerapija.AutoSize = true;
            this.labelTerapija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTerapija.Location = new System.Drawing.Point(22, 205);
            this.labelTerapija.Name = "labelTerapija";
            this.labelTerapija.Size = new System.Drawing.Size(103, 15);
            this.labelTerapija.TabIndex = 20;
            this.labelTerapija.Text = "Trenutna terapija:";
            // 
            // Pacijent_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 337);
            this.Controls.Add(this.pictureBoxPac);
            this.Controls.Add(this.tabControlPacijent);
            this.Name = "Pacijent_forma";
            this.Text = "Pacijent";
            this.tabControlPacijent.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxLpodaci.ResumeLayout(false);
            this.groupBoxLpodaci.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.Pregledi.ResumeLayout(false);
            this.Pregledi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlPacijent;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxPrez;
        private System.Windows.Forms.TextBox textBoxIm;
        private System.Windows.Forms.TextBox textBoxDatum;
        private System.Windows.Forms.TextBox textBoxJMBG;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label label1JMBG;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelDat;
        private System.Windows.Forms.GroupBox groupBoxLpodaci;
        private System.Windows.Forms.TextBox textBoxAlergije;
        private System.Windows.Forms.Label labelAlergije;
        private System.Windows.Forms.TextBox textBoxPrijasnje;
        private System.Windows.Forms.Label label1Sadasnje;
        private System.Windows.Forms.Label label1Prija;
        private System.Windows.Forms.TextBox textBoxPrija;
        private System.Windows.Forms.TextBox textBoxPordo;
        private System.Windows.Forms.Label label1Por;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.PictureBox pictureBoxPac;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelPregledi;
        private System.Windows.Forms.TabPage Pregledi;
        private System.Windows.Forms.RichTextBox richTextBoxJu;
        private System.Windows.Forms.Label labelObavljeni;
        private System.Windows.Forms.Label labelTerapija;
        private System.Windows.Forms.RichTextBox richTextBoxTerapija;
    }
}