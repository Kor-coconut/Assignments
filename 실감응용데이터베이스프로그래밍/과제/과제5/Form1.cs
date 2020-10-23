using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        string strconn = "Server=49.50.174.201;Database=s5359650;Uid=s5359650;Pwd=s5359650;Charset=utf8"; // DB 접근 서버, id, pw
        public Form1()
        {
            InitializeComponent();
            InitVariable();
            InitSettingData();
            Student_Count();
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

        #region Student SAVE Event Handlers
        private void buttonStudent1Save_Click(object sender, EventArgs e) // 학생1 버튼 클릭 시 --------------------------------------------------- 함수 사용
        {
            string name = null, student_id = null, gender = null, notepad = null;
            if (textBoxStudent1Name.Text == "") MessageBox.Show("학생 1의 이름을 입력해주세요.");
            else name = textBoxStudent1Name.Text;
            if (textBoxStudent1ID.Text == "") MessageBox.Show("학생 1의 학번을 입력해주세요.");
            else student_id = textBoxStudent1ID.Text;
            if (comboBoxStudent1Gender.Text == "") MessageBox.Show("학생 1의 성별을 입력해주세요.");
            else gender = comboBoxStudent1Gender.Text;
            notepad = textBoxNotePad1.Text;

            if (name != null && student_id != null && gender != null)
            {
                using (MySqlConnection conn = new MySqlConnection(strconn))
                {
                    conn.Open();
                    string query = "INSERT INTO studentManagement(id, name, student_id, gender, notepad) values ('1', '" + name + "', '" + student_id + "', '" + gender + "','" + notepad + "')" + 
                        "ON DUPLICATE KEY UPDATE id = 1, name = '" + name + "', student_id = '" + student_id + "', gender = '" + gender + "', notepad = '" + notepad + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            Student_Count();
        }
        private void buttonStudent2Save_Click(object sender, EventArgs e) // 학생2 버튼 클릭 시 --------------------------------------------------- 함수 사용
        {
            string name = null, student_id = null, gender = null, notepad = null;
            if (textBoxStudent2Name.Text == "") MessageBox.Show("학생 2의 이름을 입력해주세요.");
            else name = textBoxStudent2Name.Text;
            if (textBoxStudent2ID.Text == "") MessageBox.Show("학생 2의 학번을 입력해주세요.");
            else student_id = textBoxStudent2ID.Text;
            if (comboBoxStudent2Gender.Text == "") MessageBox.Show("학생 2의 성별을 입력해주세요.");
            else gender = comboBoxStudent2Gender.Text;
            notepad = textBoxNotePad2.Text;

            if (name != null && student_id != null && gender != null)
            {
                using (MySqlConnection conn = new MySqlConnection(strconn))
                {
                    conn.Open();
                    string query = "INSERT INTO studentManagement(id, name, student_id, gender, notepad) values ('2', '" + name + "', '" + student_id + "', '" + gender + "','" + notepad + "')" + 
                        "ON DUPLICATE KEY UPDATE id = 2, name = '" + name + "', student_id = '" + student_id + "', gender = '" + gender + "', notepad = '" + notepad + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            Student_Count();
        }
        private void buttonStudent3Save_Click(object sender, EventArgs e) // 학생3 버튼 클릭 시 --------------------------------------------------- 함수 사용
        {
            string name = null, student_id = null, gender = null, notepad = null;
            if (textBoxStudent3Name.Text == "") MessageBox.Show("학생 3의 이름을 입력해주세요.");
            else name = textBoxStudent3Name.Text;
            if (textBoxStudent3ID.Text == "") MessageBox.Show("학생 3의 학번을 입력해주세요.");
            else student_id = textBoxStudent3ID.Text;
            if (comboBoxStudent3Gender.Text == "") MessageBox.Show("학생 3의 성별을 입력해주세요.");
            else gender = comboBoxStudent3Gender.Text;
            notepad = textBoxNotePad3.Text;

            if (name != null && student_id != null && gender != null)
            {
                using (MySqlConnection conn = new MySqlConnection(strconn))
                {
                    conn.Open();
                    string query = "INSERT INTO studentManagement(id, name, student_id, gender, notepad) values ('3', '" + name + "', '" + student_id + "', '" + gender + "','" + notepad + "')" + 
                        "ON DUPLICATE KEY UPDATE id = 3, name = '" + name + "', student_id = '" + student_id + "', gender = '" + gender + "', notepad = '" + notepad + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            Student_Count();
        }
        #endregion
        #region Student Load Event Handlers
        private void buttonLoadStudentInfo_Click(object sender, EventArgs e) // 로드 버튼 클릭 시 정보 불러오기 --------------------------------------------------- 함수 사용
        {
            LoadStudentInfo();
        }
        private void LoadStudentInfo() // 정보 불러오는 함수
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                string query;
                MySqlCommand cmd;
                MySqlDataReader rdr;
                conn.Open();
                query = "SELECT * FROM studentManagement WHERE (id = '1')";
                cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    textBoxStudent1Name.Text = string.Format(rdr["name"] + "");
                    textBoxStudent1ID.Text = string.Format(rdr["student_id"] + "");
                    comboBoxStudent1Gender.Text = string.Format(rdr["gender"] + "");
                    textBoxNotePad1.Text = string.Format(rdr["notepad"] + "");
                }
                else
                {
                    textBoxStudent1Name.Text = "학생정보 없음";
                    textBoxStudent1ID.Text = "";
                    comboBoxStudent1Gender.Text = "남자";
                    textBoxNotePad1.Text = "";
                }
                rdr.Close();
                query = "SELECT * FROM studentManagement WHERE (id = '2')";
                cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    textBoxStudent2Name.Text = string.Format(rdr["name"] + "");
                    textBoxStudent2ID.Text = string.Format(rdr["student_id"] + "");
                    comboBoxStudent2Gender.Text = string.Format(rdr["gender"] + "");
                    textBoxNotePad2.Text = string.Format(rdr["notepad"] + "");
                }
                else
                {
                    textBoxStudent2Name.Text = "학생정보 없음";
                    textBoxStudent2ID.Text = "";
                    comboBoxStudent2Gender.Text = "남자";
                    textBoxNotePad2.Text = "";
                }
                rdr.Close();
                query = "SELECT * FROM studentManagement WHERE (id = '3')";
                cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    textBoxStudent3Name.Text = string.Format(rdr["name"] + "");
                    textBoxStudent3ID.Text = string.Format(rdr["student_id"] + "");
                    comboBoxStudent3Gender.Text = string.Format(rdr["gender"] + "");
                    textBoxNotePad3.Text = string.Format(rdr["notepad"] + "");
                }
                else
                {
                    textBoxStudent3Name.Text = "학생정보 없음";
                    textBoxStudent3ID.Text = "";
                    comboBoxStudent3Gender.Text = "남자";
                    textBoxNotePad3.Text = "";
                }
                rdr.Close();
                cmd.ExecuteNonQuery();
            }
            Student_Count();
        }
        #endregion
        #region Student Delete Event Handlers
        private void buttonStudent1Delete_Click(object sender, EventArgs e) // 학생 정보 삭제
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                string query;
                MySqlCommand cmd;
                conn.Open();
                query = "DELETE FROM studentManagement WHERE (id = '1')";
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            textBoxStudent1Name.Text = "학생정보 없음";
            textBoxStudent1ID.Text = "";
            comboBoxStudent1Gender.Text = "남자";
            textBoxNotePad1.Text = "";
            Student_Count();
        }
        private void buttonStudent2Delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                string query;
                MySqlCommand cmd;
                conn.Open();
                query = "DELETE FROM studentManagement WHERE (id = '2')";
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            textBoxStudent2Name.Text = "학생정보 없음";
            textBoxStudent2ID.Text = "";
            comboBoxStudent2Gender.Text = "남자";
            textBoxNotePad2.Text = "";
            Student_Count();
        }
        private void buttonStudent3Delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                string query;
                MySqlCommand cmd;
                conn.Open();
                query = "DELETE FROM studentManagement WHERE (id = '3')";
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            textBoxStudent3Name.Text = "학생정보 없음";
            textBoxStudent3ID.Text = "";
            comboBoxStudent3Gender.Text = "남자";
            textBoxNotePad3.Text = "";
            Student_Count();
        }
        #endregion
        #region Student CheckBox-AutoInfoLoad Event Handlers
        private void checkBoxAutoStudentInfoLoad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoStudentInfoLoad.Checked == true)
            {
                using (MySqlConnection conn = new MySqlConnection(strconn))
                {
                    conn.Open();
                    string query = "INSERT INTO studentManagementSettings(id, name, boolean) values ('1', 'autostudentinfoload', '1')" +
                        "ON DUPLICATE KEY UPDATE id = 1, boolean = '1'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(strconn))
                {
                    conn.Open();
                    string query = "INSERT INTO studentManagementSettings(id, name, boolean) values ('1', 'autostudentinfoload', '0')" +
                        "ON DUPLICATE KEY UPDATE id = 1, boolean = '0'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void InitSettingData() // 프로그램 시작 시 세팅 DB 확인
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                string query;
                MySqlCommand cmd;
                MySqlDataReader rdr;
                conn.Open();
                query = "SELECT * FROM studentManagementSettings WHERE (id = '1')";
                cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    checkBoxAutoStudentInfoLoad.Checked = bool.Parse(string.Format(rdr["boolean"] + ""));
                }
                else
                {
                    checkBoxAutoStudentInfoLoad.Checked = false;
                }
                rdr.Close();
                cmd.ExecuteNonQuery();
            }
            if(checkBoxAutoStudentInfoLoad.Checked == true) LoadStudentInfo();
        }
        #endregion
        #region Student Student_Count Method
        private void Student_Count()
        {
            int student_Count = 0;
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                string query;
                MySqlCommand cmd;
                MySqlDataReader rdr;
                conn.Open();
                query = "SELECT * FROM studentManagement";
                cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    student_Count++;
                }
                rdr.Close();
                cmd.ExecuteNonQuery();
            }
            LabelSaveStudentInfoCount.Text = Convert.ToString(student_Count);
        }
        #endregion
    }
}
