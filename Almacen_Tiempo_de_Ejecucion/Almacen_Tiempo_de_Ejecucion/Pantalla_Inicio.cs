using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Almacen_Tiempo_de_Ejecucion
{
    public partial class Pantalla_Inicio : Form
    {
        PictureBox pb = new PictureBox();
        Button btn1 = new Button();
        Label lbl1 = new Label();
        Form1 form1 = new Form1();
        TextBox Tb_Usuario = new TextBox();
        TextBox Tb_Password = new TextBox();
        Label Lb_Usuario = new Label();
        Label Lb_Password = new Label();

        public void Hilo1()//Evento del hilo
        {
            if (InvokeRequired)//Se utiliza para no interrumpir el hilo principal de la aplicacion
                Invoke(new Action(() => form1.Show()));//Ocultar forma al ejecutarse el hilo
        }
        public void Objetos()
        {
            Tb_Usuario.Size = new Size(70, 15);
            Tb_Usuario.Location = new Point(400, 200);



            Tb_Password.Size = new Size(70, 15);
            Tb_Password.Location = new Point(400, 220);


            Lb_Usuario.Text = "USUARIO";
            Lb_Usuario.Size = new Size(70, 15);
            Lb_Usuario.Location = new Point(330, 200);
            Lb_Usuario.ForeColor = Color.Black;
            Lb_Usuario.BackColor = Color.WhiteSmoke;

            Lb_Password.Text = "PASSWORD";
            Lb_Password.Size = new Size(70, 15);
            Lb_Password.Location = new Point(330, 220);
            Lb_Password.ForeColor = Color.DarkBlue;
            Lb_Password.BackColor = Color.WhiteSmoke;

            //Creacion de los componentes y los atributos correspondientes
            pb.Location = new Point(0, 0);
            pb.Name = "pbx_picture";
            pb.Size = new Size(741, 410);
            pb.TabIndex = 0;
            pb.TabStop = false;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.BackColor = SystemColors.ActiveCaption;
            pb.Image = Image.FromFile("Inicio.jpg");

            btn1.Location = new Point(330, 290);
            btn1.Size = new Size(100, 75);
            btn1.Text = "START";
            btn1.Click += new System.EventHandler(evento1);
            btn1.BackColor = Color.DarkBlue;
            btn1.ForeColor = Color.White;

            lbl1.Text = "ESPERA";
            lbl1.Size = new Size(50, 15);
            lbl1.Location = new Point(450, 320);
            lbl1.ForeColor = Color.DarkBlue;

            Controls.Add(lbl1);
            Controls.Add(btn1);
            Controls.Add(pb);
            pb.Controls.Add(Lb_Password);
            pb.Controls.Add(Lb_Usuario);
            pb.Controls.Add(Tb_Usuario);
            pb.Controls.Add(Tb_Password);
        }
        public void evento1(object sender, EventArgs e)//Evento que ocurrira
        {
            if (Tb_Usuario.Text == "JACOB LUNA" && Tb_Password.Text == "12345678")
            {
                Thread hilo1 = new Thread(Hilo1);//Creacion del hilo
                hilo1.Start();//Inicia el hilo
                Thread.Sleep(3000);//Espera 3 segundos
                this.Hide();//Oculta la forma actual
            }
            else
            {
                MessageBox.Show("ERROR USUARIO O CONTRASEÑA INCORRECTOS","ADVERTENCIA",MessageBoxButtons.OK,MessageBoxIcon.Information
                    );
            }

        }
        public Pantalla_Inicio()
        {
            InitializeComponent();
            Objetos();
        }

        private void Pantalla_Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}

