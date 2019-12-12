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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Blackjack.Controls
{
    /// <summary>
    /// Interaction logic for PlayerPanel.xaml
    /// </summary>
    public partial class PlayerPanel : UserControl
    {
        public Player Player;

        public PlayerPanel(Player player)
        {
            Player = player;
            InitializeComponent();

            LabelPlayerName.Content = $"Name: {player.Name}";
            if(player.PlayerId != 0)
                LabelPlayerHandScore.Content = $"Hand score: {player.Hand.Score}";

            player.Hand.Cards.ForEach(c =>
            {
                CardControl cardControl = new CardControl(c);
                PlayerCardsPanel.Children.Add(cardControl);
            });
        }
        public void UpdateContent(Player player)
        {
            Player = player;
            LabelPlayerName.Content = $"Name: {player.Name}";
            LabelPlayerHandScore.Content = $"Hand score: {player.Hand.Score}";
            PlayerCardsPanel.Children.Clear();
            player.Hand.Cards.ForEach(c =>
            {
                CardControl cardControl = new CardControl(c);
                PlayerCardsPanel.Children.Add(cardControl);
            });
        }
    }
}
