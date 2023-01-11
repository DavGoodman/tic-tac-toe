namespace tic_tac_toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoardModel game = new BoardModel();
            while (true)
            {
                BoardView.Show(game);
                game.positionStr = Console.ReadLine();
                game.SetMove();
                Console.Clear();
                if(game.IsGameStopped) break;
            }

            Console.WriteLine($"Game over, winner is {game.winner}");
        }
    }
}