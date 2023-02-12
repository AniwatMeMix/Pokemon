using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Pokemon.Pokemon
{
    public class hypno : Pokemons
    {
        private Bitmap _image = Properties.Resources._097;
        public hypno() { }
        public Bitmap getImage()
        {
            return _image;
        }
    }
}
