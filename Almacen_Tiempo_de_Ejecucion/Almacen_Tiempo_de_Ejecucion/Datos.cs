using Almacen_Libreria1;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Almacen_Tiempo_de_Ejecucion
{
    public partial class Datos : Form
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-V2DEJSV\\SQLEXPRESS;Initial Catalog=ALMACN_Estrellas_3;Integrated Security=True");
        Button btn1 = new Button();
        Button btn_modificar = new Button();
        Button btn2 = new Button();
        Button btn5 = new Button();
        Button btn6 = new Button();
        Button btn_agregar = new Button();
        Button btn_volver = new Button();
        Class1 data1 = new Class1();
        Class1 l_1 = new Class1();
        Class1 l_2 = new Class1();
        Class1 label_1 = new Class1();
        Class1 label_2 = new Class1();
        Class1 label_3 = new Class1();
        Class1 label_4 = new Class1();
        Class1 label_5 = new Class1();
        Class1 label_6 = new Class1();
        Class1 label_7 = new Class1();
        Class1 label_8 = new Class1();
        Class1 label_9 = new Class1();
        Class1 label_10 = new Class1();
        MaskedTextBox mascara1 = new MaskedTextBox();
        MaskedTextBox mascara2 = new MaskedTextBox();
        MaskedTextBox telefono = new MaskedTextBox();
        MaskedTextBox numero = new MaskedTextBox();
        TextBox text1 = new TextBox();
        TextBox t1 = new TextBox();
        TextBox t2 = new TextBox();
        TextBox t3 = new TextBox();

        TextBox t5 = new TextBox();
        TextBox t6 = new TextBox();
        TextBox t7 = new TextBox();
        TextBox t9 = new TextBox();
        Panel Panel_Datos = new Panel();
        public void Crear_Panel()
        {
            //Creacion del panel
            Panel_Datos.Location = new System.Drawing.Point(0, 0);
            Panel_Datos.Name = "Panel_Datos";
            Panel_Datos.Size = new System.Drawing.Size(517, 400);
            Panel_Datos.Visible = false;//Esta invisible hasta hacer clic en el boton de agregar cliente
            Panel_Datos.BackColor = Color.Blue;
            Controls.Add(Panel_Datos);
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
            btn_agregar.Text = "Agregar Datos";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += new System.EventHandler(evento_agregar);//Agrega un nuevo trabajador
            btn_agregar.TabIndex = 12;

            t1.Location = new System.Drawing.Point(166, 67);
            t1.Name = "nombres";
            t1.Size = new System.Drawing.Size(100, 20);
            t1.TabIndex = 0;

            t2.Location = new System.Drawing.Point(166, 126);
            t2.Name = "a_p";
            t2.Size = new System.Drawing.Size(100, 20);
            t2.TabIndex = 1;

            t3.Location = new System.Drawing.Point(166, 178);
            t3.Name = "a_m";
            t3.Size = new System.Drawing.Size(100, 20);
            t3.TabIndex = 2;

            telefono.Location = new System.Drawing.Point(166, 226);
            telefono.Name = "tel";
            telefono.Size = new System.Drawing.Size(100, 20);
            telefono.TabIndex = 3;
            telefono.ValidatingType = typeof(int);
            telefono.Mask = "9999999999";

            t5.Location = new System.Drawing.Point(166, 271);
            t5.Name = "ciu";
            t5.Size = new System.Drawing.Size(100, 20);
            t5.TabIndex = 4;

            t6.Location = new System.Drawing.Point(166, 308);
            t6.Name = "col";
            t6.Size = new System.Drawing.Size(100, 20);
            t6.TabIndex = 5;

            t7.Location = new System.Drawing.Point(360, 15);
            t7.Name = "call";
            t7.Size = new System.Drawing.Size(100, 20);
            t7.TabIndex = 6;

            numero.Location = new System.Drawing.Point(360, 62);
            numero.Name = "num";
            numero.Size = new System.Drawing.Size(100, 20);
            numero.TabIndex = 7;
            numero.ValidatingType = typeof(int);
            numero.Mask = "99999";

            t9.Location = new System.Drawing.Point(360, 114);
            t9.Name = "rfc";
            t9.Size = new System.Drawing.Size(100, 20);
            t9.TabIndex = 8;

            mascara2.Location = new System.Drawing.Point(200, 19);
            mascara2.Name = "id_datos";
            mascara2.Mask = "99999";
            mascara2.Size = new System.Drawing.Size(39, 20);
            mascara2.ValidatingType = typeof(int);

            Panel_Datos.Controls.Add(mascara2);
            Panel_Datos.Controls.Add(t1);
            Panel_Datos.Controls.Add(t2);
            Panel_Datos.Controls.Add(t3);
            Panel_Datos.Controls.Add(telefono);
            Panel_Datos.Controls.Add(t5);
            Panel_Datos.Controls.Add(t6);
            Panel_Datos.Controls.Add(t7);
            Panel_Datos.Controls.Add(numero);
            Panel_Datos.Controls.Add(t9);
            Panel_Datos.Controls.Add(btn_volver);
            Panel_Datos.Controls.Add(btn_agregar);
            Panel_Datos.Controls.Add(label_1.Id_Datos_Panel());//Invoca el objeto de la forma y la funcion de la libreria con todas las propiedades,
            //igual en los demas labels
            Panel_Datos.Controls.Add(label_2.Nombres_Datos_Panel());
            Panel_Datos.Controls.Add(label_3.A_P_Datos_Panel());
            Panel_Datos.Controls.Add(label_4.A_M_Datos_Panel());
            Panel_Datos.Controls.Add(label_5.Telefono_Datos_Panel());
            Panel_Datos.Controls.Add(label_6.Ciudad_Datos_Panel());
            Panel_Datos.Controls.Add(label_7.Colonia_Datos_Panel());
            Panel_Datos.Controls.Add(label_8.Calle_Datos_Panel());
            Panel_Datos.Controls.Add(label_9.Numero_Datos_Panel());
            Panel_Datos.Controls.Add(label_10.RFC_Datos_Panel());
        }

        public void evento_agregar(object sender, EventArgs e)
        {
            //Si todos los campos estan completos guarda el empleado, sino, tiene que completar el formulario
            if (!string.IsNullOrWhiteSpace(mascara2.Text) && !string.IsNullOrWhiteSpace(t1.Text) && !string.IsNullOrWhiteSpace(t2.Text) && !string.IsNullOrWhiteSpace(t3.Text) && !string.IsNullOrWhiteSpace(telefono.Text) && !string.IsNullOrWhiteSpace(t5.Text) && !string.IsNullOrWhiteSpace(t6.Text) && !string.IsNullOrWhiteSpace(t7.Text) && !string.IsNullOrWhiteSpace(numero.Text) && !string.IsNullOrWhiteSpace(t9.Text))
            {
                try
                {
                    conexion.Open();
                    MessageBox.Show("Conexion establecida con el servidor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comando = new SqlCommand("INSERT INTO DATOS (id_Datos , Nombres,Apellido_Paterno, Apellido_Materno,Telefono,Ciudad,Colonio,Calle,Numero,RFC)  VALUES('" + this.mascara2.Text + " ','" + this.t1.Text + " ','" + this.t2.Text + " ','" + this.t3.Text + " ','" + this.telefono.Text + " ','" + this.t5.Text + " ','" + this.t6.Text + " ','" + this.t7.Text + " ','" + this.numero.Text + " ','" + this.t9.Text + "')", conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Close();
                    MessageBox.Show("Se cerro correctamente la sesion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar_datagrid(data1.datadatos());
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
            Panel_Datos.Visible = false;
            data1.datadatos().Visible = true;
            l_1.Id_Datos_Datos().Visible = true;
            l_2.Nombre_Datos().Visible = true;
            mascara1.Visible = true;
            text1.Visible = true;
            btn1.Visible = true;
            btn2.Visible = true;
            btn_modificar.Visible = true;
            btn5.Visible = true;
            btn6.Visible = true;
            cargar_datagrid(data1.datadatos());
        }
        public Datos()
        {
            InitializeComponent();
            Crear_Botones();
            Controls.Add(data1.datadatos());
            Controls.Add(l_1.Id_Datos_Datos());
            Controls.Add(l_2.Nombre_Datos());
            Crear_Masked_Y_Text();
            Crear_Panel();
            Componentes_Panel();
        }
        public void Crear_Masked_Y_Text()
        {
            //Creacion de las mascaras para los ids
            mascara1.Location = new System.Drawing.Point(210, 18);
            mascara1.Name = "id_trabajador";
            mascara1.Mask = "99999";
            mascara1.TabIndex = 0;
            mascara1.Size = new System.Drawing.Size(37, 20);
            mascara1.ValidatingType = typeof(int);
            text1.Location = new Point(210, 65);
            text1.Name = "nombres";
            text1.Size = new System.Drawing.Size(100, 20);
            //Agregar las mascaras a la forma
            Controls.Add(mascara1);
            Controls.Add(text1);
        }
        public void Crear_Botones()
        {

            btn1.Location = new System.Drawing.Point(199, 278);
            btn1.Name = "c_trabajador";
            btn1.Size = new System.Drawing.Size(93, 51);
            btn1.TabIndex = 29;
            btn1.Text = "Nuevos Datos";
            btn1.Click += new System.EventHandler(evento_agregar_datos);//Muestra el panel
            btn1.UseVisualStyleBackColor = true;
            btn1.TabIndex = 8;


            btn2.Location = new System.Drawing.Point(412, 201);
            btn2.Name = "borrar";
            btn2.Size = new System.Drawing.Size(75, 23);
            btn2.Text = "Borrar";
            btn2.UseVisualStyleBackColor = true;
            btn2.TabIndex = 6;
            btn2.Click += new System.EventHandler(evento_borrar);//Limpia los campos

            btn_modificar.Location = new System.Drawing.Point(412, 150);
            btn_modificar.Name = "button4";
            btn_modificar.Size = new System.Drawing.Size(75, 23);
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += new System.EventHandler(evento_modificar);//Evento modificar

           


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
            Controls.Add(btn_modificar);
            Controls.Add(btn5);
            Controls.Add(btn6);
        }
        public void evento_modificar(object sender, EventArgs e)
        {
            int id = data1.datadatos().SelectedCells[0].RowIndex;
            actualiza_grid(id+1);
            data1.datadatos().Refresh();
        }
        private void actualiza_grid(int id)
        {
            int renglon = data1.datadatos().SelectedCells[0].RowIndex;

            string nombres = data1.datadatos().Rows[renglon].Cells[1].Value.ToString();
            string apellido_paterno = data1.datadatos().Rows[renglon].Cells[2].Value.ToString();
            string apellido_materno = data1.datadatos().Rows[renglon].Cells[3].Value.ToString();
            string tel = data1.datadatos().Rows[renglon].Cells[4].Value.ToString();
            string ciudad = data1.datadatos().Rows[renglon].Cells[5].Value.ToString();
            string colonia = data1.datadatos().Rows[renglon].Cells[6].Value.ToString();
            string calle = data1.datadatos().Rows[renglon].Cells[7].Value.ToString();
            string numero = data1.datadatos().Rows[renglon].Cells[8].Value.ToString();
            string rfc = data1.datadatos().Rows[renglon].Cells[9].Value.ToString();
            conexion.Open();
            string consulta = "update DATOS set Nombres = '" + nombres + "',Apellido_Paterno = '" + apellido_paterno + "',Apellido_Materno='" + apellido_materno + "',Telefono='" + tel + "',Ciudad='" + ciudad + "',Colonio='" + colonia + "',Calle='" + calle + "',Numero='" + numero + "',RFC='" + rfc + "' where id_Datos=" + id;
            comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void evento_borrar(object sender, EventArgs e)
        {
            int pos;
            if (data1.datadatos().Rows.Count == 0)
            {
                MessageBox.Show("NO HAY ELEMENTOS");
            }
            else
            {
                pos = data1.datadatos().CurrentRow.Index;
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar El ID Dato " + data1.datadatos()[0, pos].Value.ToString() + " ?", "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    conexion.Open();
                    string cadena = "delete from DATOS where id_Datos=" + data1.datadatos()[0, pos].Value.ToString();
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                        comando.ExecuteNonQuery();
                    MessageBox.Show("Se borró el Dato con id " + data1.datadatos()[0, pos].Value.ToString());
                    conexion.Close();
                    cargar_datagrid(data1.datadatos());
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
                    string consulta = "select * from DATOS where id_Datos like '%" + mascara1.Text + "%'";
                    comando = new SqlCommand(consulta, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla, "DATOS");
                    data1.datadatos().DataSource = tabla;
                    data1.datadatos().DataMember = "DATOS";
                    data1.datadatos().Refresh();
                    conexion.Close();
                }
                else if (text1.Text != string.Empty)
                {
                    DataSet tabla2 = new DataSet();
                    conexion.Open();
                    string consulta2 = "select * from DATOS where Nombres like '%" + text1.Text + "%'";
                    comando = new SqlCommand(consulta2, conexion);
                    SqlDataAdapter adaptador2 = new SqlDataAdapter(comando);
                    adaptador2.Fill(tabla2, "DATOS");
                    data1.datadatos().DataSource = tabla2;
                    data1.datadatos().DataMember = "DATOS";
                    data1.datadatos().Refresh();
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
        public void evento_agregar_datos(object sender, EventArgs e)
        {
            //Oculta los elementos de la forma y muestra el panel
            Panel_Datos.Visible = true;

            data1.datadatos().Visible = false;
            l_1.Id_Datos_Datos().Visible = false;
            l_2.Nombre_Datos().Visible = false;
            mascara1.Visible = false;
            text1.Visible = false;
            btn1.Visible = false;
            btn2.Visible = false;
            btn_modificar.Visible = false;
            btn5.Visible = false;
            btn6.Visible = false;

        }
        public void evento_volver_menu(object sender, EventArgs e)
        {
            //Oculta la forma actual y muestra la de inicio
            Form1 almacen = new Form1();
            almacen.Show();
            this.Hide();
        }
        private void Datos_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
            cargar_datagrid(data1.datadatos());
        }
        private void cargar_datagrid(DataGridView mostrar)
        {
            try
            {
                conexion.Open();
                comando = new SqlCommand("select * from DATOS", conexion);
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
