using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class conectar : Form
    {
        public conectar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexions = @"Server=(LocalDB)\MSSQLLocalDB;Database= master;Trusted_Connection=True;";
            string conexion2 = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(conexions))
                {
                    connection.Open();
                    MessageBox.Show("servidor: " + connection.DataSource+"\n database: " +connection.Database);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no fue posible establecer la conexion "+ ex.Message );
            }
            
        }

    }
}
