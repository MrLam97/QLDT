namespace QuanLyCHDT
{
    partial class Frm_HangSX
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbTimT = new System.Windows.Forms.RadioButton();
            this.txtMaH = new System.Windows.Forms.TextBox();
            this.cbbTenH = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHientc = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.dgvHangsx = new System.Windows.Forms.DataGridView();
            this.MaH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangsx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupBox2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(275, 309);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbTimT);
            this.groupBox2.Controls.Add(this.txtMaH);
            this.groupBox2.Controls.Add(this.cbbTenH);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnHientc);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 285);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm hãng sản xuất";
            // 
            // rdbTimT
            // 
            this.rdbTimT.AutoSize = true;
            this.rdbTimT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbTimT.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rdbTimT.Location = new System.Drawing.Point(121, 116);
            this.rdbTimT.Name = "rdbTimT";
            this.rdbTimT.Size = new System.Drawing.Size(107, 21);
            this.rdbTimT.TabIndex = 7;
            this.rdbTimT.Text = "Tìm tên hãng";
            this.rdbTimT.UseVisualStyleBackColor = true;
            this.rdbTimT.CheckedChanged += new System.EventHandler(this.rdbTimT_CheckedChanged);
            // 
            // txtMaH
            // 
            this.txtMaH.Location = new System.Drawing.Point(107, 38);
            this.txtMaH.Name = "txtMaH";
            this.txtMaH.ReadOnly = true;
            this.txtMaH.Size = new System.Drawing.Size(121, 21);
            this.txtMaH.TabIndex = 6;
            // 
            // cbbTenH
            // 
            this.cbbTenH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTenH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenH.FormattingEnabled = true;
            this.cbbTenH.Location = new System.Drawing.Point(107, 80);
            this.cbbTenH.Name = "cbbTenH";
            this.cbbTenH.Size = new System.Drawing.Size(121, 21);
            this.cbbTenH.TabIndex = 5;
            this.cbbTenH.SelectedIndexChanged += new System.EventHandler(this.cbbTenH_SelectedIndexChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnLuu.Location = new System.Drawing.Point(168, 163);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHientc
            // 
            this.btnHientc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHientc.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnHientc.Location = new System.Drawing.Point(63, 220);
            this.btnHientc.Name = "btnHientc";
            this.btnHientc.Size = new System.Drawing.Size(116, 30);
            this.btnHientc.TabIndex = 3;
            this.btnHientc.Text = "Hiện tất cả";
            this.btnHientc.UseVisualStyleBackColor = true;
            this.btnHientc.Click += new System.EventHandler(this.btnHientc_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnThem.Location = new System.Drawing.Point(6, 163);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnXoa.Location = new System.Drawing.Point(87, 163);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(22, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên hãng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(29, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hãng";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(275, 309);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupBox2;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(255, 289);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.dgvHangsx);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(275, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(511, 309);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // dgvHangsx
            // 
            this.dgvHangsx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangsx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaH,
            this.TenH});
            this.dgvHangsx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvHangsx.Location = new System.Drawing.Point(12, 12);
            this.dgvHangsx.Name = "dgvHangsx";
            this.dgvHangsx.Size = new System.Drawing.Size(487, 285);
            this.dgvHangsx.TabIndex = 7;
            // 
            // MaH
            // 
            this.MaH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaH.DataPropertyName = "MaH";
            this.MaH.HeaderText = "Mã hãng";
            this.MaH.Name = "MaH";
            // 
            // TenH
            // 
            this.TenH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenH.DataPropertyName = "TenH";
            this.TenH.HeaderText = "Tên hãng";
            this.TenH.Name = "TenH";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(511, 309);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dgvHangsx;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(491, 289);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // Frm_HangSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 309);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Frm_HangSX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "zzzz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_HangSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangsx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbTimT;
        private System.Windows.Forms.TextBox txtMaH;
        private System.Windows.Forms.ComboBox cbbTenH;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHientc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private System.Windows.Forms.DataGridView dgvHangsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenH;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}