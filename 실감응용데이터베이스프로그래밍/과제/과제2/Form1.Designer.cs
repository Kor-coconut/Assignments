namespace StudentManagement
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoadStudentInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonStudent1Delete = new System.Windows.Forms.Button();
            this.textBoxNotePad1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonStudent1Save = new System.Windows.Forms.Button();
            this.comboBoxStudent1Gender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStudent1ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStudent1Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxNotePad2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonStudent2Delete = new System.Windows.Forms.Button();
            this.buttonStudent2Save = new System.Windows.Forms.Button();
            this.comboBoxStudent2Gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStudent2ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStudent2Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxNotePad3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonStudent3Delete = new System.Windows.Forms.Button();
            this.buttonStudent3Save = new System.Windows.Forms.Button();
            this.comboBoxStudent3Gender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxStudent3ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxStudent3Name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LabelSaveStudentInfoCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBoxAutoStudentInfoLoad = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadStudentInfo
            // 
            this.buttonLoadStudentInfo.Location = new System.Drawing.Point(27, 11);
            this.buttonLoadStudentInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoadStudentInfo.Name = "buttonLoadStudentInfo";
            this.buttonLoadStudentInfo.Size = new System.Drawing.Size(166, 74);
            this.buttonLoadStudentInfo.TabIndex = 0;
            this.buttonLoadStudentInfo.Text = "학생정보 불러오기";
            this.buttonLoadStudentInfo.UseVisualStyleBackColor = true;
            this.buttonLoadStudentInfo.Click += new System.EventHandler(this.buttonLoadStudentInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonStudent1Delete);
            this.groupBox1.Controls.Add(this.textBoxNotePad1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.buttonStudent1Save);
            this.groupBox1.Controls.Add(this.comboBoxStudent1Gender);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxStudent1ID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxStudent1Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(166, 289);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 학생1";
            // 
            // buttonStudent1Delete
            // 
            this.buttonStudent1Delete.Location = new System.Drawing.Point(66, 255);
            this.buttonStudent1Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStudent1Delete.Name = "buttonStudent1Delete";
            this.buttonStudent1Delete.Size = new System.Drawing.Size(88, 21);
            this.buttonStudent1Delete.TabIndex = 9;
            this.buttonStudent1Delete.Text = "삭제";
            this.buttonStudent1Delete.UseVisualStyleBackColor = true;
            this.buttonStudent1Delete.Click += new System.EventHandler(this.buttonStudent1Delete_Click);
            // 
            // textBoxNotePad1
            // 
            this.textBoxNotePad1.Location = new System.Drawing.Point(66, 94);
            this.textBoxNotePad1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNotePad1.Multiline = true;
            this.textBoxNotePad1.Name = "textBoxNotePad1";
            this.textBoxNotePad1.Size = new System.Drawing.Size(88, 109);
            this.textBoxNotePad1.TabIndex = 8;
            this.textBoxNotePad1.TextChanged += new System.EventHandler(this.textBoxNotePad1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "메모";
            // 
            // buttonStudent1Save
            // 
            this.buttonStudent1Save.Location = new System.Drawing.Point(66, 221);
            this.buttonStudent1Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStudent1Save.Name = "buttonStudent1Save";
            this.buttonStudent1Save.Size = new System.Drawing.Size(88, 21);
            this.buttonStudent1Save.TabIndex = 6;
            this.buttonStudent1Save.Text = "저장";
            this.buttonStudent1Save.UseVisualStyleBackColor = true;
            this.buttonStudent1Save.Click += new System.EventHandler(this.buttonStudent1Save_Click);
            // 
            // comboBoxStudent1Gender
            // 
            this.comboBoxStudent1Gender.FormattingEnabled = true;
            this.comboBoxStudent1Gender.Items.AddRange(new object[] {
            "남자",
            "여자"});
            this.comboBoxStudent1Gender.Location = new System.Drawing.Point(66, 70);
            this.comboBoxStudent1Gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStudent1Gender.Name = "comboBoxStudent1Gender";
            this.comboBoxStudent1Gender.Size = new System.Drawing.Size(88, 20);
            this.comboBoxStudent1Gender.TabIndex = 5;
            this.comboBoxStudent1Gender.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudent1Gender_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "성별";
            // 
            // textBoxStudent1ID
            // 
            this.textBoxStudent1ID.Location = new System.Drawing.Point(66, 45);
            this.textBoxStudent1ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStudent1ID.Name = "textBoxStudent1ID";
            this.textBoxStudent1ID.Size = new System.Drawing.Size(88, 21);
            this.textBoxStudent1ID.TabIndex = 3;
            this.textBoxStudent1ID.TextChanged += new System.EventHandler(this.textBoxStudent1ID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "학번";
            // 
            // textBoxStudent1Name
            // 
            this.textBoxStudent1Name.Location = new System.Drawing.Point(66, 20);
            this.textBoxStudent1Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStudent1Name.Name = "textBoxStudent1Name";
            this.textBoxStudent1Name.Size = new System.Drawing.Size(88, 21);
            this.textBoxStudent1Name.TabIndex = 1;
            this.textBoxStudent1Name.Text = "학생정보 없음";
            this.textBoxStudent1Name.TextChanged += new System.EventHandler(this.textBoxStudent1Name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxNotePad2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.buttonStudent2Delete);
            this.groupBox2.Controls.Add(this.buttonStudent2Save);
            this.groupBox2.Controls.Add(this.comboBoxStudent2Gender);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxStudent2ID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxStudent2Name);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(221, 116);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(166, 289);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " 학생2";
            // 
            // textBoxNotePad2
            // 
            this.textBoxNotePad2.Location = new System.Drawing.Point(66, 94);
            this.textBoxNotePad2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNotePad2.Multiline = true;
            this.textBoxNotePad2.Name = "textBoxNotePad2";
            this.textBoxNotePad2.Size = new System.Drawing.Size(88, 109);
            this.textBoxNotePad2.TabIndex = 12;
            this.textBoxNotePad2.TextChanged += new System.EventHandler(this.textBoxNotePad2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "메모";
            // 
            // buttonStudent2Delete
            // 
            this.buttonStudent2Delete.Location = new System.Drawing.Point(65, 255);
            this.buttonStudent2Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStudent2Delete.Name = "buttonStudent2Delete";
            this.buttonStudent2Delete.Size = new System.Drawing.Size(88, 21);
            this.buttonStudent2Delete.TabIndex = 10;
            this.buttonStudent2Delete.Text = "삭제";
            this.buttonStudent2Delete.UseVisualStyleBackColor = true;
            this.buttonStudent2Delete.Click += new System.EventHandler(this.buttonStudent2Delete_Click);
            // 
            // buttonStudent2Save
            // 
            this.buttonStudent2Save.Location = new System.Drawing.Point(66, 221);
            this.buttonStudent2Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStudent2Save.Name = "buttonStudent2Save";
            this.buttonStudent2Save.Size = new System.Drawing.Size(88, 21);
            this.buttonStudent2Save.TabIndex = 6;
            this.buttonStudent2Save.Text = "저장";
            this.buttonStudent2Save.UseVisualStyleBackColor = true;
            this.buttonStudent2Save.Click += new System.EventHandler(this.buttonStudent2Save_Click);
            // 
            // comboBoxStudent2Gender
            // 
            this.comboBoxStudent2Gender.FormattingEnabled = true;
            this.comboBoxStudent2Gender.Location = new System.Drawing.Point(66, 70);
            this.comboBoxStudent2Gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStudent2Gender.Name = "comboBoxStudent2Gender";
            this.comboBoxStudent2Gender.Size = new System.Drawing.Size(88, 20);
            this.comboBoxStudent2Gender.TabIndex = 5;
            this.comboBoxStudent2Gender.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudent2Gender_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "성별";
            // 
            // textBoxStudent2ID
            // 
            this.textBoxStudent2ID.Location = new System.Drawing.Point(66, 45);
            this.textBoxStudent2ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStudent2ID.Name = "textBoxStudent2ID";
            this.textBoxStudent2ID.Size = new System.Drawing.Size(88, 21);
            this.textBoxStudent2ID.TabIndex = 3;
            this.textBoxStudent2ID.TextChanged += new System.EventHandler(this.textBoxStudent2ID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "학번";
            // 
            // textBoxStudent2Name
            // 
            this.textBoxStudent2Name.Location = new System.Drawing.Point(66, 20);
            this.textBoxStudent2Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStudent2Name.Name = "textBoxStudent2Name";
            this.textBoxStudent2Name.Size = new System.Drawing.Size(88, 21);
            this.textBoxStudent2Name.TabIndex = 1;
            this.textBoxStudent2Name.Text = "학생정보 없음";
            this.textBoxStudent2Name.TextChanged += new System.EventHandler(this.textBoxStudent2Name_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "이름";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxNotePad3);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.buttonStudent3Delete);
            this.groupBox3.Controls.Add(this.buttonStudent3Save);
            this.groupBox3.Controls.Add(this.comboBoxStudent3Gender);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxStudent3ID);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxStudent3Name);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(420, 116);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(166, 289);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " 학생3";
            // 
            // textBoxNotePad3
            // 
            this.textBoxNotePad3.Location = new System.Drawing.Point(66, 96);
            this.textBoxNotePad3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNotePad3.Multiline = true;
            this.textBoxNotePad3.Name = "textBoxNotePad3";
            this.textBoxNotePad3.Size = new System.Drawing.Size(88, 109);
            this.textBoxNotePad3.TabIndex = 12;
            this.textBoxNotePad3.TextChanged += new System.EventHandler(this.textBoxNotePad3_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "메모";
            // 
            // buttonStudent3Delete
            // 
            this.buttonStudent3Delete.Location = new System.Drawing.Point(66, 255);
            this.buttonStudent3Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStudent3Delete.Name = "buttonStudent3Delete";
            this.buttonStudent3Delete.Size = new System.Drawing.Size(88, 21);
            this.buttonStudent3Delete.TabIndex = 10;
            this.buttonStudent3Delete.Text = "삭제";
            this.buttonStudent3Delete.UseVisualStyleBackColor = true;
            this.buttonStudent3Delete.Click += new System.EventHandler(this.buttonStudent3Delete_Click);
            // 
            // buttonStudent3Save
            // 
            this.buttonStudent3Save.Location = new System.Drawing.Point(66, 221);
            this.buttonStudent3Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStudent3Save.Name = "buttonStudent3Save";
            this.buttonStudent3Save.Size = new System.Drawing.Size(88, 21);
            this.buttonStudent3Save.TabIndex = 6;
            this.buttonStudent3Save.Text = "저장";
            this.buttonStudent3Save.UseVisualStyleBackColor = true;
            this.buttonStudent3Save.Click += new System.EventHandler(this.buttonStudent3Save_Click);
            // 
            // comboBoxStudent3Gender
            // 
            this.comboBoxStudent3Gender.FormattingEnabled = true;
            this.comboBoxStudent3Gender.Location = new System.Drawing.Point(66, 70);
            this.comboBoxStudent3Gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStudent3Gender.Name = "comboBoxStudent3Gender";
            this.comboBoxStudent3Gender.Size = new System.Drawing.Size(88, 20);
            this.comboBoxStudent3Gender.TabIndex = 5;
            this.comboBoxStudent3Gender.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudent3Gender_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "성별";
            // 
            // textBoxStudent3ID
            // 
            this.textBoxStudent3ID.Location = new System.Drawing.Point(66, 45);
            this.textBoxStudent3ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStudent3ID.Name = "textBoxStudent3ID";
            this.textBoxStudent3ID.Size = new System.Drawing.Size(88, 21);
            this.textBoxStudent3ID.TabIndex = 3;
            this.textBoxStudent3ID.TextChanged += new System.EventHandler(this.textBoxStudent3ID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "학번";
            // 
            // textBoxStudent3Name
            // 
            this.textBoxStudent3Name.Location = new System.Drawing.Point(66, 20);
            this.textBoxStudent3Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStudent3Name.Name = "textBoxStudent3Name";
            this.textBoxStudent3Name.Size = new System.Drawing.Size(88, 21);
            this.textBoxStudent3Name.TabIndex = 1;
            this.textBoxStudent3Name.Text = "학생정보 없음";
            this.textBoxStudent3Name.TextChanged += new System.EventHandler(this.textBoxStudent3Name_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "이름";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LabelSaveStudentInfoCount);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.checkBoxAutoStudentInfoLoad);
            this.groupBox4.Location = new System.Drawing.Point(221, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(365, 74);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "설정 및 정보";
            // 
            // LabelSaveStudentInfoCount
            // 
            this.LabelSaveStudentInfoCount.AutoSize = true;
            this.LabelSaveStudentInfoCount.Location = new System.Drawing.Point(151, 50);
            this.LabelSaveStudentInfoCount.Name = "LabelSaveStudentInfoCount";
            this.LabelSaveStudentInfoCount.Size = new System.Drawing.Size(11, 12);
            this.LabelSaveStudentInfoCount.TabIndex = 2;
            this.LabelSaveStudentInfoCount.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "현재 저장된 학생 수 : ";
            // 
            // checkBoxAutoStudentInfoLoad
            // 
            this.checkBoxAutoStudentInfoLoad.AutoSize = true;
            this.checkBoxAutoStudentInfoLoad.Location = new System.Drawing.Point(27, 20);
            this.checkBoxAutoStudentInfoLoad.Name = "checkBoxAutoStudentInfoLoad";
            this.checkBoxAutoStudentInfoLoad.Size = new System.Drawing.Size(244, 16);
            this.checkBoxAutoStudentInfoLoad.TabIndex = 0;
            this.checkBoxAutoStudentInfoLoad.Text = "프로그램 시작시 자동으로 학생정보 로드";
            this.checkBoxAutoStudentInfoLoad.UseVisualStyleBackColor = true;
            this.checkBoxAutoStudentInfoLoad.CheckedChanged += new System.EventHandler(this.checkBoxAutoStudentInfoLoad_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 416);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLoadStudentInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "학생정보관리 프로그램";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadStudentInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonStudent1Save;
        private System.Windows.Forms.ComboBox comboBoxStudent1Gender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStudent1ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStudent1Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonStudent2Save;
        private System.Windows.Forms.ComboBox comboBoxStudent2Gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStudent2ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStudent2Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonStudent3Save;
        private System.Windows.Forms.ComboBox comboBoxStudent3Gender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxStudent3ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxStudent3Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonStudent1Delete;
        private System.Windows.Forms.TextBox textBoxNotePad1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonStudent2Delete;
        private System.Windows.Forms.Button buttonStudent3Delete;
        private System.Windows.Forms.TextBox textBoxNotePad2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNotePad3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label LabelSaveStudentInfoCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBoxAutoStudentInfoLoad;
    }
}

