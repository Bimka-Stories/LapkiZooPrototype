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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

       

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren) frm.Close();
            ProductsForm products = new ProductsForm();
            
            products.Show();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren) frm.Close();
            ClientsForm clients = new ClientsForm();
          
            clients.Show();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren) frm.Close();
            OrdersForm orders = new OrdersForm();
        
            orders.Show();
        }

        private void отчётыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Форма отчётов в разработке.");
        }

        private void администрированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren) frm.Close();
            AdminForm admin = new AdminForm();
           
            admin.Show();
        }

     

       
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren) frm.Close();
            ProductsForm products = new ProductsForm();
           
            products.Show();
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren) frm.Close();
            ClientsForm clients = new ClientsForm();
          
            clients.Show();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren) frm.Close();
            OrdersForm orders = new OrdersForm();
          
            orders.Show();
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Форма отчётов в разработке.");
        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren) frm.Close();
            AdminForm admin = new AdminForm();
            
            admin.Show();
        }

       
        private void label1_Click(object sender, EventArgs e) { }
        private void MainForm_Load(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
    }
}