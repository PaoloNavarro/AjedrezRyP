using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ajedrez
{
    public partial class ajedrez : Form
    {
        public ajedrez()
        {
            InitializeComponent();


        }

        PictureBox selecionado = null;
        int contador = 0;

        //public void peon(Object objeto) {
        //    PictureBox ficha = (PictureBox)objeto;
        //    selecionado = ficha;
        //    casilla1.BackColor.set

        //}
        public void selecion(Object objeto) {
            PictureBox ficha = (PictureBox)objeto;
            selecionado = ficha;
            try {
                selecionado.BackColor = Color.Black;


            }
            catch { 
                
            }
            selecionado.BackColor = Color.Green;





        }

        public void movimiento(PictureBox cuadrado) {
            if (validacion(selecionado,cuadrado))
            {
                if (selecionado != null)
                {
                    Point anterior = selecionado.Location;
                    selecionado.Location = cuadrado.Location;
                    int avance = anterior.Y - cuadrado.Location.Y;

                }


            }

           

        
        }


       
        public bool validacion(PictureBox origen, PictureBox destino)
        {
            Point puntoOrigen = origen.Location;
            Point puntoDestino = destino.Location;
            int avanceV = puntoOrigen.Y - puntoDestino.Y;
            int avanceH = puntoOrigen.X - puntoDestino.X;

          


            if (selecionado.Name == "pisarey")
            {

                if (avanceV == 50 || avanceV == -50)
                {
                    if ((avanceH == 50 || avanceH == -50) || avanceH == 0)
                    {
                        return true;

                    }

                }
                else if (avanceH == 50 || avanceH == -50)
                {
                    if (avanceV == 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            else if (selecionado.Name == "piezaPeon")
            {
                if (contador == 0)
                {

                    if ((avanceV == 50 && avanceH == 0) || (avanceV == 100 && avanceH == 0))
                    {

                        return true;

                    }

                }
                else {

                    if (avanceV == 50 && avanceH == 0) {

                        return true;


                    }


                }



            }

            return false;
            
        




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void cuad(object sender, EventArgs e)
        {
        }

        private void BLANCA(object sender, EventArgs e)
        {
            casilla1.BackColor = Color.Green;
            casilla3.BackColor = Color.Green;
            casilla2.BackColor = Color.Black;
            casilla4.BackColor = Color.Green;
            casilla5.BackColor = Color.Green;
            casilla6.BackColor = Color.Green;
            casilla7.BackColor = Color.Green;
            casilla8.BackColor = Color.Green;
            casilla9.BackColor = Color.Green;
            selecion(sender);

        }

        private void CuadroClick(object sender, MouseEventArgs e)
        {

            if (selecionado.Name == "piezaPeon")
            {
                casilla2.BackColor = Color.Green;
                casilla3.BackColor = Color.White;
                if (contador == 0)
                {

                    movimiento((PictureBox)sender);
                    contador++;
                }
                else
                {

                    movimiento((PictureBox)sender);
                }

               

            }
            else
            {
                movimiento((PictureBox)sender);


            }



        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {

        }

        private void piezaPeon_Click(object sender, EventArgs e)
        {
            if (contador == 0) {
                casilla1.BackColor = Color.White;
                casilla3.BackColor = Color.Green;
                casilla2.BackColor = Color.Green;
                casilla4.BackColor = Color.Black;
                casilla5.BackColor = Color.White;
                casilla6.BackColor = Color.Black;
                casilla7.BackColor = Color.Black;
                casilla8.BackColor = Color.White;
                casilla9.BackColor = Color.Black;
                selecion(sender);
            }
            else
            {
                casilla1.BackColor = Color.White;
                casilla3.BackColor = Color.White;
                casilla2.BackColor = Color.Green;
                casilla4.BackColor = Color.Black;
                casilla5.BackColor = Color.White;
                casilla6.BackColor = Color.Black;
                casilla7.BackColor = Color.Black;
                casilla8.BackColor = Color.White;
                casilla9.BackColor = Color.Black;
                selecion(sender);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
