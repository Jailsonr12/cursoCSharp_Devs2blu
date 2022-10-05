﻿using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data {
    public class ConnectionMySQL {

        public static String ConnectionString { get; set; }
        public static String Server { get; set; }
        public static String DataBase { get; set; }
        public static String User { get; set; }
        public static String Password { get; set; }
        public  static MySqlConnection GetConnection() {

            Server = "localhost";
            DataBase = "sistemacadrastro";
            User = "root";
            Password = "1234567890";
            ConnectionString = $"Persist Security Info=False;server={Server};database={DataBase};uid={User};server={Server};database={DataBase};uid={User};pwd='{Password}'";
            var conn = new MySqlConnection(ConnectionString);



            try {

                conn.Open();

            }
            catch (MySqlException myex) {

                MessageBox.Show(myex.Message, "Erro ao Connectar");

                throw;
            }
            return conn;
        }

        
    }
}
