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
namespace Snacks
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            listboxui();
            listboxui2();
          listboxui3();
           listboxui4();
        }
        Kaina kaina = new Kaina();
        private void Button1_Click(object sender, EventArgs e)
        {
            int itemCount = listBox1.Items.Count;
            double[] kainos = new double[itemCount];
            for (int i = 0; i < itemCount; i++)
            {
                kainos[i] = (double)listBox2.Items[i];
            }
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Pasirinkite viena meniu produkta");
            }
            if (listBox1.SelectedItems.Count != 0)
            {
                
                listBox5.Items.Add(listBox1.SelectedItem);
                int i;
                i = listBox1.SelectedIndex;
                kaina.preke = kainos[i];
                //kaina.bendra = kaina.bendra + kaina.preke;
                listBox6.Items.Add(kaina.preke);
                textBox1.Text = kaina.GetPrice().ToString();
                textBox2.Text = kaina.GetPricePVM().ToString();
            }
        }
        

        private void Button2_Click(object sender, EventArgs e)
        {
            int itemCount = listBox2.Items.Count;
            double[] kainosG = new double [itemCount];
            for (int i=0;i<itemCount;i++)
            {
            kainosG[i] = (double)listBox4.Items[i];
            }
            
            if (listBox3.SelectedItems.Count == 0)
            {
                MessageBox.Show("Pasirinkite viena meniu produkta");
            }
            if (listBox3.SelectedItems.Count != 0)
            {
                listBox5.Items.Add(listBox3.SelectedItem);
                int i;
                i = listBox3.SelectedIndex;
                kaina.preke = kainosG[i];
                listBox6.Items.Add(kaina.preke);
                textBox1.Text = kaina.GetPrice().ToString();
                textBox2.Text = kaina.GetPricePVM().ToString();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            String kainosK = listBox5.Items[20].ToString();
            int i;
            i = listBox5.SelectedIndex;
            kaina.preke = kainosK[i];
            listBox5.Items.Remove(listBox5.SelectedItem);
            textBox1.Text = kaina.Atimt().ToString();
            textBox2.Text = kaina.AtimtPVM().ToString();
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
    }
    }
