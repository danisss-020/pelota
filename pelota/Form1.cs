using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pelota
{
    public partial class FormPelota: Form
    {
        private Pelota pelota;
        private Random r;
        public FormPelota()
        {
            InitializeComponent();//es para inicializar los componentes
            r = new Random();
            pelota = new Pelota(20,Canchapelota.Width,Canchapelota.Height,r);//aqui se le asigna los valores a la pelota es el metodo constructor es el 10 10 10 porque es el radio y las coordenadas
            label.Text = pelota.GetAngulo();
        }

        private void Salirprograma_click_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Saliendo del programa");
            Application.Exit();
        }

        private void Canchapelota_Click(object sender, EventArgs e)
        {

        }

        private void botondibujar_Click(object sender, EventArgs e)
        {
            pelota.Borrar(Canchapelota.CreateGraphics());//para borrar la pelota en la cnacha por eso cancha esta en el los parentesis
            pelota.Mover();//para mover la pelota
            pelota.Dibujar(Canchapelota.CreateGraphics());//para dibujar la pelota en la cnacha por eso cancha esta en el los parentesis
            

        }

        private void timeranimacion_Tick(object sender, EventArgs e)//al timer le ponemos lo mismo que alboton dibujar para 
                                                                    //automatize lo que hace el boton lo que hace que nosotros ya no
                                                                    ////tengamios que darle click al boton
        {
          //  pelota.Borrar(Canchapelota.CreateGraphics());//para borrar la pelota en la cnacha por eso cancha esta en el los parentesis
            pelota.Mover();//para mover la pelota

            label.Text = pelota.GetAngulo();
           // pelota.Dibujar(Canchapelota.CreateGraphics());//para dibujar la pelota en la cnacha por eso cancha esta en el los parentesis
           Canchapelota.Invalidate();


        }

        private void Canchapelota_Paint(object sender, PaintEventArgs e)
        {
            pelota.Dibujar(e.Graphics);//esto es para que se dibuje la pelota en la cancha y el paint es para que se dibuje
            //y se actualize la pelota sin importarel tiempo que pase 
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
