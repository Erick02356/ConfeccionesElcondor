using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_TipoDocumento
    {
        private CD_TipoDocumento tipoDocumentoCD = new CD_TipoDocumento();
        public DataTable MostrarTipoDocumento()
        {
            DataTable tabla = new DataTable();
            tabla = tipoDocumentoCD.MostrarTipoDocumento();
            return tabla;
        }
    }
}
