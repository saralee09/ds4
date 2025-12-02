CREATE DATABASE [SaraLee];
GO
USE [SaraLee];
GO

-- Catalogos
CREATE TABLE [dbo].[SL_Clientes] (
  [ClienteId] INT IDENTITY PRIMARY KEY,
  [Nombre] NVARCHAR(200) NOT NULL,
  [DocumentoIdentidad] NVARCHAR(50) NULL,
  [Email] NVARCHAR(200) NULL,
  [Telefono] NVARCHAR(50) NULL,
  [Direccion] NVARCHAR(300) NULL,
  [FechaRegistro] DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME()
);

CREATE TABLE [dbo].[SL_Abogados] (
  [AbogadoId] INT IDENTITY PRIMARY KEY,
  [Nombre] NVARCHAR(200) NOT NULL,
  [Email] NVARCHAR(200) NOT NULL,
  [Telefono] NVARCHAR(50) NULL,
  [Especialidad] NVARCHAR(150) NULL,
  [Activo] BIT NOT NULL DEFAULT 1
);

-- Casos
CREATE TABLE [dbo].[SL_Casos] (
  [CasoId] INT IDENTITY PRIMARY KEY,
  [Codigo] NVARCHAR(50) NOT NULL UNIQUE,
  [Titulo] NVARCHAR(250) NOT NULL,
  [Descripcion] NVARCHAR(MAX) NULL,
  [ClienteId] INT NOT NULL,
  [AbogadoAsignadoId] INT NULL,
  [Estado] NVARCHAR(30) NOT NULL, -- Nuevo, en curso y asi
  [FechaInicio] DATE NOT NULL,
  [FechaVencimiento] DATE NULL,
  [FechaCierre] DATE NULL,
  [Prioridad] NVARCHAR(20) NOT NULL DEFAULT 'Normal',
  [CreadoEn] DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
  [ActualizadoEn] DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
  CONSTRAINT FK_SL_Casos_Clientes FOREIGN KEY (ClienteId) REFERENCES [dbo].[SL_Clientes](ClienteId),
  CONSTRAINT FK_SL_Casos_Abogados FOREIGN KEY (AbogadoAsignadoId) REFERENCES [dbo].[SL_Abogados](AbogadoId)
);

-- Participantes
CREATE TABLE [dbo].[SL_CasoParticipantes] (
  [CasoParticipanteId] INT IDENTITY PRIMARY KEY,
  [CasoId] INT NOT NULL,
  [Nombre] NVARCHAR(200) NOT NULL,
  [Rol] NVARCHAR(100) NOT NULL,
  [Contacto] NVARCHAR(200) NULL,
  CONSTRAINT FK_SL_CasoParticipantes_Casos FOREIGN KEY (CasoId) REFERENCES [dbo].[SL_Casos](CasoId)
);

-- Documentos
CREATE TABLE [dbo].[SL_Documentos] (
  [DocumentoId] INT IDENTITY PRIMARY KEY,
  [CasoId] INT NOT NULL,
  [NombreArchivo] NVARCHAR(260) NOT NULL,
  [RutaFisica] NVARCHAR(500) NOT NULL,
  [Tipo] NVARCHAR(100) NULL,
  [Version] INT NOT NULL DEFAULT 1,
  [Notas] NVARCHAR(500) NULL,
  [FechaSubida] DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
  [SubidoPor] NVARCHAR(200) NULL,
  CONSTRAINT FK_SL_Documentos_Casos FOREIGN KEY (CasoId) REFERENCES [dbo].[SL_Casos](CasoId)
);

-- Tareas y plazos
CREATE TABLE [dbo].[SL_Tareas] (
  [TareaId] INT IDENTITY PRIMARY KEY,
  [CasoId] INT NOT NULL,
  [Titulo] NVARCHAR(250) NOT NULL,
  [Descripcion] NVARCHAR(MAX) NULL,
  [AsignadoAAbogadoId] INT NULL,
  [FechaLimite] DATE NOT NULL,
  [Estado] NVARCHAR(30) NOT NULL DEFAULT 'Pendiente',
  [Prioridad] NVARCHAR(20) NOT NULL DEFAULT 'Normal',
  [CreadoEn] DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
  [ActualizadoEn] DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
  CONSTRAINT FK_SL_Tareas_Casos FOREIGN KEY (CasoId) REFERENCES [dbo].[SL_Casos](CasoId),
  CONSTRAINT FK_SL_Tareas_Abogados FOREIGN KEY (AsignadoAAbogadoId) REFERENCES [dbo].[SL_Abogados](AbogadoId)
);

-- Audiencias/Reuniones
CREATE TABLE [dbo].[SL_Eventos] (
  [EventoId] INT IDENTITY PRIMARY KEY,
  [CasoId] INT NOT NULL,
  [Tipo] NVARCHAR(50) NOT NULL,
  [Titulo] NVARCHAR(250) NOT NULL,
  [Descripcion] NVARCHAR(MAX) NULL,
  [Ubicacion] NVARCHAR(200) NULL,
  [FechaInicio] DATETIME2 NOT NULL,
  [FechaFin] DATETIME2 NULL,
  [ResponsableAbogadoId] INT NULL,
  CONSTRAINT FK_SL_Eventos_Casos FOREIGN KEY (CasoId) REFERENCES [dbo].[SL_Casos](CasoId),
  CONSTRAINT FK_SL_Eventos_Abogados FOREIGN KEY (ResponsableAbogadoId) REFERENCES [dbo].[SL_Abogados](AbogadoId)
);

-- Alertas
CREATE TABLE [dbo].[SL_Alertas] (
  [AlertaId] INT IDENTITY PRIMARY KEY,
  [OrigenTipo] NVARCHAR(30) NOT NULL,
  [OrigenId] INT NOT NULL,
  [CasoId] INT NOT NULL,
  [Mensaje] NVARCHAR(300) NOT NULL,
  [FechaProgramada] DATETIME2 NOT NULL,
  [Enviada] BIT NOT NULL DEFAULT 0,
  [FechaEnvio] DATETIME2 NULL,
  [DestinoEmail] NVARCHAR(200) NOT NULL
);

-- Auditoria
CREATE TABLE [dbo].[SL_Auditoria] (
  [AuditoriaId] INT IDENTITY PRIMARY KEY,
  [Entidad] NVARCHAR(100) NOT NULL,
  [EntidadId] NVARCHAR(50) NOT NULL,
  [Accion] NVARCHAR(50) NOT NULL,
  [Usuario] NVARCHAR(200) NOT NULL,
  [Fecha] DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
  [Cambios] NVARCHAR(MAX) NULL
);

-- Indices
CREATE INDEX IX_SL_Casos_Estado_Fecha ON [dbo].[SL_Casos]([Estado],[FechaVencimiento]);
CREATE INDEX IX_SL_Tareas_Fecha ON [dbo].[SL_Tareas]([FechaLimite],[Estado]);
CREATE INDEX IX_SL_Eventos_Fecha ON [dbo].[SL_Eventos]([FechaInicio]);