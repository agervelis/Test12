using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;
namespace Snacks
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            listboxui();
            listboxui2();
            listboxui3();
            listboxui4();
            listboxui5();
            listboxui6();
            listboxui7();
            listboxui8();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            
            SQLiteConnection dbConnection = dbConnection = new SQLiteConnection(@"Data Source=snacks.db");
            dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand("insert into snacks values(@ID, @pavadinimas,@kaina)", dbConnection);
            cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@pavadinimas", textBox2.Text);
            cmd.Parameters.AddWithValue("@kaina", textBox3.Text);
            cmd.ExecuteNonQuery();
            listboxui();
            listboxui2();
            listboxui5();
        }

        
        void listboxui()
        {
            listBox1.Items.Clear();
            SQLiteConnection dbConnection = dbConnection = new SQLiteConnection(@"Data Source=snacks.db");
            dbConnection.Open();
            string Query = "select pavadinimas from snacks";
            SQLiteCommand createCommand = new SQLiteCommand(Query, dbConnection);
            SQLiteDataReader dr = createCommand.ExecuteReader();
            while (dr.Read())
            {
                string pav = dr.GetString(0);
                listBox1.Items.Add(pav);
            }
        }
        void listboxui2()
        {
            listBox2.Items.Clear();
            SQLiteConnection dbConnection = dbConnection = new SQLiteConnection(@"Data Source=snacks.db");
            dbConnection.Open();
            string Query = "select kaina from snacks";
            SQLiteCommand createCommand = new SQLiteCommand(Query, dbConnection);
            SQLiteDataReader dr = createCommand.ExecuteReader();
            while (dr.Read())
            {
                double kaina = dr.GetDouble(0);
                listBox2.Items.Add(kaina);
            }
        }
        void listboxui3()
        {
            listBox3.Items.Clear();
            SQLiteConnection dbConnection = dbConnection = new SQLiteConnection(@"Data Source=snacks.db");
            dbConnection.Open();
            string Query = "select pavadinimas from gerimai";
            SQLiteCommand createCommand = new SQLiteCommand(Query, dbConnection);
            SQLiteDataReader dr = createCommand.ExecuteReader();
            while (dr.Read())
            {
                string pav = dr.GetString(0);
                listBox3.Items.Add(pav);
            }
        }
        void listboxui4()
        {
            listBox4.Items.Clear();
            SQLiteConnection dbConnection = dbConnection = new SQLiteConnection(@"Data Source=snacks.db");
            dbConnection.Open();
            string Query = "select kaina from gerimai";
            SQLiteCommand createCommand = new SQLiteCommand(Query, dbConnection);
            SQLiteDataReader dr = createCommand.ExecuteReader();
            while (dr.Read())
            {
                double kaina = dr.GetDouble(0);
                listBox4.Items.Add(kaina);
            }
        }
        void listboxui5()
        {
            listBox5.Items.Clear();
            SQLiteConnection dbConnection = dbConnection = new SQLiteConnection(@"Data Source=snacks.db");
            dbConnection.Open();
            string Query = "select ID from snacks";
            SQLiteCommand createCommand = new SQLiteCommand(Query, dbConnection);
            SQLiteDataReader dr = createCommand.ExecuteReader();
            while (dr.Read())
            {
                double ID = dr.GetDouble(0);
                listBox5.Items.Add(ID);
            }
        }
        void listboxui6()
        {
            listBox6.Items.Clear();
            SQLiteConnection dbConnection = dbConnection = new SQLiteConnection(@"Data Source=snacks.db");
            dbConnection.Open();
            string Query = "select ID from gerimai";
            SQLiteCommand createCommand = new SQLiteCommand(Query, dbConnection);
            SQLiteDataReader dr = createCommand.ExecuteReader();
            while (dr.Read())
            {
                double ID = dr.GetDouble(0);
                listBox6.Items.Add(ID);
            }
        }
        void listboxui7()
        {
            listBox7.Items.Clear();
            SQLiteConnection dbConnection = dbConnection = new SQLiteConnection(@"Data Source=snacks.db");
            dbConnection.Open();
            string Query = "select name from users";
            SQLiteCommand createCommand = new SQLiteCommand(Query, dbConnection);
            SQLiteDataReader dr = createCommand.ExecuteReader();
            while (dr.Read())
            {
                string us = dr.GetString(0);
                listBox7.Items.Add(us);
            }
        }
        void listboxui8()
        {
            listBox8.Items.Clear();
            SQLiteConnection dbConnection = dbConnection = new SQLiteConnection(@"Data Source=snacks.db");
            dbConnection.Open();
            string Query = "select password from users";
            SQLiteCommand createCommand = new SQLiteCommand(Query, dbConnection);
            SQLiteDataReader dr = createCommand.ExecuteReader();
            while (dr.Read())
            {
                string pw = dr.GetString(0);
                listBox8.Items.Add(pw);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection dbConnection = dbConnection = new SQLiteConnection(@"Data Source=snacks.db");
            dbConnection.Open();
            SQLiteCommand cmd = new SQLiteCommand("insert into gerimai values(@ID, @pavadinimas,@kaina)", dbConnection);
            cmd.Parameters.AddWithValue("@ID", textBox4.Text);
            cmd.Parameters.AddWithValue("@pavadinimas", textBox5.Text);
            cmd.Parameters.AddWithValue("@kaina", textBox6.Text);
            cmd.ExecuteNonQuery();
            listboxui3();
            listboxui4();
            listboxui6();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SQLiteConnection dbConnection = dbConnection = new SQLiteConnection(@"Data Source=snacks.db");
            dbConnection.Open();
            string pavadinimas;
            pavadinimas = listBox1.SelectedItem.ToString();
            string sql = $"delete from snacks where pavadinimas=@pavadinimas";
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            command.Parameters.AddWithValue("@pavadinimas", pavadinimas);
            command.ExecuteNonQuery();
            listboxui();
            listboxui2();
            listboxui5();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SQLiteConnection dbConnection = dbConnection = new SQLiteConnection(@"Data Source=snacks.db");
            dbConnection.Open();
            string pavadinimas;
            pavadinimas = listBox3.SelectedItem.ToString();
            string sql = $"delete from gerimai where pavadinimas=@pavadinimas";
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            command.Parameters.AddWithValue("@pavadinimas", pavadinimas);
            command.ExecuteNonQuery();
            listboxui3();
            listboxui4();
            listboxui6();
        }
    }
}
