using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace paper_io
{
    /// <summary>
    /// Логика взаимодействия для Room.xaml
    /// </summary>
    public partial class Room : Window
    {
        Game game;
        Key LastKeyUp = Key.None;
        public Room()
        {
            InitializeComponent();
            game = new Game();
            game.GetKeyUp += Game_GetKeyUp;
        }


        private void Game_GetKeyUp(Game game, Player player)
        {
            switch (LastKeyUp)
            {
                case Key.Up: player.Direction = Player.Diretion.Up; break;
                case Key.Right: player.Direction = Player.Diretion.Right; break;
                case Key.Down: player.Direction = Player.Diretion.Down; break;
                case Key.Left: player.Direction = Player.Diretion.Left; break;
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            room.Content = e.Key.ToString();
            LastKeyUp = e.Key;
        }
    }
}
