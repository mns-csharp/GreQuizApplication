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
    public class QuantitativeProblemBLL //: IDisposable
    {
        private QuantitativeProblemDAO _quantitativeproblemDAO;

        public QuantitativeProblemBLL()
        {
            _quantitativeproblemDAO = new QuantitativeProblemDAO();
        }

        		
		
		public int Delete(QuantitativeProblem item)
        {
            int ret = -99;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _quantitativeproblemDAO.Delete(tm, item);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }
		
		
		public IList<QuantitativeProblem> Get()
        {
            IList<QuantitativeProblem> ret = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _quantitativeproblemDAO.Get(tm);

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

                ret = _quantitativeproblemDAO.GetDataSet(tm);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }
		
		
		public QuantitativeProblem Get(int? id)
        {
            QuantitativeProblem ret = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _quantitativeproblemDAO.Get(tm, id);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }
		
		
		public int Save(QuantitativeProblem item)
        {
            int ret = -99;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                item.ID = ret = PivotTable.GetNextID(tm, "QuantitativeProblem").Value;

                _quantitativeproblemDAO.Save(tm, item);

                PivotTable.UpdateNextIdField(tm, "QuantitativeProblem", ret);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }
		
		
		public int Update(QuantitativeProblem item)
        {
            int ret = -99;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _quantitativeproblemDAO.Update(tm, item);

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
                    if (_quantitativeproblemDAO != null)
                    {
                        _quantitativeproblemDAO.Dispose();
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
