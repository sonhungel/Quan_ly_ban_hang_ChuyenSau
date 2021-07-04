namespace WindowsFormsApp5
{
    partial class fDashboard
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
            this.lbDisplayname = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.txbSearchNameItem = new System.Windows.Forms.TextBox();
            this.nmItem = new System.Windows.Forms.NumericUpDown();
            this.dtgvItem = new System.Windows.Forms.DataGridView();
            this.listViewBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIDBill = new System.Windows.Forms.TextBox();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlRoot = new System.Windows.Forms.Panel();
            this.eclipseControl1 = new WindowsFormsApp5.Tools.EclipseControl();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnInsertBill = new System.Windows.Forms.Button();
            this.btnLoadItem = new System.Windows.Forms.Button();
            this.btnAddItemBill = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.pnlRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDisplayname
            // 
            this.lbDisplayname.AutoSize = true;
            this.lbDisplayname.BackColor = System.Drawing.Color.Transparent;
            this.lbDisplayname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplayname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbDisplayname.Location = new System.Drawing.Point(73, 160);
            this.lbDisplayname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDisplayname.Name = "lbDisplayname";
            this.lbDisplayname.Size = new System.Drawing.Size(59, 20);
            this.lbDisplayname.TabIndex = 15;
            this.lbDisplayname.Text = "label4";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbUsername.Location = new System.Drawing.Point(73, 129);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(59, 20);
            this.lbUsername.TabIndex = 16;
            this.lbUsername.Text = "label5";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnBill);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 726);
            this.panel1.TabIndex = 20;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 316);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbUsername);
            this.panel2.Controls.Add(this.lbDisplayname);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 204);
            this.panel2.TabIndex = 0;
            // 
            // pnlBill
            // 
            this.pnlBill.Controls.Add(this.btnDeleteBill);
            this.pnlBill.Controls.Add(this.btnPay);
            this.pnlBill.Controls.Add(this.btnInsertBill);
            this.pnlBill.Controls.Add(this.txbSearchNameItem);
            this.pnlBill.Controls.Add(this.nmItem);
            this.pnlBill.Controls.Add(this.dtgvItem);
            this.pnlBill.Controls.Add(this.listViewBill);
            this.pnlBill.Controls.Add(this.btnLoadItem);
            this.pnlBill.Controls.Add(this.btnAddItemBill);
            this.pnlBill.Controls.Add(this.label5);
            this.pnlBill.Controls.Add(this.label4);
            this.pnlBill.Controls.Add(this.label2);
            this.pnlBill.Controls.Add(this.txbIDBill);
            this.pnlBill.Controls.Add(this.nmDiscount);
            this.pnlBill.Controls.Add(this.txbTotalPrice);
            this.pnlBill.Controls.Add(this.label1);
            this.pnlBill.Controls.Add(this.label3);
            this.pnlBill.Location = new System.Drawing.Point(3, 10);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(1187, 686);
            this.pnlBill.TabIndex = 21;
            // 
            // txbSearchNameItem
            // 
            this.txbSearchNameItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchNameItem.Location = new System.Drawing.Point(755, 93);
            this.txbSearchNameItem.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchNameItem.Multiline = true;
            this.txbSearchNameItem.Name = "txbSearchNameItem";
            this.txbSearchNameItem.Size = new System.Drawing.Size(240, 34);
            this.txbSearchNameItem.TabIndex = 5;
            this.txbSearchNameItem.TextChanged += new System.EventHandler(this.txbSearchNameItem_TextChanged);
            // 
            // nmItem
            // 
            this.nmItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmItem.Location = new System.Drawing.Point(755, 27);
            this.nmItem.Margin = new System.Windows.Forms.Padding(4);
            this.nmItem.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmItem.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nmItem.Name = "nmItem";
            this.nmItem.Size = new System.Drawing.Size(117, 34);
            this.nmItem.TabIndex = 3;
            this.nmItem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtgvItem
            // 
            this.dtgvItem.AllowUserToAddRows = false;
            this.dtgvItem.AllowUserToDeleteRows = false;
            this.dtgvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvItem.Location = new System.Drawing.Point(609, 155);
            this.dtgvItem.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvItem.MultiSelect = false;
            this.dtgvItem.Name = "dtgvItem";
            this.dtgvItem.ReadOnly = true;
            this.dtgvItem.RowHeadersWidth = 51;
            this.dtgvItem.RowTemplate.Height = 24;
            this.dtgvItem.Size = new System.Drawing.Size(574, 437);
            this.dtgvItem.TabIndex = 6;
            // 
            // listViewBill
            // 
            this.listViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewBill.GridLines = true;
            this.listViewBill.HideSelection = false;
            this.listViewBill.Location = new System.Drawing.Point(16, 155);
            this.listViewBill.Margin = new System.Windows.Forms.Padding(4);
            this.listViewBill.Name = "listViewBill";
            this.listViewBill.Size = new System.Drawing.Size(574, 437);
            this.listViewBill.TabIndex = 2;
            this.listViewBill.UseCompatibleStateImageBehavior = false;
            this.listViewBill.View = System.Windows.Forms.View.Details;
            this.listViewBill.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewBill_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã hàng";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên hàng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 230;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 160;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(623, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(623, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tìm sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(316, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Giảm giá";
            // 
            // txbIDBill
            // 
            this.txbIDBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDBill.Location = new System.Drawing.Point(122, 27);
            this.txbIDBill.Margin = new System.Windows.Forms.Padding(4);
            this.txbIDBill.Name = "txbIDBill";
            this.txbIDBill.ReadOnly = true;
            this.txbIDBill.Size = new System.Drawing.Size(178, 34);
            this.txbIDBill.TabIndex = 14;
            this.txbIDBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmDiscount
            // 
            this.nmDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmDiscount.Location = new System.Drawing.Point(413, 92);
            this.nmDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.nmDiscount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(177, 34);
            this.nmDiscount.TabIndex = 11;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.Location = new System.Drawing.Point(122, 92);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbTotalPrice.Size = new System.Drawing.Size(178, 34);
            this.txbTotalPrice.TabIndex = 9;
            this.txbTotalPrice.Text = "0";
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Số hóa đơn";
            // 
            // pnlRoot
            // 
            this.pnlRoot.Controls.Add(this.pnlBill);
            this.pnlRoot.Location = new System.Drawing.Point(221, 12);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.Size = new System.Drawing.Size(1205, 705);
            this.pnlRoot.TabIndex = 22;
            // 
            // eclipseControl1
            // 
            this.eclipseControl1.CornerRadius = 30;
            this.eclipseControl1.TargetControl = this;
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteBill.FlatAppearance.BorderSize = 0;
            this.btnDeleteBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBill.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBill.Image = global::WindowsFormsApp5.Properties.Resources.small_round_cancel;
            this.btnDeleteBill.Location = new System.Drawing.Point(716, 622);
            this.btnDeleteBill.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(167, 46);
            this.btnDeleteBill.TabIndex = 21;
            this.btnDeleteBill.Text = "Hủy hóa đơn";
            this.btnDeleteBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteBill.UseVisualStyleBackColor = false;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.SystemColors.Control;
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Image = global::WindowsFormsApp5.Properties.Resources.debit_card;
            this.btnPay.Location = new System.Drawing.Point(512, 622);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(167, 46);
            this.btnPay.TabIndex = 20;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnInsertBill
            // 
            this.btnInsertBill.BackColor = System.Drawing.SystemColors.Control;
            this.btnInsertBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsertBill.FlatAppearance.BorderSize = 0;
            this.btnInsertBill.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertBill.Image = global::WindowsFormsApp5.Properties.Resources.add_file;
            this.btnInsertBill.Location = new System.Drawing.Point(311, 622);
            this.btnInsertBill.Name = "btnInsertBill";
            this.btnInsertBill.Size = new System.Drawing.Size(167, 46);
            this.btnInsertBill.TabIndex = 22;
            this.btnInsertBill.Text = "Tạo hóa đơn";
            this.btnInsertBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertBill.UseVisualStyleBackColor = false;
            this.btnInsertBill.Click += new System.EventHandler(this.btnInsertBill_Click);
            // 
            // btnLoadItem
            // 
            this.btnLoadItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoadItem.FlatAppearance.BorderSize = 0;
            this.btnLoadItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadItem.Image = global::WindowsFormsApp5.Properties.Resources.refresh1;
            this.btnLoadItem.Location = new System.Drawing.Point(1019, 90);
            this.btnLoadItem.Name = "btnLoadItem";
            this.btnLoadItem.Size = new System.Drawing.Size(153, 41);
            this.btnLoadItem.TabIndex = 19;
            this.btnLoadItem.Text = "Tải lại";
            this.btnLoadItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadItem.UseVisualStyleBackColor = false;
            this.btnLoadItem.Click += new System.EventHandler(this.btnLoadItem_Click);
            // 
            // btnAddItemBill
            // 
            this.btnAddItemBill.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddItemBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddItemBill.FlatAppearance.BorderSize = 0;
            this.btnAddItemBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItemBill.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItemBill.Image = global::WindowsFormsApp5.Properties.Resources.cart;
            this.btnAddItemBill.Location = new System.Drawing.Point(1019, 22);
            this.btnAddItemBill.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItemBill.Name = "btnAddItemBill";
            this.btnAddItemBill.Size = new System.Drawing.Size(153, 47);
            this.btnAddItemBill.TabIndex = 4;
            this.btnAddItemBill.Text = "Thêm vào giỏ";
            this.btnAddItemBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddItemBill.UseVisualStyleBackColor = false;
            this.btnAddItemBill.Click += new System.EventHandler(this.btnAddItemBill_Click);
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBill.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = global::WindowsFormsApp5.Properties.Resources.bill;
            this.btnBill.Location = new System.Drawing.Point(0, 250);
            this.btnBill.Name = "btnBill";
            this.btnBill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBill.Size = new System.Drawing.Size(215, 42);
            this.btnBill.TabIndex = 18;
            this.btnBill.Text = "Hóa đơn";
            this.btnBill.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            this.btnBill.Leave += new System.EventHandler(this.btnBill_Leave);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = global::WindowsFormsApp5.Properties.Resources.user2;
            this.btnAccount.Location = new System.Drawing.Point(0, 310);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAccount.Size = new System.Drawing.Size(215, 42);
            this.btnAccount.TabIndex = 18;
            this.btnAccount.Text = "Tài khoản";
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            this.btnAccount.Leave += new System.EventHandler(this.btnAccount_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp5.Properties.Resources.picon;
            this.pictureBox1.Location = new System.Drawing.Point(48, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::WindowsFormsApp5.Properties.Resources.exit1;
            this.btnLogOut.Location = new System.Drawing.Point(0, 435);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(215, 42);
            this.btnLogOut.TabIndex = 17;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.Leave += new System.EventHandler(this.btnLogOut_Leave);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = global::WindowsFormsApp5.Properties.Resources.completed_task1;
            this.btnAdmin.Location = new System.Drawing.Point(0, 374);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(215, 42);
            this.btnAdmin.TabIndex = 17;
            this.btnAdmin.Text = "Danh Mục";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            this.btnAdmin.Leave += new System.EventHandler(this.btnAdmin_Leave);
            // 
            // fDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1438, 726);
            this.Controls.Add(this.pnlRoot);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlBill.ResumeLayout(false);
            this.pnlBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.pnlRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbDisplayname;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogOut;
        private Tools.EclipseControl eclipseControl1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Panel pnlRoot;
        private System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.TextBox txbSearchNameItem;
        private System.Windows.Forms.NumericUpDown nmItem;
        private System.Windows.Forms.DataGridView dtgvItem;
        private System.Windows.Forms.ListView listViewBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnLoadItem;
        private System.Windows.Forms.Button btnAddItemBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbIDBill;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnInsertBill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}