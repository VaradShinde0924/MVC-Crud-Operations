using MVCCrudAdo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVCCrudAdo.Service
{
    public class UserDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        public List<UserModel> GetUsers()
        {
            cmd=new SqlCommand("sp_select",con);
            cmd.CommandType = CommandType.StoredProcedure;
            sda=new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            List<UserModel> list = new List<UserModel>();
            foreach(DataRow dr in dt.Rows)
            {
                list.Add(new UserModel
                {
                    id = Convert.ToInt32( dr["id"]),
                    name = dr["name"].ToString(),
                    email = dr["email"].ToString(),
                    age = Convert.ToInt32(dr["age"]),
                    mobile = dr["mobile"].ToString()
                });
            }
            return list;
        }

    }
}