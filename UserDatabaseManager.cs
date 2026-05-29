using ITHelpDeskTeamB;
using Microsoft.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

public class UserDatabaseManager
{
    private StringConnection s; //used to direct database
    int userCount;

    public UserDatabaseManager() //initialize object based on connectionString
    {
        s = new StringConnection();
    }

    public bool CreateNewUser(string userName, string firstName, string lastName, string password, string userType, string email, string phone)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(s.connection))
            {
                conn.Open();

                string query = @"INSERT INTO Users 
                            (userName, userFirstName, userLastName, userPassword, userType, userEmail, userPhone)
                             VALUES 
                            (@userName, @userFirstName, @userLastName, @userPassword, @userType, @userEmail, @userPhone)";
                string dbUserType;
                if (userType == "Admin")
                {
                    dbUserType = "admin";
                }
                else if (userType == "IT Support Member")
                {
                    dbUserType = "support";
                }
                else if (userType == "Project Member")
                {
                    dbUserType = "member";
                }
                else if (userType == "Report Manager")
                {
                    dbUserType = "report";
                }
                else
                {
                    dbUserType = "invalid";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@userFirstName", firstName);
                    cmd.Parameters.AddWithValue("@userLastName", lastName);
                    cmd.Parameters.AddWithValue("@userPassword", password);
                    cmd.Parameters.AddWithValue("@userType", dbUserType);
                    cmd.Parameters.AddWithValue("@userEmail", email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@userPhone", phone ?? (object)DBNull.Value);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("Failed to create user: " + ex.Message, ex);
        }
    }

    public bool deleteUser(string userName, int userId)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(s.connection))
            {
                conn.Open();

                // Check if user has related records (tickets, etc.)
                // You might want to handle this based on your database relationships

                string deleteQuery = "DELETE FROM Users WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"User '{userName}' has been deleted successfully.",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("User could not be deleted. Please try again.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            // Handle foreign key constraint violations
            if (ex.Number == 547) // FK constraint violation
            {
                MessageBox.Show(
                    $"Cannot delete user '{userName}' because they have related records in the system.\n\n" +
                    "Please remove or reassign their tickets and other data first.",
                    "Delete Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

    public String? getAuthorizedPassword(string userName)
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        try
        {

            //right click on the .mdf file under the Solution Explorer and select Properties
            //then find its Full Path directory and copy and paste it below
            cn.ConnectionString = s.connection;
            //need to find a way to get this to work on every persons computer instead of
            //just changing this line every time

            cmd.Connection = cn;

            cmd.CommandText = "SELECT userPassword FROM Users WHERE userName = @username";

            cmd.Parameters.AddWithValue("@username", userName);

            // open a connection to DB
            cn.Open();

            //read the table
            dr = cmd.ExecuteReader();

            //read a record from the data reader
            dr.Read();

            return dr.GetString(0).TrimEnd(); //to get rid of any trailing spaces from the database table
        }
        catch (Exception err)
        {
            //it handles any other errors
            MessageBox.Show(err.Message, "Database error!");

            return null;
        }
        finally
        {
            cn.Close(); //Close connection regardless of any errors or not
        }
    }
    public User GetUser(string userName)
    {
        using (SqlConnection connection = new SqlConnection(s.connection))
        {
            string sql = "SELECT * FROM Users WHERE userName = @userName";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@userName", userName);

            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new User(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6),
                        reader.GetString(7)
                    );
                }
            }
        }

        return null;
    }
    public string[] GetUserDetails(string userName)
    // Returns an array of user information with indexes:
    // [0] userFirstName
    // [1] userLastName
    // [2] userEmail
    {
        string[] detailsArray = new string[3];
        using (SqlConnection connection = new SqlConnection(s.connection))
        {
            string GetDetailQ1 = "SELECT * FROM Users WHERE userName = @userName";
            SqlCommand command = new SqlCommand(GetDetailQ1, connection);
            command.Parameters.AddWithValue("@userName", userName);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    detailsArray[0] = reader.GetString(2);
                    detailsArray[1] = reader.GetString(3);
                    detailsArray[2] = reader.GetString(6);
                }
            }
        }
        return detailsArray;
    }

    public void setUserCount(int count)
    {
        userCount = count;
    }

    public int getUserCount()
    {
        int count = -1;
        using (SqlConnection connection = new SqlConnection(s.connection))
        {
            string query = "SELECT COUNT(*) FROM Users;";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    count = reader.GetInt32(0);
                }
            }
        }
        return count;
    }

    public DataTable LoadUsers() //pull up from DB
    {
        string query = "SELECT UserID, UserName, UserType, UserEmail, UserPhone FROM Users ORDER BY UserName";
        try
        {
            using (SqlConnection conn = new SqlConnection(s.connection))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
    }

    public List<ITSupportMember> GetITSupportMembers()
    {
        List<ITSupportMember> supportMembers = new List<ITSupportMember>();

        try
        {
            using (SqlConnection connection = new SqlConnection(s.connection))
            {
                connection.Open();
                string query = "SELECT * FROM Users WHERE userType = 'support'";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ITSupportMember staff = new ITSupportMember(
                            reader.GetInt32(0),      // userId
                            reader.GetString(1),      // userName
                            reader.GetString(2),      // userFirstName
                            reader.GetString(3),      // userLastName
                            reader.GetString(4),      // userPassword
                            reader.GetString(6),      // userEmail
                            reader.GetString(7)       // userPhone
                        );
                        supportMembers.Add(staff);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading IT staff: {ex.Message}",
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return supportMembers;
    }
}