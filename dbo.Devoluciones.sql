CREATE TABLE [dbo].[Devoluciones] (
    [IdProductosDv]  INT        IDENTITY (1, 1) NOT NULL,
    [Descripcion]    CHAR (100) NULL,
    [Unidades]       CHAR (500) NULL,
    [PrecioUnitario] CHAR (10)  NULL,
    [Reembolso ]     CHAR (50)  NULL,
    [Nombre_Cliente] CHAR (65)  NULL,
    [IdDcProductos] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([IdProductosDv] ASC)
);

