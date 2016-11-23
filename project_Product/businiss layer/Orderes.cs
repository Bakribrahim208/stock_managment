using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace project_Product.businiss_layer
{
    class Orderes
    {
        Data_acess_layer.DataAcess_layer dal = new Data_acess_layer.DataAcess_layer();
        public DataTable GET_LAST_ORDER()
        {

            dal.open();
            DataTable dt = new DataTable();
            dt = dal.select("GET_LAST_ORDER", null);
            dal.close();
            return dt;
        }
        public DataTable GET_LAST_ORDER_for_Print()
        {

            dal.open();
            DataTable dt = new DataTable();
            dt = dal.select("GET_LAST_ORDER_for_Print", null);
            dal.close();
            return dt;
        }
        public DataTable All_Custmor()
        {

            dal.open();
            DataTable dt = new DataTable();
            dt = dal.select("All_Custmor", null);
            dal.close();
            return dt;
        }
        public DataTable Get_all_Product()
        {

            dal.open();
            DataTable dt = new DataTable();
            dt = dal.select("Get_all_Product", null);
            dal.close();
            return dt;
        }

        public void Add_Order(int id_order, DateTime date_order, int customar_id, string ORDER_DESCRIPTION, string sales_person)
        {

            dal.open();
            SqlParameter[] param = new SqlParameter[5];


            param[0] = new SqlParameter("@id_order", SqlDbType.Int);
            param[0].Value = id_order;

            param[1] = new SqlParameter("@date_order", SqlDbType.DateTime);
            param[1].Value = date_order;

            param[2] = new SqlParameter("@customar_id ", SqlDbType.Int);
            param[2].Value = customar_id;

            param[3] = new SqlParameter("@ORDER_DESCRIPTION", SqlDbType.VarChar, 50);
            param[3].Value = ORDER_DESCRIPTION;

            param[4] = new SqlParameter("@sales_person ", SqlDbType.VarChar, 50);
            param[4].Value = sales_person;
            dal.ExecuteCommand("Add_Order", param);
            dal.close();

        }


        public void ADD_ORDER_DETAILS(string id_product, int id_order, int qte_, string Price, float Discount, string Amount_of_money, string TOTAL_OF_MONEY)
        {

            dal.open();
            SqlParameter[] param = new SqlParameter[7];


            param[0] = new SqlParameter("@id_product ", SqlDbType.VarChar, 50);
            param[0].Value = id_product;

            param[1] = new SqlParameter("@id_order", SqlDbType.Int);
            param[1].Value = id_order;

            param[2] = new SqlParameter("@qte_ ", SqlDbType.Int);
            param[2].Value = qte_;

            param[3] = new SqlParameter("@Price ", SqlDbType.VarChar, 50);
            param[3].Value = Price;

            param[4] = new SqlParameter("@Discount  ", SqlDbType.Float);
            param[4].Value = Discount;
            param[5] = new SqlParameter("@Amount_of_money  ", SqlDbType.VarChar, 50);
            param[5].Value = Amount_of_money;
            param[6] = new SqlParameter("@TOTAL_OF_MONEY  ", SqlDbType.VarChar, 50);
            param[6].Value = TOTAL_OF_MONEY;
            dal.ExecuteCommand("ADD_ORDER_DETAILS", param);
            dal.close();

        }


        public DataTable vertify_product(string id_product, int qte_entered)
        {

            dal.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_product", SqlDbType.VarChar, 50);
            param[0].Value = id_product;
            param[1] = new SqlParameter("@qte_entered", SqlDbType.Int);
            param[1].Value = qte_entered;
            dt = dal.select("vertify_product", param);
            dal.close();
            return dt;
        }
        public DataTable Get_Order_details(int id_product)
        {

            dal.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_order", SqlDbType.Int);
            param[0].Value = id_product;

            dt = dal.select("Get_Order_details", param);
            dal.close();
            return dt;
        }
        public DataTable search_Order(string search_word)
        {

            dal.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@search_word", SqlDbType.VarChar, 50);
            param[0].Value = search_word;

            dt = dal.select("search_Order", param);
            dal.close();
            return dt;
        }
        public DataTable list_OF_OREDRES(int id_product)
        {


            dal.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_ORDERD", SqlDbType.Int);
            param[0].Value = id_product;

            dt = dal.select("list_OF_OREDRES", param);
            dal.close();
            return dt;
        }
    }
}
