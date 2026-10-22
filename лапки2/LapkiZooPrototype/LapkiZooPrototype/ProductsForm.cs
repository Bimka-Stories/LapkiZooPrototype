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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            dgvProducts.Rows.Add("1", "Корм для кошек Purina", "Корма", "1500", "50");
            dgvProducts.Rows.Add("2", "Игрушка-мышка", "Игрушки", "300", "120");
            dgvProducts.Rows.Add("3", "Ошейник от блох", "Аксессуары", "800", "30");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
