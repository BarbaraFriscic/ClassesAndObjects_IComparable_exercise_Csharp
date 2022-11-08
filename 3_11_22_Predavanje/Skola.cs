using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_11_22_Predavanje
{
    internal class Skola : IComparable
    {
        public string imeSkole;
        public int brojUcenika;

        

        int IComparable.CompareTo(object obj)
        {
            Skola temp = (Skola)obj;
            if (this.brojUcenika > temp.brojUcenika)
                return 1;
            else if (this.brojUcenika < temp.brojUcenika)
                return -1;
            else
                return 0;
        }


        public string ImeSkole
        {
            get { return imeSkole; }
            set { imeSkole = value; }
        }
        public int BrojUcenika
        {
            get { return brojUcenika; }
            set { brojUcenika = value; }
        }

        public Skola(string imesk, int brUc)
        {
            this.imeSkole = imesk;
            this.brojUcenika = brUc;
        }
        


}
}
