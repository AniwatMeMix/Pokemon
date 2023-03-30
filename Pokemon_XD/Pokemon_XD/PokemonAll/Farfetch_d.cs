using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_XD.PokemonAll
{
    internal class Farfetch_d : Pokemon
    {
        public Farfetch_d()
        {
            Random random = new Random();
            this.name = "Farfetch_d";
            this.HP = random.Next(340, 435);
            this._image = Properties.Resources.Farfetch_d;
            this.Attack = random.Next(90, 250);
            this.Defense = random.Next(35, 150);
        }
    }
}
