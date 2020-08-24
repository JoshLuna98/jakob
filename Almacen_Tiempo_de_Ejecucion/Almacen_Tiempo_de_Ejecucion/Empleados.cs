using Almacen_Libreria1;//Agregar libreria creada
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Almacen_Tiempo_de_Ejecucion
{
    public partial class Empleados : Form
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-V2DEJSV\\SQLEXPRESS;Initial Catalog=ALMACN_Estrellas_3;Integrated Security=True");
        //Invocar la clase de la libreria y crear los objetos
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
        Class1 l_16 = new Class1();
        //Creacion de los demas objetos
        MaskedTextBox masked1 = new MaskedTextBox();
        MaskedTextBox masked2 = new MaskedTextBox();
        MaskedTextBox masked3 = new MaskedTextBox();
        MaskedTextBox masked4 = new MaskedTextBox();
        MaskedTextBox masked5 = new MaskedTextBox();
        MaskedTextBox masked6 = new MaskedTextBox();
        MaskedTextBox masked7 = new MaskedTextBox();
        MaskedTextBox masked8 = new MaskedTextBox();
        Class1 data1 = new Class1();
        Button btn1 = new Button();
        Button btn2 = new Button();
        Button btn3 = new Button();
        Button btn4 = new Button();
        Button btn5 = new Button();
        Button btn6 = new Button();
        Panel Panel_Empleados = new Panel();
        Button btn_volver = new Button();
        Button btn_agregar = new Button();
        TextBox text1 = new TextBox();
        TextBox text2 = new TextBox();
        TextBox text3 = new TextBox();
        TextBox text4 = new TextBox();
        TextBox text5 = new TextBox();
        TextBox text6 = new TextBox();
        TextBox text7 = new TextBox();
        MaskedTextBox text8 = new MaskedTextBox();

        public void Ev2()//Funcion para finalizar el proceso
        {
            if (text1.Text == "")
            {
                MessageBox.Show("Departamento Empleados Finalizado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Mensaje para mostrar
            }
        }
        public void Ev1()
        {
            if (text1.Text == "")
            {
                MessageBox.Show("Departamento Empleados Iniciado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Mensaje para mostrar
            }
        }

        public void Componentes_Panel()
        {

            //Creacion de los componentes del panel
            btn_volver.Location = new System.Drawing.Point(23, 340);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new System.Drawing.Size(75, 23);
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.TabIndex = 13;
            btn_volver.Click += new System.EventHandler(evento_volver);//Regresa a la forma enterior

            btn_agregar.Location = new System.Drawing.Point(369, 292);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new System.Drawing.Size(75, 42);
            btn_agregar.Text = "Agregar Trabajador";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += new System.EventHandler(evento_agregar);//Agrega un nuevo trabajador
            btn_agregar.TabIndex = 12;

            text1.Location = new System.Drawing.Point(166, 12);
            text1.Name = "nombres";
            text1.Size = new System.Drawing.Size(100, 20);
            text1.TabIndex = 0;


            text2.Location = new System.Drawing.Point(166, 64);
            text2.Name = "a_paterno";
            text2.Size = new System.Drawing.Size(100, 20);
            text2.TabIndex = 1;


            text3.Location = new System.Drawing.Point(166, 123);
            text3.Name = "a_materno";
            text3.Size = new System.Drawing.Size(100, 20);
            text3.TabIndex = 2;

            masked5.Location = new System.Drawing.Point(200, 178);
            masked5.Name = "id_trabajador";
            masked5.Mask = "99999";
            masked5.Size = new System.Drawing.Size(39, 20);
            masked5.ValidatingType = typeof(int);
            masked5.TabIndex = 3;


            text4.Location = new System.Drawing.Point(166, 226);
            text4.Name = "correo";
            text4.TabIndex = 4;
            text4.Size = new System.Drawing.Size(100, 20);
            text4.KeyPress += new KeyPressEventHandler(evento_correo);

            masked6.Location = new System.Drawing.Point(182, 271);
            masked6.Name = "telefono";
            masked6.TabIndex = 5;
            masked6.Size = new System.Drawing.Size(77, 20);
            masked6.Mask = "9999999999";


            text5.Location = new System.Drawing.Point(166, 308);
            text5.Name = "curp";
            text5.TabIndex = 6;
            text5.Size = new System.Drawing.Size(100, 20);

            text6.Location = new System.Drawing.Point(368, 10);
            text6.Name = "colonia";
            text6.TabIndex = 7;
            text6.Size = new System.Drawing.Size(100, 20);

            text7.Location = new System.Drawing.Point(368, 59);
            text7.Name = "ciudad";
            text7.TabIndex = 8;
            text7.Size = new System.Drawing.Size(100, 20);

            text8.Location = new System.Drawing.Point(368, 114);
            text8.Name = "id_turno";
            text8.TabIndex = 9;
            text8.Size = new System.Drawing.Size(100, 20);
            text8.ValidatingType = typeof(int);
            text8.Mask = "99999";

            masked7.Location = new System.Drawing.Point(395, 181);
            masked7.TabIndex = 10;
            masked7.Name = "id_puesto";
            masked7.Size = new System.Drawing.Size(39, 20);
            masked7.ValidatingType = typeof(int);
            masked7.Mask = "99999";

            masked8.Location = new System.Drawing.Point(395, 243);
            masked8.TabIndex = 11;
            masked8.Name = "id_datos";
            masked8.Mask = "99999";
            masked8.Size = new System.Drawing.Size(39, 20);

            //Agregar los botones y text a el panel
            Panel_Empleados.Controls.Add(masked5);
            Panel_Empleados.Controls.Add(masked6);
            Panel_Empleados.Controls.Add(masked7);
            Panel_Empleados.Controls.Add(masked8);
            Panel_Empleados.Controls.Add(text1);
            Panel_Empleados.Controls.Add(text2);
            Panel_Empleados.Controls.Add(text3);
            Panel_Empleados.Controls.Add(text4);
            Panel_Empleados.Controls.Add(text5);
            Panel_Empleados.Controls.Add(text6);
            Panel_Empleados.Controls.Add(text7);
            Panel_Empleados.Controls.Add(text8);
            Panel_Empleados.Controls.Add(btn_volver);
            Panel_Empleados.Controls.Add(btn_agregar);
            Panel_Empleados.Controls.Add(l_5.Nombres_Empleado());//Invoca el objeto de la forma y la funcion de la libreria con todas las propiedades,
            //igual en los demas labels
            Panel_Empleados.Controls.Add(l_6.A_P_Empleado());
            Panel_Empleados.Controls.Add(l_7.A_M_Empleado());
            Panel_Empleados.Controls.Add(l_8.Id_Trabajador());
            Panel_Empleados.Controls.Add(l_9.Correo_Empleado());
            Panel_Empleados.Controls.Add(l_10.Telefono_Empleado());
            Panel_Empleados.Controls.Add(l_11.Curp_Empleado());
            Panel_Empleados.Controls.Add(l_12.Colonia_Empleado());
            Panel_Empleados.Controls.Add(l_13.Ciudad_Empleado());
            Panel_Empleados.Controls.Add(l_14.Calle_Empleado());
            Panel_Empleados.Controls.Add(l_15.Numero_Empleado());
            Panel_Empleados.Controls.Add(l_16.CP_Empleado());
        }
        public void evento_correo(object sender, KeyPressEventArgs e)
        {
            //Validar que el usuario solo ingrese ciertos caracteres como @,_,borrar,etc.
            if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == 64 || e.KeyChar == 46 || e.KeyChar == 95 || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }
        public void evento_agregar(object sender, EventArgs e)
        {
            //Si todos los campos estan completos guarda el empleado, sino, tiene que completar el formulario
            if (!string.IsNullOrWhiteSpace(text1.Text) && !string.IsNullOrWhiteSpace(text2.Text) && !string.IsNullOrWhiteSpace(text3.Text) && !string.IsNullOrWhiteSpace(text4.Text) && !string.IsNullOrWhiteSpace(text5.Text) && !string.IsNullOrWhiteSpace(text6.Text) && !string.IsNullOrWhiteSpace(text7.Text) && !string.IsNullOrWhiteSpace(text8.Text) && !string.IsNullOrWhiteSpace(masked5.Text) && !string.IsNullOrWhiteSpace(masked6.Text) && !string.IsNullOrWhiteSpace(masked7.Text) && !string.IsNullOrWhiteSpace(masked8.Text))
            {
                try
                {
                    conexion.Open();
                    MessageBox.Show("Conexion establecida con el servidor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comando = new SqlCommand("INSERT INTO TRABAJADORES (id_Trabajador , id_Datos,id_Turno,id_Puesto, Nombres,Apellido_Paterno,Apellido_Materno,Correo,Telefono,CURP,Colonia,Ciudad)  VALUES('" + this.masked5.Text + " ','" + this.masked8.Text + " ','" + this.text8.Text + "','"+this.masked7.Text+" ','" + this.text1.Text + " ','" + this.text2.Text + " ','" + this.text3.Text + " ','" + this.text4.Text + " ','" + this.masked6.Text + " ','" + this.text5.Text + " ','" + this.text6.Text + " ','" + this.text7.Text + "')", conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Close();
                    MessageBox.Show("Se cerro correctamente la sesion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar_datagrid(data1.dataempleados());
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
            //Oculta el panel y hace visible los elementos de la forma
            Panel_Empleados.Visible = false;
            data1.dataempleados().Visible = true;
            l_1.label1_e().Visible = true;
            l_2.label2_e().Visible = true;
            l_3.label3_e().Visible = true;
            l_4.label4_e().Visible = true;
            masked1.Visible = true;
            masked2.Visible = true;
            masked3.Visible = true;
            masked4.Visible = true;

            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
            btn6.Visible = true;
            cargar_datagrid(data1.dataempleados());
        }
        public void Crear_Botones()
        {
            Thread h1 = new Thread(Ev1);//Creacion del primer hilo
            h1.Start();//Iniciar el primer hilo
            //Creacion de los botones de la forma
            btn1.Location = new System.Drawing.Point(199, 278);
            btn1.Name = "c_trabajador";
            btn1.Size = new System.Drawing.Size(93, 51);
            btn1.TabIndex = 29;
            btn1.Text = "Contratar Trabajador";
            btn1.Click += new System.EventHandler(evento_agregar_cliente);//Muestra el panel
            btn1.UseVisualStyleBackColor = true;
            btn1.TabIndex = 8;


            btn2.Location = new System.Drawing.Point(412, 201);
            btn2.Name = "borrar";
            btn2.Size = new System.Drawing.Size(75, 23);
            btn2.Text = "Borrar";
            btn2.UseVisualStyleBackColor = true;
            btn2.TabIndex = 6;
            btn2.Click += new System.EventHandler(evento_borrar);//Limpia los campos

            btn3.Location = new System.Drawing.Point(412, 150);
            btn3.Name = "button4";
            btn3.Size = new System.Drawing.Size(75, 23);

            btn3.Text = "Modificar";
            btn3.Click += new System.EventHandler(evento_modificar);//Evento modificar
            btn3.UseVisualStyleBackColor = true;
            btn3.TabIndex = 5;

            btn4.Location = new System.Drawing.Point(412, 268);
            btn4.Name = "guar_cambios";
            btn4.TabIndex = 7;
            btn4.Size = new System.Drawing.Size(75, 48);

            //btn4.Text = "Guardar Cambios";
            //btn4.UseVisualStyleBackColor = true;
            //btn4.Visible = false;

            btn5.Location = new System.Drawing.Point(412, 105);
            btn5.Name = "buscar";
            btn5.Size = new System.Drawing.Size(75, 23);

            btn5.Text = "Buscar";
            btn5.UseVisualStyleBackColor = true;
            btn5.TabIndex = 4;
            btn5.Click += new System.EventHandler(evento_buscar);//Busca al empleado

            btn6.Location = new System.Drawing.Point(12, 310);
            btn6.Name = "volver";
            btn6.Size = new System.Drawing.Size(75, 23);

            btn6.Text = "Volver";
            btn6.UseVisualStyleBackColor = true;
            btn6.TabIndex = 9;
            btn6.Click += new System.EventHandler(evento_volver_menu);//Vuelve al inicio
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
            Thread h2 = new Thread(Ev2);//Crear Hilo Para finalizar la forma
            h2.Start();//Iniciar Hilo
            Thread.Sleep(3000);//Dormir el hilo por 3 segundos
            //Oculta la forma actual y muestra la del inicio
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
                    string consulta = "select * from TRABAJADORES where id_Trabajador like '%" + masked1.Text + "%'";
                    comando = new SqlCommand(consulta, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla, "TRABAJADORES");
                    data1.dataempleados().DataSource = tabla;
                    data1.dataempleados().DataMember = "TRABAJADORES";
                    data1.dataempleados().Refresh();
                    conexion.Close();
                }
                else if (masked2.Text != string.Empty)
                {
                    DataSet tabla2 = new DataSet();
                    conexion.Open();
                    string consulta2 = "select * from TRABAJADORES where id_Datos like '%" + masked2.Text + "%'";
                    comando = new SqlCommand(consulta2, conexion);
                    SqlDataAdapter adaptador2 = new SqlDataAdapter(comando);
                    adaptador2.Fill(tabla2, "TRABAJADORES");
                    data1.dataempleados().DataSource = tabla2;
                    data1.dataempleados().DataMember = "TRABAJADORES";
                    data1.dataempleados().Refresh();
                    conexion.Close();
                }
                else if (masked3.Text != string.Empty)
                {
                    DataSet tabla3 = new DataSet();
                    conexion.Open();
                    string consulta3 = "select * from TRABAJADORES where id_Turno like '%" + masked3.Text + "%'";
                    comando = new SqlCommand(consulta3, conexion);
                    SqlDataAdapter adaptador3 = new SqlDataAdapter(comando);
                    adaptador3.Fill(tabla3, "TRABAJADORES");
                    data1.dataempleados().DataSource = tabla3;
                    data1.dataempleados().DataMember = "TRABAJADORES";
                    data1.dataempleados().Refresh();
                    conexion.Close();
                }
                else if (masked4.Text != string.Empty)
                {
                    DataSet tabla4 = new DataSet();
                    conexion.Open();
                    string consulta4 = "select * from TRABAJADORES where id_Puesto like '%" + masked4.Text + "%'";
                    comando = new SqlCommand(consulta4, conexion);
                    SqlDataAdapter adaptador4 = new SqlDataAdapter(comando);
                    adaptador4.Fill(tabla4, "TRABAJADORES");
                    data1.dataempleados().DataSource = tabla4;
                    data1.dataempleados().DataMember = "TRABAJADORES";
                    data1.dataempleados().Refresh();
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
            if (data1.dataempleados().Rows.Count == 0)
            {
                MessageBox.Show("NO HAY ELEMENTOS");
            }
            else
            {
                pos = data1.dataempleados().CurrentRow.Index;
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar El ID Empleado " + data1.dataempleados()[0, pos].Value.ToString() + " ?", "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    conexion.Open();
                    string cadena = "delete from TRABAJADORES where id_Trabajador=" + data1.dataempleados()[0, pos].Value.ToString();
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Se borró el Trabajador con id " + data1.dataempleados()[0, pos].Value.ToString());
                    conexion.Close();
                    cargar_datagrid(data1.dataempleados());
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("No se elimino");
                }
            }
        }
        public void evento_modificar(object sender, EventArgs e)
        {
            int id = data1.dataempleados().SelectedCells[0].RowIndex;
            actualiza_grid(id + 1);
            data1.dataempleados().Refresh();
        }

        public void Crear_Masked()
        {
            //Creacion de las mascaras para los ids
            masked1.Location = new System.Drawing.Point(166, 18);
            masked1.Name = "id_trabajador";
            masked1.Mask = "99999";
            masked1.TabIndex = 0;
            masked1.Size = new System.Drawing.Size(37, 20);
            masked1.ValidatingType = typeof(int);

            masked2.Location = new System.Drawing.Point(333, 12);
            masked2.Name = "id_datos";
            masked2.Mask = "99999";
            masked2.TabIndex = 1;
            masked2.Size = new System.Drawing.Size(37, 20);
            masked2.ValidatingType = typeof(int);

            masked3.Location = new System.Drawing.Point(166, 55);
            masked3.Name = "id_turno";
            masked3.Mask = "99999";
            masked3.TabIndex = 2;
            masked3.Size = new System.Drawing.Size(37, 20);
            masked3.ValidatingType = typeof(int);

            masked4.Location = new System.Drawing.Point(333, 55);
            masked4.Name = "id_puesto";
            masked4.Mask = "99999";
            masked4.TabIndex = 3;
            masked4.Size = new System.Drawing.Size(37, 20);
            masked4.ValidatingType = typeof(int);


            //Agregar las mascaras a la forma
            Controls.Add(masked1);
            Controls.Add(masked2);
            Controls.Add(masked3);
            Controls.Add(masked4);
        }

        public void Crear_Panel()
        {
            //Creacion del panel
            Panel_Empleados.Location = new System.Drawing.Point(0, 0);
            Panel_Empleados.Name = "Panel_Clientes";
            Panel_Empleados.Size = new System.Drawing.Size(517, 400);
            Panel_Empleados.Visible = false;//Esta invisible hasta hacer clic en el boton de agregar cliente
            Panel_Empleados.BackColor = Color.Blue;
            Controls.Add(Panel_Empleados);
        }
        public void evento_agregar_cliente(object sender, EventArgs e)
        {
            //Oculta los elementos de la forma y muestra el panel
            Panel_Empleados.Visible = true;

            data1.dataempleados().Visible = false;
            l_1.label1_e().Visible = false;
            l_2.label2_e().Visible = false;
            l_3.label3_e().Visible = false;
            l_4.label4_e().Visible = false;
            masked1.Visible = false;
            masked2.Visible = false;
            masked3.Visible = false;
            masked4.Visible = false;

            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
            btn4.Visible = false;
            btn5.Visible = false;
            btn6.Visible = false;

        }
        public Empleados()
        {
            //Inicializacion de los componentes y funciones para que se muestren en la forma
            InitializeComponent();
            this.BackColor = Color.Blue;
            Controls.Add(l_1.label1_e());
            Controls.Add(l_2.label2_e());
            Controls.Add(l_3.label3_e());
            Controls.Add(l_4.label4_e());
            Crear_Botones();
            Crear_Masked();

            Componentes_Panel();

            Controls.Add(data1.dataempleados());
            Crear_Panel();

        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            cargar_datagrid(data1.dataempleados());
        }
        private void cargar_datagrid(DataGridView mostrar)
        {
            try
            {
                conexion.Open();
                comando = new SqlCommand("select * from TRABAJADORES", conexion);
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
            int renglon = data1.dataempleados().SelectedCells[0].RowIndex;

            string nombres = data1.dataempleados().Rows[renglon].Cells[4].Value.ToString();
            string apellido_paterno = data1.dataempleados().Rows[renglon].Cells[5].Value.ToString();
            string apellido_materno = data1.dataempleados().Rows[renglon].Cells[6].Value.ToString();
            string correo = data1.dataempleados().Rows[renglon].Cells[7].Value.ToString();
            string tel = data1.dataempleados().Rows[renglon].Cells[8].Value.ToString();
            string colonia = data1.dataempleados().Rows[renglon].Cells[10].Value.ToString();
            string ciudad = data1.dataempleados().Rows[renglon].Cells[11].Value.ToString();
            conexion.Open();
            string consulta = "update TRABAJADORES set Nombres = '" + nombres + "',Apellido_Paterno = '" + apellido_paterno + "',Apellido_Materno='" + apellido_materno + "',Correo='" + correo + "',Telefono='" + tel + "',Colonia='" + colonia + "',Ciudad='" + ciudad + "' where id_Trabajador=" + id;
            comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
