using System.Windows.Forms.VisualStyles;

namespace Pokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.pictureBox1.Image = null;
            farfetch_d farfetch_D = new farfetch_d();
            this.pictureBox1.Image = farfetch_D.getImage();
            this.textBox1.Text = "Farfetch'd";
            this.textBox2.Text = "123";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            psyduck psyduck = new psyduck();
            this.pictureBox1.Image = psyduck.getImage();
            this.textBox1.Text = "Psyduck";
            this.textBox2.Text = "120";
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            machoke machoke= new machoke();
            this.pictureBox1.Image = machoke.getImage();
            this.textBox1.Text = "Machoke";
            this.textBox2.Text = "162";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hypno hypno = new hypno();
            this.pictureBox1.Image = hypno.getImage();
            this.textBox1.Text = "Hypno";
            this.textBox2.Text = "168";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "Machoke";
            this.textBox2.Text = "162";
            this.textBox3.Text = "600";
            this.textBox4.Text = "BOSS";
         
        }
    }
}