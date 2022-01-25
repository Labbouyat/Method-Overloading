using System;

namespace Method_Overloading
{
    internal class Program
    {
            public static int Add(int x, int y)
            {
            return (x + y);
            }

            public static decimal Add(decimal x, decimal y)
            {
               
                return (x + y);
            }

            public static string Add(int y, int x, bool isCheck)
            {
               var sum = x+ y;



                if (isCheck == true && sum > 5)

                {
                    return $"{sum} dollars";

                }
                else if (isCheck == true && sum == 10)

                {
                    return $" {sum} dollars";
                }
                else if (isCheck == true && sum < 1)

                {
                    return $"{sum} dollars";
                }
                else
                {
                    return sum.ToString();
                }



            }
            static void Main(string[] args)
            {
               
                var x = 30;
                var y = 75;

                var answer = Add(x, y);

                var q = 25.0m;
                var s = 15.0m;
                var decimalAnswer = Add(q, s);

                var thirdAnswer = Add(11, 5, true);

                Console.WriteLine($"int add: {answer} decimal add : {decimalAnswer}");
                Console.WriteLine(thirdAnswer);
            }

        }
    }
