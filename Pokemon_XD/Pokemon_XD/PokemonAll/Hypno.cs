using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_XD.PokemonAll
{
    internal class Hypno : Pokemon
    {
        public Hypno()
        {
            Random random = new Random();
            this.name = "Hypno";
            this.HP = random.Next(340, 435);
            this._image = Properties.Resources.Hypno;
            this.Attack = random.Next(100, 300);
            this.Defense = random.Next(35, 150);
        }
    }
}
