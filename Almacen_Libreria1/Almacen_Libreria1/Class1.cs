using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Almacen_Libreria1
{
    public class Class1
    {
        DataGridView data_clientes = new DataGridView();//Creacion del objeto de Data clientes
        DataGridView data_proveedores = new DataGridView();//Creacion del objeto de Data proveedores
        DataGridView data_empleados = new DataGridView();//Creacion del objeto de Data empleados
        DataGridView data_ventas = new DataGridView();//Creacion del objeto de Data ventas
        DataGridView data_turnos = new DataGridView();
        DataGridView data_datos = new DataGridView();
        DataGridView data_tickets = new DataGridView();
        DataGridView data_puesto = new DataGridView();
        DataGridView data_almacen = new DataGridView();
        DataGridView data_cotizaciones = new DataGridView();
        DataGridView data_pro_local = new DataGridView();
        DataGridView data_pro_ext = new DataGridView();
        DataGridView data_compras = new DataGridView();
        //Labels de la forma pro_ext
        Label label1_compras = new Label();
        Label label2_compras = new Label();

        //Labels de la forma pro_ext
        Label label1_pro_ext = new Label();
        Label label2_pro_ext = new Label();
        //Labels de la forma pro_local
        Label label1_pro_local = new Label();
        Label label2_pro_local = new Label();
        //Labels de la forma cotizaciones
        Label label1_cotizaciones = new Label();
        Label label2_cotizaciones = new Label();

        //Labels de la forma almacen
        Label label1_almacen = new Label();
        Label label2_almacen = new Label();

        //Labels _panel_puesto
        Label l1_puesto_panel = new Label();
        Label l2_puesto_panel = new Label();
        Label l3_puesto_panel = new Label();
        Label l4_puesto_panel = new Label();
        //Labels de la forma puesto
        Label label1_puesto = new Label();
        Label label2_puesto = new Label();
        //Labels panel_datos
        Label id = new Label();
        Label nombres_datos = new Label();
        Label a_m_datos = new Label();
        Label a_p_datos = new Label();
        Label tel_datos = new Label();
        Label ciudad_datos = new Label();
        Label colonia_datos = new Label();
        Label calle_datos = new Label();
        Label numero_datos = new Label();
        Label rfc_datos = new Label();
        //Labels de la forma Turnos
        Label l_1_turno = new Label();
        Label l_2_turno = new Label();
        Label l_3_turno = new Label();

        //Labels de la forma Datos
        Label l_1_datos = new Label();
        Label l_2_datos = new Label();
        //Labels de la forma Tickets
        Label label1_tickets = new Label();
        Label label2_tickets = new Label();

        //Labels panel_turnos
        Label l_id_turno = new Label();
        Label l_tipo_turno = new Label();
        Label l_id_puesto = new Label();

        //Creacion de los otros objetos de la libreria
        PictureBox imagen = new PictureBox();
        Button btn_salir = new Button();
        //Labels de la forma clientes
        Label l_1 = new Label();
        Label l_2 = new Label();
        Label l_3 = new Label();
        Label l_4 = new Label();

        //Labels de la forma proveedores
        Label l1_p = new Label();
        Label l2_p = new Label();
        Label l3_p = new Label();

        //Labels de la forma empleados
        Label l_1_e = new Label();
        Label l_2_e = new Label();
        Label l_3_e = new Label();
        Label l_4_e = new Label();

        //Labels de la forma ventas
        Label l_1_v = new Label();
        Label l_2_v = new Label();
        Label l_3_v = new Label();
        Label l_4_v = new Label();

        //Labels panel_clientes
        Label n_c = new Label();
        Label a_p_c = new Label();
        Label a_m_c = new Label();
        Label c_c = new Label();
        Label t_c = new Label();
        Label curp_c = new Label();
        Label colonia_c = new Label();
        Label ciudad_c = new Label();
        Label calle_c = new Label();
        Label numero_c = new Label();
        Label cp_c = new Label();

        //Labels _panel_empleados
        Label n_e = new Label();
        Label a_p_e = new Label();
        Label a_m_e = new Label();
        Label id_trabajador = new Label();
        Label c_e = new Label();
        Label t_e = new Label();
        Label curp_e = new Label();
        Label colonia_e = new Label();
        Label ciudad_e = new Label();
        Label calle_e = new Label();
        Label numero_e = new Label();
        Label cp_e = new Label();
        //Labels panel_ventas
        Label id_producto = new Label();
        Label id_proveedor = new Label();
        Label descuento = new Label();
        Label id_cliente = new Label();
        Label garantia = new Label();
        Label id_venta = new Label();
        Label devoluciones = new Label();
        //Labels panel_proveedores
        Label tipo_p = new Label();
        Label id_p = new Label();
        Label id_datos = new Label();
        //Labels _panel_tickets
        Label label1_tickets_panel = new Label();
        Label label2_tickets_panel = new Label();
        Label label3_tickets_panel = new Label();
        //Labels _panel_almacen
        Label label1_almacen_panel = new Label();
        Label label2_almacen_panel = new Label();
        Label label3_almacen_panel = new Label();
        //Labels _panel_cotizaciones
        Label label1_cotizaciones_panel = new Label();
        Label label2_cotizaciones_panel = new Label();
        Label label3_cotizaciones_panel = new Label();
        //Labels _panel_pro_local
        Label label1_pro_local_panel = new Label();
        Label label2_pro_local_panel = new Label();
        //Labels _panel_pro_local
        Label label1_pro_ext_panel = new Label();
        Label label2_pro_ext_panel = new Label();
        //Labels _panel_compras
        Label label1_compras_panel = new Label();
        Label label2_compras_panel = new Label();
        Label label3_compras_panel = new Label();
        Label label4_compras_panel = new Label();

        public Label label1_Compras_P()//Label turno
        {
            label1_compras_panel.AutoSize = true;
            label1_compras_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1_compras_panel.ForeColor = System.Drawing.Color.White;
            label1_compras_panel.Location = new System.Drawing.Point(21, 13);
            label1_compras_panel.Name = "label1";
            label1_compras_panel.Size = new System.Drawing.Size(94, 13);
            label1_compras_panel.Text = "Id Compra:";
            return label1_compras_panel;
        }
        public Label label2_Compras_P()
        {
            //Label id proveedor
            label2_compras_panel.AutoSize = true;
            label2_compras_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2_compras_panel.ForeColor = System.Drawing.Color.White;
            label2_compras_panel.Location = new System.Drawing.Point(21, 66);
            label2_compras_panel.Name = "id_proveed";
            label2_compras_panel.Size = new System.Drawing.Size(87, 13);
            label2_compras_panel.Text = "Id Producto:";
            return label2_compras_panel;//Retorna el label
        }
        public Label label3_Compras_P()
        {
            //Label id proveedor
            label3_compras_panel.AutoSize = true;
            label3_compras_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3_compras_panel.ForeColor = System.Drawing.Color.White;
            label3_compras_panel.Location = new System.Drawing.Point(21, 120);
            label3_compras_panel.Name = "id_proveed";
            label3_compras_panel.Size = new System.Drawing.Size(87, 13);
            label3_compras_panel.Text = "Id Proveedores:";
            return label3_compras_panel;//Retorna el label
        }
        public Label label4_Compras_P()
        {
            //Label id proveedor
            label4_compras_panel.AutoSize = true;
            label4_compras_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4_compras_panel.ForeColor = System.Drawing.Color.White;
            label4_compras_panel.Location = new System.Drawing.Point(21, 170);
            label4_compras_panel.Name = "id_proveed";
            label4_compras_panel.Size = new System.Drawing.Size(87, 13);
            label4_compras_panel.Text = "Id Cotizaciones:";
            return label4_compras_panel;//Retorna el label
        }

        public Label label1_Compras()//Label turno
        {
            label1_compras.AutoSize = true;
            label1_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1_compras.ForeColor = System.Drawing.Color.Black;
            label1_compras.Location = new System.Drawing.Point(11, 7);
            label1_compras.Name = "label1";
            label1_compras.Size = new System.Drawing.Size(94, 13);
            label1_compras.Text = "Id Compra:";
            return label1_compras;
        }
        public Label label2_Compras()
        {
            //Label id proveedor
            label2_compras.AutoSize = true;
            label2_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2_compras.ForeColor = System.Drawing.Color.Black;
            label2_compras.Location = new System.Drawing.Point(21, 50);
            label2_compras.Name = "id_proveed";
            label2_compras.Size = new System.Drawing.Size(87, 13);
            label2_compras.Text = "Id Producto:";
            return label2_compras;//Retorna el label
        }
        public Label label1_Pro_Ext_P()//Label turno
        {
            label1_pro_ext_panel.AutoSize = true;
            label1_pro_ext_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1_pro_ext_panel.ForeColor = System.Drawing.Color.White;
            label1_pro_ext_panel.Location = new System.Drawing.Point(21, 13);
            label1_pro_ext_panel.Name = "label1";
            label1_pro_ext_panel.Size = new System.Drawing.Size(94, 13);
            label1_pro_ext_panel.Text = "Id Proveedor Local:";
            return label1_pro_ext_panel;
        }
        public Label label2_Pro_Ext_P()
        {
            //Label id proveedor
            label2_pro_ext_panel.AutoSize = true;
            label2_pro_ext_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2_pro_ext_panel.ForeColor = System.Drawing.Color.White;
            label2_pro_ext_panel.Location = new System.Drawing.Point(21, 86);
            label2_pro_ext_panel.Name = "id_proveed";
            label2_pro_ext_panel.Size = new System.Drawing.Size(87, 13);
            label2_pro_ext_panel.Text = "Id Datos:";
            return label2_pro_ext_panel;//Retorna el label
        }

        public Label label1_Pro_Ext()//Label turno
        {
            label1_pro_ext.AutoSize = true;
            label1_pro_ext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1_pro_ext.ForeColor = System.Drawing.Color.Black;
            label1_pro_ext.Location = new System.Drawing.Point(11, 7);
            label1_pro_ext.Name = "label1";
            label1_pro_ext.Size = new System.Drawing.Size(94, 13);
            label1_pro_ext.Text = "Id Proveedor Extranjero:";
            return label1_pro_ext;
        }
        public Label label2_Pro_Ext()
        {
            //Label id proveedor
            label2_pro_ext.AutoSize = true;
            label2_pro_ext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2_pro_ext.ForeColor = System.Drawing.Color.Black;
            label2_pro_ext.Location = new System.Drawing.Point(21, 50);
            label2_pro_ext.Name = "id_proveed";
            label2_pro_ext.Size = new System.Drawing.Size(87, 13);
            label2_pro_ext.Text = "Id Datos:";
            return label2_pro_ext;//Retorna el label
        }

        public Label label1_Pro_Local_P()//Label turno
        {
            label1_pro_local_panel.AutoSize = true;
            label1_pro_local_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1_pro_local_panel.ForeColor = System.Drawing.Color.White;
            label1_pro_local_panel.Location = new System.Drawing.Point(21, 13);
            label1_pro_local_panel.Name = "label1";
            label1_pro_local_panel.Size = new System.Drawing.Size(94, 13);
            label1_pro_local_panel.Text = "Id Proveedor Local:";
            return label1_pro_local_panel;
        }
        public Label label2_Pro_Local_P()
        {
            //Label id proveedor
            label2_pro_local_panel.AutoSize = true;
            label2_pro_local_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2_pro_local_panel.ForeColor = System.Drawing.Color.White;
            label2_pro_local_panel.Location = new System.Drawing.Point(21, 86);
            label2_pro_local_panel.Name = "id_proveed";
            label2_pro_local_panel.Size = new System.Drawing.Size(87, 13);
            label2_pro_local_panel.Text = "Id Datos:";
            return label2_pro_local_panel;//Retorna el label
        }
        public Label label1_Pro_Local()//Label turno
        {
            label1_pro_local.AutoSize = true;
            label1_pro_local.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1_pro_local.ForeColor = System.Drawing.Color.Black;
            label1_pro_local.Location = new System.Drawing.Point(21, 7);
            label1_pro_local.Name = "label1";
            label1_pro_local.Size = new System.Drawing.Size(94, 13);
            label1_pro_local.Text = "Id Proveedor Local:";
            return label1_pro_local;
        }
        public Label label2_Pro_Local()
        {
            //Label id proveedor
            label2_pro_local.AutoSize = true;
            label2_pro_local.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2_pro_local.ForeColor = System.Drawing.Color.Black;
            label2_pro_local.Location = new System.Drawing.Point(21, 50);
            label2_pro_local.Name = "id_proveed";
            label2_pro_local.Size = new System.Drawing.Size(87, 13);
            label2_pro_local.Text = "Id Datos:";
            return label2_pro_local;//Retorna el label
        }
        public Label label1_Cotizaciones_P()//Label turno
        {
            label1_cotizaciones_panel.AutoSize = true;
            label1_cotizaciones_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1_cotizaciones_panel.ForeColor = System.Drawing.Color.White;
            label1_cotizaciones_panel.Location = new System.Drawing.Point(21, 13);
            label1_cotizaciones_panel.Name = "label1";
            label1_cotizaciones_panel.Size = new System.Drawing.Size(94, 13);
            label1_cotizaciones_panel.Text = "Id Cotizaciones:";
            return label1_cotizaciones_panel;
        }
        public Label label2_Cotizaciones_P()
        {
            //Label id proveedor
            label2_cotizaciones_panel.AutoSize = true;
            label2_cotizaciones_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2_cotizaciones_panel.ForeColor = System.Drawing.Color.White;
            label2_cotizaciones_panel.Location = new System.Drawing.Point(21, 86);
            label2_cotizaciones_panel.Name = "id_proveed";
            label2_cotizaciones_panel.Size = new System.Drawing.Size(87, 13);
            label2_cotizaciones_panel.Text = "Id Producto:";
            return label2_cotizaciones_panel;//Retorna el label
        }
        public Label label3_Cotizaciones_P()
        {
            //Label id datos
            label3_cotizaciones_panel.AutoSize = true;
            label3_cotizaciones_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3_cotizaciones_panel.ForeColor = System.Drawing.Color.White;
            label3_cotizaciones_panel.Location = new System.Drawing.Point(21, 159);
            label3_cotizaciones_panel.Name = "id_dat";
            label3_cotizaciones_panel.Size = new System.Drawing.Size(62, 13);
            label3_cotizaciones_panel.Text = "Id Proveedores:";
            return label3_cotizaciones_panel;//Retorna el label
        }
        public Label label1_Cotizaciones()//Label turno
        {
            label1_cotizaciones.AutoSize = true;
            label1_cotizaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1_cotizaciones.ForeColor = System.Drawing.Color.Black;
            label1_cotizaciones.Location = new System.Drawing.Point(21, 7);
            label1_cotizaciones.Name = "label1";
            label1_cotizaciones.Size = new System.Drawing.Size(94, 13);
            label1_cotizaciones.Text = "Id Cotizaciones:";
            return label1_cotizaciones;
        }
        public Label label2_Cotizaciones()
        {
            //Label id proveedor
            label2_cotizaciones.AutoSize = true;
            label2_cotizaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2_cotizaciones.ForeColor = System.Drawing.Color.Black;
            label2_cotizaciones.Location = new System.Drawing.Point(21, 50);
            label2_cotizaciones.Name = "id_proveed";
            label2_cotizaciones.Size = new System.Drawing.Size(87, 13);
            label2_cotizaciones.Text = "Id Producto:";
            return label2_cotizaciones;//Retorna el label
        }
        public Label label1_Almacen_P()//Label turno
        {
            label1_almacen_panel.AutoSize = true;
            label1_almacen_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1_almacen_panel.ForeColor = System.Drawing.Color.White;
            label1_almacen_panel.Location = new System.Drawing.Point(21, 13);
            label1_almacen_panel.Name = "label1";
            label1_almacen_panel.Size = new System.Drawing.Size(94, 13);
            label1_almacen_panel.Text = "Id Cotizaciones:";
            return label1_almacen_panel;
        }
        public Label label2_Almacen_P()
        {
            //Label id proveedor
            label2_almacen_panel.AutoSize = true;
            label2_almacen_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2_almacen_panel.ForeColor = System.Drawing.Color.White;
            label2_almacen_panel.Location = new System.Drawing.Point(21, 86);
            label2_almacen_panel.Name = "id_proveed";
            label2_almacen_panel.Size = new System.Drawing.Size(87, 13);
            label2_almacen_panel.Text = "Id Trabajador:";
            return label2_almacen_panel;//Retorna el label
        }
        public Label label3_Almacen_P()
        {
            //Label id datos
            label3_almacen_panel.AutoSize = true;
            label3_almacen_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3_almacen_panel.ForeColor = System.Drawing.Color.White;
            label3_almacen_panel.Location = new System.Drawing.Point(21, 159);
            label3_almacen_panel.Name = "id_dat";
            label3_almacen_panel.Size = new System.Drawing.Size(62, 13);
            label3_almacen_panel.Text = "Id Inventario:";
            return label3_almacen_panel;//Retorna el label
        }
        public Label label1_Almacen()//Label turno
        {
            label1_almacen.AutoSize = true;
            label1_almacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1_almacen.ForeColor = System.Drawing.Color.Black;
            label1_almacen.Location = new System.Drawing.Point(21, 7);
            label1_almacen.Name = "label1";
            label1_almacen.Size = new System.Drawing.Size(94, 13);
            label1_almacen.Text = "Id Cotizaciones:";
            return label1_almacen;
        }
        public Label label2_Almacen()
        {
            //Label id proveedor
            label2_almacen.AutoSize = true;
            label2_almacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2_almacen.ForeColor = System.Drawing.Color.Black;
            label2_almacen.Location = new System.Drawing.Point(21, 50);
            label2_almacen.Name = "id_proveed";
            label2_almacen.Size = new System.Drawing.Size(87, 13);
            label2_almacen.Text = "Id Trabajador:";
            return label2_almacen;//Retorna el label
        }
        public Label label1_Puesto_P()//Label turno
        {
            l1_puesto_panel.AutoSize = true;
            l1_puesto_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l1_puesto_panel.ForeColor = System.Drawing.Color.White;
            l1_puesto_panel.Location = new System.Drawing.Point(21, 13);
            l1_puesto_panel.Name = "label1";
            l1_puesto_panel.Size = new System.Drawing.Size(94, 13);
            l1_puesto_panel.Text = "Id Puesto:";
            return l1_puesto_panel;
        }
        public Label label2_Puesto_P()
        {
            //Label id proveedor
            l2_puesto_panel.AutoSize = true;
            l2_puesto_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l2_puesto_panel.ForeColor = System.Drawing.Color.White;
            l2_puesto_panel.Location = new System.Drawing.Point(21, 86);
            l2_puesto_panel.Name = "id_proveed";
            l2_puesto_panel.Size = new System.Drawing.Size(87, 13);
            l2_puesto_panel.Text = "Tipo Puesto:";
            return l2_puesto_panel;//Retorna el label
        }
        public Label label3_Puesto_P()
        {
            //Label id datos
            l3_puesto_panel.AutoSize = true;
            l3_puesto_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l3_puesto_panel.ForeColor = System.Drawing.Color.White;
            l3_puesto_panel.Location = new System.Drawing.Point(21, 159);
            l3_puesto_panel.Name = "id_dat";
            l3_puesto_panel.Size = new System.Drawing.Size(62, 13);
            l3_puesto_panel.Text = "Id Turno:";
            return l3_puesto_panel;//Retorna el label
        }
        public Label label4_Puesto_P()
        {
            //Label id datos
            l4_puesto_panel.AutoSize = true;
            l4_puesto_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l4_puesto_panel.ForeColor = System.Drawing.Color.White;
            l4_puesto_panel.Location = new System.Drawing.Point(21, 199);
            l4_puesto_panel.Name = "id_dat";
            l4_puesto_panel.Size = new System.Drawing.Size(62, 13);
            l4_puesto_panel.Text = "Id Trabajador:";
            return l4_puesto_panel;//Retorna el label
        }
        public Label label1_Puesto()//Label turno
        {
            label1_puesto.AutoSize = true;
            label1_puesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1_puesto.ForeColor = System.Drawing.Color.Black;
            label1_puesto.Location = new System.Drawing.Point(21, 7);
            label1_puesto.Name = "label1";
            label1_puesto.Size = new System.Drawing.Size(94, 13);
            label1_puesto.Text = "Id Puesto:";
            return label1_puesto;
        }
        public Label label2_Puesto()
        {
            //Label id proveedor
            label2_puesto.AutoSize = true;
            label2_puesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2_puesto.ForeColor = System.Drawing.Color.Black;
            label2_puesto.Location = new System.Drawing.Point(21, 50);
            label2_puesto.Name = "id_proveed";
            label2_puesto.Size = new System.Drawing.Size(87, 13);
            label2_puesto.Text = "Tipo Puesto:";
            return label2_puesto;//Retorna el label
        }
        public Label label1_Ticket_P()//Label turno
        {
            label1_tickets_panel.AutoSize = true;
            label1_tickets_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1_tickets_panel.ForeColor = System.Drawing.Color.White;
            label1_tickets_panel.Location = new System.Drawing.Point(21, 13);
            label1_tickets_panel.Name = "label1";
            label1_tickets_panel.Size = new System.Drawing.Size(94, 13);
            label1_tickets_panel.Text = "Id Ticket:";
            return label1_tickets_panel;
        }
        public Label label2_Tickets_P()
        {
            //Label id proveedor
            label2_tickets_panel.AutoSize = true;
            label2_tickets_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2_tickets_panel.ForeColor = System.Drawing.Color.White;
            label2_tickets_panel.Location = new System.Drawing.Point(21, 86);
            label2_tickets_panel.Name = "id_proveed";
            label2_tickets_panel.Size = new System.Drawing.Size(87, 13);
            label2_tickets_panel.Text = "Id Venta:";
            return label2_tickets_panel;//Retorna el label
        }
        public Label label3_Tickets_P()
        {
            //Label id datos
            label3_tickets_panel.AutoSize = true;
            label3_tickets_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3_tickets_panel.ForeColor = System.Drawing.Color.White;
            label3_tickets_panel.Location = new System.Drawing.Point(21, 159);
            label3_tickets_panel.Name = "id_dat";
            label3_tickets_panel.Size = new System.Drawing.Size(62, 13);
            label3_tickets_panel.Text = "Id Producto:";
            return label3_tickets_panel;//Retorna el label
        }
        public Label label1_Tickets()//Label turno
        {
            label1_tickets.AutoSize = true;
            label1_tickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1_tickets.ForeColor = System.Drawing.Color.Black;
            label1_tickets.Location = new System.Drawing.Point(21, 7);
            label1_tickets.Name = "label1";
            label1_tickets.Size = new System.Drawing.Size(94, 13);
            label1_tickets.Text = "Id_Ticket";
            return label1_tickets;
        }
        public Label label2_Tickets()
        {
            //Label id proveedor
            label2_tickets.AutoSize = true;
            label2_tickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2_tickets.ForeColor = System.Drawing.Color.Black;
            label2_tickets.Location = new System.Drawing.Point(21, 50);
            label2_tickets.Name = "id_proveed";
            label2_tickets.Size = new System.Drawing.Size(87, 13);
            label2_tickets.Text = "Id Venta:";
            return label2_tickets;//Retorna el label
        }
        public Label Id_Datos_Datos()
        {
            //Label nombre del empleado
            n_e.AutoSize = true;
            n_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            n_e.ForeColor = System.Drawing.Color.Black;
            n_e.Location = new System.Drawing.Point(120, 19);
            n_e.Name = "nomb_e";
            n_e.Size = new System.Drawing.Size(60, 13);
            n_e.Text = "ID Datos:";
            return n_e;//Retorna el label
        }
        public Label Nombre_Datos()
        {
            //Label apellido paterno del empleado
            l_1_datos.AutoSize = true;
            l_1_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l_1_datos.ForeColor = System.Drawing.Color.Black;
            l_1_datos.Location = new System.Drawing.Point(120, 67);
            l_1_datos.Name = "ape_p_e";
            l_1_datos.Size = new System.Drawing.Size(104, 13);
            l_1_datos.Text = "Nombres:";
            return l_1_datos;//Retorna el label
        }
        public Label label1_Turnos()//Label turno
        {
            l_1_turno.AutoSize = true;
            l_1_turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l_1_turno.ForeColor = System.Drawing.Color.White;
            l_1_turno.Location = new System.Drawing.Point(21, 7);
            l_1_turno.Name = "label1";
            l_1_turno.Size = new System.Drawing.Size(94, 13);
            l_1_turno.Text = "Id_Turno";
            return l_1_turno;
        }
        public Label label2_Turnos()
        {
            //Label id proveedor
            l_2_turno.AutoSize = true;
            l_2_turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l_2_turno.ForeColor = System.Drawing.Color.White;
            l_2_turno.Location = new System.Drawing.Point(21, 50);
            l_2_turno.Name = "id_proveed";
            l_2_turno.Size = new System.Drawing.Size(87, 13);
            l_2_turno.Text = "Tipo Turno:";
            return l_2_turno;//Retorna el label
        }
        public Label label3_Turnos()
        {
            //Label id datos
            l_3_turno.AutoSize = true;
            l_3_turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l_3_turno.ForeColor = System.Drawing.Color.White;
            l_3_turno.Location = new System.Drawing.Point(21, 95);
            l_3_turno.Name = "id_dat";
            l_3_turno.Size = new System.Drawing.Size(62, 13);
            l_3_turno.Text = "Id_Puesto:";
            return l_3_turno;//Retorna el label
        }
        public Label label1_Turnos_P()//Label turno
        {
            l_id_turno.AutoSize = true;
            l_id_turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l_id_turno.ForeColor = System.Drawing.Color.White;
            l_id_turno.Location = new System.Drawing.Point(21, 13);
            l_id_turno.Name = "label1";
            l_id_turno.Size = new System.Drawing.Size(94, 13);
            l_id_turno.Text = "Id_Turno";
            return l_id_turno;
        }
        public Label label2_Turnos_P()
        {
            //Label id proveedor
            l_tipo_turno.AutoSize = true;
            l_tipo_turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l_tipo_turno.ForeColor = System.Drawing.Color.White;
            l_tipo_turno.Location = new System.Drawing.Point(21, 86);
            l_tipo_turno.Name = "id_proveed";
            l_tipo_turno.Size = new System.Drawing.Size(87, 13);
            l_tipo_turno.Text = "Tipo Turno:";
            return l_tipo_turno;//Retorna el label
        }
        public Label label3_Turnos_P()
        {
            //Label id datos
            l_id_puesto.AutoSize = true;
            l_id_puesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l_id_puesto.ForeColor = System.Drawing.Color.White;
            l_id_puesto.Location = new System.Drawing.Point(21, 159);
            l_id_puesto.Name = "id_dat";
            l_id_puesto.Size = new System.Drawing.Size(62, 13);
            l_id_puesto.Text = "Id_Puesto:";
            return l_id_puesto;//Retorna el label
        }

        public Label label1_v()//Label id_producto para buscar ese producto en una venta
        {
            l_1_v.AutoSize = true;
            l_1_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l_1_v.ForeColor = System.Drawing.Color.White;
            l_1_v.Location = new System.Drawing.Point(34, 23);
            l_1_v.Name = "label1";
            l_1_v.Size = new System.Drawing.Size(80, 13);
            l_1_v.Text = "Id_Producto:";
            return l_1_v;
        }
        public Label label2_v()//Busca el cliente
        {
            l_2_v.AutoSize = true;
            l_2_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l_2_v.ForeColor = System.Drawing.Color.White;
            l_2_v.Location = new System.Drawing.Point(247, 23);
            l_2_v.Name = "label2";
            l_2_v.Size = new System.Drawing.Size(68, 13);
            l_2_v.Text = "Id_Cliente:";
            return l_2_v;
        }
        public Label label3_v()//Label id de venta
        {
            l_3_v.AutoSize = true;
            l_3_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l_3_v.ForeColor = System.Drawing.Color.White;
            l_3_v.Location = new System.Drawing.Point(52, 90);
            l_3_v.Name = "label3";
            l_3_v.Size = new System.Drawing.Size(62, 13);
            l_3_v.Text = "Id_Venta:";
            return l_3_v;
        }
        public Label label4_v()//Label id de proveedor
        {
            l_4_v.AutoSize = true;
            l_4_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l_4_v.ForeColor = System.Drawing.Color.White;
            l_4_v.Location = new System.Drawing.Point(228, 86);
            l_4_v.Name = "label4";
            l_4_v.Size = new System.Drawing.Size(87, 13);
            l_4_v.Text = "Id_Proveedor:";
            return l_4_v;
        }
        public Label label1_e()//Id trabajador para realizar la busqueda de ese trabajador
        {
            l_1_e.AutoSize = true;
            l_1_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l_1_e.ForeColor = System.Drawing.Color.White;
            l_1_e.Location = new System.Drawing.Point(52, 25);
            l_1_e.Name = "id_trabajador";
            l_1_e.Size = new System.Drawing.Size(68, 13);
            l_1_e.Text = "Id_Trabajador:";
            return l_1_e;
        }
        public Label label2_e()//Label id_datos
        {
            l_2_e.AutoSize = true;
            l_2_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l_2_e.ForeColor = System.Drawing.Color.White;
            l_2_e.Location = new System.Drawing.Point(259, 19);
            l_2_e.Name = "datos";
            l_2_e.Size = new System.Drawing.Size(68, 13);
            l_2_e.Text = "Id_Datos:";
            return l_2_e;
        }
        public Label label3_e()//Label id_turno
        {
            l_3_e.AutoSize = true;
            l_3_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l_3_e.ForeColor = System.Drawing.Color.White;
            l_3_e.Location = new System.Drawing.Point(80, 62);
            l_3_e.Name = "turno";
            l_3_e.Size = new System.Drawing.Size(54, 13);
            l_3_e.Text = "Id_Turno:";
            return l_3_e;
        }
        public Label label4_e()//Label puesto para buscar al trabajador
        {
            l_4_e.AutoSize = true;
            l_4_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l_4_e.ForeColor = System.Drawing.Color.White;
            l_4_e.Location = new System.Drawing.Point(259, 62);
            l_4_e.Name = "puesto";
            l_4_e.Size = new System.Drawing.Size(70, 13);
            l_4_e.Text = "Id_Puesto:";
            return l_4_e;
        }

        public Label label1_p()//Label tipo de proveedor
        {
            l1_p.AutoSize = true;
            l1_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l1_p.ForeColor = System.Drawing.Color.White;
            l1_p.Location = new System.Drawing.Point(21, 7);
            l1_p.Name = "label1";
            l1_p.Size = new System.Drawing.Size(94, 13);
            l1_p.Text = "Tipo Proveedor";
            return l1_p;
        }
        public Label label2_p()//Label id_proveedor
        {
            l2_p.AutoSize = true;
            l2_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l2_p.ForeColor = System.Drawing.Color.White;
            l2_p.Location = new System.Drawing.Point(32, 64);
            l2_p.Name = "label2";
            l2_p.Size = new System.Drawing.Size(83, 13);
            l2_p.Text = "Id_Proveedor";
            return l2_p;
        }
        public Label label3_p()//Label datos para buscar al proveedor
        {
            l3_p.AutoSize = true;
            l3_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l3_p.ForeColor = System.Drawing.Color.White;
            l3_p.Location = new System.Drawing.Point(32, 117);
            l3_p.Name = "label3";
            l3_p.Size = new System.Drawing.Size(58, 13);
            l3_p.Text = "Id_Datos";
            return l3_p;
        }


        public Label label1()//Label id del cliente de la forma cliente,para buscar una persona
        {
            l_1.AutoSize = true;
            l_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l_1.ForeColor = System.Drawing.Color.White;
            l_1.Location = new System.Drawing.Point(52, 25);
            l_1.Name = "id_cliente";
            l_1.Size = new System.Drawing.Size(68, 13);
            l_1.Text = "Id_Cliente:";
            return l_1;
        }
        public Label label2()//Label apellido paterno de la forma cliente
        {
            l_2.AutoSize = true;
            l_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l_2.ForeColor = System.Drawing.Color.White;
            l_2.Location = new System.Drawing.Point(259, 19);
            l_2.Name = "apellido_p";
            l_2.Size = new System.Drawing.Size(68, 13);
            l_2.Text = "Apellido P:";
            return l_2;
        }
        public Label label3()//Label nombre del cliente de la forma cliente
        {
            l_3.AutoSize = true;
            l_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l_3.ForeColor = System.Drawing.Color.White;
            l_3.Location = new System.Drawing.Point(80, 62);
            l_3.Name = "nombre";
            l_3.Size = new System.Drawing.Size(54, 13);
            l_3.Text = "Nombre:";
            return l_3;
        }
        public Label label4()//Label apellido materno de la forma cliente
        {
            l_4.AutoSize = true;
            l_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l_4.ForeColor = System.Drawing.Color.White;
            l_4.Location = new System.Drawing.Point(259, 62);
            l_4.Name = "apellido_m";
            l_4.Size = new System.Drawing.Size(70, 13);
            l_4.Text = "Apellido M:";
            return l_4;
        }


        //Imagen y boton de salir, componentes de la forma inicio
        public PictureBox picture()
        {
            imagen.Image = Image.FromFile("Imagen_Almacen.png");//Recupera la imagen almacenada en la carpeta
            imagen.Location = new System.Drawing.Point(0, 27);
            imagen.Name = "pictureBox1";
            imagen.Size = new System.Drawing.Size(741, 410);
            imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imagen.TabIndex = 33;
            imagen.TabStop = false;
            return imagen;//Retorna la imagen
        }
        public Button Salir()
        {
            btn_salir.BackColor = System.Drawing.Color.Black;
            btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_salir.ForeColor = System.Drawing.Color.White;
            btn_salir.Location = new System.Drawing.Point(12, 303);
            btn_salir.Name = "button1";
            btn_salir.Size = new System.Drawing.Size(123, 39);
            btn_salir.Text = "Salir de la Aplicación";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += new System.EventHandler(evento_salir);//Invoca el evento de salir
            return btn_salir;
        }
        public void evento_salir(object sender, EventArgs e)
        {
            Application.Exit();//Cierra la aplicación
        }

        public DataGridView dataclientes()//Crear la funcion del data
        {
            //Propiedades del DataGridView
            data_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_clientes.Location = new System.Drawing.Point(83, 105);
            data_clientes.Name = "dataGridView1";
            data_clientes.TabIndex = 10;
            data_clientes.Size = new System.Drawing.Size(273, 150);
            return data_clientes;//Retornar el datagridview
        }
        public DataGridView datatickets()//Crear la funcion del data
        {
            //Propiedades del DataGridView
            data_tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_tickets.Location = new System.Drawing.Point(210, 48);
            data_tickets.Name = "dataGridView1";
            data_tickets.TabIndex = 9;
            data_tickets.Size = new System.Drawing.Size(265, 150);
            return data_tickets;//Retornar el datagridview
        }
        public DataGridView dataproveedores()//Crear la funcion del data
        {
            //Propiedades del DataGridView
            data_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_proveedores.Location = new System.Drawing.Point(210, 48);
            data_proveedores.Name = "dataGridView1";
            data_proveedores.TabIndex = 9;
            data_proveedores.Size = new System.Drawing.Size(265, 150);
            return data_proveedores;//Retornar el datagridview
        }
        public DataGridView dataturnos()//Crear la funcion del data
        {
            //Propiedades del DataGridView
            data_turnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_turnos.Location = new System.Drawing.Point(210, 48);
            data_turnos.Name = "dataGridView1";
            data_turnos.TabIndex = 9;
            data_turnos.Size = new System.Drawing.Size(265, 150);
            return data_turnos;//Retornar el datagridview
        }
        public DataGridView dataempleados()//Crear la funcion del data
        {
            //Propiedades del DataGridView
            data_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_empleados.Location = new System.Drawing.Point(83, 105);
            data_empleados.Name = "dataGridView1";
            data_empleados.TabIndex = 10;
            data_empleados.Size = new System.Drawing.Size(273, 150);
            return data_empleados;//Retornar el datagridview
        }
        public DataGridView dataventas()//Crear la funcion del data
        {
            //Propiedades del DataGridView
            data_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_ventas.Location = new System.Drawing.Point(100, 115);
            data_ventas.Name = "dataGridView1";
            data_ventas.TabIndex = 10;
            data_ventas.Size = new System.Drawing.Size(298, 150);
            return data_ventas;//Retornar el datagridview
        }
       
        public DataGridView datadatos()//Crear la funcion del data
        {
            //Propiedades del DataGridView
            data_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_datos.Location = new System.Drawing.Point(92, 125);
            data_datos.Name = "dataGridView2";
            data_datos.TabIndex = 10;
            data_datos.Size = new System.Drawing.Size(298, 150);
            return data_datos;//Retornar el datagridview
        }
        public DataGridView datapuesto()//Crear la funcion del data
        {
            //Propiedades del DataGridView
            data_puesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_puesto.Location = new System.Drawing.Point(210, 48);
            data_puesto.Name = "dataGridView1";
            data_puesto.TabIndex = 9;
            data_puesto.Size = new System.Drawing.Size(265, 150);
            return data_puesto;//Retornar el datagridview
        }
        public DataGridView dataalmacen()//Crear la funcion del data
        {
            //Propiedades del DataGridView
            data_almacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_almacen.Location = new System.Drawing.Point(210, 48);
            data_almacen.Name = "dataGridView1";
            data_almacen.TabIndex = 9;
            data_almacen.Size = new System.Drawing.Size(265, 150);
            return data_almacen;//Retornar el datagridview
        }
        public DataGridView datacotizaciones()//Crear la funcion del data
        {
            //Propiedades del DataGridView
            data_cotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_cotizaciones.Location = new System.Drawing.Point(210, 48);
            data_cotizaciones.Name = "dataGridView1";
            data_cotizaciones.TabIndex = 9;
            data_cotizaciones.Size = new System.Drawing.Size(265, 150);
            return data_cotizaciones;//Retornar el datagridview
        }
        public DataGridView dataprolocal()//Crear la funcion del data
        {
            //Propiedades del DataGridView
            data_pro_local.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_pro_local.Location = new System.Drawing.Point(210, 48);
            data_pro_local.Name = "dataGridView1";
            data_pro_local.TabIndex = 9;
            data_pro_local.Size = new System.Drawing.Size(265, 150);
            return data_pro_local;//Retornar el datagridview
        }
        public DataGridView dataproext()//Crear la funcion del data
        {
            //Propiedades del DataGridView
            data_pro_ext.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_pro_ext.Location = new System.Drawing.Point(210, 48);
            data_pro_ext.Name = "dataGridView1";
            data_pro_ext.TabIndex = 9;
            data_pro_ext.Size = new System.Drawing.Size(265, 150);
            return data_pro_ext;//Retornar el datagridview
        }
        public DataGridView datacompras()//Crear la funcion del data
        {
            //Propiedades del DataGridView
            data_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_compras.Location = new System.Drawing.Point(210, 48);
            data_compras.Name = "dataGridView1";
            data_compras.TabIndex = 9;
            data_compras.Size = new System.Drawing.Size(265, 150);
            return data_compras;//Retornar el datagridview
        }
        //CLIENTES
        public Label Nombres_Cliente()
        {
            //Label nombre del cliente
            n_c.AutoSize = true;
            n_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            n_c.ForeColor = System.Drawing.Color.White;
            n_c.Location = new System.Drawing.Point(77, 19);
            n_c.Name = "nombre_c";
            n_c.Size = new System.Drawing.Size(60, 13);
            n_c.Text = "Nombres:";
            return n_c;//Retorna el label
        }
        public Label A_P_Cliente()
        {
            //Label apellido paterno del cliente
            a_p_c.AutoSize = true;
            a_p_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            a_p_c.ForeColor = System.Drawing.Color.White;
            a_p_c.Location = new System.Drawing.Point(53, 67);
            a_p_c.Name = "ap_p_c";
            a_p_c.Size = new System.Drawing.Size(104, 13);
            a_p_c.Text = "Apellido Paterno:";
            return a_p_c;//Retorna el label
        }
        public Label A_M_Cliente()
        {
            //Label apellido materno del cliente
            a_m_c.AutoSize = true;
            a_m_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            a_m_c.ForeColor = System.Drawing.Color.White;
            a_m_c.Location = new System.Drawing.Point(53, 126);
            a_m_c.Name = "ap_m_c";
            a_m_c.Size = new System.Drawing.Size(106, 13);
            a_m_c.Text = "Apellido Materno:";
            return a_m_c;//Retorna el label
        }

        public Label Correo_Cliente()
        {
            //Label correo cliente
            c_c.AutoSize = true;
            c_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c_c.ForeColor = System.Drawing.Color.White;
            c_c.Location = new System.Drawing.Point(96, 188);
            c_c.Name = "corr_c";
            c_c.Size = new System.Drawing.Size(48, 13);
            c_c.Text = "Correo:";
            return c_c;//Retorna el label
        }
        public Label Telefono_Cliente()
        {
            //Label telefono cliente
            t_c.AutoSize = true;
            t_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            t_c.ForeColor = System.Drawing.Color.White;
            t_c.Location = new System.Drawing.Point(88, 226);
            t_c.Name = "tel_c";
            t_c.Size = new System.Drawing.Size(61, 13);
            t_c.Text = "Telefono:";
            return t_c;//Retorna el label
        }
        public Label Curp_Cliente()
        {
            //Label curp cliente
            curp_c.AutoSize = true;
            curp_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            curp_c.ForeColor = System.Drawing.Color.White;
            curp_c.Location = new System.Drawing.Point(99, 281);
            curp_c.Name = "cu_c";
            curp_c.Size = new System.Drawing.Size(45, 13);
            curp_c.Text = "CURP:";
            return curp_c;//Retorna el label
        }
        public Label Colonia_Cliente()
        {
            //Label colonia cliente
            colonia_c.AutoSize = true;
            colonia_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colonia_c.ForeColor = System.Drawing.Color.White;
            colonia_c.Location = new System.Drawing.Point(312, 15);
            colonia_c.Name = "colon_c";
            colonia_c.Size = new System.Drawing.Size(53, 13);
            colonia_c.Text = "Colonia:";
            return colonia_c;//Retorna el label
        }
        public Label Ciudad_Cliente()
        {
            //Label ciudad cliente
            ciudad_c.AutoSize = true;
            ciudad_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciudad_c.ForeColor = System.Drawing.Color.White;
            ciudad_c.Location = new System.Drawing.Point(312, 62);
            ciudad_c.Name = "ciu_c";
            ciudad_c.Size = new System.Drawing.Size(50, 13);
            ciudad_c.Text = "Ciudad:";
            return ciudad_c;//Retorna el label
        }
        public Label Calle_Cliente()
        {
            //Label calle cliente
            calle_c.AutoSize = true;
            calle_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            calle_c.ForeColor = System.Drawing.Color.White;
            calle_c.Location = new System.Drawing.Point(318, 114);
            calle_c.Name = "limite_cliente";
            calle_c.Size = new System.Drawing.Size(39, 13);
            calle_c.Text = "limite:";
            return calle_c;//Retorna el label
        }
        public Label Numero_Cliente()
        {
            //Label numero cliente
            numero_c.AutoSize = true;
            numero_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numero_c.ForeColor = System.Drawing.Color.White;
            numero_c.Location = new System.Drawing.Point(318, 181);
            numero_c.Name = "id_cliente_cliente";
            numero_c.Size = new System.Drawing.Size(54, 13);
            numero_c.Text = "ID Cliente:";
            return numero_c;//Retorna el label
        }
        public Label CP_Cliente()
        {
            //Label codigo postal cliente
            cp_c.AutoSize = true;
            cp_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cp_c.ForeColor = System.Drawing.Color.White;
            cp_c.Location = new System.Drawing.Point(335, 243);
            cp_c.Name = "id_datos_cliente";
            cp_c.Size = new System.Drawing.Size(27, 13);
            cp_c.Text = "ID Datos:";
            return cp_c;//Retorna el label
        }

        //EMPLEADOS
        public Label Nombres_Empleado()
        {
            //Label nombre del empleado
            n_e.AutoSize = true;
            n_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            n_e.ForeColor = System.Drawing.Color.White;
            n_e.Location = new System.Drawing.Point(77, 19);
            n_e.Name = "nomb_e";
            n_e.Size = new System.Drawing.Size(60, 13);
            n_e.Text = "Nombres:";
            return n_e;//Retorna el label
        }
        public Label A_P_Empleado()
        {
            //Label apellido paterno del empleado
            a_p_e.AutoSize = true;
            a_p_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            a_p_e.ForeColor = System.Drawing.Color.White;
            a_p_e.Location = new System.Drawing.Point(53, 67);
            a_p_e.Name = "ape_p_e";
            a_p_e.Size = new System.Drawing.Size(104, 13);
            a_p_e.Text = "Apellido Paterno:";
            return a_p_e;//Retorna el label
        }
        public Label A_M_Empleado()
        {
            //Label apellido materno del empleado
            a_m_e.AutoSize = true;
            a_m_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            a_m_e.ForeColor = System.Drawing.Color.White;
            a_m_e.Location = new System.Drawing.Point(62, 126);
            a_m_e.Name = "ape_m_e";
            a_m_e.Size = new System.Drawing.Size(106, 13);
            a_m_e.Text = "Apellido Materno:";
            return a_m_e;//Retorna el label
        }
        public Label Id_Trabajador()
        {
            //Label id trabajador
            id_trabajador.AutoSize = true;
            id_trabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_trabajador.ForeColor = System.Drawing.Color.White;
            id_trabajador.Location = new System.Drawing.Point(70, 178);
            id_trabajador.Name = "id_trab";
            id_trabajador.Size = new System.Drawing.Size(90, 13);
            id_trabajador.Text = "Id_Trabajador:";
            return id_trabajador;//Retorna el label
        }
        public Label Correo_Empleado()
        {
            //Label correo empleado
            c_e.AutoSize = true;
            c_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c_e.ForeColor = System.Drawing.Color.White;
            c_e.Location = new System.Drawing.Point(88, 226);
            c_e.Name = "corr_e";
            c_e.Size = new System.Drawing.Size(48, 13);
            c_e.Text = "Correo:";
            return c_e;//Retorna el label
        }
        public Label Telefono_Empleado()
        {
            //Label telefono empleado
            t_e.AutoSize = true;
            t_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            t_e.ForeColor = System.Drawing.Color.White;
            t_e.Location = new System.Drawing.Point(85, 271);
            t_e.Name = "tel_e";
            t_e.Size = new System.Drawing.Size(61, 13);
            t_e.Text = "Telefono:";
            return t_e;//Retorna el label
        }
        public Label Curp_Empleado()
        {
            //Label curp empleado
            curp_e.AutoSize = true;
            curp_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            curp_e.ForeColor = System.Drawing.Color.White;
            curp_e.Location = new System.Drawing.Point(85, 308);
            curp_e.Name = "cu_e";
            curp_e.Size = new System.Drawing.Size(45, 13);
            curp_e.Text = "CURP:";
            return curp_e;//Retorna el label
        }
        public Label Colonia_Empleado()
        {
            //Label colonia empleado
            colonia_e.AutoSize = true;
            colonia_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colonia_e.ForeColor = System.Drawing.Color.White;
            colonia_e.Location = new System.Drawing.Point(312, 15);
            colonia_e.Name = "col_e";
            colonia_e.Size = new System.Drawing.Size(53, 13);
            colonia_e.Text = "Colonia:";
            return colonia_e;//Retorna el label
        }
        public Label Ciudad_Empleado()
        {
            //Label ciudad empleado
            ciudad_e.AutoSize = true;
            ciudad_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciudad_e.ForeColor = System.Drawing.Color.White;
            ciudad_e.Location = new System.Drawing.Point(312, 62);
            ciudad_e.Name = "ciu_e";
            ciudad_e.Size = new System.Drawing.Size(50, 13);
            ciudad_e.Text = "Ciudad:";
            return ciudad_e;//Retorna el label
        }
        public Label Calle_Empleado()
        {
            //Label calle empleado
            calle_e.AutoSize = true;
            calle_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            calle_e.ForeColor = System.Drawing.Color.White;
            calle_e.Location = new System.Drawing.Point(308, 114);
            calle_e.Name = "id_turno";
            calle_e.Size = new System.Drawing.Size(39, 13);
            calle_e.Text = "ID Turno:";
            return calle_e;//Retorna el label
        }
        public Label Numero_Empleado()
        {
            //Label numero empleado
            numero_e.AutoSize = true;
            numero_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numero_e.ForeColor = System.Drawing.Color.White;
            numero_e.Location = new System.Drawing.Point(318, 181);
            numero_e.Name = "id_puesto";
            numero_e.Size = new System.Drawing.Size(54, 13);
            numero_e.Text = "ID Puesto:";
            return numero_e;//Retorna el label
        }
        public Label CP_Empleado()
        {
            //Label codigo postal empleado
            cp_e.AutoSize = true;
            cp_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cp_e.ForeColor = System.Drawing.Color.White;
            cp_e.Location = new System.Drawing.Point(335, 243);
            cp_e.Name = "id_datos";
            cp_e.Size = new System.Drawing.Size(27, 13);
            cp_e.Text = "ID Datos:";
            return cp_e;//Retorna el label
        }



        //VENTAS
        public Label ID_Producto()
        {
            //Label id producto
            id_producto.AutoSize = true;
            id_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_producto.ForeColor = System.Drawing.Color.White;
            id_producto.Location = new System.Drawing.Point(49, 23);
            id_producto.Name = "id_prod";
            id_producto.Size = new System.Drawing.Size(80, 13);
            id_producto.Text = "Id_Producto:";
            return id_producto;//Retorna el label
        }
        public Label ID_Proveedor()
        {
            //Label id_proveedor
            id_proveedor.AutoSize = true;
            id_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_proveedor.ForeColor = System.Drawing.Color.White;
            id_proveedor.Location = new System.Drawing.Point(45, 77);
            id_proveedor.Name = "id_prov";
            id_proveedor.Size = new System.Drawing.Size(87, 13);
            id_proveedor.Text = "Id_Proveedor:";
            return id_proveedor;//Retorna el label
        }
        public Label Descuento()
        {
            //Label descuento
            descuento.AutoSize = true;
            descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descuento.ForeColor = System.Drawing.Color.White;
            descuento.Location = new System.Drawing.Point(47, 135);
            descuento.Name = "desc";
            descuento.Size = new System.Drawing.Size(85, 13);
            descuento.Text = "% Descuento:";
            return descuento;//Retorna el label
        }
        public Label ID_Cliente()
        {
            //Label id cliente
            id_cliente.AutoSize = true;
            id_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_cliente.ForeColor = System.Drawing.Color.White;
            id_cliente.Location = new System.Drawing.Point(49, 199);
            id_cliente.Name = "id_cli";
            id_cliente.Size = new System.Drawing.Size(68, 13);
            id_cliente.Text = "Id_Cliente:";
            return id_cliente;//Retorna el label
        }
        public Label Garantia()
        {
            //Label garantia
            garantia.AutoSize = true;
            garantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            garantia.ForeColor = System.Drawing.Color.White;
            garantia.Location = new System.Drawing.Point(318, 33);
            garantia.Name = "garant";
            garantia.Size = new System.Drawing.Size(59, 13);
            garantia.Text = "Garantia:";
            return garantia;//Retorna el label
        }
        public Label ID_Venta()
        {
            //Label id venta
            id_venta.AutoSize = true;
            id_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_venta.ForeColor = System.Drawing.Color.White;
            id_venta.Location = new System.Drawing.Point(307, 90);
            id_venta.Name = "id_ven";
            id_venta.Size = new System.Drawing.Size(62, 13);
            id_venta.Text = "Id_Venta:";
            return id_venta;//Retorna el label
        }
        public Label Devoluciones()
        {
            //Label devoluciones
            devoluciones.AutoSize = true;
            devoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            devoluciones.ForeColor = System.Drawing.Color.White;
            devoluciones.Location = new System.Drawing.Point(299, 165);
            devoluciones.Name = "dev";
            devoluciones.Size = new System.Drawing.Size(88, 13);
            devoluciones.Text = "Devoluciones:";
            return devoluciones;//Retorna el label
        }

        //PROVEEDORES
        public Label Tipo_Proveedor()
        {
            //Label tipo de proveedor
            tipo_p.AutoSize = true;
            tipo_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipo_p.ForeColor = System.Drawing.Color.White;
            tipo_p.Location = new System.Drawing.Point(79, 16);
            tipo_p.Name = "tipo_prov";
            tipo_p.Size = new System.Drawing.Size(98, 13);
            tipo_p.Text = "Tipo Proveedor:";
            return tipo_p;//Retorna el label
        }
        public Label Id_Pro()
        {
            //Label id proveedor
            id_p.AutoSize = true;
            id_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_p.ForeColor = System.Drawing.Color.White;
            id_p.Location = new System.Drawing.Point(101, 93);
            id_p.Name = "id_proveed";
            id_p.Size = new System.Drawing.Size(87, 13);
            id_p.Text = "Id_Proveedor:";
            return id_p;//Retorna el label
        }
        public Label Id_Datos()
        {
            //Label id datos
            id_datos.AutoSize = true;
            id_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_datos.ForeColor = System.Drawing.Color.White;
            id_datos.Location = new System.Drawing.Point(115, 166);
            id_datos.Name = "id_dat";
            id_datos.Size = new System.Drawing.Size(62, 13);
            id_datos.Text = "Id_Datos:";
            return id_datos;//Retorna el label
        }


        //DATOS_PANEL
        public Label Id_Datos_Panel()
        {
            //Label nombre del empleado
            id.AutoSize = true;
            id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id.ForeColor = System.Drawing.Color.White;
            id.Location = new System.Drawing.Point(77, 19);
            id.Name = "nomb_e";
            id.Size = new System.Drawing.Size(60, 13);
            id.Text = "ID Datos:";
            return id;//Retorna el label
        }
        public Label Nombres_Datos_Panel()
        {
            //Label apellido paterno del empleado
            nombres_datos.AutoSize = true;
            nombres_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombres_datos.ForeColor = System.Drawing.Color.White;
            nombres_datos.Location = new System.Drawing.Point(77, 67);
            nombres_datos.Name = "ape_p_e";
            nombres_datos.Size = new System.Drawing.Size(104, 13);
            nombres_datos.Text = "Nombres:";
            return nombres_datos;//Retorna el label
        }
        public Label A_P_Datos_Panel()
        {
            //Label apellido materno del empleado
            a_p_datos.AutoSize = true;
            a_p_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            a_p_datos.ForeColor = System.Drawing.Color.White;
            a_p_datos.Location = new System.Drawing.Point(42, 126);
            a_p_datos.Name = "ape_m_e";
            a_p_datos.Size = new System.Drawing.Size(106, 13);
            a_p_datos.Text = "Apellido Paterno:";
            return a_p_datos;//Retorna el label
        }
        public Label A_M_Datos_Panel()
        {
            //Label id trabajador
            a_m_datos.AutoSize = true;
            a_m_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            a_m_datos.ForeColor = System.Drawing.Color.White;
            a_m_datos.Location = new System.Drawing.Point(42, 178);
            a_m_datos.Name = "id_trab";
            a_m_datos.Size = new System.Drawing.Size(90, 13);
            a_m_datos.Text = "Apellido Materno:";
            return a_m_datos;//Retorna el label
        }
        public Label Telefono_Datos_Panel()
        {
            //Label correo empleado
            tel_datos.AutoSize = true;
            tel_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tel_datos.ForeColor = System.Drawing.Color.White;
            tel_datos.Location = new System.Drawing.Point(77, 226);
            tel_datos.Name = "corr_e";
            tel_datos.Size = new System.Drawing.Size(48, 13);
            tel_datos.Text = "Telefono:";
            return tel_datos;//Retorna el label
        }
        public Label Ciudad_Datos_Panel()
        {
            //Label telefono empleado
            ciudad_datos.AutoSize = true;
            ciudad_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciudad_datos.ForeColor = System.Drawing.Color.White;
            ciudad_datos.Location = new System.Drawing.Point(77, 271);
            ciudad_datos.Name = "tel_e";
            ciudad_datos.Size = new System.Drawing.Size(61, 13);
            ciudad_datos.Text = "Ciudad:";
            return ciudad_datos;//Retorna el label
        }
        public Label Colonia_Datos_Panel()
        {
            //Label curp empleado
            colonia_datos.AutoSize = true;
            colonia_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colonia_datos.ForeColor = System.Drawing.Color.White;
            colonia_datos.Location = new System.Drawing.Point(77, 308);
            colonia_datos.Name = "cu_e";
            colonia_datos.Size = new System.Drawing.Size(45, 13);
            colonia_datos.Text = "Colonia:";
            return colonia_datos;//Retorna el label
        }
        public Label Calle_Datos_Panel()
        {
            //Label colonia empleado
            calle_datos.AutoSize = true;
            calle_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            calle_datos.ForeColor = System.Drawing.Color.White;
            calle_datos.Location = new System.Drawing.Point(312, 15);
            calle_datos.Name = "col_e";
            calle_datos.Size = new System.Drawing.Size(53, 13);
            calle_datos.Text = "Calle:";
            return calle_datos;//Retorna el label
        }
        public Label Numero_Datos_Panel()
        {
            //Label ciudad empleado
            numero_datos.AutoSize = true;
            numero_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numero_datos.ForeColor = System.Drawing.Color.White;
            numero_datos.Location = new System.Drawing.Point(312, 62);
            numero_datos.Name = "ciu_e";
            numero_datos.Size = new System.Drawing.Size(50, 13);
            numero_datos.Text = "Numero:";
            return numero_datos;//Retorna el label
        }
        public Label RFC_Datos_Panel()
        {
            //Label calle empleado
            rfc_datos.AutoSize = true;
            rfc_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rfc_datos.ForeColor = System.Drawing.Color.White;
            rfc_datos.Location = new System.Drawing.Point(308, 114);
            rfc_datos.Name = "id_turno";
            rfc_datos.Size = new System.Drawing.Size(39, 13);
            rfc_datos.Text = "RFC:";
            return rfc_datos;//Retorna el label
        }
        

    }
}
