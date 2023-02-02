using System.Drawing;

namespace TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sisesta kujund (kaks korda): ");
            Console.WriteLine("1. Ruut");
            Console.WriteLine("2. Teemant");
            Console.WriteLine("3. Ristkülik");
            Console.WriteLine("4. Kolmnurk");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string tehe = Console.ReadLine();

            switch (tehe)
            {
                case "1":
                    Square();
                    break;
                case "2":
                    Diamond();
                    break;
                case "3":
                    Rectangle();
                    break;
                case "4":
                    Triangle();
                    break;
                default:
                    Console.WriteLine("Valikut ei tehtud");
                    break;
            }
        }


        private static void Square()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Ruut");
            Console.WriteLine(number);
            Console.WriteLine("Nüüd sisesta, kui suur ruut sa tahad?");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int row = 1; row <= size; row++)
            {
                for (int column = 1; column <= size; column++)
                {
                    string mark;
                    if (row == column || row + column <= size + 1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }

        private static void Triangle()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Kolmnurk");
            Console.WriteLine(number);
            Console.WriteLine("Nüüd sisesta, kui suur kolmnurk sa tahad? ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int spc = rows + 4 - 1;

            for (int i = 1; i <= rows; i++)
            {
                Console.Write("\n");
                for (int k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                spc--;
            }
        }
        private static void Diamond()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Teemant");
            Console.WriteLine(number);
            Console.WriteLine("Nüüd sisesta, kui suur teemant sa tahad? ");
            int row = Convert.ToInt32(Console.ReadLine());
            int j;

            for (int i = 0; i <= row; i++)
            {
                for (j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (int i = row - 1; i >= 1; i--)
            {
                for (j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

        }
        private static void Rectangle()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Ristkülik");
            Console.WriteLine(number);
            Console.WriteLine("Nüüd sisesta, kui suur ristkülik sa tahad? ");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int row = 1; row < size; row++)
            {
                for (int column = 4; column <= size; column++)
                {
                    string mark;
                    if (row == column || row + column < size + 1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }
    }
}