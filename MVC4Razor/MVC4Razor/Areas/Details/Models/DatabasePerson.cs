using System.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DatabasePerson.Models
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "test";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "Server=" + server + ";" + "Database=" +
            database + ";" + "User=" + uid + ";" + "Password=" + password + ";";

            //connectionString="Driver={MySQL ODBC 5.1 Driver}; Server=localhost; Database=mysql; User=root; Password=admin; Option=3;"

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            //connection.Ping();
            
            connection.Open();
            return true;
        }

        //Close connection
        private bool CloseConnection()
        {
            connection.Close();
            return true;
        }
        public List<Person> select()
        {
            List<Person>list = new List<Person>();
            
            if (OpenConnection())
            {
                String query = "SELECT * FROM personinfo";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                
                while (dataReader.Read())
                {
                    Person person = new Person();
  
                    person.ID = int.Parse(dataReader["ID"].ToString());
                    person.Name = dataReader["Name"].ToString();
                    person.Country = dataReader["Country"].ToString();

                    list.Add(person);
                    
                }
                CloseConnection();
            }
            return list;
        }
        //Insert statement
        public bool Insert(int ID, string PlayerName,string Country)
        {
            try 
            {
                if (OpenConnection())
                {
                    String query = "insert into personinfo (ID,Name,Country) values(" + ID +",'"+PlayerName +"','"+ Country+"')";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    if (command.ExecuteNonQuery() == -1)
                    {
                        CloseConnection();
                        return false;
                    }
                    CloseConnection();
                    return true;
                }
            }
            catch { }

            CloseConnection();
            return false;
        }

        ////Update statement
        //public void Update()
        //{
        //}

        ////Delete statement
        //public void Delete()
        //{
        //}
       
    }
    public class Person
    {
        public int ID { get; set; }
        public string  Name { get; set; }
        public string Country { get; set; }
    }
}