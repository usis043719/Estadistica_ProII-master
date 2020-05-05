using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace programacionII_estadistica
{
    class conexion
    {
        SqlConnection miconeccion = new SqlConnection();
        SqlCommand micomando = new SqlCommand();
        SqlDataAdapter miadaptador = new SqlDataAdapter();

        DataSet ds = new DataSet();
       

        public conexion()
        {
            string cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Sistema.mdf;Integrated Security=True";
            miconeccion.ConnectionString = cadena;
            miconeccion.Open();
        
        //inicializar los parametros que se van en las consultas
        parametrizacion();
    }
    private void parametrizacion()
    {
        micomando.Parameters.Add("@Id", SqlDbType.Int).Value = 0;
        micomando.Parameters.Add("@IdC", SqlDbType.Int).Value = 0;
        micomando.Parameters.Add("@IdI", SqlDbType.Int).Value = 0;
        micomando.Parameters.Add("@IdD", SqlDbType.Int).Value = 0;
        micomando.Parameters.Add("@IdN", SqlDbType.Int).Value = 0;

        micomando.Parameters.Add("@Nom", SqlDbType.Char).Value = "";
        micomando.Parameters.Add("@Dir", SqlDbType.Char).Value = "";
        micomando.Parameters.Add("@Tel", SqlDbType.Char).Value = "";

        micomando.Parameters.Add("@Des", SqlDbType.Char).Value = "";
     
        micomando.Parameters.Add("@Mar", SqlDbType.Char).Value = "";

        micomando.Parameters.Add("@Emp", SqlDbType.Char).Value = "";

        micomando.Parameters.Add("@Car", SqlDbType.Char).Value = "";

        micomando.Parameters.Add("@Cat", SqlDbType.Char).Value = "";

        }
        public DataSet obtener_datos()
        {
            //sera por cada tabla
            ds.Clear();
            micomando.Connection = miconeccion;

            micomando.CommandText = "Select * from Clientes";
            miadaptador.SelectCommand = micomando;
            miadaptador.Fill(ds, "Clientes");

            micomando.Connection = miconeccion;
            micomando.CommandText = "Select * from Productos";
            miadaptador.SelectCommand = micomando;
            miadaptador.Fill(ds, "Productos");

            micomando.CommandText = "select Categoria.Categoria, Productos.IdProductos,Productos.Descripcion, Productos.Marca," +
            " Productos.IdCategoria from Productos inner join Categoria on(Categoria.IdCategoria=Productos.IdCategoria)";
            miadaptador.SelectCommand = micomando;
            miadaptador.Fill(ds, "Productos_Categoria");

            micomando.CommandText = "Select Cargo.Cargo, Empleados.IdEmpleado,Empleados.Nombre_empleado, Empleados.Telefono, Empleados.Direccion," +
            " Empleados.IdCargo from Empleados inner join Cargo on(Cargo.IdCargo=Empleados.IdCargo)";
            miadaptador.SelectCommand = micomando;
            miadaptador.Fill(ds, "Empleados_Cargo");

            micomando.Connection = miconeccion;
            micomando.CommandText = "Select * from Empleados";
            miadaptador.SelectCommand = micomando;
            miadaptador.Fill(ds, "Empleados");

            micomando.Connection = miconeccion;
            micomando.CommandText = "Select * from Proveedor";
            miadaptador.SelectCommand = micomando;
            miadaptador.Fill(ds, "Proveedor");

            micomando.Connection = miconeccion;
            micomando.CommandText = "Select * from Inventario";
            miadaptador.SelectCommand = micomando;
            miadaptador.Fill(ds, "Inventario");

            micomando.Connection = miconeccion;
            micomando.CommandText = "select * from Categoria";
            miadaptador.SelectCommand = micomando;
            miadaptador.Fill(ds, "Categoria");

            micomando.Connection = miconeccion;
            micomando.CommandText = "select * from Cargo";
            miadaptador.SelectCommand = micomando;
            miadaptador.Fill(ds, "Cargo");

            micomando.Connection = miconeccion;
            micomando.CommandText = "Select * from Ordenes";
            miadaptador.SelectCommand = micomando;
            miadaptador.Fill(ds, "Ordenes");

            micomando.Connection = miconeccion;
            micomando.CommandText = "Select * from Descuento";
            miadaptador.SelectCommand = micomando;
            miadaptador.Fill(ds, "Descuento");

            return ds;
        }

        //DATOS DE CLIENTES
        public void mantenmiento_datos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Clientes (Nombre_cliente, Direccion, Telefono) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'" +
                         ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Clientes SET " +
                      "Nombre_cliente    = '" + datos[1] + "'," +
                      "Direccion         = '" + datos[2] + "'," +
                      "Telefono          = '" + datos[3] + "'" +
                      "WHERE IdCliente   = '" + datos[0] + "'";
            }

            else if (accion == "eliminar")
            {
                sql = "DELETE Clientes FROM Clientes WHERE IdCliente='" + datos[0] + "'";
            }
            procesarSQL(sql);
        
        }
       
        //DATOS DE EMPLEADOS

        public void mantenimiento_datos_Empleado(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Empleados (Nombre_empleado,Telefono,Direccion,IdCargo) VALUES(@Nom,@Tel,@Dir,@IdC)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Empleados SET " +

                    "Nombre_empleado      = @Nom," +
                    "Telefono             = @Tel," +
                    "Direccion            = @Dir," +
                    "IdCargo              = @IdC " +
                    "WHERE IdEmpleado = @Id";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Empleados FROM Empleados WHERE IdEmpleado=@Id";
            }
            micomando.Parameters["@Id"].Value = datos[0];
            if (accion != "eliminar")
            {
                micomando.Parameters["@Nom"].Value = datos[1];
                micomando.Parameters["@Tel"].Value = datos[2];
                micomando.Parameters["@Dir"].Value = datos[3];
                micomando.Parameters["@IdC"].Value = datos[4];
            }
            procesarSQL(sql);
        }
       

        //DATOS DE PRODUCTOS

        public void mantenmiento_datos_Productos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Productos (Descripcion, IdDcProductos, IdNum_orden, IdCategoria, Marca) VALUES(@Des,@IdD,@IdN,@IdC,@Mar)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Productos SET " +

                    "Descripcion          = @Des," +
                    "IdDcProductos        = @IdD," +
                    "IdNum_orden          = @IdN," +
                    "IdCategoria          = @IdC," +
                    "Marca                = @Mar " +
                    "WHERE IdProductos = @Id";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Productos FROM Productos WHERE IdProductos=@Id";
            }
            micomando.Parameters["@Id"].Value = datos[0];
            if (accion != "eliminar")
            {
                micomando.Parameters["@Des"].Value = datos[1];
                micomando.Parameters["@IdD"].Value = datos[2];
                micomando.Parameters["@IdN"].Value = datos[3];
                micomando.Parameters["@IdC"].Value = datos[4];
                micomando.Parameters["@Mar"].Value = datos[5];

            }
            procesarSQL(sql);
        }

        //DATOS DE PROVEEDORES

        public void mantenimiento_datos_proveedor(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Proveedor (Direccion, Telefono, IdInventario, Nombre_del_proveedor, Empresa) VALUES(" +
                         "'" + datos[1] + "'," +
                         "'" + datos[2] + "'," +
                         "'" + datos[3] + "'," +
                         "'" + datos[4] + "'," +
                         "'" + datos[5] + "'" +

                         ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Proveedor SET " +
                        "Direccion               = '" + datos[1] + "'," +
                        "Telefono                = '" + datos[2] + "'," +
                        "IdInventario            = '" + datos[3] + "'," +
                        "Nombre_del_proveedor    = '" + datos[4] + "'," +
                        "Empresa                = '" + datos[5] + "'" +
                        "WHERE IdProveedor       = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Proveedor FROM Proveedor WHERE IdProveedor ='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }


        //DATOS DE CARGO

        public void mantenimiento_datos_cargo(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Cargo (Cargo) VALUES(" +
                    "'" + datos[1] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Cargo SET " +

                    "Cargo          = '" + datos[1] + "'" +
                    "WHERE IdCargo  = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Cargo FROM Cargo WHERE IdCargo='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }
       
        //DATOS DE CATEGORIA

        public void mantenimiento_datos_Categoria(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Categoria (Categoria) VALUES(" +
                    "'" + datos[1] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Categoria SET " +

                    "Categoria            = '" + datos[1] + "'" +
                    "WHERE IdCategoria    = '" + datos[0] + "'";

            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Categoria FROM Categoria WHERE IdCategoria ='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }
        void procesarSQL(String sql)
        {
            micomando.Connection = miconeccion;
            micomando.CommandText = sql;
            micomando.ExecuteNonQuery();
        }
    }
}



