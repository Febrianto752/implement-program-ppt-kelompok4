using System.Data.SqlClient;

namespace DryPrinciple;

class Program
{
    public static void Main(string[] args)
    {

    }
}

class DB
{
    private string _connectionString = "Data Source=test;Database=db_hr;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
    public SqlConnection Connection()
    {
        return new SqlConnection(_connectionString);
    }
}

class User
{
    public List<User> GetAll()
    {
        var connection = new DB().Connection();
        // ... action

        return new List<User>();
    }

    public User GetById(int id)
    {
        var connection = new DB().Connection();
        // ... action

        return new User();
    }

    public int Delete(int id)
    {
        var connection = new DB().Connection();
        // ... action

        return 1;
    }
}