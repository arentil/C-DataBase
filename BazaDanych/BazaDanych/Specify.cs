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
    public partial class Specify : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private DataGridView dataGridView;
        public string statement;

        public Specify(MySqlConnection con)
        {
            InitializeComponent();
            conn = con;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SHOW TABLES;";
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string row = "";
                for (int i = 0; i < reader.FieldCount; i++)
                    row += reader.GetValue(i).ToString() + ", ";
                row = row.Substring(0, row.Length - 2);
                listBox1.Items.Add(row);
            }
            reader.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selected = listBox1.SelectedItem.ToString();
                listBox2.Items.Add(selected);
                listBox1.Items.Remove(selected);
                comboBoxSelectTable.Items.Add(selected);
            }
            selectCommonColumn();
        }

        private void buttonRightRight_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                listBox2.Items.Add(item);
                comboBoxSelectTable.Items.Add(item);
            }
            listBox1.Items.Clear();
            selectCommonColumn();
        }

        private void buttonLeftLeft_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox2.Items)
            {
                listBox1.Items.Add(item);
                comboBoxSelectTable.Items.Remove(item);
            }
            listBox2.Items.Clear();
            selectCommonColumn();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                string selected = listBox2.SelectedItem.ToString();
                listBox1.Items.Add(selected);
                listBox2.Items.Remove(selected);
                comboBoxSelectTable.Items.Remove(selected);
            }
            selectCommonColumn();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selected = listBox1.SelectedItem.ToString();
                listBox2.Items.Add(selected);
                listBox1.Items.Remove(selected);
                comboBoxSelectTable.Items.Add(selected);
            }
            selectCommonColumn();
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                string selected = listBox2.SelectedItem.ToString();
                listBox1.Items.Add(selected);
                listBox2.Items.Remove(selected);
                comboBoxSelectTable.Items.Remove(selected);
            }
            selectCommonColumn();
        }

        private void comboBoxSelectTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM " + comboBoxSelectTable.SelectedItem.ToString();
            MySqlDataReader reader = cmd.ExecuteReader();

            for (var f = 0; f < reader.FieldCount; f++)
            {
                string field = reader.GetName(f);
                listBox3.Items.Add(field);                
            }
            reader.Close();
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex != -1)
            {
                string selected = comboBoxSelectTable.SelectedItem.ToString() + "." + listBox3.SelectedItem.ToString();
                if (!listBox4.Items.Contains(selected))
                {
                    listBox4.Items.Add(selected);
                }
            }
        }

        private void buttonRR_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox3.Items)
            {
                if (!listBox4.Items.Contains(comboBoxSelectTable.SelectedItem.ToString() + "." + item.ToString()))
                {
                    listBox4.Items.Add(comboBoxSelectTable.SelectedItem.ToString() + "." + item.ToString());
                }
            }
        }

        private void buttonLL_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            if (listBox4.SelectedIndex != -1)
            {
                string selected = listBox4.SelectedItem.ToString();
                listBox4.Items.Remove(selected);
            }
        }

        private void listBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox3.SelectedIndex != -1)
            {
                string selected = comboBoxSelectTable.SelectedItem.ToString() + "." + listBox3.SelectedItem.ToString();
                if (!listBox4.Items.Contains(selected))
                    listBox4.Items.Add(selected);
            }
        }

        private void listBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox4.SelectedIndex != -1)
            {
                string selected = listBox4.SelectedItem.ToString();
                listBox4.Items.Remove(selected);
            }
        }

        private void selectCommonColumn()
        {
            comboBox1.Items.Clear();        // nazwy tabel z ich polami w liscie
            Dictionary<string, List<string>> common = new Dictionary<string, List<string>>();
            
            foreach (var item in comboBoxSelectTable.Items)
            {
                common.Add(item.ToString(), new List<string>());
                cmd = conn.CreateCommand();
                MySqlDataReader reader;
                cmd.CommandText = "SELECT * FROM " + item.ToString();
                reader = cmd.ExecuteReader();
                for (var f = 0; f < reader.FieldCount; f++)
                {
                    string field = reader.GetName(f);
                    common[item.ToString()].Add(field);
                }
                reader.Close();
            }

            foreach (var table in common)
            {
                string tabName = table.Key;
                foreach (var field in common[tabName])
                {
                    string fieldName = field;
                    int size = common.Count() - 1;
                    Dictionary<string, int> dc = new Dictionary<string, int>();
                    foreach (var tabName2 in common)
                    {
                        if (tabName2.Key == tabName)
                            continue;
                        foreach (var fieldName2 in common[tabName2.Key])
                        {
                            if (fieldName == fieldName2 && !comboBox1.Items.Contains(fieldName))
                                if (dc.ContainsKey(fieldName))
                                    dc[fieldName]++;
                                else
                                    dc.Add(fieldName, 1);
                        }
                    }
                    foreach (var item in (new Dictionary<string, int>(dc)))
                    {
                        if (item.Value == size)
                            comboBox1.Items.Add(item.Key);
                        dc.Remove(item.Key);
                    }

                }

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string stmt = "SELECT ";
            foreach (var col in listBox4.Items)
            {
                stmt += col.ToString() + ", ";
            }
            stmt = stmt.Remove(stmt.Length - 2);
            stmt += " FROM " + listBox2.Items[0].ToString();
            stmt += " INNER JOIN " + listBox2.Items[1].ToString();
            stmt += " ON " + listBox2.Items[0].ToString() + "." + comboBox1.SelectedItem.ToString();
            stmt += "=" + listBox2.Items[1].ToString() + "." + comboBox1.SelectedItem.ToString() + ";";
            statement = stmt;

            this.Close();
        }
    }
}
