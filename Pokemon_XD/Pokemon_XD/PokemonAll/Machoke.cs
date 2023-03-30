using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_XD.PokemonAll
{
    internal class Machoke : Pokemon
    {
        public Machoke()
        {
            Random random = new Random();
            this.name = "Machoke";
            this.HP = random.Next(340, 435);
            this._image = Properties.Resources.Machoke;
            this.Attack = random.Next(110, 290);
            this.Defense = random.Next(35, 150);
        }
    }
}
