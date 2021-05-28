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
    public class WordBLL : IDisposable
    {
        private WordDAO _wordDAO;

        public WordBLL()
        {
            _wordDAO = new WordDAO();
        }

        public Word Get(int id)
        {
            Word item = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                item = _wordDAO.Get(tm, id);

                tm.CommitTransaction();
            }
            catch (Exception)
            {
                tm.RollbackTransaction();

                throw;
            }

            return item;
        }

        public IList<Word> Get()
        {
            IList<Word> list = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                list = _wordDAO.Get(tm);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
            }

            return list;
        }

        public DataSet GetDataSet()
        {
            DataSet list = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                list = _wordDAO.GetDataSet(tm);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
            }

            return list;
        }

        public IDictionary<int, Word> GetDictionary()
        {
            IDictionary<int, Word> list = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                list = _wordDAO.GetDictionary(tm);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
            }

            return list;
        }

        public IList<Word> GetByCorrectnessBelow(int correctness, string like)
        {
            IList<Word> list = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                list = _wordDAO.GetByCorrectnessBelow(tm, correctness, like);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
            }

            return list;
        }

        public IList<Word> GetByGroup(int group)
        {
            IList<Word> list = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                list = _wordDAO.GetByGroup(tm, group);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
            }

            return list;
        }

        public IList<string> GetNamesByGroup(int group)
        {
            IList<string> list = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                list = _wordDAO.GetNamesByGroup(tm, group);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
            }

            return list;
        }

        //public IList<string> GetNamesByGroup(int group)
        //{
        //    IList<string> list = null;

        //    TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

        //    try
        //    {
        //        tm.BeginTransaction();

        //        list = _wordDAO.GetNamesByGroup(tm, group);

        //        tm.CommitTransaction();
        //    }
        //    catch (Exception ex)
        //    {
        //        tm.RollbackTransaction();

        //        throw ex;
        //    }

        //    return list;
        //}

        public IList<Word> GetByGroup(int group, string like)
        {
            IList<Word> list = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                list = _wordDAO.GetByGroup(tm, group, like);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
            }

            return list;
        }

        public IList<Word> GetByCorrectnessBelow(int group, int correctness)
        {
            IList<Word> list = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                list = _wordDAO.GetByCorrectnessBelow(tm, correctness, group);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
            }

            return list;
        }

        public IList<string> GetNamesByCorrectnessBelow(int group, int correctness)
        {
            IList<string> list = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                list = _wordDAO.GetNamesByCorrectnessBelow(tm, correctness, group);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
            }

            return list;
        }

        public IList<Word> GetByCorrectnessBelow(int group, int correctness, string like)
        {
            IList<Word> list = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                list = _wordDAO.GetByCorrectnessBelow(tm,  correctness, group, like);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
            }

            return list;
        }


        public IList<Word> GetByCorrectnessBelow(int correctness)
        {
            IList<Word> list = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                list = _wordDAO.GetByCorrectnessBelow(tm, correctness);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
            }

            return list;
        }


        public IList<Word> GetByCorrectnessBeyond(int correctness, string like)
        {
            IList<Word> list = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                list = _wordDAO.GetByCorrectnessBeyond(tm, correctness, like);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
            }

            return list;
        }

        public IList<Word> GetByCorrectnessBeyond(int group, int correctness)
        {
            IList<Word> list = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                list = _wordDAO.GetByCorrectnessBeyond(tm, group, correctness);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
            }

            return list;
        }

        public IList<string> GetNamesByCorrectnessBeyond(int group, int correctness)
        {
            IList<string> list = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                list = _wordDAO.GetNamesByCorrectnessBeyond(tm, group, correctness);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
            }

            return list;
        }

        public IList<Word> GetByCorrectnessBeyond(int correctness)
        {
            IList<Word> list = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                list = _wordDAO.GetByCorrectnessBeyond(tm, correctness);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
            }

            return list;
        }

        public IList<Word> GetByCorrectnessBeyond(int group, int correctness, string like)
        {
            IList<Word> list = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                list = _wordDAO.GetByCorrectnessBeyond(tm, group, correctness, like);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
            }

            return list;
        }

        public IList<Word> GetByLearnt(int group, LearntTypeEnum learnType)
        {
            if(learnType == LearntTypeEnum.All)
            {
                return GetByGroup(group);
            }
            else if(learnType == LearntTypeEnum.Learnt)
            {
                return GetByCorrectnessBeyond(group, InMemoryValues.CorrectnessRepetition);
            }
            else
            {
                return GetByCorrectnessBelow(group, InMemoryValues.CorrectnessRepetition);
            }
        }

        public int Save(Word item)
        {
            int newId = 0;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                item.ID = newId = PivotTable.GetNextID(tm, "GreWords").Value;

                _wordDAO.Save(tm, item);

                PivotTable.UpdateNextIdField(tm, "GreWords", newId);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
            }

            return newId;
        }

        public int Update(Word item)
        {
            int count = 0;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                count = _wordDAO.Update(tm, item);

                tm.CommitTransaction();
            }
            catch (Exception)
            {
                tm.RollbackTransaction();

                throw;
            }

            return count;
        }

        public int Update(List<Word> items)
        {
            int count = 0;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                count = _wordDAO.Update(tm, items);

                tm.CommitTransaction();
            }
            catch (Exception)
            {
                tm.RollbackTransaction();

                throw;
            }

            return count;
        }

        public int UpdateGroupNo(int GroupNo, string whereClause, IList<string> values)
        {
            int count = 0;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                count = _wordDAO.UpdateGroupNo(tm, GroupNo, whereClause, values);

                tm.CommitTransaction();
            }
            catch (Exception)
            {
                tm.RollbackTransaction();

                throw;
            }

            return count;
        }


        public int UpdateCorrectnessCount(int GroupNo, int CorrectnessCount, string inClause, IList<string> names)
        {
            int count = 0;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                count = _wordDAO.UpdateCorrectnessCount(tm, GroupNo, CorrectnessCount, inClause, names);

                tm.CommitTransaction();
            }
            catch (Exception)
            {
                tm.RollbackTransaction();

                throw;
            }

            return count;
        }

        public int Delete(Word item)
        {
            int count = 0;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                _wordDAO.Delete(tm, item);

                tm.CommitTransaction();
            }
            catch (Exception)
            {
                tm.RollbackTransaction();

                throw;
            }

            return count;
        }

        public IList<Word> GetByLike(string text)
        {
            IList<Word> list = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                list = _wordDAO.GetByLike(tm, text);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
            }

            return list;
        }

        public Word GetByName(string text)
        {
            Word item = null;

            TransactionManager tm = new TransactionManager(DBNameConst.ConnectionStringName);

            try
            {
                tm.BeginTransaction();

                item = _wordDAO.GetByName(tm, text);

                tm.CommitTransaction();
            }
            catch (Exception ex)
            {
                tm.RollbackTransaction();

                throw ex;
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
                    if (_wordDAO != null)
                    {
                        _wordDAO.Dispose();
                    }
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
