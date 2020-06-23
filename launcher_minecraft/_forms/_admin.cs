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
using System.Windows.Forms;

namespace launcher_minecraft._forms
{
    public partial class _admin : Form
    {
        dataBase db = new dataBase();
        OleDbConnection con = new OleDbConnection(Settings.Default["DataBase"].ToString());
        OleDbConnection con2 = new OleDbConnection(@" provider=Microsoft.ace.Oledb.12.0; data source=cars.accdb; Persist Security Info=False");
        bool z;

        public _admin()
        {
            InitializeComponent();
        }

        void _admin_Load(object sender, EventArgs e)
        {
            try
            {
                _таблицаПользователей.DataSource = db.usersFill();
                _таблицаПользователей.Columns[0].Visible = false;
                _таблицаПользователей.Columns[4].Visible = false;
                _таблицаПользователей.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void _добавитьАдмин_Click(object sender, EventArgs e)
        {
            try
            {
                //OleDbDataAdapter selectif = new OleDbDataAdapter("SELECT никнейм FROM users", con);
                //DataTable dt = new DataTable();
                //selectif.Fill(dt);
                //bool exists = dt.AsEnumerable().Where(c => c.Field<string>("никнейм").Equals(_имяАдмин.Text.ToString())).Count() > 0;
                string admin;
                //if (exists == true)
                //{
                //    MessageBox.Show("Данный логин уже занят, попробуйте другой!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                //{
                    if (_статусАдмин.SelectedIndex == 0) admin = "нет"; else admin = "да";
                    db.userAdd(_имяАдмин.Text, _парольАдмин.Text, admin);
                    _таблицаПользователей.DataSource = db.usersFill();
                    _таблицаПользователей.Update();
                //}
            }
            catch (Exception error) { MessageBox.Show(error.ToString()); }
        }

        void _удалитьАдмин_Click(object sender, EventArgs e)
        {
            try
            {
                db.DeleteFromTable("users", "user_id", int.Parse(_таблицаПользователей.Rows[_таблицаПользователей.CurrentRow.Index].Cells["user_id"].Value.ToString()));
                _таблицаПользователей.DataSource = db.usersFill();
            }
            catch { }
        }
    }
}
