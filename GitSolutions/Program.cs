using System;
using System.Collections.Generic;
using System.Linq;


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
                List<object> inputs = new List<object>();

                switch (input)
                {

                    case "countCombinationsKata":
                        CountCombinations(10, new[] { 1, 2, 3 });
                        break;

                    case "sumConsecutivesKata":
                        SumConsecutives(new List<int> { 1, 4, 4, 4, 0, 4, 3, 3, 1 });
                        break;

                    case "nbrOfLapsKata":
                        Console.WriteLine("Insert the first distance:");
                        inputs.Add(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Insert the second distance:");
                        inputs.Add(int.Parse(Console.ReadLine()));
                        Console.WriteLine(NbrOfLaps((int)inputs[0], (int)inputs[1]));
                        break;

                    case "reverseWordsKata":
                        Console.WriteLine("Insert a sentence:");
                        input = Console.ReadLine();
                        Console.WriteLine(ReverseWords(input));
                        break;

                    case "persistenceKata":
                        Console.WriteLine("Insert a number:");
                        inputs.Add(long.Parse(Console.ReadLine()));
                        Console.WriteLine(Persistence((long)inputs[0]));
                        break;

                    case "encodeKata":
                        Console.WriteLine("Insert something:");
                        input = Console.ReadLine();
                        Console.WriteLine(DuplicateEncode(input));
                        break;

                    case "sortArrayKata":
                        SortArray(new int[] { 1, 4, 2, 7, 3, 5, 8, 9, 6, 0 });
                        break;

                    case "digPowKata":
                        Console.WriteLine("Insert a base number:");
                        inputs.Add(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Insert a exponent:");
                        inputs.Add(int.Parse(Console.ReadLine()));
                        Console.WriteLine(DigPow((int)inputs[0], (int)inputs[1]));
                        break;

                    case "jadenKata":
                        Console.WriteLine("Insert a sentence:");
                        input = Console.ReadLine();
                        Console.WriteLine(ToJadenCase(input));
                        break;

                    case "moneyKata":
                        Console.WriteLine("Insert Amount");
                        inputs.Add(int.Parse(Console.ReadLine()));

                        Console.WriteLine("Insert Interest");
                        inputs.Add(double.Parse(Console.ReadLine()));

                        Console.WriteLine("Insert Tax");
                        inputs.Add(double.Parse(Console.ReadLine()));

                        Console.WriteLine("Insert Target");
                        inputs.Add(int.Parse(Console.ReadLine()));

                        CalculateYears((int)inputs[0], (double)inputs[1], (double)inputs[2], (int)inputs[3]);
                        break;

                    case "cal":
                        Console.WriteLine("What Formlua?");
                        input = Console.ReadLine();
                        switch (input)
                        {
                            case "add":
                                Console.WriteLine("Formlua: a + b = c");
                                Console.WriteLine("Insert a:");
                                inputs.Add(int.Parse(Console.ReadLine()));

                                Console.WriteLine("Insert b:");
                                inputs.Add(int.Parse(Console.ReadLine()));

                                Console.WriteLine("c = " + MathFunc.Addition((int)inputs[0], (int)inputs[1]));
                                break;

                            case "sub":
                                Console.WriteLine("Formlua: a - b = c");
                                Console.WriteLine("Insert a:");
                                inputs.Add(int.Parse(Console.ReadLine()));

                                Console.WriteLine("Insert b:");
                                inputs.Add(int.Parse(Console.ReadLine()));

                                Console.WriteLine("c = " + MathFunc.Subtraction((int)inputs[0], (int)inputs[1]));
                                break;

                            case "mult":
                                Console.WriteLine("Formlua: a * b = c");
                                Console.WriteLine("Insert a:");
                                inputs.Add(int.Parse(Console.ReadLine()));

                                Console.WriteLine("Insert b:");
                                inputs.Add(int.Parse(Console.ReadLine()));

                                Console.WriteLine("c = " + MathFunc.Multiplication((int)inputs[0], (int)inputs[1]));
                                break;

                            case "div":
                                Console.WriteLine("Formlua: a / b = c");
                                Console.WriteLine("Insert a:");
                                inputs.Add(int.Parse(Console.ReadLine()));

                                Console.WriteLine("Insert b:");
                                inputs.Add(int.Parse(Console.ReadLine()));

                                Console.WriteLine("c = " + MathFunc.Division((int)inputs[0], (int)inputs[1]));
                                break;


                            case "custom":
                                break;

                            default:
                                break;
                        }
                        break;

                    case "fib":
                        Console.WriteLine("Insert A Number:");
                        inputs.Add(int.Parse(Console.ReadLine()));
                        long[] fibNums = Fibonacci((int)inputs[0]);
                        foreach (int i in fibNums)
                        {
                            Console.WriteLine(i);
                        }
                        break;

                    case "fibEven":
                        Console.WriteLine("Insert A Number:");
                        inputs.Add(int.Parse(Console.ReadLine()));
                        long[] fibEvenNums = Fibonacci((int)inputs[0], (a) => a % 2 == 0);
                        break;

                    case "clone":
                        CloningService srv = new CloningService();
                        TestClass<Random> test = new TestClass<Random>();
                        test.Char = '1';
                        test.String = "adasdasd";
                        test.Int16 = 11;
                        test.Int32 = 444;


                        var clone = srv.Clone<TestClass<Random>>(test);
                        test.Char = '2';
                        test.Int16 = 22;
                        test.Int32 = 555;

                        break;

                    case "pi":
                        Console.WriteLine("Insert A Number \nMax Is {0}", Math.PI.ToString().Length);
                        inputs.Add(int.Parse(Console.ReadLine()));

                        PiToTheNthNumber((int)inputs[1]);
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
                        inputs.Add(int.Parse(Console.ReadLine()));

                        Console.WriteLine("Insert # of Columns");
                        inputs.Add(int.Parse(Console.ReadLine()));

                        CheckerBoard((int)inputs[0], (int)inputs[1]);
                        Console.ReadLine();
                        break;

                    case "prime":
                        Console.WriteLine("Insert A Number");
                        inputs.Add(int.Parse(Console.ReadLine()));

                        IsPrimeNumber((int)inputs[0]);
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

        public static string MixedFraction(string s)
        {
            int numerator;
            int denominator;

            string[] fractionParts = s.Split('/');
            numerator = int.Parse(fractionParts[0]);
            denominator = int.Parse(fractionParts[1]);

            int wholes = numerator / denominator;
            int rest = numerator % denominator;

            string result = "";

            if (wholes > 0)
                result = wholes.ToString();

            if (rest > 0)
            {
                int a = rest,
                    b = denominator;

                while (b != 0)
                {
                    int t = b;
                    b = a % b;
                    a = t;
                }

                rest /= a;
                denominator /= a;

                result += ((wholes > 0) ? " " : "0 " ) + rest + "/" + denominator;
            }
            return result;
        }

        public static string AyIt(string str)
        {
            string[] arr = str.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                string s = arr[i].Substring(1);
                arr[i] = s + arr[i][0] + "ay";
            }

            return string.Join(" ", arr);
        }

        public static List<int> SumConsecutives(List<int> list)
        {
            List<int> result = new List<int>();
            int temp = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (i + 1 < list.Count && list[i + 1] == list[i])
                {
                    temp += list[i];
                }
                else if (i - 1 > -1 && list[i - 1] == list[i])
                {
                    temp += list[i];
                    result.Add(temp);
                    temp = 0;
                }
                else
                {
                    result.Add(list[i]);
                }
            }

            return result;
        }

        public static Tuple<int, int> NbrOfLaps(int x, int y)
        {
            int num1, num2;
            int lcm = 0;
            Tuple<int, int> result = null;

            if (x > y)
            {
                num1 = x; num2 = y;
            }
            else
            {
                num1 = y; num2 = x;
            }

            for (int i = 1; i < num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                {
                    lcm = i * num1;
                    break;
                }
            }
            if (lcm == 0) { lcm = num1 * num2; }

            result = new Tuple<int, int>(lcm / x, lcm / y);

            return result;
        }

        public static int DetermineLCM(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }

            return a;
        }

        public static string ReverseWords(string str)
        {
            string[] result = str.Split(' ');

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = string.Concat(result[i].ToCharArray().Reverse());
            }

            return string.Join(" ", result);

        }

        public static int Persistence(long n)
        {
            if (n.ToString().Length == 1) { return 0; }

            char[] arr = n.ToString().ToCharArray();
            int arrLength = arr.Length;
            bool isLowest = false;
            int result = 0;

            while (!isLowest)
            {
                int num = 0;
                for (int i = 1; i < arr.Length; i++)
                {
                    num = (int)(((i == 1) ? Char.GetNumericValue(arr[0]) : num) * Char.GetNumericValue(arr[(i == 1) ? 1 : i]));
                }
                result++;
                arr = num.ToString().ToCharArray();

                if (((Char.GetNumericValue(arr[0]) * Char.GetNumericValue(arr[1])).ToString().Length == 1 && arr.Length == 2) || num == 0)
                {
                    result++;
                    isLowest = true;
                }
            }

            return result;
        }

        public static string DuplicateEncode(string word)
        {
            word = word.ToLower();
            string result = "";
            for (int i = 0; i < word.Length; i++)
            {

                string after = (i != word.Length - 1) ? word.Substring(i + 1) : "";
                string before = word.Substring(0, i);
                if (after.Contains(word[i]) || before.Contains(word[i]))
                {
                    result += ")";
                }
                else
                {
                    result += "(";
                }
            }

            return result;
        }

        public static int[] SortArray(int[] array)
        {
            var ordered = array.Where(a => a % 2 != 0).OrderBy(a => a).ToArray();
            int[] newArray = new int[array.Length];

            for (int index = 0, orderedI = 0; index < array.Length; index++)
            {
                if (array[index] % 2 == 0)
                {
                    newArray[index] = array[index];
                }
                else
                {
                    newArray[index] = ordered[orderedI];
                    orderedI++;
                }
                index++;
            }

            return newArray;
        }

        public static long DigPow(int baseNum, int ex)
        {
            string baseNumString = baseNum.ToString();
            double returnedVal = 0;
            int result = 0;

            for (int i = 0; i < baseNumString.Length; i++)
            {
                double n = int.Parse(baseNumString[i].ToString());
                returnedVal += Math.Pow(n, ex + i); ;
            }


            while (returnedVal / result != baseNum)
            {
                if (result < returnedVal / 2) { break; }
                if (returnedVal / result != baseNum) { result++; }
            }

            return (returnedVal / result != baseNum) ? -1 : result;
        }

        public static string ToJadenCase(string phrase)
        {
            string[] splitString = phrase.Split(' ');
            List<string> list = new List<string>();

            foreach (string word in splitString)
            {
                string partical = word.Substring(1);
                char firstLetter = Char.ToUpper(word[0]);

                string newWord = String.Concat(firstLetter, partical);
                list.Add(newWord);
            }

            return String.Join(" ", list);
        }

        public static Int32 CalculateYears(double amount, double interest, double tax, double target)
        {
            var years = 0;
            while (amount < target)
            {
                amount += amount * interest * (1 - tax);
                years++;
            }
            return years;
        }

        public static long[] Fibonacci(int n, Func<long, bool> predicate = null)
        {

            long a = 2;
            long b = 1;
            List<long> list = new List<long>();
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
                if (predicate != null)
                {
                    if (predicate(b))
                    {
                        list.Add(b);
                    }
                }
                else
                {
                    list.Add(b);
                }
            }

            return list.ToArray();
        }

        public static long[] FibonacciOnlyEven(int n)
        {
            long a = 2;
            long b = 1;
            List<long> list = new List<long>();
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
                if (b % 2 == 0)
                {
                    list.Add(b);
                }
            }

            return list.ToArray();

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
