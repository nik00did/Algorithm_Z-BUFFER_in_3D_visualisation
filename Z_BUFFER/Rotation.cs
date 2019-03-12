using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z_BUFFER
{
    class Rotation
    {

        public static void RotationX(float[,] m, float angle, PictureBox BOX)
        {
            float[,] X = new float[4, 4] {
                                          {1,         0               ,         0            ,0},
                                          {0,   (float)Math.Cos(angle),(float)Math.Sin(angle),0},
                                          {0,(float)-Math.Sin(angle)  ,(float)Math.Cos(angle),0},
                                          {0,         0               ,         0            ,1}
                                          };
            Form1.Multiply(X);
            Form1.GoToScreen();
            Form1.ColorLetter(BOX);
        }
        public static void RotationY(float[,] m, float angle, PictureBox BOX)
        {
            float[,] Y = new float[4, 4] {
                                         {(float)Math.Cos(angle),0,(float)-Math.Sin(angle),0},
                                         {         0            ,1,           0           ,0},
                                         {(float)Math.Sin(angle),0,(float)Math.Cos(angle) ,0},
                                         {         0            ,0,           0           ,1}
                                         };

            Form1.Multiply(Y);
            Form1.GoToScreen();
            Form1.ColorLetter(BOX);

        }
        public static void RotationZ(float[,] m, float angle, PictureBox BOX)
        {
            float[,] Z = new float[4, 4]{
                                        {(float)Math.Cos(angle) ,(float)Math.Sin(angle),0,0},
                                        {(float)-Math.Sin(angle),(float)Math.Cos(angle),0,0},
                                        {          0            ,          0           ,1,0},
                                        {          0            ,          0           ,0,1}
                                        };

            Form1.Multiply(Z);
            Form1.GoToScreen();
            Form1.ColorLetter(BOX);
        }
    }
}
