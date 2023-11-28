using Nortwind.Business.Abstract;
using Nortwind.Business.Concrete;
using Nortwind.Business.Concrete.EntityFremwork;
using Nortwind.DataAccess.Concrete.EntityFremwork;
using Nortwind.DataAccess.Concrete.NhProduct;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nortwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productServer = new ProductManager(new EfProductDal()); // Burda İçerisinde girdiğimiz serverle çalışmış olduk bir yere bağlı
            _categoryService = new CategoryManager(new EfCategoryDal());

        }
        private IProductServer _productServer;
        private ICategoryService _categoryService;


        private void Form1_Load(object sender, EventArgs e)
        {

            LoadPRoducts();
            LoadCategories();
            LoadCatagory2();
            UpdateLoadCategory();

        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }
        private void UpdateLoadCategory()
        {
            cbxUpdateCatagory.DataSource = _categoryService.GetAll();
            cbxUpdateCatagory.DisplayMember = "CategoryName";
            cbxUpdateCatagory.ValueMember = "CategoryId";
        }

        private void LoadPRoducts()
        {
            dgvProduct.DataSource = _productServer.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProduct.DataSource = _productServer.GetProductByCategory(Convert.ToInt16(cbxCategory.SelectedValue));
            }
            catch 
            {

                
            }
           
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtProductName.Text))// Eğer Text Baksa Değer varsa demiş olduk basında ! var dikkat et bakarken 
            {
                dgvProduct.DataSource = _productServer.GetProductByName(txtProductName.Text);
                //Burda eger txt bax içerisi boşşsa tüm listeyi getirsin diye yaptık
            }
            else
            {
                LoadPRoducts();
            }
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

          
            _productServer.Add(new Product
            {
             CategoryId = Convert.ToInt16(cbxCategoryId.SelectedValue),
             ProductName = txtProductname2.Text,
             QuantityPerUnit = txtQuantity.Text,
             UnitPrice = Convert.ToDecimal(txtUnitPrıce.Text),
             UnitsInStock = Convert.ToInt16(txtUnıtStock.Text)
            });
            MessageBox.Show("ÜRÜN BAŞARIYLA KAYDEDİLDİ...");
            LoadPRoducts();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void LoadCatagory2()
        {
            cbxCategoryId.DataSource = _categoryService.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _productServer.Update(new Product
            {
                ProductId = Convert.ToInt16(dgvProduct.CurrentRow.Cells[0].Value),
                ProductName = txtUpdateName.Text,
                CategoryId = Convert.ToInt16(cbxUpdateCatagory.SelectedValue),
                UnitsInStock = Convert.ToInt16(txtUpdateStock.Text),
                QuantityPerUnit = txtUpdateQuantity.Text,
                UnitPrice = Convert.ToDecimal(txtUpdatePrice.Text)
            }) ;
            MessageBox.Show("ÜRÜN BAŞARIYLA Güncellendi...");
            LoadPRoducts();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdateName.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            cbxUpdateCatagory.SelectedValue = dgvProduct.CurrentRow.Cells[2].Value;
            txtUpdatePrice.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
            txtUpdateStock.Text = dgvProduct.CurrentRow.Cells[4].Value.ToString();
            txtUpdateQuantity.Text = dgvProduct.CurrentRow.Cells[5].Value.ToString();

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productServer.Delete(new Product
            {
                ProductId = Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("ÜRÜN BAŞARIYLA SİLİNDİ...");
            LoadPRoducts();
        }

        private void gbxKatagori_Enter(object sender, EventArgs e)
        {

        }
    }
}
