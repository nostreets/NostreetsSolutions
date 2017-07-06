using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GitSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool active = true;

            while (active)
            {
                Console.WriteLine("Insert Name of Problem");
                string input = Console.ReadLine();
                int[] intInputs = new int[4];

                switch (input)
                {
                    case "pi":
                        Console.WriteLine("Insert A Number \nMax Is {0}", Math.PI.ToString().Length);
                        intInputs[1] = int.Parse(Console.ReadLine());

                        PiToTheNthNumber(intInputs[1]);
                        Console.ReadLine();
                        break;

                    case "addStudents":
                        ListOfStudents();
                        Console.ReadLine();
                        break;

                    case "buyorsell":

                        BuySellOrHold(new[] { 1, 2, 3, 7, 6, 1, 5, 3, 3, 4 });
                        Console.ReadLine();
                        break;

                    case "checkerboard":
                        Console.WriteLine("Insert # of Rows");
                        intInputs[1] = int.Parse(Console.ReadLine());

                        Console.WriteLine("Insert # of Columns");
                        intInputs[2] = int.Parse(Console.ReadLine());

                        CheckerBoard(intInputs[1], intInputs[2]);
                        Console.ReadLine();
                        break;

                    case "prime":
                        Console.WriteLine("Insert A Number");
                        intInputs[1] = int.Parse(Console.ReadLine());

                        IsPrimeNumber(intInputs[1]);
                        Console.ReadLine();
                        break;

                    case "quit":
                        Console.WriteLine("Exit Application?");
                        input = Console.ReadLine();
                        if (!input.Contains("no")) { active = false; }
                        break;

                    default:
                        Console.WriteLine("Exit Application?");
                        input = Console.ReadLine();
                        if (!input.Contains("no")) { active = false; }
                        break;
                }
            }

        }

        public static bool BuySellOrHold(int[] prices, bool hold = false)
        {
            //Incomplete

            int moneyMade = 0;
            int itemsBought = 0;
            bool buy = false;

            for (var i = 0; i < prices.Length; i++)
            {

                int result;
                int[] subArr = new int[prices.Length - i];
                prices.CopyTo(subArr, i);
                double average = subArr.Average();

                buy = subArr.Length != 1 ? BuySellOrHold(subArr) : false;

                if (subArr[0] < subArr.Max() && subArr.Length != 1 && !hold)
                {
                    moneyMade -= subArr[0];
                    itemsBought++;
                    hold = true;
                    break; 
                }
                else
                {
                    if (subArr[0] == subArr.Max() || subArr.Length == 1)
                    {
                        
                    }
                    else
                    {
                        moneyMade = subArr[0] * itemsBought;
                        itemsBought = 0;
                        break;
                    }
                }

            }
            return buy;
        }

        public static void PiToTheNthNumber(int input)
        {
            double pi = Math.PI;
            string stringOfPi = string.Concat(pi);
            Console.WriteLine(pi);
            Console.WriteLine(stringOfPi.ElementAt(input));
        }

        public static void CheckerBoard(int rows, int columns)
        {
            if (columns % 2 == 0) { columns++; }
            for (int i = 0; i < (rows * columns); i++)
            {
                if (i != 0 && i % columns == 0) { Console.WriteLine(); }
                if (i % 2 != 0)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(" ");

                }
            }
        }

        public static void IsPrimeNumber(int limit)
        {
            for (int cons = 2; cons < limit; cons++)
            {
                bool prime = true;
                for (int a = 1; a < cons; a++)
                {
                    if (cons % a == 0 && cons / a != cons) { prime = false; }
                }
                if (prime) { Console.WriteLine(cons); }
            }
        }

        public static void ListOfStudents()
        {
            var active = true;
            List<Dictionary<string, object>> contacts = new List<Dictionary<string, object>>();
            do
            {
                Dictionary<string, object> contact = new Dictionary<string, object>();
                Console.WriteLine("Put in contact info...");
                Console.Write("First Name:  ");
                contact["FirstName"] = Console.ReadLine();
                Console.Write("Last Name:  ");
                contact["LastName"] = Console.ReadLine();
                Console.Write("Age:  ");
                contact["Age"] = Console.ReadLine();
                Console.Write("Are you a student?  ");
                string checkStudent = Console.ReadLine();
                if (checkStudent == "yes") { contact["IsStudent"] = true; }
                else { contact["IsStudent"] = false; }
                contacts.Add(contact);
                Console.WriteLine("Contact Added!");
                Console.ReadLine();
                Console.WriteLine("Add Another?");
                string checkBreak = Console.ReadLine();
                if (checkBreak.Contains("yes")) continue;
                else active = false;
            } while (active);
            Console.WriteLine("The Senior Students are :");
            foreach (var index in contacts)
            {
                if (int.Parse(index["Age"].ToString()) >= 21)
                {
                    Console.WriteLine();
                    Console.WriteLine("{0} {1}, {2}, {3}", index["FirstName"], index["LastName"], index["Age"], (bool)index["IsStudent"] ? "Student" : "Not Student");
                }
                else
                {
                    continue;
                }
            }
            Console.ReadLine();
        }
    }
}
