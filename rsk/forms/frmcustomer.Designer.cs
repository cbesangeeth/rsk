namespace rsk
{
    partial class frmcustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.gbCustList = new System.Windows.Forms.GroupBox();
            this.lstCustomerlist = new System.Windows.Forms.ListBox();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.txtPhoneno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCustomercode = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCustomername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbAutono = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbCustList.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddnew);
            this.groupBox1.Controls.Add(this.gbCustList);
            this.groupBox1.Controls.Add(this.gbDetails);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Location = new System.Drawing.Point(24, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 403);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // btnAddnew
            // 
            this.btnAddnew.Location = new System.Drawing.Point(12, 363);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(75, 23);
            this.btnAddnew.TabIndex = 51;
            this.btnAddnew.Text = "Add New";
            this.btnAddnew.UseVisualStyleBackColor = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // gbCustList
            // 
            this.gbCustList.Controls.Add(this.lstCustomerlist);
            this.gbCustList.Location = new System.Drawing.Point(6, 27);
            this.gbCustList.Name = "gbCustList";
            this.gbCustList.Size = new System.Drawing.Size(198, 294);
            this.gbCustList.TabIndex = 50;
            this.gbCustList.TabStop = false;
            this.gbCustList.Text = "Customer List";
            // 
            // lstCustomerlist
            // 
            this.lstCustomerlist.FormattingEnabled = true;
            this.lstCustomerlist.HorizontalScrollbar = true;
            this.lstCustomerlist.Location = new System.Drawing.Point(6, 19);
            this.lstCustomerlist.Name = "lstCustomerlist";
            this.lstCustomerlist.ScrollAlwaysVisible = true;
            this.lstCustomerlist.Size = new System.Drawing.Size(186, 251);
            this.lstCustomerlist.TabIndex = 0;
            this.lstCustomerlist.SelectedIndexChanged += new System.EventHandler(this.lstCustomerlist_SelectedIndexChanged);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtPhoneno);
            this.gbDetails.Controls.Add(this.label3);
            this.gbDetails.Controls.Add(this.lbCustomercode);
            this.gbDetails.Controls.Add(this.txtAddress);
            this.gbDetails.Controls.Add(this.txtCustomername);
            this.gbDetails.Controls.Add(this.label5);
            this.gbDetails.Controls.Add(this.label2);
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Location = new System.Drawing.Point(211, 27);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(269, 294);
            this.gbDetails.TabIndex = 39;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // txtPhoneno
            // 
            this.txtPhoneno.Location = new System.Drawing.Point(96, 136);
            this.txtPhoneno.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneno.Name = "txtPhoneno";
            this.txtPhoneno.Size = new System.Drawing.Size(120, 20);
            this.txtPhoneno.TabIndex = 51;
            this.txtPhoneno.TextChanged += new System.EventHandler(this.txtPhoneno_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Phone Number";
            // 
            // lbCustomercode
            // 
            this.lbCustomercode.AutoSize = true;
            this.lbCustomercode.Location = new System.Drawing.Point(93, 53);
            this.lbCustomercode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCustomercode.Name = "lbCustomercode";
            this.lbCustomercode.Size = new System.Drawing.Size(52, 13);
            this.lbCustomercode.TabIndex = 49;
            this.lbCustomercode.Text = "xxxxxxxxx";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(94, 181);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(137, 58);
            this.txtAddress.TabIndex = 41;
            // 
            // txtCustomername
            // 
            this.txtCustomername.Location = new System.Drawing.Point(95, 94);
            this.txtCustomername.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomername.Name = "txtCustomername";
            this.txtCustomername.Size = new System.Drawing.Size(120, 20);
            this.txtCustomername.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Customer Code";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(170, 363);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(328, 363);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(407, 364);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(91, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbAutono
            // 
            this.cmbAutono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutono.FormattingEnabled = true;
            this.cmbAutono.Location = new System.Drawing.Point(24, 17);
            this.cmbAutono.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAutono.Name = "cmbAutono";
            this.cmbAutono.Size = new System.Drawing.Size(120, 21);
            this.cmbAutono.TabIndex = 56;
            this.cmbAutono.SelectedIndexChanged += new System.EventHandler(this.cmbAutono_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(189, 17);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(179, 26);
            this.label15.TabIndex = 55;
            this.label15.Text = "Customer Master";
            // 
            // frmcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 463);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbAutono);
            this.Controls.Add(this.label15);
            this.Name = "frmcustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcustomer";
            this.Load += new System.EventHandler(this.frmcustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbCustList.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.GroupBox gbCustList;
        private System.Windows.Forms.ListBox lstCustomerlist;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label lbCustomercode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCustomername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbAutono;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPhoneno;
        private System.Windows.Forms.Label label3;

    }
}