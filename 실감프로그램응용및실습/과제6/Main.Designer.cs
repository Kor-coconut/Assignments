namespace Assignment6
{
    partial class Main
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
            this.listViewAddressBook = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonFileLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.buttonFileSave = new System.Windows.Forms.Button();
            this.buttonFileAdd = new System.Windows.Forms.Button();
            this.buttonFIleInsert = new System.Windows.Forms.Button();
            this.buttonFIleDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewAddressBook
            // 
            this.listViewAddressBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderAddress,
            this.columnHeaderPhoneNumber});
            this.listViewAddressBook.HideSelection = false;
            this.listViewAddressBook.Location = new System.Drawing.Point(12, 12);
            this.listViewAddressBook.Name = "listViewAddressBook";
            this.listViewAddressBook.Size = new System.Drawing.Size(468, 397);
            this.listViewAddressBook.TabIndex = 0;
            this.listViewAddressBook.UseCompatibleStateImageBehavior = false;
            this.listViewAddressBook.View = System.Windows.Forms.View.Details;
            this.listViewAddressBook.Click += new System.EventHandler(this.listViewAddressBook_Click);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "이름";
            this.columnHeaderName.Width = 72;
            // 
            // columnHeaderAddress
            // 
            this.columnHeaderAddress.Text = "주소";
            this.columnHeaderAddress.Width = 220;
            // 
            // columnHeaderPhoneNumber
            // 
            this.columnHeaderPhoneNumber.Text = "전화번호";
            this.columnHeaderPhoneNumber.Width = 119;
            // 
            // buttonFileLoad
            // 
            this.buttonFileLoad.Location = new System.Drawing.Point(496, 12);
            this.buttonFileLoad.Name = "buttonFileLoad";
            this.buttonFileLoad.Size = new System.Drawing.Size(169, 61);
            this.buttonFileLoad.TabIndex = 1;
            this.buttonFileLoad.Text = "주소록 파일 열기";
            this.buttonFileLoad.UseVisualStyleBackColor = true;
            this.buttonFileLoad.Click += new System.EventHandler(this.buttonFileLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "이름 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "주소 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "전화번호 :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(119, 423);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 25);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(119, 466);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(251, 25);
            this.textBoxAddress.TabIndex = 10;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(119, 510);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(191, 25);
            this.textBoxPhoneNumber.TabIndex = 11;
            // 
            // buttonFileSave
            // 
            this.buttonFileSave.Location = new System.Drawing.Point(496, 79);
            this.buttonFileSave.Name = "buttonFileSave";
            this.buttonFileSave.Size = new System.Drawing.Size(169, 61);
            this.buttonFileSave.TabIndex = 12;
            this.buttonFileSave.Text = "주소록 파일 저장하기";
            this.buttonFileSave.UseVisualStyleBackColor = true;
            this.buttonFileSave.Click += new System.EventHandler(this.buttonFileSave_Click);
            // 
            // buttonFileAdd
            // 
            this.buttonFileAdd.Location = new System.Drawing.Point(496, 214);
            this.buttonFileAdd.Name = "buttonFileAdd";
            this.buttonFileAdd.Size = new System.Drawing.Size(169, 61);
            this.buttonFileAdd.TabIndex = 13;
            this.buttonFileAdd.Text = "추가";
            this.buttonFileAdd.UseVisualStyleBackColor = true;
            this.buttonFileAdd.Click += new System.EventHandler(this.buttonFileAdd_Click);
            // 
            // buttonFIleInsert
            // 
            this.buttonFIleInsert.Location = new System.Drawing.Point(496, 281);
            this.buttonFIleInsert.Name = "buttonFIleInsert";
            this.buttonFIleInsert.Size = new System.Drawing.Size(169, 61);
            this.buttonFIleInsert.TabIndex = 14;
            this.buttonFIleInsert.Text = "수정";
            this.buttonFIleInsert.UseVisualStyleBackColor = true;
            this.buttonFIleInsert.Click += new System.EventHandler(this.buttonFIleInsert_Click);
            // 
            // buttonFIleDelete
            // 
            this.buttonFIleDelete.Location = new System.Drawing.Point(496, 348);
            this.buttonFIleDelete.Name = "buttonFIleDelete";
            this.buttonFIleDelete.Size = new System.Drawing.Size(169, 61);
            this.buttonFIleDelete.TabIndex = 15;
            this.buttonFIleDelete.Text = "삭제";
            this.buttonFIleDelete.UseVisualStyleBackColor = true;
            this.buttonFIleDelete.Click += new System.EventHandler(this.buttonFIleDelete_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 570);
            this.Controls.Add(this.buttonFIleDelete);
            this.Controls.Add(this.buttonFIleInsert);
            this.Controls.Add(this.buttonFileAdd);
            this.Controls.Add(this.buttonFileSave);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFileLoad);
            this.Controls.Add(this.listViewAddressBook);
            this.Name = "Main";
            this.Text = "AddressBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAddressBook;
        private System.Windows.Forms.Button buttonFileLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderPhoneNumber;
        private System.Windows.Forms.Button buttonFileSave;
        private System.Windows.Forms.Button buttonFileAdd;
        private System.Windows.Forms.Button buttonFIleInsert;
        private System.Windows.Forms.Button buttonFIleDelete;
    }
}

