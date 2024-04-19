using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace MaxWeaver_Lab_1
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            BindProductsToListView(); // Bind products to ListView for Units On Hand
            BindProductsToPriceListView(); // Bind products to ListView for Price
        }

        private void BindProductsToListView()
        {
            List<Product> products = GetAllProducts().OrderBy(x => x.Units_On_Hand).ToList(); // Get all products ordered by Units On Hand


            foreach (var product in products)
            {
                this.listViewUOH.Items.Add(product.Units_On_Hand.ToString()); //Add Units On Hand to ListView
            }
        }
        private void BindProductsToPriceListView()
        {
            List<Product> products = GetAllProducts().OrderBy(x => x.Price).ToList(); //Get all products ordered by Price

            foreach (var product in products)
            {
                this.listView1.Items.Add(product.Price.ToString()); //Add Price to ListView
            }
        }

        public List<Product> GetAllProducts () 
        {
            ProductsDBDataContext dbContext = new ProductsDBDataContext(); //Create an instance of the database context

            List<Product> allProducts = dbContext.Products.ToList(); //Retrieve all products from the database

            return allProducts;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ProductsDBDataContext dbContext = new ProductsDBDataContext();

            string productNumber = searchTextBox.Text; //Get a product number from the text box

            Product product = dbContext.Products.SingleOrDefault(x => x.Product_Number == productNumber); //find a product by product number

            //Display info in proper text boxes
            this.ProductNumber.Text = product.Product_Number;
            this.DescriptionLabel.Text = product.Description;
            this.UnitsOnHand.Text = product.Units_On_Hand.ToString();
            this.Price.Text = product.Price.ToString();
        }

        private void searchButton2_Click(object sender, EventArgs e)
        {
            ProductsDBDataContext dbContext = new ProductsDBDataContext();

            string description = searchTextBox2.Text;

            List<Product> products = dbContext.Products.Where(item => item.Description.Contains(description)).ToList();


            foreach (var product in products) 
            {
                this.ProductListBox.Items.Add(product.Description);
            }

        }

        private void searchButtonUOH_Click(object sender, EventArgs e)
        {
            ProductsDBDataContext dbContext = new ProductsDBDataContext();

            string higherOrLower = comboBox1.Text;

            int unitsOnHand = Convert.ToInt32(searchTextBox3.Text);// Convert the text from searchTextBox3 to integer

            //Retrieve products based on Units On Hand and ordering them
            List<Product> products = dbContext.Products
                .Where(item => higherOrLower == "Higher" ? item.Units_On_Hand > unitsOnHand : item.Units_On_Hand < unitsOnHand) //ternary operator
                .OrderBy(item => item.Units_On_Hand)    
                .ToList();

            this.listViewUOH.Items.Clear(); //Clear the list so new items can be seen

            foreach (var product in products)
            {
                this.listViewUOH.Items.Add(product.Units_On_Hand.ToString());
            }
        }

        private void searchButton4_Click(object sender, EventArgs e)
        {
            ProductsDBDataContext dbContext = new ProductsDBDataContext();

            // Convert the text from minTextBox to decimal
            decimal min = Convert.ToDecimal(minTextBox.Text);
            decimal max = Convert.ToDecimal(maxTextBox.Text);

            // Retrieve products based on Price and ordering them
            List<Product> products = dbContext.Products
                .Where(item => item.Price >= min && item.Price <= max)
                .OrderBy(item => item.Price)
                .ToList();

            this.listView1.Items.Clear();

            foreach (var product in products)
            {
                this.listView1.Items.Add(product.Price.ToString());
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }

}
