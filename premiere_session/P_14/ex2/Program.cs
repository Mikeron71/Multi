using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
        string nom;
        string prenom;
        int age;
        char sexe;
        bool continuer = false;
        bool valide = true;

        int nbHomme =0;
        int nbFemme =0;
        double ageMoyen =0;
        int totalAge = 0;
        int count = 0;
        char reponse = default;


        do{
            
            do{
                try
                {
                    Console.WriteLine("veuillez entrez le prenom");
                    prenom = Console.ReadLine();
                    
                    
                }
                catch (System.Exception)
                {Console.WriteLine("erreur");
                valide = false;}
                
             
            } while (!valide);

                
            
            do{
                try
                {
                    Console.WriteLine("veuillez entrez le nom");
                    nom = Console.ReadLine();
                    
                }
                catch (System.Exception)
                {Console.WriteLine("erreur");
                valide = false;
                }
            } while (!valide);

            while(!valide){
                try
                {
                    Console.WriteLine("veuillez entrez le nom");
                    nom = Console.ReadLine();
                    
                }
                catch (System.Exception)
                {Console.WriteLine("erreur");
                valide = false;
                }
            }

            
            do
                {
                    Console.WriteLine("veuillez entrer l'age");
                    valide = int.TryParse(Console.ReadLine(),out age) && age >0;
                    totalAge += age;

                    
                } while (!valide);

            
             do
                {
                    Console.WriteLine("veuillez entrer le sexe");
                    valide = char.TryParse(Console.ReadLine().ToUpper(),out sexe) && sexe == 'M' || sexe == 'F';
                   if(sexe == 'M'){
                       nbHomme ++;

                   } else {
                       nbFemme ++;
                   }

                    
                } while (!valide);

                count ++;

                ageMoyen = totalAge/count;


                do{
                    Console.WriteLine("Voulez vous entrer une autre personne (O)ui ou (N)on?");
                    valide = char.TryParse(Console.ReadLine().ToUpper(),out reponse) && reponse == 'O' || reponse == 'N';

                } while(!valide);

                continuer = (reponse == 'O')? true: false; 

                

                    







            }while(continuer);


                Console.WriteLine($"il y a {nbHomme} homme et {nbFemme} femme et l'age moyen est de {ageMoyen} ans .");














        }
    }
}
