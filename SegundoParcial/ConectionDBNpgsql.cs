using System;
using System.Data;
using System.Data.SqlClient;
using Npgsql;
using System.Windows.Forms;
namespace SegundoParcial
{
    public class ConectionDBNpgsql

    {
   string parameter=("Server=localhost;Port=5432;Id=postgres;Password=1109;DataBase=ExamenParcial2;");
   private static string sConnection;
    
    public static DataTable  Connetion(string query)
    {
        NpgsqlConnection connection = new NpgsqlConnection(sConnection);
        DataSet ds = new DataSet();
        connection.Open();
            
        NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
        da.Fill(ds);
            
        connection.Close();

        return ds.Tables[0];
    }

    public static void Disconnection(string act)
    {
        Console.WriteLine(sConnection);
        NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            
        connection.Open();
        NpgsqlCommand command = new NpgsqlCommand(act, connection);
        command.ExecuteNonQuery();
        connection.Close();
    }
    }
    }
