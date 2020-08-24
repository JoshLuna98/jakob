using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Almacen_Libreria2
{
    public class Class1
    {
        Label Label1 = new Label();
        Label Label2 = new Label();
        Label Label3 = new Label();
        Label Label4 = new Label();
        Label Label5 = new Label();
        Label Label6 = new Label();
        Label Label7 = new Label();
        Label Label1_AYUDA = new Label();
        Label Label2_AYUDA = new Label();
        Label Label3_AYUDA = new Label();
        Label Label1_INVENTARIO = new Label();
        Label Label2_INVENTARIO = new Label();
        Label Label3_INVENTARIO = new Label();
        Label Label4_INVENTARIO = new Label();
        Label Label5_INVENTARIO = new Label();
        Label Label6_INVENTARIO = new Label();
        Label Label7_INVENTARIO = new Label();
        Label Label8_INVENTARIO = new Label();
        Label Label9_INVENTARIO = new Label();
        Label Label10_INVENTARIO = new Label();


        //Labels de la forma pro_ext
        Label label1_in = new Label();
        
        DataGridView data_in = new DataGridView();

        Label label1_panel = new Label();
        Label label2_panel = new Label();
        Label label3_panel = new Label();
        Label label4_panel = new Label();
        Label label5_panel = new Label();
        public Label label1_Panel()//Label turno
        {
            label1_panel.AutoSize = true;
            label1_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1_panel.ForeColor = System.Drawing.Color.White;
            label1_panel.Location = new System.Drawing.Point(21, 13);
            label1_panel.Name = "label1";
            label1_panel.Size = new System.Drawing.Size(94, 13);
            label1_panel.Text = "Id Inventario:";
            return label1_panel;
        }
        public Label label2_Panel()
        {
            //Label id proveedor
            label2_panel.AutoSize = true;
            label2_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2_panel.ForeColor = System.Drawing.Color.White;
            label2_panel.Location = new System.Drawing.Point(21, 86);
            label2_panel.Name = "id_proveed";
            label2_panel.Size = new System.Drawing.Size(87, 13);
            label2_panel.Text = "Id Producto:";
            return label2_panel;//Retorna el label
        }
        public Label label3_Panel()
        {
            //Label id datos
            label3_panel.AutoSize = true;
            label3_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3_panel.ForeColor = System.Drawing.Color.White;
            label3_panel.Location = new System.Drawing.Point(21, 159);
            label3_panel.Name = "id_dat";
            label3_panel.Size = new System.Drawing.Size(62, 13);
            label3_panel.Text = "Id Compra:";
            return label3_panel;//Retorna el label
        }
        public Label label4_Panel()
        {
            //Label id datos
            label4_panel.AutoSize = true;
            label4_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4_panel.ForeColor = System.Drawing.Color.White;
            label4_panel.Location = new System.Drawing.Point(21, 199);
            label4_panel.Name = "id_dat";
            label4_panel.Size = new System.Drawing.Size(62, 13);
            label4_panel.Text = "Id Venta:";
            return label4_panel;//Retorna el label
        }
        public Label label5_Panel()
        {
            //Label id datos
            label5_panel.AutoSize = true;
            label5_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5_panel.ForeColor = System.Drawing.Color.White;
            label5_panel.Location = new System.Drawing.Point(200, 13);
            label5_panel.Name = "id_dat";
            label5_panel.Size = new System.Drawing.Size(62, 13);
            label5_panel.Text = "Id Mobiliario:";
            return label5_panel;//Retorna el label
        }


        public Label label1_Inventario()//Label turno
        {
            label1_in.AutoSize = true;
            label1_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1_in.ForeColor = System.Drawing.Color.Black;
            label1_in.Location = new System.Drawing.Point(11, 7);
            label1_in.Name = "label1";
            label1_in.Size = new System.Drawing.Size(94, 13);
            label1_in.Text = "Id Inventario:";
            return label1_in;
        }

        public DataGridView datain()//Crear la funcion del data
        {
            //Propiedades del DataGridView
            data_in.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_in.Location = new System.Drawing.Point(210, 48);
            data_in.Name = "dataGridView1";
            data_in.TabIndex = 9;
            data_in.Size = new System.Drawing.Size(265, 150);
            return data_in;//Retornar el datagridview
        }

        public Label CrearLabel1()
        {
            Label1.AutoSize = true;
            Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1.ForeColor = System.Drawing.Color.White;
            Label1.Location = new System.Drawing.Point(48, 22);
            Label1.Name = "label1";
            Label1.Size = new System.Drawing.Size(138, 13);
            Label1.TabIndex = 32;
            Label1.Text = "Nombre de la Empresa:";
            return Label1;

        }
        public Label CrearLabel2()
        {
            Label2.AutoSize = true;
            Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label2.ForeColor = System.Drawing.Color.White;
            Label2.Location = new System.Drawing.Point(102, 79);
            Label2.Name = "label2";
            Label2.Size = new System.Drawing.Size(47, 13);
            Label2.TabIndex = 34;
            Label2.Text = "Misión:";
            return Label2;
        }
        public Label CrearLabel3()
        {
            Label3.AutoSize = true;
            Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label3.ForeColor = System.Drawing.Color.White;
            Label3.Location = new System.Drawing.Point(102, 147);
            Label3.Name = "label3";
            Label3.Size = new System.Drawing.Size(45, 13);
            Label3.TabIndex = 35;
            Label3.Text = "Visión:";
            return Label3;
        }
        public Label CrearLabel4()
        {
            Label4.AutoSize = true;
            Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label4.ForeColor = System.Drawing.Color.White;
            Label4.Location = new System.Drawing.Point(82, 220);
            Label4.Name = "label4";
            Label4.Size = new System.Drawing.Size(65, 13);
            Label4.TabIndex = 36;
            Label4.Text = "Dirección:";
            return Label4;
        }
        public Label CrearLabel5()
        {
            Label5.AutoSize = true;
            Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label5.ForeColor = System.Drawing.Color.White;
            Label5.Location = new System.Drawing.Point(335, 25);
            Label5.Name = "label5";
            Label5.Size = new System.Drawing.Size(118, 13);
            Label5.TabIndex = 37;
            Label5.Text = "Número Telefonico:";
            return Label5;
        }
        public Label CrearLabel6()
        {
            Label6.AutoSize = true;
            Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label6.ForeColor = System.Drawing.Color.White;
            Label6.Location = new System.Drawing.Point(367, 95);
            Label6.Name = "label6";
            Label6.Size = new System.Drawing.Size(45, 13);
            Label6.TabIndex = 38;
            Label6.Text = "E-mail:";
            return Label6;
        }
        public Label CrearLabel7()
        {
            Label7.AutoSize = true;
            Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label7.ForeColor = System.Drawing.Color.White;
            Label7.Location = new System.Drawing.Point(367, 180);
            Label7.Name = "label7";
            Label7.Size = new System.Drawing.Size(52, 13);
            Label7.TabIndex = 39;
            Label7.Text = "Horario:";
            return Label7;
        }

        public Label CrearLabel2_AYUDA()
        {
            Label2_AYUDA.AutoSize = true;
            Label2_AYUDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label2_AYUDA.ForeColor = System.Drawing.Color.White;
            Label2_AYUDA.Location = new System.Drawing.Point(26, 144);
            Label2_AYUDA.Name = "label2";
            Label2_AYUDA.Size = new System.Drawing.Size(151, 13);
            Label2_AYUDA.TabIndex = 2;
            Label2_AYUDA.Text = "Correo email de acesoria:";
            return Label2_AYUDA;
        }

        public Label CrearLabel1_AYUDA()
        {
            Label1_AYUDA.AutoSize = true;
            Label1_AYUDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1_AYUDA.ForeColor = System.Drawing.Color.White;
            Label1_AYUDA.Location = new System.Drawing.Point(26, 80);
            Label1_AYUDA.Name = "label1";
            Label1_AYUDA.Size = new System.Drawing.Size(142, 13);
            Label1_AYUDA.TabIndex = 1;
            Label1_AYUDA.Text = "Número de Información:";
            return Label1_AYUDA;
        }


        public Label CrearLabel3_AYUDA()

        {
            Label3_AYUDA.AutoSize = true;
            Label3_AYUDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label3_AYUDA.ForeColor = System.Drawing.Color.White;
            Label3_AYUDA.Location = new System.Drawing.Point(126, 9);
            Label3_AYUDA.Name = "label3";
            Label3_AYUDA.Size = new System.Drawing.Size(125, 13);
            Label3_AYUDA.TabIndex = 3;
            Label3_AYUDA.Text = "CENTRO DE AYUDA";
            return Label3_AYUDA;


        }
        public Label CrearLabel5_INVENTARIO()
        {
            Label5_INVENTARIO.AutoSize = true;
            Label5_INVENTARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label5_INVENTARIO.ForeColor = System.Drawing.Color.White;
            Label5_INVENTARIO.Location = new System.Drawing.Point(48, 136);
            Label5_INVENTARIO.Name = "label5";
            Label5_INVENTARIO.Size = new System.Drawing.Size(133, 13);
            Label5_INVENTARIO.TabIndex = 4;
            Label5_INVENTARIO.Text = "Motivo de devolución:";
            return Label5_INVENTARIO;
        }

        public Label CrearLabel4_INVENTARIO()
        {
            Label4_INVENTARIO.AutoSize = true;
            Label4_INVENTARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label4_INVENTARIO.ForeColor = System.Drawing.Color.White;
            Label4_INVENTARIO.Location = new System.Drawing.Point(111, 173);
            Label4_INVENTARIO.Name = "label4";
            Label4_INVENTARIO.Size = new System.Drawing.Size(46, 13);
            Label4_INVENTARIO.TabIndex = 3;
            Label4_INVENTARIO.Text = "Fecha:";
            return Label4_INVENTARIO;
        }

        public Label CrearLabel3_INVENTARIO()
        {
            Label3_INVENTARIO.AutoSize = true;
            Label3_INVENTARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label3_INVENTARIO.ForeColor = System.Drawing.Color.White;
            Label3_INVENTARIO.Location = new System.Drawing.Point(59, 90);
            Label3_INVENTARIO.Name = "label3";
            Label3_INVENTARIO.Size = new System.Drawing.Size(122, 13);
            Label3_INVENTARIO.TabIndex = 2;
            Label3_INVENTARIO.Text = "Folio de devolución:";
            return Label3_INVENTARIO;
        }
        public Label CrearLabel2_INVENTARIO()
        {
            Label2_INVENTARIO.AutoSize = true;
            Label2_INVENTARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label2_INVENTARIO.ForeColor = System.Drawing.Color.White;
            Label2_INVENTARIO.Location = new System.Drawing.Point(106, 54);
            Label2_INVENTARIO.Name = "label2";
            Label2_INVENTARIO.Size = new System.Drawing.Size(38, 13);
            Label2_INVENTARIO.TabIndex = 1;
            Label2_INVENTARIO.Text = "Folio:";
            return Label2_INVENTARIO;
        }

        public Label CrearLabel1_INVENTARIO()
        {
            Label1_INVENTARIO.AutoSize = true;
            Label1_INVENTARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label1_INVENTARIO.ForeColor = System.Drawing.Color.White;
            Label1_INVENTARIO.Location = new System.Drawing.Point(95, 9);
            Label1_INVENTARIO.Name = "label1";
            Label1_INVENTARIO.Size = new System.Drawing.Size(62, 13);
            Label1_INVENTARIO.TabIndex = 0;
            Label1_INVENTARIO.Text = "Producto:";
            return Label1_INVENTARIO;

        }
        public Label CrearLabel6_INVENTARIO()
        {
            Label6_INVENTARIO.AutoSize = true;
            Label6_INVENTARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label6_INVENTARIO.ForeColor = System.Drawing.Color.White;
            Label6_INVENTARIO.Location = new System.Drawing.Point(93, 64);
            Label6_INVENTARIO.Name = "label6";
            Label6_INVENTARIO.Size = new System.Drawing.Size(38, 13);
            Label6_INVENTARIO.TabIndex = 9;
            Label6_INVENTARIO.Text = "Folio:";
            return Label6_INVENTARIO;
        }
        public Label CrearLabel7_INVENTARIO()
        {
            Label7_INVENTARIO.AutoSize = true;
            Label7_INVENTARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label7_INVENTARIO.ForeColor = System.Drawing.Color.White;
            Label7_INVENTARIO.Location = new System.Drawing.Point(36, 97);
            Label7_INVENTARIO.Name = "label7";
            Label7_INVENTARIO.Size = new System.Drawing.Size(151, 13);
            Label7_INVENTARIO.TabIndex = 10;
            Label7_INVENTARIO.Text = "Descripción de Producto:";
            return Label7_INVENTARIO;
        }

        public Label CrearLabel8_INVENTARIO()
        {
            Label8_INVENTARIO.AutoSize = true;
            Label8_INVENTARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label8_INVENTARIO.ForeColor = System.Drawing.Color.White;
            Label8_INVENTARIO.Location = new System.Drawing.Point(75, 132);
            Label8_INVENTARIO.Name = "label8";
            Label8_INVENTARIO.Size = new System.Drawing.Size(139, 13);
            Label8_INVENTARIO.TabIndex = 11;
            Label8_INVENTARIO.Text = "Existencia en Almacen:";
            return Label8_INVENTARIO;
        }
        public Label CrearLabel9_INVENTARIO()
        {
            Label9_INVENTARIO.AutoSize = true;
            Label9_INVENTARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label9_INVENTARIO.ForeColor = System.Drawing.Color.White;
            Label9_INVENTARIO.Location = new System.Drawing.Point(112, 173);
            Label9_INVENTARIO.Name = "label9";
            Label9_INVENTARIO.Size = new System.Drawing.Size(46, 13);
            Label9_INVENTARIO.TabIndex = 12;
            Label9_INVENTARIO.Text = "Fecha:";

            return Label9_INVENTARIO;
        }
        public Label CrearLabel10_INVENTARIO()
        {
            Label10_INVENTARIO.AutoSize = true;
            Label10_INVENTARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label10_INVENTARIO.ForeColor = System.Drawing.Color.White;
            Label10_INVENTARIO.Location = new System.Drawing.Point(86, 21);
            Label10_INVENTARIO.Name = "label10";
            Label10_INVENTARIO.Size = new System.Drawing.Size(62, 13);
            Label10_INVENTARIO.TabIndex = 13;
            Label10_INVENTARIO.Text = "Producto:";
            return Label10_INVENTARIO;
        }
    }
}
