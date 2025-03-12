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
using System.Net;
using System.Net.Mail;

namespace اسم_المستخدم_وكلمه_المرور
{
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection(@"server=STAKYWS\SQLEXPRESS;DataBase=C;integrated security=true");
        public Form6()
        {
            InitializeComponent();
        }
        

        int x = 0;
        //int vCod=1000;
        private void button1_Click(object sender, EventArgs e)
        {
            //timer1.Stop();
            //string to, from, mail, pass;
            //to = textBox1.Text;
            //from = "stakywsnablyws@gmail.com";//Your gmail goes her
            //mail = vCod + "0341036620"; //7003464360
            //pass = "cout<<HM<<endl;"; //Your app passowrd goes here
            //MailMessage message = new MailMessage();
            //message.To.Add(to);
            //message.From = new MailAddress(from);
            //message.Body = mail;
            //message.Subject = "Your app neme - Verification Cod";//Mail Subject
            //SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            //smtp.EnableSsl = true;
            //smtp.Port = 587;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtp.Credentials = new NetworkCredential(from, pass);
            //try
            //{
            //    smtp.Send(message);
            //    MessageBox.Show("تم ارسال رمز التحقق بنجاح ! إذهب إلى جيميل", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    button6.Enabled = true;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //====================================================================================================//

            /* جلب البيانات من الجدول */
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Userss where User_name='"+textBox1.Text+"' and Phone='" + textBox2.Text + "' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("تم التأكد من انك المستخدم الصحيح", "تم التأكد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                groupBox1.Visible = false;
                groupBox3.Visible = false;
                groupBox2.Visible = true;
            }
            else
            {
                MessageBox.Show("اسم المستخدم او رقم الهاتف غير صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.PasswordChar = '\0';
            }
            else
                textBox3.PasswordChar = '*';
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox4.PasswordChar = '\0';
            }
            else
                textBox4.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Userss set Password='" + textBox3.Text + "', Password_Agin='" + textBox4.Text + "' where User_Name='"+textBox1.Text+"'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            if (textBox4.Text == textBox3.Text)
            {
                MessageBox.Show("تم تعديل كلمه المرور بنجاح يرجى التسجيل بحسابك", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("كلمه المرور ليست مطابقه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {// التحقق من اسم المستخدم عن طريق الكود المرسل إلى جمايل
            //if (textBox6.Text.Count() == 4)
            //{
            //    button6.Enabled = true;
            //}
            //if (textBox6.Text == vCod + "")
            //{
            //    groupBox3.Enabled = false;
            //    groupBox2.Enabled = true;
                
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //vCod += 10;
            //if (vCod == 9999)
            //{
            //    vCod = 1000;
            //}
        }

        
    }
}
