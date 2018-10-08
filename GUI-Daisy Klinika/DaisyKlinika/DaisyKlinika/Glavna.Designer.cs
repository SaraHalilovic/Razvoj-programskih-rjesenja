namespace DaisyKlinika
{
    partial class Glavna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacijentaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.doktoraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxjmbg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrujToolStripMenuItem,
            this.obrišiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(402, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrujToolStripMenuItem
            // 
            this.registrujToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacijentaToolStripMenuItem,
            this.doktoraToolStripMenuItem});
            this.registrujToolStripMenuItem.Name = "registrujToolStripMenuItem";
            this.registrujToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.registrujToolStripMenuItem.Text = "Registruj";
            this.registrujToolStripMenuItem.Click += new System.EventHandler(this.registrujToolStripMenuItem_Click);
            // 
            // pacijentaToolStripMenuItem
            // 
            this.pacijentaToolStripMenuItem.Name = "pacijentaToolStripMenuItem";
            this.pacijentaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pacijentaToolStripMenuItem.Text = "Pacijenta";
            this.pacijentaToolStripMenuItem.Click += new System.EventHandler(this.pacijentaToolStripMenuItem_Click);
            // 
            // doktoraToolStripMenuItem
            // 
            this.doktoraToolStripMenuItem.Name = "doktoraToolStripMenuItem";
            this.doktoraToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.doktoraToolStripMenuItem.Text = "Doktora";
            // 
            // obrišiToolStripMenuItem
            // 
            this.obrišiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacijentaToolStripMenuItem1,
            this.doktoraToolStripMenuItem1,
            this.uposlenikaToolStripMenuItem});
            this.obrišiToolStripMenuItem.Name = "obrišiToolStripMenuItem";
            this.obrišiToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.obrišiToolStripMenuItem.Text = "Obriši";
            // 
            // pacijentaToolStripMenuItem1
            // 
            this.pacijentaToolStripMenuItem1.Name = "pacijentaToolStripMenuItem1";
            this.pacijentaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pacijentaToolStripMenuItem1.Text = "Pacijenta";
            this.pacijentaToolStripMenuItem1.Click += new System.EventHandler(this.pacijentaToolStripMenuItem1_Click);
            // 
            // doktoraToolStripMenuItem1
            // 
            this.doktoraToolStripMenuItem1.Name = "doktoraToolStripMenuItem1";
            this.doktoraToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.doktoraToolStripMenuItem1.Text = "Doktora";
            this.doktoraToolStripMenuItem1.Click += new System.EventHandler(this.doktoraToolStripMenuItem1_Click);
            // 
            // uposlenikaToolStripMenuItem
            // 
            this.uposlenikaToolStripMenuItem.Name = "uposlenikaToolStripMenuItem";
            this.uposlenikaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uposlenikaToolStripMenuItem.Text = "Uposlenika";
            this.uposlenikaToolStripMenuItem.Click += new System.EventHandler(this.uposlenikaToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxjmbg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraži karton";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Traži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxjmbg
            // 
            this.textBoxjmbg.Location = new System.Drawing.Point(36, 61);
            this.textBoxjmbg.Name = "textBoxjmbg";
            this.textBoxjmbg.Size = new System.Drawing.Size(129, 20);
            this.textBoxjmbg.TabIndex = 1;
            this.textBoxjmbg.TextChanged += new System.EventHandler(this.textBoxjmbg_TextChanged);
            this.textBoxjmbg.Validating += new System.ComponentModel.CancelEventHandler(this.JMBG_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesi JMBG pacijenta:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 147);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(402, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 169);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrišiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacijentaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem doktoraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uposlenikaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxjmbg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}