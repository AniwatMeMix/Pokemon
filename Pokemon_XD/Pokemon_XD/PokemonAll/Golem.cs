using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_XD.PokemonAll
{
    internal class Golem : Pokemon
    {
        public Golem()
        { 
            Random random = new Random();
            this.name = "Golem";
            this.HP = random.Next(2000, 3000);
            this._image = Properties.Resources.Golem;
            this.Attack = random.Next(166, 307);
            this.Defense = random.Next(76,197);
        
        }
       
    }
}
