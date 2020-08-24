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
    public partial class Consultas : Form
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-V2DEJSV\\SQLEXPRESS;Initial Catalog=ALMACN_Estrellas_3;Integrated Security=True");
        Class1 Consultaslabe1 = new Class1();
        Class1 Consultaslabe2 = new Class1();
        Class1 masquedt1 = new Class1();
        Class1 masquedt2 = new Class1();
        Button Conbtn_Checar = new Button();
 
        Class1 VolverConsulta = new Class1();
        Class1 PANEL3 = new Class1();
        Class1 DATAgridVIEW = new Class1();
        Class1 DATAgridVIEW2 = new Class1();
        Button btn_Volver = new Button();
        Panel paneles = new Panel();
        public void CrearBoton()
        {
            //Aqui creamos los metodos para mostra los botones en from...
            Conbtn_Checar.Location = new System.Drawing.Point(0, 100);
            Conbtn_Checar.Name = "btn_Checar";
            Conbtn_Checar.Text = "Checar";
            Conbtn_Checar.Size = new System.Drawing.Size(90, 70);
            Conbtn_Checar.Click += new System.EventHandler(evento_buscar);
            Controls.Add(Conbtn_Checar);
        }
        public void evento_buscar(object sender, EventArgs e)
        {
            MessageBox.Show("Iniciando busqueda", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                if (masquedt1.ConsultaMaskedTexBox1().Text != string.Empty)
                {
                    DataSet tabla = new DataSet();
                    conexion.Open();
                    string consulta = "select * from MOBILIARIO where id_Mobiliario like '%" + masquedt1.ConsultaMaskedTexBox1().Text + "%'";
                    comando = new SqlCommand(consulta, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla, "MOBILIARIO");
                    DATAgridVIEW.ConsultaDatGriid().DataSource = tabla;
                    DATAgridVIEW.ConsultaDatGriid().DataMember = "MOBILIARIO";
                    conexion.Close();
                }
                else if (masquedt2.ConsultaMaskedTexBox2().Text != string.Empty)
                {
                    DataSet tabla2 = new DataSet();
                    conexion.Open();
                    string consulta2 = "select * from PRODUCTOS where id_Producto like '%" + masquedt2.ConsultaMaskedTexBox2().Text + "%'";
                    comando = new SqlCommand(consulta2, conexion);
                    SqlDataAdapter adaptador2 = new SqlDataAdapter(comando);
                    adaptador2.Fill(tabla2, "PRODUCTOS");
                    DATAgridVIEW2.ConsultaDatGriid2().DataSource = tabla2;
                    DATAgridVIEW2.ConsultaDatGriid2().DataMember = "PRODUCTOS";
                    conexion.Close();
                }

                else
                {
                    MessageBox.Show("Datos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception z)
            {

                MessageBox.Show("Error" + z.ToString());
            }
        }
        public Consultas()
        {
            InitializeComponent();
            InitializeComponent();
            Controls.Add(Consultaslabe1.ConsultaLabel1());
            Controls.Add(Consultaslabe2.ConsultaLabel2());
            Controls.Add(masquedt1.ConsultaMaskedTexBox1());
            Controls.Add(masquedt2.ConsultaMaskedTexBox2());
            CrearBoton();
            //Controls.Add(VolverConsulta.ConsultaBotonVolver());
            Controls.Add(DATAgridVIEW.ConsultaDatGriid());
            Controls.Add(DATAgridVIEW2.ConsultaDatGriid2());
            //Controls.Add(PANEL3());
            Botones();
            panel();
        }

        public void Botones()
        {

            btn_Volver.Location = new System.Drawing.Point(0, 200);
            btn_Volver.Name = "btn_volver";
            btn_Volver.Text = "Volver";
            btn_Volver.Size = new System.Drawing.Size(90, 70);
            btn_Volver.Click += new System.EventHandler(evento_clic1);
            Controls.Add(btn_Volver);

        }

        public void panel()
        {
            paneles.Dock = DockStyle.Fill;
            paneles.Location = new Point(0, 0);
            paneles.Name = "Panel";
            paneles.Size = new Size(594, 489);
            paneles.BackColor = Color.YellowGreen;
            Controls.Add(paneles);
        }

        public void evento_clic1(object sender, EventArgs e)
        {

            Form1 Pro = new Form1();
            Pro.Show();
            this.Hide();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            cargar_datagrid(DATAgridVIEW.ConsultaDatGriid());
            cargar_datagrid2(DATAgridVIEW2.ConsultaDatGriid2());
        }
        private void cargar_datagrid(DataGridView mostrar)
        {
            try
            {
                conexion.Open();
                comando = new SqlCommand("select * from MOBILIARIO", conexion);
                SqlDataAdapter union = new SqlDataAdapter(comando);
                DataTable data = new DataTable();
                union.Fill(data);
                mostrar.DataSource = data;
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion.Close();
            }

        }
        private void cargar_datagrid2(DataGridView mostrar)
        {
            try
            {
                conexion.Open();
                comando = new SqlCommand("select * from PRODUCTOS", conexion);
                SqlDataAdapter union = new SqlDataAdapter(comando);
                DataTable data = new DataTable();
                union.Fill(data);
                mostrar.DataSource = data;
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion.Close();
            }

        }
    }
}
