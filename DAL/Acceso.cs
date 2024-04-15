using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Acceso
    {
        private static SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-BEA1EQV\\SQLEXPRESS;Initial Catalog=ProyectoIS;Integrated Security=True");
        private static SqlCommand _command;
        private static SqlTransaction _transaction;

        public static DataTable ExecuteDataTable(string query)
        {
            DataTable table = new DataTable();

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State != ConnectionState.Closed) _connection.Close();
            }

            return table;
        }

        public static bool ExecuteNonQuery(string query)
        {
            try
            {
                _connection.Open();
                _transaction = _connection.BeginTransaction();
                _command = new SqlCommand(query, _connection);

                _command.CommandType = CommandType.Text;
                _command.Transaction = _transaction;
                _command.ExecuteNonQuery();

                _transaction.Commit();

                return true;
            }
            catch (Exception ex)
            {
                _transaction.Rollback();
                throw ex;
            }
            finally
            {
                if(_connection.State != ConnectionState.Closed) _connection.Close();
            }
        }

        public static int ExecuteScalar(string query)
        {
            try
            {
                _connection.Open();
                _command = new SqlCommand(query, _connection);
                _command.CommandType = CommandType.Text;

                int result = Convert.ToInt32(_command.ExecuteScalar());
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State != ConnectionState.Closed) _connection.Close();
            }
        }
    }
}
