using Final_Project.DAO;
using Final_Project.DTO;
using Final_Project.GUI.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.GUI.User
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txb_username.Text;
            string password = txb_password.Text;
            if (login(username, password))
            {
                Saler saler = new Saler();
                this.Hide();
                saler.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu rồi )");
            }
        }
        bool login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }
    }
}
