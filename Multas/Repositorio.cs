using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multas
{
    internal class Repositorio
    {
        /// <summary>
        /// Método para Obtener las multas
        /// </summary>
        /// <returns></returns>
        public static DataSet ObtenerMultas()
        {
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            try
            {
                comando.CommandText = "SELECT * FROM MULTAS";
                comando.Connection = conexion.cnx;
                adaptador.SelectCommand = comando;
                conexion.cnx.Open();
                adaptador.Fill(ds);
                conexion.cnx.Close();

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ds;
        }

        /// <summary>
        /// Método para crear una multa.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool CrearMulta(Multa c)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "INSERT INTO MULTAS VALUES ('" + c.dni + "', '" + c.importe + "', '" + c.observaciones + "', '" + c.nAgente + "', '" + c.fechaExp + "', '" + c.fechaLim + "')";

                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }

        /// <summary>
        /// Método para eliminar una multa.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool EliminarMulta(Multa c)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "DELETE FROM MULTAS WHERE ID = '" + c.Id + "'";

                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }

        /// <summary>
        /// Método para modificar una multa.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool ModificarMulta(Multa c)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "UPDATE MULTAS SET DNI = '" + c.dni + "', FECHACREACION= '" + c.fechaExp + "', FECHALIMITE = '" + c.fechaLim + "', OBSERVACIONES = '" + c.observaciones + "', NAGENTE= '" + c.nAgente + "', IMPORTE= '" + c.importe + "' " +
                    " WHERE ID = '" + c.Id + "'";

                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }
    }
}
