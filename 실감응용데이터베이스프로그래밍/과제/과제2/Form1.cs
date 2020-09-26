using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        private bool loadCompleted_ = false;
        private int studentCount_ = 3;
        public Form1()
        {
            InitializeComponent();
            InitVariable();
            InitSettingData();
            InitException();
        }
        private void InitException() // 실행 시 파일 유무 체크 및 생성
        {
            try
            {
                using (FileStream sr = new FileStream("student1.stu", FileMode.Open))
                {
                    sr.Close();
                } ;
            }
            catch (FileNotFoundException)
            {
                FileStream sr = new FileStream("student1.stu", FileMode.Create);
                sr.Close();
            }
            try
            {
                using (FileStream sr = new FileStream("student2.stu", FileMode.Open))
                {
                    sr.Close();
                } ;
            }
            catch (FileNotFoundException)
            {
                FileStream sr = new FileStream("student2.stu", FileMode.Create);
                sr.Close();
            }
            try
            {
                using (FileStream sr = new FileStream("student3.stu", FileMode.Open))
                {
                    sr.Close();
                } ;
            }
            catch (FileNotFoundException)
            {
                FileStream sr = new FileStream("student3.stu", FileMode.Create);
                sr.Close();
            }
        }
        private void InitSettingData() // 프로그램 시작 시 세팅 파일 유무 확인 후 없다면 생성, 있다면 로드
        {
            try
            {
                using (FileStream sr = new FileStream("Setting.dat", FileMode.Open))
                {
                    sr.Close();
                    BinaryReader br = new BinaryReader(new FileStream("Setting.dat", FileMode.Open));
                    //Console.WriteLine(br.ReadString());
                    if (br.ReadString() == "True")
                    {
                        LoadStudent1();
                        LoadStudent2();
                        LoadStudent3();
                        br.Close();
                        sr.Close();
                        checkBoxAutoStudentInfoLoad.Checked = true;
                        StudentCount();
                    }
                    else
                    {
                        br.Close();
                        sr.Close();
                        StudentCount();
                    }
                };

            }
            catch (FileNotFoundException)
            {
                FileStream sr = new FileStream("Setting.dat", FileMode.Create);
                BinaryWriter bw = new BinaryWriter(sr);
                Console.WriteLine(checkBoxAutoStudentInfoLoad.Checked);
                bw.Write(checkBoxAutoStudentInfoLoad.Checked.ToString());
                bw.Close();
                sr.Close();
                StudentCount();
            }
        }

        private void InitVariable() // comboBox 초기화
        {
            comboBoxStudent2Gender.Items.Clear();
            comboBoxStudent2Gender.Items.Add("남자");
            comboBoxStudent2Gender.Items.Add("여자");

            string[] genderData = { "남자", "여자" };
            comboBoxStudent3Gender.Items.Clear();
            comboBoxStudent3Gender.Items.AddRange(genderData);

            comboBoxStudent1Gender.SelectedIndex = 0;
            comboBoxStudent2Gender.SelectedIndex = 0;
            comboBoxStudent3Gender.SelectedIndex = 0;
        }

        #region Student1 Event Handlers
        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
            SaveStudent1();
        }
        private void textBoxStudent1Name_TextChanged(object sender, EventArgs e)
       {
            if (loadCompleted_)
                SaveStudent1();
        }
        private void textBoxStudent1ID_TextChanged(object sender, EventArgs e)
        {
            if (loadCompleted_)
                SaveStudent1();
        }
        private void comboBoxStudent1Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadCompleted_)
                SaveStudent1();
        }
        private void textBoxNotePad1_TextChanged(object sender, EventArgs e)
        {
            if (loadCompleted_)
                SaveStudent1();
        }

        private void LoadStudent1()
        {
            try
            {
                using (FileStream sr = new FileStream("student1.stu", FileMode.Open))
                {
                    sr.Close();
                    BinaryReader br = new BinaryReader(new FileStream("student1.stu", FileMode.Open));

                    while (true)
                    {
                        try
                        {
                            string student1Name = br.ReadString();
                            string student1ID = br.ReadString();
                            string student1Gender = br.ReadString();
                            string student1NotePad = br.ReadString();

                            textBoxStudent1Name.Text = student1Name;
                            textBoxStudent1ID.Text = student1ID.ToString();
                            comboBoxStudent1Gender.Text = student1Gender;
                            textBoxNotePad1.Text = student1NotePad;
                        }
                        catch (EndOfStreamException)
                        {
                            br.Close();
                            break;
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                FileStream fs = new FileStream("student1.stu", FileMode.Create);
                fs.Close();
            }
            StudentCount();
        }
        private void SaveStudent1()
        {
           BinaryWriter bw = new BinaryWriter(new FileStream("student1.stu", FileMode.Create));

            bw.Write(textBoxStudent1Name.Text);
            bw.Write(textBoxStudent1ID.Text);
            bw.Write(comboBoxStudent1Gender.Text);
            bw.Write(textBoxNotePad1.Text);

            bw.Close();
            StudentCount();
            if (loadCompleted_ == false)
                return;
        }
        private void buttonStudent1Delete_Click(object sender, EventArgs e) // 학생 정보 삭제
        {
            FileInfo fileDel = new FileInfo("student1.stu");
            if (fileDel.Exists)
            {
                fileDel.Delete();
                StudentCount();
            }
            textBoxStudent1Name.Text = "학생정보 없음";
            textBoxStudent1ID.Text = "";
            comboBoxStudent1Gender.Text = "남자";
            textBoxNotePad1.Text = "";
            StudentCount();
        }

        #endregion
        #region Student2 Event Handlers
        private void buttonStudent2Save_Click(object sender, EventArgs e)
        {
            SaveStudent2();
        }
        private void textBoxStudent2Name_TextChanged(object sender, EventArgs e)
        {
            if (loadCompleted_)
                SaveStudent2();
        }
        private void textBoxStudent2ID_TextChanged(object sender, EventArgs e)
        {
            if (loadCompleted_)
                SaveStudent2();
        }
        private void comboBoxStudent2Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadCompleted_)
                SaveStudent2();
        }
        private void textBoxNotePad2_TextChanged(object sender, EventArgs e)
        {
            if (loadCompleted_)
                SaveStudent2();
        }

        private void LoadStudent2()
        {
            try
            {
                using (FileStream sr = new FileStream("student2.stu", FileMode.Open))
                {
                    sr.Close();
                    BinaryReader br = new BinaryReader(new FileStream("student2.stu", FileMode.Open));

                    while (true)
                    {
                        try
                        {
                            string student2Name = br.ReadString();
                            string student2ID = br.ReadString();
                            string student2Gender = br.ReadString();
                            string student2NotePad = br.ReadString();

                            textBoxStudent2Name.Text = student2Name;
                            textBoxStudent2ID.Text = student2ID.ToString();
                            comboBoxStudent2Gender.Text = student2Gender;
                            textBoxNotePad2.Text = student2NotePad;
                        }
                        catch (EndOfStreamException)
                        {
                            br.Close();
                            break;
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                FileStream fs = new FileStream("student2.stu", FileMode.Create);
                fs.Close();
            }
            StudentCount();
        }
        private void SaveStudent2()
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("student2.stu", FileMode.Create));

            bw.Write(textBoxStudent2Name.Text);
            bw.Write(textBoxStudent2ID.Text);
            bw.Write(comboBoxStudent2Gender.Text);
            bw.Write(textBoxNotePad2.Text);

            bw.Close();
            StudentCount();
            if (loadCompleted_ == false)
                return;
        }
        private void buttonStudent2Delete_Click(object sender, EventArgs e)
        {
            FileInfo fileDel = new FileInfo("student2.stu");
            if (fileDel.Exists)
            {
                fileDel.Delete();
                StudentCount();
            }
            textBoxStudent2Name.Text = "학생정보 없음";
            textBoxStudent2ID.Text = "";
            comboBoxStudent2Gender.Text = "남자";
            textBoxNotePad2.Text = "";
            StudentCount();
        }

        #endregion
        #region Student3 Event Handlers
        private void buttonStudent3Save_Click(object sender, EventArgs e)
        {
            SaveStudent3();
        }
        private void textBoxStudent3Name_TextChanged(object sender, EventArgs e)
        {
            if (loadCompleted_)
                SaveStudent3();
        }
        private void textBoxStudent3ID_TextChanged(object sender, EventArgs e)
        {
            if (loadCompleted_)
                SaveStudent3();
        }
        private void comboBoxStudent3Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadCompleted_)
                SaveStudent3();
        }
        private void textBoxNotePad3_TextChanged(object sender, EventArgs e)
        {
            if (loadCompleted_)
                SaveStudent3();
        }

        private void LoadStudent3()
        {
            try
            {
                using (FileStream sr = new FileStream("student3.stu", FileMode.Open))
                {
                    sr.Close();
                    BinaryReader br = new BinaryReader(new FileStream("student3.stu", FileMode.Open));

                    while (true)
                    {
                        try
                        {
                            string student3Name = br.ReadString();
                            string student3ID = br.ReadString();
                            string student3Gender = br.ReadString();
                            string student3NotePad = br.ReadString();

                            textBoxStudent3Name.Text = student3Name;
                            textBoxStudent3ID.Text = student3ID.ToString();
                            comboBoxStudent3Gender.Text = student3Gender;
                            textBoxNotePad3.Text = student3NotePad;                        }
                        catch (EndOfStreamException)
                        {
                            br.Close();
                            break;
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                FileStream fs = new FileStream("student3.stu", FileMode.Create);
                fs.Close();
            }
            StudentCount();
        }
        private void SaveStudent3()
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("student3.stu", FileMode.Create));

            bw.Write(textBoxStudent3Name.Text);
            bw.Write(textBoxStudent3ID.Text);
            bw.Write(comboBoxStudent3Gender.Text);
            bw.Write(textBoxNotePad3.Text);

            bw.Close();
            StudentCount();
            if (loadCompleted_ == false)
                return;
        }
        private void buttonStudent3Delete_Click(object sender, EventArgs e)
        {
            FileInfo fileDel = new FileInfo("student3.stu");
            if (fileDel.Exists)
            {
                fileDel.Delete();
                StudentCount();
            }
            textBoxStudent3Name.Text = "학생정보 없음";
            textBoxStudent3ID.Text = "";
            comboBoxStudent3Gender.Text = "남자";
            textBoxNotePad3.Text = "";
            StudentCount();
        }
        #endregion
        private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
        {
            LoadStudent1();
            LoadStudent2();
            LoadStudent3();
            StudentCount();
            loadCompleted_ = true;
        }

        private void StudentCount()
        {
            studentCount_ = 3;
            if (File.Exists("student1.stu"))
            {
                BinaryReader br = new BinaryReader(new FileStream("student1.stu", FileMode.Open));
                try
                {
                    if (br.ReadString() == "학생정보 없음")
                    {
                        studentCount_--;
                    }
                }
                catch (EndOfStreamException)
                {
                    studentCount_--;
                }
                br.Close();
            }
            else
            {
                studentCount_--;
            }
            if (File.Exists("student2.stu"))
            {
                BinaryReader br = new BinaryReader(new FileStream("student2.stu", FileMode.Open));
                try
                {
                    if (br.ReadString() == "학생정보 없음")
                    {
                        studentCount_--;
                    }
                }
                catch (EndOfStreamException)
                {
                    studentCount_--;
                }
                br.Close();
            }
            else
            {
                studentCount_--;
            }
            if (File.Exists("student3.stu"))
            {
                BinaryReader br = new BinaryReader(new FileStream("student3.stu", FileMode.Open));
                try
                {
                    if (br.ReadString() == "학생정보 없음")
                    {
                        studentCount_--;
                    }
                }
                catch (EndOfStreamException)
                {
                    studentCount_--;
                }
                br.Close();
            }
            else
            {
                studentCount_--;
            }
            LabelSaveStudentInfoCount.Text = studentCount_.ToString();
        }

        private void checkBoxAutoStudentInfoLoad_CheckedChanged(object sender, EventArgs e) // 체크박스 작동 시 자동으로 세팅 파일을 저장
        {
            FileStream sr = new FileStream("Setting.dat", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(sr);
            Console.WriteLine(checkBoxAutoStudentInfoLoad.Checked);
            bw.Write(checkBoxAutoStudentInfoLoad.Checked.ToString());
            bw.Close();
            sr.Close();
        }
    }
}
