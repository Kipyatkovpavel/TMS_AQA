using System.Globalization;

namespace Classes.Models
{
    public class CreditCard
    {
        public long scorenumber;
        public float moneybalance;
        public float newmoney;

        public CreditCard(long scorenumber, float moneybalance)
        {
            this.scorenumber = scorenumber;
            this.moneybalance = moneybalance;
        }

        public void FirstBalance()
        {
            Console.WriteLine($"На вашей карте {scorenumber} баланс {moneybalance}");
        }
        public void NewSumMoney(float newmoney)
        {
            moneybalance += newmoney;
            Console.WriteLine($"Вы пополнили свой счёт на сумму {newmoney} теперь ваш баланс {moneybalance}");
        }

        public void NewMinusMoney(float newmoney)
        {
            if (moneybalance > newmoney)
            {
                moneybalance -= newmoney;
                Console.WriteLine($"Вы сняли сумму {newmoney} теперь ваш баланс {moneybalance}");
            }
            else
            {
                Console.WriteLine($"На карте недостаточно средств для совершения операции");
            }
        }

        public void NowBalance()
        {
            Console.WriteLine($"На вашей карте {scorenumber} баланс {moneybalance}");
        }

    }
}
