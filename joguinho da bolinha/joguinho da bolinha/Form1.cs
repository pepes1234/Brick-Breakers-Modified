using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joguinho_da_bolinha   
{
    public partial class Form1 : Form
    {
        private Bitmap bmp = null;
        private Graphics g = null;
        private World world = new World();
        private World2 world2 = new World2();
        private Particle2 particle = new Particle2();

        public Form1()
        {
            InitializeComponent();

            Particle2 p22 = new Particle2
            {
                PositionX = pictureBox1.Right / 2,
                PositionY = 1000,
                Largura = 100,
                Altura = 10,
                Dx = 500
            };

            world2.Entities2.Add(p22);

            Particle particle = new Particle
            {
                Mass = 30,
                PositionX = 50,
                PositionY = 60,
                DX = 340,
                DY = 920
            };
            world.Entities.Add(particle);

            Particle particle1 = new Particle
            {
                Mass = 120,
                PositionX = pictureBox1.Bottom / 2,
                PositionY = pictureBox1.Right / 2,
                DX = 340,
                DY = 920
            };
            world.Entities.Add(particle1);
        }
            
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
           
           
            world.Draw(g);
            world2.Draw(g);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            g.Clear(Color.White);
            Pen pen1 = new Pen(Color.Gray, 8);
             
            world.Draw(g);
            world2.Draw(g);
            pictureBox1.Refresh();
            foreach (var et in world.Entities)
            {
                if (et.PositionX > (pictureBox1.Right - (et.Mass/2)))
                {
                    et.DX *= -1;
                }

                if (et.PositionX < (pictureBox1.Left + (et.Mass/2)))
                {
                    et.DX *= -1;
                }
                if (et.PositionY > (pictureBox1.Top + (et.Mass/2)))
                {
                    et.DY *= -1;
                }
                if (et.PositionY < (pictureBox1.Bottom - (et.Mass/2)))
                { 
                    et.DY *= -1;
                }
            }
            foreach(var et in world.Entities)
            {
                foreach(var et2 in world2.Entities2)
                {
                    if (et.PositionX >= et2.PositionX && 
                        et.PositionX <= (et2.PositionX + et2.Largura) && 
                        et.PositionY >= et2.PositionY && 
                        et.PositionY <= (et2.PositionY + et2.Altura))
                    {
                        if (et.PositionX >= et2.PositionX && et.PositionX <= (et2.PositionX + et2.Largura))
                        {
                            et.DX *= -1;
                        }
                        if (et.PositionY >= et2.PositionY && et.PositionY <= (et2.PositionY + et2.Altura))
                        {
                            et.DY *= -1;
                        } 
                    }
                }
            }
            

    }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start(); 
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var et2 in world2.Entities2)
            {
                et2.PositionX = (e.Location.X - et2.Largura/2);

                if(et2.PositionX > (pictureBox1.Right-et2.Largura))
                {
                    et2.PositionX = (pictureBox1.Right - et2.Largura);
                }

                if (et2.PositionX < pictureBox1.Left)
                {
                    et2.PositionX = pictureBox1.Left;
                }
            } 
        }
    }
}
