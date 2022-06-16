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
                generateTickets();
                int [] winningCombination = generateCombination(7);
                validateTickets();

                // generateStats();
                // showStats();


            }while(continuer);

            
        }
        static void askUser(){
            bool valid = false;
            do{
                Console.WriteLine("Hi!  How many tickets do you need?");
                valid = Int32.TryParse(Console.ReadLine(),out nbTickets) && nbTickets > 9 && nbTickets < 201;
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
        
        
        static void generateTickets(){
            
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
        }
        static void validateTickets(){
         
            Console.Write(tickets[0][0]);

        }
    }
}
