using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CapaDatos
{
    public class CD_Empleados
    {
        private CD_conexion conexion = new CD_conexion();
        
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarEmpleado()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "cargarEmpleados";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion(); 
            return tabla;
        }

        public void AgregarEmpleado(int idTipoDocumento, string numeroDocumento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, int IdArea)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "AgregarEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idTipoDocumento", idTipoDocumento);
            comando.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
            comando.Parameters.AddWithValue("@PrimerNombre", primerNombre);
            comando.Parameters.AddWithValue("@SegundoNombre", segundoNombre);
            comando.Parameters.AddWithValue("@PrimerApellido", primerApellido);
            comando.Parameters.AddWithValue("@SegundoApellido", segundoApellido);
            comando.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
            comando.Parameters.AddWithValue("@IdArea", IdArea);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void EliminarEmpleado(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        
        public void EditarEmpleados(int idTipoDocumento, string numeroDocumento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, int IdArea, int IdEmpleado)
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EditarEmpleados";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idTipoDocumento", idTipoDocumento);
                comando.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
                comando.Parameters.AddWithValue("@PrimerNombre", primerNombre);
                comando.Parameters.AddWithValue("@SegundoNombre", segundoNombre);
                comando.Parameters.AddWithValue("@PrimerApellido", primerApellido);
                comando.Parameters.AddWithValue("@SegundoApellido", segundoApellido);
                comando.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                comando.Parameters.AddWithValue("@IdArea", IdArea);
                comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();

            }
    }
}
