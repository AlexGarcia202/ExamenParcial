using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal class CDConexion
    {
        public class CDconexion
        {
            private SqlConnection db_conexion = new SqlConnection("Data Source=DESKTOP-1A09MOT\\SQLEXPRESS;Initial Catalog=Restaurante_Delicias;Integrated Security=True;Encrypt=False");

            public SqlConnection MtdAbrirConexion()
            {
                if (db_conexion.State == ConnectionState.Closed)
                {
                    db_conexion.Open();
                }
                return db_conexion;
            }


            public SqlConnection MtdCerrarConexion()
            {
                if (db_conexion.State == ConnectionState.Open)
                {
                    db_conexion.Close();
                }
                return db_conexion;
            }

        }



    }
}
