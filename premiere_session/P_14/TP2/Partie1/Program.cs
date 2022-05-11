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
           
            double montantPret;
            double tauxHypotecaire;
            double versementsMensuels;
            double total;
            int amortissement = 0;
            int versementsUnAn = 12;
            bool continuer = false;
            bool valide = true;
            double interets ;
            char reponse;
            
      


            do
            {
               do{
                    Console.WriteLine("Veuillez entrer le montant du pret sans espace.");
                    valide = double.TryParse(Console.ReadLine(),out montantPret)&& montantPret > 0;

                }while(!valide);
                do{
                    Console.WriteLine("Veuillez entrer le taux hypotecaire.");
                    valide = double.TryParse(Console.ReadLine(),out tauxHypotecaire);

                }while(!valide);
                do{
                    Console.WriteLine("Veuillez entrer la periode d'amortissement");
                    valide = Int32.TryParse(Console.ReadLine(),out amortissement) && amortissement >=5 && amortissement <=30 && amortissement % 5 ==0;
                  

                }while(!valide);

                double aDiviser = montantPret*tauxHypotecaire/versementsUnAn;
                double exposant = -versementsUnAn*amortissement;
                              
                double diviseur =  1- Math.Pow((1+tauxHypotecaire/versementsUnAn),exposant);
             
                versementsMensuels = aDiviser/diviseur;
                
                total = versementsMensuels*(versementsUnAn*amortissement);
                interets = total - montantPret;
               
                              

                                var table = new ConsoleTable("Catégorie","","");
                                
                        
                           
                                table.AddRow("Nombre de versements","------------------------->" ,versementsUnAn*amortissement)
                                .AddRow("Versements mensuels", "------------------------->",versementsMensuels.ToString("c", myCIintl) )
                                .AddRow("Paiement de capital","------------------------->", montantPret.ToString("c", myCIintl))
                                .AddRow("Paiement de frais d'interêts", "------------------------->",interets.ToString("c", myCIintl) )
                                .AddRow("Coût total", "------------------------->",total.ToString("c", myCIintl) );
                                

                              
                                Console.WriteLine(table);
                            
                            

                                

                               
                               do{
                   
               
                               
                               
                                Console.WriteLine("Voulez vous calculer une autre hypoteque? (O)ui ou (N)on");
                                valide = Char.TryParse(Console.ReadLine().ToUpper(), out reponse) && reponse == 'O' || reponse =='N';
                           
                                }while(!valide);

                                continuer = (reponse =='O')?  true : false;


                          





                

                    



          
               
            

















                
            } while (continuer == true);




            
        }
    }
}
