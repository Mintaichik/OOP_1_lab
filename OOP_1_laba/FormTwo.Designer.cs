namespace OOP_1_laba
{
    partial class FormTwo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTwo));
            this.lbDescription = new System.Windows.Forms.Label();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDescription.Location = new System.Drawing.Point(48, 14);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(490, 17);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Правая кнопка мыши - создаёт снежинку. Клик по снежинке удаляет её.";
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.BackColor = System.Drawing.Color.Transparent;
            this.cbDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbDate.Location = new System.Drawing.Point(23, 417);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(136, 21);
            this.cbDate.TabIndex = 1;
            this.cbDate.Text = "Показать время";
            this.cbDate.UseVisualStyleBackColor = false;
            this.cbDate.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDate.Location = new System.Drawing.Point(635, 417);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(16, 17);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "0";
            this.lbDate.Visible = false;
            // 
            // FormTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.lbDescription);
            this.Name = "FormTwo";
            this.Text = "Зима!";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTwo_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbDate;
    }
}