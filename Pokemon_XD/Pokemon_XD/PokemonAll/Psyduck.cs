using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_XD.PokemonAll
{
    internal class Psyduck : Pokemon
    {
        public Psyduck() {

            Random random = new Random();
            this.name = "Psyduck";
            this.HP = random.Next(340, 435);
            this._image = Properties.Resources.Psyduck;
            this.Attack = random.Next(150, 350);
            this.Defense = random.Next(35, 150);
        }
    }
}
