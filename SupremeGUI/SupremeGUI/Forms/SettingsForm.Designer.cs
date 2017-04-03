namespace SupremeGUI
{
    partial class SettingsForm
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
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.chckSize = new System.Windows.Forms.CheckBox();
            this.chckColor = new System.Windows.Forms.CheckBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstKeywords = new System.Windows.Forms.ListBox();
            this.txtAddress2 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.comboCountry = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtAddressThree = new System.Windows.Forms.TextBox();
            this.txtAddressTwo = new System.Windows.Forms.TextBox();
            this.txtAddressOne = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCVV2 = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.nmrcYear = new System.Windows.Forms.NumericUpDown();
            this.txtCcNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboCcType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.txtAddress2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcYear)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboCategory);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.chckSize);
            this.groupBox1.Controls.Add(this.chckColor);
            this.groupBox1.Controls.Add(this.txtKeyword);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstKeywords);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // txtSize
            // 
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(19, 191);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(126, 21);
            this.txtSize.TabIndex = 18;
            this.txtSize.Text = "medium";
            // 
            // txtColor
            // 
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(19, 154);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(126, 21);
            this.txtColor.TabIndex = 17;
            this.txtColor.Text = "black";
            // 
            // chckSize
            // 
            this.chckSize.AutoSize = true;
            this.chckSize.Location = new System.Drawing.Point(20, 176);
            this.chckSize.Name = "chckSize";
            this.chckSize.Size = new System.Drawing.Size(101, 17);
            this.chckSize.TabIndex = 16;
            this.chckSize.Text = "Size relevant";
            this.chckSize.UseVisualStyleBackColor = true;
            this.chckSize.CheckedChanged += new System.EventHandler(this.chckSize_CheckedChanged);
            // 
            // chckColor
            // 
            this.chckColor.AutoSize = true;
            this.chckColor.Location = new System.Drawing.Point(20, 139);
            this.chckColor.Name = "chckColor";
            this.chckColor.Size = new System.Drawing.Size(108, 17);
            this.chckColor.TabIndex = 15;
            this.chckColor.Text = "Color relevant";
            this.chckColor.UseVisualStyleBackColor = true;
            this.chckColor.CheckedChanged += new System.EventHandler(this.chckColor_CheckedChanged);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(18, 91);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(126, 21);
            this.txtKeyword.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Keywords";
            // 
            // lstKeywords
            // 
            this.lstKeywords.FormattingEnabled = true;
            this.lstKeywords.Location = new System.Drawing.Point(18, 33);
            this.lstKeywords.Name = "lstKeywords";
            this.lstKeywords.Size = new System.Drawing.Size(126, 56);
            this.lstKeywords.TabIndex = 3;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Controls.Add(this.txtEmail);
            this.txtAddress2.Controls.Add(this.txtTelephone);
            this.txtAddress2.Controls.Add(this.comboCountry);
            this.txtAddress2.Controls.Add(this.txtCity);
            this.txtAddress2.Controls.Add(this.txtZipCode);
            this.txtAddress2.Controls.Add(this.txtAddressThree);
            this.txtAddress2.Controls.Add(this.txtAddressTwo);
            this.txtAddress2.Controls.Add(this.txtAddressOne);
            this.txtAddress2.Controls.Add(this.txtFullName);
            this.txtAddress2.Controls.Add(this.label7);
            this.txtAddress2.Controls.Add(this.label8);
            this.txtAddress2.Controls.Add(this.label11);
            this.txtAddress2.Controls.Add(this.label9);
            this.txtAddress2.Controls.Add(this.label6);
            this.txtAddress2.Controls.Add(this.label5);
            this.txtAddress2.Controls.Add(this.label10);
            this.txtAddress2.Controls.Add(this.label3);
            this.txtAddress2.Controls.Add(this.label4);
            this.txtAddress2.Location = new System.Drawing.Point(181, 12);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(287, 221);
            this.txtAddress2.TabIndex = 1;
            this.txtAddress2.TabStop = false;
            this.txtAddress2.Text = "Billing";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(127, 190);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 21);
            this.txtEmail.TabIndex = 14;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(127, 168);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(146, 21);
            this.txtTelephone.TabIndex = 13;
            // 
            // comboCountry
            // 
            this.comboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCountry.FormattingEnabled = true;
            this.comboCountry.Items.AddRange(new object[] {
            "United Kingdom (UK)",
            "Austria (AT)",
            "Belarus (BY)",
            "Belgium (BE)",
            "Bulgaria (BG)",
            "Croatia (HR)",
            "Czech Republic (CZ)",
            "Denmark (DK)",
            "Estonia (EE)",
            "Finland (FI)",
            "France (FR)",
            "Germany (DE)",
            "Greece (GR)",
            "Hungary (HU)",
            "Iceland (IS)",
            "Ireland (IE)",
            "Italy (IT)",
            "Latvia (LV)",
            "Lithuania (LT)",
            "Luxembourg (LU)",
            "Monaco (MC)",
            "Netherlands (NL)",
            "Norway (NO)",
            "Poland (PL)",
            "Portugal (PT)",
            "Romania (RO)",
            "Russia (RU)",
            "Slovakia (SK)",
            "Slovenia (SI)",
            "Spain (ES)",
            "Sweden (SE)",
            "Switzerland (CH)",
            "Turkey (TR)"});
            this.comboCountry.Location = new System.Drawing.Point(127, 146);
            this.comboCountry.Name = "comboCountry";
            this.comboCountry.Size = new System.Drawing.Size(146, 21);
            this.comboCountry.TabIndex = 12;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(127, 123);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(146, 21);
            this.txtCity.TabIndex = 11;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(127, 101);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(146, 21);
            this.txtZipCode.TabIndex = 10;
            // 
            // txtAddressThree
            // 
            this.txtAddressThree.Location = new System.Drawing.Point(127, 79);
            this.txtAddressThree.Name = "txtAddressThree";
            this.txtAddressThree.Size = new System.Drawing.Size(146, 21);
            this.txtAddressThree.TabIndex = 9;
            // 
            // txtAddressTwo
            // 
            this.txtAddressTwo.Location = new System.Drawing.Point(127, 57);
            this.txtAddressTwo.Name = "txtAddressTwo";
            this.txtAddressTwo.Size = new System.Drawing.Size(146, 21);
            this.txtAddressTwo.TabIndex = 8;
            // 
            // txtAddressOne
            // 
            this.txtAddressOne.Location = new System.Drawing.Point(127, 35);
            this.txtAddressOne.Name = "txtAddressOne";
            this.txtAddressOne.Size = new System.Drawing.Size(146, 21);
            this.txtAddressOne.TabIndex = 7;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(127, 14);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(146, 21);
            this.txtFullName.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "E-Mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Telephone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Full Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Address 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Zip Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCVV2);
            this.groupBox3.Controls.Add(this.txtMonth);
            this.groupBox3.Controls.Add(this.nmrcYear);
            this.groupBox3.Controls.Add(this.txtCcNumber);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.comboCcType);
            this.groupBox3.Location = new System.Drawing.Point(474, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 117);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment";
            // 
            // txtCVV2
            // 
            this.txtCVV2.Location = new System.Drawing.Point(264, 79);
            this.txtCVV2.Name = "txtCVV2";
            this.txtCVV2.Size = new System.Drawing.Size(34, 21);
            this.txtCVV2.TabIndex = 16;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(208, 57);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(30, 21);
            this.txtMonth.TabIndex = 15;
            this.txtMonth.Text = "04";
            // 
            // nmrcYear
            // 
            this.nmrcYear.Location = new System.Drawing.Point(238, 57);
            this.nmrcYear.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.nmrcYear.Minimum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.nmrcYear.Name = "nmrcYear";
            this.nmrcYear.Size = new System.Drawing.Size(60, 21);
            this.nmrcYear.TabIndex = 14;
            this.nmrcYear.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // txtCcNumber
            // 
            this.txtCcNumber.Location = new System.Drawing.Point(158, 35);
            this.txtCcNumber.Name = "txtCcNumber";
            this.txtCcNumber.Size = new System.Drawing.Size(140, 21);
            this.txtCcNumber.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "CVV2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Expires";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Credit Card Type";
            // 
            // comboCcType
            // 
            this.comboCcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCcType.FormattingEnabled = true;
            this.comboCcType.Items.AddRange(new object[] {
            "VISA",
            "MasterCard",
            "American Express"});
            this.comboCcType.Location = new System.Drawing.Point(158, 14);
            this.comboCcType.Name = "comboCcType";
            this.comboCcType.Size = new System.Drawing.Size(140, 21);
            this.comboCcType.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Every single keyword must appear on the\r\nproduct site for the article to be found" +
    ".";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(474, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notes";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Tomato;
            this.label16.Location = new System.Drawing.Point(6, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(204, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Do not use special characters.";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 236);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(766, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboCategory
            // 
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "all",
            "new",
            "jackets",
            "topssweaters",
            "sweatshirts",
            "hats",
            "bags",
            "pants",
            "accessories",
            "skate"});
            this.comboCategory.Location = new System.Drawing.Point(99, 0);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(64, 21);
            this.comboCategory.TabIndex = 15;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 266);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.txtAddress2.ResumeLayout(false);
            this.txtAddress2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcYear)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstKeywords;
        private System.Windows.Forms.GroupBox txtAddress2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddressTwo;
        private System.Windows.Forms.TextBox txtAddressOne;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddressThree;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.ComboBox comboCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtCVV2;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.NumericUpDown nmrcYear;
        private System.Windows.Forms.TextBox txtCcNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboCcType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.CheckBox chckSize;
        private System.Windows.Forms.CheckBox chckColor;
        private System.Windows.Forms.ComboBox comboCategory;
    }
}