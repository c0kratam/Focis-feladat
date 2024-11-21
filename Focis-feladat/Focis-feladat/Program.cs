using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

namespace Focis_feladat
{
    public struct Foci
    {
        public string nev;
        public int eletkor;
        public int golok;
        public int osszpontszam;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Foci> lista = new List<Foci>();
            Foci f = new Foci();
            foreach (var i in File.ReadAllLines("Foci-feladat.txt"))
            {
                string[] a = i.Split(';');
                f.nev = a[0];
                f.eletkor = Convert.ToInt32(a[1]);
                f.golok = Convert.ToInt32(a[2]);
                f.osszpontszam = Convert.ToInt32(a[3]);
                lista.Add(f);
            }
        }
    }
}
