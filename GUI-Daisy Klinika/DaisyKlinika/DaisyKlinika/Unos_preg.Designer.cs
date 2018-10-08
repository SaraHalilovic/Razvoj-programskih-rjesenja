namespace DaisyKlinika
{
    partial class Unos_preg
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labeldatumce = new System.Windows.Forms.Label();
            this.labelUnesi = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxMinutice = new System.Windows.Forms.TextBox();
            this.textBoxSatt = new System.Windows.Forms.TextBox();
            this.button1ok = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izaberite ordinaciju:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dermatologija",
            "Hirurgija",
            "Interna medicina",
            "Kardiologija",
            "Laboratorijska medicina",
            "Oftamologija",
            "Opšta medicina",
            "Ortopedija",
            "Otorinolaringologija",
            "Stomatologija",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(184, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labeldatumce
            // 
            this.labeldatumce.AutoSize = true;
            this.labeldatumce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labeldatumce.Location = new System.Drawing.Point(12, 164);
            this.labeldatumce.Name = "labeldatumce";
            this.labeldatumce.Size = new System.Drawing.Size(154, 15);
            this.labeldatumce.TabIndex = 2;
            this.labeldatumce.Text = "Odaberite datum pregleda:";
            this.labeldatumce.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelUnesi
            // 
            this.labelUnesi.AutoSize = true;
            this.labelUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUnesi.Location = new System.Drawing.Point(12, 95);
            this.labelUnesi.Name = "labelUnesi";
            this.labelUnesi.Size = new System.Drawing.Size(147, 15);
            this.labelUnesi.TabIndex = 3;
            this.labelUnesi.Text = "Unesite vrijeme pregleda:";
            this.labelUnesi.Click += new System.EventHandler(this.labelUnesi_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(231, 99);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(10, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = ":";
            // 
            // textBoxMinutice
            // 
            this.textBoxMinutice.Location = new System.Drawing.Point(247, 96);
            this.textBoxMinutice.Name = "textBoxMinutice";
            this.textBoxMinutice.Size = new System.Drawing.Size(41, 20);
            this.textBoxMinutice.TabIndex = 5;
            this.textBoxMinutice.TextChanged += new System.EventHandler(this.textBoxMinutice_TextChanged);
            // 
            // textBoxSatt
            // 
            this.textBoxSatt.Location = new System.Drawing.Point(184, 96);
            this.textBoxSatt.Name = "textBoxSatt";
            this.textBoxSatt.Size = new System.Drawing.Size(41, 20);
            this.textBoxSatt.TabIndex = 6;
            this.textBoxSatt.TextChanged += new System.EventHandler(this.textBoxSatt_TextChanged);
            // 
            // button1ok
            // 
            this.button1ok.Location = new System.Drawing.Point(184, 279);
            this.button1ok.Name = "button1ok";
            this.button1ok.Size = new System.Drawing.Size(75, 23);
            this.button1ok.TabIndex = 8;
            this.button1ok.Text = "OK";
            this.button1ok.UseVisualStyleBackColor = true;
            this.button1ok.Click += new System.EventHandler(this.button1ok_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(184, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Unos_preg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 314);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1ok);
            this.Controls.Add(this.textBoxSatt);
            this.Controls.Add(this.textBoxMinutice);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.labelUnesi);
            this.Controls.Add(this.labeldatumce);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Unos_preg";
            this.Text = "Unos novog pregleda";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labeldatumce;
        private System.Windows.Forms.Label labelUnesi;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxMinutice;
        private System.Windows.Forms.TextBox textBoxSatt;
        private System.Windows.Forms.Button button1ok;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}