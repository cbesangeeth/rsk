namespace rsk
{
    partial class frmitem
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
            this.gbItemlist = new System.Windows.Forms.GroupBox();
            this.lstItembox = new System.Windows.Forms.ListBox();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.btnTaxld = new System.Windows.Forms.Button();
            this.btnGroupld = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMinimumOrderQty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReorderqty = new System.Windows.Forms.TextBox();
            this.lbItemcode = new System.Windows.Forms.Label();
            this.lbPurchaseprice = new System.Windows.Forms.Label();
            this.cmbTax = new System.Windows.Forms.ComboBox();
            this.cmbgroup = new System.Windows.Forms.ComboBox();
            this.txtSellingprice = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtItemname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbAutono = new System.Windows.Forms.ComboBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.gbItemlist.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddnew);
            this.groupBox1.Controls.Add(this.gbItemlist);
            this.groupBox1.Controls.Add(this.gbDetails);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAddnew
            // 
            this.btnAddnew.Location = new System.Drawing.Point(21, 421);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(75, 23);
            this.btnAddnew.TabIndex = 51;
            this.btnAddnew.Text = "Add New";
            this.btnAddnew.UseVisualStyleBackColor = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // gbItemlist
            // 
            this.gbItemlist.Controls.Add(this.lstItembox);
            this.gbItemlist.Location = new System.Drawing.Point(6, 27);
            this.gbItemlist.Name = "gbItemlist";
            this.gbItemlist.Size = new System.Drawing.Size(198, 370);
            this.gbItemlist.TabIndex = 50;
            this.gbItemlist.TabStop = false;
            this.gbItemlist.Text = "Items";
            // 
            // lstItembox
            // 
            this.lstItembox.FormattingEnabled = true;
            this.lstItembox.HorizontalScrollbar = true;
            this.lstItembox.Location = new System.Drawing.Point(6, 19);
            this.lstItembox.Name = "lstItembox";
            this.lstItembox.ScrollAlwaysVisible = true;
            this.lstItembox.Size = new System.Drawing.Size(186, 342);
            this.lstItembox.TabIndex = 0;
            this.lstItembox.SelectedIndexChanged += new System.EventHandler(this.lstItembox_SelectedIndexChanged);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.btnTaxld);
            this.gbDetails.Controls.Add(this.btnGroupld);
            this.gbDetails.Controls.Add(this.groupBox4);
            this.gbDetails.Controls.Add(this.lbItemcode);
            this.gbDetails.Controls.Add(this.lbPurchaseprice);
            this.gbDetails.Controls.Add(this.cmbTax);
            this.gbDetails.Controls.Add(this.cmbgroup);
            this.gbDetails.Controls.Add(this.txtSellingprice);
            this.gbDetails.Controls.Add(this.txtRate);
            this.gbDetails.Controls.Add(this.txtDesc);
            this.gbDetails.Controls.Add(this.txtItemname);
            this.gbDetails.Controls.Add(this.label9);
            this.gbDetails.Controls.Add(this.label8);
            this.gbDetails.Controls.Add(this.label7);
            this.gbDetails.Controls.Add(this.label3);
            this.gbDetails.Controls.Add(this.label6);
            this.gbDetails.Controls.Add(this.label5);
            this.gbDetails.Controls.Add(this.label2);
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Location = new System.Drawing.Point(211, 27);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(540, 370);
            this.gbDetails.TabIndex = 39;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            this.gbDetails.Enter += new System.EventHandler(this.gbDetails_Enter);
            // 
            // btnTaxld
            // 
            this.btnTaxld.Image = global::rsk.Properties.Resources.icon_games_small_mdpi;
            this.btnTaxld.Location = new System.Drawing.Point(507, 86);
            this.btnTaxld.Name = "btnTaxld";
            this.btnTaxld.Size = new System.Drawing.Size(26, 28);
            this.btnTaxld.TabIndex = 51;
            this.btnTaxld.UseVisualStyleBackColor = true;
            this.btnTaxld.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnGroupld
            // 
            this.btnGroupld.Image = global::rsk.Properties.Resources.icon_games_small_mdpi;
            this.btnGroupld.Location = new System.Drawing.Point(217, 136);
            this.btnGroupld.Name = "btnGroupld";
            this.btnGroupld.Size = new System.Drawing.Size(26, 28);
            this.btnGroupld.TabIndex = 46;
            this.btnGroupld.UseVisualStyleBackColor = true;
            this.btnGroupld.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMinimumOrderQty);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtReorderqty);
            this.groupBox4.Location = new System.Drawing.Point(14, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(497, 83);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            // 
            // txtMinimumOrderQty
            // 
            this.txtMinimumOrderQty.Location = new System.Drawing.Point(361, 30);
            this.txtMinimumOrderQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtMinimumOrderQty.Name = "txtMinimumOrderQty";
            this.txtMinimumOrderQty.Size = new System.Drawing.Size(120, 20);
            this.txtMinimumOrderQty.TabIndex = 45;
            this.txtMinimumOrderQty.TextChanged += new System.EventHandler(this.txtMinimumOrderQty_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 35);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "ReOrder Qty";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Minimum Order Qty";
            // 
            // txtReorderqty
            // 
            this.txtReorderqty.Location = new System.Drawing.Point(85, 32);
            this.txtReorderqty.Margin = new System.Windows.Forms.Padding(2);
            this.txtReorderqty.Name = "txtReorderqty";
            this.txtReorderqty.Size = new System.Drawing.Size(120, 20);
            this.txtReorderqty.TabIndex = 44;
            this.txtReorderqty.TextChanged += new System.EventHandler(this.txtReorderqty_TextChanged);
            // 
            // lbItemcode
            // 
            this.lbItemcode.AutoSize = true;
            this.lbItemcode.Location = new System.Drawing.Point(93, 53);
            this.lbItemcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbItemcode.Name = "lbItemcode";
            this.lbItemcode.Size = new System.Drawing.Size(52, 13);
            this.lbItemcode.TabIndex = 49;
            this.lbItemcode.Text = "xxxxxxxxx";
            // 
            // lbPurchaseprice
            // 
            this.lbPurchaseprice.AutoSize = true;
            this.lbPurchaseprice.Location = new System.Drawing.Point(380, 134);
            this.lbPurchaseprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPurchaseprice.Name = "lbPurchaseprice";
            this.lbPurchaseprice.Size = new System.Drawing.Size(52, 13);
            this.lbPurchaseprice.TabIndex = 48;
            this.lbPurchaseprice.Text = "xxxxxxxxx";
            this.lbPurchaseprice.Click += new System.EventHandler(this.lbPurchaseprice_Click);
            // 
            // cmbTax
            // 
            this.cmbTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTax.FormattingEnabled = true;
            this.cmbTax.Location = new System.Drawing.Point(383, 91);
            this.cmbTax.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTax.Name = "cmbTax";
            this.cmbTax.Size = new System.Drawing.Size(120, 21);
            this.cmbTax.TabIndex = 47;
            this.cmbTax.SelectedIndexChanged += new System.EventHandler(this.cmbTax_SelectedIndexChanged);
            // 
            // cmbgroup
            // 
            this.cmbgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgroup.FormattingEnabled = true;
            this.cmbgroup.Location = new System.Drawing.Point(95, 140);
            this.cmbgroup.Margin = new System.Windows.Forms.Padding(2);
            this.cmbgroup.Name = "cmbgroup";
            this.cmbgroup.Size = new System.Drawing.Size(120, 21);
            this.cmbgroup.TabIndex = 46;
            this.cmbgroup.SelectedIndexChanged += new System.EventHandler(this.cmbgroup_click);
            // 
            // txtSellingprice
            // 
            this.txtSellingprice.Location = new System.Drawing.Point(383, 172);
            this.txtSellingprice.Margin = new System.Windows.Forms.Padding(2);
            this.txtSellingprice.Name = "txtSellingprice";
            this.txtSellingprice.Size = new System.Drawing.Size(120, 20);
            this.txtSellingprice.TabIndex = 43;
            this.txtSellingprice.TextChanged += new System.EventHandler(this.txtSellingprice_TextChanged);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(383, 50);
            this.txtRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(120, 20);
            this.txtRate.TabIndex = 42;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(94, 181);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(137, 58);
            this.txtDesc.TabIndex = 41;
            // 
            // txtItemname
            // 
            this.txtItemname.Location = new System.Drawing.Point(95, 94);
            this.txtItemname.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemname.Name = "txtItemname";
            this.txtItemname.Size = new System.Drawing.Size(120, 20);
            this.txtItemname.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 173);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Selling Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Purchase Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tax %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Group Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Descripition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Item Code";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(267, 421);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(513, 421);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(636, 420);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(144, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(390, 421);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(327, 7);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 26);
            this.label15.TabIndex = 38;
            this.label15.Text = "Item Master";
            // 
            // cmbAutono
            // 
            this.cmbAutono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutono.FormattingEnabled = true;
            this.cmbAutono.Location = new System.Drawing.Point(12, 12);
            this.cmbAutono.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAutono.Name = "cmbAutono";
            this.cmbAutono.Size = new System.Drawing.Size(120, 21);
            this.cmbAutono.TabIndex = 52;
            this.cmbAutono.SelectedIndexChanged += new System.EventHandler(this.cmbAutono_SelectedIndexChanged);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::rsk.Properties.Resources.basket;
            this.PictureBox1.Location = new System.Drawing.Point(278, 6);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(50, 43);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 53;
            this.PictureBox1.TabStop = false;
            // 
            // frmitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 498);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.cmbAutono);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmitem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Master";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbItemlist.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbItemlist;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label lbItemcode;
        private System.Windows.Forms.Label lbPurchaseprice;
        private System.Windows.Forms.ComboBox cmbTax;
        private System.Windows.Forms.ComboBox cmbgroup;
        private System.Windows.Forms.TextBox txtMinimumOrderQty;
        private System.Windows.Forms.TextBox txtReorderqty;
        private System.Windows.Forms.TextBox txtSellingprice;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtItemname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnGroupld;
        private System.Windows.Forms.Button btnTaxld;
        private System.Windows.Forms.ListBox lstItembox;
        private System.Windows.Forms.ComboBox cmbAutono;
        internal System.Windows.Forms.PictureBox PictureBox1;


    }
}