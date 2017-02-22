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
    public partial class NewTable : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private string table = "";
        private bool isNew;

        public NewTable(MySqlConnection con, string tab, bool is_new)
        {
            InitializeComponent();
            isNew = is_new;
            table = tab;
            conn = con;
            labelTable.Text += " " + table;
            dataGridViewNewTable.Columns.Add("Field", "Fiels");
            dataGridViewNewTable.Columns.Add("Type", "Type");
            dataGridViewNewTable.Columns.Add(new DataGridViewCheckBoxColumn());
            dataGridViewNewTable.Columns.Add(new DataGridViewCheckBoxColumn());
            dataGridViewNewTable.Columns.Add("Default", "Default");
            dataGridViewNewTable.Columns.Add("Extra", "Extra");
            dataGridViewNewTable.Columns[0].ValueType = typeof(string);
            dataGridViewNewTable.Columns[1].ValueType = typeof(string);
            dataGridViewNewTable.Columns[2].ValueType = typeof(bool);
            dataGridViewNewTable.Columns[2].Name = "Null";
            dataGridViewNewTable.Columns[3].Name = "Primary Key";
            dataGridViewNewTable.Columns[4].ValueType = typeof(string);
            dataGridViewNewTable.Columns[5].ValueType = typeof(string);
            dataGridViewNewTable.AllowUserToAddRows = false;
            dataGridViewNewTable.Rows.Add();
        }

        private void NewTable_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewNewTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelTable_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddField_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewNewTable.Rows[0];
            if (!string.IsNullOrEmpty(row.Cells[0].Value as string) && !string.IsNullOrEmpty(row.Cells[1].Value as string))
            {
                cmd = conn.CreateCommand();
                if (isNew)
                    cmd.CommandText = "CREATE TABLE " + table + " (";
                else
                    cmd.CommandText = "ALTER TABLE " + table + " ADD ";
                cmd.CommandText += row.Cells[0].Value + " " + row.Cells[1].Value;
                if (Convert.ToBoolean(row.Cells[2].Value))
                    cmd.CommandText += " NOT NULL";
                if (Convert.ToBoolean(row.Cells[3].Value))
                    cmd.CommandText += " PRIMARY KEY";
                if (isNew)
                    cmd.CommandText += ");";
                else
                    cmd.CommandText += ";";

                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                this.Close();
            }
            else
                MessageBox.Show("Column \"Field\" and \"Type\" must be not empty!");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
