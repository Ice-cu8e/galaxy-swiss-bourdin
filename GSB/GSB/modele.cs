using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB
{
    public static class modele
    {
        private static string Visiteur;

        public static string Visiteur1
        {
            //je procède a un test
            get
            {
                return Visiteur;
            }

            set
            {
                Visiteur = value;
            }
        }
    }
}
