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
    public partial class InsertRow : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private string fields = "(";
        private string table = "";

        public InsertRow(MySqlConnection con, string selectedItem)
        {
            InitializeComponent();
            conn = con;
            label1.Text += selectedItem;
            table = selectedItem;
            dataGridView1.AllowUserToAddRows = false;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM " + selectedItem;
            MySqlDataReader reader = cmd.ExecuteReader();

            for (var f = 0; f < reader.FieldCount; f++)
            {
                string field = reader.GetName(f);
                dataGridView1.Columns.Add("column" + f, field);
                fields += field + ", ";
            }
            fields = fields.Remove(fields.Length - 2);
            fields += ")";
            dataGridView1.Rows.Add();
            reader.Close();
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            string row = "(";
            foreach (DataGridViewCell cell in dataGridView1.Rows[0].Cells)
            {
                if (cell.Value.ToString() == "")
                {
                    row += "'NULL', ";
                }
                else
                {
                    row += "'" + cell.Value.ToString() + "', ";
                }
            }
            row = row.Remove(row.Length - 2);
            row += ");";
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO " + table + " " + fields + " VALUES " + row;
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Inserting row into table error!\n\n" + e1.ToString());
            }
            this.Close();
        }

        private void InsertRow_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
