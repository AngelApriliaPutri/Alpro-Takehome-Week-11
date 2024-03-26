internal class Program
{
    static void win()
    {
        Console.WriteLine("YOU WIN!!");
    }
    static void lose()
    {
        Console.WriteLine("YOU LOSE!!");
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Input kata : ");
        string input = Console.ReadLine();
        List<char> guess = new List<char> (input.ToList<char>());
        char[] hastag = new char[100];
        int nyawa = 3;
        int p = 0;
        int selesai = 0;
        int b = 0;
        Console.Clear();
        Console.WriteLine("Guess the word!");
        Console.WriteLine("Nyawa : ♥♥♥");
        for (int i = 0; i < input.Length; i++)
        {
            hastag[i] = '#';
            Console.Write(hastag[i]);
        }
        
        while (p == 0 )
        {
            Console.WriteLine();
            b = 0;
            Console.WriteLine("Guess : ");
            char guess2 = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < input.Length; i++)
            {
                if (guess2 == input[i])
                {
                    hastag[i] = Convert.ToChar(Convert.ToString(guess2).ToUpper());
                    selesai = selesai + 1;
                    b= b - 1; 
                }
            }
            if ((b >= 0) && (b==0))
            {
                Console.WriteLine(Convert.ToString(guess2).ToUpper() + " Tidak ditemukan");
                nyawa = nyawa - 1;
                Console.Write("Nyawa = ");
                    for (int k = 0; k < nyawa; k++)
                    {
                        Console.Write('♥');
                    }
            }
            else if (b < 0)
            {
                Console.WriteLine(Convert.ToString(guess2).ToUpper() + " Ditemukan");
                b = 0;
            }
            Console.WriteLine();
            Console.WriteLine(hastag);
            if (selesai == input.Length)
            {
                p = 1 ;
                Console.WriteLine("The Word is " + input.ToUpper());
                win();
            }
            else if (nyawa == 0)
            {
                lose();
                p = 1;
            }

        }
    }
}