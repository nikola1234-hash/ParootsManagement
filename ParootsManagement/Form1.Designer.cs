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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.birdsGroupBox = new System.Windows.Forms.GroupBox();
            this.birdsInCageListBox = new System.Windows.Forms.ListBox();
            this.editButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.keywordTextbox = new System.Windows.Forms.TextBox();
            this.criteriaComboBox = new System.Windows.Forms.ComboBox();
            this.resultDataGrid = new System.Windows.Forms.DataGridView();
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
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 425);
            this.panel2.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(10, 391);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Search Cage";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Search Birds";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Cage";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Bird";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.birdsGroupBox);
            this.searchPanel.Controls.Add(this.editButton);
            this.searchPanel.Controls.Add(this.label4);
            this.searchPanel.Controls.Add(this.label3);
            this.searchPanel.Controls.Add(this.button6);
            this.searchPanel.Controls.Add(this.keywordTextbox);
            this.searchPanel.Controls.Add(this.criteriaComboBox);
            this.searchPanel.Controls.Add(this.resultDataGrid);
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
            // birdsInCageListBox
            // 
            this.birdsInCageListBox.FormattingEnabled = true;
            this.birdsInCageListBox.Location = new System.Drawing.Point(7, 20);
            this.birdsInCageListBox.Name = "birdsInCageListBox";
            this.birdsInCageListBox.ScrollAlwaysVisible = true;
            this.birdsInCageListBox.Size = new System.Drawing.Size(1030, 95);
            this.birdsInCageListBox.TabIndex = 0;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(406, 25);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(116, 23);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Show Bird Details";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
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
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(238, 23);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // keywordTextbox
            // 
            this.keywordTextbox.Location = new System.Drawing.Point(131, 25);
            this.keywordTextbox.Name = "keywordTextbox";
            this.keywordTextbox.Size = new System.Drawing.Size(100, 20);
            this.keywordTextbox.TabIndex = 2;
            // 
            // criteriaComboBox
            // 
            this.criteriaComboBox.FormattingEnabled = true;
            this.criteriaComboBox.Location = new System.Drawing.Point(4, 24);
            this.criteriaComboBox.Name = "criteriaComboBox";
            this.criteriaComboBox.Size = new System.Drawing.Size(121, 21);
            this.criteriaComboBox.TabIndex = 1;
            // 
            // resultDataGrid
            // 
            this.resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGrid.Location = new System.Drawing.Point(3, 208);
            this.resultDataGrid.Name = "resultDataGrid";
            this.resultDataGrid.Size = new System.Drawing.Size(1044, 215);
            this.resultDataGrid.TabIndex = 0;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox keywordTextbox;
        private System.Windows.Forms.ComboBox criteriaComboBox;
        private System.Windows.Forms.DataGridView resultDataGrid;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.GroupBox birdsGroupBox;
        private System.Windows.Forms.ListBox birdsInCageListBox;
    }
}

