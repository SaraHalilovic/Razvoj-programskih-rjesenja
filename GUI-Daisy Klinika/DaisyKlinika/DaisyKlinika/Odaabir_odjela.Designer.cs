namespace DaisyKlinika
{
    partial class Odaabir_odjela
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
            this.buttonokicici = new System.Windows.Forms.Button();
            this.jmbgpac = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox11 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonokicici
            // 
            this.buttonokicici.Location = new System.Drawing.Point(223, 338);
            this.buttonokicici.Name = "buttonokicici";
            this.buttonokicici.Size = new System.Drawing.Size(158, 23);
            this.buttonokicici.TabIndex = 5;
            this.buttonokicici.Text = "OK";
            this.buttonokicici.UseVisualStyleBackColor = true;
            this.buttonokicici.Click += new System.EventHandler(this.buttonokicici_Click);
            // 
            // jmbgpac
            // 
            this.jmbgpac.AutoSize = true;
            this.jmbgpac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jmbgpac.Location = new System.Drawing.Point(12, 37);
            this.jmbgpac.Name = "jmbgpac";
            this.jmbgpac.Size = new System.Drawing.Size(132, 16);
            this.jmbgpac.TabIndex = 3;
            this.jmbgpac.Text = "Odaberite ordinaciju:";
            this.jmbgpac.Click += new System.EventHandler(this.jmbgpac_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 364);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(676, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Dermatologija",
            "Hirurgija",
            "Kardiologija",
            "Laboratorijska medicina",
            "Oftamologija",
            "Opsta medicina",
            "Otorinolaringologija",
            "Stomatologija"});
            this.listBox1.Location = new System.Drawing.Point(12, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(218, 199);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // richTextBox11
            // 
            this.richTextBox11.Location = new System.Drawing.Point(325, 71);
            this.richTextBox11.Name = "richTextBox11";
            this.richTextBox11.Size = new System.Drawing.Size(280, 216);
            this.richTextBox11.TabIndex = 10;
            this.richTextBox11.Text = "";
            this.richTextBox11.TextChanged += new System.EventHandler(this.richTextBox11_TextChanged);
            // 
            // Odaabir_odjela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 386);
            this.Controls.Add(this.richTextBox11);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonokicici);
            this.Controls.Add(this.jmbgpac);
            this.Name = "Odaabir_odjela";
            this.Text = "Odjel";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonokicici;
        private System.Windows.Forms.Label jmbgpac;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox11;
    }
}