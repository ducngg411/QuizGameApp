﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QuizGameApp
{
    public class DBConnect
    {
        // create connection

        MySqlConnection connect = new MySqlConnection
            ("datasource=localhost;port=3306;username=root;password=;database=gamenew2024");

        // get connection

        public MySqlConnection getConnection 
        {
            get
            {
                return connect;
            }
        }

        // open connection

        public void openConnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
        }

        // close connection 

        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
        }
    }
}
