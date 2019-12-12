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
    /// Interaction logic for Card.xaml
    /// </summary>
    public partial class CardControl : UserControl
    {
        public CardControl(Card card)
        {
            InitializeComponent();
            if (card.FaceUp)
            {
                LblCardSuite.Content = card.Suite;
                string cardValue = card.Value.ToString();
                if (card.Value == 1)
                {
                    cardValue = "Ace";
                }
                else if (card.Value == 11)
                {
                    cardValue = "Jack";
                }
                else if (card.Value == 12)
                {
                    cardValue = "Queen";
                }
                else if (card.Value == 13)
                {
                    cardValue = "King";
                }

                LblCardValue.Content = cardValue;
            }
        }
    }
}
