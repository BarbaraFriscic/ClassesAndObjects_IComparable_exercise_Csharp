using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_11_22_Predavanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblReturn2.Text = String.Format("Unesite podatke za {0}. školu", counter + 1);
            lblLimit.Hide();
            txtLimit.Hide();
            btnLimitInput.Hide();


        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            Auto auto1 = new Auto("4B45", "Ford", "Escort", "bijeli", 65000);
            Auto auto2 = new Auto("7z68", "Honda", "Civic", "crna", 134800);
            Auto auto3 = new Auto("66U8", "Kia", "Ceed", "crvena", 70500);
            Auto auto4 = new Auto("FG55", "Ford", "Fiesta", "plava", 210000);
            Auto auto5 = new Auto("J88K", "Toyota", "Aygo", "crna", 82000);

            
            IspisiAuta(auto1, auto2, auto3);
            IspisiAuta(auto1, auto2, auto3, auto4, auto5);
        }

         void IspisiAuta(params Auto[] automobili)
        {
            double ukupanIznos = 0;

            lblReturn.Text += String.Format("\n\n{0,10} {1,10} {2,10} {3,10} {4,15}\n", "serijski broj", "Marka", "Model", "Boja", "Vrijednost");
            
            foreach (Auto auto in automobili)
            {
                lblReturn.Text += String.Format("\n{0,10} {1,10} {2,10} {3,10} {4,20:C}", auto.SerijskiBroj, auto.Marka, auto.Model, auto.Boja, auto.Vrijednost);
                ukupanIznos += auto.Vrijednost;
            }
            

            lblReturn.Text += String.Format("\n\nUkupna cijena iznosi {0,45:C}", ukupanIznos);
        }


        //Globalne varijable

        Skola[] skole = new Skola[5];
        int counter = 0;
        
        
        private void btnInput_Click(object sender, EventArgs e)
        {

            


            if (txtSkolaIme.Text == "")
            {
                MessageBox.Show("Unesite ime škole");
                txtSkolaIme.Focus();
            }
            else if (txtBrojUcenika.Text == "")
            {
                MessageBox.Show("Unesite broj učenika");
                txtBrojUcenika.Focus();
            }
            
            else
            {
                lblReturn2.Text = String.Format("Unesite podatke za {0}. školu", counter + 2);
                skole[counter] = new Skola(txtSkolaIme.Text, Convert.ToInt32(txtBrojUcenika.Text));
                txtSkolaIme.Clear();
                txtSkolaIme.Focus();
                txtBrojUcenika.Clear();

                counter++;
                if (counter == skole.Length)
                {
                    lblReturn2.Text = String.Empty;
                    txtSkolaIme.Enabled = false;
                    txtBrojUcenika.Enabled = false;
                    Array.Sort(skole);

                    lblReturn2.Text += String.Format("\nSortirani ispis:");
                    foreach (Skola skola in skole)
                    {
                        
                        lblReturn2.Text += String.Format("\nIme škole: {0}, broj učenika: {1}", skola.ImeSkole, skola.BrojUcenika);
                    }

                    lblLimit.Show();
                    txtLimit.Show();
                    btnLimitInput.Show();
                }
            }
            
        }

        private void btnLimitInput_Click(object sender, EventArgs e)
        {
            int granica = Convert.ToInt32(txtLimit.Text);

            foreach (Skola skola in skole)
            {
                if (skola.BrojUcenika > granica)
                lblLimitReturnSort.Text += String.Format("\nIme škole: {0}, broj učenika: {1}", skola.ImeSkole, skola.BrojUcenika);
            }
        }
    }
}
