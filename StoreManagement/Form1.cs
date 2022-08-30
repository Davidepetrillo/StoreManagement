using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnagCustomers_Click(object sender, EventArgs e)
        {
            WinCustomers frm = new WinCustomers();
            frm.Show();
        }

        private void btnAnagSuppliers_Click(object sender, EventArgs e)
        {
            WinSuppliers frm = new WinSuppliers();
            frm.Show();
        }

        private void btnGoods_Click(object sender, EventArgs e)
        {
            WinGoods frm = new WinGoods();
            frm.Show();
        }

        private void btnMovements_Click(object sender, EventArgs e)
        {
            WinMovements frm = new WinMovements();
            frm.Show();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            WinInvoices frm = new WinInvoices();
            frm.Show();
        }
    }
}
