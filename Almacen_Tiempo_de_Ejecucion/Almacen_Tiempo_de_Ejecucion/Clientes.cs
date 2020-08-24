using Almacen_Libreria1;//Agregar libreria creada
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Almacen_Tiempo_de_Ejecucion
{
    public partial class Clientes : Form
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-V2DEJSV\\SQLEXPRESS;Initial Catalog=ALMACN_Estrellas_3;Integrated Security=True");
        //Se invoca la clase 1 de la libreria se hace un puente para crear los objetos
        Class1 panel = new Class1();
        Class1 l_1 = new Class1();
        Class1 l_2 = new Class1();
        Class1 l_3 = new Class1();
        Class1 l_4 = new Class1();
        Class1 l_5 = new Class1();
        Class1 l_6 = new Class1();
        Class1 l_7 = new Class1();
        Class1 l_8 = new Class1();
        Class1 l_9 = new Class1();
        Class1 l_10 = new Class1();
        Class1 l_11 = new Class1();
        Class1 l_12 = new Class1();
        Class1 l_13 = new Class1();
        Class1 l_14 = new Class1();
        Class1 l_15 = new Class1();
        MaskedTextBox masked1 = new MaskedTextBox();
        MaskedTextBox masked2 = new MaskedTextBox();
        MaskedTextBox masked3 = new MaskedTextBox();
        MaskedTextBox masked4 = new MaskedTextBox();
        TextBox text1 = new TextBox();
        TextBox text2 = new TextBox();
        TextBox text3 = new TextBox();
        TextBox text4 = new TextBox();
        TextBox text5 = new TextBox();
        TextBox text6 = new TextBox();
        TextBox text7 = new TextBox();
        TextBox text8 = new TextBox();
        TextBox text9 = new TextBox();
        TextBox text10 = new TextBox();
        MaskedTextBox text11 = new MaskedTextBox();
        Class1 data1 = new Class1();
        Button btn1 = new Button();
        Button btn2 = new Button();
        Button btn3 = new Button();
        Button btn4 = new Button();
        Button btn5 = new Button();
        Button btn6 = new Button();
        Button btn_agregar = new Button();
        Panel Panel_Clientes = new Panel();
        Button btn_volver = new Button();


        public void Componentes_Panel()
        {
            //Creacion de los componentes del panel
            btn_volver.Location = new System.Drawing.Point(23, 311);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new System.Drawing.Size(75, 23);

            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += new System.EventHandler(evento_volver);//Evento que regresara a la forma enterior
            btn_volver.TabIndex = 12;

            btn_agregar.Location = new System.Drawing.Point(369, 292);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new System.Drawing.Size(75, 42);
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += new System.EventHandler(evento_agregar);//Evento agregar
            btn_agregar.TabIndex = 11;

            text4.Location = new System.Drawing.Point(166, 12);
            text4.Name = "nombres";
            text4.TabIndex = 0;
            text4.Size = new System.Drawing.Size(100, 20);


            text5.Location = new System.Drawing.Point(166, 64);
            text5.Name = "a_paterno";
            text5.TabIndex = 1;
            text5.Size = new System.Drawing.Size(100, 20);


            text6.Location = new System.Drawing.Point(166, 123);
            text6.Name = "a_materno";
            text6.TabIndex = 2;
            text6.Size = new System.Drawing.Size(100, 20);


            text7.Location = new System.Drawing.Point(165, 181);
            text7.Name = "correo";
            text7.TabIndex = 3;
            text7.Size = new System.Drawing.Size(100, 20);
            text7.KeyPress += new KeyPressEventHandler(evento_correo);

            masked2.Location = new System.Drawing.Point(165, 223);
            masked2.TabIndex = 4;
            masked2.Name = "telefono";
            masked2.Size = new System.Drawing.Size(77, 20);
            masked2.Mask = "9999999999";

            text8.Location = new System.Drawing.Point(165, 278);
            text8.Name = "curp";
            text8.TabIndex = 5;
            text8.Size = new System.Drawing.Size(100, 20);

            text9.Location = new System.Drawing.Point(368, 10);
            text9.Name = "colonia";
            text9.TabIndex = 6;
            text9.Size = new System.Drawing.Size(100, 20);

            text10.Location = new System.Drawing.Point(368, 59);
            text10.Name = "ciudad";
            text10.TabIndex = 7;
            text10.Size = new System.Drawing.Size(100, 20);

            text11.Location = new System.Drawing.Point(368, 114);
            text11.Name = "txt_Limite_Credito";
            text11.TabIndex = 8;
            text11.Size = new System.Drawing.Size(100, 20);
            text11.Mask = "9999999999";

            masked3.Location = new System.Drawing.Point(395, 174);
            masked3.Mask = "99999";
            masked3.Name = "txt_id_cliente";
            masked3.TabIndex = 9;
            masked3.Size = new System.Drawing.Size(39, 20);
            masked3.ValidatingType = typeof(int);

            masked4.Location = new System.Drawing.Point(395, 236);
            masked4.Mask = "00000";
            masked4.TabIndex = 10;
            masked4.Name = "txt_id_datos";
            masked4.Size = new System.Drawing.Size(39, 20);


            Panel_Clientes.Controls.Add(btn_volver);
            Panel_Clientes.Controls.Add(btn_agregar);
            Panel_Clientes.Controls.Add(l_5.Nombres_Cliente());//Se invoca el objeto de la forma y depues la funcion de la libreria, igual para los demas labels del panel
            Panel_Clientes.Controls.Add(l_6.A_P_Cliente());
            Panel_Clientes.Controls.Add(l_7.A_M_Cliente());
            Panel_Clientes.Controls.Add(l_8.Correo_Cliente());
            Panel_Clientes.Controls.Add(l_9.Telefono_Cliente());
            Panel_Clientes.Controls.Add(l_10.Curp_Cliente());
            Panel_Clientes.Controls.Add(l_11.Colonia_Cliente());
            Panel_Clientes.Controls.Add(l_12.Ciudad_Cliente());
            Panel_Clientes.Controls.Add(l_13.Calle_Cliente());
            Panel_Clientes.Controls.Add(l_14.Numero_Cliente());
            Panel_Clientes.Controls.Add(l_15.CP_Cliente());
            Panel_Clientes.Controls.Add(text4);
            Panel_Clientes.Controls.Add(text5);
            Panel_Clientes.Controls.Add(text6);
            Panel_Clientes.Controls.Add(text7);
            Panel_Clientes.Controls.Add(text8);
            Panel_Clientes.Controls.Add(text9);
            Panel_Clientes.Controls.Add(text10);
            Panel_Clientes.Controls.Add(text11);
            Panel_Clientes.Controls.Add(masked2);
            Panel_Clientes.Controls.Add(masked3);
            Panel_Clientes.Controls.Add(masked4);
        }
        public void Crear_Panel()
        {
            //Creacion del panel
            Panel_Clientes.Location = new System.Drawing.Point(0, 0);
            Panel_Clientes.Name = "Panel_Clientes";
            Panel_Clientes.Size = new System.Drawing.Size(517, 352);
            Panel_Clientes.Visible = false;//Es invisible hasta dar clic en el boton de agregar cliente
            Panel_Clientes.BackColor = Color.Blue;
            Controls.Add(Panel_Clientes);
        }
        public void evento_agregar(object sender, EventArgs e)
        {
            //Si existe un campo vacio mostrar error y se tienen que completar todos los campos
            if (!string.IsNullOrWhiteSpace(text4.Text) && !string.IsNullOrWhiteSpace(text5.Text) && !string.IsNullOrWhiteSpace(text6.Text) && !string.IsNullOrWhiteSpace(text7.Text) && !string.IsNullOrWhiteSpace(text8.Text) && !string.IsNullOrWhiteSpace(text9.Text) && !string.IsNullOrWhiteSpace(text10.Text) && !string.IsNullOrWhiteSpace(text11.Text) && !string.IsNullOrWhiteSpace(masked2.Text) && !string.IsNullOrWhiteSpace(masked3.Text) && !string.IsNullOrWhiteSpace(masked4.Text))
            {
                try
                {
                    conexion.Open();
                    MessageBox.Show("Conexion establecida con el servidor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comando = new SqlCommand("INSERT INTO CLIENTES (id_Cliente, id_Datos,Limite_De_Credito, Nombres,Apellido_Paterno,Apellido_Materno,Correo,Telefono,CURP,Colonia,Ciudad)  VALUES('" + this.masked3.Text + " ','" + this.masked4.Text + " ','" + this.text11.Text + " ','" + this.text4.Text + " ','" + this.text5.Text + " ','" + this.text6.Text + " ','" + this.text7.Text + " ','" + this.masked2.Text + " ','" + this.text8.Text + " ','" + this.text9.Text + " ','" + this.text10.Text + "')", conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Close();
                    MessageBox.Show("Se cerro correctamente la sesion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar_datagrid(data1.dataclientes());
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
        public void evento_correo(object sender, KeyPressEventArgs e)
        {
            //Se valida que el usuario ingrese solo ciertos caracteres como @, _, borrar,etc.
            if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == 64 || e.KeyChar == 46 || e.KeyChar == 95 || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public void evento_volver(object sender, EventArgs e)
        {
            //Oculta los componentes del panel y muestra los de la forma
            Panel_Clientes.Visible = false;
            data1.dataclientes().Visible = true;
            l_1.label1().Visible = true;
            l_2.label2().Visible = true;
            l_3.label3().Visible = true;
            l_4.label4().Visible = true;
            masked1.Visible = true;
            text1.Visible = true;
            text2.Visible = true;
            text3.Visible = true;

            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
            btn6.Visible = true;
            cargar_datagrid(data1.dataclientes());
        }

        public void Crear_Botones()
        {
            //Creacion de los botones de la forma
            btn1.Location = new System.Drawing.Point(199, 278);
            btn1.Name = "ag_cliente";
            btn1.Size = new System.Drawing.Size(93, 51);
            btn1.TabIndex = 29;
            btn1.Text = "Agregar Cliente";
            btn1.Click += new System.EventHandler(evento_agregar_cliente);
            btn1.UseVisualStyleBackColor = true;
            btn1.TabIndex = 8;


            btn2.Location = new System.Drawing.Point(412, 201);
            btn2.Name = "borrar";
            btn2.Size = new System.Drawing.Size(75, 23);
            btn2.Text = "Borrar";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += new System.EventHandler(evento_borrar);
            btn2.TabIndex = 6;

            btn3.Location = new System.Drawing.Point(412, 150);
            btn3.Name = "button4";
            btn3.Size = new System.Drawing.Size(75, 23);

            btn3.Text = "Modificar";
            btn3.Click += new System.EventHandler(evento_modificar);//Hace visible el boton de guardar cambios
            btn3.UseVisualStyleBackColor = true;
            btn3.TabIndex = 5;

            btn4.Location = new System.Drawing.Point(412, 268);
            btn4.Name = "guar_cambios";
            btn4.Size = new System.Drawing.Size(75, 48);
            btn4.TabIndex = 7;

            //btn4.Text = "Guardar Cambios";
            //btn4.UseVisualStyleBackColor = true;
            //btn4.Visible = false;// Es invisible hasta dar clic en boton de modificar

            btn5.Location = new System.Drawing.Point(412, 105);
            btn5.Name = "buscar";
            btn5.TabIndex = 4;
            btn5.Size = new System.Drawing.Size(75, 23);

            btn5.Text = "Buscar";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += new System.EventHandler(evento_buscar);//Busca el cliente

            btn6.Location = new System.Drawing.Point(12, 310);
            btn6.Name = "volver";
            btn6.Size = new System.Drawing.Size(75, 23);
            btn6.TabIndex = 9;
            btn6.Click += new System.EventHandler(evento_volver_menu);//Regresa al menu principal
            btn6.Text = "Volver";
            btn6.UseVisualStyleBackColor = true;

            //Agrega los botones a la forma
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            //Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
        }
        public void evento_volver_menu(object sender, EventArgs e)
        {
            //Oculta la forma actual y muestra el menu
            Form1 almacen = new Form1();
            almacen.Show();
            this.Hide();
        }
        public void evento_buscar(object sender, EventArgs e)
        {
            MessageBox.Show("Iniciando busqueda", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                if (masked1.Text != string.Empty)
                {

                    DataSet tabla = new DataSet();
                    conexion.Open();
                    string consulta = "select * from CLIENTES where id_Cliente like '%" + masked1.Text + "%'";
                    comando = new SqlCommand(consulta, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla, "CLIENTES");
                    data1.dataclientes().DataSource = tabla;
                    data1.dataclientes().DataMember = "CLIENTES";
                    data1.dataclientes().Refresh();
                    conexion.Close();
                }
                else if (text1.Text != string.Empty)
                {
                    DataSet tabla = new DataSet();
                    conexion.Open();
                    string consulta = "select * from CLIENTES where Nombres like '%" + text1.Text + "%'";
                    comando = new SqlCommand(consulta, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla, "CLIENTES");
                    data1.dataclientes().DataSource = tabla;
                    data1.dataclientes().DataMember = "CLIENTES";
                    data1.dataclientes().Refresh();
                    conexion.Close();
                }
                else if (text2.Text != string.Empty)
                {
                    DataSet tabla = new DataSet();
                    conexion.Open();
                    string consulta = "select * from CLIENTES where Apellido_Paterno like '%" + text2.Text + "%'";
                    comando = new SqlCommand(consulta, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla, "CLIENTES");
                    data1.dataclientes().DataSource = tabla;
                    data1.dataclientes().DataMember = "CLIENTES";
                    data1.dataclientes().Refresh();
                    conexion.Close();
                }
                else if (text3.Text != string.Empty)
                {
                    DataSet tabla = new DataSet();
                    conexion.Open();
                    string consulta = "select * from CLIENTES where Apellido_Materno like '%" + text3.Text + "%'";
                    comando = new SqlCommand(consulta, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla, "CLIENTES");
                    data1.dataclientes().DataSource = tabla;
                    data1.dataclientes().DataMember = "CLIENTES";
                    data1.dataclientes().Refresh();
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
            if (data1.dataclientes().Rows.Count == 0)
            {
                MessageBox.Show("NO HAY ELEMENTOS");
            }
            else
            {
                pos = data1.dataclientes().CurrentRow.Index;
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar El ID Cliente " + data1.dataclientes()[0, pos].Value.ToString() + " ?", "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    conexion.Open();
                    string cadena = "delete from CLIENTES where id_Cliente=" + data1.dataclientes()[0, pos].Value.ToString();
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Se borró el Cliente con id " + data1.dataclientes()[0, pos].Value.ToString());
                    conexion.Close();
                    cargar_datagrid(data1.dataclientes());
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("No se elimino");
                }
            }

        }
        public void evento_modificar(object sender, EventArgs e)
        {
            int id = data1.dataclientes().SelectedCells[0].RowIndex;
            actualiza_grid(id + 1);
            data1.dataclientes().Refresh();
        }

        public void Crear_Masked()
        {
            //Crear mascaras para ids
            masked1.Location = new System.Drawing.Point(166, 18);
            masked1.Mask = "99999";
            masked1.Name = "id_cliente";
            masked1.TabIndex = 0;
            masked1.Size = new System.Drawing.Size(37, 20);
            masked1.ValidatingType = typeof(int);
            Controls.Add(masked1);
        }
        public void Crear_Textbox()
        {
            text1.Location = new System.Drawing.Point(140, 55);
            text1.Name = "nombre";
            text1.TabIndex = 1;
            text1.Size = new System.Drawing.Size(100, 20);

            text2.Location = new System.Drawing.Point(333, 12);
            text2.Name = "a_paterno";
            text2.TabIndex = 2;
            text2.Size = new System.Drawing.Size(100, 20);

            text3.Location = new System.Drawing.Point(333, 55);
            text3.Name = "a_materno";
            text3.TabIndex = 3;
            text3.Size = new System.Drawing.Size(100, 20);

            Controls.Add(text1);
            Controls.Add(text2);
            Controls.Add(text3);
        }

        public Clientes()
        {
            //Se inicializan los componentes y funciones
            InitializeComponent();
            this.BackColor = Color.Blue;
            Controls.Add(l_1.label1());
            Controls.Add(l_2.label2());
            Controls.Add(l_3.label3());
            Controls.Add(l_4.label4());
            Crear_Botones();
            Crear_Masked();
            Crear_Textbox();
            Componentes_Panel();
            Controls.Add(data1.dataclientes());

            Crear_Panel();
        }

        public void evento_agregar_cliente(object sender, EventArgs e)
        {
            //Oculta los elementos de la forma y muetra el panel
            Panel_Clientes.Visible = true;

            data1.dataclientes().Visible = false;
            l_1.label1().Visible = false;
            l_2.label2().Visible = false;
            l_3.label3().Visible = false;
            l_4.label4().Visible = false;
            masked1.Visible = false;
            text1.Visible = false;
            text2.Visible = false;
            text3.Visible = false;

            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
            btn4.Visible = false;
            btn5.Visible = false;
            btn6.Visible = false;

        }
        private void cargar_datagrid(DataGridView mostrar)
        {
            try
            {
                conexion.Open();
                comando = new SqlCommand("select * from CLIENTES", conexion);
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
        private void Clientes_Load(object sender, EventArgs e)
        {
            cargar_datagrid(data1.dataclientes());
        }
        private void actualiza_grid(int id)
        {
            int renglon = data1.dataclientes().SelectedCells[0].RowIndex;

            string limite = data1.dataclientes().Rows[renglon].Cells[2].Value.ToString();
            string nombres = data1.dataclientes().Rows[renglon].Cells[3].Value.ToString();
            string apellido_paterno = data1.dataclientes().Rows[renglon].Cells[4].Value.ToString();
            string apellido_materno = data1.dataclientes().Rows[renglon].Cells[5].Value.ToString();
            string correo = data1.dataclientes().Rows[renglon].Cells[6].Value.ToString();
            string colonia = data1.dataclientes().Rows[renglon].Cells[8].Value.ToString();
            string ciudad = data1.dataclientes().Rows[renglon].Cells[9].Value.ToString();
            string tel = data1.dataclientes().Rows[renglon].Cells[10].Value.ToString();
            conexion.Open();
            string consulta = "update CLIENTES set Limite_De_Credito = '" + limite + "',Nombres = '" + nombres + "',Apellido_Paterno='" + apellido_paterno + "',Apellido_Materno='" + apellido_materno + "',Correo='" + correo + "',Colonia='" + colonia + "',Ciudad='" + ciudad + "',Telefono='" + tel + "' where id_Cliente=" + id;
            comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
