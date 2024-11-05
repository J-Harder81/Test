using System;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 8;
            string s = "hi";
            bool b = false;
            char c = 'a';
            Console.WriteLine(b + s);
            Console.WriteLine((b + s).GetType());
            Console.WriteLine(c + c);
            Console.WriteLine((c + c).GetType());
            Console.WriteLine(c + i);
            Console.WriteLine((c + i).GetType());
            Console.WriteLine(c + s);
            Console.WriteLine((c + s).GetType());
            Console.WriteLine(i + c);
            Console.WriteLine((i + c).GetType());
            Console.WriteLine(i + i);
            Console.WriteLine((i + i).GetType());
            Console.WriteLine(i + s);
            Console.WriteLine((i + s).GetType());
            Console.WriteLine(s + b);
            Console.WriteLine((s + b).GetType());
            Console.WriteLine(s + c);
            Console.WriteLine((s + c).GetType());
            Console.WriteLine(s + i);
            Console.WriteLine((s + i).GetType());
            Console.WriteLine(s + s);
            Console.WriteLine((s + s).GetType());

            char x = 'b';
            Console.WriteLine(x);
            x = (char) (x + 1);
            Console.WriteLine(x);
            x++;
            Console.WriteLine(x);
        }
    }
}
