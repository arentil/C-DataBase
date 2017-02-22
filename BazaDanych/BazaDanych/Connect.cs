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
using MySql.Data.Types;

namespace BazaDanych
{
    public partial class Connect : Form
    {
        public MySqlConnection conn { get; set; }
        public bool is_connected { get; set; }

        public Connect()
        {
            InitializeComponent();
        }

        private void Connect_Load(object sender, EventArgs e)
        {
            this.textServerAddress.Text = "localhost";
            this.textDatabase.Text = "myDataBase1";
            this.textUser.Text = "root";
            this.textPassword.Text = "root";
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            this.conn = new MySqlConnection();
            is_connected = false;

            try
            {
                conn.ConnectionString =
                "Server = " + textServerAddress.Text + ";" +
                "Database = " + textDatabase.Text + ";" +
                "Uid = " + textUser.Text + ";" +
                "Pwd = " + textPassword.Text + ";";
                conn.Open();
                MessageBox.Show("Successful connection to the database.");
                is_connected = true;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Unable to connect to database.\n\n" + e1.ToString());
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textServerAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDatabase_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            textPassword.PasswordChar = '*';
        }
    }
}
