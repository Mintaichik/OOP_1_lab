namespace OOP_1_laba
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiForms = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFormOne = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFormTwo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSpring = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiForms,
            this.tsmiSpring});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(307, 28);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Список форм";
            // 
            // tsmiForms
            // 
            this.tsmiForms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFormOne,
            this.tsmFormTwo});
            this.tsmiForms.Name = "tsmiForms";
            this.tsmiForms.Size = new System.Drawing.Size(114, 24);
            this.tsmiForms.Text = "Список форм";
            this.tsmiForms.Click += new System.EventHandler(this.tsmiForms_Click);
            // 
            // tsmFormOne
            // 
            this.tsmFormOne.Name = "tsmFormOne";
            this.tsmFormOne.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmFormOne.Size = new System.Drawing.Size(216, 26);
            this.tsmFormOne.Text = "Форма 1";
            this.tsmFormOne.Click += new System.EventHandler(this.tsmFormOne_Click);
            // 
            // tsmFormTwo
            // 
            this.tsmFormTwo.Name = "tsmFormTwo";
            this.tsmFormTwo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmFormTwo.Size = new System.Drawing.Size(216, 26);
            this.tsmFormTwo.Text = "Форма 2";
            this.tsmFormTwo.Click += new System.EventHandler(this.tsmFormTwo_Click);
            // 
            // tsmiSpring
            // 
            this.tsmiSpring.Name = "tsmiSpring";
            this.tsmiSpring.Size = new System.Drawing.Size(66, 24);
            this.tsmiSpring.Text = "Весна!";
            this.tsmiSpring.Click += new System.EventHandler(this.tsmiAboutProgram_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(307, 32);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(325, 79);
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiForms;
        private System.Windows.Forms.ToolStripMenuItem tsmFormOne;
        private System.Windows.Forms.ToolStripMenuItem tsmFormTwo;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpring;
    }
}

