namespace HARaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Без маски, без перчатки не выходить!");
            Console.WriteLine("Задание 1");
            Console.WriteLine();

            Game game = new Game();
            game.Start();
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Задание 2");
            Console.WriteLine();
            Game1 game1 = new Game1(6);
            while (game1.playersTurn())
            {

            }
        }
    }
}