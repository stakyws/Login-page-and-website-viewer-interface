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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@"server=STAKYWS\SQLEXPRESS;DataBase=C;integrated security=true");

        public Form5()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.PasswordChar='\0';
            }
            else
                textBox4.PasswordChar='*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* اضافه بيانات الى قاعده البيانات وحفظها */
            //con.Open();
            //string sql = "insert into Userss values (@First_Name,@Last_Name,@User_Name,@Password,@Password_Agin,@Phone)";
            //SqlCommand cmd = new SqlCommand(sql,con);
            //cmd.Parameters.AddWithValue("@First_Name", textBox1.Text);
            //cmd.Parameters.AddWithValue("@Last_Name", textBox2.Text);
            //cmd.Parameters.AddWithValue("@User_Name", textBox3.Text);
            //cmd.Parameters.AddWithValue("@Password", textBox4.Text);
            //cmd.Parameters.AddWithValue("@Password_Agin", textBox5.Text);
            //cmd.Parameters.AddWithValue("@Phone", textBox6.Text);
            //cmd.ExecuteNonQuery();
            //con.Close();

            if (textBox5.Text != textBox4.Text)
            {
                MessageBox.Show("كلمه المرور ليست مطابقه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (textBox5.Text.Count() < 4 && textBox4.Text.Count() < 4) {linkLabel2.Visible = true;}

            else if (textBox3.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("اسم المستخدم غير مقبول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                /* اضافه بيانات الى قاعده البيانات وحفظها */
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Userss (First_Name,Last_Name,User_Name,Password,Password_Agin,Phone) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("تم التسجيل بنجاح الرجاء الدخول بحسابك", "التسجيل", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox5.PasswordChar = '\0';
            }
            else
                textBox5.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
}
