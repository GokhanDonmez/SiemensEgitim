using Microsoft.Data.SqlClient;
using MilcanX.Class.DTO;
using MilcanX.Class.OTHER;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilcanX.Class.DAL
{
    public class ProductDAL
    {
        static readonly SqlConnection conn = new SqlConnection(Connection.ConnectionString);
        static string sql = string.Empty;
        static bool result;
        static SqlCommand cmd;

        public static int getProductID()
        {
            int _id = 0;
            string _take = string.Format("SELECT TOP 1 ProductID FROM Products ORDER BY ProductID DESC");
            cmd= new SqlCommand(_take, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    _id = Convert.ToInt32(reader[0]);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return _id + 1;
        }
        public static List<ProductDTO> GetAll()
        {
            string _take = string.Format("SELECT * FROM Products ORDER BY ProductID DESC");
            cmd = new SqlCommand(_take, conn);
            List<ProductDTO> result = new List<ProductDTO>();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ProductDTO item = new ProductDTO();
                    item.ProductID = reader[0].ToString();
                    item.ProductName = reader[1].ToString();
                    item.SupplierID = reader[2].ToString();
                    item.CategoryID = reader[3].ToString();
                    item.QuantityPerUnit = reader[4].ToString();
                    item.UnitPrice = (decimal)reader[5];
                    item.UnitsInStock = Convert.ToUInt16(reader[6]);
                    item.UnitsOnOrder = Convert.ToUInt16(reader[7]);
                    item.ReorderLevel = Convert.ToUInt16(reader[8]);
                    item.Discontinued = (bool)reader[9];
                    result.Add(item);
                }

            }
            catch
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public static List<ProductDTO> FilteredList(string text)
        {
            SqlCommand cmd = new SqlCommand("Select * from Products WHERE ProductName = '" + text + "'", conn);
            List<ProductDTO> result = new List<ProductDTO>();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ProductDTO item = new ProductDTO();
                    item.ProductID = reader[0].ToString();
                    item.ProductName = reader[1].ToString();
                    item.SupplierID = reader[2].ToString();
                    item.CategoryID = reader[3].ToString();
                    item.QuantityPerUnit = reader[4].ToString();
                    item.UnitPrice = (decimal)reader[5];
                    item.UnitsInStock = Convert.ToUInt16(reader[6]);
                    item.UnitsOnOrder = Convert.ToUInt16(reader[7]);
                    item.ReorderLevel = Convert.ToUInt16(reader[8]);
                    item.Discontinued = (bool)reader[9];
                    result.Add(item);
                }

            }
            catch
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public static bool AddElementToTable(string ProductName,
                                              string SupplierID,
                                              string CategoryID,
                                              string QuantityPerUnit,
                                              decimal UnitPrice,
                                              int UnitsInStock,
                                              int UnitsOnOrder,
                                              int ReorderLevel,
                                              bool Discontinued
                                              )
        {

            string _ProductName = ProductName;
            string _SupplierID = SupplierID;
            string _CategoryID = CategoryID;
            string _QuantityPerUnit = QuantityPerUnit;
            decimal _UnitPrice = UnitPrice;
            int _UnitsInStock = UnitsInStock;
            int _UnitsOnOrder = UnitsOnOrder;
            bool _Discontinued = Discontinued;
            int _ReorderLevel = ReorderLevel;
            


            cmd = new SqlCommand("insert into Products values(" +
                                           "@Name," +
                                           "@SupplierID," +
                                           "@CategoryID," +
                                           "@QuantityPerUnit," +
                                           "@UnitPrice," +
                                           "@UnitsInStock," +
                                           "@UnitsOnOrder," +
                                           "@ReorderLevel," +
                                           "@Discontinued)", conn);


            cmd.Parameters.AddWithValue("@Name", _ProductName);
            cmd.Parameters.AddWithValue("@SupplierID", _SupplierID);
            cmd.Parameters.AddWithValue("@CategoryID", _CategoryID);
            cmd.Parameters.AddWithValue("@QuantityPerUnit", _QuantityPerUnit);
            cmd.Parameters.AddWithValue("@UnitPrice", _UnitPrice);
            cmd.Parameters.AddWithValue("@UnitsInStock", _UnitsInStock);
            cmd.Parameters.AddWithValue("@UnitsOnOrder", _UnitsOnOrder);
            cmd.Parameters.AddWithValue("@ReorderLevel", _ReorderLevel);
            cmd.Parameters.AddWithValue("@Discontinued", _Discontinued);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                int _sonuc = cmd.ExecuteNonQuery();
                if (_sonuc > 0)
                {
                    result = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return result;

        }

        public static bool DeleteItemFromTable(int id)
        {
            sql = "DELETE FROM Products WHERE ProductID = " + id;
            cmd = new SqlCommand(sql, conn);

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    result = true;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return result;
        }

        public static bool Update(int ProductID,
                                  string ProductName,
                                  string SupplierID,
                                  string CategoryID,
                                  string QuantityPerUnit,
                                  decimal UnitPrice,
                                  int UnitsInStock,
                                  int UnitsOnOrder,
                                  int ReorderLevel,
                                  bool Discontinued
                                  )
        {


            int _ProductID = ProductID;
            string _ProductName = ProductName;
            string _SupplierID = SupplierID;
            string _CategoryID = CategoryID;
            string _QuantityPerUnit = QuantityPerUnit;
            decimal _UnitPrice = UnitPrice;
            int _UnitsInStock = UnitsInStock;
            int _UnitsOnOrder = UnitsOnOrder;
            bool _Discontinued = Discontinued;
            int _ReorderLevel = ReorderLevel;



            cmd = new SqlCommand("update Products SET " +

                                           "ProductName=@ProductName," +
                                           "SupplierID=@SupplierID," +
                                           "CategoryID=@CategoryID," +
                                           "QuantityPerUnit=@QuantityPerUnit," +
                                           "UnitPrice=@UnitPrice," +
                                           "UnitsInStock=@UnitsInStock," +
                                           "UnitsOnOrder=@UnitsOnOrder," +
                                           "ReorderLevel=@ReorderLevel," +
                                           "Discontinued=@Discontinued " +
                                           "WHERE ProductID=@ProductID", conn);

            cmd.Parameters.AddWithValue("@ProductID", _ProductID);
            cmd.Parameters.AddWithValue("@ProductName", _ProductName);
            cmd.Parameters.AddWithValue("@SupplierID", _SupplierID);
            cmd.Parameters.AddWithValue("@CategoryID", _CategoryID);
            cmd.Parameters.AddWithValue("@QuantityPerUnit", _QuantityPerUnit);
            cmd.Parameters.AddWithValue("@UnitPrice", _UnitPrice);
            cmd.Parameters.AddWithValue("@UnitsInStock", _UnitsInStock);
            cmd.Parameters.AddWithValue("@UnitsOnOrder", _UnitsOnOrder);
            cmd.Parameters.AddWithValue("@ReorderLevel", _ReorderLevel);
            cmd.Parameters.AddWithValue("@Discontinued", _Discontinued);

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    result = true;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return result;
        }

    }
}
