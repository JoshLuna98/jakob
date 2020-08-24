
USE [ALMACN_Estrellas_3]
GO
/****** Object:  Table [dbo].[ALMACENESTRELLAS]    Script Date: 23/08/2020 07:53:59 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALMACENESTRELLAS](
	[id_Cotizaciones] [int] NULL,
	[id_Trabajador] [int] NULL,
	[id_Inventario] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 23/08/2020 07:54:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[id_Cliente] [int] NOT NULL,
	[id_Datos] [int] NULL,
	[Limite_De_Credito] [int] NULL,
	[Nombres] [varchar](15) NULL,
	[Apellido_Paterno] [varchar](15) NULL,
	[Apellido_Materno] [varchar](15) NULL,
	[Correo] [varchar](30) NULL,
	[CURP] [varchar](18) NULL,
	[Colonia] [varchar](15) NULL,
	[Ciudad] [varchar](15) NULL,
	[Telefono] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COMPRAS]    Script Date: 23/08/2020 07:54:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMPRAS](
	[id_Compra] [int] NOT NULL,
	[id_Producto] [int] NULL,
	[id_Proveedores] [int] NULL,
	[id_Cotizaciones] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COTIZACIONES]    Script Date: 23/08/2020 07:54:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COTIZACIONES](
	[id_Cotizaciones] [int] NOT NULL,
	[id_Producto] [int] NULL,
	[id_Proveedores] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Cotizaciones] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DATOS]    Script Date: 23/08/2020 07:54:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DATOS](
	[id_Datos] [int] NOT NULL,
	[Nombres] [nvarchar](50) NULL,
	[Apellido_Paterno] [nvarchar](50) NULL,
	[Apellido_Materno] [nvarchar](50) NULL,
	[Telefono] [varchar](10) NULL,
	[Ciudad] [nvarchar](50) NULL,
	[Colonio] [nvarchar](50) NULL,
	[Calle] [nvarchar](50) NULL,
	[Numero] [int] NULL,
	[RFC] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Datos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVENTARIO]    Script Date: 23/08/2020 07:54:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVENTARIO](
	[id_Inventario] [int] NOT NULL,
	[id_Producto] [int] NULL,
	[id_Compra] [int] NULL,
	[id_Venta] [int] NULL,
	[id_Mobiliario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Inventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MOBILIARIO]    Script Date: 23/08/2020 07:54:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOBILIARIO](
	[id_Mobiliario] [int] NOT NULL,
	[Tipo_Mobiliario] [nvarchar](max) NULL,
	[Cantidad_Mobiliario] [int] NULL,
	[Descripcion_Moviliario] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Mobiliario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTOS]    Script Date: 23/08/2020 07:54:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTOS](
	[id_Producto] [int] NOT NULL,
	[Precio] [int] NULL,
	[Cantidad_Producto] [int] NULL,
	[Marca_Producto] [nvarchar](max) NULL,
	[Descripcin_Producto] [nvarchar](max) NULL,
	[Garantia] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROVEEDOR_EXTRANGEROS]    Script Date: 23/08/2020 07:54:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVEEDOR_EXTRANGEROS](
	[id_Proveedor_EXTRANGEROS] [int] NOT NULL,
	[id_Datos] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Proveedor_EXTRANGEROS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROVEEDOR_LOCAL]    Script Date: 23/08/2020 07:54:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVEEDOR_LOCAL](
	[id_Proveedor_Local] [int] NOT NULL,
	[id_Datos] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Proveedor_Local] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROVEEDORES]    Script Date: 23/08/2020 07:54:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVEEDORES](
	[id_Proveedores] [int] NOT NULL,
	[id_Datos] [int] NULL,
	[Tipo_Proveedor] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Proveedores] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PUESTO_DEL_TRABAJADOR]    Script Date: 23/08/2020 07:54:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PUESTO_DEL_TRABAJADOR](
	[id_Puesto] [int] NOT NULL,
	[Tipo_Puesto] [nvarchar](max) NULL,
	[id_Turno] [int] NULL,
	[id_Trabajador] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Puesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TICKETS]    Script Date: 23/08/2020 07:54:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TICKETS](
	[id_Tiket] [int] NOT NULL,
	[id_Venta] [int] NULL,
	[id_Producto] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Tiket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRABAJADORES]    Script Date: 23/08/2020 07:54:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRABAJADORES](
	[id_Trabajador] [int] NOT NULL,
	[id_Datos] [int] NULL,
	[id_Turno] [int] NULL,
	[id_Puesto] [int] NULL,
	[Nombres] [varchar](15) NULL,
	[Apellido_Paterno] [varchar](15) NULL,
	[Apellido_Materno] [varchar](15) NULL,
	[Correo] [varchar](30) NULL,
	[Telefono] [varchar](10) NULL,
	[CURP] [varchar](18) NULL,
	[Colonia] [varchar](30) NULL,
	[Ciudad] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Trabajador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TURNO_DEL_TRABAJADOR]    Script Date: 23/08/2020 07:54:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TURNO_DEL_TRABAJADOR](
	[id_Turno] [int] NOT NULL,
	[Tipo_Turno] [nvarchar](max) NULL,
	[id_Puesto] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VENTAS]    Script Date: 23/08/2020 07:54:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VENTAS](
	[id_Venta] [int] NOT NULL,
	[id_Cliente] [int] NULL,
	[id_Producto] [int] NULL,
	[id_Proveedores] [int] NULL,
	[Porciento_Descuento] [nvarchar](max) NULL,
	[Devoluciones] [nvarchar](max) NULL,
	[Tipo_Garantia] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[ALMACENESTRELLAS] ([id_Cotizaciones], [id_Trabajador], [id_Inventario]) VALUES (1, 2, 1)
GO
INSERT [dbo].[CLIENTES] ([id_Cliente], [id_Datos], [Limite_De_Credito], [Nombres], [Apellido_Paterno], [Apellido_Materno], [Correo], [CURP], [Colonia], [Ciudad], [Telefono]) VALUES (1, 1, 10, N'pedro', N'lopez', N'jbfrijofi ', N'burnmien ', N'ybunh ', N'ijiun ', N'bnmiu', N'2')
GO
INSERT [dbo].[CLIENTES] ([id_Cliente], [id_Datos], [Limite_De_Credito], [Nombres], [Apellido_Paterno], [Apellido_Materno], [Correo], [CURP], [Colonia], [Ciudad], [Telefono]) VALUES (2, 2, 541, N'edwin', N'fewgr ', N'fegr ', N'rgt ', N'HBVYTHN548 ', N'vygbhjn ', N'ghbjn', N'8715415415')
GO
INSERT [dbo].[CLIENTES] ([id_Cliente], [id_Datos], [Limite_De_Credito], [Nombres], [Apellido_Paterno], [Apellido_Materno], [Correo], [CURP], [Colonia], [Ciudad], [Telefono]) VALUES (3, 3, 5000, N'luis', N'lopez', N'jbfrijofi ', N'burnmien ', N'HGIOTHIOH578454 ', N'ijiun ', N'bnmiu', N'2')
GO
INSERT [dbo].[CLIENTES] ([id_Cliente], [id_Datos], [Limite_De_Credito], [Nombres], [Apellido_Paterno], [Apellido_Materno], [Correo], [CURP], [Colonia], [Ciudad], [Telefono]) VALUES (4, 4, 2000, N'pedro', N'lopez', N'jbfrijofi ', N'burnmien ', N'jbnmrvybuinm ', N'ijiun ', N'bnmiu', N'2')
GO
INSERT [dbo].[COMPRAS] ([id_Compra], [id_Producto], [id_Proveedores], [id_Cotizaciones]) VALUES (1, 1, 1, 1)
GO
INSERT [dbo].[COTIZACIONES] ([id_Cotizaciones], [id_Producto], [id_Proveedores]) VALUES (1, 1, 1)
GO
INSERT [dbo].[DATOS] ([id_Datos], [Nombres], [Apellido_Paterno], [Apellido_Materno], [Telefono], [Ciudad], [Colonio], [Calle], [Numero], [RFC]) VALUES (1, N'Ale', N'Luna', N'Borja', N'567', N'bhnj ', N'bhnj ', N'bhnj ', 4546, N'bhnjmk')
GO
INSERT [dbo].[DATOS] ([id_Datos], [Nombres], [Apellido_Paterno], [Apellido_Materno], [Telefono], [Ciudad], [Colonio], [Calle], [Numero], [RFC]) VALUES (2, N'Pedro ', N'Lopez ', N'Marquez ', N'87145451 ', N'NULL ', N'NULL ', N'NULL ', 12, N'GHAGCU')
GO
INSERT [dbo].[DATOS] ([id_Datos], [Nombres], [Apellido_Paterno], [Apellido_Materno], [Telefono], [Ciudad], [Colonio], [Calle], [Numero], [RFC]) VALUES (3, N'Rodrigo ', N'Perez ', N'Marquez ', N'8715562825', N'NULL ', N'NULL ', N'NULL ', 265, N'KNVYBRN')
GO
INSERT [dbo].[DATOS] ([id_Datos], [Nombres], [Apellido_Paterno], [Apellido_Materno], [Telefono], [Ciudad], [Colonio], [Calle], [Numero], [RFC]) VALUES (4, N'juan', N'Estrada', N'Mendez', N'567', N'bhnj ', N'bhnj ', N'bhnj ', 4546, N'bhnjmk')
GO
INSERT [dbo].[DATOS] ([id_Datos], [Nombres], [Apellido_Paterno], [Apellido_Materno], [Telefono], [Ciudad], [Colonio], [Calle], [Numero], [RFC]) VALUES (5, N'rico', N'Jimenez', N'Lugo', N'87155', N'gvbjnknk ', N'gvjkjlvjkykj ', N'hvjhjhvbk ', 15689, N'hgftrgn')
GO
INSERT [dbo].[INVENTARIO] ([id_Inventario], [id_Producto], [id_Compra], [id_Venta], [id_Mobiliario]) VALUES (1, 1, 1, 1, 1)
GO
INSERT [dbo].[MOBILIARIO] ([id_Mobiliario], [Tipo_Mobiliario], [Cantidad_Mobiliario], [Descripcion_Moviliario]) VALUES (1, N'Computadora', 50, N'Computadoras para el travajo de los travajadores y Chequeo del almacen')
GO
INSERT [dbo].[MOBILIARIO] ([id_Mobiliario], [Tipo_Mobiliario], [Cantidad_Mobiliario], [Descripcion_Moviliario]) VALUES (2, N'Estanteria ', 70, N'Para poder poner los productos a la vistaa de los clientes')
GO
INSERT [dbo].[MOBILIARIO] ([id_Mobiliario], [Tipo_Mobiliario], [Cantidad_Mobiliario], [Descripcion_Moviliario]) VALUES (3, N'cajas de cobro', 15, N'Para poder cobrarle al cliente')
GO
INSERT [dbo].[PRODUCTOS] ([id_Producto], [Precio], [Cantidad_Producto], [Marca_Producto], [Descripcin_Producto], [Garantia]) VALUES (1, 1500, 100, N'Pinol', N'Desinfectante', N'Daño de producto de fbrica 10 dias')
GO
INSERT [dbo].[PRODUCTOS] ([id_Producto], [Precio], [Cantidad_Producto], [Marca_Producto], [Descripcin_Producto], [Garantia]) VALUES (2, 155, 110, N'papel higienico ', N'*****', N'NO aplica')
GO
INSERT [dbo].[PRODUCTOS] ([id_Producto], [Precio], [Cantidad_Producto], [Marca_Producto], [Descripcin_Producto], [Garantia]) VALUES (3, 2500, 150, N'Refresco', N'Refresco de cola', N'No aplica')
GO
INSERT [dbo].[PROVEEDOR_LOCAL] ([id_Proveedor_Local], [id_Datos]) VALUES (1, 1)
GO
INSERT [dbo].[PROVEEDORES] ([id_Proveedores], [id_Datos], [Tipo_Proveedor]) VALUES (1, 4, N'nuevo')
GO
INSERT [dbo].[PUESTO_DEL_TRABAJADOR] ([id_Puesto], [Tipo_Puesto], [id_Turno], [id_Trabajador]) VALUES (1, N'Jefe', 1, 1)
GO
INSERT [dbo].[PUESTO_DEL_TRABAJADOR] ([id_Puesto], [Tipo_Puesto], [id_Turno], [id_Trabajador]) VALUES (2, N'Encargado', 2, 2)
GO
INSERT [dbo].[PUESTO_DEL_TRABAJADOR] ([id_Puesto], [Tipo_Puesto], [id_Turno], [id_Trabajador]) VALUES (3, N'aseo', 3, 3)
GO
INSERT [dbo].[TICKETS] ([id_Tiket], [id_Venta], [id_Producto]) VALUES (1, 1, 1)
GO
INSERT [dbo].[TRABAJADORES] ([id_Trabajador], [id_Datos], [id_Turno], [id_Puesto], [Nombres], [Apellido_Paterno], [Apellido_Materno], [Correo], [Telefono], [CURP], [Colonia], [Ciudad]) VALUES (1, 4, 1, 1, N'Fernando', N'Lugo ', N'Rodriguez ', N'NULL ', N'8745155448', N'bnjm ', N'NULL ', N'NULL')
GO
INSERT [dbo].[TRABAJADORES] ([id_Trabajador], [id_Datos], [id_Turno], [id_Puesto], [Nombres], [Apellido_Paterno], [Apellido_Materno], [Correo], [Telefono], [CURP], [Colonia], [Ciudad]) VALUES (2, 4, 2, 1, N'pedro', N'perez', N'vbhn ', N'NULL', N'4875 ', N'tyvbuhnijmk ', N'Lerdo', N'tokio')
GO
INSERT [dbo].[TRABAJADORES] ([id_Trabajador], [id_Datos], [id_Turno], [id_Puesto], [Nombres], [Apellido_Paterno], [Apellido_Materno], [Correo], [Telefono], [CURP], [Colonia], [Ciudad]) VALUES (3, 1, 1, 1, N'Enrique ', N'Lugo ', N'Rodriguez ', N'NULL ', N'8745155448', N'GCRSHUFTG48551 ', N'NULL ', N'NULL')
GO
INSERT [dbo].[TURNO_DEL_TRABAJADOR] ([id_Turno], [Tipo_Turno], [id_Puesto]) VALUES (1, N'Mañana', 1)
GO
INSERT [dbo].[TURNO_DEL_TRABAJADOR] ([id_Turno], [Tipo_Turno], [id_Puesto]) VALUES (2, N'Tarde', 2)
GO
INSERT [dbo].[TURNO_DEL_TRABAJADOR] ([id_Turno], [Tipo_Turno], [id_Puesto]) VALUES (3, N'Noche', 3)
GO
INSERT [dbo].[VENTAS] ([id_Venta], [id_Cliente], [id_Producto], [id_Proveedores], [Porciento_Descuento], [Devoluciones], [Tipo_Garantia]) VALUES (1, 1, 1, 1, N'0.5', N'Nula', N'NULL')
GO
ALTER TABLE [dbo].[ALMACENESTRELLAS]  WITH CHECK ADD FOREIGN KEY([id_Cotizaciones])
REFERENCES [dbo].[COTIZACIONES] ([id_Cotizaciones])
GO
ALTER TABLE [dbo].[ALMACENESTRELLAS]  WITH CHECK ADD FOREIGN KEY([id_Inventario])
REFERENCES [dbo].[INVENTARIO] ([id_Inventario])
GO
ALTER TABLE [dbo].[ALMACENESTRELLAS]  WITH CHECK ADD FOREIGN KEY([id_Trabajador])
REFERENCES [dbo].[TRABAJADORES] ([id_Trabajador])
GO
ALTER TABLE [dbo].[COMPRAS]  WITH CHECK ADD FOREIGN KEY([id_Cotizaciones])
REFERENCES [dbo].[COTIZACIONES] ([id_Cotizaciones])
GO
ALTER TABLE [dbo].[COMPRAS]  WITH CHECK ADD FOREIGN KEY([id_Cotizaciones])
REFERENCES [dbo].[COTIZACIONES] ([id_Cotizaciones])
GO
ALTER TABLE [dbo].[COMPRAS]  WITH CHECK ADD FOREIGN KEY([id_Producto])
REFERENCES [dbo].[PRODUCTOS] ([id_Producto])
GO
ALTER TABLE [dbo].[COMPRAS]  WITH CHECK ADD FOREIGN KEY([id_Proveedores])
REFERENCES [dbo].[PROVEEDORES] ([id_Proveedores])
GO
ALTER TABLE [dbo].[COTIZACIONES]  WITH CHECK ADD FOREIGN KEY([id_Producto])
REFERENCES [dbo].[PRODUCTOS] ([id_Producto])
GO
ALTER TABLE [dbo].[COTIZACIONES]  WITH CHECK ADD FOREIGN KEY([id_Proveedores])
REFERENCES [dbo].[PROVEEDORES] ([id_Proveedores])
GO
ALTER TABLE [dbo].[INVENTARIO]  WITH CHECK ADD FOREIGN KEY([id_Compra])
REFERENCES [dbo].[COMPRAS] ([id_Compra])
GO
ALTER TABLE [dbo].[INVENTARIO]  WITH CHECK ADD FOREIGN KEY([id_Compra])
REFERENCES [dbo].[COMPRAS] ([id_Compra])
GO
ALTER TABLE [dbo].[INVENTARIO]  WITH CHECK ADD FOREIGN KEY([id_Mobiliario])
REFERENCES [dbo].[MOBILIARIO] ([id_Mobiliario])
GO
ALTER TABLE [dbo].[INVENTARIO]  WITH CHECK ADD FOREIGN KEY([id_Producto])
REFERENCES [dbo].[PRODUCTOS] ([id_Producto])
GO
ALTER TABLE [dbo].[INVENTARIO]  WITH CHECK ADD FOREIGN KEY([id_Venta])
REFERENCES [dbo].[VENTAS] ([id_Venta])
GO
ALTER TABLE [dbo].[PROVEEDOR_EXTRANGEROS]  WITH CHECK ADD FOREIGN KEY([id_Datos])
REFERENCES [dbo].[DATOS] ([id_Datos])
GO
ALTER TABLE [dbo].[PROVEEDOR_EXTRANGEROS]  WITH CHECK ADD FOREIGN KEY([id_Proveedor_EXTRANGEROS])
REFERENCES [dbo].[PROVEEDORES] ([id_Proveedores])
GO
ALTER TABLE [dbo].[PROVEEDOR_LOCAL]  WITH CHECK ADD FOREIGN KEY([id_Datos])
REFERENCES [dbo].[DATOS] ([id_Datos])
GO
ALTER TABLE [dbo].[PROVEEDOR_LOCAL]  WITH CHECK ADD FOREIGN KEY([id_Datos])
REFERENCES [dbo].[DATOS] ([id_Datos])
GO
ALTER TABLE [dbo].[PROVEEDOR_LOCAL]  WITH CHECK ADD FOREIGN KEY([id_Proveedor_Local])
REFERENCES [dbo].[PROVEEDORES] ([id_Proveedores])
GO
ALTER TABLE [dbo].[PROVEEDORES]  WITH CHECK ADD FOREIGN KEY([id_Datos])
REFERENCES [dbo].[DATOS] ([id_Datos])
GO
ALTER TABLE [dbo].[PUESTO_DEL_TRABAJADOR]  WITH CHECK ADD FOREIGN KEY([id_Turno])
REFERENCES [dbo].[TURNO_DEL_TRABAJADOR] ([id_Turno])
GO
ALTER TABLE [dbo].[TICKETS]  WITH CHECK ADD FOREIGN KEY([id_Producto])
REFERENCES [dbo].[PRODUCTOS] ([id_Producto])
GO
ALTER TABLE [dbo].[TICKETS]  WITH CHECK ADD FOREIGN KEY([id_Venta])
REFERENCES [dbo].[VENTAS] ([id_Venta])
GO
ALTER TABLE [dbo].[TICKETS]  WITH CHECK ADD FOREIGN KEY([id_Venta])
REFERENCES [dbo].[VENTAS] ([id_Venta])
GO
ALTER TABLE [dbo].[TRABAJADORES]  WITH CHECK ADD FOREIGN KEY([id_Datos])
REFERENCES [dbo].[DATOS] ([id_Datos])
GO
ALTER TABLE [dbo].[TRABAJADORES]  WITH CHECK ADD FOREIGN KEY([id_Puesto])
REFERENCES [dbo].[PUESTO_DEL_TRABAJADOR] ([id_Puesto])
GO
ALTER TABLE [dbo].[VENTAS]  WITH CHECK ADD FOREIGN KEY([id_Cliente])
REFERENCES [dbo].[COMPRAS] ([id_Compra])
GO
ALTER TABLE [dbo].[VENTAS]  WITH CHECK ADD FOREIGN KEY([id_Producto])
REFERENCES [dbo].[PRODUCTOS] ([id_Producto])
GO
ALTER TABLE [dbo].[VENTAS]  WITH CHECK ADD FOREIGN KEY([id_Proveedores])
REFERENCES [dbo].[PROVEEDORES] ([id_Proveedores])
GO
