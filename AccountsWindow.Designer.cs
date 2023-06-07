namespace InventoryAPP
{
    partial class AccountsWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.accountTypeDD = new System.Windows.Forms.ComboBox();
            this.accountTypeGV = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.accountTypeGV);
            this.panel5.Size = new System.Drawing.Size(1845, 1225);
            // 
            // searchTxt
            // 
            this.searchTxt.Size = new System.Drawing.Size(357, 31);
            // 
            // rightPanel
            // 
            this.rightPanel.Location = new System.Drawing.Point(403, 0);
            this.rightPanel.Size = new System.Drawing.Size(1845, 1374);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.accountTypeDD);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.addressTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.phoneTxt);
            this.leftPanel.Controls.Add(this.statusDD);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.nameTxt);
            this.leftPanel.Size = new System.Drawing.Size(403, 1374);
            this.leftPanel.Controls.SetChildIndex(this.nameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.addressTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.accountTypeDD, 0);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(403, 79);
            // 
            // statusDD
            // 
            this.statusDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.statusDD.Location = new System.Drawing.Point(41, 406);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(324, 33);
            this.statusDD.TabIndex = 14;
            this.statusDD.SelectedIndexChanged += new System.EventHandler(this.statusDD_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Status";
            // 
            // nameTxt
            // 
            this.nameTxt.Enabled = false;
            this.nameTxt.Location = new System.Drawing.Point(40, 153);
            this.nameTxt.MaxLength = 40;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(325, 31);
            this.nameTxt.TabIndex = 13;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Phone";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Enabled = false;
            this.phoneTxt.Location = new System.Drawing.Point(41, 216);
            this.phoneTxt.MaxLength = 40;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(325, 31);
            this.phoneTxt.TabIndex = 17;
            this.phoneTxt.TextChanged += new System.EventHandler(this.phoneTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Adress";
            // 
            // addressTxt
            // 
            this.addressTxt.Enabled = false;
            this.addressTxt.Location = new System.Drawing.Point(41, 279);
            this.addressTxt.MaxLength = 40;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(325, 31);
            this.addressTxt.TabIndex = 19;
            this.addressTxt.TextChanged += new System.EventHandler(this.addressTxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Type of Account";
            // 
            // accountTypeDD
            // 
            this.accountTypeDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountTypeDD.FormattingEnabled = true;
            this.accountTypeDD.Location = new System.Drawing.Point(39, 341);
            this.accountTypeDD.Name = "accountTypeDD";
            this.accountTypeDD.Size = new System.Drawing.Size(324, 33);
            this.accountTypeDD.TabIndex = 21;
            this.accountTypeDD.SelectedIndexChanged += new System.EventHandler(this.accountTypeDD_SelectedIndexChanged);
            // 
            // accountTypeGV
            // 
            this.accountTypeGV.AllowUserToAddRows = false;
            this.accountTypeGV.AllowUserToDeleteRows = false;
            this.accountTypeGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accountTypeGV.BackgroundColor = System.Drawing.Color.White;
            this.accountTypeGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountTypeGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.accountTypeGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountTypeGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.accountIDGV,
            this.accountNameGV,
            this.phoneGV,
            this.AddressGV,
            this.TypeGV,
            this.statusGV});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.accountTypeGV.DefaultCellStyle = dataGridViewCellStyle12;
            this.accountTypeGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountTypeGV.Location = new System.Drawing.Point(0, 0);
            this.accountTypeGV.MultiSelect = false;
            this.accountTypeGV.Name = "accountTypeGV";
            this.accountTypeGV.ReadOnly = true;
            this.accountTypeGV.RowHeadersVisible = false;
            this.accountTypeGV.RowHeadersWidth = 62;
            this.accountTypeGV.RowTemplate.Height = 28;
            this.accountTypeGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountTypeGV.Size = new System.Drawing.Size(1845, 1225);
            this.accountTypeGV.TabIndex = 2;
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
            // accountIDGV
            // 
            this.accountIDGV.HeaderText = "Account ID";
            this.accountIDGV.MinimumWidth = 8;
            this.accountIDGV.Name = "accountIDGV";
            this.accountIDGV.ReadOnly = true;
            this.accountIDGV.Visible = false;
            // 
            // accountNameGV
            // 
            this.accountNameGV.HeaderText = "Account";
            this.accountNameGV.MinimumWidth = 8;
            this.accountNameGV.Name = "accountNameGV";
            this.accountNameGV.ReadOnly = true;
            // 
            // phoneGV
            // 
            this.phoneGV.HeaderText = "Phone";
            this.phoneGV.MinimumWidth = 8;
            this.phoneGV.Name = "phoneGV";
            this.phoneGV.ReadOnly = true;
            // 
            // AddressGV
            // 
            this.AddressGV.HeaderText = "Address";
            this.AddressGV.MinimumWidth = 8;
            this.AddressGV.Name = "AddressGV";
            this.AddressGV.ReadOnly = true;
            // 
            // TypeGV
            // 
            this.TypeGV.HeaderText = "Type of Account";
            this.TypeGV.MinimumWidth = 8;
            this.TypeGV.Name = "TypeGV";
            this.TypeGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.MinimumWidth = 8;
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // AccountsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2248, 1374);
            this.Name = "AccountsWindow";
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.AccountsWindow_Load);
            this.panel5.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.ComboBox accountTypeDD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.DataGridView accountTypeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
    }
}