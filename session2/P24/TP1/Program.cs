using System;
using System.Collections.Generic;
using System.Linq;

namespace TP1
{
  public class WiningCondition
  {
    public string MsgWin;
    public string identification;
    public int WinnerCount;
    public int CombinationCount;
    public bool HasComplement;
  }

  public class Ticket
  {
    public int Id;
    public int[] Combination = new int[6];
    public bool IsWinner;
  }

  class Program
  {
    static int nbTickets;
    static Random hasard = new Random(DateTime.Now.Millisecond);
    static int[] winningCombination;
    static int[] countNum = new int[7];
    static void Main(string[] args)
    {
      var recommencer = false;
      do
      {
        askUser();
        var tickets = generateTickets();
        winningCombination = generateCombination(7);
        showWinningComb();
        validateTickets(tickets);
        recommencer = goAgain();
      } while (recommencer == true);
    }

    static void askUser()
    {
      string errMsg = "Vous devez entrer un chiffre entre 10 et 200";
      bool valid = false;
      do
      {
        Console.WriteLine("Bonjour! Combien de billets voulez-vous? Entrez un nombre entre 10 et 200.");
        try
        {
          nbTickets = Convert.ToInt32(Console.ReadLine());
          valid = nbTickets >= 10 && nbTickets <= 200;

        }
        catch (FormatException)
        {
          Console.WriteLine(errMsg);

        }
        catch (OverflowException)
        {
          Console.WriteLine(errMsg);
        }
        catch (Exception)
        {
          Console.WriteLine(errMsg);
        }
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


    static List<Ticket> generateTickets()
    {
      var tickets = new List<Ticket>();
      for (int i = 0; i < nbTickets; i++)
      {
        var ticket = new Ticket()
        {
          Id = i + 1,
          Combination = generateCombination(6),
          IsWinner = false
        };


        var conb = string.Join(" ", ticket.Combination.Select(s => string.Format("{0,2}", s)));
        Console.WriteLine($"Ticket {string.Format("{0,3}", ticket.Id)} : {conb}");
        tickets.Add(ticket);
      }


      Console.WriteLine();
      return tickets;
    }
    static void validateTickets(List<Ticket> tickets)
    {
      // je reset le count pour les numéros gagnants ici. Sinon il incrémente lorsque le user recommence.
      countNum = new int[7];
      // J'utilise une liste d'objets pour simplifier la validation. 
      var winningConditions = new List<WiningCondition>{
          new WiningCondition{
            CombinationCount = 2,
            HasComplement = false,
            MsgWin = "Billet {0} gagne une participation gratuite.",
            WinnerCount = 0,
            identification = "Gagnant de 2/6"
          },

          new  WiningCondition{
            CombinationCount = 2,
            HasComplement = true,
            MsgWin = "Billet {0} gagne 5 $",
            WinnerCount = 0,
            identification = "Gagnant 2/6+c"
          },
          new WiningCondition{
            CombinationCount = 3,
            HasComplement = false,
            MsgWin = "Billet {0} gagne 10$",
            WinnerCount = 0,
            identification = "Gagnant 3/6"
          },
          new WiningCondition{
            CombinationCount = 4,
            HasComplement = false,
            MsgWin = "Billet {0} remporte lot (4/6).",
            WinnerCount = 0,
            identification = "Gagnant 4/6"
          },
              new WiningCondition{
            CombinationCount = 5,
            HasComplement = false,
            MsgWin = "Billet {0} remporte lot(5/6).",
            WinnerCount = 0,
            identification = "Gagnant 5/6"
          },
              new WiningCondition{
            CombinationCount = 5,
            HasComplement = true,
            MsgWin = "Billet {0} remporte lot(5/6) plus complementaire",
            WinnerCount = 0,
             identification = "Gagnant 5/6+c"
          },
              new WiningCondition{
            CombinationCount = 6,
            HasComplement = false,
            MsgWin = "Billet {0} remporte le gros-lot.",
            WinnerCount = 0,
            identification = "Gagnant du gros-lot"
          },
        };

      for (int i = 0; i < tickets.Count; i++)
      {

        bool containsComp = false;
        int countWin = 0;

        for (int j = 0; j < 7; j++)
        {
          if (Array.Exists(tickets[i].Combination, element => element == winningCombination[j]))
          {
            if (j == 6)
            {
              containsComp = true;
            }
            countWin++;
          }

        }



        foreach (var item in winningConditions)
        {
          if (countWin == item.CombinationCount && containsComp == item.HasComplement)
          {
            Console.WriteLine(string.Format(item.MsgWin, i + 1));
            item.WinnerCount++;
            tickets[i].IsWinner = true;

          }
        }
      }

      for (int i = 0; i < tickets.Count; i++)
      {
        for (int j = 0; j < 7; j++)
        {
          if (Array.Exists(tickets[i].Combination, element => element == winningCombination[j]) && tickets[i].IsWinner == true)
          {
            countNum[j]++;

          }
        }

      }
      for (int j = 0; j < 7; j++)
      {
        Console.WriteLine($"Le chiffre {winningCombination[j]} est sortis n{countNum[j]} fois dans les billets gagnants.");
      }

      //iteration sur les conditions pour compter et afficher les gagnant SELON CATEGORIE



      foreach (var item in winningConditions)
      {
        Console.WriteLine();
        Console.Write(string.Format("{0,-20}", item.identification));
        for (int i = 0; i < item.WinnerCount; i++)
        {
          Console.Write("■ ");
        }
      }
    }


    static void showWinningComb()
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
      Console.WriteLine();


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

