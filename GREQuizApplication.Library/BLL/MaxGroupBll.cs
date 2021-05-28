using QuizApplicationLibrary.POCO;
using Simple.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplicationLibrary.BLL
{
    public class MaxGroupBll : IDisposable
    {
        public MaxGroup Get()
        {
            MaxGroup item = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);
                queryExecutor.CreateSqlCommand(@"select * from MaxGroup");

                ISafeDataReader dataReader = queryExecutor.ExecuteReader();

                try
                {
                    while (dataReader.Read())
                    {
                        item = new MaxGroup();
                        item.GroupNo = (int)dataReader.GetInt32("GroupNo");
                    }

                    dataReader.Close();
                }
                catch (Exception)
                {
                    if (dataReader != null)
                    {
                        dataReader.Close();
                        dataReader = null;
                    }

                    throw;
                }

                tm.CommitTransaction();
            }
            catch (Exception)
            {
                tm.RollbackTransaction();

                throw;
            }

            return item;
        }

        #region IDisposable
        private bool disposed = false; // to detect redundant calls
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //if (reader != null)
                    //{
                    //    reader.Dispose();
                    //}
                }

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        } 
        #endregion
    }
}
