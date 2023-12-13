﻿namespace Essay.Pages.Dialog
{
    partial class dialogHistory
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dialogHistory));
            grbFilter = new DevExpress.XtraEditors.GroupControl();
            label1 = new Label();
            txtFind = new TextBox();
            dgvData = new DataGridView();
            User = new DataGridViewTextBoxColumn();
            TypeUser = new DataGridViewTextBoxColumn();
            NameUser = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            btnReload = new PictureBox();
            TimeTyping = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)grbFilter).BeginInit();
            grbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnReload).BeginInit();
            SuspendLayout();
            // 
            // grbFilter
            // 
            grbFilter.Controls.Add(btnReload);
            grbFilter.Controls.Add(label1);
            grbFilter.Controls.Add(txtFind);
            grbFilter.Location = new Point(2, 3);
            grbFilter.Name = "grbFilter";
            grbFilter.Size = new Size(624, 119);
            grbFilter.TabIndex = 3;
            grbFilter.Text = "Filter";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 57);
            label1.Name = "label1";
            label1.Size = new Size(117, 18);
            label1.TabIndex = 1;
            label1.Text = "Search by Name";
            // 
            // txtFind
            // 
            txtFind.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFind.Location = new Point(133, 53);
            txtFind.Multiline = true;
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(426, 28);
            txtFind.TabIndex = 0;
            txtFind.TextChanged += txtFind_TextChanged;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.BackgroundColor = Color.WhiteSmoke;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { User, TypeUser, NameUser, Date });
            dgvData.Location = new Point(1, 116);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersVisible = false;
            dgvData.RowTemplate.Height = 25;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(625, 434);
            dgvData.TabIndex = 2;
            // 
            // User
            // 
            User.HeaderText = "User";
            User.Name = "User";
            User.ReadOnly = true;
            // 
            // TypeUser
            // 
            TypeUser.HeaderText = "Type User";
            TypeUser.Name = "TypeUser";
            TypeUser.ReadOnly = true;
            // 
            // NameUser
            // 
            NameUser.HeaderText = "Name";
            NameUser.Name = "NameUser";
            NameUser.ReadOnly = true;
            // 
            // Date
            // 
            Date.HeaderText = "Date Login";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // btnReload
            // 
            btnReload.Image = Properties.Resources.icons8_restore_32;
            btnReload.Location = new Point(576, 48);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(39, 36);
            btnReload.TabIndex = 4;
            btnReload.TabStop = false;
            btnReload.Click += btnReload_Click;
            // 
            // TimeTyping
            // 
            TimeTyping.Interval = 400;
            TimeTyping.Tick += TimeTyping_Tick;
            // 
            // dialogHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 550);
            Controls.Add(grbFilter);
            Controls.Add(dgvData);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(643, 589);
            Name = "dialogHistory";
            Text = "History Login";
            Load += dialogHistory_Load;
            ((System.ComponentModel.ISupportInitialize)grbFilter).EndInit();
            grbFilter.ResumeLayout(false);
            grbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnReload).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grbFilter;
        private Label label1;
        private TextBox txtFind;
        private DataGridView dgvData;
        private PictureBox btnReload;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn TypeUser;
        private DataGridViewTextBoxColumn NameUser;
        private DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Timer TimeTyping;
    }
}