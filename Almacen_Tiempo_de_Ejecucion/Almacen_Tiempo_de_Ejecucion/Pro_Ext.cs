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
    public partial class Pro_Ext : Form
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
        Panel Panel_Pro_Ext = new Panel();
        public Pro_Ext()
        {
            InitializeComponent();
            this.BackColor = Color.Chocolate;
            Controls.Add(data1.dataproext());
            Controls.Add(label1.label1_Pro_Ext());
            Controls.Add(label2.label2_Pro_Ext());
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
            Panel_Pro_Ext.Controls.Add(boton_volver);
            Panel_Pro_Ext.Controls.Add(boton7);
            Panel_Pro_Ext.Controls.Add(label3.label1_Pro_Ext_P());//Invocar el objeto de la forma y su funcion con las propiedades, 
            //                                                     ////igual para los demas labels
            Panel_Pro_Ext.Controls.Add(label4.label2_Pro_Ext_P());
            Panel_Pro_Ext.Controls.Add(mascara3);
            Panel_Pro_Ext.Controls.Add(mascara4);
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
                    comando = new SqlCommand("INSERT INTO PROVEEDOR_EXTRANGEROS (id_Proveedor_EXTRANGEROS, id_Datos)  VALUES('" + this.mascara3.Text + " ','" + this.mascara4.Text + "')", conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Close();
                    MessageBox.Show("Se cerro correctamente la sesion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar_datagrid(data1.dataproext());
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
            Panel_Pro_Ext.Visible = false;

            data1.dataproext().Visible = true;
            label1.label1_Pro_Ext().Visible = true;
            label2.label2_Pro_Ext().Visible = true;

            mascara1.Visible = true;
            mascara2.Visible = true;

            boton1.Visible = true;
            boton2.Visible = true;
            boton3.Visible = true;
            boton4.Visible = true;
            boton6.Visible = true;
            cargar_datagrid(data1.dataproext());
        }
        public void Crear_Panel()
        {
            //Crea el panel de proveedores
            Panel_Pro_Ext.Location = new System.Drawing.Point(0, 0);
            Panel_Pro_Ext.Name = "Panel_Proveedores_Ext";
            Panel_Pro_Ext.Size = new System.Drawing.Size(593, 309);
            Panel_Pro_Ext.Visible = false;//Esta invisible hasta hacer clic en el boton de nuevo proveedor
            Panel_Pro_Ext.BackColor = Color.Blue;
            Controls.Add(Panel_Pro_Ext);
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
            boton2.Click += new System.EventHandler(evento_nuevo_pro_ext);//Muestra el panel

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
            int id = data1.dataproext().SelectedCells[0].RowIndex;
            actualiza_grid(id + 1);
            data1.dataproext().Refresh();
        }
        private void actualiza_grid(int id)
        {
            int renglon = data1.dataproext().SelectedCells[0].RowIndex;
            string datos = data1.dataproext().Rows[renglon].Cells[1].Value.ToString();
            conexion.Open();
            string consulta = "update PROVEEDOR_EXTRANGEROS set id_Datos = '" + datos + "' where id_Proveedor_EXTRANGEROS=" + id;
            comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void evento_borrar(object sender, EventArgs e)
        {
            int pos;
            if (data1.dataproext().Rows.Count == 0)
            {
                MessageBox.Show("NO HAY ELEMENTOS");
            }
            else
            {
                pos = data1.dataproext().CurrentRow.Index;
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar El ID Proveedor " + data1.dataproext()[0, pos].Value.ToString() + " ?", "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    conexion.Open();
                    string cadena = "delete from PROVEEDOR_EXTRANGEROS where id_Proveedor_EXTRANGEROS=" + data1.dataproext()[0, pos].Value.ToString();
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Se borró el Proveedor con id " + data1.dataproext()[0, pos].Value.ToString());
                    conexion.Close();
                    cargar_datagrid(data1.dataproext());
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
                    string consulta = "select * from PROVEEDOR_EXTRANGEROS where id_Proveedor_EXTRANGEROS like '%" + mascara1.Text + "%'";
                    comando = new SqlCommand(consulta, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla, "PROVEEDOR_EXTRANGEROS");
                    data1.dataproext().DataSource = tabla;
                    data1.dataproext().DataMember = "PROVEEDOR_EXTRANGEROS";
                    data1.dataproext().Refresh();
                    conexion.Close();
                }
                else if (mascara2.Text != string.Empty)
                {
                    DataSet tabla2 = new DataSet();
                    conexion.Open();
                    string consulta2 = "select * from PROVEEDOR_EXTRANGEROS where id_Datos like '%" + mascara2.Text + "%'";
                    comando = new SqlCommand(consulta2, conexion);
                    SqlDataAdapter adaptador2 = new SqlDataAdapter(comando);
                    adaptador2.Fill(tabla2, "PROVEEDOR_EXTRANGEROS");
                    data1.dataproext().DataSource = tabla2;
                    data1.dataproext().DataMember = "PROVEEDOR_EXTRANGEROS";
                    data1.dataproext().Refresh();
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
        public void evento_volver_menu(object sender, EventArgs e)
        {
            //Oculta la forma actual y muestra la de inicio
            Form1 almacen = new Form1();
            almacen.Show();
            this.Hide();
        }
        public void evento_nuevo_pro_ext(object sender, EventArgs e)
        {
            //Activa el panel y oculta los componentes de la forma
            Panel_Pro_Ext.Visible = true;

            data1.dataproext().Visible = false;
            label1.label1_Pro_Ext().Visible = false;
            label2.label2_Pro_Ext().Visible = false;

            mascara1.Visible = false;
            mascara2.Visible = false;

            boton1.Visible = false;
            boton2.Visible = false;
            boton3.Visible = false;
            boton4.Visible = false;
            boton6.Visible = false;

        }
        public void TextyMascaras()
        {
            //Crear los textbox y las mascaras

            mascara1.Location = new System.Drawing.Point(160, 10);
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

        private void Pro_Ext_Load(object sender, EventArgs e)
        {
            cargar_datagrid(data1.dataproext());
        }
        private void cargar_datagrid(DataGridView mostrar)
        {
            try
            {
                conexion.Open();
                comando = new SqlCommand("select * from PROVEEDOR_EXTRANGEROS", conexion);
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
