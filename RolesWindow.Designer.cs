namespace InventoryAPP
{
    partial class RolesWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.roleTxt = new System.Windows.Forms.TextBox();
            this.rolesGV = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIdGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rolesGV);
            this.panel5.Size = new System.Drawing.Size(1730, 993);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1730, 1142);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.roleTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Size = new System.Drawing.Size(336, 1142);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.roleTxt, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Role";
            // 
            // roleTxt
            // 
            this.roleTxt.Enabled = false;
            this.roleTxt.Location = new System.Drawing.Point(18, 157);
            this.roleTxt.MaxLength = 50;
            this.roleTxt.Name = "roleTxt";
            this.roleTxt.Size = new System.Drawing.Size(292, 31);
            this.roleTxt.TabIndex = 2;
            // 
            // rolesGV
            // 
            this.rolesGV.AllowUserToAddRows = false;
            this.rolesGV.AllowUserToDeleteRows = false;
            this.rolesGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rolesGV.BackgroundColor = System.Drawing.Color.White;
            this.rolesGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rolesGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rolesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.roleIdGV,
            this.roleNameGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rolesGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.rolesGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesGV.Location = new System.Drawing.Point(0, 0);
            this.rolesGV.MultiSelect = false;
            this.rolesGV.Name = "rolesGV";
            this.rolesGV.ReadOnly = true;
            this.rolesGV.RowHeadersVisible = false;
            this.rolesGV.RowHeadersWidth = 62;
            this.rolesGV.RowTemplate.Height = 28;
            this.rolesGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rolesGV.Size = new System.Drawing.Size(1730, 993);
            this.rolesGV.TabIndex = 0;
            this.rolesGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rolesGV_CellClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.MinimumWidth = 8;
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 59;
            // 
            // roleIdGV
            // 
            this.roleIdGV.HeaderText = "Role ID ";
            this.roleIdGV.MinimumWidth = 8;
            this.roleIdGV.Name = "roleIdGV";
            this.roleIdGV.ReadOnly = true;
            this.roleIdGV.Visible = false;
            // 
            // roleNameGV
            // 
            this.roleNameGV.HeaderText = "Role";
            this.roleNameGV.MinimumWidth = 8;
            this.roleNameGV.Name = "roleNameGV";
            this.roleNameGV.ReadOnly = true;
            // 
            // RolesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2066, 1142);
            this.Name = "RolesWindow";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.RolesWindow_Load);
            this.panel5.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox roleTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView rolesGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIdGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameGV;
    }
}