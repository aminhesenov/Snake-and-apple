using System.Media;

namespace snake_and_apple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int xal, sur, dx, dy, vaxt;
        bool bitdi;
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        SoundPlayer sp1= new SoundPlayer("H:\\C#\\img\\explosion.wav");
        SoundPlayer sp2 = new SoundPlayer("H:\\C#\\img\\eat.wav");
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && bitdi)
            {
                Yeni();
            }
            if(e.KeyCode == Keys.Left)
            {
                dx = -1;
                dy = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                dx = 1;
                dy = 0;
            }
            if (e.KeyCode == Keys.Up)
            {
                dx = 0;
                dy = -1;
            }
            if (e.KeyCode == Keys.Down)
            {
                dx = 0;
                dy = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            Yeni();
        }
        void Yeni()
        {
            xal = 0;
            sur = 3;
            dx = 0;
            dy = 0;
            bitdi = false;
            picSnake.Left = 250;
            picSnake.Top = 320;

            picBomb.Visible = false;
            picApple.Visible = true;
            Yerlesdir(picApple);
            vaxt = 0;

            timer1.Start();
        }
        void Yerlesdir(PictureBox p)
        {
            p.Left = r.Next(0, ClientSize.Width - p.Width);
            p.Top = r.Next(40, ClientSize.Height - p.Height);
       
        }

        void Novbeti()
        {
            vaxt = 0;
            if (r.Next(2) == 0)
            {
                picApple.Visible = true;
                picBomb.Visible = false ;
                Yerlesdir(picApple);
            }
            else
            {
                picApple.Visible = false;
                picBomb.Visible = true;
                Yerlesdir(picBomb);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picSnake.Left += dx*sur;
            picSnake.Top += dy*sur;

            vaxt++;
            if (vaxt >= 200)
            {
                Novbeti();

            }

            if (picSnake.Bounds.IntersectsWith(picApple.Bounds))
            {
                sp2.Play();
                xal++;
                sur++;
                Yerlesdir(picApple);

                Novbeti();
            }
            if(picBomb.Visible && picSnake.Bounds.IntersectsWith(picBomb.Bounds))
            {
                sp1.Play();
                timer1.Stop();
                bitdi=true;
                MessageBox.Show("Oyun bitdi! Xal: " + xal);
            }
        }
    }
}
