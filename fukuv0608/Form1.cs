using Microsoft.VisualBasic.Devices;
using System.Diagnostics.Eventing.Reader;

namespace fukuv0608
{
    public partial class Form1 : Form
    {
        int vx = rand.Next(-100,101);
        int vy = rand.Next(-100,101);
        string chr = "������i�@�O�ցO�j���ް�";
        int iTime = 0;
        static Random rand=new Random();

        public Form1()
        {


            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = -5;
            label1.Text = "������i�@�O�ցO�j���ް�";
            label1.ForeColor = Color.Red;
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            vx = 5;
            label1.Text = "�ް݁����i�O�ցO  �j����";
            label1.ForeColor = Color.Green;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            //vx = Math.Abs(vx + (vx / 10));
            //vx = Math.Abs(vx - (vx / 10));
            timer1.Interval += -5;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            timer1.Interval += 15;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            string t = label1.Text;
            label1.Text = chr;
            chr = t;

            timer1.Enabled = false;
            label1.Text = "araisoushirou";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            iTime++;
            label4.Text = $"{iTime}";

            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = 5;
            }

            if (label1.Top < 0)
            {
                vy = 5;
            }

            if (label1.Left > 761)
            {
                vx = -5;
            }

            if (label1.Top > 433)
            {

                vy = -5;
            }

            Text = $"{MousePosition.X},{MousePosition.Y}";

            var fpos = PointToClient(MousePosition);
            label1.Text = $"{fpos.X},{fpos.Y}";
            label2.Left = fpos.X;
            label2.Top = fpos.Y;
            label2.Left = fpos.X - label2.Width / 2;
            label2.Top = fpos.Y - label2.Height / 2;

            //�����蔻��
            if ((fpos.X > label1.Left) && (fpos.X < label1.Right) && (fpos.Y > label1.Top) && (fpos.Y < label1.Bottom))
            {
                timer1.Enabled = false;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
           



        }



        // �ϐ�mpos��錾���āA�}�E�X�̃t�H�[�����W�����o��
        //// 1. MousePosition�Ƀ}�E�X���W�̃X�N���[�����ォ���X�AY�������Ă���

        //label1.Text = $"{MousePosition.X},{MousePosition.Y}";


        //// 2. �ϐ�fpos��錾���āAPointToClient()�ŃX�N���[�����W���t�H�[�����W�ɕϊ�
        // var fpos = PointToClient(MousePosition);


        // ���x���ɍ��W��\��
        //// �ϊ������t�H�[�����W�́Afpos.X�Afpos.Y�Ŏ��o����
        //label1.Text = $"{fpos.X},{fpos.Y}";


    }
}


