namespace fukuv0608
{
    public partial class Form1 : Form
    {
        int vx = -5;
        int vy = -5;
        string chr = "¼“ñ“ñ“ñi@OƒÖOj“ñ½ÌŞ°İ";

        public Form1()
        {


            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = -10;
            label1.Text = "¼“ñ“ñ“ñi@OƒÖOj“ñ½ÌŞ°İ";
            label1.ForeColor = Color.Red;
        }









        private void button2_Click_1(object sender, EventArgs e)
        {
            vx = 10;
            label1.Text = "ÌŞ°İ¼“ñ“ñiOƒÖO  j“ñ“ñ“ñ½";
            label1.ForeColor = Color.Green;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            //vx = Math.Abs(vx + (vx / 10));
            //vx = Math.Abs(vx - (vx / 10));
            timer1.Interval += -10;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            timer1.Interval += 10;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {





            timer1.Enabled = false;
            label1.Text = "araisoushirou";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = 10;
            }

            if (label1.Top < 0)
            {
                vy = 10;
            }

            if (label1.Left > 761)
            {
                vx = -10;
            }

            if (label1.Top > 433)
            {
                vy = -10;
                vx = Math.Abs(vx + (vx / 10));
            }

            else if (label1.Bottom > ClientSize.Width)
            {
                ;
            }


            string t = label1.Text;
            label1.Text = chr;
            chr = t;

        }
    }
}

