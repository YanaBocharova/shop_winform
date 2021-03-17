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
using WindowsFormsHomeWork_3.Forms;
using WindowsFormsHomeWork_3.Util;

namespace WindowsFormsHomeWork_3
{
    public partial class ShopForm : Form
    {
        ProductDTO selectedProd;
        ShopDTO shop;

        List<decimal> checkUser = new List<decimal>();
        IProductsService productsService;
        IShopsService shopsService;

        public ShopForm(IUnitOfWork unitOfWork, IProductsService productsService,IShopsService shopsService)
        {
            InitializeComponent();

            this.productsService = productsService;
            this.shopsService = shopsService;

            ReloadForm();
            ShopInfo(1);

        }
        private void ReloadForm()
        {
            comboBoxProd.DataSource = null;
            var prods = productsService.GetProducts().ToList();
            comboBoxProd.DataSource = prods.ToList();
            comboBoxProd.DisplayMember = "Name";
            
        }
        private void ShopInfo(int idshop)
        {
            shop = shopsService.GetShop(1);
            lbShopName.Text = $"{shop.Name}\n{shop.Adress}\n{shop.Telephone}";
        }
        private void btnEditShop_Click(object sender, EventArgs e)
        {
            EditorShopForm form = DIRoot.Resolve<EditorShopForm>();
            form.parent = this;

            if( form.ShowDialog()==DialogResult.OK)
            {
                Hide();
            }

        }

        private void comboBoxProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProd.SelectedIndex != -1)
            {
                var selProd = comboBoxProd.SelectedItem as ProductDTO;
                selectedProd = selProd;
                labelPrice.Text = $"{selProd.Price} $";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            if (selectedProd != null)
            {
                listBoxSelectedProd.Items.Add(selectedProd);
                listBoxSelectedProd.DisplayMember = "Name";
                checkUser.Add(selectedProd.Price);
                decimal res = checkUser.Aggregate((a, b) => a + b);
                labelCheck.Text = $"{ res} $";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelCheck.Text ="";
            listBoxSelectedProd.Items.Clear();
        }
    }
}
