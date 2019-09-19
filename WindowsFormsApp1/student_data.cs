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
using MySql.Data;
namespace WindowsFormsApp1
{
    public partial class student_form : Form
    {
        public student_form()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void student_form_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=studentInfo;");
            string sql = "SELECT * FROM users";
            MySqlDataAdapter adr = new MySqlDataAdapter(sql, con);
            adr.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            adr.Fill(dt);

            // method 1 - direct method
            //dataGridView1.DataSource = dt;

            // method 2 - data grid view columns
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
        }
    }
}
