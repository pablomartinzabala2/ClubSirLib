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

        public Int32 GetMaxSocio()
        {
            Int32 CodSocio = 0;
            string sql = "select max(CodSocio) as CodSocio from Socio ";
            DataTable trdo = cDb.GetDatatable(sql);
            if (trdo.Rows.Count >0)
            {
                CodSocio = Convert.ToInt32(trdo.Rows[0]["CodSocio"]);
            }
            return CodSocio;
        }

        public DataTable GetSocioxCategoria(int CodCategoria)
        {
            string sql = "select CodSocio,Nombre,Apellido,NroDoc ";
            sql = sql + " from Socio s";
            sql = sql + " where CodCategoria=" + CodCategoria.ToString();
            return cDb.GetDatatable(sql);
        }
    }
}
