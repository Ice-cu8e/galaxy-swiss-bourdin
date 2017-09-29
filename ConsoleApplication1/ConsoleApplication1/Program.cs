using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static string prenom;
        static int jour, mois, annee;

        static void presentation()
        {
            Console.Title = "Happy Birthday";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Est ce ton anniversaire aujourd'hui ?");
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }

        static void questions()
        {
            Console.WriteLine("Quel est ton prenom?");
            prenom = Console.ReadLine();
            if (jour >= 1 && jour <= 30)
            {

            }
            else
            {
                Console.WriteLine("tu te fous de ma geule ? met ta vrai date serieux !");
            }
            Console.WriteLine("Quel est ton jour de naissance ?");
            jour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quel est ton mois de naissance ?");
            mois = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quel est ton année de naissance ?");
            annee = Convert.ToInt32(Console.ReadLine());
            return;
        }

        static void debug()
        {
            if (jour >= 1 && jour <= 30 )
            {
             
            }
            else
            {
                Console.WriteLine("tu te fous de ma geule ? met ta vrai date serieux !");
            }


            if (mois >= 1 && mois <= 12)
            {
                
            }
            else
            {
                Console.WriteLine("seriux ? nan allez donne ton veritable mois de naissance !");
            }


            if (annee >= 1873 && annee <= 2017)
            {
             
            }
            else
            {
                if (annee < 1873)
                {
                    Console.WriteLine("tu va battre un reccord de longevité OUAAAHHHH ! ");
                }
                if (annee > 2017)
                {  
                    Console.WriteLine("bah en vrai t meme pas né");
                }
            }
            return;
        }

        static void Main(string[] args)
        {
            presentation();
            questions();
            //debug();
            Console.WriteLine("Tu t'appel " + prenom + " et tu est né(e) le " + jour + "/" + mois + "/" + annee);
            //Console.WriteLine("tu est né(e) le " + jour +"/"+ mois +"/"+ annee);
            Console.ReadKey(true);
        }
    }
}
