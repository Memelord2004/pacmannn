using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace itogoviyProj
{ 
 
        class Pacman
        {
        public bool CanMove = false;
        public int x = 10;
        public int y = 11;
        public static int horiz = 20, vert = 20, sq = 20;   
        public char Navigation = 'L';
        public char WantNavigation = 'N';


    public void Move()
    {
       if (WantNavigation != 'N')
        {
            if (WantNavigation == 'L' && Navigation != 'R')
            {
                Navigation = WantNavigation;
            }
            if (WantNavigation == 'R' && Navigation != 'L')
            {
                Navigation = WantNavigation;
            }
            if (WantNavigation == 'U' && Navigation != 'D')
            {
                Navigation = WantNavigation;
            }
            if (WantNavigation == 'D' && Navigation != 'U')
            {
                Navigation = WantNavigation;
            }
        }
            
                switch (Navigation)
                {
                    case 'L':
                        {
                        if (CanMove)
                        {
                            x--;
                        }
                            break;
                        }
                    case 'R':
                        {
                        if (CanMove)
                        {
                            x++;
                        }
                                break;
                        
                        }
                    case 'U':
                        {
                        if (CanMove)
                        {
                            y--;
                        }
                            break;
                        }
                    case 'D':
                        {
                        if (CanMove)
                        {
                            y++;
                        }
                            break;
                        }

                }
            
    }

    }
 
}
