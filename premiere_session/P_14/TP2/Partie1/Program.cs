using System;
using ConsoleTables;
using System.Globalization;


namespace Partie1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            //j'utilise la cultureInfo du canada pour le format monétaire
            CultureInfo myCIintl = new CultureInfo("fr-CA", false);
           

           //Declaration/Assignations 
            
            double montantPret;
            double tauxHypotecaire;
            decimal versementsMensuels;
            decimal total;
            int amortissement = 0;
            int versementsUnAn = 12;
            bool continuer = false;
            bool valide = true;
            decimal interets ;
            char reponse;
            
      
            do{
               do{
                    Console.WriteLine("Veuillez entrer le montant du pret");
                    valide = double.TryParse(Console.ReadLine().Replace(" ", string.Empty),out montantPret)&& montantPret > 0;
  

                }while(!valide);
                do{
                    Console.WriteLine("Veuillez entrer le taux hypotecaire. Entrez 10 pour 10%");
                    valide = double.TryParse  (Console.ReadLine(),out tauxHypotecaire);
                    tauxHypotecaire = tauxHypotecaire/100;


                }while(!valide);
                do{
                    Console.WriteLine("Veuillez entrer la periode d'amortissement");
                    valide = Int32.TryParse(Console.ReadLine(),out amortissement) && amortissement >=5 && amortissement <=30 && amortissement % 5 ==0;
                  

                }while(!valide);

                //Calculs formule hypotecaire

                decimal dividende = (decimal)montantPret*(decimal)tauxHypotecaire/versementsUnAn;
                double exposant = -versementsUnAn*amortissement;
                decimal diviseur =  1- (decimal)Math.Pow((1+tauxHypotecaire/versementsUnAn),exposant);
                              
             
                versementsMensuels = dividende/diviseur;
                
                total = versementsMensuels*(versementsUnAn*amortissement);
                interets = decimal.Subtract(total , (decimal)montantPret);
               
                              
                //Config tableau resultats
                var table = new ConsoleTable("Catégorie","","");
                                
                        
                string fleche = "------------------------>";
                table.AddRow("Nombre de versements",fleche        ,versementsUnAn*amortissement)
                .AddRow("Paiement de capital",fleche              ,montantPret.ToString("c", myCIintl))
                .AddRow("Paiement de frais d'interêts", fleche    ,interets.ToString("c", myCIintl) )
                .AddRow("Coût total", fleche                      ,total.ToString("c", myCIintl) );
                Console.WriteLine(table);
                                
                do{
                    Console.WriteLine("Voulez vous calculer une autre hypoteque? (O)ui ou (N)on");
                    valide = Char.TryParse(Console.ReadLine().ToUpper(), out reponse) && reponse == 'O' || reponse =='N';}
                    while(!valide);

                continuer = (reponse =='O')?  true : false;

                
            } while (continuer == true);
        }
    }
}
// NOTE je suis incapable de retirer le COUNT: apres mon tableau. :(