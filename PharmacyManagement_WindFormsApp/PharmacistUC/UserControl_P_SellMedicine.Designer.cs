namespace PharmacyManagement_WindFormsApp.PharmacistUC
{
    partial class UserControl_P_SellMedicine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_P_SellMedicine));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSyncReload = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.listBoxMedicineList = new System.Windows.Forms.ListBox();
            this.txtMedicineName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedicineID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeExpire = new System.Windows.Forms.DateTimePicker();
            this.expire = new System.Windows.Forms.Label();
            this.txtPricePerUnit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumberOfUnits = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewAddCartMedicineList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnPurchasePrint = new Guna.UI2.WinForms.Guna2Button();
            this.lblPriceShow = new System.Windows.Forms.Label();
            this.guna2ElipseSellMedicine = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddCartMedicineList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sell Medicine";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSyncReload
            // 
            this.btnSyncReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSyncReload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSyncReload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSyncReload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSyncReload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSyncReload.FillColor = System.Drawing.Color.White;
            this.btnSyncReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSyncReload.ForeColor = System.Drawing.Color.White;
            this.btnSyncReload.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSyncReload.Image = ((System.Drawing.Image)(resources.GetObject("btnSyncReload.Image")));
            this.btnSyncReload.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSyncReload.Location = new System.Drawing.Point(193, 29);
            this.btnSyncReload.Name = "btnSyncReload";
            this.btnSyncReload.PressedColor = System.Drawing.Color.White;
            this.btnSyncReload.Size = new System.Drawing.Size(45, 41);
            this.btnSyncReload.TabIndex = 10;
            this.btnSyncReload.Click += new System.EventHandler(this.btnSyncReload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BorderThickness = 2;
            this.txtBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearch.DefaultText = "";
            this.txtBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxSearch.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txtBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.txtBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxSearch.Location = new System.Drawing.Point(31, 110);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.PasswordChar = '\0';
            this.txtBoxSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtBoxSearch.PlaceholderText = "Search\r\n";
            this.txtBoxSearch.SelectedText = "";
            this.txtBoxSearch.Size = new System.Drawing.Size(210, 36);
            this.txtBoxSearch.TabIndex = 12;
            this.txtBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // listBoxMedicineList
            // 
            this.listBoxMedicineList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMedicineList.FormattingEnabled = true;
            this.listBoxMedicineList.ItemHeight = 20;
            this.listBoxMedicineList.Location = new System.Drawing.Point(31, 162);
            this.listBoxMedicineList.Name = "listBoxMedicineList";
            this.listBoxMedicineList.Size = new System.Drawing.Size(210, 584);
            this.listBoxMedicineList.TabIndex = 13;
            this.listBoxMedicineList.SelectedIndexChanged += new System.EventHandler(this.listBoxMedicineList_SelectedIndexChanged);
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.BorderThickness = 2;
            this.txtMedicineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineName.DefaultText = "";
            this.txtMedicineName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMedicineName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMedicineName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicineName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicineName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicineName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineName.ForeColor = System.Drawing.Color.Black;
            this.txtMedicineName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicineName.Location = new System.Drawing.Point(298, 178);
            this.txtMedicineName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.PasswordChar = '\0';
            this.txtMedicineName.PlaceholderText = "";
            this.txtMedicineName.ReadOnly = true;
            this.txtMedicineName.SelectedText = "";
            this.txtMedicineName.Size = new System.Drawing.Size(340, 36);
            this.txtMedicineName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Medicine Name";
            // 
            // txtMedicineID
            // 
            this.txtMedicineID.BorderThickness = 2;
            this.txtMedicineID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineID.DefaultText = "";
            this.txtMedicineID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMedicineID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMedicineID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicineID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicineID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicineID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineID.ForeColor = System.Drawing.Color.Black;
            this.txtMedicineID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicineID.Location = new System.Drawing.Point(298, 77);
            this.txtMedicineID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMedicineID.Name = "txtMedicineID";
            this.txtMedicineID.PasswordChar = '\0';
            this.txtMedicineID.PlaceholderText = "";
            this.txtMedicineID.ReadOnly = true;
            this.txtMedicineID.SelectedText = "";
            this.txtMedicineID.Size = new System.Drawing.Size(340, 36);
            this.txtMedicineID.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Medicine ID";
            // 
            // dateTimeExpire
            // 
            this.dateTimeExpire.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeExpire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeExpire.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeExpire.Location = new System.Drawing.Point(298, 281);
            this.dateTimeExpire.Name = "dateTimeExpire";
            this.dateTimeExpire.Size = new System.Drawing.Size(340, 30);
            this.dateTimeExpire.TabIndex = 19;
            // 
            // expire
            // 
            this.expire.AutoSize = true;
            this.expire.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expire.Location = new System.Drawing.Point(294, 238);
            this.expire.Name = "expire";
            this.expire.Size = new System.Drawing.Size(105, 22);
            this.expire.TabIndex = 18;
            this.expire.Text = "Expire Date";
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.BorderThickness = 2;
            this.txtPricePerUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPricePerUnit.DefaultText = "";
            this.txtPricePerUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPricePerUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPricePerUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePerUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePerUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPricePerUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerUnit.ForeColor = System.Drawing.Color.Black;
            this.txtPricePerUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPricePerUnit.Location = new System.Drawing.Point(699, 75);
            this.txtPricePerUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.PasswordChar = '\0';
            this.txtPricePerUnit.PlaceholderText = "";
            this.txtPricePerUnit.ReadOnly = true;
            this.txtPricePerUnit.SelectedText = "";
            this.txtPricePerUnit.Size = new System.Drawing.Size(340, 36);
            this.txtPricePerUnit.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(695, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "Price Per Unit";
            // 
            // txtNumberOfUnits
            // 
            this.txtNumberOfUnits.BorderThickness = 2;
            this.txtNumberOfUnits.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberOfUnits.DefaultText = "";
            this.txtNumberOfUnits.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumberOfUnits.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumberOfUnits.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberOfUnits.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberOfUnits.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberOfUnits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfUnits.ForeColor = System.Drawing.Color.Black;
            this.txtNumberOfUnits.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberOfUnits.Location = new System.Drawing.Point(699, 178);
            this.txtNumberOfUnits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumberOfUnits.Name = "txtNumberOfUnits";
            this.txtNumberOfUnits.PasswordChar = '\0';
            this.txtNumberOfUnits.PlaceholderText = "";
            this.txtNumberOfUnits.SelectedText = "";
            this.txtNumberOfUnits.Size = new System.Drawing.Size(340, 36);
            this.txtNumberOfUnits.TabIndex = 23;
            this.txtNumberOfUnits.TextChanged += new System.EventHandler(this.txtNumberOfUnits_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(695, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "Number of Units";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(695, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Total Price";
            // 
            // txtBoxTotalPrice
            // 
            this.txtBoxTotalPrice.BorderThickness = 2;
            this.txtBoxTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxTotalPrice.DefaultText = "";
            this.txtBoxTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtBoxTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxTotalPrice.Location = new System.Drawing.Point(699, 281);
            this.txtBoxTotalPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxTotalPrice.Name = "txtBoxTotalPrice";
            this.txtBoxTotalPrice.PasswordChar = '\0';
            this.txtBoxTotalPrice.PlaceholderText = "";
            this.txtBoxTotalPrice.ReadOnly = true;
            this.txtBoxTotalPrice.SelectedText = "";
            this.txtBoxTotalPrice.Size = new System.Drawing.Size(340, 36);
            this.txtBoxTotalPrice.TabIndex = 23;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BorderRadius = 16;
            this.btnAddToCart.BorderThickness = 1;
            this.btnAddToCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddToCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddToCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnAddToCart.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddToCart.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnAddToCart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.Image")));
            this.btnAddToCart.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddToCart.Location = new System.Drawing.Point(812, 338);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(227, 45);
            this.btnAddToCart.TabIndex = 24;
            this.btnAddToCart.Text = "Add to Card";
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // dataGridViewAddCartMedicineList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridViewAddCartMedicineList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAddCartMedicineList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddCartMedicineList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAddCartMedicineList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewAddCartMedicineList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewAddCartMedicineList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAddCartMedicineList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAddCartMedicineList.ColumnHeadersHeight = 45;
            this.dataGridViewAddCartMedicineList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAddCartMedicineList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewAddCartMedicineList.EnableHeadersVisualStyles = false;
            this.dataGridViewAddCartMedicineList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewAddCartMedicineList.Location = new System.Drawing.Point(298, 405);
            this.dataGridViewAddCartMedicineList.Name = "dataGridViewAddCartMedicineList";
            this.dataGridViewAddCartMedicineList.RowHeadersVisible = false;
            this.dataGridViewAddCartMedicineList.RowHeadersWidth = 51;
            this.dataGridViewAddCartMedicineList.RowTemplate.Height = 24;
            this.dataGridViewAddCartMedicineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAddCartMedicineList.Size = new System.Drawing.Size(741, 269);
            this.dataGridViewAddCartMedicineList.TabIndex = 25;
            this.dataGridViewAddCartMedicineList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewAddCartMedicineList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewAddCartMedicineList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewAddCartMedicineList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewAddCartMedicineList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewAddCartMedicineList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewAddCartMedicineList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewAddCartMedicineList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewAddCartMedicineList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewAddCartMedicineList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewAddCartMedicineList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewAddCartMedicineList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewAddCartMedicineList.ThemeStyle.HeaderStyle.Height = 45;
            this.dataGridViewAddCartMedicineList.ThemeStyle.ReadOnly = false;
            this.dataGridViewAddCartMedicineList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewAddCartMedicineList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewAddCartMedicineList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewAddCartMedicineList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewAddCartMedicineList.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewAddCartMedicineList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewAddCartMedicineList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewAddCartMedicineList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddCartMedicineList_CellClick);
            // 
            // btnRemove
            // 
            this.btnRemove.BorderRadius = 16;
            this.btnRemove.BorderThickness = 1;
            this.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.FillColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRemove.Location = new System.Drawing.Point(298, 697);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(163, 45);
            this.btnRemove.TabIndex = 26;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPurchasePrint
            // 
            this.btnPurchasePrint.BorderRadius = 16;
            this.btnPurchasePrint.BorderThickness = 1;
            this.btnPurchasePrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchasePrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchasePrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPurchasePrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPurchasePrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnPurchasePrint.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchasePrint.ForeColor = System.Drawing.Color.White;
            this.btnPurchasePrint.HoverState.FillColor = System.Drawing.Color.White;
            this.btnPurchasePrint.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnPurchasePrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchasePrint.Image")));
            this.btnPurchasePrint.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPurchasePrint.Location = new System.Drawing.Point(767, 697);
            this.btnPurchasePrint.Name = "btnPurchasePrint";
            this.btnPurchasePrint.Size = new System.Drawing.Size(272, 45);
            this.btnPurchasePrint.TabIndex = 27;
            this.btnPurchasePrint.Text = "Purchase &&  Print";
            // 
            // lblPriceShow
            // 
            this.lblPriceShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.lblPriceShow.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceShow.Location = new System.Drawing.Point(487, 694);
            this.lblPriceShow.Name = "lblPriceShow";
            this.lblPriceShow.Size = new System.Drawing.Size(257, 48);
            this.lblPriceShow.TabIndex = 28;
            this.lblPriceShow.Text = "BDT: ";
            this.lblPriceShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Medicine Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Medicine Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Expire Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price per Unit";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Number of Units";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total Price";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // UserControl_P_SellMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblPriceShow);
            this.Controls.Add(this.btnPurchasePrint);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dataGridViewAddCartMedicineList);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.txtPricePerUnit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxTotalPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumberOfUnits);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimeExpire);
            this.Controls.Add(this.expire);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMedicineID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxMedicineList);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.btnSyncReload);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_P_SellMedicine";
            this.Size = new System.Drawing.Size(1097, 780);
            this.Load += new System.EventHandler(this.UserControl_P_SellMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddCartMedicineList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnSyncReload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxSearch;
        private System.Windows.Forms.ListBox listBoxMedicineList;
        private Guna.UI2.WinForms.Guna2TextBox txtMedicineName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtMedicineID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeExpire;
        private System.Windows.Forms.Label expire;
        private Guna.UI2.WinForms.Guna2TextBox txtPricePerUnit;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtNumberOfUnits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxTotalPrice;
        private Guna.UI2.WinForms.Guna2Button btnAddToCart;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewAddCartMedicineList;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnPurchasePrint;
        private System.Windows.Forms.Label lblPriceShow;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseSellMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
