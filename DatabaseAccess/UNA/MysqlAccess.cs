using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DatabaseAccess.UNA
{
    public class MysqlAccess : DbAccess
    {
        public override void BeginTransaction()
        {
            if (Connection != null)
            {
                Transaction = Connection.BeginTransaction();
            }
        }

        public override void CloseConnection()
        {
            if(Connection != null)
            {
                Connection.Close();
            }
        }

        public override void CommitTransaction()
        {
            if (IsTransaction())
            {
                Transaction.Commit();
            }
        }

   
        public override bool IsTransaction()
        {
            if(Transaction != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void OpenConnection()
        {
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
        }

        public override void RollBackTransaction()
        {
            if(IsTransaction())
            {
                Transaction.Rollback();
            }
        }
        public override long EjectSQL(string sql)
        {
            MySqlCommand mySqlCommand = new MySqlCommand(sql,(MySqlConnection) Connection);
            return mySqlCommand.ExecuteNonQuery();
            
        }
        
        public override DataTable QuerySQL(string sql)
        {
            DataTable result = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sql,(MySqlConnection) Connection);
            mySqlDataAdapter.Fill(result);
            return result;
        }

    }
}
