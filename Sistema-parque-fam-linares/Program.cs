using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using Sistema_parque_fam_linares.Models;

namespace Sistema_parque_fam_linares
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            var client = new MongoClient("mongodb://local:local_pass@localhost:27017/?authSource=admin&readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var database = client.GetDatabase("multiservicios");
            var userDB = database.GetCollection<Usuario>("usuario");

            var usuario = new Usuario() { primerApellido = "Cuéllar", primerNombre = "Oscar", segundoApellido = "Mancilla", segundoNombre = "René" };
            // userDB.InsertOne(usuario);
            // List<Usuario> list = userDB.Find(d => true).ToList();
            // userDB.ReplaceOne(d => d.Id == "605784872b465f60acfe2b61", usuario);
            // userDB.DeleteOne(d=>d.Id == "605784872b465f60acfe2b61");
        }
    }
}
