using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Z_BUFFER.Triangles;

namespace Z_BUFFER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Graphics image;
        public static Bitmap bmp;
        // мировые
        public static float Xe = 0;
        public static float Ye = 0;
        public static float Ze = 0;

        public static float fi = 90;
        public static float teta = 10;
        public static float distance = 220;
        
        public static float r = 0;
        public static float z = 0;
        public static float az = 0; 

        public static float z0 = 450;
       
        public static float[,] m1 = new float[24, 4];
        public static float[,] m2 = new float[24, 4];
        public static float[,] m3 = new float[24, 4];
        public static float[,] view = {{ 0,0,0,0 },
                                       { 0,0,0,0 },
                                       { 0,0,0,0 },
                                       { 0,0,0,0 }};
        public static void FileRead()
        {
            using (StreamReader read = new StreamReader("letter_D.txt"))
            {
                int a = 0;
                while (read.Peek() >= 0)
                {
                    string s = read.ReadLine();
                    string[] mas = s.Split(new char[] { '\n', ' ', '.', ':', '\t' });
                    for (int i = 0; i < 4; i++)
                    {
                        m1[a, i] = float.Parse(mas[i]);
                    }
                    a++;
                }
            }
        }
        public static void WorldCoordinates()
        {
            Xe = (float)(distance * Math.Sin(fi) * Math.Cos(teta));
            Ye = (float)(distance * Math.Sin(fi) * Math.Cos(teta));
            Ze = (float)(distance * Math.Cos(fi));
        }
        public static void SphereCoordinates()
        {
            r = (float)Math.Sqrt(Xe * Xe + Ye * Ye + Ze * Ze);
            z = (float)Math.Acos(Ze / r);
            if (Xe > 0) az = (float)(Math.Atan(Ye / Xe));
            else if (Xe <= 0) az = (float)(Math.PI + Math.Atan(Ye / Xe));
            else if (Xe == 0 && Ye >= 0) az = (float)(Math.PI / 2); 
            else if (Xe == 0 && Ye < 0) az = (float)(3 * Math.PI / 2);
        }
        public static void ChangeWorldToKindOf()
        {
            view = new float[4, 4]{
                                  { (float)-Math.Sin(az), (float)(-Math.Cos(z) * Math.Cos(az)),(float)(-Math.Sin(z)*Math.Cos(az)),0},
                                  { (float)Math.Cos(az) , (float)(-Math.Cos(z) * Math.Sin(az)),(float)(-Math.Sin(z)*Math.Sin(az)),0},
                                  {           0         , (float)Math.Sin(z)                  ,(float)(-Math.Cos(z))             ,0},
                                  {           0         ,                   0                 ,               r                  ,1}
                                  };
        }
        public static void GoToScreen()
        {
            m2 = new float[24, 4];
            for (int row = 0; row < 24; row++) for (int col = 0; col < 4; col++) for (int i = 0; i < 4; i++) m2[row, col] += m1[row, i] * view[i, col];
        }
        private void Load_Click(object sender, EventArgs e)
        {
            Load(BOX);
        }
        public static void Load(PictureBox BOX)
        {
            FileRead();
            bmp = new Bitmap(BOX.Width, BOX.Height);
            image = Graphics.FromImage(bmp);
            WorldCoordinates();
            SphereCoordinates();
            ChangeWorldToKindOf();
            GoToScreen();
            ColorLetter(BOX);
            BOX.Image = bmp;
        }
        static bool bl = false;
        public static Point3d[] Точки(int a, float[,] m, PictureBox BOX, ref bool f)
        {
            float centx = BOX.Width / 2;
            float centy = BOX.Height / 2;
            int coof = 12;
            Point3d[] p = new Point3d[a];
            for (int i = 0; i < a; i++)
            {
                float x1 = m[i, 0] / (1 - (m[i, 2] / z0));
                float y1 = m[i, 1] / (1 - (m[i, 2] / z0));
                p[i] = new Point3d(x1 * coof + centx, y1 * coof + centy, m[i, 2]);
                if (x1 * coof + centx < 0 || x1 * coof + centx > BOX.Width || y1 * coof + centy < 0 || y1 * coof + centy > BOX.Height)
                {
                    f = true;
                    bl = true;
                    Array.Clear(m1, 0, 96);
                    Array.Clear(m2, 0, 96);
                    Array.Clear(m3, 0, 96);
                    MessageBox.Show("The letter is outside of field.\nIt will be on start position.\nTry again!");
                    Load(BOX);
                }
            }
            return p;
        }
        public static void ColorLetter(PictureBox BOX)
        {
            Z_Buffer z = new Z_Buffer(BOX.Width, BOX.Height);
            bool f = false;
            Point3d[] point = Точки(24, m2, BOX, ref f);
            if (f)
            {
                Load(BOX);
                return;
            }
            z.Fon();
            z.DrawTriangles(new Triangles(point[0], point[1], point[6], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[1], point[6], point[7], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[1], point[7], point[2], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[2], point[7], point[8], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[2], point[8], point[9], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[2], point[9], point[3], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[3], point[9], point[10], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[3], point[10], point[4], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[4], point[10], point[11], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[4], point[11], point[5], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[5], point[11], point[6], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[5], point[6], point[0], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[12], point[13], point[18], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[13], point[18], point[19], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[13], point[19], point[14], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[14], point[19], point[20], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[14], point[20], point[15], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[15], point[20], point[21], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[15], point[21], point[16], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[16], point[21], point[22], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[16], point[22], point[23], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[16], point[23], point[17], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[17], point[23], point[18], Color.LightSkyBlue));
            z.DrawTriangles(new Triangles(point[17], point[18], point[12], Color.LightSkyBlue));



            z.DrawTriangles(new Triangles(point[17], point[5], point[4], Color.Navy));
            z.DrawTriangles(new Triangles(point[17], point[16], point[4], Color.Navy));
            z.DrawTriangles(new Triangles(point[4], point[16], point[15], Color.Navy));
            z.DrawTriangles(new Triangles(point[4], point[3], point[15], Color.Navy));
            z.DrawTriangles(new Triangles(point[3], point[15], point[14], Color.Navy));
            z.DrawTriangles(new Triangles(point[3], point[2], point[14], Color.Navy));
            z.DrawTriangles(new Triangles(point[0], point[1], point[13], Color.Navy));
            z.DrawTriangles(new Triangles(point[0], point[13], point[12], Color.Navy));
            z.DrawTriangles(new Triangles(point[0], point[12], point[5], Color.Navy));
            z.DrawTriangles(new Triangles(point[12], point[17], point[5], Color.Navy));
            z.DrawTriangles(new Triangles(point[13], point[1], point[2], Color.Navy));
            z.DrawTriangles(new Triangles(point[13], point[2], point[14], Color.Navy));


            z.DrawTriangles(new Triangles(point[6], point[7], point[19], Color.RoyalBlue));
            z.DrawTriangles(new Triangles(point[6], point[18], point[19], Color.RoyalBlue));
            z.DrawTriangles(new Triangles(point[19], point[7], point[8], Color.RoyalBlue));
            z.DrawTriangles(new Triangles(point[19], point[8], point[20], Color.RoyalBlue));
            z.DrawTriangles(new Triangles(point[20], point[8], point[9], Color.RoyalBlue));
            z.DrawTriangles(new Triangles(point[20], point[9], point[21], Color.RoyalBlue));
            z.DrawTriangles(new Triangles(point[21], point[9], point[10], Color.RoyalBlue));
            z.DrawTriangles(new Triangles(point[21], point[10], point[22], Color.RoyalBlue));
            z.DrawTriangles(new Triangles(point[22], point[10], point[11], Color.RoyalBlue));
            z.DrawTriangles(new Triangles(point[22], point[11], point[23], Color.RoyalBlue));
            z.DrawTriangles(new Triangles(point[23], point[11], point[6], Color.RoyalBlue));
            z.DrawTriangles(new Triangles(point[23], point[18], point[6], Color.RoyalBlue));

            bmp = z.DrawLetter();
            BOX.Image = bmp;
        }
        public static void Multiply(float[,] b)
        {
            m2 = new float[24, 4];
            m3 = new float[24, 4];
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    m3[i, j] = m1[i, j];
                }
            }
            m1 = new float[24, 4];
            for (int row = 0; row < 24; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    for (int m = 0; m < 4; m++)
                    {
                        m1[row, col] += m3[row, m] * b[m, col];
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Rotation.RotationX(m2, 0.3f, BOX);
            BOX.Image = bmp;
        }
        private void ПротивстрелкиХ_Click(object sender, EventArgs e)
        {
            Rotation.RotationX(m2, -0.3f, BOX);
            BOX.Image = bmp;
        }
        private void ПострелкеУ_Click(object sender, EventArgs e)
        {
            Rotation.RotationZ(m2, 0.3f, BOX);
            BOX.Image = bmp;
        }
        private void ПротивстрелкиУ_Click(object sender, EventArgs e)
        {
            Rotation.RotationZ(m2, -0.3f, BOX);
            BOX.Image = bmp;
        }
        private void ПострелкеZ_Click(object sender, EventArgs e)
        {
            Rotation.RotationY(m2, 0.3f, BOX);
            BOX.Image = bmp;
        }
        private void ПротивстрелкиZ_Click(object sender, EventArgs e)
        {
            Rotation.RotationY(m2, -0.3f, BOX);
            BOX.Image = bmp;
        }
        private void Перенос1Х_Click(object sender, EventArgs e)
        {
            MoveTo.MoveToX(0.4f, BOX);
            BOX.Image = bmp;
        }
        private void Перенос2Х_Click(object sender, EventArgs e)
        {
            MoveTo.MoveToX(-0.4f, BOX);
            BOX.Image = bmp;
        }
        private void Перенос1У_Click(object sender, EventArgs e)
        {
            MoveTo.MoveToY(0.4f, BOX);
            BOX.Image = bmp;
        }
        private void Перенос2У_Click(object sender, EventArgs e)
        {
            MoveTo.MoveToY(-0.4f, BOX);
            BOX.Image = bmp;
        }
        private void Перенос1Z_Click(object sender, EventArgs e)
        {
            MoveTo.MoveToZ(0.4f, BOX);
            BOX.Image = bmp;
        }
        private void Перенос2Z_Click(object sender, EventArgs e)
        {
            MoveTo.MoveToZ(-0.4f, BOX);
            BOX.Image = bmp;
        }
        private void Resize1Х_Click(object sender, EventArgs e)
        {
            Res.ResizeX(0.9f, BOX);
            BOX.Image = bmp;

        }
        private void Масштаб2Х_Click(object sender, EventArgs e)
        {
            Res.ResizeX(1.1f, BOX);
            BOX.Image = bmp;
        }

        private void Resize1Y_Click(object sender, EventArgs e)
        {
            Res.ResizeY(1.1f, BOX);
            BOX.Image = bmp;
        }
        private void Resize2Y_Click(object sender, EventArgs e)
        {
            Res.ResizeY(0.9f, BOX);
            BOX.Image = bmp;
        }
        private void Resize1Z_Click(object sender, EventArgs e)
        {
            Res.ResizeZ(1.1f, BOX);
            BOX.Image = bmp;
        }
        private void Resize2Z_Click(object sender, EventArgs e)
        {
            Res.ResizeZ(0.9f, BOX);
            BOX.Image = bmp;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Mirror.MirrorXOY(BOX);
            BOX.Image = bmp;
        }
        private void YOZ_Click(object sender, EventArgs e)
        {
            Mirror.MirrorYOZ(BOX);
            BOX.Image = bmp;
        }
        private void XOZ_Click(object sender, EventArgs e)
        {
            Mirror.MirrorXOZ(BOX);
            BOX.Image = bmp;
        }
        private void label10_Click(object sender, EventArgs e){}
        private void Движение_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            bl = false;
        }
        float y = 0;
        float t = 0;
        float dy = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            t += 20f;
            y = 2 * (float)(Math.Cos((double)t / 35));
            MoveTo.MoveToZ(0.5f, BOX);
            MoveTo.MoveToY(y - dy, BOX);
            dy = y;
            BOX.Image = bmp;
            if (t >= 3000 || bl == true) { timer1.Stop(); t = 0; }
        }
        private void Загрузить_Click(object sender, EventArgs e)
        {
            Load(BOX);
        }
        private void Form1_Load(object sender, EventArgs e){}
        private void label4_Click(object sender, EventArgs e){}
        private void label7_Click(object sender, EventArgs e){}
        private void label9_Click(object sender, EventArgs e){}
        private void label8_Click(object sender, EventArgs e){}
    }
}