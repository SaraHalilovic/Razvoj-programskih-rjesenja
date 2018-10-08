namespace DaisyKlinika
{
    partial class Doktor_forma
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Zakaži novi pregled");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Izvrši/Obriši pregled");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Pregled", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Unesi u Karton");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Karton", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Zakazani pregledi po ordinacijama");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Ordinacije", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.labelopc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView2
            // 
            this.treeView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.treeView2.Location = new System.Drawing.Point(12, 71);
            this.treeView2.Name = "treeView2";
            treeNode1.Name = "Zakazi_pregled";
            treeNode1.Text = "Zakaži novi pregled";
            treeNode2.Name = "Pregledaj";
            treeNode2.Text = "Izvrši/Obriši pregled";
            treeNode3.Name = "Pregled";
            treeNode3.Text = "Pregled";
            treeNode4.Name = "UnesiKarton";
            treeNode4.Text = "Unesi u Karton";
            treeNode5.Name = "Karton";
            treeNode5.Text = "Karton";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Zakazani pregledi po ordinacijama";
            treeNode7.Name = "Ordinacije";
            treeNode7.Text = "Ordinacije";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5,
            treeNode7});
            this.treeView2.Size = new System.Drawing.Size(292, 147);
            this.treeView2.TabIndex = 1;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // labelopc
            // 
            this.labelopc.AutoSize = true;
            this.labelopc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelopc.Location = new System.Drawing.Point(12, 43);
            this.labelopc.Name = "labelopc";
            this.labelopc.Size = new System.Drawing.Size(50, 16);
            this.labelopc.TabIndex = 2;
            this.labelopc.Text = "Opcije:";
            // 
            // Doktor_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 296);
            this.Controls.Add(this.labelopc);
            this.Controls.Add(this.treeView2);
            this.Name = "Doktor_forma";
            this.Text = "Doktor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Label labelopc;
    }
}