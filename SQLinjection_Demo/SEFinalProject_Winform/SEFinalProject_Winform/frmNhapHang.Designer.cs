﻿namespace SEFinalProject_Winform
{
    partial class frmNhapHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numberProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbProUseDate = new System.Windows.Forms.DateTimePicker();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.picturePro = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rtbProDes = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbProPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbProBrand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbProType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProOrigin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbImportID = new System.Windows.Forms.Label();
            this.tbImportDate = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numberProductQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(403, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU NHẬP HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thêm sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sản phẩm";
            // 
            // tbProductID
            // 
            this.tbProductID.Location = new System.Drawing.Point(129, 158);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.Size = new System.Drawing.Size(136, 20);
            this.tbProductID.TabIndex = 3;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(376, 154);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(286, 20);
            this.tbProductName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên sản phẩm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(675, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Số lượng thêm";
            // 
            // numberProductQuantity
            // 
            this.numberProductQuantity.Location = new System.Drawing.Point(773, 154);
            this.numberProductQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberProductQuantity.Name = "numberProductQuantity";
            this.numberProductQuantity.Size = new System.Drawing.Size(53, 20);
            this.numberProductQuantity.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbProUseDate);
            this.groupBox1.Controls.Add(this.btnChooseImage);
            this.groupBox1.Controls.Add(this.picturePro);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.rtbProDes);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbProPrice);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbProBrand);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbProType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbProOrigin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(30, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 255);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết sản phẩm";
            // 
            // tbProUseDate
            // 
            this.tbProUseDate.Location = new System.Drawing.Point(124, 107);
            this.tbProUseDate.Margin = new System.Windows.Forms.Padding(2);
            this.tbProUseDate.Name = "tbProUseDate";
            this.tbProUseDate.Size = new System.Drawing.Size(218, 20);
            this.tbProUseDate.TabIndex = 31;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(394, 98);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(89, 39);
            this.btnChooseImage.TabIndex = 30;
            this.btnChooseImage.Text = "Thêm ảnh";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Clicked);
            // 
            // picturePro
            // 
            this.picturePro.BackgroundImage = global::SEFinalProject_Winform.Properties.Resources.icon_noimage;
            this.picturePro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picturePro.Location = new System.Drawing.Point(500, 29);
            this.picturePro.Name = "picturePro";
            this.picturePro.Size = new System.Drawing.Size(117, 134);
            this.picturePro.TabIndex = 29;
            this.picturePro.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(391, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Ảnh sản phẩm";
            // 
            // rtbProDes
            // 
            this.rtbProDes.Location = new System.Drawing.Point(124, 159);
            this.rtbProDes.Name = "rtbProDes";
            this.rtbProDes.Size = new System.Drawing.Size(218, 90);
            this.rtbProDes.TabIndex = 27;
            this.rtbProDes.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Mô tả sản phẩm";
            // 
            // tbProPrice
            // 
            this.tbProPrice.Location = new System.Drawing.Point(124, 133);
            this.tbProPrice.Name = "tbProPrice";
            this.tbProPrice.Size = new System.Drawing.Size(218, 20);
            this.tbProPrice.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Đơn giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Hạn sử dụng";
            // 
            // tbProBrand
            // 
            this.tbProBrand.Location = new System.Drawing.Point(124, 81);
            this.tbProBrand.Name = "tbProBrand";
            this.tbProBrand.Size = new System.Drawing.Size(218, 20);
            this.tbProBrand.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Hãng";
            // 
            // tbProType
            // 
            this.tbProType.Location = new System.Drawing.Point(124, 55);
            this.tbProType.Name = "tbProType";
            this.tbProType.Size = new System.Drawing.Size(218, 20);
            this.tbProType.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Loại ";
            // 
            // tbProOrigin
            // 
            this.tbProOrigin.Location = new System.Drawing.Point(124, 29);
            this.tbProOrigin.Name = "tbProOrigin";
            this.tbProOrigin.Size = new System.Drawing.Size(218, 20);
            this.tbProOrigin.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nguồn gốc";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Chọn ảnh của bạn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(91, 500);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(238, 31);
            this.label13.TabIndex = 19;
            this.label13.Text = "Sản phẩm sẵn có";
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddNew.Location = new System.Drawing.Point(30, 463);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(184, 34);
            this.btnAddNew.TabIndex = 20;
            this.btnAddNew.Text = "Thêm sản phẩm mới";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.addNewProduct);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(97, 546);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1172, 135);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadCellContent);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(566, 463);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 34);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_clicked);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(300, 463);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(184, 34);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.updateProduct);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(769, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(223, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Dữ liệu phiếu nhập hiện tại";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(998, 208);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Mã phiếu nhập";
            // 
            // tbImportID
            // 
            this.tbImportID.AutoSize = true;
            this.tbImportID.Location = new System.Drawing.Point(1082, 208);
            this.tbImportID.Name = "tbImportID";
            this.tbImportID.Size = new System.Drawing.Size(34, 13);
            this.tbImportID.TabIndex = 26;
            this.tbImportID.Text = "I0010";
            // 
            // tbImportDate
            // 
            this.tbImportDate.AutoSize = true;
            this.tbImportDate.Location = new System.Drawing.Point(1211, 208);
            this.tbImportDate.Name = "tbImportDate";
            this.tbImportDate.Size = new System.Drawing.Size(65, 13);
            this.tbImportDate.TabIndex = 28;
            this.tbImportDate.Text = "12/12/2022";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1146, 208);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Ngày nhập";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(773, 230);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(558, 226);
            this.dataGridView2.TabIndex = 29;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 693);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tbImportDate);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbImportID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numberProductQuantity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbProductID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNhapHang";
            this.Text = "Phiếu nhập";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberProductQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numberProductQuantity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picturePro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rtbProDes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbProPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbProBrand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbProType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbProOrigin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.DateTimePicker tbProUseDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label tbImportID;
        private System.Windows.Forms.Label tbImportDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}