using System;

namespace Battleship2._0
{
    class Program
    {
        static string player1Name;
        static string player2Name;

       
        static string[,] player1Card ;
        static string[,] player2Card ;
        static string[,] player1Blank ;
        static string[,] player2Blank ;
        
        static void welcomePlayers(){
            Console.WriteLine("ITS BATTLESHIP TIME");
        }

        static string askName(string whichPlayer){
            Console.WriteLine($"veuillez entrer le nom du {whichPlayer} joueur");
            string name = Console.ReadLine();
            return name;
        }

        static string[,] createBlank(){
           string[,] blank = new string [10,10];
            for (int ligne = 0; ligne <= 9; ligne++){
                for (int col = 0; col <= 9; col++)
                    {blank[ligne,col] = "|_|"; 
                }
                
            }
            return blank;
        }
        static void afficherBlank(string[,]blank){
            char lettre = 'A';
             for (int ligne = 0; ligne <= 9; ligne++){
                 Console.Write("\n" + lettre);
                 lettre ++;
                for (int col = 0; col <= 9; col++)
                    {Console.Write(blank[ligne,col]);
                }
                
            }
        }

        

        static void setupGame(){
            player1Name = askName("Premier");
            player2Name = askName("Deuxieme");
            player1Blank = createBlank();
            player2Blank = createBlank();
            afficherBlank(player1Blank);
        }





        static void Main(string[] args)
        {

            welcomePlayers();
            setupGame();


       
        }
    }
}
