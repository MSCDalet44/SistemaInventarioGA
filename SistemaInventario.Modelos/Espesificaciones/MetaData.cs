using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos.Espesificaciones
{
    public class MetaData
    {
        public int TotalPages { get; set; }//tatal de paginas de mi tabla productos
        public int PageSize { get; set; }
        public int TotalCount { get; set; }//Total de Registros de productos
    }
}
