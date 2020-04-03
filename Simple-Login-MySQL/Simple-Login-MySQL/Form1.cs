using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Simple_Login_MySQL
{
    public partial class Form1 : Form
    {
        public MySqlCommand sql_cmd = new MySqlCommand();
        public string sID;
        public string sql = "";
        public string user;
        public string pass;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsMySQL.sql_con.Close();
            clsMySQL.sql_con.Open(); // open connection for the database

            sql = "SELECT *FROM tbuser";
            sql_cmd = new MySqlCommand(sql, clsMySQL.sql_con);
            MySqlDataReader rd = sql_cmd.ExecuteReader();
            while (rd.Read())
            {

                user = rd["username"].ToString();
                pass = rd["password"].ToString();

            }
            rd.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            welcome op = new welcome();

            if (textBox1.Text == user && textBox2.Text == pass)
            {
                op.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
                    
        }
    }
}
