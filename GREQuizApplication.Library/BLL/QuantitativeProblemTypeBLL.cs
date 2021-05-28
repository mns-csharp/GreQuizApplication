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
    public class QuantitativeProblemTypeBLL //: IDisposable
    {
        private QuantitativeProblemTypeDAO _quantitativeproblemtypeDAO;

        public QuantitativeProblemTypeBLL()
        {
            _quantitativeproblemtypeDAO = new QuantitativeProblemTypeDAO();
        }

        		
		
		public int Delete(QuantitativeProblemType item)
        {
            int ret = -99;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _quantitativeproblemtypeDAO.Delete(tm, item);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }
		
		
		public IList<QuantitativeProblemType> Get()
        {
            IList<QuantitativeProblemType> ret = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _quantitativeproblemtypeDAO.Get(tm);

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

                ret = _quantitativeproblemtypeDAO.GetDataSet(tm);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }
		
		
		public QuantitativeProblemType Get(int? id)
        {
            QuantitativeProblemType ret = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _quantitativeproblemtypeDAO.Get(tm, id);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }
		
		
		public int Save(QuantitativeProblemType item)
        {
            int ret = -99;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _quantitativeproblemtypeDAO.Save(tm, item);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }
		
		
		public int Update(QuantitativeProblemType item)
        {
            int ret = -99;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _quantitativeproblemtypeDAO.Update(tm, item);

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
                    if (_quantitativeproblemtypeDAO != null)
                    {
                        _quantitativeproblemtypeDAO.Dispose();
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
