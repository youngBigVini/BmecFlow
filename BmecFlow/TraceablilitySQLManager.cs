using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BmecFlow
{
    class TraceablilitySQLManager
    {
        
        public bool TrackIdExist(string trackId)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jagvluiz\Documents\GitHub\BmecFlow\BmecFlow\dbTraceability.mdf;Integrated Security=True;Connect Timeout=30";
            string query = $"SELECT COUNT(*) FROM TableTraceability WHERE TrackId = @trackId";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@trackId", trackId);
                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                    return false;
                }
            }
                
        }

        public void insertTrackId(string trackId)
        {
            // String de conexão com o banco de dados
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jagvluiz\Documents\GitHub\BmecFlow\BmecFlow\dbTraceability.mdf;Integrated Security=True;Connect Timeout=30";
            string insertSql = $"INSERT INTO TableTraceability (TrackId) VALUES (@trackId)";
            // Conectar ao banco de dados e executar a consulta
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand insertCommand = new SqlCommand(insertSql, connection);
                insertCommand.Parameters.AddWithValue("@trackId", trackId);                
                try
                {
                    connection.Open();
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    Console.WriteLine($"Número de linhas afetadas: {rowsAffected}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }
        }

        public void insertItemTraceability(string itemTraceability, string trackId, string partnumber)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TRACEABILITY\db\dbTraceability.mdf;Integrated Security=True;Connect Timeout=30";
            
            // Query SQL para atualizar a célula
            string query = $"UPDATE TableTraceability SET [{itemTraceability}] = @partnumber WHERE TrackId = @trackId";
            Console.WriteLine(query);
            // Conexão com o banco de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Cria o comando SQL
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@partnumber", partnumber);
                cmd.Parameters.AddWithValue("@trackId", trackId); // Adiciona o parâmetro @trackId

                try
                {
                    // Abre a conexão
                    connection.Open();

                    // Executa o comando
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} linha(s) atualizada(s).");
                    connection.Close();
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }
        }


        }
}
