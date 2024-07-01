using BankDataAccessLayer;
using System;
using System.Data;
using System.Net.Http.Headers;



namespace BankMiddleLayer
{
    public class clsUser
    {
        public enum enPermiosion 
        {
        pAll=-1,
        pAddNewClient=1,
        pDeleteClient=2,
        pUpdateClient=4,
        pTtancations=8,
        pMangeUser=16
        }
        public enum enMode { AddNew,Update};
        public enMode Mode;
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int Permissions { get; set; }

        public clsUser()
        {
            UserID = -1;
            UserName = string.Empty;
            PassWord=string.Empty;
            Permissions = -2;
            Mode = enMode.AddNew;
        }
        private clsUser (int userID,string username,string password,int permissions)
        {
            UserID = userID;
            UserName = username;
            PassWord = password;
            Permissions = permissions;
            Mode = enMode.Update;
        }

        public static clsUser Find(int ID)
        {
          string  UserName = string.Empty;
          string  PassWord = string.Empty;
          int  Permissions = -2;

            if (clsUserDataAccess.GetUserByID(ID,ref UserName,ref PassWord,ref Permissions))
            {
                return new clsUser(ID,UserName,PassWord,Permissions);

            }
            else
            {
                return null;
            }
        }
        public static clsUser Find(string username, string password)
        {
            int ID = -1;
            int Permissions = -2;

            if (clsUserDataAccess.GetUserByUserNameAndPasswprd(username,password,ref ID,ref Permissions))
            {
             return new clsUser(ID,username,password,Permissions);     
            }
            else
            {
                return null;
            }


        }
        private bool _AddNewUser()
        {
            this.UserID = clsUserDataAccess.AddNewUser(UserName,PassWord,Permissions);
            return (this.UserID != -1);
        }
        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(this.UserID,this.UserName,this.PassWord,this.Permissions);
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;   
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public static bool IsUserExit(int  ID) {
            return clsUserDataAccess.IsUserExit(ID);
        }
        
       public static bool DeleteUser(int ID)
        {
            return clsUserDataAccess.DeleteUser(ID);
        }
        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }
    }
}
