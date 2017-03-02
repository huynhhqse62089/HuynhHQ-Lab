using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.DataAccess;
using BusinessLogic.Entities;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private int menu = 1;
        public Form1()
        {
            InitializeComponent();
            btnProducts_Click(null, null);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductDAO dao = new ProductDAO();
            List<Products> list = dao.getAllProducts();
            dgvAll.DataSource = list;
            menu = 1;
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SupplierDAO dao = new SupplierDAO();
            List<Suppliers> list = dao.getAllSuppliers();
            dgvAll.DataSource = list;
            menu = 2;
        }

        private void btnCatagories_Click(object sender, EventArgs e)
        {
            CatagoryDAO dao = new CatagoryDAO();
            List<Catagories> list = dao.getAllCatagories();
            dgvAll.DataSource = list;
            menu = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (menu == 0)
                return;
            if(menu == 1)
            {
                string searchValue = txtSearchValue.Text;
                ProductDAO dao = new ProductDAO();
                List<Products> list = dao.searchByName(searchValue);
                dgvAll.DataSource = list;
            }
            else
            {
                string searchValue = txtSearchValue.Text;
                SupplierDAO dao = new SupplierDAO();
                List<Suppliers> list = dao.searchByCompanyName(searchValue);
                dgvAll.DataSource = list;
            }
        }
    }
}
