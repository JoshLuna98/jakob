using Almacen_Libreria1;//Agregar libreria creada
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Almacen_Tiempo_de_Ejecucion
{
    public partial class Ventas : Form
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-V2DEJSV\\SQLEXPRESS;Initial Catalog=ALMACN_Estrellas_3;Integrated Security=True");
        //Se invocan los componentes desde la libreria y otros son creados en la misma forma
        Class1 label1 = new Class1();
        Class1 label2 = new Class1();
        Class1 label3 = new Class1();
        Class1 label4 = new Class1();
        Class1 label5 = new Class1();
        Class1 label6 = new Class1();
        Class1 label7 = new Class1();
        Class1 label8 = new Class1();
        Class1 label9 = new Class1();
        Class1 label10 = new Class1();
        Class1 label11 = new Class1();
        MaskedTextBox mascara1 = new MaskedTextBox();
        MaskedTextBox mascara2 = new MaskedTextBox();
        MaskedTextBox mascara3 = new MaskedTextBox();
        MaskedTextBox mascara4 = new MaskedTextBox();
        MaskedTextBox mascara5 = new MaskedTextBox();
        MaskedTextBox mascara6 = new MaskedTextBox();
        MaskedTextBox mascara7 = new MaskedTextBox();
        MaskedTextBox mascara8 = new MaskedTextBox();
        MaskedTextBox mascara9 = new MaskedTextBox();
        Class1 data1 = new Class1();
        Button boton1 = new Button();
        Button boton2 = new Button();
        Button boton3 = new Button();
        Button boton4 = new Button();
        Button boton5 = new Button();
        Button boton6 = new Button();
        Button boton7 = new Button();
        Panel Panel_Ventas = new Panel();
        Button boton8 = new Button();
        TextBox texto1 = new TextBox();
        TextBox texto2 = new TextBox();
        public void Componentes_Panel()
        {
            //Creacion de los componentes del panel
            boton7.Location = new System.Drawing.Point(17, 326);
            boton7.Name = "button7";
            boton7.Size = new System.Drawing.Size(129, 32);
            boton7.Text = "Volver";
            boton7.TabIndex = 8;
            boton7.UseVisualStyleBackColor = true;
            boton7.Click += new System.EventHandler(evento_volver);

            mascara5.Location = new System.Drawing.Point(166, 20);
            mascara5.Name = "id_producto";
            mascara5.TabIndex = 0;
            mascara5.Size = new System.Drawing.Size(44, 20);
            mascara5.ValidatingType = typeof(int);
            mascara5.Mask = "99999";


            mascara6.Location = new System.Drawing.Point(166, 70);
            mascara6.Name = "id_proveedor";
            mascara6.TabIndex = 1;
            mascara6.Size = new System.Drawing.Size(44, 20);
            mascara6.ValidatingType = typeof(int);
            mascara6.Mask = "99999";

            mascara7.Location = new System.Drawing.Point(166, 128);
            mascara7.Name = "% descuento";
            mascara7.TabIndex = 2;
            mascara7.Size = new System.Drawing.Size(44, 20);
            mascara7.ValidatingType = typeof(int);

            mascara8.Location = new System.Drawing.Point(166, 192);
            mascara8.Name = "id_cliente";
            mascara8.TabIndex = 3;
            mascara8.Size = new System.Drawing.Size(44, 20);
            mascara8.ValidatingType = typeof(int);
            mascara8.Mask = "99999";


            texto1.Location = new System.Drawing.Point(399, 30);
            texto1.Name = "garantia";
            texto1.TabIndex = 4;
            texto1.Size = new System.Drawing.Size(100, 20);


            mascara9.Location = new System.Drawing.Point(399, 86);
            mascara9.Name = "id_venta";
            mascara9.TabIndex = 5;
            mascara9.Size = new System.Drawing.Size(44, 20);
            mascara9.ValidatingType = typeof(int);
            mascara9.Mask = "99999";

            texto2.Location = new System.Drawing.Point(399, 158);
            texto2.Name = "devoluciones";
            texto2.TabIndex = 6;
            texto2.Size = new System.Drawing.Size(100, 20);

            boton8.Location = new System.Drawing.Point(404, 291);
            boton8.Name = "button8";
            boton8.Size = new System.Drawing.Size(95, 59);
            boton8.Text = "Realizar Venta";
            boton8.TabIndex = 7;
            boton8.UseVisualStyleBackColor = true;
            boton8.Click += new System.EventHandler(evento_agregar);

            //Agregar los componentes al panel
            Panel_Ventas.Controls.Add(boton7);
            Panel_Ventas.Controls.Add(boton8);
            Panel_Ventas.Controls.Add(label5.ID_Producto());
            Panel_Ventas.Controls.Add(label6.ID_Proveedor());
            Panel_Ventas.Controls.Add(label7.Descuento());
            Panel_Ventas.Controls.Add(label8.ID_Cliente());
            Panel_Ventas.Controls.Add(label9.Garantia());
            Panel_Ventas.Controls.Add(label10.ID_Venta());
            Panel_Ventas.Controls.Add(label11.Devoluciones());
            Panel_Ventas.Controls.Add(mascara5);
            Panel_Ventas.Controls.Add(mascara6);
            Panel_Ventas.Controls.Add(mascara7);
            Panel_Ventas.Controls.Add(mascara8);
            Panel_Ventas.Controls.Add(mascara9);
            Panel_Ventas.Controls.Add(texto1);
            Panel_Ventas.Controls.Add(texto2);
        }
        public void evento_agregar(object sender, EventArgs e)
        {
            //Si todos los campos estan llenos se guradan los datos, de lo contario tiene que llenar todos los campos
            if (!string.IsNullOrWhiteSpace(mascara5.Text) && !string.IsNullOrWhiteSpace(mascara6.Text) && !string.IsNullOrWhiteSpace(mascara7.Text) && !string.IsNullOrWhiteSpace(mascara8.Text) && !string.IsNullOrWhiteSpace(mascara9.Text) && !string.IsNullOrWhiteSpace(texto1.Text) && !string.IsNullOrWhiteSpace(texto2.Text))
            {
                try
                {
                    conexion.Open();
                    MessageBox.Show("Conexion establecida con el servidor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comando = new SqlCommand("INSERT INTO VENTAS (id_Venta, id_Cliente,id_Producto, id_Proveedores,Porciento_Descuento,Devoluciones,Tipo_Garantia)  VALUES('" + this.mascara9.Text + " ','" + this.mascara8.Text + " ','" + this.mascara5.Text + " ','" + this.mascara6.Text + " ','" + this.mascara7.Text + " ','" + this.texto2.Text + " ','" + this.texto1.Text + "')", conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Close();
                    MessageBox.Show("Se cerro correctamente la sesion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar_datagrid(data1.dataventas());
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
            //Evento en el cual los componentes del panel se ocultan para mostrar la forma anterior
            Panel_Ventas.Visible = false;

            data1.dataventas().Visible = true;//Se invoca el data desde la libreria
            label1.label1_v().Visible = true;
            label2.label2_v().Visible = true;
            label3.label3_v().Visible = true;
            label4.label4_v().Visible = true;
            mascara1.Visible = true;
            mascara2.Visible = true;
            mascara3.Visible = true;
            mascara4.Visible = true;

            boton1.Visible = true;
            boton2.Visible = true;
            boton3.Visible = true;
            boton4.Visible = true;
            boton5.Visible = true;
            boton6.Visible = true;
            cargar_datagrid(data1.dataventas());
        }
        public void Crear_Panel()
        {
            //Creacion del panel
            Panel_Ventas.Location = new System.Drawing.Point(0, 0);
            Panel_Ventas.Name = "Panel_Ventas";
            Panel_Ventas.Size = new System.Drawing.Size(575, 376);
            Panel_Ventas.Visible = false;//Es invisible hasta dar clic en el boton de nueva venta
            Panel_Ventas.BackColor = Color.Green;
            //Agregar panel a los controles
            Controls.Add(Panel_Ventas);
        }
        public void Crear_Masked()
        {
            mascara1.Location = new System.Drawing.Point(139, 20);
            mascara1.Mask = "99999";//Solo se permite ingresar hasta 5 numeros que es el id
            mascara1.Name = "id_producto";
            mascara1.TabIndex = 0;
            mascara1.Size = new System.Drawing.Size(40, 20);
            mascara1.ValidatingType = typeof(int);

            mascara2.Location = new System.Drawing.Point(332, 20);
            mascara2.Mask = "99999"; //Mascara con limite de solo 5 numeros
            mascara2.Name = "id_cliente";
            mascara2.TabIndex = 1;
            mascara2.Size = new System.Drawing.Size(40, 20);
            mascara2.ValidatingType = typeof(int);


            mascara3.Location = new System.Drawing.Point(139, 83);
            mascara3.Mask = "99999"; //Mascara con limite de solo 5 numeros
            mascara3.Name = "id_venta";
            mascara3.TabIndex = 2;
            mascara3.Size = new System.Drawing.Size(40, 20);
            mascara3.ValidatingType = typeof(int);

            mascara4.Location = new System.Drawing.Point(332, 83);
            mascara4.Mask = "99999";//Mascara con limite de solo 5 numeros
            mascara4.Name = "id_proveedor";
            mascara4.TabIndex = 3;
            mascara4.Size = new System.Drawing.Size(40, 20);
            mascara4.ValidatingType = typeof(int);

            //Agregar las mascaras a los controles de la forma
            Controls.Add(mascara1);
            Controls.Add(mascara2);
            Controls.Add(mascara3);
            Controls.Add(mascara4);
        }

        //Panel 575, 376
        public void Crear_Botones()
        {
            boton1.Location = new System.Drawing.Point(3, 341);
            boton1.Name = "button1";
            boton1.Size = new System.Drawing.Size(111, 23);
            boton1.Text = "Volver";
            boton1.TabIndex = 9;
            boton1.UseVisualStyleBackColor = true;
            boton1.Click += new System.EventHandler(evento_volver_menu);//Evento para volver a la forma principal

            boton2.Location = new System.Drawing.Point(427, 165);
            boton2.Name = "button2";
            boton2.Size = new System.Drawing.Size(75, 23);
            boton2.Text = "Borrar";
            boton2.UseVisualStyleBackColor = true;
            boton2.TabIndex = 6;
            boton2.Click += new System.EventHandler(evento_borrar);//Borra los campos

            boton3.Location = new System.Drawing.Point(427, 103);
            boton3.Name = "button3";
            boton3.Size = new System.Drawing.Size(75, 23);
            boton3.Text = "Modificar";
            boton3.Click += new System.EventHandler(evento_modificar);//Modifica los campos y activa el boton de guardar cambios
            boton3.UseVisualStyleBackColor = true;
            boton3.TabIndex = 5;

            //boton4.Location = new System.Drawing.Point(427, 237);
            //boton4.Name = "btn_gc_ventas";
            //boton4.Size = new System.Drawing.Size(75, 48);
            //boton4.Text = "Guardar Cambios";
            //boton4.UseVisualStyleBackColor = true;
            //boton4.TabIndex = 7;
            //boton4.Visible = false;//El boton el invisible hasta que se de clic en el boton de modificar

            boton5.Location = new System.Drawing.Point(427, 23);
            boton5.Name = "button5";
            boton5.Size = new System.Drawing.Size(75, 23);
            boton5.Text = "Buscar";
            boton5.TabIndex = 4;
            boton5.UseVisualStyleBackColor = true;
            boton5.Click += new System.EventHandler(evento_buscar);

            boton6.Location = new System.Drawing.Point(212, 316);
            boton6.Name = "button6";
            boton6.Size = new System.Drawing.Size(75, 48);
            boton6.Text = "Nueva Venta";
            boton6.TabIndex = 8;
            boton6.UseVisualStyleBackColor = true;
            boton6.Click += new System.EventHandler(evento_nueva_venta);

            //Agregar los botones creados a los controles
            Controls.Add(boton1);
            Controls.Add(boton2);
            Controls.Add(boton3);
            //Controls.Add(boton4);
            Controls.Add(boton5);
            Controls.Add(boton6);

        }
        public void evento_volver_menu(object sender, EventArgs e)
        {
            //Regresa a la forma principal, ocultando la forma actual
            Form1 almacen = new Form1();
            almacen.Show();
            this.Hide();
        }
        public void evento_buscar(object sender, EventArgs e)
        {
            //Se inicia la busqueda de la venta siempre y cuando ningun campo este vacio
            MessageBox.Show("Iniciando busqueda", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                if (mascara3.Text != string.Empty)
                {
                    DataSet tabla = new DataSet();
                    conexion.Open();
                    string consulta = "select * from VENTAS where id_Venta like '%" + mascara3.Text + "%'";
                    comando = new SqlCommand(consulta, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla, "VENTAS");
                    data1.dataventas().DataSource = tabla;
                    data1.dataventas().DataMember = "VENTAS";
                    data1.dataventas().Refresh();
                    conexion.Close();
                }

                else if (mascara1.Text != string.Empty)
                {
                    DataSet tabla2 = new DataSet();
                    conexion.Open();
                    string consulta2 = "select * from VENTAS where id_Producto like '%" + mascara1.Text + "%'";
                    comando = new SqlCommand(consulta2, conexion);
                    SqlDataAdapter adaptador2 = new SqlDataAdapter(comando);
                    adaptador2.Fill(tabla2, "VENTAS");
                    data1.dataventas().DataSource = tabla2;
                    data1.dataventas().DataMember = "VENTAS";
                    data1.dataventas().Refresh();
                    conexion.Close();
                }
                else if (mascara2.Text != string.Empty)
                {
                    DataSet tabla3 = new DataSet();
                    conexion.Open();
                    string consulta3 = "select * from VENTAS where id_Cliente like '%" + mascara2.Text + "%'";
                    comando = new SqlCommand(consulta3, conexion);
                    SqlDataAdapter adaptador3 = new SqlDataAdapter(comando);
                    adaptador3.Fill(tabla3, "VENTAS");
                    data1.dataventas().DataSource = tabla3;
                    data1.dataventas().DataMember = "VENTAS";
                    data1.dataventas().Refresh();
                    conexion.Close();
                }
                else if (mascara4.Text != string.Empty)
                {
                    DataSet tabla4 = new DataSet();
                    conexion.Open();
                    string consulta4 = "select * from VENTAS where id_Proveedores like '%" + mascara4.Text + "%'";
                    comando = new SqlCommand(consulta4, conexion);
                    SqlDataAdapter adaptador4 = new SqlDataAdapter(comando);
                    adaptador4.Fill(tabla4, "VENTAS");
                    data1.dataventas().DataSource = tabla4;
                    data1.dataventas().DataMember = "VENTAS";
                    data1.dataventas().Refresh();
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
        public void evento_borrar(object sender, EventArgs e)
        {
            int pos;
            if (data1.dataventas().Rows.Count == 0)
            {
                MessageBox.Show("NO HAY ELEMENTOS");
            }
            else
            {
                pos = data1.dataventas().CurrentRow.Index;
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar El ID Venta " + data1.dataventas()[0, pos].Value.ToString() + " ?", "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    conexion.Open();
                    string cadena = "delete from VENTAS where id_Venta=" + data1.dataventas()[0, pos].Value.ToString();
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Se borró la Venta con id " + data1.dataventas()[0, pos].Value.ToString());
                    conexion.Close();
                    cargar_datagrid(data1.dataventas());
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("No se elimino");
                }
            }

        }
        public void evento_modificar(object sender, EventArgs e)
        {
            int id = data1.dataventas().SelectedCells[0].RowIndex;
            //string dato = data1.dataventas().Rows[id].Cells[0].Value.ToString();
            actualiza_grid(id + 1);
            data1.dataventas().Refresh();
        }
        public void evento_nueva_venta(object sender, EventArgs e)
        {
            //Se ocultan los componentes de la forma anterior y se muestra el panel
            Panel_Ventas.Visible = true;
            data1.dataventas().Visible = false;
            label1.label1_v().Visible = false;
            label2.label2_v().Visible = false;
            label3.label3_v().Visible = false;
            label4.label4_v().Visible = false;
            mascara1.Visible = false;
            mascara2.Visible = false;
            mascara3.Visible = false;
            mascara4.Visible = false;
            boton1.Visible = false;
            boton2.Visible = false;
            boton3.Visible = false;
            boton4.Visible = false;
            boton5.Visible = false;
            boton6.Visible = false;
        }
        public Ventas()
        {
            //Inicializacion de los componentes y funciones para que se muestren al momento de ejecutar el programa
            InitializeComponent();
            this.BackColor = Color.Coral;
            Controls.Add(data1.dataventas());
            Controls.Add(label1.label1_v());
            Controls.Add(label2.label2_v());
            Controls.Add(label3.label3_v());
            Controls.Add(label4.label4_v());
            Crear_Masked();
            
            Crear_Botones();
            Componentes_Panel();
            Crear_Panel();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            cargar_datagrid(data1.dataventas());
        }
        private void cargar_datagrid(DataGridView mostrar)
        {
            try
            {
                conexion.Open();
                comando = new SqlCommand("select * from VENTAS", conexion);
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
        private void actualiza_grid(int id)
        {
            int renglon = data1.dataventas().SelectedCells[0].RowIndex;

            //string id_Cliente = data1.dataventas().Rows[renglon].Cells[0].Value.ToString();
            //string id_Producto = data1.dataventas().Rows[renglon].Cells[1].Value.ToString();
            //string id_Proveedores = data1.dataventas().Rows[renglon].Cells[2].Value.ToString();
            string porciento = data1.dataventas().Rows[renglon].Cells[4].Value.ToString();
            string devoluciones = data1.dataventas().Rows[renglon].Cells[5].Value.ToString();
            string tipo_g = data1.dataventas().Rows[renglon].Cells[6].Value.ToString();
            conexion.Open();
            string consulta = "update VENTAS set Porciento_Descuento = '" + porciento + "',Devoluciones = '" + devoluciones + "',Tipo_Garantia='" + tipo_g + "' where id_Venta=" + id;
            comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
