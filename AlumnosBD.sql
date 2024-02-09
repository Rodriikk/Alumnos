CREATE DATABASE Alumnos
GO

USE [Alumnos]
GO

/****** Object:  Table [dbo].[alumnos]    Script Date: 09/02/2024 04:07:08 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[alumnos](
	[id_alumno] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NULL,
	[apellido] [varchar](30) NULL,
	[edad] [int] NULL,
	[dni] [bigint] NULL,
	[legajo] [int] NULL
) ON [PRIMARY]
GO