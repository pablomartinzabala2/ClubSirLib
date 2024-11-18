using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace SistemaBase.Clases
{
    public class cSocio
    {
        public DataTable GetSocioxNroDoc(string NroDoc)
        {
            string sql = "select * from Socio ";
            sql = sql + " where NroDoc =" + "'" + NroDoc + "'";
            return cDb.GetDatatable(sql);
        }
    }
}
