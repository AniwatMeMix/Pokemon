using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Pokemon.Pokemon
{
    public class psyduck : Pokemons
    {
        private Bitmap _image = Properties.Resources._054;
        public psyduck() { }
        public Bitmap getImage()
        {
            return _image;
        }
    }
}
