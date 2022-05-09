using System;

namespace Partie1
{
    class Program
    {
        static void Main(string[] args)
        {
            double montantPret;
            double tauxHypotecaire;
            double versementsMensuels;
            double total;
            int amortissement = 0;
            int versementsUnAn = 12;
            bool continuer = false;
            bool valide = true;
            
      


            do
            {
               do{
                    Console.WriteLine("Veuillez entrer le montant du pret.");
                    valide = double.TryParse(Console.ReadLine(),out montantPret);
                    Console.WriteLine(valide);

                }while(!valide);
                do{
                    Console.WriteLine("Veuillez entrer le taux hypotecaire.");
                    valide = double.TryParse(Console.ReadLine(),out tauxHypotecaire);
                    Console.WriteLine(valide);

                }while(!valide);
                do{
                    Console.WriteLine("Veuillez entrer la periode d'amortissement");
                    valide = Int32.TryParse(Console.ReadLine(),out amortissement) && amortissement >=5 && amortissement <=30 && amortissement % 5 ==0;
                    Console.WriteLine(valide);

                }while(!valide);

                double aDiviser = montantPret*tauxHypotecaire/versementsUnAn;
                double exposant = -versementsUnAn*amortissement;
                                Console.WriteLine("EXPO" + exposant);
                double diviseur =  1- Math.Pow((1+tauxHypotecaire/versementsUnAn),exposant);
                double div2 = 1-diviseur;
                versementsMensuels = aDiviser/div2;
                Console.WriteLine("adiviser===" +aDiviser);
                                Console.WriteLine("diviseur===" +diviseur);
                                Console.WriteLine("div2===" +div2);

                                Console.WriteLine("versements===" +versementsMensuels);



                

                    



          
                Console.WriteLine("vvvvvvvvv" );
            

















                
            } while (continuer == true);




            
        }
    }
}
