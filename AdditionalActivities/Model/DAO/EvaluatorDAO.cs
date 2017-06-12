using AdditionalActivities.Model.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.DAO
{
    class EvaluatorDAO
    {
        public void Delete(string obj)
        {
            MySqlConnection connection = DatabaseManager.Instance.Connection;

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand command = new MySqlCommand("delete from evaluator where id=@id;", connection);
                command.Parameters.AddWithValue("@id", obj);

                command.ExecuteNonQuery();

                obj = null;
            }
            catch (Exception e)
            {
                throw new DAOException(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<string> GetAll()
        {
            List<string> list = new List<string>();

            MySqlConnection connection = DatabaseManager.Instance.Connection;

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand command = new MySqlCommand("select * from evaluator;", connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string ev = reader.GetString("id");

                    list.Add(ev);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                throw new DAOException(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public List<string> GetByParentID(int id)
        {
            return new List<string>();
        }

        public string Read(int id)
        {
            string ev = "";

            MySqlConnection connection = DatabaseManager.Instance.Connection;

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand command = new MySqlCommand("select * from evaluator where id=@id;", connection);
                command.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ev = reader.GetString("id");
                }
                else
                {
                    throw new DAOException("Query returned 0 rows.");
                }
                reader.Close();
            }
            catch (Exception e)
            {
                throw new DAOException(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return ev;
        }

        public void Save(string obj)
        {
            MySqlConnection connection = DatabaseManager.Instance.Connection;
            MySqlCommand command;

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                if (obj != "")
                {
                    command = new MySqlCommand("update evaluator set id = @id where id = @id;", connection);
                    command.Parameters.AddWithValue("@id", obj);
                }
                else
                {
                    command = new MySqlCommand("insert into evaluator (id) values (@id);", connection);
                    command.Parameters.AddWithValue("@id", obj);
                }

                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw new DAOException(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
