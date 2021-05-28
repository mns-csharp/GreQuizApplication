using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Simple.Framework;
using System.Data;
using QuizApplicationLibrary.DAO;
using QuizApplicationLibrary.POCO;

namespace QuizApplicationLibrary.BLL
{
    public class QuantComplexityTypeBLL //: IDisposable
    {
        private QuantComplexityTypeDAO _quantcomplexitytypeDAO;

        public QuantComplexityTypeBLL()
        {
            _quantcomplexitytypeDAO = new QuantComplexityTypeDAO();
        }

        		
		
		public int Delete(QuantComplexityType item)
        {
            int ret = -99;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _quantcomplexitytypeDAO.Delete(tm, item);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }
		
		
		public IList<QuantComplexityType> Get()
        {
            IList<QuantComplexityType> ret = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _quantcomplexitytypeDAO.Get(tm);

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

                ret = _quantcomplexitytypeDAO.GetDataSet(tm);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }
		
		
		public QuantComplexityType Get(int? id)
        {
            QuantComplexityType ret = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _quantcomplexitytypeDAO.Get(tm, id);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }
		
		
		public int Save(QuantComplexityType item)
        {
            int ret = -99;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _quantcomplexitytypeDAO.Save(tm, item);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }
		
		
		public int Update(QuantComplexityType item)
        {
            int ret = -99;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _quantcomplexitytypeDAO.Update(tm, item);

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
                    if (_quantcomplexitytypeDAO != null)
                    {
                        _quantcomplexitytypeDAO.Dispose();
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
