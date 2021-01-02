namespace WindowsFormsApp1
{
    partial class Frm_Search
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_FamilyName = new System.Windows.Forms.TextBox();
            this.txt_Age = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Caretaker = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_FileNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Grade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_NationalCode = new System.Windows.Forms.TextBox();
            this.rdo_girl = new System.Windows.Forms.RadioButton();
            this.rdo_boy = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Find = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "جست و جو بر اساس:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "نام",
            "نام خوانوادگی",
            "سن",
            "نام خوانوادگی سرپرست",
            "کد ملی",
            "شماره پرونده",
            "مقطع تحصیلی",
            "جنس"});
            this.comboBox1.Location = new System.Drawing.Point(290, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "نام خوانوادگی:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "سن:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(324, 75);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 21);
            this.txt_Name.TabIndex = 5;
            // 
            // txt_FamilyName
            // 
            this.txt_FamilyName.Location = new System.Drawing.Point(324, 101);
            this.txt_FamilyName.Name = "txt_FamilyName";
            this.txt_FamilyName.Size = new System.Drawing.Size(100, 21);
            this.txt_FamilyName.TabIndex = 6;
            // 
            // txt_Age
            // 
            this.txt_Age.Location = new System.Drawing.Point(324, 126);
            this.txt_Age.Name = "txt_Age";
            this.txt_Age.Size = new System.Drawing.Size(100, 21);
            this.txt_Age.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "نام خوانوادگی سرپرست:";
            // 
            // txt_Caretaker
            // 
            this.txt_Caretaker.Location = new System.Drawing.Point(324, 153);
            this.txt_Caretaker.Name = "txt_Caretaker";
            this.txt_Caretaker.Size = new System.Drawing.Size(100, 21);
            this.txt_Caretaker.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "شماره پرونده:";
            // 
            // txt_FileNo
            // 
            this.txt_FileNo.Location = new System.Drawing.Point(324, 207);
            this.txt_FileNo.Name = "txt_FileNo";
            this.txt_FileNo.Size = new System.Drawing.Size(100, 21);
            this.txt_FileNo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "مقطع تحصیلی:";
            // 
            // txt_Grade
            // 
            this.txt_Grade.Location = new System.Drawing.Point(324, 233);
            this.txt_Grade.Name = "txt_Grade";
            this.txt_Grade.Size = new System.Drawing.Size(100, 21);
            this.txt_Grade.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(438, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "جنس:";
            // 
            // txt_NationalCode
            // 
            this.txt_NationalCode.Location = new System.Drawing.Point(324, 180);
            this.txt_NationalCode.Name = "txt_NationalCode";
            this.txt_NationalCode.Size = new System.Drawing.Size(100, 21);
            this.txt_NationalCode.TabIndex = 7;
            // 
            // rdo_girl
            // 
            this.rdo_girl.AutoSize = true;
            this.rdo_girl.Location = new System.Drawing.Point(379, 263);
            this.rdo_girl.Name = "rdo_girl";
            this.rdo_girl.Size = new System.Drawing.Size(46, 17);
            this.rdo_girl.TabIndex = 8;
            this.rdo_girl.TabStop = true;
            this.rdo_girl.Text = "دختر";
            this.rdo_girl.UseVisualStyleBackColor = true;
            // 
            // rdo_boy
            // 
            this.rdo_boy.AutoSize = true;
            this.rdo_boy.Location = new System.Drawing.Point(324, 263);
            this.rdo_boy.Name = "rdo_boy";
            this.rdo_boy.Size = new System.Drawing.Size(45, 17);
            this.rdo_boy.TabIndex = 9;
            this.rdo_boy.TabStop = true;
            this.rdo_boy.Text = "پسر";
            this.rdo_boy.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(440, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "کد ملی:";
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(324, 287);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(100, 27);
            this.btn_Find.TabIndex = 10;
            this.btn_Find.Text = "پیدا کن";
            this.btn_Find.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 195);
            this.dataGridView1.TabIndex = 11;
            // 
            // frm_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 571);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.rdo_boy);
            this.Controls.Add(this.rdo_girl);
            this.Controls.Add(this.txt_NationalCode);
            this.Controls.Add(this.txt_Grade);
            this.Controls.Add(this.txt_FileNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Caretaker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Age);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_FamilyName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_Search";
            this.Opacity = 0.2D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frm_Search";
            this.Load += new System.EventHandler(this.Frm_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_FamilyName;
        private System.Windows.Forms.TextBox txt_Age;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Caretaker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_FileNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Grade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_NationalCode;
        private System.Windows.Forms.RadioButton rdo_girl;
        private System.Windows.Forms.RadioButton rdo_boy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}