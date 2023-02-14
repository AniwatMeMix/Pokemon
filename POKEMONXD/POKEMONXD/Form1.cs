using POKEMONXD.Pokemon;

namespace POKEMONXD
{
    public partial class Form1 : Form
    {
        List<POKEMON> Pokemon;
        POKEMON selectedPokemon;
        POKEMON monster;
        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
            Pokemon = new List<POKEMON>();
            Pokemon.Add(new Machoke());
            Pokemon.Add(new farfetch_d());
            Pokemon.Add(new Magikarp());
            Pokemon.Add(new Hypno());


            this.monster = new Psyduck();
            this.pictureBox2.Image = this.monster.getImage();
            this.textBox4.Text = this.monster.getName();
            this.textBox3.Text = this.monster.getHP().ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = Pokemon[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = selectedPokemon.getHP().ToString();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = Pokemon[1];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = selectedPokemon.getHP().ToString();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = Pokemon[2];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = selectedPokemon.getHP().ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void button4_Click(object sender, EventArgs e)
        {
            selectedPokemon = Pokemon[3];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = selectedPokemon.getHP().ToString();
        }

        public void button5_Click(object sender, EventArgs e)
        {
            int atk = Math.Abs(this.monster.getDefense() - this.selectedPokemon.getAttack());
            this.monster.takeDamage(atk);
            this.textBox3.Text = monster.getHP().ToString();
            if (monster.getHP() <= 0)
            {
                MessageBox.Show("YOU WIN");
                Application.Exit();
            }
        }
    }
    
}
