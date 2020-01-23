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
    public abstract class DbAccess
    {
        public   string ConnectionString
        {
            get;
            set;
        }
        public  DbTransaction Transaction 
        {
            get;
            set;
        }
        public  DbConnection Connection 
        {
            get;
            set;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
        public abstract long EjectSQL(String var);
        public abstract DataTable QuerySQL(string var);
        public abstract bool IsTransaction();
        public abstract void CommitTransaction();
        public abstract void RollBackTransaction();
        public abstract void BeginTransaction();

    }
}
