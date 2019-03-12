﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z_BUFFER
{
    class MoveTo
    {
        public static void MoveToX(float k, PictureBox BOX)
        {
            float[,] X = new float[4, 4] {
                                         {1,0,0,0},
                                         {0,1,0,0},
                                         {0,0,1,0},
                                         {k,0,0,1}
                                         };
            Form1.Multiply(X);
            Form1.GoToScreen();
            Form1.ColorLetter(BOX);
        }
        public static void MoveToY(float k, PictureBox BOX)
        {
            float[,] Y = new float[4, 4] {
                                         {1,0,0,0},
                                         {0,1,0,0},
                                         {0,0,1,0},
                                         {0,k,0,1}
                                         };

            Form1.Multiply(Y);
            Form1.GoToScreen();
            Form1.ColorLetter(BOX);
        }
        public static void MoveToZ(float k, PictureBox BOX)
        {
            float[,] Z = new float[4, 4] {
                                         {1,0,0,0},
                                         {0,1,0,0},
                                         {0,0,1,0},
                                         {0,0,k,1}
                                         };

            Form1.Multiply(Z);
            Form1.GoToScreen();
            Form1.ColorLetter(BOX);
        }
    }
}
