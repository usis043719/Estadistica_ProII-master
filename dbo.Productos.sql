CREATE TABLE [dbo].[Productos] (
    [IdProductos]   INT         IDENTITY (1, 1) NOT NULL,
    [Descripcion]   NCHAR (100) NOT NULL,
    [IdDcProductos] INT         NOT NULL,
    [IdNum_orden]   INT         NOT NULL,
    [IdCategoria]   INT         NOT NULL,
    [Marca]         CHAR (45)   NOT NULL,
    PRIMARY KEY CLUSTERED ([IdProductos] ASC),
	CONSTRAINT [FK_Productos_Categoria] FOREIGN KEY ([IdCategoria]) REFERENCES [dbo].[Categoria] ([IdCategoria]),
    CONSTRAINT [FK_Productos_Descuento] FOREIGN KEY ([IdDcProductos]) REFERENCES [dbo].[Descuento] ([IdDcProductos]),
    CONSTRAINT [FK_Productos_Ordenes] FOREIGN KEY ([IdNum_orden]) REFERENCES [dbo].[Ordenes] ([IdNum_orden])
);

