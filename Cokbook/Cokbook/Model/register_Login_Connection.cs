using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cokbook
{
    internal class Register_Login_Connection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public Register_Login_Connection()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "35.224.20.143";
            database = "cokbook";
            uid = "cokbook";
            password = "cokbook";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        /// <summary>
        /// checking if there is such chef
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        internal bool CheckChefName(string name)
        {
            string query = $"SELECT chef FROM chefs where chef = '{name}'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();
                    return true;
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
                return false;
            }
            else
            {
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Getting login details
        /// </summary>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        /// <returns></returns>
        internal List<string> CheckLoginDetails(string text1, string text2)
        {
            string query = $"SELECT * FROM chefs where chef = '{text1}' and password = '{text2}'";
            //Create a list to store the result
            List<string> list = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                if (dataReader.Read())
                {
                    list.Add(dataReader["age"] + "");
                    list.Add(dataReader["gender"] + "");
                    list.Add(dataReader["email"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
        /// <summary>
        /// Registering new chefs
        /// </summary>
        /// <param name="chef"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public void InsertNewChef(string chef, string age, string gender, string email, string password)
        {
            string query = $"INSERT INTO chefs (chef, password, age, gender, email) VALUES('{chef}', '{password}', '{age}', '{gender}', '{email}')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
    }
}
