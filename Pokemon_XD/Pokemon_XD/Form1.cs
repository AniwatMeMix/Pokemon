using Pokemon_XD.PokemonAll;

namespace Pokemon_XD
{
    public partial class Form1 : Form
    {
        List<Pokemon> pokemons;
        Pokemon selectedPokemon;
        Pokemon monster;

        public Form1()
        {
            InitializeComponent();
            pokemons = new List<Pokemon>();
            pokemons.Add(new Machoke());
            pokemons.Add(new Hypno());
            pokemons.Add(new Psyduck());
            pokemons.Add(new Farfetch_d());

            this.monster = new Golem();
            this.pictureBox2.Image = this.monster.getImage();
            this.textBox3.Text = this.monster.getName();
            this.textBox4.Text = this.monster.getHP().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.labelEND.Text = null;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0)
            {
                this.pictureBox1.Image = null;
                this.textBox1.Text = "ตายแล้ว";
                this.textBox2.Text = "0";
                this.selectedPokemon.getAttack();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0)
            {
                this.pictureBox1.Image = null;
                this.textBox1.Text = "ตายแล้ว";
                this.textBox2.Text = "0";
                this.selectedPokemon.getAttack();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0)
            {
                this.pictureBox1.Image = null;
                this.textBox1.Text = "ตายแล้ว";
                this.textBox2.Text = "0";
                this.selectedPokemon.getAttack();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0)
            {
                this.pictureBox1.Image = null;
                this.textBox1.Text = "ตายแล้ว";
                this.textBox2.Text = "0";
                this.selectedPokemon.getAttack();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int damage = this.selectedPokemon.getAttack() - this.monster.getDefense();
            int reflectDamage = this.monster.getAttack() - this.selectedPokemon.getDefense();
            if (damage >= 0 && reflectDamage >= 0)
            {
                this.textBox2.Text = this.selectedPokemon.takeDamage(damage).ToString();
                this.textBox4.Text = this.monster.takeDamage(reflectDamage).ToString();
            }
            if (this.monster.getHP() <= 0)
            {
                this.labelEND.Text = "YOU WIN";
                this.pictureBox2.Image = null;
            }
            else if (this.selectedPokemon.getHP() <= 0)
            {
                this.pictureBox1.Image = null;
                this.textBox1.Text = "ตายแล้ว";
                this.textBox2.Text = "0";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.selectedPokemon.getHP() > 0)
            {
                int getHeal = this.selectedPokemon.getHP() + 50;
                this.textBox2.Text = getHeal.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int getDefense = this.selectedPokemon.getDefense() + 50;
        }

        private void buttonEND_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}