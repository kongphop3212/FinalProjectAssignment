namespace FinalProjectAssignment
{
    partial class CheckList
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxInandOut = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTitleName = new System.Windows.Forms.ComboBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInandOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAdd.Location = new System.Drawing.Point(52, 294);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(134, 55);
            this.buttonAdd.TabIndex = 38;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxInandOut
            // 
            this.comboBoxInandOut.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxInandOut.FormattingEnabled = true;
            this.comboBoxInandOut.Items.AddRange(new object[] {
            "เข้า",
            "ออก"});
            this.comboBoxInandOut.Location = new System.Drawing.Point(107, 255);
            this.comboBoxInandOut.Name = "comboBoxInandOut";
            this.comboBoxInandOut.Size = new System.Drawing.Size(121, 23);
            this.comboBoxInandOut.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "เข้า - ออก";
            // 
            // dateTimeTime
            // 
            this.dateTimeTime.CalendarTitleBackColor = System.Drawing.SystemColors.Window;
            this.dateTimeTime.CalendarTitleForeColor = System.Drawing.SystemColors.Window;
            this.dateTimeTime.CalendarTrailingForeColor = System.Drawing.SystemColors.Window;
            this.dateTimeTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeTime.Location = new System.Drawing.Point(107, 219);
            this.dateTimeTime.Name = "dateTimeTime";
            this.dateTimeTime.Size = new System.Drawing.Size(121, 23);
            this.dateTimeTime.TabIndex = 34;
            // 
            // dateTimeDate
            // 
            this.dateTimeDate.CalendarMonthBackground = System.Drawing.SystemColors.ButtonFace;
            this.dateTimeDate.CalendarTrailingForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dateTimeDate.CustomFormat = "dd.MMMM.yyyy";
            this.dateTimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDate.Location = new System.Drawing.Point(107, 184);
            this.dateTimeDate.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimeDate.MinDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.dateTimeDate.Name = "dateTimeDate";
            this.dateTimeDate.Size = new System.Drawing.Size(121, 23);
            this.dateTimeDate.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "เวลา";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "วันที่";
            // 
            // comboBoxTitleName
            // 
            this.comboBoxTitleName.FormattingEnabled = true;
            this.comboBoxTitleName.Items.AddRange(new object[] {
            "นาย",
            "นางสาว",
            "นาง"});
            this.comboBoxTitleName.Location = new System.Drawing.Point(107, 77);
            this.comboBoxTitleName.Name = "comboBoxTitleName";
            this.comboBoxTitleName.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTitleName.TabIndex = 30;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(107, 146);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(121, 23);
            this.textSurname.TabIndex = 29;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(107, 111);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(121, 23);
            this.textName.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "นามสกุล";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(37, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "คำนำหน้าชื่อ";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(107, 41);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(121, 23);
            this.textId.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnTitleName,
            this.ColumnName,
            this.ColumnSurname,
            this.ColumnDate,
            this.ColumnTime,
            this.ColumnInandOut});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(261, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(744, 448);
            this.dataGridView1.TabIndex = 22;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnTitleName
            // 
            this.ColumnTitleName.HeaderText = "คำนำหน้าชื่อ";
            this.ColumnTitleName.Name = "ColumnTitleName";
            this.ColumnTitleName.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "ชื่อ";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnSurname
            // 
            this.ColumnSurname.HeaderText = "นามสกุล";
            this.ColumnSurname.Name = "ColumnSurname";
            this.ColumnSurname.ReadOnly = true;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "วันที่";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "เวลา";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            // 
            // ColumnInandOut
            // 
            this.ColumnInandOut.HeaderText = "เข้า - ออก";
            this.ColumnInandOut.Name = "ColumnInandOut";
            this.ColumnInandOut.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1017, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(12, 458);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(139, 35);
            this.buttonExit.TabIndex = 39;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // CheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 505);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxInandOut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimeTime);
            this.Controls.Add(this.dateTimeDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTitleName);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CheckList";
            this.Text = "CheckList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAdd;
        private ComboBox comboBoxInandOut;
        private Label label7;
        private DateTimePicker dateTimeTime;
        private DateTimePicker dateTimeDate;
        private Label label6;
        private Label label5;
        private ComboBox comboBoxTitleName;
        private TextBox textSurname;
        private TextBox textName;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textId;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnTitleName;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnSurname;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnTime;
        private DataGridViewTextBoxColumn ColumnInandOut;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private Button buttonExit;
    }
}