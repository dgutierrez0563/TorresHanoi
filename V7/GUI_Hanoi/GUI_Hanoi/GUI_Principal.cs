using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Hanoi
{
    public partial class GUI_Principal : Form
    {
        /// <summary>
        /// Creacion de objetos referentes al dibujo y colores
        /// </summary>
        Color color = new Color();
        Graphics formas;
        /// <summary>
        /// Atributos del formulario
        /// </summary>
        private int serieA, serieB, serieC;
        private int moviemientos;
        private int cantidadAnillos;
        private int movimientosSolucion;
        //private int modoFacil;
        //private int modoMedio;
        //private int modoDificil;
        private int discosA, discosB, discosC;
        private bool onSerieA, onSerieB, onSerieC;        
        private int[] torreI, torreII, torreIII;
        private int posicion;
        public GUI_Principal()
        {
            InitializeComponent();
            formas = panel_Torres.CreateGraphics();
        }

        private void panel_Torres_Paint(object sender, PaintEventArgs e)
        {
            controlGraficos();
        }

        private void facilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int cantidadDiscosAuxiliar = 3;
            validaciones(cantidadDiscosAuxiliar);
        }

        private void medioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int cantidadDiscosAuxiliar = 5;
            validaciones(cantidadDiscosAuxiliar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validaciones(5);
        }

        private void difícilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cantidadDiscosAuxiliar = 8;
            validaciones(cantidadDiscosAuxiliar);
        }

        private void panel_Torres_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X>=0 & e.X <=170) & (this.serieA != 0)) {
                onSerieA = true;
                onSerieB = false;
                onSerieC = false;
            }
            if ((e.X>=170 & e.X <=330) & (serieB!=0)){
                onSerieA = true;
                onSerieB = false;
                onSerieC = false;
            }
            if ((e.X >= 330 & e.X <= 500) & (serieC != 0))
            {
                onSerieA = true;
                onSerieB = false;
                onSerieC = false;
            }
        }

        private void panel_Torres_MouseMove(object sender, MouseEventArgs e)
        {
            if (onSerieA | onSerieB | onSerieC) {
                this.Refresh();
            }
            if (onSerieA) {
                formas.FillRectangle(new SolidBrush(Color.Blue), 90 - (torreI[discosA - 1] * 10), 210 - ((discosA - 1) * 20), 20 * torreI[discosA - 1], 20);
                formas.FillRectangle(new SolidBrush(Color.Brown), 85, 210 - ((discosA - 1) * 20), 10, 20);
                int x = e.X - (10 * torreI[discosA-1]);
                int y = e.Y - 10;
                formas.FillRectangle(new SolidBrush(Color.LightPink), x, y, 20 * torreI[discosA-1],20);
                if (torreI[discosA - 1] == 1) {
                    color = Color.Black;
                }
                if (torreI[discosA - 1] == 2)
                {
                    color = Color.Black;
                }
                if (torreI[discosA - 1] == 3)
                {
                    color = Color.Black;
                }
                if (torreI[discosA - 1] == 4)
                {
                    color = Color.Black;
                }
                if (torreI[discosA - 1] == 5)
                {
                    color = Color.Black;
                }
                if (torreI[discosA - 1] == 6)
                {
                    color = Color.Black;
                }
                if (torreI[discosA - 1] == 7)
                {
                    color = Color.Black;
                }
                if (torreI[discosA - 1] == 8)
                {
                    color = Color.Black;
                }
                formas.FillRectangle(new SolidBrush(color), x + 2, y + 2, (20 * torreI[discosA - 1]) - 4, 16);
            }
            if (onSerieB)
            {
                formas.FillRectangle(new SolidBrush(Color.Blue), 250 - (torreII[discosB - 1] * 10), 210 - ((discosB - 1) * 20), 20 * torreII[discosB - 1], 20);
                formas.FillRectangle(new SolidBrush(Color.Brown), 245, 210 - ((discosB - 1) * 20), 10, 20);
                int x = e.X - (10 * torreII[discosB-1]);
                int y = e.Y - 10;
                formas.FillRectangle(new SolidBrush(Color.LightPink), x, y, 20 * torreII[discosB-1], 20);
                if (torreII[discosB - 1] == 1)
                {
                    color = Color.Black;
                }
                if (torreII[discosB - 1] == 2)
                {
                    color = Color.Black;
                }
                if (torreII[discosB - 1] == 3)
                {
                    color = Color.Black;
                }
                if (torreII[discosB - 1] == 4)
                {
                    color = Color.Black;
                }
                if (torreII[discosB - 1] == 5)
                {
                    color = Color.Black;
                }
                if (torreII[discosB - 1] == 6)
                {
                    color = Color.Black;
                }
                if (torreII[discosB - 1] == 7)
                {
                    color = Color.Black;
                }
                if (torreII[discosB - 1] == 8)
                {
                    color = Color.Black;
                }
                formas.FillRectangle(new SolidBrush(color), x + 2, y + 2, (20 * torreII[discosB - 1]) - 4, 16);
            }

            if (onSerieC)
            {
                formas.FillRectangle(new SolidBrush(Color.Blue), 410 - (torreIII[discosC - 1] * 10), 210 - ((discosC - 1) * 20), 20 * torreIII[discosC - 1], 20);
                formas.FillRectangle(new SolidBrush(Color.Brown), 405, 210 - ((discosC - 1) * 20), 10, 20);
                int x = e.X - (10 * torreIII[discosC - 1]);
                int y = e.Y - 10;
                formas.FillRectangle(new SolidBrush(Color.LightPink), x, y, 20 * torreIII[discosC - 1], 20);
                if (torreIII[discosC - 1] == 1)
                {
                    color = Color.Black;
                }
                if (torreII[discosC - 1] == 2)
                {
                    color = Color.Black;
                }
                if (torreIII[discosC - 1] == 3)
                {
                    color = Color.Black;
                }
                if (torreIII[discosC - 1] == 4)
                {
                    color = Color.Black;
                }
                if (torreIII[discosC - 1] == 5)
                {
                    color = Color.Black;
                }
                if (torreIII[discosC - 1] == 6)
                {
                    color = Color.Black;
                }
                if (torreIII[discosC - 1] == 7)
                {
                    color = Color.Black;
                }
                if (torreIII[discosC - 1] == 8)
                {
                    color = Color.Black;
                }
                formas.FillRectangle(new SolidBrush(color), x + 2, y + 2, (20 * torreIII[discosC - 1]) - 4, 16);
            }
        }

        private void panel_Torres_MouseUp(object sender, MouseEventArgs e)
        {
            onSerieA = false;
            onSerieB = false;
            onSerieC = false;

            if ((e.X>=0 & e.X<=170)& onSerieB & ((serieB<serieA)|serieA==0)) {
                serieA = serieB;
                torreI[discosA]=serieB;
                if (discosB > 1)
                {
                    serieB = torreII[discosB - 2];
                }
                else {
                    serieB = torreII[discosB];
                }
                torreII[discosB - 1] = 0;
                discosA++;
                discosB--;
                //discosC--;
                moviemientos++;
            }
            if ((e.X >= 0 & e.X <= 170) & onSerieC & ((serieC < serieA) | serieA == 0))
            {
                serieA = serieC;
                torreI[discosA] = serieC;
                if (discosC > 1)
                {
                    serieC = torreIII[discosC - 2];
                }
                else
                {
                    serieB = torreII[discosC];
                }
                torreIII[discosC - 1] = 0;
                discosA++;
                discosC--;
                //discosC--;
                moviemientos++;
            }
            if ((e.X >= 170 & e.X <= 330) & onSerieA & ((serieA < serieB) | serieB == 0))
            {
                serieB = serieA;
                torreII[discosB] = serieA;
                if (discosA > 1)
                {
                    serieA = torreI[discosA - 2];
                }
                else
                {
                    serieA = torreI[discosA];
                }
                torreII[discosA - 1] = 0;
                discosB++;
                discosA--;
                //discosC--;
                moviemientos++;
            }
            if ((e.X >= 170 & e.X <= 330) & onSerieC & ((serieC < serieB) | serieB == 0))
            {
                serieB = serieC;
                torreII[discosB] = serieC;
                if (discosC > 1)
                {
                    serieC = torreIII[discosC - 2];
                }
                else
                {
                    serieC = torreIII[discosC];
                }
                torreIII[discosC - 1] = 0;
                discosB++;
                discosC--;
                //discosC--;
                moviemientos++;
            }
            if ((e.X >= 330 & e.X <= 500) & onSerieA & ((serieA < serieC) | serieC == 0))
            {
                serieC = serieA;
                torreIII[discosC] = serieA;
                if (discosA > 1)
                {
                    serieA = torreI[discosA - 2];
                }
                else
                {
                    serieA = torreI[discosA];
                }
                torreI[discosA - 1] = 0;
                discosC++;
                discosA--;
                //discosC--;
                moviemientos++;
            }
            if ((e.X >= 330 & e.X <= 5000) & onSerieB & ((serieB < serieC) | serieC == 0))
            {
                serieC = serieB;
                torreIII[discosC] = serieB;
                if (discosB > 1)
                {
                    serieB = torreII[discosB - 2];
                }
                else
                {
                    serieB = torreII[discosB];
                }
                torreII[discosB - 1] = 0;
                discosC++;
                discosB--;
                //discosC--;
                moviemientos++;
            }

            this.Refresh();
            lbl_Movimientos.Text = Convert.ToString(moviemientos);
            if ((torreIII[cantidadAnillos-1]==1))
            {
                movimientosSolucion = 0;
                for (int i = 1; i <= movimientosSolucion; i++)
                {
                    movimientosSolucion = (movimientosSolucion * 2) + 1;
                }
                if (moviemientos>movimientosSolucion || moviemientos.Equals(movimientosSolucion))
                {
                    string mensaje=Convert.ToString(MessageBox.Show("Juego terminado satisfactoriamente\n\n"+"Total "+moviemientos+ " movimientos " + " de "+movimientosSolucion+"\n\n¿Voler a Jugar?\n","Mensaje del Sistema",MessageBoxButtons.RetryCancel,MessageBoxIcon.Question));
                    if (mensaje.Equals("Reintentar"))
                    {
                        //volver a jugar
                    }
                    else
                    {
                        //vacio
                    }
                }else
                {
                    
                }
                this.Refresh();
            }

        }
                 
        public void validaciones(int auxiliarDiscos) {
            lbl_Movimientos.Text="NULL";
            panel_Torres.Enabled = (true);
            cantidadAnillos = System.Convert.ToInt32(auxiliarDiscos);
            torreI = new int[cantidadAnillos];
            torreII = new int[cantidadAnillos];
            torreIII = new int[cantidadAnillos];
            discosA = cantidadAnillos;
            discosB = 0;
            discosC = 0;
            for (int i = cantidadAnillos, j=0; i >0; i--, j++)
            {
                torreI[j] = i;
            }
            moviemientos = 0;
            lbl_Movimientos.Text = Convert.ToString(moviemientos);
            this.Refresh();
        }
        /// <summary>
        /// Metodo iten menu para salir del juego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string respuesta = Convert.ToString(MessageBox.Show("¿Desea salir del juego?","Mensaje del Sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Question));
            if (respuesta.Equals("Yes"))
            {
                Application.Exit();
            }
            else {
                MessageBox.Show("Ha cancelado el cierre","Mensaje del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void GUI_Principal_Load(object sender, EventArgs e)
        {

        }

        public void controlGraficos() {
            ////Torre A
            //formas.FillRectangle(new SolidBrush(Color.Brown), 20, 230, 140, 20);
            //formas.FillRectangle(new SolidBrush(Color.DarkGray), 85, 30, 10, 210);
            ////Torre B
            //formas.FillRectangle(new SolidBrush(Color.Brown), 180, 230, 140, 20);
            //formas.FillRectangle(new SolidBrush(Color.DarkGray), 245, 30, 10, 210);
            ////TorreC
            //formas.FillRectangle(new SolidBrush(Color.Brown), 340, 230, 140, 20);
            //formas.FillRectangle(new SolidBrush(Color.DarkGray), 405, 30, 10, 210);

            //creacionDeGraficos.FillRectangle(new SolidBrush(Color.Gray), 90 - (torreI[a] * 10), 210 - (a * 20), 20 * torreI[a], 20);
            //creacionDeGraficos.FillRectangle(new SolidBrush(Color.Gray), 250 - (torreII[a] * 10), 210 - (a * 20), 20 * torreII[a], 20);
            //creacionDeGraficos.FillRectangle(new SolidBrush(Color.Gray), 410 - (torreIII[a] * 10), 210 - (a * 20), 20 * torreIII[a], 20);

            for (int i = 0; i < cantidadAnillos; i++)
            {

                if (torreI[i]==1 | torreII[i]==1 | torreIII[i]==1)
                {
                    if (torreI[i]==1)
                    {
                        posicion = 92 - (torreI[i] * 10);
                    }
                    if (torreII[i] == 1)
                    {
                        posicion = 252 - (torreII[i] * 10);
                    }
                    if (torreIII[i] == 1)
                    {
                        posicion = 452 - (torreIII[i] * 10);
                    }
                }
                if (torreI[i] == 2 | torreII[i] == 2 | torreIII[i] == 2)
                {
                    if (torreI[i] == 2)
                    {
                        posicion = 92 - (torreI[i] * 10);
                    }
                    if (torreII[i] == 2)
                    {
                        posicion = 252 - (torreII[i] * 10);
                    }
                    if (torreIII[i] == 2)
                    {
                        posicion = 452 - (torreIII[i] * 10);
                    }
                }
                if (torreI[i] == 3 | torreII[i] == 3 | torreIII[i] == 3)
                {
                    if (torreI[i] == 3)
                    {
                        posicion = 92 - (torreI[i] * 10);
                    }
                    if (torreII[i] == 3)
                    {
                        posicion = 252 - (torreII[i] * 10);
                    }
                    if (torreIII[i] == 3)
                    {
                        posicion = 452 - (torreIII[i] * 10);
                    }
                }
                if (torreI[i] == 4 | torreII[i] == 4 | torreIII[i] == 4)
                {
                    if (torreI[i] == 4)
                    {
                        posicion = 92 - (torreI[i] * 10);
                    }
                    if (torreII[i] == 4)
                    {
                        posicion = 252 - (torreII[i] * 10);
                    }
                    if (torreIII[i] == 4)
                    {
                        posicion = 452 - (torreIII[i] * 10);
                    }
                }
                if (torreI[i] == 5 | torreII[i] == 5 | torreIII[i] == 5)
                {
                    if (torreI[i] == 5)
                    {
                        posicion = 92 - (torreI[i] * 10);
                    }
                    if (torreII[i] == 5)
                    {
                        posicion = 252 - (torreII[i] * 10);
                    }
                    if (torreIII[i] == 5)
                    {
                        posicion = 452 - (torreIII[i] * 10);
                    }
                }
                if (torreI[i] == 6 | torreII[i] == 6 | torreIII[i] == 6)
                {
                    if (torreI[i] == 6)
                    {
                        posicion = 92 - (torreI[i] * 10);
                    }
                    if (torreII[i] == 6)
                    {
                        posicion = 252 - (torreII[i] * 10);
                    }
                    if (torreIII[i] == 6)
                    {
                        posicion = 452 - (torreIII[i] * 10);
                    }
                }
                if (torreI[i] == 7 | torreII[i] == 7 | torreIII[i] == 7)
                {
                    if (torreI[i] == 7)
                    {
                        posicion = 92 - (torreI[i] * 10);
                    }
                    if (torreII[i] == 7)
                    {
                        posicion = 252 - (torreII[i] * 10);
                    }
                    if (torreIII[i] == 7)
                    {
                        posicion = 452 - (torreIII[i] * 10);
                    }
                }
                //if (torreI[i] == 8 | torreII[i] == 8 | torreIII[i] == 8)
                //{
                //    if (torreI[i] == 8)
                //    {
                //        posicion = 92 - (torreI[i] * 10);
                //    }
                //    if (torreII[i] == 8)
                //    {
                //        posicion = 252 - (torreII[i] * 10);
                //    }
                //    if (torreIII[i] == 8)
                //    {
                //        posicion = 452 - (torreIII[i] * 10);
                //    }
                //}
            }
        }
                
    }
}
