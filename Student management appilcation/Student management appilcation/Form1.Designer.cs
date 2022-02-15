namespace Student_management_appilcation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxID_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxName_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGpa_input = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGPAX = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuFile
            // 
            this.toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuOpen,
            this.toolStripMenuSave});
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuFile.Text = "File";
            // 
            // toolStripMenuOpen
            // 
            this.toolStripMenuOpen.Name = "toolStripMenuOpen";
            this.toolStripMenuOpen.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuOpen.Text = "Open";
            this.toolStripMenuOpen.Click += new System.EventHandler(this.toolStripMenuOpen_Click);
            // 
            // toolStripMenuSave
            // 
            this.toolStripMenuSave.Name = "toolStripMenuSave";
            this.toolStripMenuSave.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuSave.Text = "Save";
            this.toolStripMenuSave.Click += new System.EventHandler(this.toolStripMenuSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnName,
            this.ColumnMajor});
            this.dataGridView1.Location = new System.Drawing.Point(363, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(425, 360);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnMajor
            // 
            this.ColumnMajor.HeaderText = "Major";
            this.ColumnMajor.Name = "ColumnMajor";
            // 
            // textBoxID_input
            // 
            this.textBoxID_input.Location = new System.Drawing.Point(148, 52);
            this.textBoxID_input.Name = "textBoxID_input";
            this.textBoxID_input.Size = new System.Drawing.Size(100, 23);
            this.textBoxID_input.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxName_input
            // 
            this.textBoxName_input.Location = new System.Drawing.Point(148, 81);
            this.textBoxName_input.Name = "textBoxName_input";
            this.textBoxName_input.Size = new System.Drawing.Size(100, 23);
            this.textBoxName_input.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Major";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CIS",
            "ES"});
            this.comboBox1.Location = new System.Drawing.Point(148, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 23);
            this.comboBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "GPA";
            // 
            // textBoxGpa_input
            // 
            this.textBoxGpa_input.Location = new System.Drawing.Point(148, 139);
            this.textBoxGpa_input.Name = "textBoxGpa_input";
            this.textBoxGpa_input.Size = new System.Drawing.Size(100, 23);
            this.textBoxGpa_input.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxMin);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxMax);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxGPAX);
            this.groupBox1.Location = new System.Drawing.Point(31, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 149);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Min";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(117, 92);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.ReadOnly = true;
            this.textBoxMin.Size = new System.Drawing.Size(100, 23);
            this.textBoxMin.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Max";
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(117, 63);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.ReadOnly = true;
            this.textBoxMax.Size = new System.Drawing.Size(100, 23);
            this.textBoxMax.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "GPAX";
            // 
            // textBoxGPAX
            // 
            this.textBoxGPAX.Location = new System.Drawing.Point(117, 34);
            this.textBoxGPAX.Name = "textBoxGPAX";
            this.textBoxGPAX.ReadOnly = true;
            this.textBoxGPAX.Size = new System.Drawing.Size(100, 23);
            this.textBoxGPAX.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxGpa_input);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName_input);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID_input);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuFile;
        private ToolStripMenuItem toolStripMenuOpen;
        private ToolStripMenuItem toolStripMenuSave;
        private DataGridView dataGridView1;
        private TextBox textBoxID_input;
        private Label label1;
        private Button button1;
        private TextBox textBoxName_input;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBoxGpa_input;
        private GroupBox groupBox1;
        private Label label7;
        private TextBox textBoxMin;
        private Label label6;
        private TextBox textBoxMax;
        private Label label5;
        private TextBox textBoxGPAX;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnMajor;
    }
}