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
    public class Ticket
    {

        public DateTime fechaIngreso { get; set; }
        public DateTime fechaEgreso { get; set; }
        public string placa { get; set; }
        public string tipoVehiculo { get; set; }
        public double cobroTotal { get; set; }

        public void guardarTicket()
        {
            try
            {
                MySqlCommand ejecutarSQL = new MySqlCommand();
                ejecutarSQL.Connection = ConexionMySQL.AbrirBD();

                string sql = "Insert into ticket (fechaIngreso,placa,tipoVehiculo) values (@fechaIngreso,@placa,@tipoVehiculo)";
                ejecutarSQL.CommandText = sql;
                ejecutarSQL.Parameters.AddWithValue("@placa", placa);
                ejecutarSQL.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
                ejecutarSQL.Parameters.AddWithValue("@tipoVehiculo", tipoVehiculo);
                MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el ticket, inténtelo de nuevo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //verificar si ya hay un carro estacionado con esta placa
        public static bool existePlaca(string placa) {
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = ConexionMySQL.AbrirBD();
            string SQL = "select * from ticket where placa = @placa and fechaEgreso = NULL";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@placa", placa);
            MySqlDataReader result = ejecutarSQL.ExecuteReader();

            return result.HasRows;
        }
    }
}
