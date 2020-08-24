using Almacen_Libreria2;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Almacen_Tiempo_de_Ejecucion
{
    public partial class Inventario : Form
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
        MaskedTextBox mascara3 = new MaskedTextBox();
        MaskedTextBox mascara4 = new MaskedTextBox();
        MaskedTextBox mascara5 = new MaskedTextBox();
        MaskedTextBox mascara6 = new MaskedTextBox();
        MaskedTextBox mascara7 = new MaskedTextBox();
        Button boton1 = new Button();
        Button boton2 = new Button();
        Button boton3 = new Button();
        Button boton4 = new Button();
        Button boton5 = new Button();
        Button boton6 = new Button();
        Button boton7 = new Button();
        Button boton_volver = new Button();
        Panel Panel_Inventario = new Panel();

        public Inventario()
        {
            InitializeComponent();
            Controls.Add(data1.datain());
            Controls.Add(label1.label1_Inventario());
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

            mascara3.Location = new System.Drawing.Point(129, 13);
            mascara3.Name = "id_proveedor";
            mascara3.Mask = "99999";
            mascara3.TabIndex = 1;
            mascara3.Size = new System.Drawing.Size(35, 20);
            mascara3.ValidatingType = typeof(int);

            mascara4.Location = new System.Drawing.Point(129, 86);
            mascara4.Name = "id_datos";
            mascara4.Mask = "99999";
            mascara4.TabIndex = 2;
            mascara4.Size = new System.Drawing.Size(35, 20);
            mascara4.ValidatingType = typeof(int);

            mascara5.Location = new System.Drawing.Point(129, 159);
            mascara5.Name = "id_datos";
            mascara5.Mask = "99999";
            mascara5.TabIndex = 2;
            mascara5.Size = new System.Drawing.Size(35, 20);
            mascara5.ValidatingType = typeof(int);

            mascara6.Location = new System.Drawing.Point(129, 199);
            mascara6.Name = "id_datos";
            mascara6.Mask = "99999";
            mascara6.TabIndex = 2;
            mascara6.Size = new System.Drawing.Size(35, 20);
            mascara6.ValidatingType = typeof(int);

            mascara7.Location = new System.Drawing.Point(320, 13);
            mascara7.Name = "id_datos";
            mascara7.Mask = "99999";
            mascara7.TabIndex = 2;
            mascara7.Size = new System.Drawing.Size(35, 20);
            mascara7.ValidatingType = typeof(int);

            boton7.Location = new System.Drawing.Point(331, 74);
            boton7.Name = "button7";
            boton7.Size = new System.Drawing.Size(89, 82);
            boton7.Text = "Agregar";
            boton7.TabIndex = 3;
            boton7.UseVisualStyleBackColor = true;
            boton7.Click += new System.EventHandler(evento_agregar);//El evento guarda los proveedores

            //////////Agregar los componentes al panel
            Panel_Inventario.Controls.Add(boton_volver);
            Panel_Inventario.Controls.Add(boton7);
            Panel_Inventario.Controls.Add(label2.label1_Panel());//Invocar el objeto de la forma y su funcion con las propiedades, 
            Panel_Inventario.Controls.Add(label3.label2_Panel());
            Panel_Inventario.Controls.Add(label4.label3_Panel());
            Panel_Inventario.Controls.Add(label5.label4_Panel());
            Panel_Inventario.Controls.Add(label6.label5_Panel());
            Panel_Inventario.Controls.Add(mascara3);
            Panel_Inventario.Controls.Add(mascara4);
            Panel_Inventario.Controls.Add(mascara5);
            Panel_Inventario.Controls.Add(mascara6);
            Panel_Inventario.Controls.Add(mascara7);
        }
        public void evento_agregar(object sender, EventArgs e)
        {
            //Agrega un proveedor solo si todos los campos estan llenos
            if (!string.IsNullOrWhiteSpace(mascara3.Text) && !string.IsNullOrWhiteSpace(mascara4.Text) && !string.IsNullOrWhiteSpace(mascara5.Text) && !string.IsNullOrWhiteSpace(mascara6.Text) && !string.IsNullOrWhiteSpace(mascara7.Text))
            {
                try
                {
                    conexion.Open();
                    MessageBox.Show("Conexion establecida con el servidor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comando = new SqlCommand("INSERT INTO INVENTARIO (id_Inventario, id_Producto,id_Compra,id_Venta,id_Mobiliario)  VALUES('" + this.mascara3.Text + " ','" + this.mascara4.Text + "','" + this.mascara5.Text + "','" + this.mascara6.Text + "','"+this.mascara7.Text+"')", conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Close();
                    MessageBox.Show("Se cerro correctamente la sesion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar_datagrid(data1.datain());
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
            Panel_Inventario.Visible = false;

            data1.datain().Visible = true;
            label1.label1_Inventario().Visible = true;

            mascara1.Visible = true;



            boton1.Visible = true;
            boton2.Visible = true;
            boton3.Visible = true;
            boton4.Visible = true;
            boton6.Visible = true;
            cargar_datagrid(data1.datain());
        }
        public void Crear_Panel()
        {
            //Crea el panel de proveedores
            Panel_Inventario.Location = new System.Drawing.Point(0, 0);
            Panel_Inventario.Name = "puesto";
            Panel_Inventario.Size = new System.Drawing.Size(593, 309);
            Panel_Inventario.Visible = false;//Esta invisible hasta hacer clic en el boton de nuevo proveedor
            Panel_Inventario.BackColor = Color.Chocolate;
            Controls.Add(Panel_Inventario);
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


            //Agregar los textbox y las mascaras a la forma
            Controls.Add(mascara1);
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
            boton2.Text = "Agregar";
            boton2.TabIndex = 6;
            boton2.UseVisualStyleBackColor = true;
            boton2.Click += new System.EventHandler(evento_nuevo_inventario);//Muestra el panel

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
            int id = data1.datain().SelectedCells[0].RowIndex;
            actualiza_grid(id + 1);
            data1.datain().Refresh();
        }
        private void actualiza_grid(int id)
        {
            int renglon = data1.datain().SelectedCells[0].RowIndex;
            string pro = data1.datain().Rows[renglon].Cells[1].Value.ToString();
            string com = data1.datain().Rows[renglon].Cells[2].Value.ToString();
            string ven = data1.datain().Rows[renglon].Cells[3].Value.ToString();
            string mob = data1.datain().Rows[renglon].Cells[4].Value.ToString();
            conexion.Open();
            string consulta = "update INVENTARIO set id_Producto = '" + pro + "',id_Compra = '" + com + "',id_Venta='" + ven + "',id_Mobiliario='"+mob+"' where id_Inventario=" + id;
            comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void evento_borrar(object sender, EventArgs e)
        {
            int pos;
            if (data1.datain().Rows.Count == 0)
            {
                MessageBox.Show("NO HAY ELEMENTOS");
            }
            else
            {
                pos = data1.datain().CurrentRow.Index;
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar El ID Inventario " + data1.datain()[0, pos].Value.ToString() + " ?", "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    conexion.Open();
                    string cadena = "delete from INVENTARIO where id_Inventario=" + data1.datain()[0, pos].Value.ToString();
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Se borró el Inventario con id " + data1.datain()[0, pos].Value.ToString());
                    conexion.Close();
                    cargar_datagrid(data1.datain());
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
                    string consulta = "select * from INVENTARIO where id_Inventario like '%" + mascara1.Text + "%'";
                    comando = new SqlCommand(consulta, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla, "INVENTARIO");
                    data1.datain().DataSource = tabla;
                    data1.datain().DataMember = "INVENTARIO";
                    data1.datain().Refresh();
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
        public void evento_nuevo_inventario(object sender, EventArgs e)
        {
            //Activa el panel y oculta los componentes de la forma
            Panel_Inventario.Visible = true;

            data1.datain().Visible = false;
            label1.label1_Inventario().Visible = false;

            mascara1.Visible = false;

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

        private void Inventario_Load(object sender, EventArgs e)
        {

        }
        private void cargar_datagrid(DataGridView mostrar)
        {
            try
            {
                conexion.Open();
                comando = new SqlCommand("select * from INVENTARIO", conexion);
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
        private void Inventario_Load_1(object sender, EventArgs e)
        {
            cargar_datagrid(data1.datain());
            this.BackColor = Color.Coral;
        }
    }
}
