using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLib;

namespace GameCardLib
{
    public class Player
    {
        public Hand Hand { get; set; }
        public string Name { get; set; }
        public int PlayerId { get; set; }
        public PlayerState State { get; set; }

        //public bool IsThick
        //{
        //    get
        //    {
        //        return Hand.Score > 21;
        //    }
        //}
        //public bool PlayedRound { get; set; }

        public Player(string name, int id)
        {
            Name = name;
            PlayerId = id;
            Hand = new Hand();
            State = PlayerState.Ready;
        }
    }
}
