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
        public int id { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaEgreso { get; set; }
        public string placa { get; set; }
        public int idTipoVehiculo { get; set; }
        public double cobroTotal { get; set; }
        public TipoVehiculo tipoVehiculo { get; set; }

        public void guardarTicket()
        {
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = ConexionMySQL.AbrirBD();

            string sql = "Insert into ticket (fechaIngreso,placa,idTipoVehiculo) values (@fechaIngreso,@placa,@idTipoVehiculo); SELECT LAST_INSERT_ID();";
            ejecutarSQL.CommandText = sql;
            ejecutarSQL.Parameters.AddWithValue("@placa", placa);
            ejecutarSQL.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
            ejecutarSQL.Parameters.AddWithValue("@idTipoVehiculo", idTipoVehiculo);
            MySqlDataReader reader = ejecutarSQL.ExecuteReader();

            while (reader.Read())
            {
                this.id = reader.GetInt32(0);
            }
        }

        public void update() {
            try
            {
                MySqlCommand ejecutarSQL = new MySqlCommand();
                ejecutarSQL.Connection = ConexionMySQL.AbrirBD();

                string sql = "update ticket set fechaEgreso=@fechaEgreso, cobroTotal=@cobroTotal where id=@id";
                ejecutarSQL.CommandText = sql;
                ejecutarSQL.Parameters.AddWithValue("@fechaEgreso", fechaEgreso);
                ejecutarSQL.Parameters.AddWithValue("@cobroTotal", cobroTotal);
                ejecutarSQL.Parameters.AddWithValue("@id", id);
                MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al finalizar el ticket, inténtelo de nuevo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //verificar si ya hay un carro estacionado con esta placa
        public static bool existePlaca(string placa) {
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = ConexionMySQL.AbrirBD();
            string SQL = "select * from ticket where placa = @placa and fechaEgreso is NULL";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@placa", placa);
            MySqlDataReader result = ejecutarSQL.ExecuteReader();

            return result.HasRows;
        }

        public static Ticket getTicketById(string id)
        {
            try {
                Ticket ticket = new Ticket();
                int idTicket = Convert.ToInt32(id);
                MySqlCommand ejecutarSQL = new MySqlCommand();
                ejecutarSQL.Connection = ConexionMySQL.AbrirBD();
                string SQL = "select placa, fechaIngreso, idTipoVehiculo from ticket where id = @idTicket and fechaEgreso is NULL";
                ejecutarSQL.CommandText = SQL;
                ejecutarSQL.Parameters.AddWithValue("@idTicket", idTicket);
                MySqlDataReader result = ejecutarSQL.ExecuteReader();

                while (result.Read())
                {
                    ticket.placa = result.GetString(0) ?? "";
                    ticket.fechaIngreso = result.GetDateTime(1);
                    ticket.idTipoVehiculo = result.GetInt32(2);
                    ticket.id = idTicket;
                }

                return ticket;
            }catch(Exception ex)
            {
                return new Ticket();
            }
        }

        public TipoVehiculo getTipoVehiculo()
        {
            if(tipoVehiculo != null)
            {
                return this.tipoVehiculo;
            }

            if (this.tipoVehiculo == null && this.idTipoVehiculo != 0)
            {
                this.tipoVehiculo = TipoVehiculo.getTipoVehiculoById(this.idTipoVehiculo);
                return this.tipoVehiculo;
            }

            return new TipoVehiculo();
        }
    }
}
