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
            
            



           do{
               do{
                    Console.WriteLine("Veuillez entrer le montant du dépot initial");
                    valide = decimal.TryParse(Console.ReadLine().Replace(" ", string.Empty),out depotInitial)&& depotInitial > 0;
  

                }while(!valide);
                do{
                    Console.WriteLine("Veuillez entrer le taux d'intérêts annuel. Entrez 10 pour 10%");
                    valide = double.TryParse  (Console.ReadLine(),out tauxAnnuel);
                


                }while(!valide);
                do{
                    Console.WriteLine("Veuillez entrer le montant des dépots subséquents mensuels");
                    valide = decimal.TryParse(Console.ReadLine(),out depotsSubsequents);
                  

                }while(!valide);

                //Calculs 

                
                  do{  
                    
                  
                    // interetGagne = (decimal)Math.Pow(depotInitial*(1+tauxAnnuel/12/100),12);


                double tauxmensuel = tauxAnnuel/12;

                montant = depotInitial*(decimal)Math.Pow((1+tauxmensuel/100),1) + depotsSubsequents;
                interetGagne = montant-depotInitial;
                depotInitial += interetGagne ;
                mois++;

            
                if(mois % 12 ==0){

                var table = new ConsoleTable("Catégorie","","");
                                
                        
                string fleche = "------------------------>";
                table.AddRow($"année {mois/12}",fleche ,  montant.ToString("c",myCIintl)    );
                Console.WriteLine(table);
                }


               

            
                  }
                while (montant <=1000000);
              
              int annes = (int)Math.Floor(mois/12);
              int moisRestants = (int)mois %12;

                Console.WriteLine($"En {annes} ans et {moisRestants} mois vous aurrez atteint le million de dollars. Plus précisément {montant.ToString("c",myCIintl)}.");

                   
                   
               

                
                








                              
            //     //Config tableau resultats
            //     var table = new ConsoleTable("Catégorie","","");
                                
                        
            //     string fleche = "------------------------>";
            //     table.AddRow("Nombre de versements",fleche        ,versementsUnAn*amortissement)
            //     .AddRow("Paiement de capital",fleche              ,montantPret.ToString("c", myCIintl))
            //     .AddRow("Paiement de frais d'interêts", fleche    ,interets.ToString("c", myCIintl) )
            //     .AddRow("Coût total", fleche                      ,total.ToString("c", myCIintl) );
            //     Console.WriteLine(table);
                                
            //     do{
            //         Console.WriteLine("Voulez vous calculer une autre hypoteque? (O)ui ou (N)on");
            //         valide = Char.TryParse(Console.ReadLine().ToUpper(), out reponse) && reponse == 'O' || reponse =='N';}
            //         while(!valide);

            //     continuer = (reponse =='O')?  true : false;

                
            } while (continuer == true);























        }
    }
}
