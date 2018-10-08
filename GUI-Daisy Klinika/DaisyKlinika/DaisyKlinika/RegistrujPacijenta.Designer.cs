namespace DaisyKlinika
{
    partial class RegistrujPacijenta
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
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.Jmbg_pacijenta = new System.Windows.Forms.TextBox();
            this.Prezime_pacijenta = new System.Windows.Forms.TextBox();
            this.Ime_pacijenta = new System.Windows.Forms.TextBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pravilnoime_prezime = new System.Windows.Forms.ErrorProvider(this.components);
            this.DatumRodjenja = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RadioButtonZena = new System.Windows.Forms.RadioButton();
            this.radioButtonMuskarac = new System.Windows.Forms.RadioButton();
            this.radioButtonSlobodan = new System.Windows.Forms.RadioButton();
            this.radioButtonBrak = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pravilnoime_prezime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatumRodjenja)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Bracno stanje:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Spol:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(115, 255);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(126, 20);
            this.textBoxAdresa.TabIndex = 29;
            this.textBoxAdresa.TextChanged += new System.EventHandler(this.textBoxAdresa_TextChanged);
            this.textBoxAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.Adresa_Validating);
            // 
            // Jmbg_pacijenta
            // 
            this.Jmbg_pacijenta.Location = new System.Drawing.Point(115, 98);
            this.Jmbg_pacijenta.Name = "Jmbg_pacijenta";
            this.Jmbg_pacijenta.Size = new System.Drawing.Size(132, 20);
            this.Jmbg_pacijenta.TabIndex = 28;
            this.Jmbg_pacijenta.TextChanged += new System.EventHandler(this.Jmbg_pacijenta_TextChanged);
            this.Jmbg_pacijenta.Validating += new System.ComponentModel.CancelEventHandler(this.JMBG_pacijenta_Validating);
            this.Jmbg_pacijenta.Validated += new System.EventHandler(this.JMBG_pacijenta_Validated);
            // 
            // Prezime_pacijenta
            // 
            this.Prezime_pacijenta.Location = new System.Drawing.Point(115, 40);
            this.Prezime_pacijenta.Name = "Prezime_pacijenta";
            this.Prezime_pacijenta.Size = new System.Drawing.Size(132, 20);
            this.Prezime_pacijenta.TabIndex = 26;
            this.Prezime_pacijenta.TextChanged += new System.EventHandler(this.prezime_pacijenta_TextChanged);
            this.Prezime_pacijenta.Validating += new System.ComponentModel.CancelEventHandler(this.PrezimePacijenta_Validating);
            // 
            // Ime_pacijenta
            // 
            this.Ime_pacijenta.Location = new System.Drawing.Point(115, 12);
            this.Ime_pacijenta.Name = "Ime_pacijenta";
            this.Ime_pacijenta.Size = new System.Drawing.Size(132, 20);
            this.Ime_pacijenta.TabIndex = 25;
            this.Ime_pacijenta.TextChanged += new System.EventHandler(this.Ime_pacijenta_TextChanged);
            this.Ime_pacijenta.Validating += new System.ComponentModel.CancelEventHandler(this.Ime_pacijenta_Validating);
            this.Ime_pacijenta.Validated += new System.EventHandler(this.Ime_pacijenta_Validated);
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(166, 358);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 24;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Datum prijema:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Adresa:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "JMBG:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Datum rodjenja:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Prezime:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ime:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 289);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 20);
            this.dateTimePicker1.TabIndex = 35;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(115, 71);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker2.TabIndex = 36;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            this.dateTimePicker2.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker2_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pravilnoime_prezime
            // 
            this.pravilnoime_prezime.ContainerControl = this;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.ContainerControl = this;
            // 
            // RadioButtonZena
            // 
            this.RadioButtonZena.AutoSize = true;
            this.RadioButtonZena.Location = new System.Drawing.Point(128, 16);
            this.RadioButtonZena.Name = "RadioButtonZena";
            this.RadioButtonZena.Size = new System.Drawing.Size(50, 17);
            this.RadioButtonZena.TabIndex = 40;
            this.RadioButtonZena.TabStop = true;
            this.RadioButtonZena.Text = "Zena";
            this.RadioButtonZena.UseVisualStyleBackColor = true;
            this.RadioButtonZena.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonMuskarac
            // 
            this.radioButtonMuskarac.AutoSize = true;
            this.radioButtonMuskarac.Location = new System.Drawing.Point(25, 16);
            this.radioButtonMuskarac.Name = "radioButtonMuskarac";
            this.radioButtonMuskarac.Size = new System.Drawing.Size(72, 17);
            this.radioButtonMuskarac.TabIndex = 41;
            this.radioButtonMuskarac.TabStop = true;
            this.radioButtonMuskarac.Text = "Muskarac";
            this.radioButtonMuskarac.UseVisualStyleBackColor = true;
            // 
            // radioButtonSlobodan
            // 
            this.radioButtonSlobodan.AutoSize = true;
            this.radioButtonSlobodan.Location = new System.Drawing.Point(21, 19);
            this.radioButtonSlobodan.Name = "radioButtonSlobodan";
            this.radioButtonSlobodan.Size = new System.Drawing.Size(81, 17);
            this.radioButtonSlobodan.TabIndex = 42;
            this.radioButtonSlobodan.TabStop = true;
            this.radioButtonSlobodan.Text = "Slobodan/a";
            this.radioButtonSlobodan.UseVisualStyleBackColor = true;
            // 
            // radioButtonBrak
            // 
            this.radioButtonBrak.AutoSize = true;
            this.radioButtonBrak.Location = new System.Drawing.Point(121, 19);
            this.radioButtonBrak.Name = "radioButtonBrak";
            this.radioButtonBrak.Size = new System.Drawing.Size(63, 17);
            this.radioButtonBrak.TabIndex = 43;
            this.radioButtonBrak.TabStop = true;
            this.radioButtonBrak.Text = "U braku";
            this.radioButtonBrak.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(429, 22);
            this.statusStrip1.TabIndex = 44;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMuskarac);
            this.groupBox1.Controls.Add(this.RadioButtonZena);
            this.groupBox1.Location = new System.Drawing.Point(115, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 39);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonSlobodan);
            this.groupBox2.Controls.Add(this.radioButtonBrak);
            this.groupBox2.Location = new System.Drawing.Point(115, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 43);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // RegistrujPacijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 444);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxAdresa);
            this.Controls.Add(this.Jmbg_pacijenta);
            this.Controls.Add(this.Prezime_pacijenta);
            this.Controls.Add(this.Ime_pacijenta);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrujPacijenta";
            this.Text = "Registracija pacijenta";
            this.Load += new System.EventHandler(this.RegistrujPacijenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pravilnoime_prezime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatumRodjenja)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.TextBox Jmbg_pacijenta;
        private System.Windows.Forms.TextBox Prezime_pacijenta;
        private System.Windows.Forms.TextBox Ime_pacijenta;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider pravilnoime_prezime;
        private System.Windows.Forms.ErrorProvider DatumRodjenja;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton RadioButtonZena;
        private System.Windows.Forms.RadioButton radioButtonMuskarac;
        private System.Windows.Forms.RadioButton radioButtonBrak;
        private System.Windows.Forms.RadioButton radioButtonSlobodan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}