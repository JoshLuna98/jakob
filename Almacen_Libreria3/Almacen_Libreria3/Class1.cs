using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Almacen_Libreria3
{
    public class Class1
    {
        //Productos-----------------------
        //aqui creamos los componentes que se van a utilizar en ejecucion de productos
        Label Prolabel1 = new Label();//Creamos los componentes label
        Label Prolabel2 = new Label();
        Label Prolabel3 = new Label();
        Label Prolabel4 = new Label();
        Label Prolabel5 = new Label();
        Label Prolabel6 = new Label();
        MaskedTextBox ProMaskedTextBox1 = new MaskedTextBox();//un componente masked 
        TextBox ProtextBox1 = new TextBox();
        TextBox ProtextBox2 = new TextBox();//y los componentes de texbboxt
        TextBox ProtextBox3 = new TextBox();
        TextBox ProtextBox4 = new TextBox();
        TextBox ProtextBox5 = new TextBox();
        //TextBox ProtextBox6 = new TextBox();
        Button ProBtn_Guardar = new Button();
        Button ProBtn_Volver = new Button();
        Panel ProPaneles = new Panel();
        //------------------------------------------
        public Label ProductosLabel1()
        {
            //Aqui creamos los metodos para mostra los label en from...
            Prolabel1.Location = new System.Drawing.Point(0, 0);
            Prolabel1.Name = "label.ID_Proveedor";
            Prolabel1.Size = new System.Drawing.Size(70, 25);
            Prolabel1.Text = "ID_Producto";
            return Prolabel1;
        }
        public Label ProductosLabel2()
        {
            //Aqui creamos los metodos para mostra los label en from...
            Prolabel2.Location = new System.Drawing.Point(0, 50);
            Prolabel2.Name = "label.CantidadProductos";
            Prolabel2.Size = new System.Drawing.Size(120, 25);
            Prolabel2.Text = "Cantidad De Productos";
            return Prolabel2;
        }
        public Label ProductosLabel3()
        {
            //Aqui creamos los metodos para mostra los label en from...
            Prolabel3.Location = new System.Drawing.Point(0, 100);
            Prolabel3.Name = "label.Descripcion_de_productos";
            Prolabel3.Size = new System.Drawing.Size(120, 25);
            Prolabel3.Text = "Descripcion de productos";
            return Prolabel3;
        }
        public Label ProductosLabel4()
        {
            //Aqui creamos los metodos para mostra los label en from...
            Prolabel4.Location = new System.Drawing.Point(0, 150);
            Prolabel4.Name = "label.Precio";
            Prolabel4.Size = new System.Drawing.Size(75, 25);
            Prolabel4.Text = "Precio";
            return Prolabel4;
        }
        public Label ProductosLabel5()
        {
            //Aqui creamos los metodos para mostra los label en from...
            Prolabel5.Location = new System.Drawing.Point(0, 200);
            Prolabel5.Name = "label.Marca";
            Prolabel5.Size = new System.Drawing.Size(75, 25);
            Prolabel5.Text = "Marca";
            return Prolabel5;
        }
        public Label ProductosLabel6()
        {
            //Aqui creamos los metodos para mostra los label en from...
            Prolabel6.Location = new System.Drawing.Point(0, 250);
            Prolabel6.Name = "label.Garantia";
            Prolabel6.Size = new System.Drawing.Size(75, 25);
            Prolabel6.Text = "Garantia";
            return Prolabel6;
        }
        //label----------------------------------------
        //-------------------------------------------
        public MaskedTextBox productosmaskedTexBox()
        {
            //Aqui creamos los metodos para mostra los maskedtexbox en from...
            ProMaskedTextBox1.Location = new System.Drawing.Point(80, 0);
            ProMaskedTextBox1.Name = "MasTxt_ID_Producto";
            ProMaskedTextBox1.Size = new System.Drawing.Size(60, 25);
            ProMaskedTextBox1.Mask = "99999";
            ProMaskedTextBox1.ValidatingType = typeof(int);
            ProMaskedTextBox1.TabIndex = 1;
            return ProMaskedTextBox1;
        }
        public TextBox productosTexBox1()
        {
            //Aqui creamos los metodos para mostra los texbox en from...
            ProtextBox1.Location = new System.Drawing.Point(130, 50);
            ProtextBox1.Name = "Txt_CantidadProductos";
            ProtextBox1.Size = new System.Drawing.Size(125, 23);
            ProtextBox1.TabIndex = 2;
            // txt1.ReadOnly = true;
            return ProtextBox1;
        }
        public TextBox productosTexBox2()
        {
            //Aqui creamos los metodos para mostra los texbox en from...
            ProtextBox2.Location = new System.Drawing.Point(130, 100);
            ProtextBox2.Name = "Txt_Descripcion_de_productos";
            ProtextBox2.Size = new System.Drawing.Size(125, 23);
            ProtextBox2.TabIndex = 3;
            // txt1.ReadOnly = true;
            return ProtextBox2;
        }
        public TextBox productosTexBox3()
        {
            //Aqui creamos los metodos para mostra los texbox en from...
            ProtextBox3.Location = new System.Drawing.Point(80, 150);
            ProtextBox3.Name = "Txt_Precio";
            ProtextBox3.Size = new System.Drawing.Size(125, 23);
            ProtextBox3.TabIndex = 4;
            // txt1.ReadOnly = true;
            return ProtextBox3;
        }
        public TextBox productosTexBox4()
        {
            //Aqui creamos los metodos para mostra los texbox en from...
            ProtextBox4.Location = new System.Drawing.Point(80, 200);
            ProtextBox4.Name = "Txt_Marca";
            ProtextBox4.Size = new System.Drawing.Size(125, 23);
            ProtextBox4.TabIndex = 5;
            // txt1.ReadOnly = true;
            return ProtextBox4;
        }
        public TextBox productosTexBox5()
        {
            //Aqui creamos los metodos para mostra los texbox en from...
            ProtextBox5.Location = new System.Drawing.Point(80, 250);
            ProtextBox5.Name = "Txt_Garantia";
            ProtextBox5.Size = new System.Drawing.Size(125, 23);
            ProtextBox5.TabIndex = 6;
            // txt1.ReadOnly = true;
            return ProtextBox5;
        }
        //texbox-------------------------------------------------
        //-------------------------------------------------------
        //public Button guardar()
        //{
        //    // Aqui creamos los metodos para mostra los Botones en from...
        //    ProBtn_Guardar.Location = new System.Drawing.Point(300, 100);
        //    ProBtn_Guardar.Name = "btn_Guardar";
        //    ProBtn_Guardar.Text = "Guardar";
        //    ProBtn_Guardar.Size = new System.Drawing.Size(90, 70);
        //    return ProBtn_Guardar;
        //}
        public Button volver()
        {
            // Aqui creamos los metodos para mostra los Botones en from...
            ProBtn_Volver.Location = new System.Drawing.Point(300, 200);
            ProBtn_Volver.Name = "btn_volver";
            ProBtn_Volver.Text = "Volver";
            ProBtn_Volver.Size = new System.Drawing.Size(90, 70);
            return ProBtn_Volver;
        }
        public Panel Panel1()
        {    // Aqui creamos los metodos para mostra el panel en from...
            ProPaneles.Dock = DockStyle.Fill;
            ProPaneles.Location = new Point(0, 0);
            ProPaneles.Name = "Panel";
            ProPaneles.Size = new Size(594, 489);
            ProPaneles.BackColor = Color.CadetBlue;
            return ProPaneles;
        }
        //Botones------------------------------------------------

        //Mobiliario---------------------------------
        Panel Mobipaneles2 = new Panel(); //Creamos los componentes label
        Label Mobilabel1 = new Label();
        Label Mobilabel2 = new Label();
        Label Mobilabel3 = new Label();
        Label Mobilabel4 = new Label();
        MaskedTextBox MobiMaskedTextBox1 = new MaskedTextBox(); //Creamos los componentes Maskedtexbox
        TextBox MobitextBox1 = new TextBox(); //Creamos los componentes texBox
        TextBox MobitextBox2 = new TextBox();
        TextBox MobitextBox3 = new TextBox();
        TextBox MobitextBox4 = new TextBox();
        Button Mobibtn_Guardar = new Button();
        Button Mobibtn_Volver = new Button();

        public Label MobiliarioLabe1()
        {
            //Aqui creamos los metodos para mostra los label en from...
            Mobilabel1.Location = new System.Drawing.Point(0, 0);
            Mobilabel1.Name = "label.ID_Moviliario";
            Mobilabel1.Size = new System.Drawing.Size(70, 25);
            Mobilabel1.Text = "ID_Moviliario";
            return Mobilabel1;
        }
        public Label MobiliarioLabe2()
        {
            //Aqui creamos los metodos para mostra los label en from...
            Mobilabel2.Location = new System.Drawing.Point(0, 50);
            Mobilabel2.Name = "label.CantidadMoviliario";
            Mobilabel2.Size = new System.Drawing.Size(120, 25);
            Mobilabel2.Text = "Cantidad De Moviliario";
            return Mobilabel2;
        }
        public Label MobiliarioLabe3()
        {//Aqui creamos los metodos para mostra los label en from...
            Mobilabel3.Location = new System.Drawing.Point(0, 100);
            Mobilabel3.Name = "label.Descripcion_de_Moviliario";
            Mobilabel3.Size = new System.Drawing.Size(120, 25);
            Mobilabel3.Text = "Descripcion de Moviliario";
            return Mobilabel3;
        }
        public Label MobiliarioLabe4()
        {//Aqui creamos los metodos para mostra los label en from...
            Mobilabel4.Location = new System.Drawing.Point(0, 150);
            Mobilabel4.Name = "label.TipodeMoviliario";
            Mobilabel4.Size = new System.Drawing.Size(120, 25);
            Mobilabel4.Text = "Tipo de Moviliario";
            return Mobilabel4;
        }

        public MaskedTextBox MasketexBoxMobiliario1()
        {
            //Aqui creamos los metodos para mostra los Maskedtexbox en from...
            MobiMaskedTextBox1.Location = new System.Drawing.Point(80, 0);
            MobiMaskedTextBox1.Name = "MasTxt_ID_Moviliario";
            MobiMaskedTextBox1.Size = new System.Drawing.Size(60, 25);
            MobiMaskedTextBox1.Mask = "99999";
            MobiMaskedTextBox1.ValidatingType = typeof(int);
            MobiMaskedTextBox1.TabIndex = 1;
            return MobiMaskedTextBox1;
        }
        public TextBox textBoxMobiliario2()
        {
            //Aqui creamos los metodos para mostra los texbox label maskedtexbox en from...
            MobitextBox1.Location = new System.Drawing.Point(130, 50);
            MobitextBox1.Name = "Txt_CantidadMoviliario";
            MobitextBox1.Size = new System.Drawing.Size(125, 23);

            MobitextBox1.TabIndex = 2;
            // txt1.ReadOnly = true;
            return MobitextBox1;
        }
        public TextBox textBoxMobiliario3()
        {//Aqui creamos los metodos para mostra los texbox en from...
            MobitextBox1.Location = new System.Drawing.Point(130, 100);
            MobitextBox1.Name = "Txt_Descripcion_de_Moviliario";
            MobitextBox1.Size = new System.Drawing.Size(125, 23);
            MobitextBox1.TabIndex = 3;
            // txt1.ReadOnly = true;
            return MobitextBox1;
        }
        public TextBox textBoxMobiliario4()
        {
            //Aqui creamos los metodos para mostra los texbox en from...
            MobitextBox1.Location = new System.Drawing.Point(100, 150);
            MobitextBox1.Name = "Txt_TipodeMoviliario";
            MobitextBox1.Size = new System.Drawing.Size(125, 23);
            MobitextBox1.TabIndex = 4;
            return MobitextBox1;
        }

        //public Button MobiliarioBotonGuardar()
        //{ //Aqui creamos los metodos para mostra los botones en from...
        //    Mobibtn_Guardar.Location = new Point(300, 100);
        //    Mobibtn_Guardar.Name = "btn_Guardar";
        //    Mobibtn_Guardar.Text = "Guardar";
        //    Mobibtn_Guardar.Size = new Size(90, 70);
        //    return Mobibtn_Guardar;
        //}
        public Button MobiliarioBotonVolver()
        {
            //Aqui creamos los metodos para mostra los botones en from...
            Mobibtn_Volver.Location = new Point(300, 200);
            Mobibtn_Volver.Name = "btn_volver";
            Mobibtn_Volver.Text = "Volver";
            Mobibtn_Volver.Size = new Size(90, 70);
            return Mobibtn_Volver;
        }

        public Panel MobiliarioPanel()
        {
            Mobipaneles2.Dock = DockStyle.Fill;
            Mobipaneles2.Location = new Point(0, 0);
            Mobipaneles2.Name = "Panel";
            Mobipaneles2.Size = new Size(594, 489);
            Mobipaneles2.BackColor = Color.CadetBlue;

            return Mobipaneles2;
        }

        //Mobiliario---------------------------------

        //CONSULTAS-------------------------------------
        Label Conlabel1 = new Label(); //Creamos los componentes label
        Label Conlabel2 = new Label();
        MaskedTextBox ConMaskedTextBox1 = new MaskedTextBox(); //Creamos los componentes maskedtexbox
        MaskedTextBox ConMaskedTextBox2 = new MaskedTextBox();
        Button Conbtn_Checar = new Button(); //Creamos los componentes botones
        Button Conbtn_Volver = new Button();
        Panel Conpaneles = new Panel();
        DataGridView data = new DataGridView(); //Creamo el componente DataGridView
        DataGridView data2 = new DataGridView(); //Creamo el componente DataGridView
        public Label ConsultaLabel1()
        {//Aqui creamos los metodos para mostra los label en from...
            Conlabel1.Location = new System.Drawing.Point(200, 0);
            Conlabel1.Name = "label.ID_Proveedor";
            Conlabel1.Size = new System.Drawing.Size(70, 25);
            Conlabel1.Text = "ID_Mobiliario";
            return Conlabel1;
        }

        public Label ConsultaLabel2()
        {//Aqui creamos los metodos para mostra los label en from...
            Conlabel2.Location = new System.Drawing.Point(550, 0);
            Conlabel2.Name = "label.ID_Moviliario";
            Conlabel2.Size = new System.Drawing.Size(75, 25);
            Conlabel2.Text = "ID_Producto";

            return Conlabel2;
        }

        public MaskedTextBox ConsultaMaskedTexBox1()
        {
            //Aqui creamos los metodos para mostra los maskedtexbox en from...
            ConMaskedTextBox1.Location = new System.Drawing.Point(290, 5);
            ConMaskedTextBox1.Name = "MasTxt_ID_Producto";
            ConMaskedTextBox1.Size = new System.Drawing.Size(60, 25);
            ConMaskedTextBox1.TabIndex = 1;
            return ConMaskedTextBox1;
        }
        public MaskedTextBox ConsultaMaskedTexBox2()
        {//Aqui creamos los metodos para mostra los maskedtexbox en from...
            ConMaskedTextBox2.Location = new System.Drawing.Point(640, 5);
            ConMaskedTextBox2.Name = "MasTxt_ID_Producto";
            ConMaskedTextBox2.Size = new System.Drawing.Size(60, 25);
            ConMaskedTextBox2.TabIndex = 2;
            return ConMaskedTextBox2;
        }
        public Button ConsultaBotonChecar()
        {
            //Aqui creamos los metodos para mostra los botones en from...
            Conbtn_Checar.Location = new System.Drawing.Point(0, 100);
            Conbtn_Checar.Name = "btn_Checar";
            Conbtn_Checar.Text = "Checar";
            Conbtn_Checar.Size = new System.Drawing.Size(90, 70);
            return Conbtn_Checar;
        }
        public Button ConsultaBotonVolver()
        {
            //Aqui creamos los metodos para mostra los botones en from...
            Conbtn_Volver.Location = new System.Drawing.Point(0, 200);
            Conbtn_Volver.Name = "btn_volver";
            Conbtn_Volver.Text = "Volver";
            Conbtn_Volver.Size = new System.Drawing.Size(90, 70);
            return Conbtn_Volver;
        }

        public DataGridView ConsultaDatGriid()
        {
            //Aqui creamos los metodos para mostra los DataGridView en from...
            data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data.Location = new System.Drawing.Point(150, 150);
            data.Name = "dataGridView1";
            data.TabIndex = 10;
            data.Size = new System.Drawing.Size(273, 150);
            return data;
        }
        public DataGridView ConsultaDatGriid2()
        {
            //Aqui creamos los metodos para mostra los DataGridView en from...
            data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data2.Location = new System.Drawing.Point(500, 150);
            data2.Name = "dataGridView1";
            data2.TabIndex = 10;
            data2.Size = new System.Drawing.Size(273, 150);
            return data2;
        }
    }
}
