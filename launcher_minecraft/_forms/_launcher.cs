using launcher_minecraft._class;
using launcher_minecraft._forms;
using launcher_minecraft.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace launcher_minecraft
{
    public partial class _launcher : Form
    {
        dataBase db = new dataBase();
        OleDbConnection con = new OleDbConnection(Settings.Default["DataBase"].ToString());
        _admin aForm = new _admin();
        string username = Settings.Default["username"].ToString();
        string password = Settings.Default["password"].ToString();
        string admin;
        bool saved = Convert.ToBoolean(Settings.Default["save"]);
        bool online;



        public _launcher()
        {
            InitializeComponent();
        }

        void _закрыть_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void _скрыть_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void _launcher_Load(object sender, EventArgs e)
        {
            if (Internet.CheckConnection())
                goto есть;
            else { MessageBox.Show("Соединение с интернетом не найдено, использование лаунчера невозможно, сорри...", "Ошибка соеднинения.", MessageBoxButtons.OK, MessageBoxIcon.Error); Application.Exit(); }
            есть:
            loadSaved();
        }

        void проверкаСтатуса()
        {
            if (admin == "да")
            {
                _админПанель.Visible = true;
            }
            else if (admin == "нет") { _админПанель.Visible = false; }
        }

        void _войти_Click(object sender, EventArgs e)
        {
            if (_полеИмя.Text.Length <= 1 && _парольПоле.Text.Length <= 1)
                MessageBox.Show("Ошибка авторизации, корректно заполните данные для авторизации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    OleDbDataAdapter ada = new OleDbDataAdapter("SELECT COUNT(*) FROM users where никнейм = '" + _полеИмя.Text + "'and пароль = '" + _парольПоле.Text + "'", con);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        DataSet st = new DataSet();
                        OleDbDataAdapter getStatus = new OleDbDataAdapter("SELECT админ FROM users where никнейм = '" + _полеИмя.Text + "'", con);
                        getStatus.Fill(st);
                        foreach (DataRow row in st.Tables[0].Rows)
                        {
                            admin = Convert.ToString(row["админ"]);
                        }
                        //onlineUser(username,true);
                        проверкаСтатуса();
                        _выйти.Visible = true;
                        if(_сохранитьПароль.Checked == true)
                        {
                            saved = true;
                            Settings.Default["username"] = _полеИмя.Text;
                            Settings.Default["password"] = _парольПоле.Text;
                            Settings.Default["save"] = saved;
                            Settings.Default.Save();
                        }
                        else
                        {
                            saved = false;
                            Settings.Default["username"] = "";
                            Settings.Default["password"] = "";
                            Settings.Default["save"] = saved;
                            Settings.Default.Save();
                        }
                    }
                    else MessageBox.Show("Не правильный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception error) { MessageBox.Show(error.ToString()); }
            }
        }

        void loadSaved()
        {
            _сохранитьПароль.Checked = saved;
            _полеИмя.Text = username;
            _парольПоле.Text = password;
        }

        void onlineUser(string nick, bool onl)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into users ([онлайн]) values (@онлайнс) WHERE никнейм = {nick}";
            cmd.Parameters.AddWithValue("@онлайнс", "true");
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            //
            con.Close();
        }

        void _выйти_Click(object sender, EventArgs e)
        {
            _выйти.Visible = false;
            _полеИмя.Text = string.Empty;
            _парольПоле.Text = string.Empty;
            _сохранитьПароль.Checked = false;
            _админПанель.Visible = false;
            //
            saved = false;
            Settings.Default["username"] = "";
            Settings.Default["password"] = "";
            Settings.Default["save"] = saved;
            Settings.Default.Save();
        }

        void _админПанель_Click(object sender, EventArgs e)
        {
            aForm.ShowDialog();
        }
    }
}
