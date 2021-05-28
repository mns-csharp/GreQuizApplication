using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Simple.Framework;
using System.Data;
using QuizApplicationLibrary.POCO;
using QuizApplicationLibrary.DAO;
namespace QuizApplicationLibrary.BLL
{
    public class TestTakerBLL //: IDisposable
    {
        private TestTakerDAO _testtakerDAO;

        public TestTakerBLL()
        {
            _testtakerDAO = new TestTakerDAO();
        }

        		
		
		public int Delete(TestTaker item)
        {
            int ret = -99;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _testtakerDAO.Delete(tm, item);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }
		
		
		public IList<TestTaker> Get()
        {
            IList<TestTaker> ret = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _testtakerDAO.Get(tm);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }
		
		
		public DataSet GetDataSet()
        {
            DataSet ret = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _testtakerDAO.GetDataSet(tm);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }
		
		
		public TestTaker Get(int? id)
        {
            TestTaker ret = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _testtakerDAO.Get(tm, id);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }
		
		
		public int Save(TestTaker item)
        {
            int ret = -99;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _testtakerDAO.Save(tm, item);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }
		
		
		public int Update(TestTaker item)
        {
            int ret = -99;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _testtakerDAO.Update(tm, item);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }
  

        #region IDisposable
		/*
        private bool disposed = false; // to detect redundant calls
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (_testtakerDAO != null)
                    {
                        _testtakerDAO.Dispose();
                    }
                }

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }*/
        #endregion
    }
}
