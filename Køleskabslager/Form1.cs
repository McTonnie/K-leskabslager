using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Køleskabslager
{
    //når ejg skal adde den funtion der viser for gamle ting skal jeg bruge https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.monthcalendar.datechanged?view=net-5.0
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reload()
        {
            liste.Items.Clear();
            listeold.Items.Clear();

            dateTimePicker1.Value = DateTime.Now;

            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(4);
            Pull();


            //ListView1.Items.Add("Mahesh Chand");

            // dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
        }



        public void Form1_Load(object sender, EventArgs e)
        {
            DBConnector.DBconnect();
            DBConnector.Opencon();
            WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            

            liste.View = View.Details;
            liste.Name = "ListView1";
            liste.Size = new System.Drawing.Size(500, 700);
            liste.BackColor = System.Drawing.Color.Cyan;
            liste.ForeColor = System.Drawing.Color.Black;
            liste.FullRowSelect = true;
            liste.Location = new System.Drawing.Point(60, 60);

            liste.Columns.Add("Fornavn", 125);
            liste.Columns.Add("Efternavn", 125);
            liste.Columns.Add("Vare", 150);
            liste.Columns.Add("Udløb", 100);
            liste.Columns.Add("id", 50);




            listeold.View = View.Details;
            listeold.Name = "ListView1";
            listeold.Size = new System.Drawing.Size(500, 700);
            listeold.BackColor = System.Drawing.Color.Red;
            listeold.ForeColor = System.Drawing.Color.Black;
            listeold.FullRowSelect = true;
            listeold.Location = new System.Drawing.Point(900, 60);

            listeold.Columns.Add("Fornavn", 125);
            listeold.Columns.Add("Efternavn", 125);
            listeold.Columns.Add("Vare", 150);
            listeold.Columns.Add("Udløb", 100);
            listeold.Columns.Add("id", 50);


            label7.Text = "20";
            label8.Text = "20";
            label9.Text = "35";



            pictureBox1.Location = new System.Drawing.Point(60, 735);
            pictureBox1.Size = new System.Drawing.Size(500, 25);

            pictureBox2.Location = new System.Drawing.Point(900, 735);
            pictureBox2.Size = new System.Drawing.Size(500, 25);
            reload();

            
        }




        private void tilføj()
        {
            Variabler.date = dateTimePicker1.Value.Day.ToString();
            Variabler.month = dateTimePicker1.Value.Month.ToString();
            Variabler.year = dateTimePicker1.Value.Year.ToString();

            Variabler.dato = Variabler.year + "-" + Variabler.month + "-" + Variabler.date;

            Variabler.navn = textBoxnavn.Text;

            Variabler.efternavn = textBoxEfternavn.Text;

            Variabler.vare = textBoxVare.Text;

            DBConnector.Insert();

            textBoxnavn.Text = null;
            textBoxEfternavn.Text = null;
            textBoxVare.Text = null;


            reload();
        }






        private void buttonTilføj_Click(object sender, EventArgs e)
        {
            if (textBoxnavn.Text != "")
            {
                if (textBoxEfternavn.Text != "")
                {

                    if (textBoxVare.Text != "")
                    {


                        if (textBoxnavn.Text.Length <= 20)
                        {
                            if (textBoxEfternavn.Text.Length <= 20)
                            {
                                if (textBoxVare.Text.Length <= 35)
                                {
                                    tilføj();
                                }
                                else
                                {
                                    MessageBox.Show("Feltet Vare må max være på 35 bogstaver");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Feltet Efternavn må max være på 20 bogstaver");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Feltet Navn må max være på 20 bogstaver");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Feltet Vare må ikke være tomt");
                    }

                }
                else
                {
                    MessageBox.Show("Feltet Efternavn må ikke være tomt");
                }

            }
            else
            {
                MessageBox.Show("Feltet Navn må ikke være tomt");

            }

        }

        private void buttonFjern_Click(object sender, EventArgs e)
        {

         



            try
            {
                string deleteid = liste.SelectedItems[0].SubItems[4].Text;
                DBConnector.delete(deleteid);
                reload();


            }
            catch (ArgumentException)
            {
                try
                {
                    string deleteid = listeold.SelectedItems[0].SubItems[4].Text;
                    DBConnector.delete(deleteid);
                    reload();
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Du skal vægle en ting du vil fjerne først");

                }
            }
        }


        public void listeupdate()
        {
            
            //liste.Items
        }


        private void Pull()
        {

            MySqlCommand cmd = new MySqlCommand("SELECT id, navn, efternavn, vare, date_format(udløb, '%d/%m-%y') as Udløb FROM lager  where udløb >= CURDATE();", DBConnector.con);
            MySqlDataReader datareader = cmd.ExecuteReader();




            while (datareader.Read())
            {
                Variabler.id = datareader.GetString(0);

                Variabler.navn = datareader.GetString(1);

                Variabler.efternavn = datareader.GetString(2);

                Variabler.vare = datareader.GetString(3);

                Variabler.dato = datareader.GetString(4);

                string[] row = { Variabler.navn, Variabler.efternavn, Variabler.vare, Variabler.dato, Variabler.id };
                ListViewItem item = new ListViewItem(row);
                liste.Items.Add(item);
            }
            datareader.Close();



            cmd = new MySqlCommand("SELECT id, navn, efternavn, vare, date_format(udløb, '%d/%m-%y') as Udløb FROM køle.lager  where udløb < CURDATE();", DBConnector.con);
            datareader = cmd.ExecuteReader();




            while (datareader.Read())
            {
                Variabler.id = datareader.GetString(0);

                Variabler.navn = datareader.GetString(1);

                Variabler.efternavn = datareader.GetString(2);

                Variabler.vare = datareader.GetString(3);

                Variabler.dato = datareader.GetString(4);

                string[] row = { Variabler.navn, Variabler.efternavn, Variabler.vare, Variabler.dato, Variabler.id };
                ListViewItem item = new ListViewItem(row);
                listeold.Items.Add(item);
            }
            datareader.Close();






            //console.WriteLine("Showed the table " + table);


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reload(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxnavn_TextChanged(object sender, EventArgs e)
        {
            Variabler.lengthnavn = 20 - textBoxnavn.Text.Length;
            label7.Text = Variabler.lengthnavn.ToString();
        }

        private void textBoxEfternavn_TextChanged(object sender, EventArgs e)
        {
            Variabler.lengthenavn = 20 - textBoxEfternavn.Text.Length;
            label8.Text = Variabler.lengthenavn.ToString();
        }

        private void textBoxVare_TextChanged(object sender, EventArgs e)
        {
            Variabler.lengthvare = 35 - textBoxVare.Text.Length;
            label9.Text = Variabler.lengthvare.ToString();
        }
    }
}
