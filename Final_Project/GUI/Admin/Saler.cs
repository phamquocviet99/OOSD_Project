using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.GUI.Admin
{
    public partial class Saler : Form
    {
        public Saler()
        {
            InitializeComponent();
        }

        private void Saler_Load(object sender, EventArgs e)
        {
            cb_Sort.Items.Add("Mới nhất");
            cb_Sort.Items.Add("Cũ nhất");
            cb_Sort.Items.Add("Giá cao");
            cb_Sort.Items.Add("Giá thấp");
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
