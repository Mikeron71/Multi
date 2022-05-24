using System;

namespace Assurances
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int numeroClient;
            int nombreAccidents;
            double montantActuel;
            bool valide = false;
            bool continuer = false;
            double augmentation0 = 0.05;
            double augmentation1 = 0.08;
            double augmentation2 = 0.15;
            double augmentation3 = 0.40;
            double nouvellePrime = 0;
            char reponse ;

           
            do {



                do { 
                        Console.WriteLine("Veuillez entrer votre numero de client");
                        valide = int.TryParse(Console.ReadLine(),out numeroClient) && numeroClient  >0  ;

                        } while(valide == false);


                do { 
                        Console.WriteLine("Veuillez entrer votre nombre d'accidents enregistres");
                        valide = int.TryParse(Console.ReadLine(),out nombreAccidents) && nombreAccidents  >= 0  ;
                }while(valide == false);

                do { 
                        Console.WriteLine("Veuillez entrer le montant de la prime actuelle");
                        valide = double.TryParse(Console.ReadLine(),out montantActuel)&& montantActuel >0;
                    } while(valide == false);






                switch(nombreAccidents) 
                    {
                      case 0:
                        nouvellePrime = (montantActuel*augmentation0) + montantActuel;
                        break;
                      case 1:
                        nouvellePrime = (montantActuel*augmentation1) + montantActuel;
                        break;
                      case 2:
                        nouvellePrime = (montantActuel*augmentation2) + montantActuel;
                        break;
                      case 3:
                        nouvellePrime = (montantActuel*augmentation3) + montantActuel;
                        break;
                      case >=4:
                        Console.WriteLine("Suppression de la police") ;
                        break;
                      default:
                        {}
                        break;
                    }
                if(nombreAccidents  < 4)
                Console.WriteLine($"Le client {numeroClient} a subit {nombreAccidents} accidents et sa nouvelle prime s'eleve a {nouvellePrime}$");
                
                do{
                    Console.WriteLine("Voulez vous calculer une autre prime? (O)ui ou (N)on");
                    valide = Char.TryParse(Console.ReadLine().ToUpper(), out reponse) && reponse == 'O' || reponse =='N';
                }
                    while(valide == false);

                continuer = (reponse == 'O') ? true: false;


             } while (continuer == true);
        }
    }
}
