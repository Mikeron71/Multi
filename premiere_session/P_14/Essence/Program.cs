using System;
using System.Globalization;


namespace Essence
{
    class Program
    {
        static void Main(string[] args)
        {
             CultureInfo myCIintl = new CultureInfo("fr-CA", false);

            double prixEssence;
            double consommationMoyenne;
            double consommationKm;
            double total;
            int longeurTrajet;
            bool continuer = false;
            bool valide = false ;
            bool autreMontant = true;
            char reponse;
            double ajout; 
            double totalAjouts = 0;




        do{
            

            do{
                Console.WriteLine("Veuillez entrer le prix actuel de l'essence");
                valide = double.TryParse(Console.ReadLine(),out prixEssence) && prixEssence >0;
            } while(!valide);

            do{
                Console.WriteLine("Veuillez entrer la consommation moyenne de votre voiture.");
                valide = double.TryParse(Console.ReadLine(),out consommationMoyenne) && consommationMoyenne >0;
            } while(!valide);

            do{
            Console.WriteLine("Veuillez entrer la longeur de votre trajet en kilometre.");
            valide = int.TryParse(Console.ReadLine(),out longeurTrajet) && longeurTrajet >0;
            } while(!valide);

            

            while (autreMontant) {
                do{
                    Console.WriteLine("Avez-vous un autre montant a ajouter au total (O)ui ou (N)on ?");
                    valide = Char.TryParse(Console.ReadLine().ToUpper(),out reponse) && reponse == 'N' || reponse == 'O';
                } while(!valide);

                if(reponse == 'O') {
                do{
                    Console.WriteLine("Entrez le montant a ajouter.");
                    valide = double.TryParse(Console.ReadLine(), out ajout) && ajout > 0;
                    totalAjouts += ajout;
                    } while(!valide);

                
                

                } else {
                    autreMontant = false ;
                }


            }
            

            
            consommationKm = consommationMoyenne/100;
            total  = consommationKm *prixEssence *longeurTrajet + totalAjouts;

            
            if (totalAjouts >0)
            {
            Console.WriteLine($"Le montant total pour votre voyage est de {total.ToString("c", myCIintl)} en comptant les ajouts de {totalAjouts} $ ");
                
            } else {
            Console.WriteLine($"Le montant total pour votre voyage est de {total.ToString("c", myCIintl)} ");

            }
            


            do{
                Console.WriteLine("Voulez vous caluler un autre voyage? (O)ui ou (N)on ?");
                valide = Char.TryParse(Console.ReadLine().ToUpper(),out reponse) && reponse == 'N' || reponse == 'O';
            } while(!valide);

          continuer = (reponse == 'O')? true: false; 

         }while(continuer == true);
          








        }
    }
}
