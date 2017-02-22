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
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
            buttonCreateTable.Enabled = false;
            comboBox1.Enabled = false;
            buttonSpecify.Enabled = false;
            buttonInsertRow.Enabled = false;
            buttonDeleteRow.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectButton.BackColor = Color.IndianRed;
            dataGridTableContent.AllowUserToAddRows = false;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            Connect connectForm = new Connect();
            var result = connectForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                conn = connectForm.conn;
                if (connectForm.is_connected == true)
                    connectButton.BackColor = Color.LightGreen;

                buttonCreateTable.Enabled = true;
                comboBox1.Enabled = true;
                buttonSpecify.Enabled = true;
                refresh();
            }
        }

        private void refresh()
        {
            cmd = conn.CreateCommand();
            comboBox1.Items.Clear();
            cmd.CommandText = "SHOW TABLES;";
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string row = "";
                for (int i = 0; i < reader.FieldCount; i++)
                    row += reader.GetValue(i).ToString() + ", ";
                row = row.Substring(0, row.Length - 2);
                comboBox1.Items.Add(row);
            }
            reader.Close();
        }

        private void buttonCreateTable_Click_1(object sender, EventArgs e)
        {
            CreateTable createTableForm = new CreateTable(conn);
            var result = createTableForm.ShowDialog();
            refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonInsertRow.Enabled = true;
            buttonDeleteRow.Enabled = true;
            cmd = new MySqlCommand("SELECT * FROM " + comboBox1.SelectedItem, conn);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridTableContent.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception e1)
            {
                MessageBox.Show("Failed to show table " + comboBox1.SelectedItem + "\n\n" + e1.Message);
            }
        }

        private void dataGridTableContent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonSpecify_Click(object sender, EventArgs e)
        {
            Specify specify = new Specify(conn);
            var result = specify.ShowDialog();
            MessageBox.Show(specify.statement);
            cmd = new MySqlCommand(specify.statement, conn);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridTableContent.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception e1)
            {
                MessageBox.Show("Failed to show table " + comboBox1.SelectedItem + "\n\n" + e1.Message);
            }
        }

        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            DialogResult choiseBox = MessageBox.Show("Delete selected row.\nAre you sure?", "Delete row.", MessageBoxButtons.YesNo);
            if (choiseBox == DialogResult.No)
            { }
            if (choiseBox == DialogResult.Yes)
            {
                var i = dataGridTableContent.CurrentCell;
                if (i != null)
                {
                    int j = i.RowIndex;
                    if (j != -1)
                    {
                        var row = dataGridTableContent.Rows[j];

                        try
                        {
                            string statement = "DELETE FROM " + comboBox1.Text + " WHERE ";
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                statement += cell.OwningColumn.Name + "=";
                                if (cell.Value.ToString() == "True")
                                    statement += "'1'";
                                else if (cell.Value.ToString() == "False")
                                    statement += "'0'";
                                else
                                    statement += "'" + cell.Value.ToString() + "'";
                                statement += " AND ";
                            }
                            statement = statement.Substring(0, statement.Length - 5);
                            statement += ";";
                            var QueryCommand = new MySqlCommand(statement, conn);
                            var ResultReader = QueryCommand.ExecuteReader();
                            ResultReader.Close();
                            dataGridTableContent.Update();
                            dataGridTableContent.Refresh();
                            comboBox1_SelectedIndexChanged(sender, e);
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show("Failed to delete row!\n" + e1.ToString());
                        }
                    }
                }
                refresh();
            }
        }

        private void buttonInsertRow_Click(object sender, EventArgs e)
        {
            string ch = comboBox1.Text;
            InsertRow ir = new InsertRow(conn, comboBox1.Text);
            var result = ir.ShowDialog();
            refresh();
            comboBox1.Text = ch;
        }
    }
}
