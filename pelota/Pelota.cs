using System;
using System.Drawing;

namespace pelota
{
    internal class Pelota
    {
        private double radio;
        private double x;
        private double y;

        private double angulo;
        private double sentido;

        private double anchocancha;
        private double altocancha;
        private Bitmap texture;
        private TextureBrush textureBrush;

        private Random r;//esto es para 
        public Pelota(double Radio, double anchocancha, double altocancha, Random r, double? angulo = null, double? X = null, double? Y = null)
        {

            this.radio = Radio;//hacemos referencia a la variable radio segun su metodo 
            x = anchocancha / 2;//hacemos referencia a la variable x segun su metodo
            y = altocancha / 2;//hacemos referencia a la variable y segun su metodo

            this.angulo = r.Next(0, 91);
            sentido = 1;

            this.anchocancha = anchocancha;//esto es 
            this.altocancha = altocancha;

            this.r = r;

            texture = new Bitmap(@"C:\Users\ZenBook\Desktop\progra\img\pelota.png");
            textureBrush = new TextureBrush(texture);
            textureBrush.WrapMode = System.Drawing.Drawing2D.WrapMode.Clamp;
        }
        public void Dibujar(Graphics g)//es para dibujar 
        {
            var display = new Rectangle((int)(x - radio), (int)(y - radio), (int)radio * 2, (int)radio * 2);
            textureBrush.Transform = new System.Drawing.Drawing2D.Matrix(
                (float)display.Width / texture.Width,
                0,
                0,
                (float)display.Height / texture.Height,
                display.X,
                display.Y
            );
            g.FillEllipse(textureBrush,//color de la elipse
                       display);//es 2 por el tamaño del radio 

        }

        public double Borrar(Graphics g)
        {
            g.FillEllipse(Brushes.White,//color de la elipse
                (float)(x - radio), (float)(y - radio),//coordenada superior izquierda
                (float)(2 * radio), (float)(2 * radio));//es 2 por el tamaño del radio 
            return 0;

        }

        double speedX = 16;
        double speedY = 16;
        public void Mover()
        {
            x += speedX;
            y += speedY;
            Rebotar1();
        }

        public void Rebotar1()
        {
            if (x - radio < 0 || x + radio > anchocancha)
            {
                speedX *= -1;
            }

            if (y - radio < 0 || y + radio > altocancha)
            {
                speedY *= -1;
            }
        }

        public void Mover2()//para mover la pelota
        {
            double anguloRadianes = angulo * Math.PI / 180;
            //angulo entre 0 y 45 
            if (angulo < 0 && angulo < 45)
            {
                x += sentido;


                y += Math.Tan(anguloRadianes) * sentido;
            }
            else if (angulo >= 45 && angulo < 90)

            //angulo entre 45 y 90
            {
                y += sentido;
                x += sentido / Math.Tan(anguloRadianes);

            }
            else if (angulo == 90)
            //angulo igual a 90
            {
                y += sentido;
            }
            else
                angulo = r.Next(0, 91);
            Rebotar();
        }
        private void Rebotar()
        {
            if (x - radio < 0 || x + radio > anchocancha)
            {
                sentido *= -1;
                angulo = r.Next(0, 91);

            }

            if (y - radio < 0 || y + radio > altocancha)
            {
                sentido *= -1;
                angulo = r.Next(0, 91);
            }
        }

        public string GetAngulo()
        {
            return angulo.ToString();
        }
    }
}
