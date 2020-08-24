using Almacen_Libreria1;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Almacen_Tiempo_de_Ejecucion
{
    public partial class Tickets : Form
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-V2DEJSV\\SQLEXPRESS;Initial Catalog=ALMACN_Estrellas_3;Integrated Security=True");
        Class1 label1 = new Class1();
        Class1 label2 = new Class1();
        Class1 label3 = new Class1();
        Class1 label4 = new Class1();
        Class1 label5 = new Class1();
        Class1 data1 = new Class1();
        Button boton1 = new Button();
        Button boton2 = new Button();
        Button boton3 = new Button();
        Button boton4 = new Button();
        Button boton5 = new Button();
        Button boton6 = new Button();
        MaskedTextBox mascara1 = new MaskedTextBox();
        MaskedTextBox mascara2 = new MaskedTextBox();
        MaskedTextBox mascara3 = new MaskedTextBox();
        MaskedTextBox mascara4 = new MaskedTextBox();
        MaskedTextBox mascara5 = new MaskedTextBox();
        Panel Panel_Tickets = new Panel();
        Button boton_volver = new Button();
        Button boton7 = new Button();
        public Tickets()
        {
            InitializeComponent();
            this.BackColor = Color.Aqua;
            Controls.Add(data1.datatickets());
            Controls.Add(label1.label1_Tickets());
            Controls.Add(label2.label2_Tickets());
            Crear_Botones();
            TextyMascaras();
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

            mascara5.Location = new System.Drawing.Point(189, 159);
            mascara5.Name = "id_datos";
            mascara5.Mask = "99999";
            mascara5.TabIndex = 2;
            mascara5.Size = new System.Drawing.Size(35, 20);
            mascara5.ValidatingType = typeof(int);

            boton7.Location = new System.Drawing.Point(331, 74);
            boton7.Name = "button7";
            boton7.Size = new System.Drawing.Size(89, 82);
            boton7.Text = "Agregar Ticket";
            boton7.TabIndex = 3;
            boton7.UseVisualStyleBackColor = true;
            boton7.Click += new System.EventHandler(evento_agregar);//El evento guarda los proveedores

            //Agregar los componentes al panel
            Panel_Tickets.Controls.Add(boton_volver);
            Panel_Tickets.Controls.Add(boton7);
            Panel_Tickets.Controls.Add(label3.label1_Ticket_P());//Invocar el objeto de la forma y su funcion con las propiedades, 
                                                                 ////igual para los demas labels
            Panel_Tickets.Controls.Add(label4.label2_Tickets_P());
            Panel_Tickets.Controls.Add(label5.label3_Tickets_P());
            Panel_Tickets.Controls.Add(mascara5);
            Panel_Tickets.Controls.Add(mascara3);
            Panel_Tickets.Controls.Add(mascara4);
        }
        public void evento_agregar(object sender, EventArgs e)
        {
            //Agrega un proveedor solo si todos los campos estan llenos
            if (!string.IsNullOrWhiteSpace(mascara5.Text) && !string.IsNullOrWhiteSpace(mascara3.Text) && !string.IsNullOrWhiteSpace(mascara4.Text))
            {
                try
                {
                    conexion.Open();
                    MessageBox.Show("Conexion establecida con el servidor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comando = new SqlCommand("INSERT INTO TICKETS (id_Tiket, id_Venta,id_Producto)  VALUES('" + this.mascara3.Text + " ','" + this.mascara4.Text + " ','" + this.mascara5.Text + "')", conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Close();
                    MessageBox.Show("Se cerro correctamente la sesion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar_datagrid(data1.datatickets());
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
            Panel_Tickets.Visible = false;

            data1.datatickets().Visible = true;
            label1.label1_Tickets().Visible = true;
            label2.label2_Tickets().Visible = true;

            mascara1.Visible = true;
            mascara2.Visible = true;

            boton1.Visible = true;
            boton2.Visible = true;
            boton3.Visible = true;
            boton4.Visible = true;
            boton5.Visible = true;
            boton6.Visible = true;
            cargar_datagrid(data1.datatickets());
        }
        public void Crear_Panel()
        {
            //Crea el panel de proveedores
            Panel_Tickets.Location = new System.Drawing.Point(0, 0);
            Panel_Tickets.Name = "Panel_Proveedores";
            Panel_Tickets.Size = new System.Drawing.Size(593, 309);
            Panel_Tickets.Visible = false;//Esta invisible hasta hacer clic en el boton de nuevo proveedor
            Panel_Tickets.BackColor = Color.Blue;
            Controls.Add(Panel_Tickets);
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
            boton2.Text = "Nuevo Ticket";
            boton2.TabIndex = 6;
            boton2.UseVisualStyleBackColor = true;
            boton2.Click += new System.EventHandler(evento_nuevo_ticket);//Muestra el panel

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
            //Controls.Add(boton5);
            Controls.Add(boton6);
        }
        public void evento_modificar(object sender, EventArgs e)
        {
            int id = data1.datatickets().SelectedCells[0].RowIndex;
            actualiza_grid(id + 1);
            data1.datatickets().Refresh();
        }
        private void actualiza_grid(int id)
        {
            int renglon = data1.datatickets().SelectedCells[0].RowIndex;
            string venta = data1.datatickets().Rows[renglon].Cells[1].Value.ToString();
            string producto = data1.datatickets().Rows[renglon].Cells[2].Value.ToString();
            conexion.Open();
            string consulta = "update TICKETS set id_Venta = '" + venta + "',id_Producto = '" + producto + "' where id_Tiket=" + id; 
            comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void evento_borrar(object sender, EventArgs e)
        {
            int pos;
            if (data1.datatickets().Rows.Count == 0)
            {
                MessageBox.Show("NO HAY ELEMENTOS");
            }
            else
            {
                pos = data1.datatickets().CurrentRow.Index;
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar El ID Ticket " + data1.datatickets()[0, pos].Value.ToString() + " ?", "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    conexion.Open();
                    string cadena = "delete from TICKETS where id_Tiket=" + data1.datatickets()[0, pos].Value.ToString();
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Se borró el Ticket con id " + data1.datatickets()[0, pos].Value.ToString());
                    conexion.Close();
                    cargar_datagrid(data1.datatickets());
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
                    string consulta = "select * from TICKETS where id_Tiket like '%" + mascara1.Text + "%'";
                    comando = new SqlCommand(consulta, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla, "TICKETS");
                    data1.datatickets().DataSource = tabla;
                    data1.datatickets().DataMember = "TICKETS";
                    data1.datatickets().Refresh();
                    conexion.Close();
                }
                else if (mascara2.Text != string.Empty)
                {
                    DataSet tabla2 = new DataSet();
                    conexion.Open();
                    string consulta2 = "select * from TICKETS where id_Venta like '%" + mascara2.Text + "%'";
                    comando = new SqlCommand(consulta2, conexion);
                    SqlDataAdapter adaptador2 = new SqlDataAdapter(comando);
                    adaptador2.Fill(tabla2, "TICKETS");
                    data1.datatickets().DataSource = tabla2;
                    data1.datatickets().DataMember = "TICKETS";
                    data1.datatickets().Refresh();
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
        public void evento_nuevo_ticket(object sender, EventArgs e)
        {
            //Activa el panel y oculta los componentes de la forma
            Panel_Tickets.Visible = true;

            data1.datatickets().Visible = false;
            label1.label1_Tickets().Visible = false;
            label2.label2_Tickets().Visible = false;

            mascara1.Visible = false;
            mascara2.Visible = false;

            boton1.Visible = false;
            boton2.Visible = false;
            boton3.Visible = false;
            boton4.Visible = false;
            boton5.Visible = false;
            boton6.Visible = false;
        }
        public void evento_volver_menu(object sender, EventArgs e)
        {
            //Oculta la forma actual y muestra la de inicio
            Form1 almacen = new Form1();
            almacen.Show();
            this.Hide();
        }
        private void Tickets_Load(object sender, EventArgs e)
        {
            cargar_datagrid(data1.datatickets());
        }
        private void cargar_datagrid(DataGridView mostrar)
        {
            try
            {
                conexion.Open();
                comando = new SqlCommand("select * from TICKETS", conexion);
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
