namespace SW_AddressBook
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvAddresses = new System.Windows.Forms.DataGridView();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.buttonViewAll = new System.Windows.Forms.Button();
            this.labelSearchTerm = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.rdbState = new System.Windows.Forms.RadioButton();
            this.rdbCity = new System.Windows.Forms.RadioButton();
            this.rdbAddress = new System.Windows.Forms.RadioButton();
            this.rdbLastName = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.rdbFirstName = new System.Windows.Forms.RadioButton();
            this.control_AddAddress1 = new SW_AddressBook.controls.control_AddAddress();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddresses)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAddresses
            // 
            this.dgvAddresses.AllowUserToAddRows = false;
            this.dgvAddresses.AllowUserToDeleteRows = false;
            this.dgvAddresses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAddresses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddresses.Location = new System.Drawing.Point(267, 23);
            this.dgvAddresses.Name = "dgvAddresses";
            this.dgvAddresses.ReadOnly = true;
            this.dgvAddresses.RowHeadersVisible = false;
            this.dgvAddresses.Size = new System.Drawing.Size(1331, 575);
            this.dgvAddresses.TabIndex = 1;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxSearch.Controls.Add(this.buttonViewAll);
            this.groupBoxSearch.Controls.Add(this.labelSearchTerm);
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Controls.Add(this.rdbState);
            this.groupBoxSearch.Controls.Add(this.rdbCity);
            this.groupBoxSearch.Controls.Add(this.rdbAddress);
            this.groupBoxSearch.Controls.Add(this.rdbLastName);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.rdbFirstName);
            this.groupBoxSearch.Location = new System.Drawing.Point(13, 361);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(247, 237);
            this.groupBoxSearch.TabIndex = 2;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search By:";
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.Location = new System.Drawing.Point(166, 203);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(75, 23);
            this.buttonViewAll.TabIndex = 8;
            this.buttonViewAll.Text = "View All";
            this.buttonViewAll.UseVisualStyleBackColor = true;
            this.buttonViewAll.Click += new System.EventHandler(this.buttonViewAll_Click);
            // 
            // labelSearchTerm
            // 
            this.labelSearchTerm.AutoSize = true;
            this.labelSearchTerm.Location = new System.Drawing.Point(4, 132);
            this.labelSearchTerm.Name = "labelSearchTerm";
            this.labelSearchTerm.Size = new System.Drawing.Size(71, 13);
            this.labelSearchTerm.TabIndex = 7;
            this.labelSearchTerm.Text = "Search Term:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(7, 148);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(234, 20);
            this.textBoxSearch.TabIndex = 6;
            // 
            // rdbState
            // 
            this.rdbState.AutoSize = true;
            this.rdbState.Location = new System.Drawing.Point(7, 112);
            this.rdbState.Name = "rdbState";
            this.rdbState.Size = new System.Drawing.Size(50, 17);
            this.rdbState.TabIndex = 5;
            this.rdbState.Text = "State";
            this.rdbState.UseVisualStyleBackColor = true;
            // 
            // rdbCity
            // 
            this.rdbCity.AutoSize = true;
            this.rdbCity.Location = new System.Drawing.Point(7, 89);
            this.rdbCity.Name = "rdbCity";
            this.rdbCity.Size = new System.Drawing.Size(42, 17);
            this.rdbCity.TabIndex = 4;
            this.rdbCity.Text = "City";
            this.rdbCity.UseVisualStyleBackColor = true;
            // 
            // rdbAddress
            // 
            this.rdbAddress.AutoSize = true;
            this.rdbAddress.Location = new System.Drawing.Point(7, 66);
            this.rdbAddress.Name = "rdbAddress";
            this.rdbAddress.Size = new System.Drawing.Size(63, 17);
            this.rdbAddress.TabIndex = 3;
            this.rdbAddress.Text = "Address";
            this.rdbAddress.UseVisualStyleBackColor = true;
            // 
            // rdbLastName
            // 
            this.rdbLastName.AutoSize = true;
            this.rdbLastName.Location = new System.Drawing.Point(7, 43);
            this.rdbLastName.Name = "rdbLastName";
            this.rdbLastName.Size = new System.Drawing.Size(76, 17);
            this.rdbLastName.TabIndex = 2;
            this.rdbLastName.Text = "Last Name";
            this.rdbLastName.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(166, 174);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // rdbFirstName
            // 
            this.rdbFirstName.AutoSize = true;
            this.rdbFirstName.Checked = true;
            this.rdbFirstName.Location = new System.Drawing.Point(7, 20);
            this.rdbFirstName.Name = "rdbFirstName";
            this.rdbFirstName.Size = new System.Drawing.Size(75, 17);
            this.rdbFirstName.TabIndex = 0;
            this.rdbFirstName.TabStop = true;
            this.rdbFirstName.Text = "First Name";
            this.rdbFirstName.UseVisualStyleBackColor = true;
            // 
            // control_AddAddress1
            // 
            this.control_AddAddress1.Location = new System.Drawing.Point(13, 13);
            this.control_AddAddress1.Name = "control_AddAddress1";
            this.control_AddAddress1.Size = new System.Drawing.Size(247, 341);
            this.control_AddAddress1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 610);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.dgvAddresses);
            this.Controls.Add(this.control_AddAddress1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SW Address Book";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddresses)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private controls.control_AddAddress control_AddAddress1;
        private System.Windows.Forms.DataGridView dgvAddresses;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.RadioButton rdbLastName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.RadioButton rdbFirstName;
        private System.Windows.Forms.RadioButton rdbCity;
        private System.Windows.Forms.RadioButton rdbAddress;
        private System.Windows.Forms.RadioButton rdbState;
        private System.Windows.Forms.Label labelSearchTerm;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonViewAll;
    }
}

