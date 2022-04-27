using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            double averageSleep = 2598.8;
            double lotrRuntime = 7.12;
            int userAge;
           
            Console.WriteLine("Veuillez entrer votre age suivi de la touche ENTER");
            userAge = Convert.ToInt32(Console.ReadLine());

            if(userAge < 18) {
                Console.WriteLine("Désolé, il n'y a pas de données pour les 18 ans et moins.");
            }
            else {
            int adultYears = userAge -18;
            double hoursSlept = adultYears * averageSleep;
            double missedOpportunity = hoursSlept / lotrRuntime;

            Console.WriteLine($"Vous avez dormis un total de {hoursSlept} heures.  Vous auriez pu écouter la trilogie version longue du seigneur des anneaux {missedOpportunity} fois. Dommage... ");

            }

        }
    }
}
