USE [SistemaCine]
GO
/****** Object:  Table [dbo].[TArtista]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TArtista](
	[Artista_id] [int] IDENTITY(1,1) NOT NULL,
	[Artista_nacionalidad] [varchar](50) NULL,
	[Artista_nombre] [varchar](50) NULL,
	[Artista_biografia] [varchar](50) NULL,
	[Artista_estado] [varchar](1) NULL,
 CONSTRAINT [TArtista_PK] PRIMARY KEY CLUSTERED 
(
	[Artista_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TColeccion]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TColeccion](
	[Coleccion_id] [int] IDENTITY(1,1) NOT NULL,
	[Museo_id] [int] NOT NULL,
	[Coleccion_nombre] [varchar](50) NULL,
	[Coleccion_siglo] [varchar](50) NULL,
	[Coleccion_observaciones] [varchar](50) NULL,
	[Coleccion_estado] [varchar](1) NULL,
 CONSTRAINT [TColeccion_PK] PRIMARY KEY CLUSTERED 
(
	[Coleccion_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TEntrada]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TEntrada](
	[Entrada_id] [int] IDENTITY(1,1) NOT NULL,
	[Museo_id] [int] NOT NULL,
	[Precio_id] [int] NOT NULL,
	[Tarjeta_id] [int] NOT NULL,
	[Entrada_nombreVisitante] [varchar](50) NULL,
	[Entrada_fecha] [varchar](50) NULL,
	[Entrada_cantidad] [int] NULL,
	[Entrada_subtotal] [real] NULL,
	[Entrada_comision] [real] NULL,
	[Entrada_total] [real] NULL,
	[Entrada_estado] [varchar](1) NULL,
 CONSTRAINT [TEntrada_PK] PRIMARY KEY CLUSTERED 
(
	[Entrada_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TImagen]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[TImagen](
	[Imagen_id] [int] IDENTITY(1,1) NOT NULL,
	[Obra_id] [int] NOT NULL,
	[Imagen_ubicacion] [image] NULL,
	[Imagen_estado] [varchar](1) NULL,
 CONSTRAINT [TImagen_PK] PRIMARY KEY CLUSTERED 
(
	[Imagen_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TMuseo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TMuseo](
	[Museo_id] [int] IDENTITY(1,1) NOT NULL,
	[TipoMuseo_id] [int] NOT NULL,
	[Museo_nombre] [varchar](50) NULL,
	[Museo_instalacion] [varchar](50) NULL,
	[Museo_estado] [varchar](1) NULL,
 CONSTRAINT [TMuseo_PK] PRIMARY KEY CLUSTERED 
(
	[Museo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TObra]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TObra](
	[Obra_id] [int] IDENTITY(1,1) NOT NULL,
	[Artista_id] [int] NOT NULL,
	[Coleccion_id] [int] NOT NULL,
	[TipoObra_id] [int] NOT NULL,
	[Obra_nombre] [varchar](50) NULL,
	[Obra_descripcion] [varchar](50) NULL,
	[Obra_cultura] [varchar](50) NULL,
	[Obra_estado] [varchar](1) NULL,
 CONSTRAINT [TObra_PK] PRIMARY KEY CLUSTERED 
(
	[Obra_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TPrecio]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TPrecio](
	[Precio_id] [int] IDENTITY(1,1) NOT NULL,
	[Museo_id] [int] NOT NULL,
	[Precio_modalidad] [varchar](50) NULL,
	[Precio_monto] [float] NULL,
	[Precio_estado] [varchar](1) NULL,
 CONSTRAINT [TPrecio_PK] PRIMARY KEY CLUSTERED 
(
	[Precio_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TTarjeta]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TTarjeta](
	[Tarjeta_id] [int] IDENTITY(1,1) NOT NULL,
	[Tarjeta_nombre] [varchar](50) NULL,
	[Tarjeta_porcentaje] [varchar](50) NULL,
	[Tarjeta_estado] [varchar](1) NULL,
 CONSTRAINT [TTarjeta_PK] PRIMARY KEY CLUSTERED 
(
	[Tarjeta_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TTipoMuseo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[TTipoMuseo](
	[TipoMuseo_id] [int] IDENTITY(1,1) NOT NULL,
	[TipoMuseo_tipo] [varchar](50) NULL,
	[TipoMuseo_descripcion] [varchar](50) NULL,
	[TipoMuseo_estado] [varchar](1) NULL,
 CONSTRAINT [TTipoMuseo_PK] PRIMARY KEY CLUSTERED 
(
	[TipoMuseo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TTipoObra]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TTipoObra](
	[TipoObra_id] [int] IDENTITY(1,1) NOT NULL,
	[TipoObra_tipoObra] [varchar](50) NULL,
	[TipoObra_descripcion] [varchar](50) NULL,
	[TipoObra_estado] [varchar](1) NULL,
 CONSTRAINT [TTipoObra_PK] PRIMARY KEY CLUSTERED 
(
	[TipoObra_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TUsuario]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TUsuario](
	[Usuario_id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario_nombre] [varchar](50) NULL,
	[Usuario_tipo] [varchar](50) NULL,
	[Usuario_contrasenna] [varchar](50) NULL,
	[Usuario_estado] [varchar](1) NULL,
 CONSTRAINT [TUsuario_PK] PRIMARY KEY CLUSTERED 
(
	[Usuario_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[TColeccion]  WITH CHECK ADD  CONSTRAINT [TColeccion_FK] FOREIGN KEY([Museo_id])
REFERENCES [dbo].[TMuseo] ([Museo_id])
GO
ALTER TABLE [dbo].[TColeccion] CHECK CONSTRAINT [TColeccion_FK]
GO
ALTER TABLE [dbo].[TEntrada]  WITH CHECK ADD  CONSTRAINT [TEntrada_FK] FOREIGN KEY([Museo_id])
REFERENCES [dbo].[TMuseo] ([Museo_id])
GO
ALTER TABLE [dbo].[TEntrada] CHECK CONSTRAINT [TEntrada_FK]
GO
ALTER TABLE [dbo].[TEntrada]  WITH CHECK ADD  CONSTRAINT [TEntrada_FK1] FOREIGN KEY([Precio_id])
REFERENCES [dbo].[TPrecio] ([Precio_id])
GO
ALTER TABLE [dbo].[TEntrada] CHECK CONSTRAINT [TEntrada_FK1]
GO
ALTER TABLE [dbo].[TEntrada]  WITH CHECK ADD  CONSTRAINT [TEntrada_FK2] FOREIGN KEY([Tarjeta_id])
REFERENCES [dbo].[TTarjeta] ([Tarjeta_id])
GO
ALTER TABLE [dbo].[TEntrada] CHECK CONSTRAINT [TEntrada_FK2]
GO
ALTER TABLE [dbo].[TImagen]  WITH CHECK ADD  CONSTRAINT [TImagen_FK] FOREIGN KEY([Obra_id])
REFERENCES [dbo].[TObra] ([Obra_id])
GO
ALTER TABLE [dbo].[TImagen] CHECK CONSTRAINT [TImagen_FK]
GO
ALTER TABLE [dbo].[TObra]  WITH CHECK ADD  CONSTRAINT [TObra_FK] FOREIGN KEY([Artista_id])
REFERENCES [dbo].[TArtista] ([Artista_id])
GO
ALTER TABLE [dbo].[TObra] CHECK CONSTRAINT [TObra_FK]
GO
ALTER TABLE [dbo].[TObra]  WITH CHECK ADD  CONSTRAINT [TObra_FK1] FOREIGN KEY([Coleccion_id])
REFERENCES [dbo].[TColeccion] ([Coleccion_id])
GO
ALTER TABLE [dbo].[TObra] CHECK CONSTRAINT [TObra_FK1]
GO
ALTER TABLE [dbo].[TObra]  WITH CHECK ADD  CONSTRAINT [TObra_FK2] FOREIGN KEY([TipoObra_id])
REFERENCES [dbo].[TTipoObra] ([TipoObra_id])
GO
ALTER TABLE [dbo].[TObra] CHECK CONSTRAINT [TObra_FK2]
GO
ALTER TABLE [dbo].[TPrecio]  WITH CHECK ADD  CONSTRAINT [TPrecio_FK] FOREIGN KEY([Museo_id])
REFERENCES [dbo].[TMuseo] ([Museo_id])
GO
ALTER TABLE [dbo].[TPrecio] CHECK CONSTRAINT [TPrecio_FK]
GO
/****** Object:  StoredProcedure [dbo].[ActivarArtista]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActivarArtista] @Artista_id INT
AS
	BEGIN
		UPDATE TArtista
		SET Artista_estado = 'A'
		WHERE Artista_id = @Artista_id
	END

GO
/****** Object:  StoredProcedure [dbo].[ActivarColeccion]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActivarColeccion] @Coleccion_id INT
AS
	BEGIN
		UPDATE TColeccion
		SET Coleccion_estado = 'A'
		WHERE Coleccion_id = @Coleccion_id
	END

GO
/****** Object:  StoredProcedure [dbo].[ActivarEntrada]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActivarEntrada] @Entrada_id INT
AS
	BEGIN
		UPDATE TEntrada
		SET Entrada_estado = 'A'
		WHERE Entrada_id = @Entrada_id
	END

GO
/****** Object:  StoredProcedure [dbo].[ActivarImagen]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActivarImagen] @Imagen_id INT
AS
	BEGIN
		UPDATE TImagen
		SET Imagen_estado = 'A'
		WHERE Imagen_id = @Imagen_id
	END

GO
/****** Object:  StoredProcedure [dbo].[ActivarMuseo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActivarMuseo] @Museo_id INT
AS
	BEGIN
		UPDATE TMuseo
		SET Museo_estado = 'A'
		WHERE Museo_id = @Museo_id
	END

GO
/****** Object:  StoredProcedure [dbo].[ActivarObra]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActivarObra] @Obra_id INT
AS
	BEGIN
		UPDATE TObra
		SET Obra_estado = 'A'
		WHERE Obra_id = @Obra_id
	END

GO
/****** Object:  StoredProcedure [dbo].[ActivarPrecio]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActivarPrecio] @Precio_id INT
AS
	BEGIN
		UPDATE TPrecio
		SET Precio_estado = 'A'
		WHERE Precio_id = @Precio_id
	END

GO
/****** Object:  StoredProcedure [dbo].[ActivarTarjeta]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActivarTarjeta] @Tarjeta_id INT
AS
	BEGIN
		UPDATE TTarjeta
		SET Tarjeta_estado = 'A'
		WHERE Tarjeta_id = @Tarjeta_id
	END

GO
/****** Object:  StoredProcedure [dbo].[ActivarTipoMuseo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActivarTipoMuseo] @TipoMuseo_id INT
AS
	BEGIN
		UPDATE TTipoMuseo
		SET TipoMuseo_estado = 'A'
		WHERE TipoMuseo_id = @TipoMuseo_id
	END

GO
/****** Object:  StoredProcedure [dbo].[ActivarTipoObra]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActivarTipoObra] @TipoObra_id INT
AS
	BEGIN
		UPDATE TTipoObra
		SET TipoObra_estado = 'A'
		WHERE TipoObra_id = @TipoObra_id
	END

GO
/****** Object:  StoredProcedure [dbo].[ConsultarArtista]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarArtista] @Artista_id INT
AS
BEGIN
	 SELECT *
	 FROM TArtista
	 WHERE Artista_id = @Artista_id
END

GO
/****** Object:  StoredProcedure [dbo].[ConsultarColeccion]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarColeccion] @Coleccion_id INT
AS
BEGIN
	 SELECT *
	 FROM TColeccion
	 WHERE Coleccion_id = @Coleccion_id
END

GO
/****** Object:  StoredProcedure [dbo].[ConsultarEntrada]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarEntrada] @Entrada_id INT
AS
BEGIN
	 SELECT *
	 FROM TEntrada
	 WHERE Entrada_id = @Entrada_id
END

GO
/****** Object:  StoredProcedure [dbo].[ConsultarImagen]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarImagen] @Imagen_id INT
AS
BEGIN
	 SELECT *
	 FROM TImagen
	 WHERE Imagen_id = @Imagen_id
END

GO
/****** Object:  StoredProcedure [dbo].[ConsultarMuseo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarMuseo] @Museo_id INT
AS
BEGIN
	 SELECT *
	 FROM TMuseo
	 WHERE Museo_id = @Museo_id
END

GO
/****** Object:  StoredProcedure [dbo].[ConsultarObra]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarObra] @Obra_id INT
AS
BEGIN
	 SELECT *
	 FROM TObra
	 WHERE Obra_id = @Obra_id
END

GO
/****** Object:  StoredProcedure [dbo].[ConsultarPrecio]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarPrecio] @Precio_id INT
AS
BEGIN
	 SELECT *
	 FROM TPrecio
	 WHERE Precio_id = @Precio_id
END

GO
/****** Object:  StoredProcedure [dbo].[ConsultarTarjeta]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarTarjeta] @Tarjeta_id INT
AS
BEGIN
	 SELECT *
	 FROM TTarjeta
	 WHERE Tarjeta_id = @Tarjeta_id
END

GO
/****** Object:  StoredProcedure [dbo].[ConsultarTipoMuseo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarTipoMuseo] @TipoMuseo_id INT
AS
BEGIN
	 SELECT *
	 FROM TTipoMuseo
	 WHERE TipoMuseo_id = @TipoMuseo_id
END

GO
/****** Object:  StoredProcedure [dbo].[ConsultarTipoObra]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarTipoObra] @TipoObra_id INT
AS
BEGIN
	 SELECT *
	 FROM TTipoObra
	 WHERE TipoObra_id = @TipoObra_id
END

GO
/****** Object:  StoredProcedure [dbo].[ConsultarUsuario]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarUsuario] @Usuario_id INT
AS
BEGIN
	 SELECT *
	 FROM TUsuario
	 WHERE Usuario_id = @Usuario_id
END

GO
/****** Object:  StoredProcedure [dbo].[ConsultarUsuarioLogin]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultarUsuarioLogin] @Usuario_id int, @Usuario_nombre VarChar
AS
BEGIN
	 SELECT *
	 FROM TUsuario
	 WHERE Usuario_id = @Usuario_id AND Usuario_nombre = @Usuario_nombre
END
GO
/****** Object:  StoredProcedure [dbo].[InactivarArtista]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InactivarArtista] @Artista_id INT
AS
	BEGIN
		UPDATE TArtista
		SET Artista_estado = 'I'
		WHERE Artista_id = @Artista_id
	END

GO
/****** Object:  StoredProcedure [dbo].[InactivarColeccion]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InactivarColeccion] @Coleccion_id INT
AS
	BEGIN
		UPDATE TColeccion
		SET Coleccion_estado = 'I'
		WHERE Coleccion_id = @Coleccion_id
	END

GO
/****** Object:  StoredProcedure [dbo].[InactivarEntrada]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InactivarEntrada] @Entrada_id INT
AS
	BEGIN
		UPDATE TEntrada
		SET Entrada_estado = 'I'
		WHERE Entrada_id = @Entrada_id
	END

GO
/****** Object:  StoredProcedure [dbo].[InactivarImagen]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InactivarImagen] @Imagen_id INT
AS
	BEGIN
		UPDATE TImagen
		SET Imagen_estado = 'I'
		WHERE Imagen_id = @Imagen_id
	END

GO
/****** Object:  StoredProcedure [dbo].[InactivarMuseo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InactivarMuseo] @Museo_id INT
AS
	BEGIN
		UPDATE TMuseo
		SET Museo_estado = 'I'
		WHERE Museo_id = @Museo_id
	END

GO
/****** Object:  StoredProcedure [dbo].[InactivarObra]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InactivarObra] @Obra_id INT
AS
	BEGIN
		UPDATE TObra
		SET Obra_estado = 'I'
		WHERE Obra_id = @Obra_id
	END

GO
/****** Object:  StoredProcedure [dbo].[InactivarPrecio]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InactivarPrecio] @Precio_id INT
AS
	BEGIN
		UPDATE TPrecio
		SET Precio_estado = 'I'
		WHERE Precio_id = @Precio_id
	END

GO
/****** Object:  StoredProcedure [dbo].[InactivarTarjeta]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InactivarTarjeta] @Tarjeta_id INT
AS
	BEGIN
		UPDATE TTarjeta
		SET Tarjeta_estado = 'I'
		WHERE Tarjeta_id = @Tarjeta_id
	END

GO
/****** Object:  StoredProcedure [dbo].[InactivarTipoMuseo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InactivarTipoMuseo] @TipoMuseo_id INT
AS
	BEGIN
		UPDATE TTipoMuseo
		SET TipoMuseo_estado = 'I'
		WHERE TipoMuseo_id = @TipoMuseo_id
	END

GO
/****** Object:  StoredProcedure [dbo].[InactivarTipoObra]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InactivarTipoObra] @TipoObra_id INT
AS
	BEGIN
		UPDATE TTipoObra
		SET TipoObra_estado = 'I'
		WHERE TipoObra_id = @TipoObra_id
	END

GO
/****** Object:  StoredProcedure [dbo].[InsertarArtista]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarArtista]  @Artista_nacionalidad VARCHAR(50),				/*NOTEN QUE LA LLAVE PRIMARIA (Estdiante_id), NO SE RECIBE COMO PARÁMETRO*/	
									@Artista_nombre VARCHAR(50),
									@Artista_biografia VARCHAR(50),
									@Artista_estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TArtista(                     /*ESTOS SON LOS CAMPOS DE LA TABLA*/
							Artista_nacionalidad,
							Artista_nombre,
							Artista_biografia,
							Artista_estado) 
	SELECT                                  /*ESTOS SON LOS PARÁMETROS DE ARRIBA QUE AQUÍ SE LE INDICA QUE LOS AGARRE PARA ALMACENARLOS EN LA TABLA*/
			@Artista_nacionalidad,
			@Artista_nombre,
			@Artista_biografia,
			@Artista_estado
END

GO
/****** Object:  StoredProcedure [dbo].[InsertarColeccion]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarColeccion] @Museo_id INT,                     /*ESTA PARTE ES DONDE SE DEFINEN LOS PARÁMETROS QUE SE VAN A RECIBIR*/	
									@Coleccion_nombre VARCHAR(50),
									@Coleccion_siglo VARCHAR(50),
									@Coleccion_observaciones VARCHAR(50),					
									@Coleccion_estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TColeccion(Museo_id,                     /*ESTOS SON LOS CAMPOS DE LA TABLA*/
							Coleccion_nombre,
							Coleccion_siglo,
							Coleccion_observaciones,
							Coleccion_estado) 
	SELECT  @Museo_id,                                   /*ESTOS SON LOS PARÁMETROS DE ARRIBA QUE AQUÍ SE LE INDICA QUE LOS AGARRE PARA ALMACENARLOS EN LA TABLA*/
			@Coleccion_nombre,
			@Coleccion_siglo,
			@Coleccion_observaciones,
			@Coleccion_estado
END

GO
/****** Object:  StoredProcedure [dbo].[InsertarEntrada]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarEntrada] @Museo_id INT,                     /*ESTA PARTE ES DONDE SE DEFINEN LOS PARÁMETROS QUE SE VAN A RECIBIR*/
									@Precio_id INT,
									@Tarjeta_id INT,
									@Entrada_nombreVisitante VARCHAR(50),
									@Entrada_fecha VARCHAR(50),
									@Entrada_cantidad INT,
									@Entrada_subtotal FLOAT(20),
									@Entrada_comision FLOAT(50),
									@Entrada_total FLOAT(50),
									@Entrada_estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TEntrada(Museo_id,                     /*ESTOS SON LOS CAMPOS DE LA TABLA*/
							Precio_id,
							Tarjeta_id,
							Entrada_nombreVisitante,
							Entrada_fecha,
							Entrada_cantidad,
							Entrada_subtotal,
							Entrada_comision,
							Entrada_total,
							Entrada_estado) 
	SELECT  @Museo_id,                                  /*ESTOS SON LOS PARÁMETROS DE ARRIBA QUE AQUÍ SE LE INDICA QUE LOS AGARRE PARA ALMACENARLOS EN LA TABLA*/
			@Precio_id,
			@Tarjeta_id,
			@Entrada_nombreVisitante,
			@Entrada_fecha,
			@Entrada_cantidad,
			@Entrada_subtotal,
			@Entrada_comision,
			@Entrada_total,
			@Entrada_estado
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarImagen]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarImagen] @Obra_id INT,                     /*ESTA PARTE ES DONDE SE DEFINEN LOS PARÁMETROS QUE SE VAN A RECIBIR*/		
									@Imagen_ubicacion image,
									@Imagen_estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TImagen(Obra_id,                     /*ESTOS SON LOS CAMPOS DE LA TABLA*/
							Imagen_ubicacion,
							Imagen_estado) 
	SELECT  @Obra_id,                                   /*ESTOS SON LOS PARÁMETROS DE ARRIBA QUE AQUÍ SE LE INDICA QUE LOS AGARRE PARA ALMACENARLOS EN LA TABLA*/
			@Imagen_ubicacion,
			@Imagen_estado
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarMuseo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarMuseo] @TipoMuseo_id INT,                     /*ESTA PARTE ES DONDE SE DEFINEN LOS PARÁMETROS QUE SE VAN A RECIBIR*/
									@Museo_nombre VARCHAR(50),
									@Museo_instalacion VARCHAR(50),
									@Museo_estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TMuseo(TipoMuseo_id,                     /*ESTOS SON LOS CAMPOS DE LA TABLA*/
							Museo_nombre,
							Museo_instalacion,
							Museo_estado) 
	SELECT  @TipoMuseo_id,                                   /*ESTOS SON LOS PARÁMETROS DE ARRIBA QUE AQUÍ SE LE INDICA QUE LOS AGARRE PARA ALMACENARLOS EN LA TABLA*/
			@Museo_nombre,
			@Museo_instalacion,
			@Museo_estado
END

GO
/****** Object:  StoredProcedure [dbo].[InsertarObra]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarObra] @Artista_id INT, 
									@Coleccion_id INT,
									@TipoObra_id INT,
								    @Obra_nombre VARCHAR(50),				/*NOTEN QUE LA LLAVE PRIMARIA (Estdiante_id), NO SE RECIBE COMO PARÁMETRO*/	
									@Obra_descripcion VARCHAR(50),
									@Obra_cultura VARCHAR(50),
									@Obra_estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TObra(Artista_id,                     /*ESTOS SON LOS CAMPOS DE LA TABLA*/
							Coleccion_id,
							TipoObra_id,
							Obra_nombre,
							Obra_descripcion,
							Obra_cultura,
							Obra_estado) 
	SELECT  @Artista_id,                                   /*ESTOS SON LOS PARÁMETROS DE ARRIBA QUE AQUÍ SE LE INDICA QUE LOS AGARRE PARA ALMACENARLOS EN LA TABLA*/
			@Coleccion_id,
			@TipoObra_id,
			@Obra_nombre,
			@Obra_descripcion,
			@Obra_cultura,
			@Obra_estado
END

GO
/****** Object:  StoredProcedure [dbo].[InsertarPrecio]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarPrecio] @Museo_id INT,                     /*ESTA PARTE ES DONDE SE DEFINEN LOS PARÁMETROS QUE SE VAN A RECIBIR*/
									@Precio_modalidad VARCHAR(50),
									@Precio_monto VARCHAR(50),
									@Precio_estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TPrecio(Museo_id,                     /*ESTOS SON LOS CAMPOS DE LA TABLA*/
							Precio_modalidad,
							Precio_monto,
							Precio_estado) 
	SELECT  @Museo_id,                                   /*ESTOS SON LOS PARÁMETROS DE ARRIBA QUE AQUÍ SE LE INDICA QUE LOS AGARRE PARA ALMACENARLOS EN LA TABLA*/
			@Precio_modalidad,
			@Precio_monto,
			@Precio_estado
END

GO
/****** Object:  StoredProcedure [dbo].[InsertarTarjeta]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarTarjeta]                     /*ESTA PARTE ES DONDE SE DEFINEN LOS PARÁMETROS QUE SE VAN A RECIBIR*/
									@Tarjeta_nombre VARCHAR(50),
									@Tarjeta_porcentaje VARCHAR(50),
									@Tarjeta_estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TTarjeta(                     /*ESTOS SON LOS CAMPOS DE LA TABLA*/
							Tarjeta_nombre,
							Tarjeta_porcentaje,
							Tarjeta_estado) 
	SELECT                                  /*ESTOS SON LOS PARÁMETROS DE ARRIBA QUE AQUÍ SE LE INDICA QUE LOS AGARRE PARA ALMACENARLOS EN LA TABLA*/
			@Tarjeta_nombre,
			@Tarjeta_porcentaje,
			@Tarjeta_estado
END

GO
/****** Object:  StoredProcedure [dbo].[InsertarTipoMuseo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarTipoMuseo]                  /*ESTA PARTE ES DONDE SE DEFINEN LOS PARÁMETROS QUE SE VAN A RECIBIR*/
									@TipoMuseo_tipo VARCHAR(50),
									@TipoMuseo_descripcion VARCHAR(50),
									@TipoMuseo_estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TTipoMuseo(                /*ESTOS SON LOS CAMPOS DE LA TABLA*/
							TipoMuseo_tipo,
							TipoMuseo_descripcion,
							TipoMuseo_estado) 
	SELECT                                     /*ESTOS SON LOS PARÁMETROS DE ARRIBA QUE AQUÍ SE LE INDICA QUE LOS AGARRE PARA ALMACENARLOS EN LA TABLA*/
			@TipoMuseo_tipo,
			@TipoMuseo_descripcion,
			@TipoMuseo_estado
END

GO
/****** Object:  StoredProcedure [dbo].[InsertarTipoObra]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarTipoObra]   
									@TipoObra_tipoObra VARCHAR(50),
									@TipoObra_descripcion VARCHAR(50),
									@TipoObra_estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TTipoObra(                    /*ESTOS SON LOS CAMPOS DE LA TABLA*/
							TipoObra_tipoObra,
							TipoObra_descripcion,
							TipoObra_estado) 
	SELECT                                   /*ESTOS SON LOS PARÁMETROS DE ARRIBA QUE AQUÍ SE LE INDICA QUE LOS AGARRE PARA ALMACENARLOS EN LA TABLA*/
			@TipoObra_tipoObra,
			@TipoObra_descripcion,
			@TipoObra_estado
END

GO
/****** Object:  StoredProcedure [dbo].[InsertarUsuario]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarUsuario]
									@Usuario_id INT,                      /*ESTA PARTE ES DONDE SE DEFINEN LOS PARÁMETROS QUE SE VAN A RECIBIR*/
									@Usuario_nombre VARCHAR(50),
	
									@Usuario_contrasenna VARCHAR(50),
									@Usuario_estado VARCHAR(1)
AS
BEGIN
	INSERT INTO TUsuario(   Usuario_id,                 /*ESTOS SON LOS CAMPOS DE LA TABLA*/
							Usuario_nombre,

							Usuario_contrasenna,
							Usuario_estado) 
	SELECT  @Usuario_id,                                   /*ESTOS SON LOS PARÁMETROS DE ARRIBA QUE AQUÍ SE LE INDICA QUE LOS AGARRE PARA ALMACENARLOS EN LA TABLA*/
			@Usuario_nombre,
	
			@Usuario_contrasenna,
			@Usuario_estado
END
GO
/****** Object:  StoredProcedure [dbo].[ListarArtista]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarArtista]
AS
BEGIN
	SELECT Artista_id,
		   Artista_nacionalidad,
		   Artista_nombre,
		   Artista_biografia,
		   Artista_estado
	FROM TArtista
	WHERE Artista_estado = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarArtistaInactivo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarArtistaInactivo]
AS
BEGIN
	SELECT Artista_id,
		   Artista_nacionalidad,
		   Artista_nombre,
		   Artista_biografia,
		   Artista_estado
	FROM TArtista
	WHERE Artista_estado = 'I'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarColeccion]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarColeccion]
AS
BEGIN
	SELECT Coleccion_id,
		   Museo_id,
		   Coleccion_nombre,
		   Coleccion_siglo,
		   Coleccion_observaciones,
		   Coleccion_estado
	FROM TColeccion
	WHERE Coleccion_estado = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarColeccionInactivo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarColeccionInactivo]
AS
BEGIN
	SELECT Coleccion_id,
		   Museo_id,
		   Coleccion_nombre,
		   Coleccion_siglo,
		   Coleccion_observaciones,
		   Coleccion_estado
	FROM TColeccion
	WHERE Coleccion_estado = 'I'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarEntrada]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarEntrada]
AS
BEGIN
	SELECT Entrada_id,
			Museo_id,
			Precio_id,
		   Tarjeta_id,
		   Entrada_nombreVisitante,
		   Entrada_fecha,
		   Entrada_cantidad,
		   Entrada_subtotal,
		   Entrada_comision,
		   Entrada_total,
		   Entrada_estado
	FROM TEntrada
	WHERE Entrada_estado = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarEntradaInactivo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarEntradaInactivo]
AS
BEGIN
	SELECT Entrada_id,
			Museo_id,
			Precio_id,
		   Tarjeta_id,
		   Entrada_nombreVisitante,
		   Entrada_fecha,
		   Entrada_cantidad,
		   Entrada_subtotal,
		   Entrada_comision,
		   Entrada_total,
		   Entrada_estado
	FROM TEntrada
	WHERE Entrada_estado = 'I'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarImagen]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarImagen]
AS
BEGIN
	SELECT Imagen_id,
		   Obra_id,
		   Imagen_ubicacion,
		   Imagen_estado
	FROM TImagen
	WHERE Imagen_estado = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarImagenInactivo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarImagenInactivo]
AS
BEGIN
	SELECT Imagen_id,
		   Obra_id,
		   Imagen_ubicacion,
		   Imagen_estado
	FROM TImagen
	WHERE Imagen_estado = 'I'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarMuseo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarMuseo]
AS
BEGIN
	SELECT Museo_id,
		   TipoMuseo_id,
		   Museo_nombre,
		   Museo_instalacion,
		   Museo_estado
	FROM TMuseo
	WHERE Museo_estado = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarMuseoInactivo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarMuseoInactivo]
AS
BEGIN
	SELECT Museo_id,
		   TipoMuseo_id,
		   Museo_nombre, 
		   Museo_instalacion,
		   Museo_estado
	FROM TMuseo
	WHERE Museo_estado = 'I'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarObra]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarObra]
AS
BEGIN
	SELECT Obra_id,
		   Artista_id,
		   Coleccion_id,
		   TipoObra_id,
		   Obra_nombre,
		   Obra_descripcion,
		   Obra_cultura,
		   Obra_estado
	FROM TObra
	WHERE Obra_estado = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarObraInactivo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarObraInactivo]
AS
BEGIN
	SELECT Obra_id,
		   Artista_id,
		   Coleccion_id,
		   TipoObra_id,
		   Obra_nombre,
		   Obra_descripcion,
		   Obra_cultura,
		   Obra_estado
	FROM TObra
	WHERE Obra_estado = 'I'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarPrecio]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarPrecio]
AS
BEGIN
	SELECT Precio_id,
		   Museo_id,
		   Precio_modalidad, 
		   Precio_monto,
		   Precio_estado
	FROM TPrecio
	WHERE Precio_estado = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarPrecioInactivo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarPrecioInactivo]
AS
BEGIN
	SELECT Precio_id,
		   Museo_id,
		   Precio_modalidad, 
		   Precio_monto,
		   Precio_estado
	FROM TPrecio
	WHERE Precio_estado = 'I'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarTarjeta]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarTarjeta]
AS
BEGIN
	SELECT Tarjeta_id,
		   Tarjeta_nombre,
		   Tarjeta_porcentaje,
		   Tarjeta_estado
	FROM TTarjeta
	WHERE Tarjeta_estado = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarTarjetaInactivo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarTarjetaInactivo]
AS
BEGIN
	SELECT Tarjeta_id,
		   Tarjeta_nombre,
		   Tarjeta_porcentaje,
		   Tarjeta_estado
	FROM TTarjeta
	WHERE Tarjeta_estado = 'I'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarTipoMuseo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarTipoMuseo]
AS
BEGIN
	SELECT TipoMuseo_id,
		   TipoMuseo_tipo,
		   TipoMuseo_descripcion,
		   TipoMuseo_estado
	FROM TTipoMuseo
	WHERE TipoMuseo_estado = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarTipoMuseoInactivo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarTipoMuseoInactivo]
AS
BEGIN
	SELECT TipoMuseo_id,
		   TipoMuseo_tipo,
		   TipoMuseo_descripcion,
		   TipoMuseo_estado
	FROM TTipoMuseo
	WHERE TipoMuseo_estado = 'I'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarTipoObra]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarTipoObra]
AS
BEGIN
	SELECT TipoObra_id,
		   TipoObra_tipoObra, 
		   TipoObra_descripcion,
		   TipoObra_estado
	FROM TTipoObra
	WHERE TipoObra_estado = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarTipoObraInactivo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarTipoObraInactivo]
AS
BEGIN
	SELECT TipoObra_id,
		   TipoObra_tipoObra,
		   TipoObra_descripcion,
		   TipoObra_estado
	FROM TTipoObra
	WHERE TipoObra_estado = 'I'
END
GO
/****** Object:  StoredProcedure [dbo].[ListarUsuario]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarUsuario]
AS
BEGIN
	SELECT Usuario_id,
		   Usuario_nombre,
	
		   Usuario_contrasenna,
		   Usuario_estado
	FROM TUsuario
	WHERE Usuario_estado = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[ModificarArtista]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarArtista] @Artista_id INT,
								  @Artista_nacionalidad VARCHAR(50),		      /*NOTEN QUE AQUI SI SE RECIBE COMO PARÁMETRO LA LLAVE PRIMARIA (Estdiante_id)*/
								  @Artista_nombre VARCHAR(50),
								  @Artista_biografia VARCHAR(50),
								  @Artista_estado VARCHAR(1)
AS
	BEGIN
		UPDATE TArtista
		SET 
			Artista_nacionalidad = @Artista_nacionalidad,
			Artista_nombre = @Artista_nombre,
			Artista_biografia = @Artista_biografia,
			Artista_estado = @Artista_estado
		WHERE Artista_id = @Artista_id
	END

GO
/****** Object:  StoredProcedure [dbo].[ModificarColeccion]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarColeccion] @Coleccion_id INT,
								  @Museo_id INT,                     /*ESTA PARTE ES DONDE SE DEFINEN LOS PARÁMETROS QUE SE VAN A RECIBIR*/
								  @Coleccion_nombre VARCHAR(50),		      /*NOTEN QUE AQUI SI SE RECIBE COMO PARÁMETRO LA LLAVE PRIMARIA (Estdiante_id)*/
								  @Coleccion_siglo VARCHAR(50),
								  @Coleccion_observaciones VARCHAR(50),
								  @Coleccion_estado VARCHAR(1)
AS
	BEGIN
		UPDATE TColeccion
		SET Museo_id = @Museo_id,
			Coleccion_nombre = @Coleccion_nombre,
			Coleccion_siglo = @Coleccion_siglo,
			Coleccion_observaciones = @Coleccion_observaciones,
			Coleccion_estado = @Coleccion_estado
		WHERE Coleccion_id = @Coleccion_id
	END

GO
/****** Object:  StoredProcedure [dbo].[ModificarImagen]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarImagen] @Imagen_id INT,
								  @Obra_id INT,                     /*ESTA PARTE ES DONDE SE DEFINEN LOS PARÁMETROS QUE SE VAN A RECIBIR*/
								  @Imagen_ubicacion image,
								  @Imagen_estado VARCHAR(1)
AS
	BEGIN
		UPDATE TImagen
		SET Obra_id = @Obra_id,
			Imagen_ubicacion = @Imagen_ubicacion,
			Imagen_estado = @Imagen_estado
		WHERE Imagen_id = @Imagen_id
	END
GO
/****** Object:  StoredProcedure [dbo].[ModificarMuseo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarMuseo] @Museo_id INT,
								  @TipoMuseo_id INT,                     /*ESTA PARTE ES DONDE SE DEFINEN LOS PARÁMETROS QUE SE VAN A RECIBIR*/		      /*NOTEN QUE AQUI SI SE RECIBE COMO PARÁMETRO LA LLAVE PRIMARIA (Estdiante_id)*/
								  @Museo_nombre VARCHAR(50),
								  @Museo_instalacion VARCHAR(50),
								  @Museo_estado VARCHAR(1)
AS
	BEGIN
		UPDATE TMuseo
		SET TipoMuseo_id = @TipoMuseo_id,
			Museo_nombre = @Museo_nombre,
			Museo_instalacion = @Museo_instalacion,
			Museo_estado = @Museo_estado
		WHERE Museo_id = @Museo_id
	END

GO
/****** Object:  StoredProcedure [dbo].[ModificarObra]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarObra] @Obra_id INT,
								  @Artista_id INT,                     /*ESTA PARTE ES DONDE SE DEFINEN LOS PARÁMETROS QUE SE VAN A RECIBIR*/
								  @Coleccion_id INT,
								  @TipoObra_id INT,
								  @Obra_nombre VARCHAR(50),
								  @Obra_descripcion VARCHAR(50),
								  @Obra_cultura VARCHAR(50),
								  @Obra_estado VARCHAR(1)
AS
	BEGIN
		UPDATE TObra
		SET Artista_id = @Artista_id,
			Coleccion_id = @Coleccion_id,
			TipoObra_id = @TipoObra_id,
			Obra_nombre = @Obra_nombre,
			Obra_descripcion = @Obra_descripcion,
			Obra_cultura = @Obra_cultura,
			Obra_estado = @Obra_estado
		WHERE Obra_id = @Obra_id
	END

GO
/****** Object:  StoredProcedure [dbo].[ModificarPrecio]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarPrecio] @Precio_id INT,
								  @Museo_id INT,                     /*ESTA PARTE ES DONDE SE DEFINEN LOS PARÁMETROS QUE SE VAN A RECIBIR*/
								  @Precio_modalidad VARCHAR(50),		      /*NOTEN QUE AQUI SI SE RECIBE COMO PARÁMETRO LA LLAVE PRIMARIA (Estdiante_id)*/
								  @Precio_monto VARCHAR(50),
								  @Precio_estado VARCHAR(1)
AS
	BEGIN
		UPDATE TPrecio
		SET Museo_id = @Museo_id,
			Precio_modalidad = @Precio_modalidad,
			Precio_monto = @Precio_monto,
			Precio_estado = @Precio_estado
		WHERE Precio_id = @Precio_id
	END

GO
/****** Object:  StoredProcedure [dbo].[ModificarTarjeta]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarTarjeta] @Tarjeta_id INT,
								  @Tarjeta_nombre VARCHAR(50),		      /*NOTEN QUE AQUI SI SE RECIBE COMO PARÁMETRO LA LLAVE PRIMARIA (Estdiante_id)*/
								  @Tarjeta_porcentaje VARCHAR(50),
								  @Tarjeta_estado VARCHAR(1)
AS
	BEGIN
		UPDATE TTarjeta
		SET 
			Tarjeta_nombre = @Tarjeta_nombre,
			Tarjeta_porcentaje = @Tarjeta_porcentaje,
			Tarjeta_estado = @Tarjeta_estado
		WHERE Tarjeta_id = @Tarjeta_id
	END

GO
/****** Object:  StoredProcedure [dbo].[ModificarTipoMuseo]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarTipoMuseo] @TipoMuseo_id INT,
								  @TipoMuseo_tipo VARCHAR(50),
								  @TipoMuseo_descripcion VARCHAR(50),
								  @TipoMuseo_estado VARCHAR(1)
AS
	BEGIN
		UPDATE TTipoMuseo
		SET 
			TipoMuseo_tipo = @TipoMuseo_tipo,
			TipoMuseo_descripcion = @TipoMuseo_descripcion,
			TipoMuseo_estado = @TipoMuseo_estado
		WHERE TipoMuseo_id = @TipoMuseo_id
	END

GO
/****** Object:  StoredProcedure [dbo].[ModificarTipoObra]    Script Date: 29/9/2019 10:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarTipoObra] @TipoObra_id INT,
								  @TipoObra_tipoObra VARCHAR(50),
								  @TipoObra_descripcion VARCHAR(50),
								  @TipoObra_estado VARCHAR(1)
AS
	BEGIN
		UPDATE TTipoObra
		SET 
			TipoObra_tipoObra = @TipoObra_tipoObra,
			TipoObra_descripcion = @TipoObra_descripcion,
			TipoObra_estado = @TipoObra_estado
		WHERE TipoObra_id = @TipoObra_id
	END

GO
