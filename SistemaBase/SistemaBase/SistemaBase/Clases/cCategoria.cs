using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaBase.Clases
{
    public class cCategoria
    {
        public DataTable GetCategoria()
        {
            string sql = "select * from Categoria ";
            sql = sql + " order by Nombre ";
            return cDb.GetDatatable(sql); 
        } 
    }
}
