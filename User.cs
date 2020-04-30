using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itogoviyProj
{
    class User : Field
    {

        public User(int horiz, int vert) : base(horiz, vert)
        {
           Field field = new Field(horiz, vert);
           bitmap = new Bitmap(horiz, vert);
           g = Graphics.FromImage(bitmap);
        }
    }
}
