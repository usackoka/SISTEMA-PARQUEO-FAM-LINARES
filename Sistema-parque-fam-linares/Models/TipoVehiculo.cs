using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sistema_parque_fam_linares.DB;

namespace Sistema_parque_fam_linares.Models
{
    public class TipoVehiculo
    {
        public string nombre { get; set; }
        public int costoPorHora { get; set; }
        public int costoPorDia { get; set; }
        public int costoPorMes { get; set; }

        public static TipoVehiculo getTipoVehiculoById(int idTipo)
        {
            try
            {
                TipoVehiculo tipoV = new TipoVehiculo();
                MySqlCommand ejecutarSQL = new MySqlCommand();
                ejecutarSQL.Connection = ConexionMySQL.AbrirBD();
                string SQL = "select nombre, costoPorHora, costoPorDia, costoPorMes from tipoVehiculo where id = @idTipo";
                ejecutarSQL.CommandText = SQL;
                ejecutarSQL.Parameters.AddWithValue("@idTipo", idTipo);
                MySqlDataReader result = ejecutarSQL.ExecuteReader();

                while (result.Read())
                {
                    tipoV.nombre = result.GetString(0);
                    tipoV.costoPorHora = result.GetInt32(1);
                    tipoV.costoPorDia = result.GetInt32(2);
                    tipoV.costoPorMes = result.GetInt32(3);
                }
                
                ConexionMySQL.cerrarBD();

                return tipoV;
            }
            catch (Exception ex)
            {
                return new TipoVehiculo();
            }
        }
    }
}
