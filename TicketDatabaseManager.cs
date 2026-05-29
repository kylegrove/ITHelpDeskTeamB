using ITHelpDeskTeamB;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Diagnostics;
public class TicketDatabaseManager
{
    private StringConnection s = new StringConnection();
    public TicketDatabaseManager()
    {

    }


    public void InsertTicket(string ticketDescription, string ticketStatus, string ticketDate, int ticketPriority, int userID)
    {

        //create the SQL query as a string to pass into function
        string query = @"INSERT INTO tickets (ticketDescription, ticketStatus, ticketSolution, ticketDate, ticketPriority, userID)
                         VALUES (@ticketDescription, @ticketStatus, @ticketSolution, @ticketDate, @ticketPriority, @userID)";

        //establish connection to path of where database is located
        using (SqlConnection connection = new SqlConnection(s.connection))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            //individually add each piece of data
            command.Parameters.AddWithValue("@ticketDescription", ticketDescription);
            command.Parameters.AddWithValue("@ticketStatus", ticketStatus);
            command.Parameters.AddWithValue("@ticketDate", ticketDate);
            command.Parameters.AddWithValue("@ticketSolution", "N/A");
            command.Parameters.AddWithValue("@ticketPriority", ticketPriority);
            command.Parameters.AddWithValue("@userID", userID);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public DataTable LoadSqlData(int userID)
    {
        string query = "SELECT * FROM Tickets WHERE userID = @userID";
        try
        {

            using (SqlConnection connection = new SqlConnection(s.connection))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", userID);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();


                    adapter.Fill(dataTable);


                    return dataTable;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message);
            return null;
        }
    }

    public DataTable LoadAdminTickets()
    {
        string query = "SELECT * FROM Tickets";
        try
        {

            using (SqlConnection connection = new SqlConnection(s.connection))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
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
            MessageBox.Show("An error occurred: " + ex.Message);
            return null;
        }

    }

    public void SolveTicket(string caseNumber, string solution)
    {
        string query = @"UPDATE tickets
                     SET ticketStatus = @status,
                         ticketSolution = @solution
                     WHERE ticketID = @ticketID";

        using (SqlConnection connection = new SqlConnection(s.connection))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@status", "Solved");
            command.Parameters.AddWithValue("@solution", solution);
            command.Parameters.AddWithValue("@ticketID", caseNumber);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public void UpdateTicketChanges(string ticketid, string priority, string notes)
    {
        // Convert priority text to number
        int priorityNumber = priority switch
        {
            "Low" => 1,
            "Medium" => 2,
            "High" => 3,
            "Critical" => 4,
            _ => 2
        };

        string query = @"UPDATE tickets
                     SET ticketPriority = @priority
                     WHERE ticketID = @ticketID";

        using (SqlConnection connection = new SqlConnection(s.connection))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@priority", priorityNumber);
            command.Parameters.AddWithValue("@ticketID", ticketid);

            connection.Open();
            command.ExecuteNonQuery();
        }

        // Note: If you want to store notes, you'll need to add a notes column to your database
        // For now, this updates only the priority
    }

    public int[] GetDataCount()
    {
        string query = "SELECT SUM(case when ticketStatus = 'Unsolved' then 1 else 0 end) AS UnsolvedCount, " +
            "SUM(case when ticketStatus = 'InProgress' then 1 else 0 end) AS InProgressCount, " +
            "SUM(case when ticketStatus = 'Solved' then 1 else 0 end) AS SolvedCount, " +
            "SUM(case when ticketDate >= @today and ticketDate < dateadd(day, 1, @today) then 1 else 0 end) AS OpenedTodayCount " +
            "FROM tickets;";
        var counts = new int[4];
        using (SqlConnection connection = new SqlConnection(s.connection))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.Add("@today", SqlDbType.Date).Value = DateTime.Today;
            connection.Open();
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    counts[0] = reader.GetInt32(0); // Unsolved
                    counts[1] = reader.GetInt32(1); // InProgress
                    counts[2] = reader.GetInt32(2); // Solved
                    counts[3] = reader.GetInt32(3); // Opened Today
                }
            }
        }
        return counts;
    }

    public string GetTicketDescription(string ticketID)
    {
        string description = string.Empty;

        try
        {
            using (SqlConnection connection = new SqlConnection(s.connection))
            {
                connection.Open();
                string query = "SELECT ticketDescription FROM Tickets WHERE ticketID = @ticketID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ticketID", ticketID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            description = reader.GetString(0);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading ticket description: {ex.Message}",
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        return description;
    }

    public bool ShareTicket(string ticketID, int newUserID, string newStatus)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(s.connection))
            {
                connection.Open();

                string updateQuery = @"UPDATE Tickets 
                                      SET userID = @newUserID,
                                          ticketStatus = @status
                                      WHERE ticketID = @ticketID";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@newUserID", newUserID);
                    command.Parameters.AddWithValue("@ticketID", ticketID);
                    command.Parameters.AddWithValue("@status", newStatus);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error sharing ticket: {ex.Message}",
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return false;
        }
    }
}