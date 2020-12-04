﻿using GiaoDienCafe_New.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GiaoDienCafe_New.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private AccountDAO() { }

        public bool Login(string username, string password, string type)
        {
            string query = "dbo.USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }

        public bool UpdateAccount(string username, string displayname, string password, string newpass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateAccount @userName , @displayName , @passWord , @newPassWord", new object[] { username, displayname, password, newpass });
            return result > 0;
        }

        public Account GetAccountByUserName(string username)
        {

            string query = "SELECT * FROM dbo.Account WHERE UserName = '" + username + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
    }
}
