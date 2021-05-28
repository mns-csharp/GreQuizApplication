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
    public class QuantTestBLL //: IDisposable
    {
        private QuantitativeProblemDAO _quantProblemDAO;
        private QuantTestDAO _quanttestDAO;
        private TestAndQuantQuestionRelationDAO _testAndQuantQuestionRelationDAO;

        public QuantTestBLL()
        {
            _quantProblemDAO = new QuantitativeProblemDAO();
            _quanttestDAO = new QuantTestDAO();
        }
		
		public int Delete(QuantTest item)
        {
            int ret = -99;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _quanttestDAO.Delete(tm, item);

                _testAndQuantQuestionRelationDAO.DeleteByQuantTestID(tm, item);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }
		
		
		public IList<QuantTest> Get()
        {
            IList<QuantTest> ret = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _quanttestDAO.Get(tm);

                foreach (QuantTest item in ret)
                {
                    item.Problems = _testAndQuantQuestionRelationDAO.GetByTestID(tm, item.ID);
                }

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }

        #region GetDataSet()
        public DataSet GetDataSet()
        {
            DataSet ret = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _quanttestDAO.GetDataSet(tm);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        } 
        #endregion		
		
		public QuantTest Get(int? id)
        {
            QuantTest ret = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _quanttestDAO.Get(tm, id);

                ret.Problems = _testAndQuantQuestionRelationDAO.GetByTestID(tm, id);

                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return ret;
        }
		
		
		public int Save(QuantTest item)
        {
            int newId = -99;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                item.ID = newId = PivotTable.GetNextID(tm, "QuantTest").Value;

                _quanttestDAO.Save(tm, item);

                int c = _testAndQuantQuestionRelationDAO.Save(tm, item.ID, item.Problems);

                PivotTable.UpdateNextIdField(tm, "QuantTest", newId);



                tm.CommitTransaction();
            }
            catch
            {
                tm.RollbackTransaction();

                throw;
            }

            return newId;
        }
		
		
		public int Update(QuantTest item)
        {
            int ret = -99;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                ret = _quanttestDAO.Update(tm, item);



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
                    if (_quanttestDAO != null)
                    {
                        _quanttestDAO.Dispose();
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
