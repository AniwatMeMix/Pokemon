using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Pokemon.Pokemon
{
    public class farfetch_d : Pokemons
    {
        private Bitmap _image = Properties.Resources._083;
        public farfetch_d() { }
        public Bitmap getImage()
        {
            return _image;
        }
    }
}
