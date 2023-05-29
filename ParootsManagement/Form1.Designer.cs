namespace ParootsManagement
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.birdsGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.keywordTextBox = new ReaLTaiizor.Controls.MetroTextBox();
            this.button6 = new ReaLTaiizor.Controls.MetroButton();
            this.metroButton1 = new ReaLTaiizor.Controls.MetroButton();
            this.metroButton2 = new ReaLTaiizor.Controls.MetroButton();
            this.metroButton3 = new ReaLTaiizor.Controls.MetroButton();
            this.metroButton4 = new ReaLTaiizor.Controls.MetroButton();
            this.airButton1 = new ReaLTaiizor.Controls.AirButton();
            this.criteriaComboBox = new ReaLTaiizor.Controls.MetroComboBox();
            this.editButton = new ReaLTaiizor.Controls.MetroButton();
            this.birdsInCageListBox = new ReaLTaiizor.Controls.MetroListBox();
            this.resultDataGrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.birdsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.searchPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 453);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 425);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.airButton1);
            this.groupBox1.Controls.Add(this.metroButton4);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.metroButton3);
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Location = new System.Drawing.Point(-1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchPanel.Controls.Add(this.resultDataGrid);
            this.searchPanel.Controls.Add(this.editButton);
            this.searchPanel.Controls.Add(this.criteriaComboBox);
            this.searchPanel.Controls.Add(this.button6);
            this.searchPanel.Controls.Add(this.keywordTextBox);
            this.searchPanel.Controls.Add(this.birdsGroupBox);
            this.searchPanel.Controls.Add(this.label4);
            this.searchPanel.Controls.Add(this.label3);
            this.searchPanel.Location = new System.Drawing.Point(201, 12);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1061, 426);
            this.searchPanel.TabIndex = 0;
            // 
            // birdsGroupBox
            // 
            this.birdsGroupBox.Controls.Add(this.birdsInCageListBox);
            this.birdsGroupBox.Location = new System.Drawing.Point(4, 63);
            this.birdsGroupBox.Name = "birdsGroupBox";
            this.birdsGroupBox.Size = new System.Drawing.Size(1043, 123);
            this.birdsGroupBox.TabIndex = 7;
            this.birdsGroupBox.TabStop = false;
            this.birdsGroupBox.Text = "Birds in cage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 4);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Keyword";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Criteria";
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.AutoCompleteCustomSource = null;
            this.keywordTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.keywordTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.keywordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.keywordTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.keywordTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.keywordTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.keywordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.keywordTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.keywordTextBox.Image = null;
            this.keywordTextBox.IsDerivedStyle = true;
            this.keywordTextBox.Lines = null;
            this.keywordTextBox.Location = new System.Drawing.Point(131, 20);
            this.keywordTextBox.MaxLength = 32767;
            this.keywordTextBox.Multiline = false;
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.ReadOnly = false;
            this.keywordTextBox.Size = new System.Drawing.Size(135, 30);
            this.keywordTextBox.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.keywordTextBox.StyleManager = null;
            this.keywordTextBox.TabIndex = 9;
            this.keywordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.keywordTextBox.ThemeAuthor = "Taiizor";
            this.keywordTextBox.ThemeName = "MetroLight";
            this.keywordTextBox.UseSystemPasswordChar = false;
            this.keywordTextBox.WatermarkText = "";
            // 
            // button6
            // 
            this.button6.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.button6.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.button6.DisabledForeColor = System.Drawing.Color.Gray;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button6.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.button6.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.button6.HoverTextColor = System.Drawing.Color.White;
            this.button6.IsDerivedStyle = true;
            this.button6.Location = new System.Drawing.Point(272, 20);
            this.button6.Name = "button6";
            this.button6.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.button6.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.button6.NormalTextColor = System.Drawing.Color.White;
            this.button6.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.button6.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.button6.PressTextColor = System.Drawing.Color.White;
            this.button6.Size = new System.Drawing.Size(108, 30);
            this.button6.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.button6.StyleManager = null;
            this.button6.TabIndex = 10;
            this.button6.Text = "Search";
            this.button6.ThemeAuthor = "Taiizor";
            this.button6.ThemeName = "MetroLight";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroButton1.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroButton1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroButton1.HoverTextColor = System.Drawing.Color.White;
            this.metroButton1.IsDerivedStyle = true;
            this.metroButton1.Location = new System.Drawing.Point(6, 22);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroButton1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroButton1.NormalTextColor = System.Drawing.Color.White;
            this.metroButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroButton1.PressTextColor = System.Drawing.Color.White;
            this.metroButton1.Size = new System.Drawing.Size(177, 42);
            this.metroButton1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Add Bird";
            this.metroButton1.ThemeAuthor = "Taiizor";
            this.metroButton1.ThemeName = "MetroLight";
            this.metroButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroButton2.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroButton2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroButton2.HoverTextColor = System.Drawing.Color.White;
            this.metroButton2.IsDerivedStyle = true;
            this.metroButton2.Location = new System.Drawing.Point(6, 70);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroButton2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroButton2.NormalTextColor = System.Drawing.Color.White;
            this.metroButton2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroButton2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroButton2.PressTextColor = System.Drawing.Color.White;
            this.metroButton2.Size = new System.Drawing.Size(177, 42);
            this.metroButton2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroButton2.StyleManager = null;
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Add Cage";
            this.metroButton2.ThemeAuthor = "Taiizor";
            this.metroButton2.ThemeName = "MetroLight";
            this.metroButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroButton3.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroButton3.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroButton3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroButton3.HoverTextColor = System.Drawing.Color.White;
            this.metroButton3.IsDerivedStyle = true;
            this.metroButton3.Location = new System.Drawing.Point(6, 118);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroButton3.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroButton3.NormalTextColor = System.Drawing.Color.White;
            this.metroButton3.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroButton3.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroButton3.PressTextColor = System.Drawing.Color.White;
            this.metroButton3.Size = new System.Drawing.Size(177, 42);
            this.metroButton3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroButton3.StyleManager = null;
            this.metroButton3.TabIndex = 4;
            this.metroButton3.Text = "Search Birds";
            this.metroButton3.ThemeAuthor = "Taiizor";
            this.metroButton3.ThemeName = "MetroLight";
            this.metroButton3.Click += new System.EventHandler(this.button3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroButton4.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroButton4.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroButton4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroButton4.HoverTextColor = System.Drawing.Color.White;
            this.metroButton4.IsDerivedStyle = true;
            this.metroButton4.Location = new System.Drawing.Point(6, 166);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroButton4.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroButton4.NormalTextColor = System.Drawing.Color.White;
            this.metroButton4.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroButton4.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroButton4.PressTextColor = System.Drawing.Color.White;
            this.metroButton4.Size = new System.Drawing.Size(177, 42);
            this.metroButton4.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroButton4.StyleManager = null;
            this.metroButton4.TabIndex = 5;
            this.metroButton4.Text = "Search Cage";
            this.metroButton4.ThemeAuthor = "Taiizor";
            this.metroButton4.ThemeName = "MetroLight";
            this.metroButton4.Click += new System.EventHandler(this.button4_Click);
            // 
            // airButton1
            // 
            this.airButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.airButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.airButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.airButton1.Image = null;
            this.airButton1.Location = new System.Drawing.Point(40, 366);
            this.airButton1.Name = "airButton1";
            this.airButton1.NoRounding = false;
            this.airButton1.Size = new System.Drawing.Size(106, 45);
            this.airButton1.TabIndex = 2;
            this.airButton1.Text = "EXIT";
            this.airButton1.Transparent = false;
            this.airButton1.Click += new System.EventHandler(this.button5_Click);
            // 
            // criteriaComboBox
            // 
            this.criteriaComboBox.AllowDrop = true;
            this.criteriaComboBox.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.criteriaComboBox.BackColor = System.Drawing.Color.Transparent;
            this.criteriaComboBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.criteriaComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.criteriaComboBox.CausesValidation = false;
            this.criteriaComboBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.criteriaComboBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.criteriaComboBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.criteriaComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.criteriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.criteriaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.criteriaComboBox.FormattingEnabled = true;
            this.criteriaComboBox.IsDerivedStyle = true;
            this.criteriaComboBox.ItemHeight = 20;
            this.criteriaComboBox.Location = new System.Drawing.Point(4, 23);
            this.criteriaComboBox.Name = "criteriaComboBox";
            this.criteriaComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.criteriaComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            this.criteriaComboBox.Size = new System.Drawing.Size(121, 26);
            this.criteriaComboBox.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.criteriaComboBox.StyleManager = null;
            this.criteriaComboBox.TabIndex = 11;
            this.criteriaComboBox.ThemeAuthor = "Taiizor";
            this.criteriaComboBox.ThemeName = "MetroLight";
            // 
            // editButton
            // 
            this.editButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.editButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.editButton.HoverTextColor = System.Drawing.Color.White;
            this.editButton.IsDerivedStyle = true;
            this.editButton.Location = new System.Drawing.Point(386, 18);
            this.editButton.Name = "editButton";
            this.editButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editButton.NormalTextColor = System.Drawing.Color.White;
            this.editButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.editButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.editButton.PressTextColor = System.Drawing.Color.White;
            this.editButton.Size = new System.Drawing.Size(108, 30);
            this.editButton.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.editButton.StyleManager = null;
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Show Details";
            this.editButton.ThemeAuthor = "Taiizor";
            this.editButton.ThemeName = "MetroLight";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // birdsInCageListBox
            // 
            this.birdsInCageListBox.BackColor = System.Drawing.Color.White;
            this.birdsInCageListBox.BorderColor = System.Drawing.Color.LightGray;
            this.birdsInCageListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.birdsInCageListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.birdsInCageListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.birdsInCageListBox.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.birdsInCageListBox.HoveredItemColor = System.Drawing.Color.DimGray;
            this.birdsInCageListBox.IsDerivedStyle = true;
            this.birdsInCageListBox.ItemHeight = 30;
            this.birdsInCageListBox.Location = new System.Drawing.Point(6, 19);
            this.birdsInCageListBox.MultiSelect = false;
            this.birdsInCageListBox.Name = "birdsInCageListBox";
            this.birdsInCageListBox.SelectedIndex = -1;
            this.birdsInCageListBox.SelectedItem = null;
            this.birdsInCageListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.birdsInCageListBox.SelectedItemColor = System.Drawing.Color.White;
            this.birdsInCageListBox.SelectedText = null;
            this.birdsInCageListBox.SelectedValue = null;
            this.birdsInCageListBox.ShowBorder = true;
            this.birdsInCageListBox.ShowScrollBar = true;
            this.birdsInCageListBox.Size = new System.Drawing.Size(1031, 98);
            this.birdsInCageListBox.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.birdsInCageListBox.StyleManager = null;
            this.birdsInCageListBox.TabIndex = 13;
            this.birdsInCageListBox.ThemeAuthor = "Taiizor";
            this.birdsInCageListBox.ThemeName = "MetroLight";
            // 
            // resultDataGrid
            // 
            this.resultDataGrid.AllowUserToAddRows = false;
            this.resultDataGrid.AllowUserToDeleteRows = false;
            this.resultDataGrid.AllowUserToResizeRows = false;
            this.resultDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resultDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.resultDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.resultDataGrid.EnableHeadersVisualStyles = false;
            this.resultDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.resultDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resultDataGrid.Location = new System.Drawing.Point(10, 193);
            this.resultDataGrid.Name = "resultDataGrid";
            this.resultDataGrid.ReadOnly = true;
            this.resultDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.resultDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.resultDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultDataGrid.Size = new System.Drawing.Size(1031, 226);
            this.resultDataGrid.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 453);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.birdsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox birdsGroupBox;
        private ReaLTaiizor.Controls.MetroButton button6;
        private ReaLTaiizor.Controls.MetroTextBox keywordTextBox;
        private ReaLTaiizor.Controls.AirButton airButton1;
        private ReaLTaiizor.Controls.MetroButton metroButton4;
        private ReaLTaiizor.Controls.MetroButton metroButton1;
        private ReaLTaiizor.Controls.MetroButton metroButton3;
        private ReaLTaiizor.Controls.MetroButton metroButton2;
        private ReaLTaiizor.Controls.MetroButton editButton;
        private ReaLTaiizor.Controls.MetroComboBox criteriaComboBox;
        private ReaLTaiizor.Controls.MetroListBox birdsInCageListBox;
        private ReaLTaiizor.Controls.PoisonDataGridView resultDataGrid;
    }
}

