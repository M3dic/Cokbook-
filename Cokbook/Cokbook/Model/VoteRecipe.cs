using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cokbook
{
    internal class VoteRecipe
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public VoteRecipe()
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
        /// Check if person has voted for this recipe
        /// </summary>
        /// <param name="chef"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        internal bool AlreadyVoted(string chef, string text)
        {
            string query = $"SELECT * FROM vote where alreadyvoted = '{chef}' and num = '{text}'";

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
        /// <summary>
        /// Voting positive for the recipe
        /// </summary>
        /// <param name="chef"></param>
        /// <param name="text"></param>
        internal void VotePositive(string chef, string text)
        {
            string query = $"INSERT INTO vote (num, good, alreadyvoted) VALUES('{text}', '1','{chef}')";

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
        /// <summary>
        /// Voting Negative for recipe
        /// </summary>
        /// <param name="chef"></param>
        /// <param name="text"></param>
        internal void VoteNegative(string chef, string text)
        {
            string query = $"INSERT INTO vote (num, bad, alreadyvoted) VALUES('{text}', '1','{chef}')";

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
        /// <summary>
        /// Check for positive votes
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        internal int Takepositivevotes(string text)
        {
            string query = $"SELECT Count(`good`) FROM vote where num = '{text}'";
            int Count = 0;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
        /// <summary>
        /// Take negative votes
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        internal int Takenegativevotes(string text)
        {
            string query = $"SELECT Count(`bad`) FROM vote where num = '{text}'";
            int Count = 0;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
    }
}
