using System;
using System.Data;

using BankDataAccessLayer;

namespace BankMiddleLayer
{
    public class clsClient
    {
        public enum enMode { AddNew, Update }
        public enMode Mode;
        public int ClientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AccountNumber { get; set; }
        public int PinCode { get; set; }
        public int AccountBalance { get; set; }
        public clsClient()
        {
            this.ClientID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.AccountNumber = "";
            this.PinCode = 0;
            this.AccountBalance = 0;

            Mode = enMode.AddNew;
        }
        private clsClient(int ClientID, string FirstName, string LastName, string Email, string Phone,
                          string AccountNumber, int PinCode, int AccountBalance)
        {
            this.ClientID = ClientID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.AccountNumber = AccountNumber;
            this.PinCode = PinCode;
            this.AccountBalance = AccountBalance;

            Mode = enMode.Update;
        }
        public static clsClient Find(int ID)
        {
            string FirstName = "";
            string LastName = "";
            string Email = "";
            string Phone = "";
            string AccountNumber = "";
            int PinCode = 0;
            int AccountBalance = 0;

            if (clsClientDataAccess.GetClientByID(ID, ref FirstName, ref LastName, ref Email, ref Phone, ref AccountNumber, ref PinCode, ref AccountBalance))
            {
                return new clsClient(ID, FirstName, LastName, Email, Phone, AccountNumber, PinCode, AccountBalance);
            }
            else
            {
                return null;
            }

        }
        public static DataTable GetAllClients()
        {
            return clsClientDataAccess.GetAllClients();
        }
        public static bool IsClientExit(int ID)
        {
            return clsClientDataAccess.IcClientExit(ID);
        }
        public static bool DeleteClient(int ID)
        {
            return clsClientDataAccess.DeleteClient(ID);
        }

        private bool _AddNewClient()
        {
            this.ClientID=clsClientDataAccess.AddNewClient(FirstName, LastName, Email, Phone, AccountNumber,PinCode, AccountBalance);

            return (this.ClientID != -1 );
        }
        private bool _UpdateNewClient()
        {
            return clsClientDataAccess.UpdateClient(this.ClientID, this.FirstName, this.LastName, 
                this.Email, this.Phone, this.AccountNumber, this.PinCode, this.AccountBalance);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if (_AddNewClient())
                    {
                        return true;
                        Mode = enMode.Update;   
                    }
                    else
                    {
                        return false;
                    }
                    case enMode.Update:
                    return _UpdateNewClient();
            }
            return false;   
        }

        public bool Deposite(int ID, int Amount)
        {
            return clsClientDataAccess.Deposite(ID,  Amount);
        }
        public bool WithDraw(int ID, int Amount)
        {
            if (Amount<=this.AccountBalance)
            {
                return clsClientDataAccess.Withdraw(ID, Amount);

            }
            return false;
        }
        public static int GetTotalBalances()
        {
            return clsClientDataAccess.GetTotalBalance();
        }
    } 
}
