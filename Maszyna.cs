using System;
using System.Collections.Generic;
using System.Text;

namespace WpfZadanie1
{
    class Maszyna
    {
        List<string> kupony;
        Random random;

        public Maszyna()
        {
            kupony = new List<string>();
        }

        public void Dodaj(string kupon)
        {
            kupony.Add(kupon);
        }
        public string Losuj()
        {
            random = new Random();
            int i = random.Next(kupony.Count);
            string kupon = kupony[i];
            kupony.RemoveAt(i);
            return kupon;
        }

        public bool CzySaKupony()
        {
            if (kupony.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Zawartosc()
        {
            string zawartosc = "Zawartość: ";
            foreach (string kupon in kupony){
                zawartosc += kupon + " ";
            }
            return zawartosc;
        }

    }
}
