namespace WindowsFormsApp1
{
    partial class Frm_Relateds
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimeSelector_BirthDate = new Atf.UI.DateTimeSelector();
            this.txt_HealthState = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Relateds = new System.Windows.Forms.ComboBox();
            this.txt_Grade = new DevExpress.XtraEditors.TextEdit();
            this.label28 = new System.Windows.Forms.Label();
            this.txt_MaritalState = new DevExpress.XtraEditors.TextEdit();
            this.label27 = new System.Windows.Forms.Label();
            this.txt_FatherName = new DevExpress.XtraEditors.TextEdit();
            this.label26 = new System.Windows.Forms.Label();
            this.txt_FamilyName = new DevExpress.XtraEditors.TextEdit();
            this.txt_r_Description = new System.Windows.Forms.RichTextBox();
            this.txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_NationalCode = new DevExpress.XtraEditors.TextEdit();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HealthState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Grade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaritalState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FatherName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FamilyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NationalCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimeSelector_BirthDate);
            this.groupBox4.Controls.Add(this.txt_HealthState);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cmb_Relateds);
            this.groupBox4.Controls.Add(this.txt_Grade);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.txt_MaritalState);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.txt_FatherName);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.txt_FamilyName);
            this.groupBox4.Controls.Add(this.txt_r_Description);
            this.groupBox4.Controls.Add(this.txt_Name);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.txt_NationalCode);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Location = new System.Drawing.Point(181, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 462);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "اطلاعات وابستگان";
            // 
            // dateTimeSelector_BirthDate
            // 
            this.dateTimeSelector_BirthDate.Location = new System.Drawing.Point(10, 224);
            this.dateTimeSelector_BirthDate.Name = "dateTimeSelector_BirthDate";
            this.dateTimeSelector_BirthDate.Size = new System.Drawing.Size(111, 22);
            this.dateTimeSelector_BirthDate.TabIndex = 54;
            this.dateTimeSelector_BirthDate.UsePersianFormat = true;
            // 
            // txt_HealthState
            // 
            this.txt_HealthState.Location = new System.Drawing.Point(9, 257);
            this.txt_HealthState.Name = "txt_HealthState";
            this.txt_HealthState.Size = new System.Drawing.Size(112, 20);
            this.txt_HealthState.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "کد ملی مددجو:";
            // 
            // cmb_Relateds
            // 
            this.cmb_Relateds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Relateds.FormattingEnabled = true;
            this.cmb_Relateds.Items.AddRange(new object[] {
            "مادر",
            "پدر",
            "برادر",
            "خواهر",
            "دایی",
            "عمو",
            "عمه",
            "خاله",
            "سایر"});
            this.cmb_Relateds.Location = new System.Drawing.Point(9, 54);
            this.cmb_Relateds.Name = "cmb_Relateds";
            this.cmb_Relateds.Size = new System.Drawing.Size(112, 21);
            this.cmb_Relateds.TabIndex = 24;
            // 
            // txt_Grade
            // 
            this.txt_Grade.Location = new System.Drawing.Point(9, 199);
            this.txt_Grade.Name = "txt_Grade";
            this.txt_Grade.Size = new System.Drawing.Size(112, 20);
            this.txt_Grade.TabIndex = 49;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(133, 295);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(65, 20);
            this.label28.TabIndex = 15;
            this.label28.Text = "توضیحات:";
            // 
            // txt_MaritalState
            // 
            this.txt_MaritalState.Location = new System.Drawing.Point(9, 173);
            this.txt_MaritalState.Name = "txt_MaritalState";
            this.txt_MaritalState.Size = new System.Drawing.Size(112, 20);
            this.txt_MaritalState.TabIndex = 49;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(133, 255);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(98, 20);
            this.label27.TabIndex = 14;
            this.label27.Text = "وضعیت جسمانی:";
            // 
            // txt_FatherName
            // 
            this.txt_FatherName.Location = new System.Drawing.Point(9, 144);
            this.txt_FatherName.Name = "txt_FatherName";
            this.txt_FatherName.Size = new System.Drawing.Size(112, 20);
            this.txt_FatherName.TabIndex = 49;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(133, 226);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 20);
            this.label26.TabIndex = 13;
            this.label26.Text = "تاریخ تولد:";
            // 
            // txt_FamilyName
            // 
            this.txt_FamilyName.Location = new System.Drawing.Point(9, 115);
            this.txt_FamilyName.Name = "txt_FamilyName";
            this.txt_FamilyName.Size = new System.Drawing.Size(112, 20);
            this.txt_FamilyName.TabIndex = 49;
            // 
            // txt_r_Description
            // 
            this.txt_r_Description.Location = new System.Drawing.Point(9, 281);
            this.txt_r_Description.Name = "txt_r_Description";
            this.txt_r_Description.Size = new System.Drawing.Size(118, 45);
            this.txt_r_Description.TabIndex = 4;
            this.txt_r_Description.Text = "";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(10, 86);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(112, 20);
            this.txt_Name.TabIndex = 49;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(133, 197);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 20);
            this.label25.TabIndex = 12;
            this.label25.Text = "تحصیلات:";
            // 
            // txt_NationalCode
            // 
            this.txt_NationalCode.Location = new System.Drawing.Point(9, 20);
            this.txt_NationalCode.Name = "txt_NationalCode";
            this.txt_NationalCode.Properties.Mask.EditMask = "\\d{10}";
            this.txt_NationalCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txt_NationalCode.Size = new System.Drawing.Size(112, 20);
            this.txt_NationalCode.TabIndex = 49;
            this.txt_NationalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NationalCode_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(133, 168);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(82, 20);
            this.label24.TabIndex = 11;
            this.label24.Text = "وضعیت تاهل:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(133, 139);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(47, 20);
            this.label23.TabIndex = 10;
            this.label23.Text = "نام پدر:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(133, 110);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 20);
            this.label22.TabIndex = 9;
            this.label22.Text = "نام خوانوادگی:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(133, 81);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 20);
            this.label21.TabIndex = 8;
            this.label21.Text = "نام:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(133, 52);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 20);
            this.label20.TabIndex = 7;
            this.label20.Text = "نسبیت:";
            // 
            // Frm_Relateds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 486);
            this.Controls.Add(this.groupBox4);
            this.Name = "Frm_Relateds";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frm_Relateds";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HealthState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Grade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaritalState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FatherName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FamilyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NationalCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.RichTextBox txt_r_Description;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmb_Relateds;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_NationalCode;
        private DevExpress.XtraEditors.TextEdit txt_Name;
        private DevExpress.XtraEditors.TextEdit txt_FamilyName;
        private DevExpress.XtraEditors.TextEdit txt_FatherName;
        private DevExpress.XtraEditors.TextEdit txt_MaritalState;
        private DevExpress.XtraEditors.TextEdit txt_Grade;
        private DevExpress.XtraEditors.TextEdit txt_HealthState;
        private Atf.UI.DateTimeSelector dateTimeSelector_BirthDate;
    }
}