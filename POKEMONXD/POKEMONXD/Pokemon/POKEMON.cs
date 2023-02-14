using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POKEMONXD.Pokemon
{
    internal class POKEMON
    {
        protected string name;
        protected int HP;
        protected int Attack;
        protected int Defense;
        protected int Speed;
        protected Bitmap _image;
        public Bitmap getImage()
        {
            return _image;
        }
        public string getName() { return name; }
        public int getHP()
        {
            return HP;
            if (this.HP <= 0)
            {
                MessageBox.Show("Your Pokemons HP");
            }
        }
        public int getAttack() { return Attack; }
        public int getDefense() { return Defense; }
        public void takeDamage(int atk)
        {
            int damage;
            if (this.Defense > atk)
            {
                damage = 10;
            }
            else
            {
                damage = atk - this.Defense;
            }
            this.HP = this.HP - damage;
        }
        public int getHealth()
        {
            return this.HP + 50;
        }
        public int getDef()
        {
            return this.Defense + 50;
        }
    }
}
