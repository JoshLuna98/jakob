using Almacen_Libreria1;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Almacen_Tiempo_de_Ejecucion
{
    public partial class Compras : Form
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
        MaskedTextBox mascara1 = new MaskedTextBox();
        MaskedTextBox mascara2 = new MaskedTextBox();
        MaskedTextBox mascara3 = new MaskedTextBox();
        MaskedTextBox mascara4 = new MaskedTextBox();
        MaskedTextBox mascara5 = new MaskedTextBox();
        MaskedTextBox mascara6 = new MaskedTextBox();
        Button boton1 = new Button();
        Button boton2 = new Button();
        Button boton3 = new Button();
        Button boton4 = new Button();
        Button boton5 = new Button();
        Button boton6 = new Button();
        Button boton7 = new Button();
        Button boton_volver = new Button();
        Panel Panel_Compras = new Panel();
        public void Crear_Panel()
        {
            //Crea el panel de proveedores
            Panel_Compras.Location = new System.Drawing.Point(0, 0);
            Panel_Compras.Name = "puesto";
            Panel_Compras.Size = new System.Drawing.Size(593, 309);
            Panel_Compras.Visible = false;//Esta invisible hasta hacer clic en el boton de nuevo proveedor
            Panel_Compras.BackColor = Color.Blue;
            Controls.Add(Panel_Compras);
        }
        public Compras()
        {
            InitializeComponent();
            this.BackColor = Color.Chocolate;
            Controls.Add(data1.datacompras());
            Controls.Add(label1.label1_Compras());
            Controls.Add(label2.label2_Compras());
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

            mascara4.Location = new System.Drawing.Point(189, 66);
            mascara4.Name = "id_datos";
            mascara4.Mask = "99999";
            mascara4.TabIndex = 2;
            mascara4.Size = new System.Drawing.Size(35, 20);
            mascara4.ValidatingType = typeof(int);

            mascara5.Location = new System.Drawing.Point(189, 120);
            mascara5.Name = "id_datos";
            mascara5.Mask = "99999";
            mascara5.TabIndex = 2;
            mascara5.Size = new System.Drawing.Size(35, 20);
            mascara5.ValidatingType = typeof(int);

            mascara6.Location = new System.Drawing.Point(189, 170);
            mascara6.Name = "id_datos";
            mascara6.Mask = "99999";
            mascara6.TabIndex = 2;
            mascara6.Size = new System.Drawing.Size(35, 20);
            mascara6.ValidatingType = typeof(int);

            boton7.Location = new System.Drawing.Point(331, 74);
            boton7.Name = "button7";
            boton7.Size = new System.Drawing.Size(89, 82);
            boton7.Text = "Agregar Datos";
            boton7.TabIndex = 3;
            boton7.UseVisualStyleBackColor = true;
            boton7.Click += new System.EventHandler(evento_agregar);//El evento guarda los proveedores

            ////////Agregar los componentes al panel
            Panel_Compras.Controls.Add(boton_volver);
            Panel_Compras.Controls.Add(boton7);
            Panel_Compras.Controls.Add(label3.label1_Compras_P());//Invocar el objeto de la forma y su funcion con las propiedades, 
            Panel_Compras.Controls.Add(label4.label2_Compras_P());
            Panel_Compras.Controls.Add(label5.label3_Compras_P());
            Panel_Compras.Controls.Add(label6.label4_Compras_P());
            Panel_Compras.Controls.Add(mascara3);
            Panel_Compras.Controls.Add(mascara4);
            Panel_Compras.Controls.Add(mascara5);
            Panel_Compras.Controls.Add(mascara6);
        }
        public void evento_agregar(object sender, EventArgs e)
        {
            //Agrega un proveedor solo si todos los campos estan llenos
            if (!string.IsNullOrWhiteSpace(mascara3.Text) && !string.IsNullOrWhiteSpace(mascara4.Text) && !string.IsNullOrWhiteSpace(mascara5.Text) && !string.IsNullOrWhiteSpace(mascara6.Text))
            {
                try
                {
                    conexion.Open();
                    MessageBox.Show("Conexion establecida con el servidor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comando = new SqlCommand("INSERT INTO COMPRAS (id_Compra, id_Producto,id_Proveedores,id_Cotizaciones)  VALUES('" + this.mascara3.Text + " ','" + this.mascara4.Text + "','" + this.mascara5.Text + "','" + this.mascara6.Text + "')", conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Close();
                    MessageBox.Show("Se cerro correctamente la sesion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar_datagrid(data1.datacompras());
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
            Panel_Compras.Visible = false;

            data1.datacompras().Visible = true;
            label1.label1_Compras().Visible = true;
            label2.label2_Compras().Visible = true;

            mascara1.Visible = true;
            mascara2.Visible = true;


            boton1.Visible = true;
            boton2.Visible = true;
            boton3.Visible = true;
            boton4.Visible = true;
            boton6.Visible = true;
            cargar_datagrid(data1.datacompras());
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
            boton2.Text = "Nueva Compra";
            boton2.TabIndex = 6;
            boton2.UseVisualStyleBackColor = true;
            boton2.Click += new System.EventHandler(evento_nueva_compra);//Muestra el panel

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
            Controls.Add(boton1);
            Controls.Add(boton2);
            Controls.Add(boton3);
            Controls.Add(boton4);
            Controls.Add(boton6);
        }
        public void evento_modificar(object sender, EventArgs e)
        {
            int id = data1.datacompras().SelectedCells[0].RowIndex;
            actualiza_grid(id + 1);
            data1.datacompras().Refresh();
        }
        private void actualiza_grid(int id)
        {
            int renglon = data1.datacompras().SelectedCells[0].RowIndex;
            string pro = data1.datacompras().Rows[renglon].Cells[1].Value.ToString();
            string provee = data1.datacompras().Rows[renglon].Cells[2].Value.ToString();
            string cot = data1.datacompras().Rows[renglon].Cells[3].Value.ToString();
            conexion.Open();
            string consulta = "update COMPRAS set id_Producto = '" + pro + "',id_Proveedores = '" + provee +"',id_Cotizaciones='"+cot+ "' where id_Compra=" + id;
            comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void evento_borrar(object sender, EventArgs e)
        {
            int pos;
            if (data1.datacompras().Rows.Count == 0)
            {
                MessageBox.Show("NO HAY ELEMENTOS");
            }
            else
            {
                pos = data1.datacompras().CurrentRow.Index;
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar El ID Compra " + data1.datacompras()[0, pos].Value.ToString() + " ?", "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    conexion.Open();
                    string cadena = "delete from COMPRAS where id_Compra=" + data1.datacompras()[0, pos].Value.ToString();
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Se borró la Compra con id " + data1.datacompras()[0, pos].Value.ToString());
                    conexion.Close();
                    cargar_datagrid(data1.datacompras());
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
                    string consulta = "select * from COMPRAS where id_Compra like '%" + mascara1.Text + "%'";
                    comando = new SqlCommand(consulta, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla, "COMPRAS");
                    data1.datacompras().DataSource = tabla;
                    data1.datacompras().DataMember = "COMPRAS";
                    data1.datacompras().Refresh();
                    conexion.Close();
                }
                else if (mascara2.Text != string.Empty)
                {
                    DataSet tabla2 = new DataSet();
                    conexion.Open();
                    string consulta2 = "select * from COMPRAS where id_Producto like '%" + mascara2.Text + "%'";
                    comando = new SqlCommand(consulta2, conexion);
                    SqlDataAdapter adaptador2 = new SqlDataAdapter(comando);
                    adaptador2.Fill(tabla2, "COMPRAS");
                    data1.datacompras().DataSource = tabla2;
                    data1.datacompras().DataMember = "COMPRAS";
                    data1.datacompras().Refresh();
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
        public void evento_nueva_compra(object sender, EventArgs e)
        {
            //Activa el panel y oculta los componentes de la forma
            Panel_Compras.Visible = true;

            data1.datacompras().Visible = false;
            label1.label1_Compras().Visible = false;
            label2.label2_Compras().Visible = false;

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
            mascara1.Name = "id_puesto";
            mascara1.TabIndex = 1;
            mascara1.Size = new System.Drawing.Size(35, 20);
            mascara1.ValidatingType = typeof(int);

            mascara2.Location = new System.Drawing.Point(149, 55);
            mascara2.Name = "tipo";
            mascara2.Size = new System.Drawing.Size(35, 20);
            mascara2.Mask = "99999";

            //Agregar los textbox y las mascaras a la forma
            Controls.Add(mascara1);
            Controls.Add(mascara2);
        }
        private void Compras_Load(object sender, EventArgs e)
        {
            cargar_datagrid(data1.datacompras());
        }
        private void cargar_datagrid(DataGridView mostrar)
        {
            try
            {
                conexion.Open();
                comando = new SqlCommand("select * from COMPRAS", conexion);
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
