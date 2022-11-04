using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _3_11_22_Predavanje
{
    internal class Auto 
    {
        public string serijskiBroj;
        public string marka;
        public string model;
        public string boja;
        public double vrijednost;  

        public string SerijskiBroj {
            get { return serijskiBroj; }
            set { serijskiBroj = value; }
        }
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        public string Model {
            get { return model; }
            set { model = value; }
        }
        public string Boja {
            get { return boja; }
            set { boja = value; }
        }
        public double Vrijednost {
            get { return vrijednost; }
            set { vrijednost = value; } 
            }

        public Auto(string serijskiBroj, string marka, string model, string boja, double vrijednost)
        {
            this.serijskiBroj = serijskiBroj;
            this.marka = marka;
            this.model = model;
            this.boja = boja;
            this.vrijednost = vrijednost;
            
        }
    }
}
