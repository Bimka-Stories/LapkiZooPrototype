using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapkiZooPrototype
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dgvUsers.Rows.Add("1", "admin", "Администратор", "Активен");
            dgvUsers.Rows.Add("2", "user1", "Клиент", "Активен");
            dgvUsers.Rows.Add("3", "manager", "Менеджер", "Заблокирован");
        }

        private void chkFood_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
