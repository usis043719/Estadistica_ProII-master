CREATE TABLE [dbo].[Factura] (
    [nfactura]           INT             IDENTITY (1, 1) NOT NULL,
    [IdCliente]          INT             NOT NULL,
    [IdProductosDv]      INT             NOT NULL,
    [fecha_de_venta]     DATE            NOT NULL,
    [Descripcion]        CHAR (100)      NOT NULL,
    [nombre_del_cliente] CHAR (50)       NOT NULL,
    [Unidades]           INT             NOT NULL,
    [precioUnitario]     CHAR (10)       NOT NULL,
    [pago]               DECIMAL (10, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([nfactura] ASC),
    CONSTRAINT [FK_Factura_Clientes] FOREIGN KEY ([IdCliente]) REFERENCES [dbo].[Clientes] ([IdCliente]),
);

