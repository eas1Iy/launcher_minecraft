using launcher_minecraft._class;
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
        string username = "";
        string password = "";
        bool admin;
        bool saved;
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

        }

        void проверкаСтатуса()
        {
            if (admin == true)
            {
                _админПанель.Visible = true;
            }
            else if (admin == false) { _админПанель.Visible = false; }
        }

        void _войти_Click(object sender, EventArgs e)
        {
            if (_полеИмя.Text.Length <= 1 && _парольПоле.Text.Length <= 1)
                MessageBox.Show("Ошибка авторизации, корректно заполните данные для авторизации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                username = _полеИмя.Text;
                password = _парольПоле.Text;
                try
                {
                    OleDbDataAdapter ada = new OleDbDataAdapter("SELECT COUNT(*) FROM users where никнейм = '" + username + "'and пароль = '" + password + "'", con);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        DataSet st = new DataSet();
                        OleDbDataAdapter getStatus = new OleDbDataAdapter("SELECT админ FROM users where никнейм = '" + username + "'", con);
                        getStatus.Fill(st);
                        foreach (DataRow row in st.Tables[0].Rows)
                        {
                            admin = Convert.ToBoolean(row["админ"]);
                        }
                        OleDbDataAdapter online = new OleDbDataAdapter("INSERT INTO users ([онлайн])  VALUES (?) WHERE никнейм = '" + username + "'", con);
                        //onlineUser(username,true);
                        проверкаСтатуса();
                        _выйти.Visible = true;
                    }

                }
                catch (Exception error) { MessageBox.Show(error.ToString()); }
            }
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
        }
    }
}
