using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic matrix = new Logic(3);
            matrix.Show();
            matrix.Diagonal();
            matrix.Negative();
        }
    }
}