using System;

namespace Triangle
{
    public class Program
    {
        public static bool CheckArgs(ref string[] args)
        {
            foreach (string temp in args)
            {
                try
                {
                    Convert.ToInt32(temp);
                }
                catch { return false; }
            }
            return true;
        }

        public static string CheckTriangle(ref string[] args)
        {
            bool flag = CheckArgs(ref args);
            if (flag && (args.Length == 3))
            {
                int a = Convert.ToInt32(args[0]);
                int b = Convert.ToInt32(args[1]);
                int c = Convert.ToInt32(args[2]);
                if ((a + b > c) && (b + c > a) && (a + c > b))
                {
                    if (a == b && b == c) { return "Равносторонний"; }
                    else if (a == b || a == c || b == c) { return "Равнобедренный"; }
                    else { return "Обычный"; }
                }
                else
                {
                    return "Не Треугольник";
                }
            }
            else
            {
                if (flag) { return "Не Треугольник"; }
                else { return "Неизвестная ошибка"; }
            }
        }

        static void Main(string[] args)
        {
            string answer = CheckTriangle(ref args);
            Console.WriteLine(answer);
        }
    }
}
