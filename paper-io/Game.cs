using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_io
{
    class Game
    {
        Player[,] field;
        Player[] players;

        public delegate void GetKeyUpPlayer (Game game, Player player);
        public event GetKeyUpPlayer GetKeyUp;

        public void Run()
        {
            ///Здесь должен быть бесконечный цикл опрашивающий всех игроков, 
            ///когда произойдет опрос не бота, 
            ///должно сгенерироваться событие GetKeyUp
        }
    }
}
