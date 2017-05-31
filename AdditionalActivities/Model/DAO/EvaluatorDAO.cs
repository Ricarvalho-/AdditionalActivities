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
            throw new NotImplementedException();
        }

        public List<Evaluator> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Evaluator> GetByParentID(int id)
        {
            throw new NotImplementedException();
        }

        public Evaluator Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Evaluator obj)
        {
            MySqlConnection connection = DatabaseManager.Instance.Connection;
            string cmdText = obj.Id.HasValue ?
                "update evaluator set name = @name where id = @id;" :
                "insert into evaluator (name) values (@name);";
            //params
            MySqlCommand command = new MySqlCommand(cmdText, connection);

            try
            {
                //open, execute, update id (if needed)
            }
            catch (MySqlException e)
            {
                throw new DAOException(e.Message);
            }
            finally
            {
                //close
            }
        }
    }
}
