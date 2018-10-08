namespace DaisyKlinika
{
    partial class Form3
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonokicici = new System.Windows.Forms.Button();
            this.textBoxJJ = new System.Windows.Forms.TextBox();
            this.jmbgpac = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 145);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(303, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // buttonokicici
            // 
            this.buttonokicici.Location = new System.Drawing.Point(110, 113);
            this.buttonokicici.Name = "buttonokicici";
            this.buttonokicici.Size = new System.Drawing.Size(75, 23);
            this.buttonokicici.TabIndex = 6;
            this.buttonokicici.Text = "OK";
            this.buttonokicici.UseVisualStyleBackColor = true;
            this.buttonokicici.Click += new System.EventHandler(this.buttonokicici_Click);
            // 
            // textBoxJJ
            // 
            this.textBoxJJ.Location = new System.Drawing.Point(68, 64);
            this.textBoxJJ.Name = "textBoxJJ";
            this.textBoxJJ.Size = new System.Drawing.Size(152, 20);
            this.textBoxJJ.TabIndex = 5;
            this.textBoxJJ.TextChanged += new System.EventHandler(this.textBoxJJ_TextChanged);
            this.textBoxJJ.Validating += new System.ComponentModel.CancelEventHandler(this.Jmbg_Validating);
            // 
            // jmbgpac
            // 
            this.jmbgpac.AutoSize = true;
            this.jmbgpac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jmbgpac.Location = new System.Drawing.Point(65, 29);
            this.jmbgpac.Name = "jmbgpac";
            this.jmbgpac.Size = new System.Drawing.Size(146, 16);
            this.jmbgpac.TabIndex = 4;
            this.jmbgpac.Text = "Unesite JMBG doktora:";
            this.jmbgpac.Click += new System.EventHandler(this.jmbgpac_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 167);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonokicici);
            this.Controls.Add(this.textBoxJJ);
            this.Controls.Add(this.jmbgpac);
            this.Name = "Form3";
            this.Text = "Obrisi doktora";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonokicici;
        private System.Windows.Forms.TextBox textBoxJJ;
        private System.Windows.Forms.Label jmbgpac;
    }
}