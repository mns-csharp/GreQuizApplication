using QuizApplicationLibrary.DAO;
using QuizApplicationLibrary.POCO;
using Simple.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplicationLibrary
{
    public static class ApplicationDataBLLL
    {
        public static ApplicationData Get()
        {
            ApplicationDataDAO _applicationDatabase = new ApplicationDataDAO();

            ApplicationData item = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                item = _applicationDatabase.Get(tm);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
            }

            return item;
        }

        public static int Save(ApplicationData item)
        {
            ApplicationDataDAO _applicationDatabase = new ApplicationDataDAO();

            int newId = 0;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                _applicationDatabase.SaveData(tm, item);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
            }

            return newId;
        }
    }
}
