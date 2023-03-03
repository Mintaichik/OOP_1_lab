namespace OOP_1_laba
{
    partial class FormOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOne));
            this.groupBoxSmile = new System.Windows.Forms.GroupBox();
            this.lbPrintSpace = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.rbSad = new System.Windows.Forms.RadioButton();
            this.rbHappy = new System.Windows.Forms.RadioButton();
            this.pbSmile = new System.Windows.Forms.PictureBox();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.lbProgress = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbDate = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lbReturnDate = new System.Windows.Forms.Label();
            this.lbPrintNumbers = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.ListBox();
            this.rtbNumber = new System.Windows.Forms.RichTextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lbPaint = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.clbAdd = new System.Windows.Forms.CheckedListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.llbAdd = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddCopy = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxSmile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmile)).BeginInit();
            this.panelProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gbDate.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSmile
            // 
            this.groupBoxSmile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxSmile.BackgroundImage")));
            this.groupBoxSmile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxSmile.Controls.Add(this.lbPrintSpace);
            this.groupBoxSmile.Controls.Add(this.cbColor);
            this.groupBoxSmile.Controls.Add(this.rbSad);
            this.groupBoxSmile.Controls.Add(this.rbHappy);
            this.groupBoxSmile.Controls.Add(this.pbSmile);
            this.groupBoxSmile.Location = new System.Drawing.Point(15, 3);
            this.groupBoxSmile.Name = "groupBoxSmile";
            this.groupBoxSmile.Size = new System.Drawing.Size(157, 350);
            this.groupBoxSmile.TabIndex = 0;
            this.groupBoxSmile.TabStop = false;
            this.groupBoxSmile.Text = "Смайл";
            // 
            // lbPrintSpace
            // 
            this.lbPrintSpace.AllowDrop = true;
            this.lbPrintSpace.AutoEllipsis = true;
            this.lbPrintSpace.AutoSize = true;
            this.lbPrintSpace.BackColor = System.Drawing.Color.Transparent;
            this.lbPrintSpace.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbPrintSpace.Location = new System.Drawing.Point(25, 276);
            this.lbPrintSpace.MaximumSize = new System.Drawing.Size(120, 0);
            this.lbPrintSpace.Name = "lbPrintSpace";
            this.lbPrintSpace.Size = new System.Drawing.Size(119, 34);
            this.lbPrintSpace.TabIndex = 5;
            this.lbPrintSpace.Text = "Нажми пробел в поле ввода";
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Green",
            "Blue",
            "Red"});
            this.cbColor.Location = new System.Drawing.Point(19, 240);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(121, 24);
            this.cbColor.TabIndex = 3;
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbColor.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            this.cbColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // rbSad
            // 
            this.rbSad.AutoSize = true;
            this.rbSad.BackColor = System.Drawing.Color.Transparent;
            this.rbSad.Location = new System.Drawing.Point(20, 204);
            this.rbSad.Name = "rbSad";
            this.rbSad.Size = new System.Drawing.Size(92, 21);
            this.rbSad.TabIndex = 2;
            this.rbSad.Text = "Грустный";
            this.rbSad.UseVisualStyleBackColor = false;
            this.rbSad.CheckedChanged += new System.EventHandler(this.rbSad_CheckedChanged);
            // 
            // rbHappy
            // 
            this.rbHappy.AutoSize = true;
            this.rbHappy.BackColor = System.Drawing.Color.Transparent;
            this.rbHappy.Checked = true;
            this.rbHappy.Location = new System.Drawing.Point(20, 167);
            this.rbHappy.Name = "rbHappy";
            this.rbHappy.Size = new System.Drawing.Size(109, 21);
            this.rbHappy.TabIndex = 1;
            this.rbHappy.TabStop = true;
            this.rbHappy.Text = "Счастливый";
            this.rbHappy.UseVisualStyleBackColor = false;
            this.rbHappy.CheckedChanged += new System.EventHandler(this.rbHappy_CheckedChanged);
            // 
            // pbSmile
            // 
            this.pbSmile.BackColor = System.Drawing.Color.Transparent;
            this.pbSmile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSmile.Image = ((System.Drawing.Image)(resources.GetObject("pbSmile.Image")));
            this.pbSmile.Location = new System.Drawing.Point(20, 25);
            this.pbSmile.Name = "pbSmile";
            this.pbSmile.Size = new System.Drawing.Size(120, 121);
            this.pbSmile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSmile.TabIndex = 0;
            this.pbSmile.TabStop = false;
            this.pbSmile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbSmile_MouseMove);
            // 
            // panelProgress
            // 
            this.panelProgress.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelProgress.BackgroundImage")));
            this.panelProgress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelProgress.Controls.Add(this.lbProgress);
            this.panelProgress.Controls.Add(this.numericUpDown1);
            this.panelProgress.Controls.Add(this.progressBar1);
            this.panelProgress.Location = new System.Drawing.Point(30, 49);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(144, 150);
            this.panelProgress.TabIndex = 1;
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.BackColor = System.Drawing.Color.Transparent;
            this.lbProgress.Location = new System.Drawing.Point(38, 21);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(69, 17);
            this.lbProgress.TabIndex = 2;
            this.lbProgress.Text = "Прогресс";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(15, 95);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 46);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(120, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(16, 55);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // gbDate
            // 
            this.gbDate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbDate.BackgroundImage")));
            this.gbDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbDate.Controls.Add(this.btnReturn);
            this.gbDate.Controls.Add(this.lbReturnDate);
            this.gbDate.Controls.Add(this.dateTimePicker1);
            this.gbDate.Controls.Add(this.monthCalendar1);
            this.gbDate.Location = new System.Drawing.Point(258, 62);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(230, 349);
            this.gbDate.TabIndex = 4;
            this.gbDate.TabStop = false;
            this.gbDate.Text = "Дата";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(45, 291);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(137, 34);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Вернуть";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbReturnDate
            // 
            this.lbReturnDate.AutoSize = true;
            this.lbReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.lbReturnDate.Location = new System.Drawing.Point(13, 271);
            this.lbReturnDate.Name = "lbReturnDate";
            this.lbReturnDate.Size = new System.Drawing.Size(199, 17);
            this.lbReturnDate.TabIndex = 4;
            this.lbReturnDate.Text = "Вернуть сегодняшнюю дату?";
            // 
            // lbPrintNumbers
            // 
            this.lbPrintNumbers.AutoSize = true;
            this.lbPrintNumbers.BackColor = System.Drawing.Color.Transparent;
            this.lbPrintNumbers.Location = new System.Drawing.Point(6, 9);
            this.lbPrintNumbers.Name = "lbPrintNumbers";
            this.lbPrintNumbers.Size = new System.Drawing.Size(95, 17);
            this.lbPrintNumbers.TabIndex = 2;
            this.lbPrintNumbers.Text = "Печать цифр";
            // 
            // lbNumber
            // 
            this.lbNumber.FormattingEnabled = true;
            this.lbNumber.ItemHeight = 16;
            this.lbNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.lbNumber.Location = new System.Drawing.Point(24, 39);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(90, 84);
            this.lbNumber.TabIndex = 1;
            this.lbNumber.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // rtbNumber
            // 
            this.rtbNumber.Location = new System.Drawing.Point(9, 39);
            this.rtbNumber.Name = "rtbNumber";
            this.rtbNumber.Size = new System.Drawing.Size(100, 96);
            this.rtbNumber.TabIndex = 0;
            this.rtbNumber.Text = "Наведи сюда курсор";
            this.rtbNumber.MouseHover += new System.EventHandler(this.richTextBox1_MouseHover);
            // 
            // btnGo
            // 
            this.btnGo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnGo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGo.Location = new System.Drawing.Point(597, 373);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(250, 50);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "Перейти дальше!";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbPaint
            // 
            this.lbPaint.AutoSize = true;
            this.lbPaint.Location = new System.Drawing.Point(25, 0);
            this.lbPaint.Name = "lbPaint";
            this.lbPaint.Size = new System.Drawing.Size(16, 17);
            this.lbPaint.TabIndex = 7;
            this.lbPaint.Text = "0";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(3, 0);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(16, 17);
            this.sizeLabel.TabIndex = 8;
            this.sizeLabel.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(36, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(203, 382);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxSmile);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(195, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Смайл";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelProgress);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(195, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Прогресс";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Location = new System.Drawing.Point(523, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbPrintNumbers);
            this.splitContainer1.Panel1.Controls.Add(this.rtbNumber);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbNumber);
            this.splitContainer1.Size = new System.Drawing.Size(254, 196);
            this.splitContainer1.SplitterDistance = 122;
            this.splitContainer1.TabIndex = 10;
            // 
            // clbAdd
            // 
            this.clbAdd.CheckOnClick = true;
            this.clbAdd.FormattingEnabled = true;
            this.clbAdd.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.clbAdd.Location = new System.Drawing.Point(22, 14);
            this.clbAdd.Name = "clbAdd";
            this.clbAdd.Size = new System.Drawing.Size(95, 89);
            this.clbAdd.TabIndex = 2;
            this.clbAdd.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.sizeLabel);
            this.flowLayoutPanel1.Controls.Add(this.lbPaint);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(601, 232);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(138, 118);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(25, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 35);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(17, 152);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(100, 22);
            this.tbAdd.TabIndex = 13;
            // 
            // llbAdd
            // 
            this.llbAdd.AutoSize = true;
            this.llbAdd.Location = new System.Drawing.Point(22, 115);
            this.llbAdd.Name = "llbAdd";
            this.llbAdd.Size = new System.Drawing.Size(55, 17);
            this.llbAdd.TabIndex = 14;
            this.llbAdd.TabStop = true;
            this.llbAdd.Text = "ссылка";
            this.llbAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbAdd_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.llbAdd);
            this.panel2.Controls.Add(this.tbAdd);
            this.panel2.Controls.Add(this.clbAdd);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(801, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 236);
            this.panel2.TabIndex = 15;
            // 
            // btnAddCopy
            // 
            this.btnAddCopy.Location = new System.Drawing.Point(792, 304);
            this.btnAddCopy.Name = "btnAddCopy";
            this.btnAddCopy.Size = new System.Drawing.Size(151, 29);
            this.btnAddCopy.TabIndex = 16;
            this.btnAddCopy.Text = "Добавить 2.0";
            this.btnAddCopy.UseVisualStyleBackColor = true;
            this.btnAddCopy.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(10, 60);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(254, 269);
            this.webBrowser1.TabIndex = 17;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(10, 32);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(179, 22);
            this.tbSearch.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(195, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 24);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Location = new System.Drawing.Point(983, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 341);
            this.panel1.TabIndex = 20;
            // 
            // FormOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1297, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddCopy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.gbDate);
            this.Name = "FormOne";
            this.Text = "Форма 1";
            this.SizeChanged += new System.EventHandler(this.FormOne_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormOne_Paint);
            this.groupBoxSmile.ResumeLayout(false);
            this.groupBoxSmile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmile)).EndInit();
            this.panelProgress.ResumeLayout(false);
            this.panelProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gbDate.ResumeLayout(false);
            this.gbDate.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSmile;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.RadioButton rbSad;
        private System.Windows.Forms.RadioButton rbHappy;
        private System.Windows.Forms.PictureBox pbSmile;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbDate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lbReturnDate;
        private System.Windows.Forms.RichTextBox rtbNumber;
        private System.Windows.Forms.Label lbPrintNumbers;
        private System.Windows.Forms.ListBox lbNumber;
        private System.Windows.Forms.Label lbPrintSpace;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lbPaint;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckedListBox clbAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.LinkLabel llbAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddCopy;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
    }
}