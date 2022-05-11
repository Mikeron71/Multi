using System;

namespace partie2
{
    class Program
    {
        static void Main(string[] args)
        {

            double depotInitial;
            double tauxAnnuel;
            double depotsSubsequents;
            bool valide = false;
            bool continuer = false;
            double total= 0;
            double count = 0;
            double interetGagne;
            



           do{
               do{
                    Console.WriteLine("Veuillez entrer le montant du dépot initial");
                    valide = double.TryParse(Console.ReadLine().Replace(" ", string.Empty),out depotInitial)&& depotInitial > 0;
  

                }while(!valide);
                do{
                    Console.WriteLine("Veuillez entrer le taux d'intérêts annuel. Entrez 10 pour 10%");
                    valide = double.TryParse  (Console.ReadLine(),out tauxAnnuel);
                


                }while(!valide);
                do{
                    Console.WriteLine("Veuillez entrer le montant des dépots subséquents mensuels");
                    valide = double.TryParse(Console.ReadLine(),out depotsSubsequents);
                  

                }while(!valide);

                //Calculs 

                while (total <10000){
                    count++;
                  
                    // interetGagne = (decimal)Math.Pow(depotInitial*(1+tauxAnnuel/12/100),12);
               
                double montant = depotInitial*Math.Pow((1+tauxAnnuel/12/100),12);
                interetGagne = depotInitial-montant;
                total = total +montant;
                total = total +depotsSubsequents;
                    Console.WriteLine("montant====" + montant);
                    Console.WriteLine("interet gagne====" + interetGagne);
                    Console.WriteLine("total" + total);

                    Console.WriteLine(count);

                
                }








                              
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
