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
            string cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_sistema_peliculas.mdf;Integrated Security=True";
            miconeccion.ConnectionString = cadena;
            miconeccion.Open();
        }
        public DataSet obtener_datos()
        {
            //sera por cada tabla
            ds.Clear();
            micomando.Connection = miconeccion;
            micomando.CommandText = "Select * from clientes";
            miadaptador.SelectCommand = micomando;
            miadaptador.Fill(ds, "clientes");

            micomando.Connection = miconeccion;
            micomando.CommandText = "select clientes.nombre, FechaPrestamo, alquiler.FechaDevolucion,  alquiler.valor," +
               " alquiler.IdCliente from alquiler inner join clientes on(clientes.IdCliente=alquiler.IdCliente)";
            miadaptador.SelectCommand = micomando;
            miadaptador.Fill(ds, "alquiler_clientes");

            micomando.Connection = miconeccion;
            micomando.CommandText = "Select * from peliculas";
            miadaptador.SelectCommand = micomando;
            miadaptador.Fill(ds, "peliculas");

            micomando.Connection = miconeccion;
            micomando.CommandText = "select peliculas.descripcion, alquiler.FechaPrestamo, alquiler.FechaDevolucion,  alquiler.valor," +
                " alquiler.IdPelicula from alquiler inner join peliculas on(peliculas.IdPelicula=alquiler.IdPelicula)";
            miadaptador.SelectCommand = micomando;
            miadaptador.Fill(ds, "alquiler_peliculas");

            micomando.Connection = miconeccion;
            micomando.CommandText = "Select * from alquiler";
            miadaptador.SelectCommand = micomando;
            miadaptador.Fill(ds, "alquiler");

            micomando.Connection = miconeccion;
            micomando.CommandText = "select clientes.nombre, alquiler.FechaPrestamo, alquiler.FechaDevolucion,  alquiler.valor," +
           " peliculas.descripcion " + " from alquiler " +" inner join clientes on(clientes.IdCliente = alquiler.IdCliente)" +
           " inner join peliculas on(peliculas.IdPelicula = alquiler.IdPelicula)";
            miadaptador.SelectCommand = micomando;
            miadaptador.Fill(ds, "alquiler_clientes_peliculas");

            //alquiles desplegables
            return ds;
        }

        
        public void mantenmiento_datos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO clientes (nombre,direccion,telefono,dui) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'" +
                         ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE clientes SET " +
                      "nombre            = '" + datos[1] + "'," +
                      "direccion         = '" + datos[2] + "'," +
                      "telefono          = '" + datos[3] + "'," +
                      "dui               = '" + datos[4] + "'" +
                      "WHERE IdCliente   = '" + datos[0] + "'";
            }

            else if (accion == "eliminar")
            {
                sql = "DELETE clientes FROM clientes WHERE IdCliente='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }

        void procesarSQL(String sql)
        {
            micomando.Connection = miconeccion;
            micomando.CommandText = sql;
            micomando.ExecuteNonQuery();
        }
        //datos de peliculas
        public void mantenmiento_datos_peliculas(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO peliculas (descripcion,sinopsis,genero,duracion) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'" +
                         ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE peliculas SET " +
                      "descripcion            = '" + datos[1] + "'," +
                      "sinopsis               = '" + datos[2] + "'," +
                      "genero                 = '" + datos[3] + "'," +
                      "duracion               = '" + datos[4] + "'" +
                      "WHERE IdPelicula       = '" + datos[0] + "'";
            }

            else if (accion == "eliminar")
            {
                sql = "DELETE peliculas FROM peliculas WHERE IdPelicula='" + datos[0] + "'";
            }
            procesarpeliSQL(sql);
        }

        void procesarpeliSQL(String sql)
        {
            micomando.Connection = miconeccion;
            micomando.CommandText = sql;
            micomando.ExecuteNonQuery();
        }
        //datos de Alquiler
        public void mantenmiento_datos_alquiler(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO alquiler (IdCliente,IdPelicula,FechaPrestamo,FechaDevolucion,valor) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +

                    "'" + datos[5] + "'" +
                         ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE alquiler SET " +
                      "IdCliente           = '" + datos[1] + "'," +
                      "IdPelicula          = '" + datos[2] + "'," +
                      "FechaPrestamo       = '" + datos[3] + "'," +
                      "FechaDevolucion     = '" + datos[4] + "'," +
                      "valor               = '" + datos[5] + "'" +
                      "WHERE IdAlquiler    = '" + datos[0] + "'";
            }

            else if (accion == "eliminar")
            {
                sql = "DELETE alquiler FROM alquiler WHERE IdAlquiler='" + datos[0] + "'";
            }
            procesaralqSQL(sql);
        }

        void procesaralqSQL(String sql)
        {
            micomando.Connection = miconeccion;
            micomando.CommandText = sql;
            micomando.ExecuteNonQuery();
        }
    }
}
