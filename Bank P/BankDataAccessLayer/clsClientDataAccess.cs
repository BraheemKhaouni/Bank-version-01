using System;
using System.Data;
using System.Data.SqlClient; 

namespace BankDataAccessLayer
{
    public class clsClientDataAccess
    {
        public static bool GetClientByID(int ID,ref string FirstName,ref string LastName,ref string Email,ref string Phone,
                       ref   string AccountNumber,ref int PinCode,ref int AccountBalance)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.conString);

            string QUERY = "select * from Clients Where ClientID = @ClientID";

            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@ClientID", ID);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName );
            command.Parameters.AddWithValue("@Email", Email );
            command.Parameters.AddWithValue("@Phone", Phone );
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber );
            command.Parameters.AddWithValue("@PinCode", PinCode );
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance );

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    IsFound = true;
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    AccountNumber = (string)reader["AccountNumber"];
                    PinCode = (int)reader["PinCode"];
                    AccountBalance = (int)reader["AccountBalance"];

                }
                reader.Close(); 
            }
            catch (Exception ex) { IsFound = false; } finally { connection.Close(); }
            
            return IsFound;
        }
        public static DataTable GetAllClients()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.conString);
            string Query = "select * from Clients";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }
            return dt;
        }
       public static bool IcClientExit(int ID)
        {
            bool IsFound = false;

            SqlConnection connection =new SqlConnection(clsDataAccessSetting.conString);
            string Query = "Select Found = 1 From Clients Where ClientID = @ClientID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ClientID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;
            }catch (Exception ex) {IsFound = false; } finally { connection.Close();}

            return IsFound;
        }
        public static bool DeleteClient(int ID)
        {
            int RowEffect = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.conString);
            string QUERY = "Delete From Clients Where ClientID = @ClientID ";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@ClientID",ID);

            try
            {
                connection.Open();
                RowEffect = command.ExecuteNonQuery();


            }
            catch { RowEffect = 0; }
            finally { connection.Close(); }

            return RowEffect > 0;
        }

        public static int AddNewClient( string FirstName,  string LastName,  string Email,  string Phone,
                                        string AccountNumber,  int PinCode,  int AccountBalance)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection (clsDataAccessSetting.conString);

            string QUERY = "Insert Into Clients " +
            "Values (@FirstName,@LastName,@Email,@Phone,@AccountNumber,@PinCode,@AccountBalance);" +
            "Select SCOPE_IDENTITY() ";

            SqlCommand command =new SqlCommand (QUERY, connection);

            command.Parameters.AddWithValue("@FirstName"     , FirstName) ;
            command.Parameters.AddWithValue("@LastName"      , LastName);
            command.Parameters.AddWithValue("@Email"         , Email);
            command.Parameters.AddWithValue("@Phone"         , Phone);
            command.Parameters.AddWithValue("@AccountNumber" , AccountNumber);
            command.Parameters.AddWithValue("@PinCode"       , PinCode);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

            try
            {
                connection.Open();
                object Rus = command.ExecuteScalar();
                if (Rus!=null&&int.TryParse(Rus.ToString(),out int NewID))
                {
                    ID = NewID;
                }
            }
            catch { ID = -1; }
            finally { connection.Close(); }

            return ID;
        }

        public static bool UpdateClient(int ID,string FirstName, string LastName, string Email, string Phone,
                                        string AccountNumber, int PinCode, int AccountBalance)
        {
            int RowEffect = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.conString);

            string QUERY = @"Update  Clients  
                                set FirstName = @FirstName, 
                                LastName = @LastName, 
                                Email = @Email, 
                                Phone = @Phone, 
                                AccountNumber = @AccountNumber, 
                                PinCode = @PinCode,
                                AccountBalance = @AccountBalance

                                where ClientID = @ClientID";

            SqlCommand command = new SqlCommand(QUERY, connection);

            command.Parameters.AddWithValue("@ClientID", ID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

            try
            {
                connection.Open();

                RowEffect = command.ExecuteNonQuery();
            }
            catch { return false; }
            finally { connection.Close(); }

            return RowEffect > 0;
        }


        public static bool Deposite(int ID, int Amount)
        {
            int RowEffect= 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.conString);

            string Query = " Update Clients " +
                           " Set AccountBalance +=@Amount" +
                           " Where ClientID = @ClientID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ClientID", ID);
            command.Parameters.AddWithValue("@Amount", Amount);

            try
            {
                connection.Open();
                RowEffect = command.ExecuteNonQuery();
            }
            catch { return false; }finally { connection.Close(); }

            return RowEffect > 0;
        }
        public static bool Withdraw(int ID, int Amount)
        {
            int RowEffect = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.conString);

            string Query = " Update Clients " +
                           " Set AccountBalance -=@Amount" +
                           " Where ClientID = @ClientID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ClientID", ID);
            command.Parameters.AddWithValue("@Amount", Amount);

            try
            {
                connection.Open();
                RowEffect = command.ExecuteNonQuery();
            }
            catch { return false; }
            finally { connection.Close(); }

            return RowEffect > 0;
        }
        public static int GetTotalBalance()
        {
            int totalBalance = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.conString);
            string QUERY = "select SUM(AccountBalance) as Total from Clients";

            SqlCommand command = new SqlCommand(QUERY, connection);


            try
            {
                connection.Open();
                object Rus = command.ExecuteScalar();
                if (Rus!=null&&int.TryParse(Rus.ToString(),out int Total))
                {
                    totalBalance = Total;
                }
            }
            catch { totalBalance = 0; }
            finally { connection.Close(); }


            return totalBalance;
        }







    }
}
