using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace اسم_المستخدم_وكلمه_المرور
{

    public partial class Form1 : Form2
    {
        SqlConnection con = new SqlConnection(@"server=STAKYWS\SQLEXPRESS;DataBase=C;integrated security=true");

        /* ربط البرنامج بقاعده البيانات */
        //SqlConnection con = new SqlConnection();
        //string server_name = @"STAKYWS\SQLEXPRESS";
        //string database_name = "C";
        //con.ConnectionString = @"Data source=" + server_name + "; Initial catalog=" + database_name + "; Integrated Security=True ";
        public Form1()
        {
            InitializeComponent();
        }

        public void txt(string s)
        {
            textBox1.Text = s;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /* خاصيه الباسوورد */
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
                textBox2.PasswordChar = '*';
        }

        public void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            /* جلب البيانات من الجدول */
            SqlCommand cmd = new SqlCommand("select * from Userss where User_Name='"+textBox1.Text+"' and Password='"+textBox2.Text+"' ",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("تم تسجيل الدخول بنجاح","تسجيل الدخول",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("اسم المستخدم او كلمه المرور غير موجود", "التسجيل", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                linkLabel2.Visible = true;
                con.Close();

            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }
    }
}
