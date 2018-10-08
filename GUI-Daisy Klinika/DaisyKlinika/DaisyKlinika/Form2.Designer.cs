namespace DaisyKlinika
{
    partial class Form2
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
            this.textBoxJJ = new System.Windows.Forms.TextBox();
            this.jmbgpac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonokicici
            // 
            this.buttonokicici.Location = new System.Drawing.Point(110, 162);
            this.buttonokicici.Name = "buttonokicici";
            this.buttonokicici.Size = new System.Drawing.Size(75, 23);
            this.buttonokicici.TabIndex = 5;
            this.buttonokicici.Text = "OK";
            this.buttonokicici.UseVisualStyleBackColor = true;
            this.buttonokicici.Click += new System.EventHandler(this.buttonokicici_Click);
            // 
            // textBoxJJ
            // 
            this.textBoxJJ.Location = new System.Drawing.Point(68, 113);
            this.textBoxJJ.Name = "textBoxJJ";
            this.textBoxJJ.Size = new System.Drawing.Size(152, 20);
            this.textBoxJJ.TabIndex = 4;
            this.textBoxJJ.TextChanged += new System.EventHandler(this.textBoxJJ_TextChanged);
            // 
            // jmbgpac
            // 
            this.jmbgpac.AutoSize = true;
            this.jmbgpac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jmbgpac.Location = new System.Drawing.Point(65, 78);
            this.jmbgpac.Name = "jmbgpac";
            this.jmbgpac.Size = new System.Drawing.Size(155, 16);
            this.jmbgpac.TabIndex = 3;
            this.jmbgpac.Text = "Unesite JMBG pacijenta:";
            this.jmbgpac.Click += new System.EventHandler(this.jmbgpac_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonokicici);
            this.Controls.Add(this.textBoxJJ);
            this.Controls.Add(this.jmbgpac);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonokicici;
        private System.Windows.Forms.TextBox textBoxJJ;
        private System.Windows.Forms.Label jmbgpac;
    }
}