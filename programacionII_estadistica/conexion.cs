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
        //caro aqui hay algo
        //public conexion(SqlConnection miconeccion, SqlCommand micomando, SqlDataAdapter miadaptador, DataSet ds)
        //{
        //  this.miconeccion = miconeccion;
        // this.micomando = micomando;
        // this.miadaptador = miadaptador;
        //this.ds = ds;
        // }

        public conexion()
        {
            string cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Sistema.mdf;Integrated Security=True";
            miconeccion.ConnectionString = cadena;
            miconeccion.Open();
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

            micomando.Connection = miconeccion;
            micomando.CommandText = "Select * from Empleados";
            miadaptador.SelectCommand = micomando;
            miadaptador.Fill(ds, "Empleados");

            return ds;
        }


        //DATOS DE CLIENTES


        public void mantenmiento_datos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Clientes (Nombre_cliente, Direccion, Telefono, nfactura) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'" +
                         ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Clientes SET " +
                      "Nombre_cliente    = '" + datos[1] + "'," +
                      "Direccion         = '" + datos[2] + "'," +
                      "Telefono          = '" + datos[3] + "'," +
                      "nfactura          = '" + datos[4] + "'" +
                      "WHERE IdCliente   = '" + datos[0] + "'";
            }

            else if (accion == "eliminar")
            {
                sql = "DELETE Clientes FROM Clientes WHERE IdCliente='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }

        void procesarSQL(String sql)
        {
            micomando.Connection = miconeccion;
            micomando.CommandText = sql;
            micomando.ExecuteNonQuery();
        }


        //DATOS DE EMPLEADOS

        public void mantenimiento_datos_Empleado(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Empleados (Nombre_empleado, Telefono, Direccion) VALUES(" +
                         "'" + datos[1] + "'," +
                         "'" + datos[2] + "'," +
                         "'" + datos[3] + "'" +
                         ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Empleados SET " +
                        "Nombre_empleado   = '" + datos[1] + "'," +
                        "Telefono          = '" + datos[2] + "'," +
                        "Direccion         = '" + datos[3] + "'" +
                        "WHERE IdEmpleado  = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Empleados FROM Empleados WHERE IdEmpleado ='" + datos[0] + "'";
            }
            procesSQL(sql);
        }

        void procesSQL(String sql)
        {
            micomando.Connection = miconeccion;
            micomando.CommandText = sql;
            micomando.ExecuteNonQuery();
        }

        //DATOS DE PRODUCTOS

        public void mantenmiento_datos_Productos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Productos (Descripcion, IdDcProducto) VALUES(" +
                         "'" + datos[1] + "'," +
                         "'" + datos[2] + "'" +
                         ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Productos SET " +
                        "Descripcion        = '" + datos[1] + "'," +
                        "IdDcProducto      = '" + datos[2] + "'" +
                        "WHERE IdProductos  = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Productos FROM Productos WHERE IdProductos ='" + datos[0] + "'";
            }
            procesamientoSQL(sql);
        }

        void procesamientoSQL(String sql)
        {
            micomando.Connection = miconeccion;
            micomando.CommandText = sql;
            micomando.ExecuteNonQuery();
        }
    }
}

