using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace project_Product.businiss_layer
{
    class product_class
    {
        public DataTable Get_all_catagory()
        {
            Data_acess_layer.DataAcess_layer dal = new Data_acess_layer.DataAcess_layer();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.select("Get_all_catagory", null); 
            dal.close();
            return dt;
        }
        public void ADD_PRoduct(int ID_cat, string id_product, string lebel_product, int Qte_instock, string price, byte[] image_product)
        {
            Data_acess_layer.DataAcess_layer dal = new Data_acess_layer.DataAcess_layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0]=new SqlParameter("@ID_cat",SqlDbType.Int );
            param[0].Value=ID_cat;

            param[1] = new SqlParameter("@id_product", SqlDbType.VarChar,50);
            param[1].Value = id_product;

            param[2] = new SqlParameter("@lebel_product", SqlDbType.VarChar,50);
            param[2].Value = lebel_product;

            param[3] = new SqlParameter("@Qte_instock", SqlDbType.Int);
            param[3].Value = Qte_instock;

            param[4] = new SqlParameter("@price", SqlDbType.VarChar,50);
            param[4].Value = price;

            param[5] = new SqlParameter("@image_product", SqlDbType.Image);
            param[5].Value = image_product;
            dal.ExecuteCommand("Add_product", param);
            dal.close();

        }
        public DataTable vertify_productID(string Product_ID)
        {
            Data_acess_layer.DataAcess_layer dal = new Data_acess_layer.DataAcess_layer();
            dal.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_product", SqlDbType.VarChar, 50);
            param[0].Value = Product_ID;
            dt = dal.select("vertify_productID", param);
            dal.close();
            return dt;
        }
        public DataTable Get_all_Product()
        {
            Data_acess_layer.DataAcess_layer dal = new Data_acess_layer.DataAcess_layer();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.select("Get_all_Product", null);
            dal.close();
            return dt;
        }
        public DataTable Search_Product(string Product_ID)
        {
            Data_acess_layer.DataAcess_layer dal = new Data_acess_layer.DataAcess_layer();
            dal.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Word_search", SqlDbType.VarChar, 50);
            param[0].Value = Product_ID;
            dt = dal.select("Search_Product", param);
            dal.close();
            return dt;
        }
        public void Delete_product(string ID_cat)
        {
            Data_acess_layer.DataAcess_layer dal = new Data_acess_layer.DataAcess_layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = ID_cat;
            dal.ExecuteCommand("Delete_product", param);
            dal.close();

        }
        public DataTable Get_pic(string Product_ID)
        {
            Data_acess_layer.DataAcess_layer dal = new Data_acess_layer.DataAcess_layer();
            dal.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = Product_ID;
            dt = dal.select("Get_pic", param);
            dal.close();
            return dt;
        }
        public void Update_proudect(int ID_cat, string id_product, string lebel_product, int Qte_instock, string price, byte[] image_product)
        {
            Data_acess_layer.DataAcess_layer dal = new Data_acess_layer.DataAcess_layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_cat", SqlDbType.Int);
            param[0].Value = ID_cat;

            param[1] = new SqlParameter("@id_product", SqlDbType.VarChar, 50);
            param[1].Value = id_product;

            param[2] = new SqlParameter("@lebel_product", SqlDbType.VarChar, 50);
            param[2].Value = lebel_product;

            param[3] = new SqlParameter("@Qte_instock", SqlDbType.Int);
            param[3].Value = Qte_instock;

            param[4] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[4].Value = price;

            param[5] = new SqlParameter("@image_product", SqlDbType.Image);
            param[5].Value = image_product;
            dal.ExecuteCommand("Update_proudect", param);
            dal.close();

        }
    }
}
