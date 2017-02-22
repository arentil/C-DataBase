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
    public partial class CreateTable : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;

        public CreateTable(MySqlConnection con)
        {
            InitializeComponent();
            conn = con;
            buttonDeleteTable.Enabled = false;
            buttonAddField.Enabled = false;
            buttonDeleteFiels.Enabled = false;
        }

        private void CreateTable_Load(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            comboBox1.Items.Clear();
            cmd.CommandText = "SHOW TABLES;";
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                string row = "";
                for (int i = 0; i < reader.FieldCount; i++)
                    row += reader.GetValue(i).ToString() + ", ";
                row = row.Substring(0, row.Length - 2);
                comboBox1.Items.Add(row);
            }
            reader.Close();
            dataGridViewTables.AllowUserToAddRows = false;
        }

        private void textTableName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SHOW FIELDS FROM " + comboBox1.SelectedItem, conn);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridViewTables.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception e1)
            {
                MessageBox.Show("Failed to show table " + comboBox1.SelectedItem + "\n\n" + e1.Message);
            }
            buttonDeleteTable.Enabled = true;
            buttonAddField.Enabled = true;
            buttonDeleteFiels.Enabled = true;
        }

        private void buttonAddField_Click(object sender, EventArgs e)
        {
            string ch = comboBox1.Text;
            NewTable nt = new NewTable(conn, comboBox1.Text, false);
            var result = nt.ShowDialog();
            CreateTable_Load(sender, e);
            comboBox1.Text = ch;
        }

        private void dataGridViewTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCreateNewTable_Click(object sender, EventArgs e)
        {
            NewTable nt = new NewTable(conn, textTableName.Text, true);
            var result = nt.ShowDialog();
            CreateTable_Load(sender, e);
            if (comboBox1.Items.Contains(textTableName))
                comboBox1.Text = textTableName.ToString();
        }

        private void buttonDeleteTable_Click(object sender, EventArgs e)
        {
            DialogResult choiseBox = MessageBox.Show("Delete selected table.\nAre you sure?", "Delete row.", MessageBoxButtons.YesNo);
            if (choiseBox == DialogResult.Yes)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "DROP TABLE " + comboBox1.Text + ";";
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Close();
                CreateTable_Load(sender, e);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void buttonDeleteFiels_Click(object sender, EventArgs e)
        {
            DialogResult choiseBox = MessageBox.Show("Delete selected field.\nAre you sure?", "Delete row.", MessageBoxButtons.YesNo);
            if (choiseBox == DialogResult.No)
            { }
            if (choiseBox == DialogResult.Yes)
            {
                var i = dataGridViewTables.CurrentCell;
                if (i != null)
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "ALTER TABLE " + comboBox1.Text + " DROP COLUMN " + i.Value.ToString() +";";
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    reader.Close();
                    string txt = comboBox1.Text;
                    CreateTable_Load(sender, e);
                    comboBox1.Text = txt;
                }


            }
        }
    }
}
