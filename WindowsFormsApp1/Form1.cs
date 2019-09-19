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
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=studentInfo;");
            string sql = "INSERT INTO users(name,email,address) VALUES (@name,@email,@address)";
            MySqlCommand com = new MySqlCommand(sql, con);
            com.Parameters.AddWithValue("@name", txt_name.Text);
            com.Parameters.AddWithValue("@email", txt_email.Text);
            com.Parameters.AddWithValue("@address", txt_address.Text);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();

            if (i != 0)
            {
                MessageBox.Show(i + "Data Saved");
            }


        }
        public static void main(string[] args)
        {

            Application.Run(new Form1());

        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_KeyDown(object sender)
        {
          
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_name.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            student_form form = new student_form();
            form.ShowDialog();
        }
    }
}
