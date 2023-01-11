using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    class SafetyChecks
    {
        public CellContent[] Content { get; set; }
        public static bool CheckChars(string positionStr)
        {
            if (positionStr.Length != 2 ||
                !new[] { 'a', 'b', 'c' }.Contains(positionStr[0]) ||
                !new[] { '1', '2', '3' }.Contains(positionStr[1]))
            {
                Console.WriteLine("write a valid cell");
                return false;
            }
            return true;
        }

        public static bool CheckPosition(int position, CellContent[] content)
        {
            if (content[position] != CellContent.None)
            {
                Console.WriteLine("That cell is already taken, please choose another one");
                return false;
            }

            return true;
        }
        
    }
}
