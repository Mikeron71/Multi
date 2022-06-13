using System;
using System.Text;

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
        static string[,] player1Battle ;
        static string[,] player2Battle ;
        
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
        static string[,] creerBattle() {
        
            int ligne;
            int col;
            string[,] battle = new string[10,10];
            Random hasard = new Random(DateTime.Now.Millisecond);
            int ligneOuCol = hasard.Next(0,2);

            for (ligne = 0; ligne < 10; ligne++){
                for (col = 0; col < 10; col++){
                    battle[ligne,col] = "|_|";
                }
                
            }
            if (ligneOuCol == 0){
              
                int ligneAuHasard = hasard.Next(0,8);
                battle[ligneAuHasard,ligneAuHasard] = "|■|";
                battle[ligneAuHasard,ligneAuHasard+1] = "|■|";
                battle[ligneAuHasard,ligneAuHasard+2] = "|■|";
           
                    
            }else if (ligneOuCol ==1){
                 
                int colAuHasard = hasard.Next(0,8);
                battle[colAuHasard,colAuHasard] = "|■|";
                battle[colAuHasard+1,colAuHasard] = "|■|";
                battle[colAuHasard+2,colAuHasard] = "|■|";
             
            }
            return battle;


        }
        static void afficherBlank(string[,]blank){
            Console.Write("  1  2  3  4  5  6  7  8  9 10");
            char lettre = 'A';
             for (int ligne = 0; ligne <= 9; ligne++){
                 Console.Write("\n" + lettre);
                 lettre ++;
                for (int col = 0; col <= 9; col++)
                    {Console.Write(blank[ligne,col]);
                }
                
            }
        }

             static void afficherBattle(string[,]battle){
            Console.Write("\n  1  2  3  4  5  6  7  8  9 10");
            char lettre = 'A';
             for (int ligne = 0; ligne <= 9; ligne++){
                 Console.Write("\n" + lettre);
                 lettre ++;
                for (int col = 0; col <= 9; col++)
                    {Console.Write(battle[ligne,col]);
                }
                
            }
        }

  
        

        static void setupGame(){
            player1Name = askName("Premier");
            player2Name = askName("Deuxieme");
            player1Blank = createBlank();
            player2Blank = createBlank();
            player1Battle = creerBattle();
            player2Battle = creerBattle();
            afficherBlank(player1Blank);
            afficherBattle(player1Battle);
           
        }
        
       
       StringBuilder pow = new StringBuilder(); 




        static void Main(string[] args)
        {

            welcomePlayers();
            setupGame();


       
        }
    }
}
