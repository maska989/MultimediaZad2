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
            this.Góra = new System.Windows.Forms.Button();
            this.Dół = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Wczytaj = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.RotPraw = new System.Windows.Forms.Button();
            this.RotLew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(700, 436);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(75, 42);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(619, 436);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(75, 42);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Prawo
            // 
            this.Prawo.Location = new System.Drawing.Point(362, 437);
            this.Prawo.Name = "Prawo";
            this.Prawo.Size = new System.Drawing.Size(40, 40);
            this.Prawo.TabIndex = 2;
            this.Prawo.Text = "→";
            this.Prawo.UseVisualStyleBackColor = true;
            // 
            // Lewo
            // 
            this.Lewo.Location = new System.Drawing.Point(270, 437);
            this.Lewo.Name = "Lewo";
            this.Lewo.Size = new System.Drawing.Size(40, 40);
            this.Lewo.TabIndex = 3;
            this.Lewo.Text = "←";
            this.Lewo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(270, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 358);
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
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // ususnToolStripMenuItem
            // 
            this.ususnToolStripMenuItem.Name = "ususnToolStripMenuItem";
            this.ususnToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.ususnToolStripMenuItem.Text = "Ususn";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(251, 493);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Góra
            // 
            this.Góra.Location = new System.Drawing.Point(316, 391);
            this.Góra.Name = "Góra";
            this.Góra.Size = new System.Drawing.Size(40, 40);
            this.Góra.TabIndex = 7;
            this.Góra.Text = "↑";
            this.Góra.UseVisualStyleBackColor = true;
            // 
            // Dół
            // 
            this.Dół.Location = new System.Drawing.Point(316, 481);
            this.Dół.Name = "Dół";
            this.Dół.Size = new System.Drawing.Size(40, 40);
            this.Dół.TabIndex = 8;
            this.Dół.Text = "↓";
            this.Dół.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(316, 437);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(40, 40);
            this.Reset.TabIndex = 9;
            this.Reset.Text = "∰";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Wczytaj
            // 
            this.Wczytaj.Location = new System.Drawing.Point(474, 400);
            this.Wczytaj.Name = "Wczytaj";
            this.Wczytaj.Size = new System.Drawing.Size(75, 23);
            this.Wczytaj.TabIndex = 10;
            this.Wczytaj.Text = "Load";
            this.Wczytaj.UseVisualStyleBackColor = true;
            this.Wczytaj.Click += new System.EventHandler(this.Wczytaj_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(474, 429);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // RotPraw
            // 
            this.RotPraw.Location = new System.Drawing.Point(362, 391);
            this.RotPraw.Name = "RotPraw";
            this.RotPraw.Size = new System.Drawing.Size(40, 40);
            this.RotPraw.TabIndex = 14;
            this.RotPraw.Text = "↷";
            this.RotPraw.UseVisualStyleBackColor = true;
            // 
            // RotLew
            // 
            this.RotLew.Location = new System.Drawing.Point(270, 391);
            this.RotLew.Name = "RotLew";
            this.RotLew.Size = new System.Drawing.Size(40, 40);
            this.RotLew.TabIndex = 15;
            this.RotLew.Text = "↶";
            this.RotLew.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.RotLew);
            this.Controls.Add(this.RotPraw);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Wczytaj);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Dół);
            this.Controls.Add(this.Góra);
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
        private System.Windows.Forms.Button Góra;
        private System.Windows.Forms.Button Dół;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Wczytaj;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button RotPraw;
        private System.Windows.Forms.Button RotLew;
    }
}

