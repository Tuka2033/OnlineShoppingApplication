using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Catalog;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;

namespace WarehouseApp
{
    public partial class MainForm : Form
    {

        // List to hold all Product collections as Inventory

        private List<Product> allProducts = new List<Product>();

        public MainForm()
        {
            InitializeComponent();   // code is written in sepearte designer.cs file

            LoginForm frm = new LoginForm();
            frm.ShowDialog();
        }


        //Event Handlers

        //Developer should focus more on 
        //Handling events with the help of Event handlers 

        private void OnFileExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnFileOpen(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
           if( dlg.ShowDialog()==DialogResult.OK)
            {
                string FileName = dlg.FileName;
                FileStream stream = new FileStream(FileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                this.allProducts=(List<Product>)bf.Deserialize(stream);
                stream.Close();
            }
            Display();
            // Bind List to DataGridVeiew
            this.dataProductsGridView.DataSource = null;
            this.dataProductsGridView.DataSource = allProducts;
        }

        private void OnFileSaveAS(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = dlg.FileName; // get the name of file selected
                FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, allProducts);
                stream.Close();

            }
        }

        private void OnToolsSignIn(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
        }

        private void OnInsertProduct(object sender, EventArgs e)
        {

            //Get data from controls and store to variables

            int id = int.Parse(this.txtProductID.Text);
            string title = this.txtProductTitle.Text;
            string description = this.txtProductDescription.Text;
            float unitPrice = float.Parse(this.txtProductUnitPrice.Text);
            int quantity = int.Parse(this.txtProductQuantity.Text);
          
            //Create instance of Product based on data received

            Product theProduct = new Product
            {
                ID=id,
                Title = title,
                Description = description,
                UnitPrice = unitPrice,
                Quantity = quantity
            };

            //Add prouct data into  List 
         
            this.allProducts.Add(theProduct);

            // Bind List to DataGridVeiew
            this.dataProductsGridView.DataSource = null;
            this.dataProductsGridView.DataSource = allProducts;
        }


        private int current = 0;
        private void OnFirst(object sender, EventArgs e)
        {
            this.current = 0;
            Display();
        }

        private void OnPrevious(object sender, EventArgs e)
        {
            if(this.current!=0)
            this.current = current - 1;
            Display();

        }

        private void OnNext(object sender, EventArgs e)
        {
            if(this.current!=allProducts.Count)
            this.current = current + 1;
            Display();
        }

        private void OnLast(object sender, EventArgs e)
        {
            this.current = allProducts.Count - 1;
            Display();
        }


        private void Display()
        {
            Product theProduct = allProducts[current];
            this.txtProductID.Text = theProduct.ID.ToString();
            this.txtProductTitle.Text = theProduct.Title.ToString();
            this.txtProductDescription.Text = theProduct.Description.ToString();
            this.txtProductUnitPrice.Text = theProduct.UnitPrice.ToString();
            this.txtProductQuantity.Text = theProduct.Quantity.ToString();
        }
    }
}
