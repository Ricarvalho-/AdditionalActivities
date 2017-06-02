using AdditionalActivities.Model.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.DAO
{
    class EvaluatorDAO : IDAO<Evaluator>
    {
        public void Delete(Evaluator obj)
        {
            MySqlConnection connection = DatabaseManager.Instance.Connection;

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand command = new MySqlCommand("delete from evaluator where id=@id;", connection);
                command.Parameters.AddWithValue("@id", obj.Id.Value);

                command.ExecuteNonQuery();

                obj.Id = null;
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

        public List<Evaluator> GetAll()
        {
            List<Evaluator> list = new List<Evaluator>();

            MySqlConnection connection = DatabaseManager.Instance.Connection;

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand command = new MySqlCommand("select * from evaluator;", connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Evaluator ev = new Evaluator();

                    ev.Id = reader.GetInt32("id");
                    ev.Name = reader.GetString("name");

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

        public List<Evaluator> GetByParentID(int id)
        {
            return new List<Evaluator>();
        }

        public Evaluator Read(int id)
        {
            Evaluator ev = new Evaluator();

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
                    ev.Id = reader.GetInt32("id");
                    ev.Name = reader.GetString("name");
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

        public void Save(Evaluator obj)
        {
            MySqlConnection connection = DatabaseManager.Instance.Connection;
            MySqlCommand command;

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                if (obj.Id.HasValue)
                {
                    command = new MySqlCommand("update evaluator set name = @name where id = @id;", connection);
                    command.Parameters.AddWithValue("@id", obj.Id.Value);
                    command.Parameters.AddWithValue("@name", obj.Name);
                }
                else
                {
                    command = new MySqlCommand("insert into evaluator (name) values (@name);", connection);
                    command.Parameters.AddWithValue("@name", obj.Name);
                }

                command.ExecuteNonQuery();

                obj.Id = obj.Id.HasValue ? obj.Id : (int)command.LastInsertedId;
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
