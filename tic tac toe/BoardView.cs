
namespace tic_tac_toe
{
    class BoardView
    {
        public static void Show(BoardModel boardModel)
        {
            char[] symbols = new char[9];

            for (int i = 0; i < boardModel.Content.Length; i++)
            {
                var cell = boardModel.Content[i];
                if (cell == CellContent.None) symbols[i] = ' ';
                else if (cell == CellContent.Circle) symbols[i] = 'O';
                else if (cell == CellContent.Cross) symbols[i] = 'X';
            }

            Console.WriteLine("  1 2 3");
            Console.WriteLine(" ┌─────┐");
            Console.WriteLine("a│{0} {1} {2}│", symbols[0], symbols[1], symbols[2]);
            Console.WriteLine("b│{0} {1} {2}│", symbols[3], symbols[4], symbols[5]);
            Console.WriteLine("c│{0} {1} {2}│", symbols[6], symbols[7], symbols[8]);
            Console.WriteLine(" └─────┘");
        }
    }
}
