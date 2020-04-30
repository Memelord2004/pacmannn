using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace itogoviyProj
{

    public partial class Form1 : Form
    {
        public static int horiz = 20, vert = 20, sq = 20;
        public Graphics g;
        public bool CanMove = false;
        Field field = new Field(horiz, vert);
        Pacman pacman = new Pacman();
        public SolidBrush Pac = new SolidBrush(Color.Yellow);
        public int count;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            {
                switch (e.KeyCode.ToString())
                {
                    case "W":
                        {
                            pacman.WantNavigation = 'U';
                            break;
                        }
                    case "A":
                        {
                            pacman.WantNavigation = 'L';
                            break;
                        }
                    case "D":
                        {
                            pacman.WantNavigation = 'R';
                            break;
                        }

                    case "S":
                        {
                            pacman.WantNavigation = 'D';
                            break;
                        }

                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            Graphics g = Graphics.FromImage(field.getFieldNow());
            g.Clear(Color.White);
            pacman.Move();
            field.Matrix[pacman.y, pacman.x] = 2;
            
            pictureBox1.Image = field.getFieldNow();
            field.Matrix[pacman.y, pacman.x] = 0;
            count++;
            label1.Text = count.ToString();
            pacman.CanMove = true;
            if ((pacman.Navigation =='U') &&(field.Matrix[pacman.y -1,pacman.x] !=0))
            {
                pacman.CanMove = false;
            }
            if ((pacman.Navigation == 'D') && (field.Matrix[pacman.y +1, pacman.x] != 0))
            {
                pacman.CanMove = false;
            }
            if ((pacman.Navigation == 'L') && (field.Matrix[pacman.y , pacman.x-1] != 0))
            {
                pacman.CanMove = false;
            }
            if ((pacman.Navigation == 'R') && (field.Matrix[pacman.y , pacman.x+1] != 0))
            {
                pacman.CanMove = false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 180;
            timer1.Enabled = true;
            File.AppendAllText("a.txt", count.ToString());
        }
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }
    }
}


