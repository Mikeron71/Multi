﻿using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace TP1
{
  public class WinningCondition
  {
    public string MsgWin;
    public string Identification;
    public double WinnerCount;
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
    static double nbTickets;
    static Random hasard = new Random(DateTime.Now.Millisecond);
    static int[] winningCombination;
    static int[] countNum = new int[7];
    static void Main(string[] args)
    {
      var recommencer = false;
      do
      {
        AskUser();
        var tickets = GenerateTickets();
        winningCombination = GenerateCombination(7);
        ShowWinningComb();
        ValidateTickets(tickets);
        recommencer = GoAgain();
      } while (recommencer == true);
    }
    static void AskUser()
    {
      string errMsg = "Vous devez entrer un chiffre entre 10 et 200";
      bool valid = false;
      do
      {
        WriteLine("Bonjour! Combien de billets voulez-vous? Entrez un nombre entre 10 et 200.");
        try
        {
          nbTickets = Convert.ToInt32(ReadLine());
          valid = nbTickets >= 10 && nbTickets <= 200;

        }
        catch (FormatException)
        {
          WriteLine(errMsg);
        }
        catch (OverflowException)
        {
          WriteLine(errMsg);
        }
        catch (Exception)
        {
          WriteLine(errMsg);
        }
      } while (!valid);
    }

    static int[] GenerateCombination(int nbDeNum)
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
    static List<Ticket> GenerateTickets()
    {
      var tickets = new List<Ticket>();
      for (int i = 0; i < nbTickets; i++)
      {
        var ticket = new Ticket()
        {
          Id = i + 1,
          Combination = GenerateCombination(6),
          IsWinner = false
        };
        var conb = string.Join(" ", ticket.Combination.Select(s => string.Format("{0,2}", s)));
        WriteLine($"Ticket {string.Format("{0,3}", ticket.Id)} : {conb}");
        tickets.Add(ticket);
      }
      WriteLine();
      return tickets;
    }
    static void ValidateTickets(List<Ticket> tickets)
    {
      // je reset le count pour les numéros gagnants ici. Sinon il incrémente lorsque le user recommence.
      countNum = new int[7];
      // J'utilise une liste d'objets pour simplifier la validation. 
      var winningConditions = new List<WinningCondition>{
          new WinningCondition{
            CombinationCount = 2,
            HasComplement = false,
            MsgWin = "Billet {0} gagne une participation gratuite.",
            WinnerCount = 0,
            Identification = "Gagnant 2/6"
          },
          new  WinningCondition{
            CombinationCount = 2,
            HasComplement = true,
            MsgWin = "Billet {0} gagne 5 $",
            WinnerCount = 0,
            Identification = "Gagnant 2/6+c"
          },
          new WinningCondition{
            CombinationCount = 3,
            HasComplement = false,
            MsgWin = "Billet {0} gagne 10$",
            WinnerCount = 0,
            Identification = "Gagnant 3/6"
          },
          new WinningCondition{
            CombinationCount = 4,
            HasComplement = false,
            MsgWin = "Billet {0} remporte lot (4/6).",
            WinnerCount = 0,
            Identification = "Gagnant 4/6"
          },
          new WinningCondition{
            CombinationCount = 5,
            HasComplement = false,
            MsgWin = "Billet {0} remporte lot(5/6).",
            WinnerCount = 0,
            Identification = "Gagnant 5/6"
          },
          new WinningCondition{
            CombinationCount = 5,
            HasComplement = true,
            MsgWin = "Billet {0} remporte lot(5/6) plus complementaire",
            WinnerCount = 0,
            Identification = "Gagnant 5/6+c"
          },
          new WinningCondition{
            CombinationCount = 6,
            HasComplement = false,
            MsgWin = "Billet {0} remporte le gros-lot.",
            WinnerCount = 0,
            Identification = "Gagnant du gros-lot"
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
            WriteLine(string.Format(item.MsgWin, i + 1));
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
        WriteLine($"Le chiffre {winningCombination[j]} est sortis {countNum[j]} fois dans les billets gagnants.");
      }

      //iteration sur les conditions pour compter et afficher les gagnant SELON CATEGORIE
      foreach (var item in winningConditions)
      {
        double pourcentage = item.WinnerCount / nbTickets;
        WriteLine();
        Write(string.Format("{0,-20}", item.Identification));
        Write(string.Format("{0,-10}", pourcentage.ToString("p")));
        for (int i = 0; i < item.WinnerCount; i++)
        {
          Write("■ ");
        }
      }
    }
    static void ShowWinningComb()
    {
      WriteLine("Voici la combinaison gagnante : ");
      for (int i = 0; i < winningCombination.Length; i++)
      {
        if (i == 6)
        {
          WriteLine("Complémentaire: " + winningCombination[i]);
        }
        else
        {
          Write(winningCombination[i] + " ");
        }
      }
      WriteLine();
    }
    static bool GoAgain()
    {
      bool valide;
      bool ouiOuNon;
      char reponse;
      do
      {
        WriteLine("\nVoulez vous recommencer? (O)ui ou (N)on");
        valide = Char.TryParse(ReadLine().ToUpper(), out reponse) && reponse == 'O' || reponse == 'N';
      } while (!valide);

      ouiOuNon = (reponse == 'O') ? true : false;
      return ouiOuNon;
    }
  }
}

