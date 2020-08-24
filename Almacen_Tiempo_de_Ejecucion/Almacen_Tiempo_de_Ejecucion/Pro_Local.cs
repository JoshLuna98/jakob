using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Almacen_Libreria1;

namespace Almacen_Tiempo_de_Ejecucion
{
    public partial class Pro_Local : Form
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-V2DEJSV\\SQLEXPRESS;Initial Catalog=ALMACN_Estrellas_3;Integrated Security=True");
        Class1 label1 = new Class1();
        Class1 label2 = new Class1();
        Class1 label3 = new Class1();
        Class1 label4 = new Class1();
        Class1 data1 = new Class1();
        Button boton1 = new Button();
        Button boton2 = new Button();
        Button boton3 = new Button();
        Button boton4 = new Button();
        Button boton6 = new Button();
        Button boton7 = new Button();
        Button boton_volver = new Button();
        MaskedTextBox mascara1 = new MaskedTextBox();
        MaskedTextBox mascara2 = new MaskedTextBox();
        MaskedTextBox mascara3 = new MaskedTextBox();
        MaskedTextBox mascara4 = new MaskedTextBox();
        Panel Panel_Pro_Local = new Panel();
        public Pro_Local()
        {
            InitializeComponent();
            this.BackColor = Color.Chocolate;
            Controls.Add(data1.dataprolocal());
            Controls.Add(label1.label1_Pro_Local());
            Controls.Add(label2.label2_Pro_Local());
            TextyMascaras();
            Crear_Botones();
            Crear_Panel();
            Componentes_Panel();
        }
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

            mascara3.Location = new System.Drawing.Point(189, 13);
            mascara3.Name = "id_proveedor";
            mascara3.Mask = "99999";
            mascara3.TabIndex = 1;
            mascara3.Size = new System.Drawing.Size(35, 20);
            mascara3.ValidatingType = typeof(int);




            mascara4.Location = new System.Drawing.Point(189, 86);
            mascara4.Name = "id_proveedor";
            mascara4.Mask = "99999";
            mascara4.TabIndex = 1;
            mascara4.Size = new System.Drawing.Size(35, 20);
            mascara4.ValidatingType = typeof(int);

           
            boton7.Location = new System.Drawing.Point(331, 74);
            boton7.Name = "button7";
            boton7.Size = new System.Drawing.Size(89, 82);
            boton7.Text = "Agregar Proveedor";
            boton7.TabIndex = 3;
            boton7.UseVisualStyleBackColor = true;
            boton7.Click += new System.EventHandler(evento_agregar);//El evento guarda los proveedores

            //Agregar los componentes al panel
            Panel_Pro_Local.Controls.Add(boton_volver);
            Panel_Pro_Local.Controls.Add(boton7);
            Panel_Pro_Local.Controls.Add(label3.label1_Pro_Local_P());//Invocar el objeto de la forma y su funcion con las propiedades, 
            //                                                     ////igual para los demas labels
            Panel_Pro_Local.Controls.Add(label4.label2_Pro_Local_P());
            Panel_Pro_Local.Controls.Add(mascara3);
            Panel_Pro_Local.Controls.Add(mascara4);
        }
        public void evento_agregar(object sender, EventArgs e)
        {
            //Agrega un proveedor solo si todos los campos estan llenos
            if (!string.IsNullOrWhiteSpace(mascara3.Text) && !string.IsNullOrWhiteSpace(mascara4.Text))
            {
                try
                {
                    conexion.Open();
                    MessageBox.Show("Conexion establecida con el servidor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comando = new SqlCommand("INSERT INTO PROVEEDOR_LOCAL (id_Proveedor_Local, id_Datos)  VALUES('" + this.mascara3.Text + " ','" + this.mascara4.Text + "')", conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Close();
                    MessageBox.Show("Se cerro correctamente la sesion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar_datagrid(data1.dataprolocal());
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
            Panel_Pro_Local.Visible = false;

            data1.dataprolocal().Visible = true;
            label1.label1_Pro_Local().Visible = true;
            label2.label2_Pro_Local().Visible = true;

            mascara1.Visible = true;
            mascara2.Visible = true;

            boton1.Visible = true;
            boton2.Visible = true;
            boton3.Visible = true;
            boton4.Visible = true;
            boton6.Visible = true;
            cargar_datagrid(data1.dataprolocal());
        }
        public void Crear_Panel()
        {
            //Crea el panel de proveedores
            Panel_Pro_Local.Location = new System.Drawing.Point(0, 0);
            Panel_Pro_Local.Name = "Panel_Proveedores";
            Panel_Pro_Local.Size = new System.Drawing.Size(593, 309);
            Panel_Pro_Local.Visible = false;//Esta invisible hasta hacer clic en el boton de nuevo proveedor
            Panel_Pro_Local.BackColor = Color.Blue;
            Controls.Add(Panel_Pro_Local);
        }
        public void Crear_Botones()
        {
            //Creacion de los botones
            boton1.Location = new System.Drawing.Point(12, 268);
            boton1.Name = "button1";
            boton1.Size = new System.Drawing.Size(75, 23);
            boton1.Text = "Volver";
            boton1.TabIndex = 8;
            boton1.UseVisualStyleBackColor = true;
            boton1.Click += new System.EventHandler(evento_volver_menu);//Evento para volver al inicio

            boton2.Location = new System.Drawing.Point(496, 90);
            boton2.Name = "button2";
            boton2.Size = new System.Drawing.Size(75, 66);
            boton2.Text = "Nuevo Proveedor";
            boton2.TabIndex = 6;
            boton2.UseVisualStyleBackColor = true;
            boton2.Click += new System.EventHandler(evento_nuevo_pro_local);//Muestra el panel

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

    

            boton6.Location = new System.Drawing.Point(68, 160);
            boton6.Name = "button6";
            boton6.Size = new System.Drawing.Size(75, 23);
            boton6.Text = "Buscar";
            boton6.TabIndex = 3;
            boton6.UseVisualStyleBackColor = true;
            boton6.Click += new System.EventHandler(evento_buscar);//Busca el proveedor
            //Agregar los botones a la forma
            Controls.Add(boton1);
            Controls.Add(boton2);
            Controls.Add(boton3);
            Controls.Add(boton4);
            Controls.Add(boton6);
        }
        public void evento_modificar(object sender, EventArgs e)
        {
            int id = data1.dataprolocal().SelectedCells[0].RowIndex;
            actualiza_grid(id + 1);
            data1.dataprolocal().Refresh();
        }
        private void actualiza_grid(int id)
        {
            int renglon = data1.dataprolocal().SelectedCells[0].RowIndex;
            string datos = data1.dataprolocal().Rows[renglon].Cells[1].Value.ToString();
            conexion.Open();
            string consulta = "update PROVEEDOR_LOCAL set id_Datos = '" + datos + "' where id_Proveedor_Local=" + id;
            comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void evento_borrar(object sender, EventArgs e)
        {
            int pos;
            if (data1.dataprolocal().Rows.Count == 0)
            {
                MessageBox.Show("NO HAY ELEMENTOS");
            }
            else
            {
                pos = data1.dataprolocal().CurrentRow.Index;
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar El ID Proveedor " + data1.dataprolocal()[0, pos].Value.ToString() + " ?", "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    conexion.Open();
                    string cadena = "delete from PROVEEDOR_LOCAL where id_Proveedor_Local=" + data1.dataprolocal()[0, pos].Value.ToString();
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Se borró el Proveedor con id " + data1.dataprolocal()[0, pos].Value.ToString());
                    conexion.Close();
                    cargar_datagrid(data1.dataprolocal());
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
                if (mascara1.Text != string.Empty)
                {
                    DataSet tabla = new DataSet();
                    conexion.Open();
                    string consulta = "select * from PROVEEDOR_LOCAL where id_Proveedor_Local like '%" + mascara1.Text + "%'";
                    comando = new SqlCommand(consulta, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla, "PROVEEDOR_LOCAL");
                    data1.dataprolocal().DataSource = tabla;
                    data1.dataprolocal().DataMember = "PROVEEDOR_LOCAL";
                    data1.dataprolocal().Refresh();
                    conexion.Close();
                }
                else if (mascara2.Text != string.Empty)
                {
                    DataSet tabla2 = new DataSet();
                    conexion.Open();
                    string consulta2 = "select * from PROVEEDOR_LOCAL where id_Datos like '%" + mascara2.Text + "%'";
                    comando = new SqlCommand(consulta2, conexion);
                    SqlDataAdapter adaptador2 = new SqlDataAdapter(comando);
                    adaptador2.Fill(tabla2, "PROVEEDOR_LOCAL");
                    data1.dataprolocal().DataSource = tabla2;
                    data1.dataprolocal().DataMember = "PROVEEDOR_LOCAL";
                    data1.dataprolocal().Refresh();
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
        public void evento_nuevo_pro_local(object sender, EventArgs e)
        {
            //Activa el panel y oculta los componentes de la forma
            Panel_Pro_Local.Visible = true;

            data1.dataprolocal().Visible = false;
            label1.label1_Pro_Local().Visible = false;
            label2.label2_Pro_Local().Visible = false;

            mascara1.Visible = false;
            mascara2.Visible = false;

            boton1.Visible = false;
            boton2.Visible = false;
            boton3.Visible = false;
            boton4.Visible = false;
            boton6.Visible = false;
           
        }
        public void evento_volver_menu(object sender, EventArgs e)
        {
            //Oculta la forma actual y muestra la de inicio
            Form1 almacen = new Form1();
            almacen.Show();
            this.Hide();
        }
        public void TextyMascaras()
        {
            //Crear los textbox y las mascaras

            mascara1.Location = new System.Drawing.Point(149, 10);
            mascara1.Mask = "99999";
            mascara1.Name = "id_ticket";
            mascara1.TabIndex = 1;
            mascara1.Size = new System.Drawing.Size(35, 20);
            mascara1.ValidatingType = typeof(int);

            mascara2.Location = new System.Drawing.Point(149, 55);
            mascara2.Mask = "99999";
            mascara2.TabIndex = 2;
            mascara2.Name = "id_venta";
            mascara2.Size = new System.Drawing.Size(35, 20);
            mascara2.ValidatingType = typeof(int);

            //Agregar los textbox y las mascaras a la forma
            Controls.Add(mascara1);
            Controls.Add(mascara2);
        }

        private void Pro_Local_Load(object sender, EventArgs e)
        {
            cargar_datagrid(data1.dataprolocal());
        }
        private void cargar_datagrid(DataGridView mostrar)
        {
            try
            {
                conexion.Open();
                comando = new SqlCommand("select * from PROVEEDOR_LOCAL", conexion);
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
