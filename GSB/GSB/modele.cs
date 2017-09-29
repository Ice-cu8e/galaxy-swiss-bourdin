using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB
{
    public static class modele
    {
        private static Visiteur Visiteur;
        private static gsbEntity maConnexion;

       

        public static gsbEntity MaConnexion
        {
            get
            {
                return maConnexion;
            }

            set
            {
                maConnexion = value;
            }
        }

        public static Visiteur Visiteur1
        {
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
