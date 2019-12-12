using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLib;

namespace GameCardLib
{
    public class Card
    {
        public int Value { get; set; }
        public Suite Suite { get; set; }
        public bool FaceUp { get; set; }

        public Card(int value, Suite suite, bool faceUp)
        {
            Value = value;
            Suite = suite;
            FaceUp = faceUp;
        }
    }
}
