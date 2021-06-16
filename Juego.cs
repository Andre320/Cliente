using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace ClienteVentanas
{
    public partial class Juego : Form
    {
        #region Variables de uso general
        PictureBox[,] matrizTablero = new PictureBox[10, 10];

        string colorJugador="";
        public struct datos
        {
            string nombre;
            string color;
            string nombreCarta;
            string rotacionCarta; //0, 90, 180 ,270

            string modenas1;
            string modenas5;
            string modenas10;

        }

        public struct Carta
        {
            public string nombreCarta;
            public string tipo;
        }

       



        //jugador
        List<Carta> barajaMano = new List<Carta>();

        List<Carta> pilasChozas = new List<Carta>();

        //tablero
        List<Carta> pilaSelva = new List<Carta>();

        List<Carta> selvaExplorada = new List<Carta>();




        //generacion de las abarajas       
        int tipoA = 4;
        int tipoB= 5;
        int tipoC=2;
        
        
        int selva = 28;
        Random rand = new Random((int)DateTime.Now.Ticks);

        public void crearBarajaMano()
        {

            switch (colorJugador)
            {
                case "Amarillo":


                    for (int i = 0; i < 11; i++)
                    {
                        int randGenerado = rand.Next(0, 3);
                        if (randGenerado == 0 && tipoA !=0)
                        {
                            Carta ctipoA;
                            ctipoA.nombreCarta = "A_Amarillo.png";
                            ctipoA.tipo = "Choza";

                            tipoA--;
                            pilasChozas.Add(ctipoA);
                        }
                        else if (randGenerado == 1 && tipoB != 0)
                        {
                            Carta ctipoB;
                            ctipoB.nombreCarta = "B_Amarillo.png";
                            ctipoB.tipo = "Choza";

                            tipoB--;
                            pilasChozas.Add(ctipoB);
                        }
                        else if (randGenerado == 2 && tipoC != 0)
                        {
                            Carta ctipoC;
                            ctipoC.nombreCarta = "C_Amarillo.png";
                            ctipoC.tipo = "Choza";

                            tipoC--;
                            pilasChozas.Add(ctipoC);
                        }
                        else
                        {
                            i--;
                        }
                    }






                    break;
                case "Rojo":
                   
                    break;
                case "Morado":
                   
                    break;
                case "Blanco":
                  
                    break;
                default:
                    MessageBox.Show("problemas con el color seleccionado");
                    break;
            }






        }
        
        




        #endregion


        public Juego()
        {
            InitializeComponent();

            crearMatriz();

            mostrarMatrizTablero();
        }

        private void Juego_Load(object sender, EventArgs e)
        {
            

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Conectar();
        }

        #region creacion y visualizacion de la matriz de picBox
        public void crearMatriz()
        {
         
            int posX = 3;
            int posY = 3;

            for (int i=0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Name = "picBox_"+i+"_"+j;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.BorderStyle = BorderStyle.Fixed3D;
                    pic.Size = new Size(85,85);
                    pic.Location = new Point(posX,posY);
                    matrizTablero[i,j] = pic;
                    pic.Click += new EventHandler(pic_click);
                    if (j == 9)
                    {
                        posX = 3;
                    }
                    else { posX = posX + 91; }
                    
                }

                if (i == 9)
                {
                    posY = 3;
                }
                else { posY = posY + 91; }
            }

        }

        public void mostrarMatrizTablero()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    PanelTablero.Controls.Add(matrizTablero[i, j]);

                }

              
            }
        }

        public void pic_click(object sender, EventArgs evento)
        {
            PictureBox picb = sender as PictureBox;
            picb.Image = Image.FromFile("../../../Imagenes/piolin.png");
        }
        #endregion


        #region conexion al server
        static private NetworkStream stream;
        static private StreamWriter writter;
        static private StreamReader reader;
        static private TcpClient cliente = new TcpClient();

        public void Escuchar()
        {
            while (cliente.Connected)
            {
                try
                {
                    Debug.WriteLine("mensaje del servidor: " + reader.ReadLine());


                }
                catch { }
            }
        }

        public void Conectar()
        {
            if (txtIP.Text.Trim() !="" && txtNombre.Text.Trim() != ""&& cbColor.SelectedItem.ToString().Trim() != "")
            {
                try
                {

                    cliente.Connect(IPAddress.Parse(txtIP.Text), int.Parse("46000"));
                    if (cliente.Connected)
                    {

                        PanelTablero.Visible = true;
                        panelInicio.Visible = false;
                        string color = cbColor.SelectedItem.ToString();
                        string nombre = txtNombre.Text;
                        string data = "Hola Mundo";

                        Debug.WriteLine("Conectado con exito");

                        Thread thread = new Thread(Escuchar);

                        stream = cliente.GetStream();
                        writter = new StreamWriter(stream);
                        reader = new StreamReader(stream);

                        writter.WriteLine(color);
                        writter.WriteLine(nombre);
                        writter.WriteLine(data);

                        writter.Flush();

                        thread.Start();


                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                    MessageBox.Show("se murio");

                }
            }
            else
            {
                MessageBox.Show("no sea idiota y llene los datos");
            }

            
        }

        public void Enviar(string mensaje)
        {
            writter.WriteLine(mensaje);
            writter.Flush();
        }
        #endregion


        #region estructura inicial de juego

        public void inicializarCartas()
        {

        }

        public void manoJugador()
        {

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            colorJugador = "Amarillo";
            crearBarajaMano();
            for(int c = 0; c < pilasChozas.Count; c++)
            {
                Debug.WriteLine("dato de la lista en la pos: "+c+" Nombre: "+pilasChozas[c].nombreCarta+ " Tipo: "+ pilasChozas[c].tipo);
            }


        }
    }
}
