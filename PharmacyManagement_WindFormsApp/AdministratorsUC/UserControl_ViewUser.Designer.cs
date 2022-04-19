namespace PharmacyManagement_WindFormsApp.AdministratorsUC
{
    partial class UserControl_ViewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_ViewUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchByUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridViewFORViewUser = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnSyncReload = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.gunaElipseViewUser = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFORViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "View User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(775, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username: ";
            // 
            // txtSearchByUserName
            // 
            this.txtSearchByUserName.BorderThickness = 2;
            this.txtSearchByUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchByUserName.DefaultText = "";
            this.txtSearchByUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchByUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchByUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchByUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchByUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchByUserName.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txtSearchByUserName.ForeColor = System.Drawing.Color.Black;
            this.txtSearchByUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchByUserName.Location = new System.Drawing.Point(779, 145);
            this.txtSearchByUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchByUserName.Name = "txtSearchByUserName";
            this.txtSearchByUserName.PasswordChar = '\0';
            this.txtSearchByUserName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchByUserName.PlaceholderText = "Search by username!";
            this.txtSearchByUserName.SelectedText = "";
            this.txtSearchByUserName.Size = new System.Drawing.Size(291, 44);
            this.txtSearchByUserName.TabIndex = 5;
            this.txtSearchByUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchByUserName.TextChanged += new System.EventHandler(this.txtSearchByUserName_TextChanged);
            // 
            // dataGridViewFORViewUser
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewFORViewUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFORViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFORViewUser.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFORViewUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewFORViewUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewFORViewUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFORViewUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFORViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFORViewUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFORViewUser.EnableHeadersVisualStyles = false;
            this.dataGridViewFORViewUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewFORViewUser.Location = new System.Drawing.Point(25, 237);
            this.dataGridViewFORViewUser.Name = "dataGridViewFORViewUser";
            this.dataGridViewFORViewUser.RowHeadersVisible = false;
            this.dataGridViewFORViewUser.RowHeadersWidth = 51;
            this.dataGridViewFORViewUser.RowTemplate.Height = 24;
            this.dataGridViewFORViewUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFORViewUser.Size = new System.Drawing.Size(1045, 434);
            this.dataGridViewFORViewUser.TabIndex = 6;
            this.dataGridViewFORViewUser.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewFORViewUser.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewFORViewUser.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewFORViewUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewFORViewUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewFORViewUser.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewFORViewUser.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewFORViewUser.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewFORViewUser.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewFORViewUser.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewFORViewUser.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewFORViewUser.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFORViewUser.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridViewFORViewUser.ThemeStyle.ReadOnly = false;
            this.dataGridViewFORViewUser.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewFORViewUser.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewFORViewUser.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewFORViewUser.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewFORViewUser.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewFORViewUser.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewFORViewUser.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewFORViewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFORViewUser_CellClick);
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
            this.btnSyncReload.Location = new System.Drawing.Point(43, 56);
            this.btnSyncReload.Name = "btnSyncReload";
            this.btnSyncReload.PressedColor = System.Drawing.Color.White;
            this.btnSyncReload.Size = new System.Drawing.Size(34, 35);
            this.btnSyncReload.TabIndex = 8;
            this.btnSyncReload.Click += new System.EventHandler(this.btnSyncReload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 16;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(172)))), ((int)(((byte)(37)))));
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDelete.Location = new System.Drawing.Point(905, 688);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 45);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gunaElipseViewUser
            // 
            this.gunaElipseViewUser.TargetControl = this;
            // 
            // UserControl_ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSyncReload);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewFORViewUser);
            this.Controls.Add(this.txtSearchByUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_ViewUser";
            this.Size = new System.Drawing.Size(1104, 768);
            this.Load += new System.EventHandler(this.UserControl_ViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFORViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchByUserName;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewFORViewUser;
        private Guna.UI2.WinForms.Guna2Button btnSyncReload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Elipse gunaElipseViewUser;
    }
}
