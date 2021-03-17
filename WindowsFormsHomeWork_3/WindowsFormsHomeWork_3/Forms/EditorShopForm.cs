using ShopApp.BLL.DTO;
using ShopApp.BLL.Interfaces;
using ShopApp.BLL.Services;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsHomeWork_3.Util;

namespace WindowsFormsHomeWork_3.Forms
{
    public partial class EditorShopForm : Form
    {
        ProductDTO selectProduct=new ProductDTO();
        IProductsService productsServiceForm;
        public ShopForm parent;
        public EditorShopForm(IUnitOfWork unitOfWork, IProductsService productsService, IShopsService shopsService)
        {
            InitializeComponent();
           
            productsServiceForm = productsService;
            var prods = productsService.GetProducts().ToList();
            listBoxProduct.DataSource = prods;

        }

        private void listBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var selIdx = listBoxProduct.SelectedIndex;

            if(selIdx != -1)
            {
                var selItem = listBoxProduct.SelectedItem as ProductDTO;
                textBoxName.Text = selItem.Name;
                textBoxDescrpt.Text = selItem.Description;
                textBoxPrice.Text = selItem.Price.ToString();
                selectProduct = selItem;
                //блокировка ввода
                textBoxName.Enabled = textBoxDescrpt.Enabled = textBoxPrice.Enabled=false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            selectProduct.Name = textBoxName.Text;
            selectProduct.Description = textBoxDescrpt.Text;
            selectProduct.Price = decimal.Parse(textBoxPrice.Text);

            productsServiceForm.UpdateProductDTO(selectProduct);
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            textBoxName.Enabled = textBoxDescrpt.Enabled = textBoxPrice.Enabled = true;
            textBoxName.Text = selectProduct.Name;
            textBoxDescrpt.Text = selectProduct.Description;
            textBoxPrice.Text = selectProduct.Price.ToString();
           
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();

            ShopForm f = DIRoot.Resolve<ShopForm>();
            f.Show();

        }
    }
}
