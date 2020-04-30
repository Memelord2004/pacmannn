using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itogoviyProj
{
    class Field 
    {

        public int[,] Matrix = new int[20, 20]  {
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,-1},
            {1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,1,-1},
            {1,0,1,1,1,1,0,0,0,0,0,0,0,1,1,1,1,0,1,-1},
            {1,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,1,-1},
            {1,0,0,0,1,0,0,1,0,0,0,1,0,0,1,0,0,0,1,-1},
            {1,0,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,0,1,-1},
            {1,1,0,0,1,1,1,1,0,0,0,1,1,1,1,0,0,1,1,-1},
            {1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,-1},
            {1,1,0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,1,1,-1},
            {1,1,0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,1,1,-1},
            {1,1,0,1,0,0,0,0,1,1,1,0,0,0,0,1,0,1,1,-1},
            {1,1,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,1,1,-1},
            {1,1,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,1,1,-1},
            {1,0,0,1,0,0,1,1,1,1,1,1,1,0,0,1,0,0,1,-1},
            {1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,1,-1},
            {1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,1,-1},
            {1,1,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,1,1,-1},
            {1,0,0,0,0,0,1,1,1,1,1,1,1,0,0,0,0,0,1,-1},
            {1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,1,-1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,-1} };

        public Bitmap bitmap;
        public Graphics g;
        public Pen line = new Pen(Color.Black, 1);
        public SolidBrush drawfield = new SolidBrush(Color.CadetBlue);
        public SolidBrush Pac = new SolidBrush(Color.Yellow);
        
        public int horiz = 20, vert = 20, sq = 20;


        public Field(int horiz, int vert) 
        {

            bitmap = new Bitmap(horiz*20, vert*20);
            g = Graphics.FromImage(bitmap);

        }

        public Bitmap getFieldNow()
        {
            for(int i = 0; i < vert; i++)
            {
                for (int j = 0; j < horiz; j++)
                {
                    if(Matrix[j, i] == 1)
                    {
                        g.FillRectangle(drawfield, i * sq, j * sq, sq, sq);
                    }
                    if (Matrix[j, i] == 2)
                    {
                        g.FillRectangle(Pac, i * horiz, j * vert, horiz, horiz);
                    }

                    if (Matrix[j, i] == 0)
                    {
                        g.DrawRectangle(line, i * sq, j * sq, sq, sq);
                        
                    }

                }
            }


            return bitmap;
        }

    }
}
