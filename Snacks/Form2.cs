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
        Price price = new Price();
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
                price.preke = kainos[i];
                listBox6.Items.Add(price.preke);
                textBox1.Text = price.GetPrice().ToString();
                textBox2.Text = price.GetPricePVM().ToString();
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
                price.preke = kainosG[i];
                listBox6.Items.Add(price.preke);
                textBox1.Text = price.GetPrice().ToString();
                textBox2.Text = price.GetPricePVM().ToString();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int itemCount = listBox5.Items.Count;

            double[] kainosK = new double[itemCount];
            for(int i=0;i<itemCount;i++)
            {
                kainosK[i] = (double)listBox6.Items[i];
            }
            if (listBox5.SelectedItems.Count == 0)
            {
                MessageBox.Show("Pasirinkite viena produkta");
            }
            if (listBox5.SelectedItems.Count != 0)
            {
                int p;
                p = listBox5.SelectedIndex;
                price.preke = kainosK[p];
            textBox1.Text = price.Atimt().ToString();
            textBox2.Text = price.AtimtPVM().ToString();
            listBox5.Items.Remove(listBox5.SelectedItem);
            listBox6.Items.Remove(listBox6.Items[p]);
            if (listBox5.Items.Count==0)
                {
                    textBox1.Text = "0";
                    textBox2.Text = "0";
                }

            }
            
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
