using System;

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
                generateCombination(6);
                tickets = generateTickets();
                winningCombination = generateCombination(7);
                Console.Write(winningCombination[0] +" ");
                Console.Write(winningCombination[1] +" ");
                Console.Write(winningCombination[2] +" ");
                Console.Write(winningCombination[3]+" ");
                Console.Write(winningCombination[4]+" ");
                Console.Write(winningCombination[5]+" ");
                Console.Write(winningCombination[6]+" ");

                validateTickets();

                // generateStats();
                // showStats();


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
                return lign;
        }
        
        
        static int[][] generateTickets(){
            
              int[][] tickets = new int[nbTickets][];
           

           for (int i = 0; i < nbTickets; i++){
                tickets[i] = generateCombination(6);
           }


            for (int i = 0; i < tickets.Length;i++){
                Console.WriteLine();
                Console.Write( $"ticket {i+1} :    ");
                for (int j = 0; j < 6; j++){ 
                    Console.Write(tickets[i][j] + " ");
                    
                }
            }
          Console.WriteLine();
          return tickets;
        }
        static void validateTickets(){
         int countnum1 = 0;
         int countnum2 = 0;
         int countnum3 = 0;
         int countnum4 = 0;
         int countnum5 = 0;
         int countnum6 = 0;
         int countcomp = 0;

         int num1 = winningCombination[0];
         int num2 = winningCombination[1];
         int num3 = winningCombination[2];
         int num4 = winningCombination[3];
         int num5 = winningCombination[4];
         int num6 = winningCombination[5];
         int comp = winningCombination[6];

         Console.WriteLine("num1 =="+ num1);

        for (int i = 0; i < tickets.Length;i++){
            bool containsComp = false;
            int countWin = 0;
                
            if( Array.Exists(tickets[i], element => element == num1)) {
                countnum1++;
                countWin++;
            }
            if( Array.Exists(tickets[i], element => element == num2)) {
                    countnum2++;
                    countWin++;
            }if( Array.Exists(tickets[i], element => element == num3)) {
                    countnum3++;
                    countWin++;
            }if( Array.Exists(tickets[i], element => element == num4)) {
                    countnum4++;
                    countWin++;
            }if( Array.Exists(tickets[i], element => element == num5)) {
                    countnum5++;
                    countWin++;
            }if( Array.Exists(tickets[i], element => element == num6)) {
                    countnum6++;
                    countWin++;
            }if( Array.Exists(tickets[i], element => element == comp)) {
                    countcomp++;
                    containsComp = true;
            }

            if(countWin ==3) {
                Console.WriteLine($" ticket {i+1} est un billet gagnant de 3");
                
            }
             if(countWin ==4) {
                Console.WriteLine($" ticket {i+1} est un billet gagnant de 4");
                
            } if(countWin ==5) {
                Console.WriteLine($" ticket {i+1} est un billet gagnant de 5");
                
            } if(countWin ==6) {
                Console.WriteLine($" ticket {i+1} est un billet gagnant de 6");
                
            }

        }
        Console.Write("countcount ===" + countnum1);
        Console.Write("countcount ===" + countnum2);
        Console.Write("countcount ===" + countnum3);
        Console.Write("countcount ===" + countnum4);
        Console.Write("countcount ===" + countnum5);
        Console.Write("countcount ===" + countnum6);
        Console.Write("countcount ===" + countcomp);
        Console.Write("countcount ===" + countcomp);
                

        }
    }
}
