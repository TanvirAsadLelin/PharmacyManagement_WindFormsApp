namespace PharmacyManagement_WindFormsApp.PharmacistUC
{
    partial class UserControl_P_ViewMedicine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_P_ViewMedicine));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ElipseViewMedicine = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnSyncReload = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewFORViewMedicine = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtSearchByMedicineName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFORViewMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "View Medicine";
            // 
            // guna2ElipseViewMedicine
            // 
            this.guna2ElipseViewMedicine.TargetControl = this;
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
            this.btnSyncReload.Location = new System.Drawing.Point(39, 34);
            this.btnSyncReload.Name = "btnSyncReload";
            this.btnSyncReload.PressedColor = System.Drawing.Color.White;
            this.btnSyncReload.Size = new System.Drawing.Size(34, 35);
            this.btnSyncReload.TabIndex = 14;
            this.btnSyncReload.Click += new System.EventHandler(this.btnSyncReload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewFORViewMedicine
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewFORViewMedicine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFORViewMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFORViewMedicine.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFORViewMedicine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewFORViewMedicine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewFORViewMedicine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFORViewMedicine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFORViewMedicine.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFORViewMedicine.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFORViewMedicine.EnableHeadersVisualStyles = false;
            this.dataGridViewFORViewMedicine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewFORViewMedicine.Location = new System.Drawing.Point(21, 215);
            this.dataGridViewFORViewMedicine.Name = "dataGridViewFORViewMedicine";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFORViewMedicine.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewFORViewMedicine.RowHeadersVisible = false;
            this.dataGridViewFORViewMedicine.RowHeadersWidth = 51;
            this.dataGridViewFORViewMedicine.RowTemplate.Height = 24;
            this.dataGridViewFORViewMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFORViewMedicine.Size = new System.Drawing.Size(1045, 434);
            this.dataGridViewFORViewMedicine.TabIndex = 12;
            this.dataGridViewFORViewMedicine.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewFORViewMedicine.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewFORViewMedicine.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewFORViewMedicine.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewFORViewMedicine.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewFORViewMedicine.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewFORViewMedicine.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewFORViewMedicine.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewFORViewMedicine.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewFORViewMedicine.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewFORViewMedicine.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewFORViewMedicine.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewFORViewMedicine.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridViewFORViewMedicine.ThemeStyle.ReadOnly = false;
            this.dataGridViewFORViewMedicine.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewFORViewMedicine.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewFORViewMedicine.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewFORViewMedicine.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewFORViewMedicine.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewFORViewMedicine.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewFORViewMedicine.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewFORViewMedicine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFORViewMedicine_CellClick);
            // 
            // txtSearchByMedicineName
            // 
            this.txtSearchByMedicineName.BorderThickness = 2;
            this.txtSearchByMedicineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchByMedicineName.DefaultText = "";
            this.txtSearchByMedicineName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchByMedicineName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchByMedicineName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchByMedicineName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchByMedicineName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchByMedicineName.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txtSearchByMedicineName.ForeColor = System.Drawing.Color.Black;
            this.txtSearchByMedicineName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchByMedicineName.Location = new System.Drawing.Point(775, 123);
            this.txtSearchByMedicineName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchByMedicineName.Name = "txtSearchByMedicineName";
            this.txtSearchByMedicineName.PasswordChar = '\0';
            this.txtSearchByMedicineName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchByMedicineName.PlaceholderText = "Search by Medicine Name!";
            this.txtSearchByMedicineName.SelectedText = "";
            this.txtSearchByMedicineName.Size = new System.Drawing.Size(291, 44);
            this.txtSearchByMedicineName.TabIndex = 11;
            this.txtSearchByMedicineName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchByMedicineName.TextChanged += new System.EventHandler(this.txtSearchByMedicineName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(771, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Medicine name: ";
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 16;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(148)))), ((int)(((byte)(184)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDelete.Location = new System.Drawing.Point(901, 697);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 45);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UserControl_P_ViewMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSyncReload);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewFORViewMedicine);
            this.Controls.Add(this.txtSearchByMedicineName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_P_ViewMedicine";
            this.Size = new System.Drawing.Size(1097, 780);
            this.Load += new System.EventHandler(this.UserControl_P_ViewMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFORViewMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseViewMedicine;
        private Guna.UI2.WinForms.Guna2Button btnSyncReload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewFORViewMedicine;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchByMedicineName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
    }
}
