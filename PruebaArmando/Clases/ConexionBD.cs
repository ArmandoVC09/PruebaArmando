using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Clases
{
    internal class ConexionBD
    {
        private static readonly Lazy<ConexionBD> lazyInstance = new Lazy<ConexionBD>(() => new ConexionBD());
        public static ConexionBD Instance { get { return lazyInstance.Value; } }

        private string cadenaConexion = "Data Source=DESKTOP-NFHJLJR\\SQLEXPRESS;Initial Catalog=pruebaArmando;Integrated Security=True;Trust Server Certificate = True;";

        public SqlConnection abrirConexion (){ 
            
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;

        }

        public void cerrarConexion(SqlConnection conexion) {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open) { 
                conexion.Close();
            
            }
        
        }

    }
}
