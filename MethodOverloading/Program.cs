using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            int answer1 = Add(25, 22);
            Console.WriteLine(answer1);

            decimal answer2 = Add(5.5m, 102.35m);
            Console.WriteLine(answer2);

            string answer3 = Add(50, 12, true);
            Console.WriteLine(answer3);




        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }



        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }


        public static string Add(int num1, int num2, bool tf)
        {
            var sum = num1 + num2;

            if (tf == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (tf != true && sum <= 1)
            {
                return $"{sum} dollar";

            }
            else
            {
                return $"{sum}";
            }
        }
            


    }
}
