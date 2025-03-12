//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;

//namespace اسم_المستخدم_وكلمه_المرور
//{

//    public static class myconiction
//    {
//        public static SqlConnection con;
//        public static void set_my_coniction()
//        {
//            con = new SqlConnection(@"Data Source = STAKYWS\SQLEXPRESS; Initial Catalog = C#; integrated security = true");
//            con.Open();
//        }

//        public static void add_sql(string sql)
//        {
//            SqlCommand cmd = new SqlCommand();
//            cmd.Connection = con;
//            cmd.CommandText = sql;
//            cmd.ExecuteNonQuery(); /* قم بتنفيذ الاوامر حسب ماهو معدل على جدول قاعده البيانات
//                                    * delet و update و insert تستخدم فقط معى ال */

//            con.Close(); // قم باغلاق الاتصال
//        }
//    }
//}
