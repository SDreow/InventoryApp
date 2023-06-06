namespace InventoryAPP
{
    partial class AccountsTypeWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.accountTypeGV = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.accountTypeGV);
            this.panel5.Size = new System.Drawing.Size(1654, 1071);
            // 
            // searchTxt
            // 
            this.searchTxt.Size = new System.Drawing.Size(322, 31);
            this.searchTxt.TabIndex = 4;
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1654, 1220);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.statusDD);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.nameTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Size = new System.Drawing.Size(336, 1220);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusDD, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Account Name";
            // 
            // nameTxt
            // 
            this.nameTxt.Enabled = false;
            this.nameTxt.Location = new System.Drawing.Point(28, 178);
            this.nameTxt.MaxLength = 40;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(286, 31);
            this.nameTxt.TabIndex = 5;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // statusDD
            // 
            this.statusDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.statusDD.Location = new System.Drawing.Point(29, 241);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(285, 33);
            this.statusDD.TabIndex = 6;
            this.statusDD.SelectedIndexChanged += new System.EventHandler(this.statusDD_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Status";
            // 
            // accountTypeGV
            // 
            this.accountTypeGV.AllowUserToAddRows = false;
            this.accountTypeGV.AllowUserToDeleteRows = false;
            this.accountTypeGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accountTypeGV.BackgroundColor = System.Drawing.Color.White;
            this.accountTypeGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountTypeGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.accountTypeGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountTypeGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.accountTypeIDGV,
            this.accountNameGV,
            this.statusGV});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.accountTypeGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.accountTypeGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountTypeGV.Location = new System.Drawing.Point(0, 0);
            this.accountTypeGV.MultiSelect = false;
            this.accountTypeGV.Name = "accountTypeGV";
            this.accountTypeGV.ReadOnly = true;
            this.accountTypeGV.RowHeadersVisible = false;
            this.accountTypeGV.RowHeadersWidth = 62;
            this.accountTypeGV.RowTemplate.Height = 28;
            this.accountTypeGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountTypeGV.Size = new System.Drawing.Size(1654, 1071);
            this.accountTypeGV.TabIndex = 1;
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
            // accountTypeIDGV
            // 
            this.accountTypeIDGV.HeaderText = "Account Type ID";
            this.accountTypeIDGV.MinimumWidth = 8;
            this.accountTypeIDGV.Name = "accountTypeIDGV";
            this.accountTypeIDGV.ReadOnly = true;
            this.accountTypeIDGV.Visible = false;
            // 
            // accountNameGV
            // 
            this.accountNameGV.HeaderText = "Account Name";
            this.accountNameGV.MinimumWidth = 8;
            this.accountNameGV.Name = "accountNameGV";
            this.accountNameGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.MinimumWidth = 8;
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // AccountsTypeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1990, 1220);
            this.Name = "AccountsTypeWindow";
            this.Text = "Account Types";
            this.Load += new System.EventHandler(this.AccountsTypeWindow_Load);
            this.panel5.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView accountTypeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
    }
}