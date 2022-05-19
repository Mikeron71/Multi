using System;
using ConsoleTables;
using System.Globalization;

namespace partie2
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            //j'utilise la cultureInfo du canada pour le format monétaire
            CultureInfo myCIintl = new CultureInfo("fr-CA", false);

            decimal depotInitial;
            double tauxAnnuel;
            decimal depotsSubsequents;
            bool valide = false;
            bool continuer = false;

            double mois = 0;
            decimal interetGagne;
            decimal montant = 0;
            char reponse;
            
            



           do{
               do{
                    Console.WriteLine("Veuillez entrer le montant du dépot initial");
                    valide = decimal.TryParse(Console.ReadLine().Replace(" ", string.Empty),out depotInitial)&& depotInitial > 0;
  

                }while(!valide);
                do{
                    Console.WriteLine("Veuillez entrer le taux d'intérêts annuel. Entrez 10 pour 10%");
                    valide = double.TryParse  (Console.ReadLine(),out tauxAnnuel) && tauxAnnuel > 0;
                


                }while(!valide);
                do{
                    Console.WriteLine("Veuillez entrer le montant des dépots subséquents mensuels");
                    valide = decimal.TryParse(Console.ReadLine(),out depotsSubsequents);
                  

                }while(!valide);

                //Calculs 

            
                do{ 
                    double tauxmensuel = tauxAnnuel/12;
                    montant = depotInitial*(decimal)Math.Pow((1+tauxmensuel/100),1) + depotsSubsequents;
                    interetGagne = montant-depotInitial;
                    depotInitial += interetGagne ;
                    mois++;

                    // je fais modelo pour afficher seulement les annees
                    if(mois % 12 ==0){

                        var table = new ConsoleTable("Catégorie","","");
                                
                        
                        string fleche = "------------------------>";
                        table.AddRow($"année {mois/12}",fleche ,  montant.ToString("c",myCIintl)    );
                        Console.WriteLine(table);
                    }
                } while (montant <=1000000);
              
                int annes = (int)Math.Floor(mois/12);
                int moisRestants = (int)mois %12;

                Console.WriteLine($"En {annes} ans et {moisRestants} mois vous aurrez atteint le million de dollars. Plus précisément {montant.ToString("c",myCIintl)}.");

                do{
                    Console.WriteLine("Voulez vous calculer une autre placement? (O)ui ou (N)on");
                    valide = Char.TryParse(Console.ReadLine().ToUpper(), out reponse) && reponse == 'O' || reponse =='N';}
                    while(!valide);

                continuer = (reponse =='O')?  true : false;
                   
                
            } while (continuer == true);
        }
    }
}
