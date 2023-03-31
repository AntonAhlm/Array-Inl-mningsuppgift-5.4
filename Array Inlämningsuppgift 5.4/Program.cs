using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] namn = { "Anton", "Kevin", "Theo", "Alfred", "Felix" };
            Array.Sort(namn);

            Console.WriteLine(namn[0]);
        }
    }
}
