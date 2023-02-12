using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Pokemon.Pokemon
{
    public class machoke : Pokemons
    {
        private Bitmap _image = Properties.Resources._067;
        public machoke() { }
        public Bitmap getImage()
        {
            return _image;
        }


    }
}
