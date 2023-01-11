using Microsoft.VisualBasic;

namespace tic_tac_toe
{
    partial class BoardModel
    {
        public bool XTurn = true;

        public string winner { get; set; }
        public string positionStr { get; set; }
        public bool IsGameStopped { get; private set; }
        public CellContent[] Content { get; set; }

        public BoardModel()
        {
            Content = new CellContent[9]; // values start as None by default
        }

        public void SetMove()
        {
            if (!SafetyChecks.CheckChars(positionStr)) return;
            int position = GetPosition();
            if (!SafetyChecks.CheckPosition(position, Content)) return;

            if (XTurn) Content[position] = CellContent.Cross;
            else Content[position] = CellContent.Circle;
            checkWinner();
            XTurn = !XTurn;
        }


        public int GetPosition()
        {
            var row = positionStr[0] == 'a' ? 0 : positionStr[0] == 'b' ? 1 : 2;
            var col = Convert.ToInt32(positionStr[1].ToString()) - 1;
            var position = row * 3 + col;
            return position;
        }

        public void checkWinner()
        {
            checkWinningCombination(0, 1, 2);
            if (IsGameStopped) return;
            checkWinningCombination(3, 4, 5);
            if (IsGameStopped) return;
            checkWinningCombination(6, 7, 8);
            if (IsGameStopped) return;
            checkWinningCombination(0, 3, 6);
            if (IsGameStopped) return;
            checkWinningCombination(1, 4, 7);
            if (IsGameStopped) return;
            checkWinningCombination(2, 5, 8);
            if (IsGameStopped) return;
            checkWinningCombination(0, 4, 8);
            if (IsGameStopped) return;
            checkWinningCombination(2, 4, 6);
        }

        public void checkWinningCombination(int num1, int num2, int num3)
        {
            if (new[] { Content[num1], Content[num2], Content[num3] }.All(x => x == CellContent.Cross))
            {
                IsGameStopped = true;
                winner = "X";
            }
            if (new[] { Content[num1], Content[num2], Content[num3] }.All(x => x == CellContent.Circle))
            {
                IsGameStopped = true;
                winner = "O";
            }
        }


    }
}
