using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Fix DateTime error. (Is it stored as a string or DateTime type?)
//Check Entertainment query, unable to find item?
//Refactor 
//Make ExeNonQuery method (Takes in sqlString)

namespace ProductPOS___Ryan_Ross
{
    class ProductDB
    {
        public static OleDbConnection GetConnection()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=|DataDirectory|\\ProductDB.accdb;" +
                "Persist Security Info=True";
            OleDbConnection connection = new OleDbConnection(connectionString);
            return connection;
        }

        public static bool ExeNonQuery(string sqlString)
        {
            OleDbConnection connection = GetConnection();
            OleDbCommand command = new OleDbCommand(sqlString, connection);

            try
            {
                connection.Open();
                int count = command.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }


        public static Product SelectProduct(String productID)
        {
            OleDbConnection connection = GetConnection();
            string selectStatement = "SELECT ID, Desc, Price, Qty, Type " +
                "From Product Where ID = '" + productID + "'";
            OleDbCommand selectCommand = new OleDbCommand(selectStatement, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = selectCommand.ExecuteReader();
                if (reader.Read())
                {
                    Product p = new Product();
                    p.ID = reader.GetString(0);
                    p.Desc = reader.GetString(1);
                    p.Price = reader.GetDouble(2);
                    p.Qty = reader.GetInt32(3);
                    p.Type = reader.GetString(4);
                    return p;

                }
                else
                {
                    return null;
                }
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static Pants SelectPants(string id)
        {
            Pants p = null;

            OleDbConnection connection = GetConnection();

            string select = "SELECT Product.ID, Product.Desc, Product.Price, "
                + "Product.Qty, Product.Type, Apparel.Material, Apparel.Color, Apparel.Manufacturer, "
                + "Pants.Waist, Pants.Inseam FROM (Product INNER JOIN Apparel ON Product.ID = Apparel.ID)"
                + "INNER JOIN Pants ON Apparel.ID = Pants.ID WHERE Product.ID = '" + id + "';";

            OleDbCommand command = new OleDbCommand(select, connection);
            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    p = new Pants();
                    p.ID = reader.GetString(0);
                    p.Desc = reader.GetString(1);
                    p.Price = reader.GetDouble(2);
                    p.Qty = reader.GetInt32(3);
                    p.Type = reader.GetString(4);
                    p.Material = reader.GetString(5);
                    p.Color = reader.GetString(6);
                    p.Manufacturer = reader.GetString(7);
                    p.Waist = reader.GetInt32(8);
                    p.Inseam = reader.GetInt32(9);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                p = null;
            }
            finally
            {
                connection.Close();
            }

            return p;
        }

        public static DressShirt SelectDressShirt(string id)
        {
            DressShirt p = null;

            OleDbConnection connection = GetConnection();

            string select = "SELECT Product.ID, Product.Desc, Product.Price, "
                + "Product.Qty, Product.Type, Apparel.Material, Apparel.Color, Apparel.Manufacturer, "
                + "DressShirt.Neck, DressShirt.Sleeve FROM (Product INNER JOIN Apparel ON Product.ID = Apparel.ID) "
                + "INNER JOIN DressShirt ON Apparel.ID = DressShirt.ID WHERE Product.ID = '" + id + "';";

            OleDbCommand command = new OleDbCommand(select, connection);
            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    p = new DressShirt();
                    p.ID = reader.GetString(0);
                    p.Desc = reader.GetString(1);
                    p.Price = reader.GetDouble(2);
                    p.Qty = reader.GetInt32(3);
                    p.Type = reader.GetString(4);
                    p.Material = reader.GetString(5);
                    p.Color = reader.GetString(6);
                    p.Manufacturer = reader.GetString(7);
                    p.Neck = reader.GetInt32(8);
                    p.Sleeve = reader.GetInt32(9);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                p = null;
            }
            finally
            {
                connection.Close();
            }

            return p;
        }

        public static TShirt SelectTShirt(string id)
        {
            TShirt p = null;

            OleDbConnection connection = GetConnection();

            string select = "SELECT Product.ID, Product.Desc, Product.Price, "
                + "Product.Qty, Product.Type, Apparel.Material, Apparel.Color, Apparel.Manufacturer, "
                + "TShirt.SizeT FROM (Product INNER JOIN Apparel ON Product.ID = Apparel.ID)"
                + "INNER JOIN TShirt ON Apparel.ID = TShirt.ID WHERE Product.ID = '" + id + "';";

            OleDbCommand command = new OleDbCommand(select, connection);
            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    p = new TShirt();
                    p.ID = reader.GetString(0);
                    p.Desc = reader.GetString(1);
                    p.Price = reader.GetDouble(2);
                    p.Qty = reader.GetInt32(3);
                    p.Type = reader.GetString(4);
                    p.Material = reader.GetString(5);
                    p.Color = reader.GetString(6);
                    p.Manufacturer = reader.GetString(7);
                    p.Size = reader.GetString(8);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                p = null;
            }
            finally
            {
                connection.Close();
            }

            return p;
        }

        public static Book SelectBook(string id)
        {
            Book p = null;

            OleDbConnection connection = GetConnection();

            string select = "SELECT Product.ID, Product.Desc, Product.Price, "
                + "Product.Qty, Product.Type, Media.ReleaseDate, Book.NumPages, Book.Author, "
                + "Book.Publisher FROM(Product INNER JOIN Media ON Product.ID = Media.ID) "
                + "INNER JOIN Book ON Media.ID = Book.ID WHERE Product.ID = '" + id + "';";

            OleDbCommand command = new OleDbCommand(select, connection);
            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    p = new Book();
                    p.ID = reader.GetString(0);
                    p.Desc = reader.GetString(1);
                    p.Price = reader.GetDouble(2);
                    p.Qty = reader.GetInt32(3);
                    p.Type = reader.GetString(4);
                    p.ReleaseDate = reader.GetDateTime(5).ToShortDateString();
                    p.NumPages = reader.GetInt32(6);
                    p.Author = reader.GetString(7);
                    p.Publisher = reader.GetString(8);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                p = null;
            }
            finally
            {
                connection.Close();
            }

            return p;
        }

        public static Software SelectSoftware(string id)
        {
            Software p = null;

            OleDbConnection connection = GetConnection();

            string select = "SELECT Product.ID, Product.Desc, Product.Price, "
                + "Product.Qty, Product.Type, Media.ReleaseDate, Disk.SizeDisk, Disk.NumDisks, "
                + "Disk.TypeDisk, Software.TypeSoft FROM ((Product INNER JOIN Media ON Product.ID = Media.ID)"
                + "INNER JOIN Disk ON Media.ID = Disk.ID) " 
                + "INNER JOIN Software ON Disk.ID = Software.ID WHERE Product.ID = '" + id + "';";

            OleDbCommand command = new OleDbCommand(select, connection);
            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    p = new Software();
                    p.ID = reader.GetString(0);
                    p.Desc = reader.GetString(1);
                    p.Price = reader.GetDouble(2);
                    p.Qty = reader.GetInt32(3);
                    p.Type = reader.GetString(4);
                    p.ReleaseDate = reader.GetDateTime(5).ToShortDateString();
                    p.Size = reader.GetInt32(6);
                    p.NumDisks = reader.GetInt32(7);
                    p.TypeDisk = reader.GetString(8);
                    p.TypeSoft = reader.GetString(9);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                p = null;
            }
            finally
            {
                connection.Close();
            }

            return p;
        }

        public static Music SelectMusic(string id)
        {
            Music p = null;

            OleDbConnection connection = GetConnection();

            string select = "SELECT Product.ID, Product.Desc, Product.Price, "
                + "Product.Qty, Product.Type, Media.ReleaseDate, Disk.SizeDisk, Disk.NumDisks, "
                + "Disk.TypeDisk, Entertainment.Hours, Entertainment.Minutes, Entertainment.Seconds, "
                + "Music.Genre, Music.Artist, Music.Label FROM"  
                + "(((Product INNER JOIN Media ON Product.ID = Media.ID)"
                + "INNER JOIN Disk ON Media.ID = Disk.ID) "
                + "INNER JOIN Entertainment ON Disk.ID = Entertainment.ID) " 
                + "INNER JOIN Music ON Entertainment.ID = Music.ID WHERE Product.ID = '" + id + "';";

            OleDbCommand command = new OleDbCommand(select, connection);
            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    p = new Music();
                    p.ID = reader.GetString(0);
                    p.Desc = reader.GetString(1);
                    p.Price = reader.GetDouble(2);
                    p.Qty = reader.GetInt32(3);
                    p.Type = reader.GetString(4);
                    p.ReleaseDate = reader.GetDateTime(5).ToShortDateString();
                    p.Size = reader.GetInt32(6);
                    p.NumDisks = reader.GetInt32(7);
                    p.TypeDisk = reader.GetString(8);
                    string runTime = reader.GetInt32(9) + ":" + reader.GetInt32(10) + ":" + reader.GetInt32(11);
                    p.RunTime = runTime;
                    p.Genre = reader.GetString(12);
                    p.Artist = reader.GetString(13);
                    p.Label = reader.GetString(14);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                p = null;
            }
            finally
            {
                connection.Close();
            }

            return p;
        }

        public static Movie SelectMovie(string id)
        {
            Movie p = null;

            OleDbConnection connection = GetConnection();

            string select = "SELECT Product.ID, Product.Desc, Product.Price, "
                + "Product.Qty, Product.Type, Media.ReleaseDate, Disk.SizeDisk, Disk.NumDisks, "
                + "Disk.TypeDisk, Entertainment.Hours, Entertainment.Minutes, Entertainment.Seconds, "
                + "Movie.Director, Movie.Producer FROM"
                + "(((Product INNER JOIN Media ON Product.ID = Media.ID) "
                + "INNER JOIN Disk ON Media.ID = Disk.ID) "
                + "INNER JOIN Entertainment ON Disk.ID = Entertainment.ID) "
                + "INNER JOIN Movie ON Entertainment.ID = Movie.ID WHERE Product.ID = '" + id + "';";

            OleDbCommand command = new OleDbCommand(select, connection);
            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    p = new Movie();
                    p.ID = reader.GetString(0);
                    p.Desc = reader.GetString(1);
                    p.Price = reader.GetDouble(2);
                    p.Qty = reader.GetInt32(3);
                    p.Type = reader.GetString(4);
                    p.ReleaseDate = reader.GetDateTime(5).ToShortDateString();
                    p.Size = reader.GetInt32(6);
                    p.NumDisks = reader.GetInt32(7);
                    p.TypeDisk = reader.GetString(8);
                    string runTime = reader.GetInt32(9) + ":" + reader.GetInt32(10) + ":" + reader.GetInt32(11);
                    p.RunTime = runTime;
                    p.Director = reader.GetString(12);
                    p.Producer = reader.GetString(13);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                p = null;
            }
            finally
            {
                connection.Close();
            }

            return p;
        }

        public static bool InsertLineItem(int transID, string productID, int qty, double price)
        {
            string str = "INSERT INTO LineItem (TransID, ProductID, Qty, Price) VALUES (" + transID + ", '" + productID + "', " + qty + ", " + price + ");";
            return ProductDB.ExeNonQuery(str);
        }

        public static bool InsertTrans(double subtotal, double tax, double total)
        {
            string str = "INSERT INTO Trans (Subtotal, Tax, Total) VALUES (" + subtotal + ", " + tax + ", " + total + ");";
            return ProductDB.ExeNonQuery(str);
        }

        public static int SelectMaxTrans()
        {
            OleDbConnection connection = GetConnection();
            string str = "SELECT MAX(ID) FROM Trans;";
            OleDbCommand command = new OleDbCommand(str, connection);
            int maxID = 0;
            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                   maxID = reader.GetInt32(0);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return maxID;
        }

        public static bool UpdateProduct(string id, int quantity)
        {
            string str = "UPDATE Product SET Qty = " + quantity + " WHERE ID = '" + id + "';";
            return ProductDB.ExeNonQuery(str);
        }

        public static Product[] SelectLikeDesc(string search)
        {
            Product[] productArray = null;
            OleDbConnection connection = GetConnection();

            string str = "SELECT ID, Desc, Price, Qty, Type FROM Product WHERE Desc LIKE '%" + search + "%';";

            OleDbCommand command = new OleDbCommand(str, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                productArray = new Product[reader.FieldCount]; //Gets the number of columns in the current row that is being read
                int i = 0;

                while (reader.Read())
                {
                    productArray[i] = new Product();
                    productArray[i].ID = reader.GetString(0);
                    productArray[i].Desc = reader.GetString(1);
                    productArray[i].Price = reader.GetDouble(2);
                    productArray[i].Qty = reader.GetInt32(3);
                    productArray[i].Type = reader.GetString(4);//i++?
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                productArray = null;
            }
            finally
            {
                connection.Close();
            }

            return productArray;
        }


    }
}
