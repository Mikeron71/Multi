using System;
using System.Collections;
using System.Collections.Generic;

namespace TP1
{
  public class WiningCondition
  {
    public string MsgWin;
    public int WinnerCount;
    public int CombinationCount;
    public bool HasComplement;
  }
  class Program
  {
    static int nbTickets;
    static Random hasard = new Random(DateTime.Now.Millisecond);
    static int[][] tickets;
    static int[] winningCombination;
    static void Main(string[] args)
    {
      var recommencer = false;
      do
      {
        askUser();
        tickets = generateTickets();
        winningCombination = generateCombination(7);
        showWinnings();
        validateTickets();
        recommencer = goAgain();
      } while (recommencer == true);
    }



    static void askUser()
    {
      bool valid = false;
      do
      {
        Console.WriteLine("Bonjour! Combien de billets voulez-vous?");
        valid = Int32.TryParse(Console.ReadLine(), out nbTickets) && nbTickets >= 10 && nbTickets <= 200;
      } while (!valid);
    }

    static int[] generateCombination(int nbDeNum)
    {
      var lign = new int[nbDeNum];
      for (int i = 0; i < nbDeNum; i++)
      {
        bool doublon;

        do
        {
          int randomNuber = hasard.Next(1, 50);
          doublon = Array.Exists(lign, element => element == randomNuber);
          if (doublon == false)
          {
            lign[i] = randomNuber;
          }
        } while (doublon == true);
      }
      Array.Sort(lign);
      return lign;
    }


    static int[][] generateTickets()
    {
      int[][] tickets = new int[nbTickets][];
      for (int i = 0; i < nbTickets; i++)
      {
        tickets[i] = generateCombination(6);
      }

      for (int i = 0; i < tickets.Length; i++)
      {
        Console.WriteLine();

        Console.Write($"         ticket {i + 1} :".PadLeft(3));
        for (int j = 0; j < 6; j++)
        {
          Console.Write(tickets[i][j].ToString().PadLeft(3) + " ");

        }
      }
      Console.WriteLine();
      return tickets;
    }
    static void validateTickets()
    {
      var countNum = new int[7];





      for (int i = 0; i < tickets.Length; i++)
      {
        bool containsComp = false;
        int countWin = 0;
        for (int j = 0; j < countNum.Length; j++)
        {
          if (Array.Exists(tickets[i], element => element == winningCombination[j]))
          {
            if (j == 6)
            {
              containsComp = true;
            }
            countNum[j]++;
            countWin++;
          }

        }

        var winingConditions = new List<WiningCondition>{
          new WiningCondition{
            CombinationCount = 2,
            HasComplement = false,
            MsgWin = "Billet {0} gagne une participation gratuite.",
            WinnerCount = 0,


          },

          new WiningCondition{
            CombinationCount = 2,
            HasComplement = true,
            MsgWin = "Billet {0} gagne 5 $",
            WinnerCount = 0,


          },
          new WiningCondition{
            CombinationCount = 3,
            HasComplement = false,
            MsgWin = "Billet {0} gagne 10$",
            WinnerCount = 0,


          },
          new WiningCondition{
            CombinationCount = 4,
            HasComplement = false,
            MsgWin = "Billet {0} remporte lot (4/6).",
            WinnerCount = 0,


          },
              new WiningCondition{
            CombinationCount = 5,
            HasComplement = false,
            MsgWin = "Billet {0} remporte lot(5/6).",
            WinnerCount = 0,


          },
              new WiningCondition{
            CombinationCount = 5,
            HasComplement = true,
            MsgWin = "Billet {0} remporte lot(5/6) plus complementaire",
            WinnerCount = 0,


          },
              new WiningCondition{
            CombinationCount = 6,
            HasComplement = false,
            MsgWin = "Billet {0} remporte le gros-lot.",
            WinnerCount = 0,


          },

        };

        foreach (var item in winingConditions)
        {
          if (countWin == item.CombinationCount && containsComp == item.HasComplement)
          {
            Console.WriteLine(string.Format(item.MsgWin, i + 1));
            item.WinnerCount++;



          }
        }


      }
      for (int j = 0; j < countNum.Length; j++)
      {


        Console.WriteLine($"Le chiffre {winningCombination[0]} est sorti {countNum[j]} fois");
      }


    }

    static void showWinnings()
    {
      Console.WriteLine("Voici la combinaison gagnante : ");
      for (int i = 0; i < winningCombination.Length; i++)
      {
        if (i == 6)
        {
          Console.WriteLine("Complémentaire: " + winningCombination[i]);
        }
        else
        {
          Console.Write(winningCombination[i] + " ");
        }
      }
    }



    static bool goAgain()
    {
      bool valide;
      bool ouiOuNon;
      char reponse;

      do
      {
        Console.WriteLine("\nVoulez vous recommencer? (O)ui ou (N)on");
        valide = Char.TryParse(Console.ReadLine().ToUpper(), out reponse) && reponse == 'O' || reponse == 'N';
      } while (!valide);

      ouiOuNon = (reponse == 'O') ? true : false;
      return ouiOuNon;
    }
  }
}
