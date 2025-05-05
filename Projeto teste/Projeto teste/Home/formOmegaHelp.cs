using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_teste.Home
{
    public partial class formOmegaHelp : Form
    {
        public formOmegaHelp()
        {
            InitializeComponent();
        }

        private void formOmegaHelp_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;
        }

        Home home;
        private void pic_home_Click(object sender, EventArgs e)
        {
            home = new Home();
            home.FormClosed += (s, args) => Application.Exit();
            home.Show();
            this.Hide();
        }
    }
}
