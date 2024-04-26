using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Acceso
    {
        private static SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ProyectoIS"].ConnectionString);
        private static SqlCommand _command;
        private static SqlTransaction _transaction;

        public static DataTable ExecuteDataTable(string query, Hashtable parametros)
        {
            DataTable table = new DataTable();

            try
            {
                _command = new SqlCommand(query, _connection);

                if (parametros != null)
                {
                    foreach (string param in parametros.Keys)
                    {
                        _command.Parameters.AddWithValue(param, parametros[param]);
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(_command);
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

        public static bool ExecuteNonQuery(string query, Hashtable parametros)
        {
            try
            {
                _connection.Open();

                _transaction = _connection.BeginTransaction();
                
                _command = new SqlCommand(query, _connection);
                _command.CommandType = CommandType.Text;
                _command.Transaction = _transaction;

                if (parametros != null)
                {
                    foreach (string param in parametros.Keys)
                    {
                        _command.Parameters.AddWithValue(param, parametros[param]);
                    }
                }

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
                if (_connection.State != ConnectionState.Closed) _connection.Close();
            }
        }

        public static int ExecuteScalar(string query, Hashtable parametros)
        {
            try
            {
                _connection.Open();
                _command = new SqlCommand(query, _connection);
                _command.CommandType = CommandType.Text;

                if (parametros != null)
                {
                    foreach (string param in parametros.Keys)
                    {
                        _command.Parameters.AddWithValue(param, parametros[param]);
                    }
                }

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
