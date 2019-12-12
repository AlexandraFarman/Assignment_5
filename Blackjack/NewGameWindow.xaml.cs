using GameCardLib;
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

namespace Blackjack
{
    /// <summary>
    /// Interaction logic for NewGameWindow.xaml
    /// </summary>
    public partial class NewGameWindow : Window
    {
        public GameManager GameManager { get; set; }
        public (Player dealer, List<Player> players) StartingPlayers { get; set; }
        public MainWindow MainWindow { get; set; }

        public NewGameWindow(MainWindow mainWindow)
        {
            GameManager = mainWindow.GameManager;
            MainWindow = mainWindow;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nbrOfDecksStr = TxtBoxNbrOfDecks.Text;
            string nbrOfPlayersStr = TxtBoxNbrOfPlayers.Text;
            int nbrOfDecks = 0;
            int nbrOfPlayers = 0;
            int.TryParse(nbrOfDecksStr, out nbrOfDecks);
            int.TryParse(nbrOfPlayersStr, out nbrOfPlayers);

            Action toFewPlayers = () =>
            {
                MessageBox.Show("Number of players must be a positive integer");
            };

            Action toFewDecks = () =>
            {
                MessageBox.Show("Number of decks must be a positive integer");
            };

            Action badDecksToPlayersRatio = () =>
            {
                MessageBox.Show("Number of decks is to low for the number of players");
            };

            StartingPlayers = GameManager.StartGame(nbrOfPlayers, nbrOfDecks, toFewPlayers, toFewDecks, badDecksToPlayersRatio);
            if(StartingPlayers != default) this.Close();
        }
    }
}
