using System;
using ConsoleTables;


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
                                Console.WriteLine("EXPO" + exposant);
                double diviseur =  1- Math.Pow((1+tauxHypotecaire/versementsUnAn),exposant);
             
                versementsMensuels = aDiviser/diviseur;
                total = versementsMensuels*(versementsUnAn*amortissement);
                interets = total - montantPret;
                Console.WriteLine("adiviser===" +aDiviser);
                                Console.WriteLine("diviseur===" +diviseur);
                                Console.WriteLine("div2===" +diviseur);

                                Console.WriteLine("versements===" +versementsMensuels);

                                var table = new ConsoleTable("Catégorie","");
                                table.AddRow("Nombre de versements", versementsUnAn*amortissement)
                                .AddRow("Versements mensuels", versementsMensuels )
                                .AddRow("Paiement de capital", montantPret)
                                .AddRow("Paiement de frais d'interêts", interets )
                                .AddRow("Coût total", total );
                                

                                Console.WriteLine(table);
                                

                               
                               do{
                   
               
                               
                               
                                Console.WriteLine("Voulez vous calculer une autre hypoteque? (O)ui ou (N)on");
                                valide = Char.TryParse(Console.ReadLine().ToUpper(), out reponse) && reponse == 'O' || reponse =='N';
                                Console.WriteLine("dernier valide:" +valide);
                                }while(!valide);

                                continuer = (reponse =='O')?  true : false;


                          





                

                    



          
               
            

















                
            } while (continuer == true);




            
        }
    }
}
