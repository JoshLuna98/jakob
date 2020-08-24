using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Almacen_Libreria3;
using System.Data.SqlClient;

namespace Almacen_Tiempo_de_Ejecucion
{
    public partial class Movbiliario : Form
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-V2DEJSV\\SQLEXPRESS;Initial Catalog=ALMACN_Estrellas_3;Integrated Security=True");
        Class1 labelMovi1 = new Class1();
        Class1 labelMovi2 = new Class1();
        Class1 labelMovi3 = new Class1();
        Class1 labelMovi4 = new Class1();
        Class1 masket1 = new Class1();
        Class1 txtmovi2 = new Class1();
        Class1 txtmovi3 = new Class1();
        Class1 txtmovi4 = new Class1();
        Button BotonMoviliarioGuardadr = new Button();
        Class1 BotonMoviliarioVolver = new Class1();
        Class1 PANEL2 = new Class1();
        Button btn_Volver = new Button();
        Panel paneles2 = new Panel();

        public void crear_Boton()
        {
            BotonMoviliarioGuardadr.Location = new Point(300, 100);
            BotonMoviliarioGuardadr.Name = "btn_Guardar";
            BotonMoviliarioGuardadr.Text = "Guardar";
            BotonMoviliarioGuardadr.Size = new Size(90, 70);
            BotonMoviliarioGuardadr.Click += new System.EventHandler(evento_agregar);
            Controls.Add(BotonMoviliarioGuardadr);
        }
        public void evento_agregar(object sender, EventArgs e)
        {
            //Si todos los campos estan completos guarda el empleado, sino, tiene que completar el formulario

            try
            {
                conexion.Open();
                MessageBox.Show("Conexion establecida con el servidor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comando = new SqlCommand("INSERT INTO MOBILIARIO (id_Mobiliario ,Tipo_Mobiliario,Cantidad_Mobiliario, Descripcion_Moviliario)  VALUES('" + this.masket1.MasketexBoxMobiliario1().Text + "','" + this.txtmovi4.textBoxMobiliario4().Text + " ','" + this.txtmovi2.textBoxMobiliario2().Text + " ','" + this.txtmovi3.textBoxMobiliario3().Text + "')", conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Datos guardados exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();
                MessageBox.Show("Se cerro correctamente la sesion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //cargar_datagrid(data1.datadatos());
            }
            catch (Exception p)
            {
                MessageBox.Show("Error " + p.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion.Close();
            }
        }
        public Movbiliario()
        {
            InitializeComponent();
            crear_Boton();
            Controls.Add(labelMovi1.MobiliarioLabe1());
            Controls.Add(labelMovi2.MobiliarioLabe2());
            Controls.Add(labelMovi3.MobiliarioLabe3());
            Controls.Add(labelMovi4.MobiliarioLabe4());
            Controls.Add(masket1.MasketexBoxMobiliario1());
            Controls.Add(txtmovi2.textBoxMobiliario2());
            Controls.Add(txtmovi3.textBoxMobiliario3());
            Controls.Add(txtmovi4.textBoxMobiliario4());
           
            //Controls.Add(BotonMoviliarioVolver.MobiliarioBotonVolver());
            //Controls.Add(PANEL2.MobiliarioPanel());
            BOTON();
            panel2();
        }

        public void BOTON()
        {


            btn_Volver.Location = new System.Drawing.Point(300, 200);
            btn_Volver.Name = "btn_volver";
            btn_Volver.Text = "Volver";
            btn_Volver.Size = new System.Drawing.Size(90, 70);
            btn_Volver.Click += new System.EventHandler(evento_clic1);
            Controls.Add(btn_Volver);

        }
        public void evento_clic1(object sender, EventArgs e)
        {

            Form1 from2 = new Form1();
            from2.Show();
            this.Hide();

        }
        public void panel2()
        {
            paneles2.Dock = DockStyle.Fill;
            paneles2.Location = new Point(0, 0);
            paneles2.Name = "Panel";
            paneles2.Size = new Size(594, 489);
            paneles2.BackColor = Color.CadetBlue;
            Controls.Add(paneles2);
            //paneles2.Visible = false;


        }

        private void Movbiliario_Load(object sender, EventArgs e)
        {

        }
    }
}
