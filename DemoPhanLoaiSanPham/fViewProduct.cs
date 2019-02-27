using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoPhanLoaiSanPham
{
    public partial class fViewProduct : Form
    {
        public fViewProduct()
        {
            InitializeComponent();
        }

        private void fViewProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            CodefViewProduct data = new CodefViewProduct();
            DataTable dt = data.GetCategory().Tables[0];
            lstCategory.DataSource = dt;
            lstCategory.DisplayMember = "Category"; //hiem thi cac category
            lstCategory.ValueMember = "ID"; //truy van id theo category
            lstCategory.SelectedIndex = 0; //so dong auto chon khi khoi chay chuong trinh
        }

        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CodefViewProduct dt = new CodefViewProduct();
            string id = lstCategory.SelectedValue.ToString();
            dtgvProduct.DataSource = dt.GetProductByCate(id).Tables[0].DefaultView;
        }
    }
}
