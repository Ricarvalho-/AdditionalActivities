using AdditionalActivities.Model.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.DAO
{
    class ActivityCategoryDAO : IDAO<ActivityCategory>
    {
        public void Delete(ActivityCategory obj)
        {
            MySqlConnection connection = DatabaseManager.Instance.Connection;

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand command = new MySqlCommand("delete from category where id=@id;", connection);
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

        public List<ActivityCategory> GetAll()
        {
            List<ActivityCategory> list = new List<ActivityCategory>();

            MySqlConnection connection = DatabaseManager.Instance.Connection;

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand command = new MySqlCommand("select * from category;", connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ActivityCategory cat = new ActivityCategory();

                    cat.Id = reader.GetInt32("id");
                    cat.Name = reader.GetString("name");

                    list.Add(cat);
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

        public List<ActivityCategory> GetByParentID(int id)
        {
            return new List<ActivityCategory>();
        }

        public ActivityCategory Read(int id)
        {
            ActivityCategory cat = new ActivityCategory();

            MySqlConnection connection = DatabaseManager.Instance.Connection;

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                MySqlCommand command = new MySqlCommand("select * from category where id=@id;", connection);
                command.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    cat.Id = reader.GetInt32("id");
                    cat.Name = reader.GetString("name");
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
            return cat;
        }

        public void Save(ActivityCategory obj)
        {
            MySqlConnection connection = DatabaseManager.Instance.Connection;
            MySqlCommand command;

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                if (obj.Id.HasValue)
                {
                    command = new MySqlCommand("update category set name = @name where id = @id;", connection);
                    command.Parameters.AddWithValue("@id", obj.Id.Value);
                    command.Parameters.AddWithValue("@name", obj.Name);
                }
                else
                {
                    command = new MySqlCommand("insert into category (name) values (@name);", connection);
                    command.Parameters.AddWithValue("@name", obj.Name);
                }

                command.ExecuteNonQuery();

                obj.Id = obj.Id.HasValue ? obj.Id : (int)command.LastInsertedId;
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
    }
}
