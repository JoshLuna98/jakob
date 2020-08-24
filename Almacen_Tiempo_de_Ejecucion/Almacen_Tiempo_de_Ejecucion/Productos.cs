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
    public partial class Productos : Form
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-V2DEJSV\\SQLEXPRESS;Initial Catalog=ALMACN_Estrellas_3;Integrated Security=True");
        Class1 label1Pro = new Class1();
        Class1 label2Pro = new Class1();
        Class1 label3Pro = new Class1();
        Class1 label4Pro = new Class1();
        Class1 label5Pro = new Class1();
        Class1 label6Pro = new Class1();
        Class1 masket1 = new Class1();
        Class1 txt1 = new Class1();
        Class1 txt2 = new Class1();
        Class1 txt3 = new Class1();
        Class1 txt4 = new Class1();
        Class1 txt5 = new Class1();
        Button BotonGuardad = new Button();
        Class1 BotonVolver = new Class1();
        Class1 PANEL1 = new Class1();
        Button ProBtn_Volver = new Button();
        Panel paneles = new Panel();
        public void crear_Boton()
        {
            BotonGuardad.Location = new System.Drawing.Point(300, 100);
            BotonGuardad.Name = "btn_Guardar";
            BotonGuardad.Text = "Guardar";
            BotonGuardad.Size = new System.Drawing.Size(90, 70);
            BotonGuardad.Click += new System.EventHandler(evento_agregar);
            Controls.Add(BotonGuardad);
        }
      
        public void evento_agregar(object sender, EventArgs e)
        {
            //Si todos los campos estan completos guarda el empleado, sino, tiene que completar el formulario
            
                try
                {
                    conexion.Open();
                    MessageBox.Show("Conexion establecida con el servidor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comando = new SqlCommand("INSERT INTO PRODUCTOS (id_Producto ,Precio,Cantidad_Producto, Marca_Producto,Descripcin_Producto,Garantia)  VALUES('" + this.masket1.productosmaskedTexBox().Text + "','"+this.txt3.productosTexBox3().Text+" ','" + this.txt1.productosTexBox1().Text + " ','" + this.txt4.productosTexBox4().Text + " ','" + this.txt2.productosTexBox2().Text + " ','" + this.txt5.productosTexBox5().Text + "')", conexion);
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

        static void Hilo2()
        {
            MessageBox.Show("Please.. stand by");
        }
        public Productos()
        {
            InitializeComponent();
            crear_Boton();
            Controls.Add(label1Pro.ProductosLabel1());
            Controls.Add(label2Pro.ProductosLabel2());
            Controls.Add(label3Pro.ProductosLabel3());
            Controls.Add(label4Pro.ProductosLabel4());
            Controls.Add(label5Pro.ProductosLabel5());
            Controls.Add(label6Pro.ProductosLabel6());
            Controls.Add(masket1.productosmaskedTexBox());
            Controls.Add(txt1.productosTexBox1());
            Controls.Add(txt2.productosTexBox2());
            Controls.Add(txt3.productosTexBox3());
            Controls.Add(txt4.productosTexBox4());
            Controls.Add(txt5.productosTexBox5());
            //Controls.Add(BotonVolver.volver());
            //Controls.Add(PANEL1.Panel1());
            volver1();
            panel1();
            
        }

        public void panel1()
        {
            paneles.Dock = DockStyle.Fill;
            paneles.Location = new Point(0, 0);
            paneles.Name = "Panel";
            paneles.Size = new Size(594, 489);
            paneles.BackColor = Color.CadetBlue;
            Controls.Add(paneles);
        }
        public void volver1()
        {
            // Aqui creamos los metodos para mostra los Botones en from...

            ProBtn_Volver.Location = new System.Drawing.Point(300, 200);
            ProBtn_Volver.Name = "btn_volver";
            ProBtn_Volver.Text = "Volver";
            ProBtn_Volver.Size = new System.Drawing.Size(90, 70);
            ProBtn_Volver.Click += new System.EventHandler(evento_clic1);
            Controls.Add(ProBtn_Volver);

        }
        public void evento_clic1(object sender, EventArgs e)
        {
            
            
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }
    }
}