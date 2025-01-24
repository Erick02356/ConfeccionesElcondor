using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_AreaTrabajo
    {
        private CD_AreaTrabajo areaCD = new CD_AreaTrabajo();
        public DataTable MostraAreasTrabajo()
        {
            DataTable tabla = new DataTable();
            tabla = areaCD.MostrarAreaTrabajo();
            return tabla;
        }

    }
}
