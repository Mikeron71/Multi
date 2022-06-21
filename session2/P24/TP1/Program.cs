using System;
using System.Collections;

namespace TP1
{
    class Program
    {   static int nbTickets;
        static Random hasard = new Random(DateTime.Now.Millisecond);
        static int [][] tickets;
        static int [] winningCombination;
        static void Main(string[] args)
        {   bool continuer = false;
            do{
                askUser();
            
                tickets = generateTickets();
                winningCombination = generateCombination(7);
                afficherWinning();

            
                validateTickets();

               


            }while(continuer);

            
        }
        static void askUser(){
            bool valid = false;
            do{
                Console.WriteLine("Hi!  How many tickets do you need?");
                valid = Int32.TryParse(Console.ReadLine(),out nbTickets) && nbTickets > 9 && nbTickets < 999999;
            }while(!valid);
        }
        
        static int[] generateCombination(int combien){
            
            int[] lign = new int[combien];
            for (int i = 0; i < combien; i++){  
                bool doublon;
                
                do{
                    int randomNuber = hasard.Next(1,50);
                    doublon = Array.Exists(lign, element => element == randomNuber);
                    if (doublon == false){
                        lign[i]= randomNuber;
                        
                    } 
                }while(doublon == true);
                
            } 
                Array.Sort(lign);
                return lign;
        }
        
        
        static int[][] generateTickets(){
            
              int[][] tickets = new int[nbTickets][];
           

           for (int i = 0; i < nbTickets; i++){
                tickets[i] = generateCombination(6);
           }


            for (int i = 0; i < tickets.Length;i++){
                if(i % 5 == 0 ){
                Console.WriteLine();
                }
                Console.Write( $"         ticket {i+1} :".PadLeft(3));
                for (int j = 0; j < 6; j++){ 
                    Console.Write(tickets[i][j].ToString().PadLeft(3) +  " ");
                    
                }
            }
          Console.WriteLine();
          return tickets;
        }
        static void validateTickets(){
            int countNum1 = 0;
            int countNum2 = 0;
            int countNum3 = 0;
            int countNum4 = 0;
            int countNum5 = 0;
            int countNum6 = 0;
            int countComp = 0;

            int num1 = winningCombination[0];
            int num2 = winningCombination[1];
            int num3 = winningCombination[2];
            int num4 = winningCombination[3];
            int num5 = winningCombination[4];
            int num6 = winningCombination[5];
            int comp = winningCombination[6];

   

            for (int i = 0; i < tickets.Length;i++){
                bool containsComp = false;
                int countWin = 0;
                    
                if( Array.Exists(tickets[i], element => element == num1)) {
                    countNum1++;
                    countWin++;
                }
                if( Array.Exists(tickets[i], element => element == num2)) {
                        countNum2++;
                        countWin++;
                }if( Array.Exists(tickets[i], element => element == num3)) {
                        countNum3++;
                        countWin++;
                }if( Array.Exists(tickets[i], element => element == num4)) {
                        countNum4++;
                        countWin++;
                }if( Array.Exists(tickets[i], element => element == num5)) {
                        countNum5++;
                        countWin++;
                }if( Array.Exists(tickets[i], element => element == num6)) {
                        countNum6++;
                        countWin++;
                }if( Array.Exists(tickets[i], element => element == comp)) {
                        countComp++;
                        containsComp = true;
                }

                if(countWin ==2 && containsComp == false ) {
                Console.WriteLine($"ticket {i+1} remporte une participation gratuite");
                }
                
                if(countWin ==2 && containsComp == true ) {
                Console.WriteLine($"ticket {i+1} remporte 5$ ");
                }

                if(countWin ==3) {
                    Console.WriteLine($"ticket {i+1} est un billet gagnant de 10$");
                }
                if(countWin ==4) {
                Console.WriteLine($"ticket {i+1} est un billet gagnant de 4");
                }
                    
                if(countWin ==5) {
                    Console.WriteLine($"ticket {i+1} est un billet gagnant de 5");

                } if(countWin ==5 && containsComp == true) {
                Console.WriteLine($"ticket {i+1} est un billet gagnant de 5 + C");
                
                    
                } if(countWin ==6) {
                    Console.WriteLine($"ticket {i+1} est un billet gagnant de 6");
                    
                }

             }
   
          Console.WriteLine($"Le chiffre {winningCombination[0]} est sorti {countNum1} fois" );
          Console.WriteLine($"Le chiffre {winningCombination[1]} est sorti {countNum2} fois" );
          Console.WriteLine($"Le chiffre {winningCombination[2]} est sorti {countNum3} fois" );
          Console.WriteLine($"Le chiffre {winningCombination[3]} est sorti {countNum4} fois" );
          Console.WriteLine($"Le chiffre {winningCombination[4]} est sorti {countNum5} fois" );
          Console.WriteLine($"Le chiffre {winningCombination[5]} est sorti {countNum6} fois" );
          Console.WriteLine($"Le chiffre {winningCombination[6]} est sorti {countComp} fois" );
         }
         static void afficherWinning(){
            Console.WriteLine("Voici la combinaison gagnante : " );
            for (int i = 0; i < winningCombination.Length;  i++)
              {
                if(i == 6){
                    Console.WriteLine("Complémentaire: " + winningCombination[i]);
                } else{

                Console.Write(winningCombination[i] + " ");
                }
                
            }
         }
    }
}
