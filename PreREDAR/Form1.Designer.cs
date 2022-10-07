namespace PreREDAR
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
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주의사항ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.제작자ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Label_Count = new System.Windows.Forms.Label();
            this.TextBox_Count = new System.Windows.Forms.TextBox();
            this.Button_TestAdd = new System.Windows.Forms.Button();
            this.Button_TestExport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label_Caution = new System.Windows.Forms.Label();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.Button_Convert = new System.Windows.Forms.Button();
            this.TextBox_FileCount = new System.Windows.Forms.TextBox();
            this.Label_FileCount = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.정보ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.주의사항ToolStripMenuItem,
            this.제작자ToolStripMenuItem});
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.정보ToolStripMenuItem.Text = "정보";
            // 
            // 주의사항ToolStripMenuItem
            // 
            this.주의사항ToolStripMenuItem.Name = "주의사항ToolStripMenuItem";
            this.주의사항ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.주의사항ToolStripMenuItem.Text = "주의사항";
            this.주의사항ToolStripMenuItem.Click += new System.EventHandler(this.주의사항ToolStripMenuItem_Click);
            // 
            // 제작자ToolStripMenuItem
            // 
            this.제작자ToolStripMenuItem.Name = "제작자ToolStripMenuItem";
            this.제작자ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.제작자ToolStripMenuItem.Text = "제작자";
            this.제작자ToolStripMenuItem.Click += new System.EventHandler(this.제작자ToolStripMenuItem_Click);
            // 
            // Label_Count
            // 
            this.Label_Count.AutoSize = true;
            this.Label_Count.Location = new System.Drawing.Point(587, 334);
            this.Label_Count.Name = "Label_Count";
            this.Label_Count.Size = new System.Drawing.Size(75, 15);
            this.Label_Count.TabIndex = 3;
            this.Label_Count.Text = "총 자료 건수";
            // 
            // TextBox_Count
            // 
            this.TextBox_Count.Location = new System.Drawing.Point(587, 352);
            this.TextBox_Count.Name = "TextBox_Count";
            this.TextBox_Count.ReadOnly = true;
            this.TextBox_Count.Size = new System.Drawing.Size(85, 23);
            this.TextBox_Count.TabIndex = 4;
            this.TextBox_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Button_TestAdd
            // 
            this.Button_TestAdd.Location = new System.Drawing.Point(587, 77);
            this.Button_TestAdd.Name = "Button_TestAdd";
            this.Button_TestAdd.Size = new System.Drawing.Size(85, 23);
            this.Button_TestAdd.TabIndex = 6;
            this.Button_TestAdd.Text = "Add";
            this.Button_TestAdd.UseVisualStyleBackColor = true;
            this.Button_TestAdd.Click += new System.EventHandler(this.Button_TestAdd_Click);
            // 
            // Button_TestExport
            // 
            this.Button_TestExport.Location = new System.Drawing.Point(587, 423);
            this.Button_TestExport.Name = "Button_TestExport";
            this.Button_TestExport.Size = new System.Drawing.Size(85, 23);
            this.Button_TestExport.TabIndex = 7;
            this.Button_TestExport.Text = "Export";
            this.Button_TestExport.UseVisualStyleBackColor = true;
            this.Button_TestExport.Click += new System.EventHandler(this.Button_TestExport_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(553, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // Label_Caution
            // 
            this.Label_Caution.AutoSize = true;
            this.Label_Caution.Location = new System.Drawing.Point(12, 42);
            this.Label_Caution.Name = "Label_Caution";
            this.Label_Caution.Size = new System.Drawing.Size(258, 15);
            this.Label_Caution.TabIndex = 8;
            this.Label_Caution.Text = "※사용 전에 정보- 주의사항을 읽고 사용하세요";
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(587, 120);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(85, 23);
            this.Button_Clear.TabIndex = 9;
            this.Button_Clear.Text = "Clear";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Button_Convert
            // 
            this.Button_Convert.Location = new System.Drawing.Point(587, 160);
            this.Button_Convert.Name = "Button_Convert";
            this.Button_Convert.Size = new System.Drawing.Size(85, 23);
            this.Button_Convert.TabIndex = 10;
            this.Button_Convert.Text = "Convert";
            this.Button_Convert.UseVisualStyleBackColor = true;
            this.Button_Convert.Visible = false;
            this.Button_Convert.Click += new System.EventHandler(this.Button_Convert_Click);
            // 
            // TextBox_FileCount
            // 
            this.TextBox_FileCount.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox_FileCount.Location = new System.Drawing.Point(587, 252);
            this.TextBox_FileCount.Name = "TextBox_FileCount";
            this.TextBox_FileCount.Size = new System.Drawing.Size(85, 23);
            this.TextBox_FileCount.TabIndex = 11;
            this.TextBox_FileCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_FileCount
            // 
            this.Label_FileCount.AutoSize = true;
            this.Label_FileCount.Location = new System.Drawing.Point(587, 234);
            this.Label_FileCount.Name = "Label_FileCount";
            this.Label_FileCount.Size = new System.Drawing.Size(75, 15);
            this.Label_FileCount.TabIndex = 12;
            this.Label_FileCount.Text = "합친 파일 수";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.Label_FileCount);
            this.Controls.Add(this.TextBox_FileCount);
            this.Controls.Add(this.Button_Convert);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Label_Caution);
            this.Controls.Add(this.Button_TestExport);
            this.Controls.Add(this.Button_TestAdd);
            this.Controls.Add(this.TextBox_Count);
            this.Controls.Add(this.Label_Count);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PreREDAr";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 파일ToolStripMenuItem;
        private ToolStripMenuItem 종료ToolStripMenuItem;
        private ToolStripMenuItem 정보ToolStripMenuItem;
        private ToolStripMenuItem 제작자ToolStripMenuItem;
        private Label Label_Count;
        private TextBox textBox1;
        private TextBox TextBox_Count;
        private ToolStripMenuItem 주의사항ToolStripMenuItem;
        private Button Button_TestAdd;
        private Button Button_TestExport;
        private DataGridView dataGridView1;
        private Label Label_Caution;
        private Button Button_Clear;
        private Button Button_Convert;
        private TextBox TextBox_FileCount;
        private Label Label_FileCount;
    }

    class dataGridView1 : DataGridView
    {
        public dataGridView1()
        {
            DoubleBuffered = true;
        }
    }
}