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
            micomando.CommandText = "Select * from peliculas";
            miadaptador.SelectCommand = micomando;
            miadaptador.Fill(ds, "peliculas");

            return ds;
        }

        //datos de los clientes
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
    }
}
