using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Z_BUFFER.Triangles;

namespace Z_BUFFER
{
    class Z_Buffer
    {
        public Cell[,] buffer;//create buffer
        int Cell1;//width
        int Cell2;//height
        public Z_Buffer(int C1, int C2)
        {
            Cell1 = C1;
            Cell2 = C2;
            buffer = new Cell[C1, C2];
        }
        public void Fon()
        {
            for (int i = 0; i < Cell1; i++)
            {
                for (int j = 0; j < Cell2; j++)
                {
                    buffer[i, j].C = Color.PowderBlue;
                    buffer[i, j].z = 300f;
                }
            }
        }
        public Bitmap DrawLetter()
        {
            Bitmap bmp = new Bitmap(Cell1, Cell2);//like buffer
            for (int i = 0; i < Cell1; i++)
            {
                for (int j = 0; j < Cell2; j++)
                {
                    bmp.SetPixel(i, j, buffer[i, j].C); //color of pixel
                }
            }
            for (int b = 0; b < Cell1; b++)//x
            {
                int a = (Cell1 / 2 - 100) * 2 - 5 * b / 13 + 80;
                bmp.SetPixel(b, a, Color.Red);
            }
            int a1 = (Cell2 / 2 - 64);
            for (int b1 = 0; b1 < Cell2  ; b1++)//y
            {
                bmp.SetPixel(a1, b1, Color.Green);
            }
            for (int b2 = 0; b2 < Cell1; b2++)//z
            {
                int a2 = (Cell1 / 2 - 100) * 2 + 5 * b2 / 13 - 147;
                bmp.SetPixel(b2, a2, Color.Blue);
            }
            return bmp;
        }
        public void DrawTriangles(Triangles triangle)
        {
            int YMax, YMin, e1, e;
            int[] x = new int[3];
            int[] y = new int[3];

            for (int i = 0; i < 3; i++)
            {
                x[i] = Convert.ToInt32(triangle.p[i].x);
                y[i] = Convert.ToInt32(triangle.p[i].y);
            }
            YMin = y[0];
            YMax = y[0];
            for (int i=1;i<3;i++)
            {
                if (YMax < y[i]) YMax = y[i];
                else if (YMin > y[i]) YMin = y[i];
            }
            YMin = (YMin < 0) ? 0 : YMin;
            YMax = (YMin < Cell2) ? YMax : Cell2;//check of cordon
            int n;
            int x1 = 0, x2 = 0;
            int cx1, cx2;
            float z1 = 0, z2 = 0;
            e1 = 0;
            float part, z;
            for (int cy = YMin; cy < YMax; cy++)
            {
                n = 0;
                for (e = 0; e < 3; e++)
                {
                    e1 = e + 1;
                    if (e1 == 3) e1 = 0;
                    if (y[e] < y[e1])
                    {
                        if (y[e1] <= cy || cy < y[e]) continue;
                    }
                    else if (y[e] > y[e1])
                    {
                        if (y[e1] > cy || cy >= y[e]) continue;
                    }
                    else continue;
                    part = (float)(y[e] - cy) / (y[e] - y[e1]);
                    if (n != 0)
                    {
                        x2 = x[e] + Convert.ToInt32(part * (x[e1] - x[e]));
                        z2 = triangle.p[e].z + part * (triangle.p[e1].z - triangle.p[e].z);
                    }
                    else
                    {
                        x1 = x[e] + Convert.ToInt32(part * (x[e1] - x[e]));
                        z1 = triangle.p[e].z + part * (triangle.p[e1].z - triangle.p[e].z);
                        n = 1;
                    }
                }
                if (x2 < x1)
                {
                    e = x1;
                    x1 = x2;
                    x2 = e;
                    part = z1;
                    z1 = z2;
                    z2 = part;
                }
                cx1 = (x1 < 0) ? 0 : x1;
                cx2 = (x2 < Cell1) ? x2 : Cell1;
                for (int cx = cx1; cx < cx2; cx++)
                {
                    part = (float)(x1 - cx) / (x1 - x2);
                    z = z1 + part * (z2 - z1);
                    if (z < buffer[cx, cy].z)
                    {
                        buffer[cx, cy].C = triangle.C;
                        buffer[cx, cy].z = z;
                    }
                }
            }
        }
    }
}