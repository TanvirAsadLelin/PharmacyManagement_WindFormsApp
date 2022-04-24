namespace PharmacyManagement_WindFormsApp
{
    partial class PharmacistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmacistForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2ElipseDashBoard = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ElipseAddMedicine = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ElipseViewMedicine = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ElipseUpdateMedicine = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ElipseMedicineValidityCheck = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSellMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnValidityCheck = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifyMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashBoardPharmacist = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ElipseSellMedicine = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.userControl_P_MedicineValidityCheck1 = new PharmacyManagement_WindFormsApp.PharmacistUC.UserControl_P_MedicineValidityCheck();
            this.userControl_P_UpdateMedicine1 = new PharmacyManagement_WindFormsApp.PharmacistUC.UserControl_P_UpdateMedicine();
            this.userControl_P_ViewMedicine1 = new PharmacyManagement_WindFormsApp.PharmacistUC.UserControl_P_ViewMedicine();
            this.userControl_P_AddMedicine1 = new PharmacyManagement_WindFormsApp.PharmacistUC.UserControl_P_AddMedicine();
            this.userControl_P_DashBoard1 = new PharmacyManagement_WindFormsApp.PharmacistUC.UserControl_P_DashBoard();
            this.userControl_P_SellMedicine1 = new PharmacyManagement_WindFormsApp.PharmacistUC.UserControl_P_SellMedicine();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnSellMedicine);
            this.panel1.Controls.Add(this.btnValidityCheck);
            this.panel1.Controls.Add(this.btnModifyMedicine);
            this.panel1.Controls.Add(this.btnViewMedicine);
            this.panel1.Controls.Add(this.btnAddMedicine);
            this.panel1.Controls.Add(this.btnDashBoardPharmacist);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 780);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pharmacists";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userControl_P_SellMedicine1);
            this.panel2.Controls.Add(this.userControl_P_MedicineValidityCheck1);
            this.panel2.Controls.Add(this.userControl_P_UpdateMedicine1);
            this.panel2.Controls.Add(this.userControl_P_ViewMedicine1);
            this.panel2.Controls.Add(this.userControl_P_AddMedicine1);
            this.panel2.Controls.Add(this.userControl_P_DashBoard1);
            this.panel2.Location = new System.Drawing.Point(278, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 780);
            this.panel2.TabIndex = 1;
            // 
            // guna2ElipseDashBoard
            // 
            this.guna2ElipseDashBoard.TargetControl = this.panel2;
            // 
            // guna2ElipseAddMedicine
            // 
            this.guna2ElipseAddMedicine.TargetControl = this.panel2;
            // 
            // guna2ElipseViewMedicine
            // 
            this.guna2ElipseViewMedicine.TargetControl = this.panel2;
            // 
            // guna2ElipseUpdateMedicine
            // 
            this.guna2ElipseUpdateMedicine.TargetControl = this.panel2;
            // 
            // guna2ElipseMedicineValidityCheck
            // 
            this.guna2ElipseMedicineValidityCheck.TargetControl = this.panel2;
            // 
            // btnLogOut
            // 
            this.btnLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogOut.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogOut.Location = new System.Drawing.Point(12, 663);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(266, 45);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSellMedicine
            // 
            this.btnSellMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSellMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSellMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnSellMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSellMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSellMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSellMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSellMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnSellMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellMedicine.ForeColor = System.Drawing.Color.White;
            this.btnSellMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnSellMedicine.Image")));
            this.btnSellMedicine.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSellMedicine.Location = new System.Drawing.Point(12, 597);
            this.btnSellMedicine.Name = "btnSellMedicine";
            this.btnSellMedicine.Size = new System.Drawing.Size(266, 45);
            this.btnSellMedicine.TabIndex = 9;
            this.btnSellMedicine.Text = "Sell Medicine";
            this.btnSellMedicine.Click += new System.EventHandler(this.btnSellMedicine_Click);
            // 
            // btnValidityCheck
            // 
            this.btnValidityCheck.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnValidityCheck.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnValidityCheck.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnValidityCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnValidityCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnValidityCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnValidityCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnValidityCheck.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnValidityCheck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidityCheck.ForeColor = System.Drawing.Color.White;
            this.btnValidityCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnValidityCheck.Image")));
            this.btnValidityCheck.ImageSize = new System.Drawing.Size(30, 30);
            this.btnValidityCheck.Location = new System.Drawing.Point(15, 528);
            this.btnValidityCheck.Name = "btnValidityCheck";
            this.btnValidityCheck.Size = new System.Drawing.Size(263, 45);
            this.btnValidityCheck.TabIndex = 3;
            this.btnValidityCheck.Text = "Validity Check";
            this.btnValidityCheck.Click += new System.EventHandler(this.btnValidityCheck_Click);
            // 
            // btnModifyMedicine
            // 
            this.btnModifyMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnModifyMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnModifyMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnModifyMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModifyMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModifyMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModifyMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModifyMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnModifyMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyMedicine.ForeColor = System.Drawing.Color.White;
            this.btnModifyMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyMedicine.Image")));
            this.btnModifyMedicine.ImageSize = new System.Drawing.Size(30, 30);
            this.btnModifyMedicine.Location = new System.Drawing.Point(15, 462);
            this.btnModifyMedicine.Name = "btnModifyMedicine";
            this.btnModifyMedicine.Size = new System.Drawing.Size(263, 45);
            this.btnModifyMedicine.TabIndex = 4;
            this.btnModifyMedicine.Text = "Modify Medicine";
            this.btnModifyMedicine.Click += new System.EventHandler(this.btnModifyMedicine_Click);
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnViewMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedicine.ForeColor = System.Drawing.Color.White;
            this.btnViewMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMedicine.Image")));
            this.btnViewMedicine.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewMedicine.Location = new System.Drawing.Point(15, 396);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.Size = new System.Drawing.Size(263, 45);
            this.btnViewMedicine.TabIndex = 5;
            this.btnViewMedicine.Text = "View Medicine";
            this.btnViewMedicine.Click += new System.EventHandler(this.btnViewMedicine_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnAddMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMedicine.Image")));
            this.btnAddMedicine.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddMedicine.Location = new System.Drawing.Point(15, 330);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(263, 45);
            this.btnAddMedicine.TabIndex = 6;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // btnDashBoardPharmacist
            // 
            this.btnDashBoardPharmacist.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashBoardPharmacist.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashBoardPharmacist.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnDashBoardPharmacist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashBoardPharmacist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashBoardPharmacist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashBoardPharmacist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashBoardPharmacist.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnDashBoardPharmacist.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoardPharmacist.ForeColor = System.Drawing.Color.White;
            this.btnDashBoardPharmacist.Image = ((System.Drawing.Image)(resources.GetObject("btnDashBoardPharmacist.Image")));
            this.btnDashBoardPharmacist.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashBoardPharmacist.Location = new System.Drawing.Point(15, 263);
            this.btnDashBoardPharmacist.Name = "btnDashBoardPharmacist";
            this.btnDashBoardPharmacist.Size = new System.Drawing.Size(263, 45);
            this.btnDashBoardPharmacist.TabIndex = 7;
            this.btnDashBoardPharmacist.Text = "Dashboard";
            this.btnDashBoardPharmacist.Click += new System.EventHandler(this.btnDashBoardPharmacist_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2ElipseSellMedicine
            // 
            this.guna2ElipseSellMedicine.TargetControl = this.panel2;
            // 
            // userControl_P_MedicineValidityCheck1
            // 
            this.userControl_P_MedicineValidityCheck1.BackColor = System.Drawing.Color.White;
            this.userControl_P_MedicineValidityCheck1.Location = new System.Drawing.Point(0, -3);
            this.userControl_P_MedicineValidityCheck1.Name = "userControl_P_MedicineValidityCheck1";
            this.userControl_P_MedicineValidityCheck1.Size = new System.Drawing.Size(1097, 780);
            this.userControl_P_MedicineValidityCheck1.TabIndex = 4;
            // 
            // userControl_P_UpdateMedicine1
            // 
            this.userControl_P_UpdateMedicine1.BackColor = System.Drawing.Color.White;
            this.userControl_P_UpdateMedicine1.Location = new System.Drawing.Point(0, -3);
            this.userControl_P_UpdateMedicine1.Name = "userControl_P_UpdateMedicine1";
            this.userControl_P_UpdateMedicine1.Size = new System.Drawing.Size(1097, 780);
            this.userControl_P_UpdateMedicine1.TabIndex = 3;
            // 
            // userControl_P_ViewMedicine1
            // 
            this.userControl_P_ViewMedicine1.BackColor = System.Drawing.Color.White;
            this.userControl_P_ViewMedicine1.Location = new System.Drawing.Point(0, -3);
            this.userControl_P_ViewMedicine1.Name = "userControl_P_ViewMedicine1";
            this.userControl_P_ViewMedicine1.Size = new System.Drawing.Size(1097, 780);
            this.userControl_P_ViewMedicine1.TabIndex = 2;
            // 
            // userControl_P_AddMedicine1
            // 
            this.userControl_P_AddMedicine1.BackColor = System.Drawing.Color.White;
            this.userControl_P_AddMedicine1.Location = new System.Drawing.Point(0, -3);
            this.userControl_P_AddMedicine1.Name = "userControl_P_AddMedicine1";
            this.userControl_P_AddMedicine1.Size = new System.Drawing.Size(1097, 780);
            this.userControl_P_AddMedicine1.TabIndex = 1;
            // 
            // userControl_P_DashBoard1
            // 
            this.userControl_P_DashBoard1.BackColor = System.Drawing.Color.White;
            this.userControl_P_DashBoard1.Location = new System.Drawing.Point(0, -3);
            this.userControl_P_DashBoard1.Name = "userControl_P_DashBoard1";
            this.userControl_P_DashBoard1.Size = new System.Drawing.Size(1097, 780);
            this.userControl_P_DashBoard1.TabIndex = 0;
            // 
            // userControl_P_SellMedicine1
            // 
            this.userControl_P_SellMedicine1.BackColor = System.Drawing.Color.White;
            this.userControl_P_SellMedicine1.Location = new System.Drawing.Point(0, -3);
            this.userControl_P_SellMedicine1.Name = "userControl_P_SellMedicine1";
            this.userControl_P_SellMedicine1.Size = new System.Drawing.Size(1097, 780);
            this.userControl_P_SellMedicine1.TabIndex = 5;
            // 
            // PharmacistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 780);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PharmacistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PharmacistForm";
            this.Load += new System.EventHandler(this.PharmacistForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnValidityCheck;
        private Guna.UI2.WinForms.Guna2Button btnModifyMedicine;
        private Guna.UI2.WinForms.Guna2Button btnViewMedicine;
        private Guna.UI2.WinForms.Guna2Button btnAddMedicine;
        private Guna.UI2.WinForms.Guna2Button btnDashBoardPharmacist;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnSellMedicine;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseDashBoard;
        private PharmacistUC.UserControl_P_DashBoard userControl_P_DashBoard1;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseAddMedicine;
        private PharmacistUC.UserControl_P_AddMedicine userControl_P_AddMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseViewMedicine;
        private PharmacistUC.UserControl_P_ViewMedicine userControl_P_ViewMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseUpdateMedicine;
        private PharmacistUC.UserControl_P_UpdateMedicine userControl_P_UpdateMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseMedicineValidityCheck;
        private PharmacistUC.UserControl_P_MedicineValidityCheck userControl_P_MedicineValidityCheck1;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseSellMedicine;
        private PharmacistUC.UserControl_P_SellMedicine userControl_P_SellMedicine1;
    }
}