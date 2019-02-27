using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DemoPhanLoaiSanPham
{
    class CodefViewProduct
    {
        //biến toàn cục
        SqlConnection conn;//Khai báo đối tượng thực hiện kết nối đến cơ sở dữ liệu

        //public SqlConnection GetConnection() 
        //{
        //    conn = new SqlConnection("Server=DESKTOP-E845J9V\\SQLEXPRESS;database=asm2;uid=sa;pwd=1");
        //    return conn;
        //}//ham ket noi den database

        public DataSet GetCategory()
        {
            conn = new SqlConnection("Server=DESKTOP-E845J9V\\SQLEXPRESS;database=asm2;uid=sa;pwd=1");
            DataSet ds = new DataSet(); //tạo đối tượng DataSet
            //load du lieu tu table
            string str = "SELECT _id AS [ID], _name AS [Category] FROM[dbo].[_Category]";
            //tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL va đối tượng Connection
            SqlDataAdapter sqldap = new SqlDataAdapter(str, conn);
            //dua du lieu vao dataset
            sqldap.Fill(ds, "Category");
            return ds;
        }//load du lieu table Category
        public DataSet GetProductByCate(String idcate)
        {
            conn = new SqlConnection("Server=DESKTOP-E845J9V\\SQLEXPRESS;database=asm2;uid=sa;pwd=1");
            DataSet ds = new DataSet(); //tạo đối tượng DataSet
            //load du lieu tu table
            string str = "SELECT _productID AS [ID],_category AS [Category]" +
                ",_productNAME AS [Name],_productVENDOR AS[VENDOR],_quantityInStock AS[Quantity]" +
                ",_productDescription AS [Description],_buyprice AS [Price] FROM[dbo].[_Product] WHERE " +
                "_category='" + idcate + "'";
            //tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL va đối tượng Connection
            SqlDataAdapter sqldap = new SqlDataAdapter(str, conn);
            //dua du lieu vao dataset
            sqldap.Fill(ds, "Product");
            return ds;
        }//
    }
}
