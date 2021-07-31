using KonusarakOgren.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace dotnetcoreapi.Controllers
{
    public class sqlqueries
    {/*
        private SqliteConnection connection; 
        private List<CreateModel> create = new List<CreateModel>();
        private void Setconnection()
        {
            connection = new SqliteConnection("" + new SqliteConnectionStringBuilder { DataSource = "hello.db" });
        }

        public List<CreateModel> Getall()
        {
            Setconnection();
            connection.Open();
            using (var transaction = connection.BeginTransaction())
            {
                var selectCommand = connection.CreateCommand();
                selectCommand.Transaction = transaction;
                selectCommand.CommandText = "SELECT * FROM kisi";
                using (
                var reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        create.Add(new CreateModel()
                        {
                            baslik = reader.GetString(0),
                            yazi = reader.GetString(1),
                            //Sorular = reader.GetString(2)

                        });
                    }
                }
                transaction.Commit();

                connection.Close();
                return create;

            }
        }
        */
        public static void Sqlitebaglanti()
        {
            using (var connection = new SqliteConnection("" +
                    new SqliteConnectionStringBuilder
                    {
                        DataSource = "hello.db"
                    }))
                    {
                connection.Open();


                using (var transaction = connection.BeginTransaction())
                {
                    var insertCommand = connection.CreateCommand();
                    insertCommand.Transaction = transaction;
                    //insertCommand.CommandText = "ALTER TABLE message ADD Email varchar(255); ";
                    //insertCommand.CommandText = "INSERT INTO message ( id ) VALUES ( $id )";
                    insertCommand.Parameters.AddWithValue("$baslik", "Hello, World!");
                    insertCommand.Parameters.AddWithValue("$yazi", "10");
                    insertCommand.ExecuteNonQuery();

                    var selectCommand = connection.CreateCommand();
                    selectCommand.Transaction = transaction;
                    selectCommand.CommandText = "SELECT baslik,yazi FROM CreateModel";
                    using (var reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("{0}\t{1}", reader.GetString(0),
                            reader.GetString(1));

                        }
                    }
                    transaction.Commit();
                }
            }
        }

    }
}

