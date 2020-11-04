using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Catalog;

namespace DAL
{
    public static class CatalogDBManger
    {

        public static string  connectionString=@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\TAP\AmazonOnline\TesterApp\ECommerce.mdf;Integrated Security=True";

        //CRUD Operations against database
        public static Product GetProductByID(int productID)
        {

            Product theProduct = null;
            //using connected data access mode
            try
            {
                using (IDbConnection con = new SqlConnection())
                {
                    con.ConnectionString = connectionString;
                    IDbCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    string query = "SELECT * FROM flowers WHERE  productID=@Id";
                    cmd.CommandText = query;
                    cmd.Parameters.Add(new SqlParameter("@Id", productID));
                    con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int id = int.Parse(reader["ProductID"].ToString());
                        string title = reader["title"].ToString();
                        string description = reader["description"].ToString();
                        int unitPrice = int.Parse(reader["price"].ToString());
                        int quantity = int.Parse(reader["quantity"].ToString());

                        theProduct = new Product
                        {
                            ID = id,
                            Title = title,
                            Description = description,
                            UnitPrice = unitPrice,
                            Quantity = quantity
                        };
                    }

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }
            return theProduct;

        }
        public static  IEnumerable<Product> GetAllProducts()
        {
            List<Product> allProducts = new List<Product>();
            IDbConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            IDbCommand cmd = new SqlCommand();
            string query = "SELECT * FROM flowers";
            cmd.Connection = con;
            cmd.CommandText = query;
            IDataReader reader = null;

            try
            {
                con.Open();
                reader=cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["ProductID"].ToString());
                    string title = reader["title"].ToString();
                    string description = reader["description"].ToString();
                    int unitPrice =int.Parse(reader["price"].ToString());
                    int quantity=int.Parse(reader["quantity"].ToString());

                    Product theProduct = new Product
                    {
                        ID = id,
                        Title = title,
                        Description = description,
                        UnitPrice = unitPrice,
                        Quantity = quantity
                    };
                    allProducts.Add(theProduct);
                }
                reader.Close();
            }
            catch (SqlException exp)
            { 
                string message = exp.Message;
            }

            finally 
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return allProducts;
        }
        public static IEnumerable<Product> GetAllProductsUsingDisconnected()
        {

            List<Product> allProducts = new List<Product>();
            IDbConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            IDbCommand cmd = new SqlCommand();
            string query = "SELECT * FROM flowers";
            cmd.Connection = con;
            cmd.CommandText = query;
            try
            {
                DataSet ds = new DataSet();
                // empty dataset

                SqlDataAdapter da = new SqlDataAdapter(cmd as SqlCommand);
                da.Fill(ds);
                //data will be filled with results recived from database 

                // DataSet is collection of DataTable objects retrived from database 
                //after fill method
                DataTable dt = ds.Tables[0];
                //DataTable is a collection of DataRow Objets 

                foreach( DataRow  datarow in dt.Rows)
                {

                    int id = int.Parse(datarow["productID"].ToString());
                    string title = datarow["title"].ToString();
                    string description = datarow["description"].ToString();
                    float unitPrice = float.Parse(datarow["price"].ToString());
                    int quantity = int.Parse(datarow["quantity"].ToString());
                    allProducts.Add(new Product()
                    {
                        ID = id,
                        Title = title,
                        Description = description,
                        UnitPrice = unitPrice,
                        Quantity = quantity,
                        
                    });
                }
            }
            catch(SqlException exp)
            {
                string message = exp.Message;
            }

            return allProducts;
        }
        public static bool Insert(Product theProduct)
        {
            bool status = false;
            //using connected data access mode

            try
            {
                IDbConnection con = new SqlConnection();
                con.ConnectionString = connectionString;
                IDbCommand cmd = new SqlCommand();
                string query = "INSERT INTO flowers (productID, title, description, price, quantity)"+
                               // "VALUES ("+theProduct.ID+ ","+ theProduct.Title+ " , " + theProduct.Description + "" @Title, @Description, @Price, @Quantity)";
                              "VALUES (@Id, @Title, @Description, @Price, @Quantity)";
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@Id", theProduct.ID));
                cmd.Parameters.Add(new SqlParameter("@Title", theProduct.Title));
                cmd.Parameters.Add(new SqlParameter("@Description", theProduct.Description));
                cmd.Parameters.Add(new SqlParameter("@UnitPrice", theProduct.UnitPrice));
                cmd.Parameters.Add(new SqlParameter("@Quantity", theProduct.Quantity));

                cmd.ExecuteNonQuery();
                status = true;
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch ( SqlException exp)
            {
                string message = exp.Message;
            }
              return status;
        }
        public static bool Update(Product theProduct)
        {
            bool status = false;
            //using connected data access mode
            try
            {
                IDbConnection con = new SqlConnection();
                con.ConnectionString = connectionString; 
                IDbCommand cmd = new SqlCommand();
                cmd.Connection = con;
                string query = "UPDATE flowers SET title=@Title, description=@Description, price=@UnitPrice, quantity=@Quantity " +
                               "WHERE  productID=@Id";
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@Id", theProduct.ID));
                cmd.Parameters.Add(new SqlParameter("@Title", theProduct.Title));
                cmd.Parameters.Add(new SqlParameter("@Description", theProduct.Description));
                cmd.Parameters.Add(new SqlParameter("@UnitPrice", (int)theProduct.UnitPrice));
                cmd.Parameters.Add(new SqlParameter("@Quantity", theProduct.Quantity));
                con.Open();
                cmd.ExecuteNonQuery();
                status = true;
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }
            return status;
        }
        public static bool Delete(int  productID)
        {
            bool status = false;
            //using connected data access mode
            try
            {
                IDbConnection con = new SqlConnection();
                con.ConnectionString = connectionString;
                IDbCommand cmd = new SqlCommand();
                cmd.Connection = con;
                string query = "DELETE FROM flowers WHERE  productID=@Id";
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@Id", productID));
                con.Open();
                cmd.ExecuteNonQuery();
                status = true;
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }
            return status;
        }
    }
}
