using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBase.Clases
{
    public static class cConexion
    {
        public static string GetConexion()
        {
            //string cadena = SistemaFact.Properties.Settings.Default.JOYConnectionString1;
            //nueva cadena de conexion 
           // string cad = "Data Source=DESKTOP-PICJCLR\\SQLEXPRESS;Initial Catalog=ClubSirio;Integrated Security=True;Trust Server Certificate=True";
            string cad = "Data Source=DESKTOP-PICJCLR\\SQLEXPRESS;Initial Catalog=ClubSirio;Integrated Security=True;";
            // string cadena = "Data Source=DESKTOP-PICJCLR\\SQLEXPRESS;Initial Catalog=ClubSirio;Integrated Security=True;TrustServerCertificate=true";
            //DESKTOP-I0OF5F9\SQLEXPRESS
            //string cadena = "Data Source=DESKTOP-I0OF5F9\\SQLEXPRESS;Initial Catalog=JOY;Integrated Security=True";
            return cad;
        }
    }
}
