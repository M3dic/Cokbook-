using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cokbook
{
    internal class Recipe
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public Recipe()
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
        /// <summary>
        /// This method is for openning connection to the DB
        /// </summary>
        /// <returns></returns>
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
        /// Checking if contains such chef
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
        /// <summary>
        /// Adding recipe into DB
        /// </summary>
        /// <param name="name"></param>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        /// <param name="forum"></param>
        internal void Addnewrecipe(string name, string text1, string text2, char forum)
        {
            string query = $"INSERT INTO recipe (name, topic, instructions, place) VALUES('{name}', '{text1}', '{text2}', '{forum}')";

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
        /// Closing connection
        /// </summary>
        /// <returns></returns>
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
        /// Updating recipe information
        /// </summary>
        /// <param name="name"></param>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        internal void UpdateRecipe(string name, string text1, string text2)
        {
            string query = $"UPDATE recipe SET instructions='{text2}' WHERE name='{name}' and topic='{text1}'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand
                {
                    //Assign the query using CommandText
                    CommandText = query,
                    //Assign the connection using Connection
                    Connection = connection
                };

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        /// <summary>
        /// Deleting recipe from the library
        /// </summary>
        /// <param name="name"></param>
        /// <param name="text1"></param>
        internal void Deleterecipe(string name, string text1)
        {
            string query = $"DELETE FROM recipe WHERE topic='{text1}' and name = '{name}'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        /// <summary>
        /// Place recipe on the top form
        /// </summary>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        /// <param name="date"></param>
        /// <param name="pictureBox2"></param>
        internal void Addadvertisementproduct(string text1, string text2, DateTime date, PictureBox pictureBox2)
        {
            string query = $"INSERT INTO toprecipes (topic, instructions, datetill, image) VALUES('{text1}', '{text2}', '{date.Date}', '{pictureBox2.Image}')";

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
