using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix(10);
            m.PrintMatrix();
            Console.ReadKey();
        }
    }
}
