using System;

namespace marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double totalTemps= 0;
            double plusRapide = 18000;
            int numeroPlusRapide =0;
            string best="";
            int num =-1;
            
            
            
            
            num = numeroCoureur();
            while(num != 0 ){
            
                count++;
                
                coureur cour;
                cour.numero = num;
                cour.heures = nbHeures();
                cour.minutes = nbMinutes();
                cour.secondes = nbsecondes();

                totalTemps = (cour.heures*60*60) + (cour.minutes*60)+ cour.secondes;
                Console.WriteLine(totalTemps);
                if (totalTemps < plusRapide)
                {
                    plusRapide = totalTemps;
                    numeroPlusRapide = cour.numero;
                    best = $"Avec un temps de {cour.heures}h {cour.minutes} min et {cour.secondes} secondes. ";
                  
                }
                num = numeroCoureur();
            };
            Console.WriteLine(@$"Nombre de participants: {count}
            Coureur le plus rapide :{numeroPlusRapide}");
            Console.WriteLine(best);
            Console.WriteLine("Merci d'avoir couru à St-Boudin de Bellechasse" );

            

        }




        static int numeroCoureur(){
            bool valide = true;
            int numero;
            do{
                Console.WriteLine("Entrez votre numero de coureur");
                valide = Int32.TryParse(Console.ReadLine(),out numero)&& numero >=0 && numero <=200; 
            }while(!valide);
            return numero;
            
        }
        static int nbHeures(){
            bool valide = true;
            int nbHeures;
            do{
                Console.WriteLine("Entrez les heures");
                valide = Int32.TryParse(Console.ReadLine(),out nbHeures)&& nbHeures >=0 && nbHeures <=6; 
            }while(!valide);
            return nbHeures;
        }
         static int nbMinutes(){
            bool valide = true;
            int nbMinutes;
            do{
                Console.WriteLine("Entrez les minutes");
                valide = Int32.TryParse(Console.ReadLine(),out nbMinutes)&& nbMinutes >=0 && nbMinutes <=60; 
            }while(!valide);
            return nbMinutes;
        }
           static int nbsecondes(){
            bool valide = true;
            int nbsecondes;
            do{
                Console.WriteLine("Entrez les secondes courus");
                valide = Int32.TryParse(Console.ReadLine(),out nbsecondes)&& nbsecondes >=0 && nbsecondes <=60; 
            }while(!valide);
            return nbsecondes;
        }

      public struct coureur{
          public int numero;
          public int heures;
          public int minutes;
          public int secondes;
      }





    }
}
