using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace ApsUnip
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtLogin.Text ="";
            txtSenha.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            toConnectDb stringConnection = new toConnectDb();
            MySqlConnection connection = new MySqlConnection(stringConnection.connString);
            var command = connection.CreateCommand();

        
            try
            {
                connection.Open();
                command.CommandText = "select * from USUARIOS WHERE USUARIOS.LOGIN = " + txtLogin.Text + " AND USUARIOS.SENHA = " + txtLogin.Text;
                command.ExecuteNonQuery();

            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

                
            }

        }
    }
}
