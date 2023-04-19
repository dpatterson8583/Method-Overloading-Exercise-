namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer1 = Add(2, 3);
            Console.WriteLine(answer1);

            var answer2 = Add(232445m, .284m);
            Console.WriteLine(answer2);

            var answer3 = Add(10, 100, true);
            Console.WriteLine(answer3);
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal  x, decimal y) 
        {
            return x + y;
        }

        public static string Add(int x, int y, bool isTrue)
        {
            if (isTrue) 
            { 
                if(x+y==1)
                {
                    return "1 dollar ";
                }
                else
                {
                    return Convert.ToString(x + y) + " dollars";

                }

            }
            else 
            {
                return Convert.ToString(x + y);
            }
        }

    }
}
