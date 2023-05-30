namespace InventoryAPP
{
    partial class SuppliersWindow
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
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.supplierGV = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.supplierGV);
            this.panel5.Size = new System.Drawing.Size(1818, 1061);
            // 
            // searchTxt
            // 
            this.searchTxt.Size = new System.Drawing.Size(354, 31);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1818, 1210);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.adressTxt);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.statusDD);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.emailTxt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.phoneTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.nameTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Size = new System.Drawing.Size(336, 1210);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.emailTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.adressTxt, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(18, 178);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(291, 31);
            this.nameTxt.TabIndex = 2;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(19, 241);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(291, 31);
            this.phoneTxt.TabIndex = 4;
            this.phoneTxt.TextChanged += new System.EventHandler(this.phoneTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(19, 304);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(291, 31);
            this.emailTxt.TabIndex = 6;
            this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Status";
            // 
            // statusDD
            // 
            this.statusDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.statusDD.Location = new System.Drawing.Point(19, 430);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(291, 33);
            this.statusDD.TabIndex = 10;
            this.statusDD.SelectedIndexChanged += new System.EventHandler(this.statusDD_SelectedIndexChanged);
            // 
            // supplierGV
            // 
            this.supplierGV.AllowUserToAddRows = false;
            this.supplierGV.AllowUserToDeleteRows = false;
            this.supplierGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.supplierGV.BackgroundColor = System.Drawing.Color.White;
            this.supplierGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supplierGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.supplierGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.supplierIDGV,
            this.nameGV,
            this.phoneGV,
            this.adressGV,
            this.emailGV,
            this.statusGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.supplierGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.supplierGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierGV.Location = new System.Drawing.Point(0, 0);
            this.supplierGV.MultiSelect = false;
            this.supplierGV.Name = "supplierGV";
            this.supplierGV.ReadOnly = true;
            this.supplierGV.RowHeadersVisible = false;
            this.supplierGV.RowHeadersWidth = 62;
            this.supplierGV.RowTemplate.Height = 28;
            this.supplierGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supplierGV.Size = new System.Drawing.Size(1818, 1061);
            this.supplierGV.TabIndex = 1;
            this.supplierGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplierGV_CellClick);
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
            // supplierIDGV
            // 
            this.supplierIDGV.HeaderText = "SupplierID";
            this.supplierIDGV.MinimumWidth = 8;
            this.supplierIDGV.Name = "supplierIDGV";
            this.supplierIDGV.ReadOnly = true;
            this.supplierIDGV.Visible = false;
            // 
            // nameGV
            // 
            this.nameGV.HeaderText = "Supplier";
            this.nameGV.MinimumWidth = 8;
            this.nameGV.Name = "nameGV";
            this.nameGV.ReadOnly = true;
            // 
            // phoneGV
            // 
            this.phoneGV.HeaderText = "Phone";
            this.phoneGV.MinimumWidth = 8;
            this.phoneGV.Name = "phoneGV";
            this.phoneGV.ReadOnly = true;
            // 
            // adressGV
            // 
            this.adressGV.HeaderText = "Adress";
            this.adressGV.MinimumWidth = 8;
            this.adressGV.Name = "adressGV";
            this.adressGV.ReadOnly = true;
            // 
            // emailGV
            // 
            this.emailGV.HeaderText = "Email";
            this.emailGV.MinimumWidth = 8;
            this.emailGV.Name = "emailGV";
            this.emailGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.MinimumWidth = 8;
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // adressTxt
            // 
            this.adressTxt.Location = new System.Drawing.Point(19, 367);
            this.adressTxt.Name = "adressTxt";
            this.adressTxt.Size = new System.Drawing.Size(291, 31);
            this.adressTxt.TabIndex = 8;
            this.adressTxt.TextChanged += new System.EventHandler(this.adressTxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Adress";
            // 
            // SuppliersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2154, 1210);
            this.Name = "SuppliersWindow";
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.SuppliersWindow_Load);
            this.panel5.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView supplierGV;
        private System.Windows.Forms.TextBox adressTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
    }
}