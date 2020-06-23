using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace launcher_minecraft
{
    public partial class _launcher : Form
    {
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
    }
}
