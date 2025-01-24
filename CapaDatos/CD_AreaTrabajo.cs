using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_AreaTrabajo
    {
        private CD_conexion conexion = new CD_conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarAreaTrabajo()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarAreas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
