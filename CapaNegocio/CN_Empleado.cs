using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Empleado
    {
        private CD_Empleados empleadoCD = new CD_Empleados();

        public DataTable MostrarEmpleado()
        {
            DataTable tabla = new DataTable();
            tabla = empleadoCD.MostrarEmpleado();
            return tabla;
        }

        public void AgregarEmpleado(int idTipoDocumento, string numeroDocumento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, int IdArea)
        {
            empleadoCD.AgregarEmpleado(Convert.ToInt32(idTipoDocumento),numeroDocumento,primerNombre,segundoNombre,primerApellido,segundoApellido, Convert.ToDateTime(fechaNacimiento),Convert.ToInt32(IdArea));
        }

        public void EliminarEmpleado(string id)
        {
            empleadoCD.EliminarEmpleado(Convert.ToInt32(id));
        }
        public void EditarEmpleado(int idTipoDocumento, string numeroDocumento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, int IdArea,string IdEmpleado)
        {
            empleadoCD.EditarEmpleados(Convert.ToInt32(idTipoDocumento), numeroDocumento, primerNombre, segundoNombre, primerApellido, segundoApellido, Convert.ToDateTime(fechaNacimiento), Convert.ToInt32(IdArea), Convert.ToInt32(IdEmpleado));
        }
    }
}
