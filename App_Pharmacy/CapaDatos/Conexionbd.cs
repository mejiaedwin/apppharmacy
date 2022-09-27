using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace App_Pharmacy.CapaDatos
{
    public class Conexionbd
    {
        private SqlConnection Conexion = new 
            SqlConnection("server=EDWIN\\ENTORNO; database=Pharmacy; integrated security = true");

        public SqlConnection Openconnetion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Close();
            return Conexion;
        }
        public SqlConnection CloseConnection()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

 
    }
}
