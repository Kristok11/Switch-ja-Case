namespace Switch_ja_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kuunumber;
            Console.WriteLine("Mitu päeva on selles kuus sisesta kuu arv 1-12");
            while (!int.TryParse(Console.ReadLine(), out kuunumber))
            {
                Console.Write("Sa ei sisestanud numbri proovi uuesti");
            }
            switch (kuunumber)
            {
                case 1:
                    Console.WriteLine("31 päeva");
                    break;
                case 2:
                    Console.WriteLine("28 või 29 päeva");
                    break;
                case 3:
                    Console.WriteLine("31 päeva");
                    break;
                case 4:
                    Console.WriteLine("30 päeva");
                    break;
                case 5:
                    Console.WriteLine("31 päeva");
                    break;
                case 6:
                    Console.WriteLine("30 päeva");
                    break;
                case 7:
                    Console.WriteLine("31 päeva");
                    break;
                case 8:
                    Console.WriteLine("31 päeva");
                    break;
                case 9:
                    Console.WriteLine("30 päeva");
                    break;
                case 10:
                    Console.WriteLine("31 päeva");
                    break;
                case 11:
                    Console.WriteLine("30 päeva");
                    break;
                case 12:
                    Console.WriteLine("31 päeva");
                    break;

                default:
                    Console.WriteLine("Vale kuude arv!!!");
                    break;
            }
            Console.ReadLine();
        }
    }
}