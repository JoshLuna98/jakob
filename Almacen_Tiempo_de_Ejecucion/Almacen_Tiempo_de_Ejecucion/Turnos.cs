using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Almacen_Libreria1;
using System.Data.SqlClient;

namespace Almacen_Tiempo_de_Ejecucion
{
    public partial class Turnos : Form
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-V2DEJSV\\SQLEXPRESS;Initial Catalog=ALMACN_Estrellas_3;Integrated Security=True");

        Class1 label1 = new Class1();
        Class1 label2 = new Class1();
        Class1 label3 = new Class1();

        Class1 label4 = new Class1();
        Class1 label5 = new Class1();
        Class1 label6 = new Class1();

        Class1 data1 = new Class1();
        Button boton_volver_menu = new Button();
        Button boton_volver = new Button();
        Button boton2 = new Button();
        Button boton3 = new Button();
        Button boton4 = new Button();
        Button boton6 = new Button();
        Button boton7 = new Button();
        Panel Panel_Turno = new Panel();
        TextBox texto1 = new TextBox();
        TextBox texto2 = new TextBox();
        MaskedTextBox mascara1 = new MaskedTextBox();
        MaskedTextBox mascara2 = new MaskedTextBox();
        MaskedTextBox mascara3 = new MaskedTextBox();
        MaskedTextBox mascara4 = new MaskedTextBox();

        public void Componentes_Panel()
        {
            //Componentes del panel
            boton_volver.Location = new System.Drawing.Point(15, 235);
            boton_volver.Name = "boton_volver";
            boton_volver.Size = new System.Drawing.Size(75, 23);
            boton_volver.Text = "Volver";
            boton_volver.TabIndex = 4;
            boton_volver.UseVisualStyleBackColor = true;
            boton_volver.Click += new System.EventHandler(evento_volver);//Evento volver

            texto2.Location = new System.Drawing.Point(189, 13);
            texto2.Name = "Id Turno";
            texto2.TabIndex = 0;
            texto2.Size = new System.Drawing.Size(100, 20);

            mascara3.Location = new System.Drawing.Point(220, 86);
            mascara3.Name = "Tipo Turno";
            mascara3.TabIndex = 1;
            mascara3.Size = new System.Drawing.Size(35, 20);
            mascara3.ValidatingType = typeof(int);

            mascara4.Location = new System.Drawing.Point(220, 159);
            mascara4.Name = "Id Puesto";
            mascara4.Mask = "99999";
            mascara4.TabIndex = 2;
            mascara4.Size = new System.Drawing.Size(35, 20);
            mascara4.ValidatingType = typeof(int);

            boton7.Location = new System.Drawing.Point(331, 74);
            boton7.Name = "button7";
            boton7.Size = new System.Drawing.Size(89, 82);
            boton7.Text = "Agregar Turno";
            boton7.TabIndex = 3;
            boton7.UseVisualStyleBackColor = true;
            boton7.Click += new System.EventHandler(evento_agregar);//El evento guarda los proveedores

            //Agregar los componentes al panel
            Panel_Turno.Controls.Add(boton_volver);
            Panel_Turno.Controls.Add(boton7);
            Panel_Turno.Controls.Add(label4.label1_Turnos_P());//Invocar el objeto de la forma y su funcion con las propiedades, 
            ////igual para los demas labels
            Panel_Turno.Controls.Add(label5.label2_Turnos_P());
            Panel_Turno.Controls.Add(label6.label3_Turnos_P());
            Panel_Turno.Controls.Add(texto2);
            Panel_Turno.Controls.Add(mascara3);
            Panel_Turno.Controls.Add(mascara4);
        }
        public void evento_agregar(object sender, EventArgs e)
        {
            //Agrega un proveedor solo si todos los campos estan llenos
            if (!string.IsNullOrWhiteSpace(texto2.Text) && !string.IsNullOrWhiteSpace(mascara3.Text) && !string.IsNullOrWhiteSpace(mascara4.Text))
            {
                try
                {
                    conexion.Open();
                    MessageBox.Show("Conexion establecida con el servidor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comando = new SqlCommand("INSERT INTO TURNO_DEL_TRABAJADOR (id_Turno, Tipo_Turno,id_Puesto)  VALUES('" + this.texto2.Text + " ','" + this.mascara3.Text + " ','" + this.mascara4.Text + "')", conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Close();
                    MessageBox.Show("Se cerro correctamente la sesion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar_datagrid(data1.dataturnos());
                }
                catch (Exception p)
                {
                    MessageBox.Show("Error " + p.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Datos incompletos, revise el formulario", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void evento_volver(object sender, EventArgs e)
        {
            //Hace invisible el panel
            Panel_Turno.Visible = false;

            data1.dataturnos().Visible = true;
            label1.label1_Turnos().Visible = true;
            label2.label2_Turnos().Visible = true;
            label3.label3_Turnos().Visible = true;
            mascara1.Visible = true;
            mascara2.Visible = true;
            texto1.Visible = true;

            boton_volver_menu.Visible = true;
            boton2.Visible = true;
            boton3.Visible = true;
            boton4.Visible = true;
            boton6.Visible = true;
            cargar_datagrid(data1.dataturnos());
        }
       
        public void TextyMascaras()
        {
            //Crear los textbox y las mascaras
            texto1.Location = new System.Drawing.Point(131, 8);
            texto1.Name = "ID Turno";
            texto1.TabIndex = 0;
            texto1.Size = new System.Drawing.Size(35, 20);


            mascara1.Location = new System.Drawing.Point(100, 50);
            mascara1.Name = "Tipo:";
            mascara1.TabIndex = 1;
            mascara1.Size = new System.Drawing.Size(100, 20);
            mascara1.ValidatingType = typeof(int);

            mascara2.Location = new System.Drawing.Point(149, 95);
            mascara2.TabIndex = 2;
            mascara2.Name = "Puesto";
            mascara2.Size = new System.Drawing.Size(35, 20);
            mascara2.ValidatingType = typeof(int);

            //Agregar los textbox y las mascaras a la forma
            Controls.Add(texto1);
            Controls.Add(texto2);
            Controls.Add(mascara1);
            Controls.Add(mascara2);
            
        }
        public Turnos()
        {
            
            InitializeComponent();
            Controls.Add(label1.label1_Turnos());
            Controls.Add(label2.label2_Turnos());
            Controls.Add(label3.label3_Turnos());
            Controls.Add(data1.dataturnos());
            Crear_Botones();
            TextyMascaras();
            Crear_Panel();
            Componentes_Panel();
        }
        public void Crear_Botones()
        {
            //Creacion de los botones
            boton_volver_menu.Location = new System.Drawing.Point(12, 268);
            boton_volver_menu.Name = "button1";
            boton_volver_menu.Size = new System.Drawing.Size(75, 23);
            boton_volver_menu.Text = "Volver";
            boton_volver_menu.TabIndex = 8;
            boton_volver_menu.UseVisualStyleBackColor = true;
            boton_volver_menu.Click += new System.EventHandler(evento_volver_menu);//Evento para volver al inicio

            boton2.Location = new System.Drawing.Point(496, 90);
            boton2.Name = "button2";
            boton2.Size = new System.Drawing.Size(75, 66);
            boton2.Text = "Nuevo Turno";
            boton2.TabIndex = 6;
            boton2.UseVisualStyleBackColor = true;
            boton2.Click += new System.EventHandler(evento_nuevo_turno);//Muestra el panel

            boton3.Location = new System.Drawing.Point(260, 12);
            boton3.Name = "button3";
            boton3.Size = new System.Drawing.Size(75, 23);
            boton3.Text = "Modificar";
            boton3.TabIndex = 4;
            boton3.UseVisualStyleBackColor = true;
            boton3.Click += new System.EventHandler(evento_modificar);//Musetra el boton de guardar cambios

            boton4.Location = new System.Drawing.Point(368, 12);
            boton4.Name = "button4";
            boton4.Size = new System.Drawing.Size(75, 23);
            boton4.Text = "Borrar";
            boton4.TabIndex = 5;
            boton4.UseVisualStyleBackColor = true;
            boton4.Click += new System.EventHandler(evento_borrar);//Limpia los campos de la forma

            //boton5.Location = new System.Drawing.Point(307, 204);
            //boton5.Name = "btn_gc_prov";
            //boton5.Size = new System.Drawing.Size(75, 64);
            //boton5.Text = "Guardar Cambios";
            //boton5.TabIndex = 7;
            //boton5.UseVisualStyleBackColor = true;
            //boton5.Visible = false;

            boton6.Location = new System.Drawing.Point(68, 160);
            boton6.Name = "button6";
            boton6.Size = new System.Drawing.Size(75, 23);
            boton6.Text = "Buscar";
            boton6.TabIndex = 3;
            boton6.UseVisualStyleBackColor = true;
            boton6.Click += new System.EventHandler(evento_buscar);//Busca el proveedor
            //Agregar los botones a la forma
            Controls.Add(boton_volver_menu);
            Controls.Add(boton2);
            Controls.Add(boton2);
            Controls.Add(boton3);
            Controls.Add(boton4);

            Controls.Add(boton6);
        }
        public void evento_modificar(object sender, EventArgs e)
        {
            int id = data1.dataturnos().SelectedCells[0].RowIndex;
            actualiza_grid(id + 1);
            data1.dataturnos().Refresh();
        }
        private void actualiza_grid(int id)
        {
            int renglon = data1.dataturnos().SelectedCells[0].RowIndex;
            string tipo_turno = data1.dataturnos().Rows[renglon].Cells[1].Value.ToString();
            conexion.Open();
            string consulta = "update TURNO_DEL_TRABAJADOR set Tipo_Turno = '" + tipo_turno + "' where id_Turno=" + id;
            comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void evento_borrar(object sender, EventArgs e)
        {
            int pos;
            if (data1.dataturnos().Rows.Count == 0)
            {
                MessageBox.Show("NO HAY ELEMENTOS");
            }
            else
            {
                pos = data1.dataturnos().CurrentRow.Index;
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar El ID Turno " + data1.dataturnos()[0, pos].Value.ToString() + " ?", "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    conexion.Open();
                    string cadena = "delete from  TURNO_DEL_TRABAJADOR where id_Turno=" + data1.dataturnos()[0, pos].Value.ToString();
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Se borró el Turno con id " + data1.dataturnos()[0, pos].Value.ToString());
                    conexion.Close();
                    cargar_datagrid(data1.dataturnos());
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("No se elimino");
                }
            }
        }
        public void evento_buscar(object sender, EventArgs e)
        {
            MessageBox.Show("Iniciando busqueda", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                if (texto1.Text != string.Empty)
                {
                    DataSet tabla = new DataSet();
                    conexion.Open();
                    string consulta = "select * from TURNO_DEL_TRABAJADOR where id_Turno like '%" + texto1.Text + "%'";
                    comando = new SqlCommand(consulta, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla, "TURNO_DEL_TRABAJADOR");
                    data1.dataturnos().DataSource = tabla;
                    data1.dataturnos().DataMember = "TURNO_DEL_TRABAJADOR";
                    data1.dataturnos().Refresh();
                    conexion.Close();
                }
                else if (mascara1.Text != string.Empty)
                {
                    DataSet tabla2 = new DataSet();
                    conexion.Open();
                    string consulta2 = "select * from TURNO_DEL_TRABAJADOR where Tipo_Turno like '%" + mascara1.Text + "%'";
                    comando = new SqlCommand(consulta2, conexion);
                    SqlDataAdapter adaptador2 = new SqlDataAdapter(comando);
                    adaptador2.Fill(tabla2, "TURNO_DEL_TRABAJADOR");
                    data1.dataturnos().DataSource = tabla2;
                    data1.dataturnos().DataMember = "TURNO_DEL_TRABAJADOR";
                    data1.dataturnos().Refresh();
                    conexion.Close();
                }
                else if (mascara2.Text != string.Empty)
                {
                    DataSet tabla3 = new DataSet();
                    conexion.Open();
                    string consulta3 = "select * from TURNO_DEL_TRABAJADOR where id_Puesto like '%" + mascara2.Text + "%'";
                    comando = new SqlCommand(consulta3, conexion);
                    SqlDataAdapter adaptador3 = new SqlDataAdapter(comando);
                    adaptador3.Fill(tabla3, "TURNO_DEL_TRABAJADOR");
                    data1.dataturnos().DataSource = tabla3;
                    data1.dataturnos().DataMember = "TURNO_DEL_TRABAJADOR";
                    data1.dataturnos().Refresh();
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
        public void Crear_Panel()
        {
            //Crea el panel de proveedores
            Panel_Turno.Location = new System.Drawing.Point(0, 0);
            Panel_Turno.Name = "Panel_Turno";
            Panel_Turno.Size = new System.Drawing.Size(593, 309);
            Panel_Turno.Visible = false;//Esta invisible hasta hacer clic en el boton de nuevo proveedor
            Panel_Turno.BackColor = Color.Blue;
            Controls.Add(Panel_Turno);
        }
        public void evento_nuevo_turno(object sender, EventArgs e)
        {
            //Hace invisible el panel
            Panel_Turno.Visible = true;

            data1.dataturnos().Visible = false;
            label1.label1_Turnos().Visible = false;
            label2.label2_Turnos().Visible = false;
            label3.label3_Turnos().Visible = false;
            mascara1.Visible = false;
            mascara2.Visible = false;
            texto1.Visible = false;
            

            boton_volver_menu.Visible = false;
            boton2.Visible = false;
            boton3.Visible = false;
            boton4.Visible = false;
            boton6.Visible = false;
            //cargar_datagrid(data1.dataproveedores());
        }
        public void evento_volver_menu(object sender, EventArgs e)
        {
            //Oculta la forma actual y muestra la de inicio
            Form1 almacen = new Form1();
            almacen.Show();
            this.Hide();
        }
        private void Turnos_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            cargar_datagrid(data1.dataturnos());
        }
        private void cargar_datagrid(DataGridView mostrar)
        {
            try
            {
                conexion.Open();
                comando = new SqlCommand("select * from TURNO_DEL_TRABAJADOR", conexion);
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
