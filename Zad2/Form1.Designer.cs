namespace Zad2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Prawo = new System.Windows.Forms.Button();
            this.Lewo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcjieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ususnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(713, 396);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(75, 42);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(632, 396);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(75, 42);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            // 
            // Prawo
            // 
            this.Prawo.Location = new System.Drawing.Point(351, 396);
            this.Prawo.Name = "Prawo";
            this.Prawo.Size = new System.Drawing.Size(75, 42);
            this.Prawo.TabIndex = 2;
            this.Prawo.Text = "->";
            this.Prawo.UseVisualStyleBackColor = true;
            // 
            // Lewo
            // 
            this.Lewo.Location = new System.Drawing.Point(270, 396);
            this.Lewo.Name = "Lewo";
            this.Lewo.Size = new System.Drawing.Size(75, 42);
            this.Lewo.TabIndex = 3;
            this.Lewo.Text = "<-";
            this.Lewo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(270, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(517, 363);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcjieToolStripMenuItem
            // 
            this.opcjieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.ususnToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.opcjieToolStripMenuItem.Name = "opcjieToolStripMenuItem";
            this.opcjieToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.opcjieToolStripMenuItem.Text = "Opcjie";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // ususnToolStripMenuItem
            // 
            this.ususnToolStripMenuItem.Name = "ususnToolStripMenuItem";
            this.ususnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ususnToolStripMenuItem.Text = "Ususn";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(251, 410);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lewo);
            this.Controls.Add(this.Prawo);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Prawo;
        private System.Windows.Forms.Button Lewo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcjieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ususnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
    }
}

