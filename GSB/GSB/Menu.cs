using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace GSB
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Valider_Click(object sender, EventArgs e)
        {

            var filteredData = modele.MaConnexion.Visiteur.ToList()
                         .Where(x => x.identifiant.Equals(identifiantTxt.Text));
            if (filteredData.ToList().Count == 0)
            {
                MessageBox.Show("Identifiant non valide");
                msgLab.Text = "Connexion refusé !";
                msgLab.Visible = true;
            }
            else
            {
                bsuser.DataSource = filteredData; // application du filtre
                bsuser.MoveFirst();
                Visiteur monuser = (Visiteur)bsuser.Current;
                MD5 monMD5 = MD5.Create();
                string passwdCrypte = GetMd5Hash(monMD5, passwdTxt.Text);
                string pswdc = monuser.password.Substring(2); // Pbs de l'hexa 0x sur sqlserver
                if (pswdc.Equals(passwdCrypte) || monuser.password.Equals(passwdCrypte))
                {                  
                    msgLab.Text = "Vous êtes autorisé à vous connecter. Bienvenue sur l'application MusicAtout !";
                    msgLab.Visible = true;
                    modele.Visiteur1 = monuser;
                }
                else
                {
                    MessageBox.Show("PSWD non valide");
                    msgLab.Text = "Connexion refusé !";
                    msgLab.Visible = true;
                }
            }

        }
        static string GetMd5Hash(MD5 MonMD5, string PasswdSaisi)
        {
            // step 1, calculate MD5 hash from input

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = MonMD5.ComputeHash(inputBytes);
            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();

        }
    }
}
