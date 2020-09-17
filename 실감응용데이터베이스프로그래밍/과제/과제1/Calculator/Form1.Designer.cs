namespace Calculator
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
            this.groupBoxComboCalc = new System.Windows.Forms.GroupBox();
            this.buttonComboBoxCalculator = new System.Windows.Forms.Button();
            this.comboBoxComboCalc_Operater = new System.Windows.Forms.ComboBox();
            this.textBoxComboCalc_Result = new System.Windows.Forms.TextBox();
            this.textBoxComboCalc_Oper2 = new System.Windows.Forms.TextBox();
            this.textBoxComboCalc_Oper1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxRadioButtonCalc = new System.Windows.Forms.GroupBox();
            this.RadioButtonCalc_Operater_2 = new System.Windows.Forms.RadioButton();
            this.RadioButtonCalc_Operater_1 = new System.Windows.Forms.RadioButton();
            this.radioButtonCalculator = new System.Windows.Forms.Button();
            this.radioButtonCalc_Result = new System.Windows.Forms.TextBox();
            this.radioButtonCalc_Oper2 = new System.Windows.Forms.TextBox();
            this.radioButtonCalc_Oper1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RadioButtonCalc_Operater_3 = new System.Windows.Forms.RadioButton();
            this.RadioButtonCalc_Operater_4 = new System.Windows.Forms.RadioButton();
            this.RadioButtonCalc_Operater_5 = new System.Windows.Forms.RadioButton();
            this.groupBoxComboCalc.SuspendLayout();
            this.groupBoxRadioButtonCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxComboCalc
            // 
            this.groupBoxComboCalc.Controls.Add(this.buttonComboBoxCalculator);
            this.groupBoxComboCalc.Controls.Add(this.comboBoxComboCalc_Operater);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboCalc_Result);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboCalc_Oper2);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboCalc_Oper1);
            this.groupBoxComboCalc.Controls.Add(this.label4);
            this.groupBoxComboCalc.Controls.Add(this.label3);
            this.groupBoxComboCalc.Controls.Add(this.label2);
            this.groupBoxComboCalc.Controls.Add(this.label1);
            this.groupBoxComboCalc.Location = new System.Drawing.Point(59, 57);
            this.groupBoxComboCalc.Name = "groupBoxComboCalc";
            this.groupBoxComboCalc.Size = new System.Drawing.Size(661, 110);
            this.groupBoxComboCalc.TabIndex = 0;
            this.groupBoxComboCalc.TabStop = false;
            this.groupBoxComboCalc.Text = "ComboBox based Calculator";
            // 
            // buttonComboBoxCalculator
            // 
            this.buttonComboBoxCalculator.Location = new System.Drawing.Point(415, 64);
            this.buttonComboBoxCalculator.Name = "buttonComboBoxCalculator";
            this.buttonComboBoxCalculator.Size = new System.Drawing.Size(75, 23);
            this.buttonComboBoxCalculator.TabIndex = 3;
            this.buttonComboBoxCalculator.Text = "Calculate";
            this.buttonComboBoxCalculator.UseVisualStyleBackColor = true;
            this.buttonComboBoxCalculator.Click += new System.EventHandler(this.buttonComboBoxCalculator_Click);
            // 
            // comboBoxComboCalc_Operater
            // 
            this.comboBoxComboCalc_Operater.FormattingEnabled = true;
            this.comboBoxComboCalc_Operater.Location = new System.Drawing.Point(164, 65);
            this.comboBoxComboCalc_Operater.Name = "comboBoxComboCalc_Operater";
            this.comboBoxComboCalc_Operater.Size = new System.Drawing.Size(51, 20);
            this.comboBoxComboCalc_Operater.TabIndex = 2;
            // 
            // textBoxComboCalc_Result
            // 
            this.textBoxComboCalc_Result.Location = new System.Drawing.Point(525, 64);
            this.textBoxComboCalc_Result.Name = "textBoxComboCalc_Result";
            this.textBoxComboCalc_Result.Size = new System.Drawing.Size(100, 21);
            this.textBoxComboCalc_Result.TabIndex = 1;
            // 
            // textBoxComboCalc_Oper2
            // 
            this.textBoxComboCalc_Oper2.Location = new System.Drawing.Point(277, 64);
            this.textBoxComboCalc_Oper2.Name = "textBoxComboCalc_Oper2";
            this.textBoxComboCalc_Oper2.Size = new System.Drawing.Size(100, 21);
            this.textBoxComboCalc_Oper2.TabIndex = 1;
            // 
            // textBoxComboCalc_Oper1
            // 
            this.textBoxComboCalc_Oper1.Location = new System.Drawing.Point(11, 64);
            this.textBoxComboCalc_Oper1.Name = "textBoxComboCalc_Oper1";
            this.textBoxComboCalc_Oper1.Size = new System.Drawing.Size(100, 21);
            this.textBoxComboCalc_Oper1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Operand 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Operand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operand 1";
            // 
            // groupBoxRadioButtonCalc
            // 
            this.groupBoxRadioButtonCalc.Controls.Add(this.RadioButtonCalc_Operater_5);
            this.groupBoxRadioButtonCalc.Controls.Add(this.RadioButtonCalc_Operater_4);
            this.groupBoxRadioButtonCalc.Controls.Add(this.RadioButtonCalc_Operater_3);
            this.groupBoxRadioButtonCalc.Controls.Add(this.RadioButtonCalc_Operater_2);
            this.groupBoxRadioButtonCalc.Controls.Add(this.RadioButtonCalc_Operater_1);
            this.groupBoxRadioButtonCalc.Controls.Add(this.radioButtonCalculator);
            this.groupBoxRadioButtonCalc.Controls.Add(this.radioButtonCalc_Result);
            this.groupBoxRadioButtonCalc.Controls.Add(this.radioButtonCalc_Oper2);
            this.groupBoxRadioButtonCalc.Controls.Add(this.radioButtonCalc_Oper1);
            this.groupBoxRadioButtonCalc.Controls.Add(this.label5);
            this.groupBoxRadioButtonCalc.Controls.Add(this.label6);
            this.groupBoxRadioButtonCalc.Controls.Add(this.label7);
            this.groupBoxRadioButtonCalc.Controls.Add(this.label8);
            this.groupBoxRadioButtonCalc.Location = new System.Drawing.Point(59, 287);
            this.groupBoxRadioButtonCalc.Name = "groupBoxRadioButtonCalc";
            this.groupBoxRadioButtonCalc.Size = new System.Drawing.Size(661, 110);
            this.groupBoxRadioButtonCalc.TabIndex = 1;
            this.groupBoxRadioButtonCalc.TabStop = false;
            this.groupBoxRadioButtonCalc.Text = "Radio Button Calculator";
            // 
            // RadioButtonCalc_Operater_2
            // 
            this.RadioButtonCalc_Operater_2.AutoSize = true;
            this.RadioButtonCalc_Operater_2.Location = new System.Drawing.Point(151, 77);
            this.RadioButtonCalc_Operater_2.Name = "RadioButtonCalc_Operater_2";
            this.RadioButtonCalc_Operater_2.Size = new System.Drawing.Size(29, 16);
            this.RadioButtonCalc_Operater_2.TabIndex = 5;
            this.RadioButtonCalc_Operater_2.TabStop = true;
            this.RadioButtonCalc_Operater_2.Text = "-";
            this.RadioButtonCalc_Operater_2.UseVisualStyleBackColor = true;
            // 
            // RadioButtonCalc_Operater_1
            // 
            this.RadioButtonCalc_Operater_1.AutoSize = true;
            this.RadioButtonCalc_Operater_1.Checked = true;
            this.RadioButtonCalc_Operater_1.Location = new System.Drawing.Point(151, 55);
            this.RadioButtonCalc_Operater_1.Name = "RadioButtonCalc_Operater_1";
            this.RadioButtonCalc_Operater_1.Size = new System.Drawing.Size(29, 16);
            this.RadioButtonCalc_Operater_1.TabIndex = 4;
            this.RadioButtonCalc_Operater_1.TabStop = true;
            this.RadioButtonCalc_Operater_1.Text = "+";
            this.RadioButtonCalc_Operater_1.UseVisualStyleBackColor = true;
            // 
            // radioButtonCalculator
            // 
            this.radioButtonCalculator.Location = new System.Drawing.Point(413, 64);
            this.radioButtonCalculator.Name = "radioButtonCalculator";
            this.radioButtonCalculator.Size = new System.Drawing.Size(75, 23);
            this.radioButtonCalculator.TabIndex = 3;
            this.radioButtonCalculator.Text = "Calculate";
            this.radioButtonCalculator.UseVisualStyleBackColor = true;
            this.radioButtonCalculator.Click += new System.EventHandler(this.radioButtonCalculator_Click);
            // 
            // radioButtonCalc_Result
            // 
            this.radioButtonCalc_Result.Location = new System.Drawing.Point(523, 64);
            this.radioButtonCalc_Result.Name = "radioButtonCalc_Result";
            this.radioButtonCalc_Result.Size = new System.Drawing.Size(100, 21);
            this.radioButtonCalc_Result.TabIndex = 1;
            // 
            // radioButtonCalc_Oper2
            // 
            this.radioButtonCalc_Oper2.Location = new System.Drawing.Point(275, 64);
            this.radioButtonCalc_Oper2.Name = "radioButtonCalc_Oper2";
            this.radioButtonCalc_Oper2.Size = new System.Drawing.Size(100, 21);
            this.radioButtonCalc_Oper2.TabIndex = 1;
            // 
            // radioButtonCalc_Oper1
            // 
            this.radioButtonCalc_Oper1.Location = new System.Drawing.Point(11, 64);
            this.radioButtonCalc_Oper1.Name = "radioButtonCalc_Oper1";
            this.radioButtonCalc_Oper1.Size = new System.Drawing.Size(100, 21);
            this.radioButtonCalc_Oper1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Operand 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "Operand";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Operand 1";
            // 
            // RadioButtonCalc_Operater_3
            // 
            this.RadioButtonCalc_Operater_3.AutoSize = true;
            this.RadioButtonCalc_Operater_3.Location = new System.Drawing.Point(186, 55);
            this.RadioButtonCalc_Operater_3.Name = "RadioButtonCalc_Operater_3";
            this.RadioButtonCalc_Operater_3.Size = new System.Drawing.Size(29, 16);
            this.RadioButtonCalc_Operater_3.TabIndex = 6;
            this.RadioButtonCalc_Operater_3.TabStop = true;
            this.RadioButtonCalc_Operater_3.Text = "*";
            this.RadioButtonCalc_Operater_3.UseVisualStyleBackColor = true;
            // 
            // RadioButtonCalc_Operater_4
            // 
            this.RadioButtonCalc_Operater_4.AutoSize = true;
            this.RadioButtonCalc_Operater_4.Location = new System.Drawing.Point(186, 77);
            this.RadioButtonCalc_Operater_4.Name = "RadioButtonCalc_Operater_4";
            this.RadioButtonCalc_Operater_4.Size = new System.Drawing.Size(29, 16);
            this.RadioButtonCalc_Operater_4.TabIndex = 7;
            this.RadioButtonCalc_Operater_4.TabStop = true;
            this.RadioButtonCalc_Operater_4.Text = "/";
            this.RadioButtonCalc_Operater_4.UseVisualStyleBackColor = true;
            // 
            // RadioButtonCalc_Operater_5
            // 
            this.RadioButtonCalc_Operater_5.AutoSize = true;
            this.RadioButtonCalc_Operater_5.Location = new System.Drawing.Point(221, 55);
            this.RadioButtonCalc_Operater_5.Name = "RadioButtonCalc_Operater_5";
            this.RadioButtonCalc_Operater_5.Size = new System.Drawing.Size(29, 16);
            this.RadioButtonCalc_Operater_5.TabIndex = 8;
            this.RadioButtonCalc_Operater_5.TabStop = true;
            this.RadioButtonCalc_Operater_5.Text = "^";
            this.RadioButtonCalc_Operater_5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxRadioButtonCalc);
            this.Controls.Add(this.groupBoxComboCalc);
            this.Name = "Form1";
            this.Text = "FormCalculator_5359650";
            this.groupBoxComboCalc.ResumeLayout(false);
            this.groupBoxComboCalc.PerformLayout();
            this.groupBoxRadioButtonCalc.ResumeLayout(false);
            this.groupBoxRadioButtonCalc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxComboCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonComboBoxCalculator;
        private System.Windows.Forms.TextBox textBoxComboCalc_Result;
        private System.Windows.Forms.TextBox textBoxComboCalc_Oper2;
        private System.Windows.Forms.TextBox textBoxComboCalc_Oper1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxComboCalc_Operater;
        private System.Windows.Forms.GroupBox groupBoxRadioButtonCalc;
        private System.Windows.Forms.Button radioButtonCalculator;
        private System.Windows.Forms.TextBox radioButtonCalc_Result;
        private System.Windows.Forms.TextBox radioButtonCalc_Oper2;
        private System.Windows.Forms.TextBox radioButtonCalc_Oper1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton RadioButtonCalc_Operater_2;
        private System.Windows.Forms.RadioButton RadioButtonCalc_Operater_1;
        private System.Windows.Forms.RadioButton RadioButtonCalc_Operater_5;
        private System.Windows.Forms.RadioButton RadioButtonCalc_Operater_4;
        private System.Windows.Forms.RadioButton RadioButtonCalc_Operater_3;
    }
}

