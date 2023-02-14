using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POKEMONXD.Pokemon
{
    internal class Machoke : POKEMON
    {
        public Machoke()
        {
            this.name = "Machoke";
            Random random = new Random();
            this.HP = random.Next(355, 525);
            this._image = Properties.Resources._067;
            this.Attack = random.Next(410, 650);
            this.Defense = random.Next(350, 550);
        }

    }
}
