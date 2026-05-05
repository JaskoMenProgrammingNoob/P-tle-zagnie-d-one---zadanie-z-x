using System.Runtime.CompilerServices;

class program
{
    static void Main(string[] args)
    {


        for (int i = 1; i <= 20; i++)
        {


            for (int j = 1; j <= 20; j++)
            {
                
                if (i == 1 || i == 20)
                {
                    Console.Write("X");
                }
                else if (j == 1 || j == 20)
                {
                    Console.Write("X");
                }
                else
                {

                    Console.Write(" ");

                }
            }
            Console.WriteLine();
        }
    }
}








