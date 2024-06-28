using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace BankDataAccessLayer
{
    public class clsUserDataAccess
    {
        public static bool GetUserByID(int user_id,ref string username,ref string password,ref int permissions)

        {
            bool IsFound = false;
            SqlConnection connection =new SqlConnection(clsDataAccessSetting.conString);

            string QUERY = "select * from Users Where UserID = @UserID ";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@UserID", user_id);
            command.Parameters.AddWithValue("@UserName", username);
            command.Parameters.AddWithValue("@PassWord", password);
            command.Parameters.AddWithValue("@Permissions", permissions);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    IsFound = true;
                    username = (string)reader["UserName"];
                    password = (string)reader["PassWord"];
                    permissions = (int)reader["Permissions"];

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }




            return IsFound;
        }

        public static int AddNewUser(string username,string password,int permissions)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.conString);
            string QUERY = "Insert Into Users " +
                "Values (@UserName,@PassWord,@Permissions);" +
                " select SCOPE_IDENTITY()";
               

            SqlCommand sqlCommand = new SqlCommand(QUERY, connection);

            sqlCommand.Parameters.AddWithValue("@UserName", username);
            sqlCommand.Parameters.AddWithValue("@PassWord", password);
            sqlCommand.Parameters.AddWithValue("@Permissions", permissions);
            try
            {
                connection.Open();
                object rus = sqlCommand.ExecuteScalar();
                if (rus != null && int.TryParse(rus.ToString(), out int NewID)) 
                {
                    ID = NewID;
                }

            }
            catch { ID = -1; }
            finally { connection.Close(); }



            return ID;
        }

        public static bool  UpdateUser(int ID, string username, string password, int permissions)
        {
            int RowEffect = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.conString);
            string QUERY = @"Update Users
                            set UserName     = @UserName,
                                PassWord     = @PassWord,
                                Permissions  = @Permissions
                                Where UserID =@UserID ";

            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@UserID",ID);
            command.Parameters.AddWithValue("@UserName", username);
            command.Parameters.AddWithValue("@PassWord", password);
            command.Parameters.AddWithValue("@Permissions", permissions);

            try
            {
                connection.Open();
                RowEffect = command.ExecuteNonQuery();

            }
            catch { return false; }finally { connection.Close(); }
            return RowEffect > 0;
        }

        public static bool IsUserExit(int ID)
        {
            int RowExit = 0;
            string QUERY = "select Found = 1 from Users where UserID=@UserID";
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.conString);
            SqlCommand command =new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@UserID", ID);

            try
            {
                connection.Open();
                object rus = command.ExecuteScalar();
                if (rus != null && int.TryParse(rus.ToString(), out int New)) 
                {
                    RowExit = New;
                }
            }
            catch { return false; }

            finally 
            {
                connection.Close();
            
            
            
            }



            return RowExit > 0;
        }

        public static bool DeleteUser(int ID)
        {
            int RowDelete = -1;
            SqlConnection conn = new SqlConnection(clsDataAccessSetting.conString);

            string Query = "Delete From Users Where UserID = @UserID";
            SqlCommand command = new SqlCommand(Query, conn);
            command.Parameters.AddWithValue("@UserID", ID);

            try
            {
                conn.Open();

                
                RowDelete = command.ExecuteNonQuery();

            }
            catch { return false; }
            finally { conn.Close(); }
            return RowDelete > 0;
        }


        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.conString);


            string Query = "select * From Users";
            SqlCommand cmd = new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch { return dt; }finally { connection.Close(); }

            return dt;
        }

    }
}
