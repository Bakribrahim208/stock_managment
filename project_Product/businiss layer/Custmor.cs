using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace project_Product.businiss_layer
{
    class Custmor
    {
        public void ADD_PRoduct( string @firstname, string @lastname, string @tel, string @email, byte[] @image_customar)
        {
            Data_acess_layer.DataAcess_layer dal = new Data_acess_layer.DataAcess_layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[5];
            

            param[0] = new SqlParameter("@firstname", SqlDbType.VarChar, 50);
            param[0].Value = @firstname;

            param[1] = new SqlParameter("@lastname", SqlDbType.VarChar, 50);
            param[1].Value = @lastname;

            param[2] = new SqlParameter("@tel", SqlDbType.VarChar,15);
            param[2].Value = @tel;

            param[3] = new SqlParameter("@email", SqlDbType.VarChar, 25);
            param[3].Value = @email;

            param[4] = new SqlParameter("@image_customar", SqlDbType.Image);
            param[4].Value = @image_customar;
            dal.ExecuteCommand("Add_custmor", param);
            dal.close();

        }


        public void EDITE_CUSTOMER(int id_custmor, string @firstname, string @lastname, string @tel, string @email, byte[] @image_customar)
        {
            Data_acess_layer.DataAcess_layer dal = new Data_acess_layer.DataAcess_layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];


            param[0] = new SqlParameter("@firstname", SqlDbType.VarChar, 50);
            param[0].Value = @firstname;

            param[1] = new SqlParameter("@lastname", SqlDbType.VarChar, 50);
            param[1].Value = @lastname;

            param[2] = new SqlParameter("@tel", SqlDbType.VarChar, 15);
            param[2].Value = @tel;

            param[3] = new SqlParameter("@email", SqlDbType.VarChar, 25);
            param[3].Value = @email;

            param[4] = new SqlParameter("@image_customar", SqlDbType.Image);
            param[4].Value = @image_customar;

            param[5] = new SqlParameter("@id_custmor", SqlDbType.Int );
            param[5].Value = id_custmor;


            dal.ExecuteCommand("EDITE_CUSTOMER", param);
            dal.close();

        }

        public DataTable All_Custmor()
        {
            Data_acess_layer.DataAcess_layer dal = new Data_acess_layer.DataAcess_layer();
            dal.open();
            DataTable dt = new DataTable();
            dt = dal.select("All_Custmor", null);
            dal.close();
            return dt;
        }

        public void Delete_User(int  ID_cat)
        {
            Data_acess_layer.DataAcess_layer dal = new Data_acess_layer.DataAcess_layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int );
            param[0].Value = ID_cat;
            dal.ExecuteCommand("Delete_User", param);
            dal.close();

        }



    }
}
