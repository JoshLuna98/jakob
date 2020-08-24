using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Almacen_Libreria1;


namespace Almacen_Tiempo_de_Ejecucion
{
    public partial class Form1 : Form
    {
        //Se crea el menu para seleccion algun departamento del almacen
        Class1 imagen_almacen = new Class1();
        Class1 boton = new Class1();
        MenuStrip menuStrip1 = new MenuStrip();
        ToolStripMenuItem acercaDeLaEmpresaToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem acercamenuToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem datosToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem almacenToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem productosToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem productosmenuToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem cotizacionesToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem inventarioToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem proveedoresToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem proveedoresmenuToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem proveedoreslocalToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem proveedoresextToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem comprasToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem empleadosToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem clientesToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem consultasToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem mobiliarioToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem ayudaToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem infrToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem turnoToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem puestoToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem ticketsToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem ventasToolStripMenuItem = new ToolStripMenuItem();

        public void menu()
        {
            //Se crean las opciones del menu
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            acercaDeLaEmpresaToolStripMenuItem,
            productosToolStripMenuItem,
            inventarioToolStripMenuItem,
            proveedoresToolStripMenuItem,
            empleadosToolStripMenuItem,
            clientesToolStripMenuItem,
            consultasToolStripMenuItem,
            mobiliarioToolStripMenuItem,
            ayudaToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(574, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // acercaDeLaEmpresaToolStripMenuItem
            // 
            acercaDeLaEmpresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            datosToolStripMenuItem,
            almacenToolStripMenuItem
            });
            acercaDeLaEmpresaToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            acercaDeLaEmpresaToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            acercaDeLaEmpresaToolStripMenuItem.Text = "Acerca de la Empresa";


            //acercamenuToolStripMenuItem.Name = "acercaToolStripMenuItem";
            //acercamenuToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            //acercamenuToolStripMenuItem.Text = "Acerca";
            //acercamenuToolStripMenuItem.Click += new System.EventHandler(Cambiar_Acerca);

            datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            datosToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            datosToolStripMenuItem.Text = "Datos";
            datosToolStripMenuItem.Click += new System.EventHandler(Cambiar_Datos);

            almacenToolStripMenuItem.Name = "almacenToolStripMenuItem";
            almacenToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            almacenToolStripMenuItem.Text = "Almacen";
            almacenToolStripMenuItem.Click += new System.EventHandler(Cambiar_Almacen);
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            productosmenuToolStripMenuItem,
            cotizacionesToolStripMenuItem
            });
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            productosToolStripMenuItem.Text = "Productos";

            productosmenuToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosmenuToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            productosmenuToolStripMenuItem.Text = "Productos";
            productosmenuToolStripMenuItem.Click += new System.EventHandler(Cambiar_Productos);

            cotizacionesToolStripMenuItem.Name = "productosToolStripMenuItem";
            cotizacionesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            cotizacionesToolStripMenuItem.Text = "Cotizaciones";
            cotizacionesToolStripMenuItem.Click += new System.EventHandler(Cambiar_Cotizaciones);

            
            //this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 

            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            inventarioToolStripMenuItem.Text = "Inventario";
            inventarioToolStripMenuItem.Click += new System.EventHandler(evento_inventario);

            // proveedoresToolStripMenuItem
            // 

            proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            proveedoresmenuToolStripMenuItem,
            proveedoreslocalToolStripMenuItem,
            proveedoresextToolStripMenuItem,
            comprasToolStripMenuItem
            });
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            proveedoresToolStripMenuItem.Text = "Proveedores";



            proveedoresmenuToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresmenuToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            proveedoresmenuToolStripMenuItem.Text = "Proveedores";
            proveedoresmenuToolStripMenuItem.Click += new System.EventHandler(Cambiar_Proveedores);

            proveedoreslocalToolStripMenuItem.Name = "proveedoreslocalToolStripMenuItem";
            proveedoreslocalToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            proveedoreslocalToolStripMenuItem.Text = "Proveedores Locales";
            proveedoreslocalToolStripMenuItem.Click += new System.EventHandler(Cambiar_Proveedores_Local);

            proveedoresextToolStripMenuItem.Name = "proveedoresextToolStripMenuItem";
            proveedoresextToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            proveedoresextToolStripMenuItem.Text = "Proveedores Extranjeros";
            proveedoresextToolStripMenuItem.Click += new System.EventHandler(Cambiar_Proveedores_Ext);

            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            comprasToolStripMenuItem.Text = "Compras";
            comprasToolStripMenuItem.Click += new System.EventHandler(Cambiar_Compras);
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            infrToolStripMenuItem,
            ventasToolStripMenuItem,
            turnoToolStripMenuItem,
            ticketsToolStripMenuItem,
            puestoToolStripMenuItem});
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // infrToolStripMenuItem
            // 
            infrToolStripMenuItem.Name = "infrToolStripMenuItem";
            infrToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            infrToolStripMenuItem.Text = "Información";
            infrToolStripMenuItem.Click += new System.EventHandler(Cambiar_Empleados);
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            ventasToolStripMenuItem.Text = "Ventas";
            ventasToolStripMenuItem.Click += new System.EventHandler(Cambiar_Ventas);
            // ventasToolStripMenuItem
            // 
            turnoToolStripMenuItem.Name = "turnoToolStripMenuItem";
            turnoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            turnoToolStripMenuItem.Text = "Turnos";
            turnoToolStripMenuItem.Click += new System.EventHandler(Cambiar_Turnos);

            ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            ticketsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            ticketsToolStripMenuItem.Text = "Tickets";
            ticketsToolStripMenuItem.Click += new System.EventHandler(Cambiar_Tickets);

            puestoToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            puestoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            puestoToolStripMenuItem.Text = "Puestos";
            puestoToolStripMenuItem.Click += new System.EventHandler(Cambiar_Puesto);
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += new System.EventHandler(Cambiar_Clientes);
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            consultasToolStripMenuItem.Text = "Consultas";
            consultasToolStripMenuItem.Click += new System.EventHandler(Cambiar_ConsultasMyP);
            // mobiliarioToolStripMenuItem
            // 
            mobiliarioToolStripMenuItem.Name = "mobiliarioToolStripMenuItem";
            mobiliarioToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            mobiliarioToolStripMenuItem.Text = "Mobiliario";
            mobiliarioToolStripMenuItem.Click += new System.EventHandler(Cambiar_Mobiliario);
            //
            // 
            // ayudaToolStripMenuItem
            // 
           // ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
           // ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
           // ayudaToolStripMenuItem.Text = "Ayuda";
           //ayudaToolStripMenuItem.Click += new System.EventHandler(evento_ayuda);
            Controls.Add(menuStrip1);

        }
       
        public void evento_inventario(object sender, EventArgs e)
        {
            //Cambia a la forma
            Inventario inventario = new Inventario();
            inventario.Show();
            this.Hide();
        }
        
        public void Cambiar_Almacen(object sender, EventArgs e)
        {
            //Cambia a la forma
            Almacen almacen = new Almacen();
            almacen.Show();
            this.Hide();
        }
        public void Cambiar_Clientes(object sender, EventArgs e)
        {
            //Cambia a la forma
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }
        public void Cambiar_Compras(object sender, EventArgs e)
        {
            //Cambia a la forma
            Compras compras = new Compras();
            compras.Show();
            this.Hide();
        }
        public void Cambiar_Puesto(object sender, EventArgs e)
        {
            //Cambia a la forma
            Puesto puesto = new Puesto();
            puesto.Show();
            this.Hide();
        }
       
        public void Cambiar_Empleados(object sender, EventArgs e)
        {
            //Cambia a la forma
            Empleados empleados = new Empleados();
            empleados.Show();
            this.Hide();
        }
        public void Cambiar_Tickets(object sender, EventArgs e)
        {
            //Cambia a la forma
            Tickets tickets = new Tickets();
            tickets.Show();
            this.Hide();
        }
        public void Cambiar_Ventas(object sender, EventArgs e)
        {
            //Cambia a la forma
            Ventas ventas = new Ventas();
            ventas.Show();
            this.Hide();
        }
        public void Cambiar_Turnos(object sender, EventArgs e)
        {
            //Cambia a la forma
            Turnos turnos = new Turnos();
            turnos.Show();
            this.Hide();
        }
        public void Cambiar_Proveedores(object sender, EventArgs e)
        {
            //Cambia a la forma
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            this.Hide();
        }
        public void Cambiar_Proveedores_Local(object sender, EventArgs e)
        {
            //Cambia a la forma
            Pro_Local proveedores_local = new Pro_Local();
            proveedores_local.Show();
            this.Hide();
        }
        public void Cambiar_Proveedores_Ext(object sender, EventArgs e)
        {
            //Cambia a la forma
            Pro_Ext proveedores_ext = new Pro_Ext();
            proveedores_ext.Show();
            this.Hide();
        }
        //----------------------------------------
        public void Cambiar_Productos(object sender, EventArgs e)
        {
            //Cambia a la forma
            Productos pro = new Productos();
            pro.Show();
            this.Hide();
        }
        public void Cambiar_Cotizaciones(object sender, EventArgs e)
        {
            //Cambia a la forma
            Cotizaciones cotizaciones = new Cotizaciones();
            cotizaciones.Show();
            this.Hide();
        }
        public void Cambiar_Datos(object sender, EventArgs e)
        {
            //Cambia a la forma
            Datos datos = new Datos();
            datos.Show();
            this.Hide();
        }

        public void Cambiar_Mobiliario(object sender, EventArgs e)
        {
            //Cambia a la forma
            Movbiliario movi = new Movbiliario();
            movi.Show();
            this.Hide();
        }
        public void Cambiar_ConsultasMyP(object sender, EventArgs e)
        {
            //Cambia a la forma
            Consultas consultas = new Consultas();
            consultas.Show();
            this.Hide();
        }

        //--------------------------------------------
        public Form1()
        {
            InitializeComponent();

            menu();
            
            //Controls.Add(boton.Salir());
            Crear_Boton();
            Controls.Add(imagen_almacen.picture());
        }
        public void Crear_Boton()
        {
            Button btn_salir = new Button();
            btn_salir.BackColor = System.Drawing.Color.Black;
            btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_salir.ForeColor = System.Drawing.Color.White;
            btn_salir.Location = new System.Drawing.Point(12, 303);
            btn_salir.Name = "button1";
            btn_salir.Size = new System.Drawing.Size(123, 39);
            btn_salir.Text = "Volver";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += new System.EventHandler(evento_volver);
            Controls.Add(btn_salir);
        }
        public void evento_volver(object sender, EventArgs e)
        {
            this.Hide();
            Pantalla_Inicio pantalla_Inicio = new Pantalla_Inicio();
            pantalla_Inicio.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
