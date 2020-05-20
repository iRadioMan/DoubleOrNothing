using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleOrNothing
{
    class DONGame
    {
        public int Money { get; set; }
        public int Cost { get; }
        public int Jackpot { get; }
        public int Amount { get; set; }
        public int WinFlag { get; set; }
        public int Multiplier { get; set; }
        public int Chance { get; set; }
        Random random;
        public DONGame(int money, int cost, int jackpot, int chance)
        {
            Money = money;
            Cost = cost;
            Jackpot = jackpot;
            Chance = chance;
            Amount = 0;
            Multiplier = 0;
            WinFlag = -1;
            random = new Random();
        }

        public string MultiplierText
        {
            get
            {
                if (WinFlag != 0 && ((Money - Cost) < 0)) return "No money";
                else if (WinFlag == 2) return "JACKPOT!";
                else if (WinFlag == 1) return " You won!";
                else if (WinFlag == -1) return "  Nothing";
                else return "      X" + Multiplier.ToString();
            }
        }

        public void Reset()
        {
            Amount = 0;
            WinFlag = -1;
        }

        public void ChooseDouble()
        {
            if ((Money - Cost) < 0 && WinFlag != 0) return;

            WinFlag = 0;

            if (Multiplier == 0)
            {
                Money -= Cost;
                Amount = Cost;
                Multiplier = 1;
            }
            else
            {
                if (random.Next(0, 100) < Chance)
                {
                    ++Multiplier;
                    //Amount *= Multiplier;
                    Amount *= 2;
                    if (Multiplier == 10)
                    {
                        WinFlag = 2;
                        Multiplier = 0;
                        Money += Jackpot;
                        Amount = Jackpot;
                    }
                }
                else
                {
                    WinFlag = -1;
                    Multiplier = 0;
                    Amount = 0;
                }
            }
        }

        public void TakeOut()
        {
            WinFlag = 1;
            Multiplier = 0;
            Money += Amount;
        }
    }
}
