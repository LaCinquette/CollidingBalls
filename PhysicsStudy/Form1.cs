using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System.Text;
using System.Windows.Forms;

namespace PhysicsStudy
{
    public partial class Form1 : Form
    {
        public Graphics g;
        public Bitmap bmp;
        public Pen pen = new Pen(Color.Black);
        public Pen Arrow = new Pen(Color.Red, 2f);
        System.Drawing.Drawing2D.AdjustableArrowCap bigArrow = new System.Drawing.Drawing2D.AdjustableArrowCap(5, 4);
        public SolidBrush CircleBrush = new SolidBrush(Color.Blue);
        public SolidBrush TextBrush = new SolidBrush(Color.Black);
        public Font TextFont = new Font("Arial", 8);
        Rectangle FrameRect = new Rectangle(0, 0, 800, 600);
        public List<PhysicCircle> circles = new List<PhysicCircle>();
        public delegate void Collision(PhysicCircle c1, PhysicCircle c2);
        Collision collision;
        int Collisions = 0;
        double ms;
        Stopwatch stopWatch1 = new Stopwatch();
        TimeSpan ts1;
        public Form1()
        {
            InitializeComponent();

            this.Text = "Упругое и неупрогое столкновение";
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            Arrow.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            Arrow.CustomEndCap = bigArrow;
            circles.Add(new PhysicCircle(10 * 8, 300, 2 * 8, 10, 10 * 8));
            circles.Add(new PhysicCircle(20 * 8, 300, 2 * 8, 10, 5 * 8));
            collision = PhysicCircle.ElasticCollision;
            ms = 14;
            DrawConstant();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            circles[0].m = Convert.ToDouble(Circle1Mass.Text);
            circles[0].r = Convert.ToDouble(Circle1Radius.Text) * 8;
            circles[0].v = Convert.ToDouble(Circle1Speed.Text) * 8;
            circles[0].x = Convert.ToDouble(Circle1Distance.Text) * 8;
            circles[1].m = Convert.ToDouble(Circle2Mass.Text);
            circles[1].r = Convert.ToDouble(Circle2Radius.Text) * 8;
            circles[1].v = Convert.ToDouble(Circle2Speed.Text) * 8;
            circles[1].x = Convert.ToDouble(Circle2Distance.Text) * 8;
            if (radioButton1.Checked)
            {
                collision = PhysicCircle.ElasticCollision;
            }
            if (radioButton2.Checked)
            {
                collision = PhysicCircle.InelasticCollision;
            }
            Collisions = 0;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!stopWatch1.IsRunning)
            {
                Draw();
                stopWatch1.Start();
            }
            else
            {
                stopWatch1.Stop();
                ts1 = stopWatch1.Elapsed;
                ms = ts1.Milliseconds;
                Draw();
                stopWatch1.Restart();
            }
        }

        public void Draw()
        {
            pictureBox1.Image = null;

            g.Clear(Color.White);
            g.DrawRectangle(pen, FrameRect);
            g.DrawLine(pen, 0, 300, 800, 300);

            for (int i = 1; i < 20; i++)
            {
                g.DrawLine(pen, i * 40, 295, i * 40, 305);
                g.DrawString($"{(i * 5).ToString()}м", TextFont, TextBrush, i * 40 - 10, 307);
            }
            this.NextTick();
            for (int i = 0; i < circles.Count(); i++)
            {
                circles[i].Next(ms);
                g.FillEllipse(CircleBrush, (int)(circles[i].x - circles[i].r), (int)(circles[i].y - circles[i].r), (int)(2 * circles[i].r), (int)(2 * circles[i].r));
            }
            for (int i = 0; i < circles.Count(); i++)
            {
                g.DrawLine(Arrow, (float)circles[i].x, (float)circles[i].y, (float)(circles[i].x + circles[i].m * circles[i].v / 8), (float)circles[i].y);
                string Impulse = $"{circles[i].m * circles[i].v / 8}кг*м/с";
                g.DrawString(Impulse, TextFont, TextBrush, (float)(circles[i].x - (Impulse.Length) * TextFont.Size / 2.8), (float)(circles[i].y - circles[i].r - 20));
            }

            g.DrawString($"{(circles[0].v / 8).ToString()}м/с", TextFont, TextBrush, 100, 500);
            g.DrawString($"{(circles[1].v / 8).ToString()}м/с", TextFont, TextBrush, 650, 500);
            g.DrawString($"{Collisions.ToString()} ударов", TextFont, TextBrush, 400, 500);
            g.DrawString($"{ms.ToString()}ms", TextFont, TextBrush, 10, 20);

            pictureBox1.Image = bmp;
        }
        public void DrawConstant()
        {
            pictureBox1.Image = null;

            g.Clear(Color.White);
            g.DrawRectangle(pen, FrameRect);
            g.DrawLine(pen, 0, 300, 800, 300);

            for (int i = 1; i < 20; i++)
            {
                g.DrawLine(pen, i * 40, 295, i * 40, 305);
                g.DrawString($"{(i * 5).ToString()}м", TextFont, TextBrush, i * 40 - 10, 307);
            }
            for (int i = 0; i < circles.Count(); i++)
            {
                g.FillEllipse(CircleBrush, (int)(circles[i].x - circles[i].r), (int)(circles[i].y - circles[i].r), (int)(2 * circles[i].r), (int)(2 * circles[i].r));
            }
            for (int i = 0; i < circles.Count(); i++)
            {
                g.DrawLine(Arrow, (float)circles[i].x, (float)circles[i].y, (float)(circles[i].x + circles[i].m * circles[i].v / 8), (float)circles[i].y);
                string Impulse = $"{circles[i].m * circles[i].v / 8}кг*м/с";
                g.DrawString(Impulse, TextFont, TextBrush, (float)(circles[i].x - (Impulse.Length) * TextFont.Size / 2.8), (float)(circles[i].y - circles[i].r - 20));
            }

            g.DrawString($"{(circles[0].v / 8).ToString()}м/с", TextFont, TextBrush, 100, 500);
            g.DrawString($"{(circles[1].v / 8).ToString()}м/с", TextFont, TextBrush, 650, 500);
            g.DrawString($"{Collisions.ToString()} ударов", TextFont, TextBrush, 400, 500);
            g.DrawString($"{ms.ToString()}ms", TextFont, TextBrush, 10, 20);

            pictureBox1.Image = bmp;
        }
        public void NextTick()
        {
            if (circles[0].x < 0)
            {
                circles[0].x = 2 + circles[0].r;
                circles[0].v = -(circles[0].v);
            }
            else if (circles[0].x > 800)
            {
                circles[0].x = 799 - circles[0].r;
                circles[0].v = -(circles[0].v);
            }

            if (circles[1].x < 0)
            {
                circles[1].x = 2 + circles[1].r;
                circles[1].v = -(circles[1].v);
            }
            else if (circles[1].x > 800)
            {
                circles[1].x = 799 - circles[1].r;
                circles[1].v = -(circles[1].v);
            }

            if (PhysicCircle.Distance(circles[0], circles[1]) < (circles[0].r + circles[1].r))
            {
                collision(circles[0], circles[1]);
                circles[0].x = (circles[0].x + circles[1].x) / 2 - (circles[0].r + circles[1].r) / 2;
                circles[1].x = (circles[0].x + circles[1].x) / 2 + (circles[0].r + circles[1].r) / 2;
                Collisions++;
            }
            else if (circles[0].x > circles[1].x)
            {
                double temp_x = circles[0].x;
                circles[0].x = circles[1].x;
                circles[1].x = temp_x;
            }
            for (int i = 0; i < circles.Count(); i++)
            {
                if ((circles[i].x - circles[i].r <= 1) || (circles[i].x + circles[i].r >= 800))
                {
                    if (collision == PhysicCircle.InelasticCollision)
                    {
                        if (Collisions > 0)
                        {
                            foreach (PhysicCircle c in circles)
                            {
                                c.v = -(c.v);
                            }
                        }
                        else
                        {
                            circles[i].v = -(circles[i].v);
                            if (circles[i].x - circles[i].r <= 1)
                            {
                                circles[i].x = 2 + circles[i].r;
                            }
                            else
                            {
                                circles[i].x = 799 - circles[i].r;
                            }
                        }
                    }
                    else
                    {
                        circles[i].v = -(circles[i].v);
                        if (circles[i].x - circles[i].r <= 1)
                        {
                            circles[i].x = 2 + circles[i].r;
                        }
                        else
                        {
                            circles[i].x = 799 - circles[i].r;
                        }
                    }
                }
            }
        }
        public class PhysicCircle
        {
            public double x, y;
            public double r;
            public double m;
            public double v;
            public PhysicCircle(double x, double y, double r, double m, double v)
            {
                this.x = x;
                this.y = y;
                this.r = r;
                this.m = m;
                this.v = v;
            }
            public void Next(double ms)
            {
                x += v / 1000 * ms;
            }
            public static double Distance(PhysicCircle c1, PhysicCircle c2)
            {
                return Math.Sqrt((c1.x - c2.x) * (c1.x - c2.x) + (c1.y - c2.y) * (c1.y - c2.y));
            }
            public static void ElasticCollision(PhysicCircle c1, PhysicCircle c2)
            {
                double c1v_temp = ((c1.m - c2.m) * c1.v + 2 * c2.m * c2.v) / (c1.m + c2.m);
                double c2v_temp = ((c2.m - c1.m) * c2.v + 2 * c1.m * c1.v) / (c1.m + c2.m);
                c1.v = c1v_temp;
                c2.v = c2v_temp;
            }
            public static void InelasticCollision(PhysicCircle c1, PhysicCircle c2)
            {
                c1.v = (c1.m * c1.v + c2.m * c2.v) / (c1.m + c2.m);
                c2.v = c1.v;
            }
        }

        private void Circle1Radius_Leave(object sender, EventArgs e)
        {
            TextLeave();
        }

        private void Circle2Radius_Leave(object sender, EventArgs e)
        {
            TextLeave();
        }

        private void Circle1Mass_Leave(object sender, EventArgs e)
        {
            TextLeave();
        }

        private void Circle2Mass_Leave(object sender, EventArgs e)
        {
            TextLeave();
        }

        private void Circle1Speed_Leave(object sender, EventArgs e)
        {
            TextLeave();
        }

        private void Circle2Speed_Leave(object sender, EventArgs e)
        {
            TextLeave();
        }

        private void Circle1Distance_Leave(object sender, EventArgs e)
        {
            TextLeave();
        }

        private void Circle2Distance_Leave(object sender, EventArgs e)
        {
            TextLeave();
        }
        public void TextLeave()
        {
            timer1.Enabled = false;
            circles[0].m = Convert.ToDouble(Circle1Mass.Text);
            circles[0].r = Convert.ToDouble(Circle1Radius.Text) * 8;
            circles[0].v = Convert.ToDouble(Circle1Speed.Text) * 8;
            circles[0].x = Convert.ToDouble(Circle1Distance.Text) * 8;
            circles[1].m = Convert.ToDouble(Circle2Mass.Text);
            circles[1].r = Convert.ToDouble(Circle2Radius.Text) * 8;
            circles[1].v = Convert.ToDouble(Circle2Speed.Text) * 8;
            circles[1].x = Convert.ToDouble(Circle2Distance.Text) * 8;
            if (radioButton1.Checked)
            {
                collision = PhysicCircle.ElasticCollision;
            }
            if (radioButton2.Checked)
            {
                collision = PhysicCircle.InelasticCollision;
            }
            Collisions = 0;
            DrawConstant();
        }
    }
}
