using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Simple.Framework;
using System.Data.SqlTypes;
using QuizApplicationLibrary.POCO;

namespace QuizApplicationLibrary.DAO
{
    public class QuantTestDAO
    {
		public int Delete(ITransactionManager tm, QuantTest item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<QuantTest> queryExecutor = new QueryExecutor<QuantTest>(tm);

				queryExecutor.CreateSqlCommand(@"DELETE FROM QuantTest WHERE ID=@ID");

				queryExecutor.AddParameter(item.ID, DbType.Int32);

				count = queryExecutor.ExecuteNonQuery();
			}
			catch
			{
				throw;
			}

			return count;
		}

        

		public IList<QuantTest> Get(ITransactionManager tm)
		{
			IList<QuantTest> list = null;

			IQueryExecutor<QuantTest> queryExecutor = new QueryExecutor<QuantTest>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, CreateDate, CreatedBy, TotalNumberOfQuestions FROM QuantTest");

			ISafeDataReader dataReader = queryExecutor.ExecuteReader();

			try
			{
				QuantTest item = null;

				while (dataReader.Read())
				{
					if (list == null)
					{
						list = new List<QuantTest>();
					}

					item = new QuantTest();

					item.ID = dataReader.GetInt32("ID");
					item.CreateDate = (DateTime)dataReader.GetDateTime("CreateDate");
					item.CreatedBy = dataReader.GetString("CreatedBy");
					item.TotalNumberOfQuestions = (int)dataReader.GetInt32("TotalNumberOfQuestions");


					list.Add(item);
				}

				dataReader.Close();
			}
			catch
			{
				if (dataReader != null)
				{
					dataReader.Close();
					dataReader = null;
				}

				throw;
			}

			return list;
		}

		public DataSet GetDataSet(ITransactionManager tm)
		{
			IQueryExecutor<QuantTest> queryExecutor = new QueryExecutor<QuantTest>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, CreateDate, CreatedBy, TotalNumberOfQuestions FROM QuantTest");

			return queryExecutor.ExecuteDataSet();
		}

        public QuantTest Get(ITransactionManager tm, int? id)
        {
            QuantTest item = null;

            IQueryExecutor<QuantTest> queryExecutor = new QueryExecutor<QuantTest>(tm);

            queryExecutor.CreateSqlCommand(@"SELECT ID, CreateDate, CreatedBy, TotalNumberOfQuestions FROM QuantTest WHERE ID=@ID");

            queryExecutor.AddParameter((int)id, DbType.Int32);

            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

            try
            {
                while (dataReader.Read())
                {
                    if (item == null)
                    {
                        item = new QuantTest();
                    }

                    item.ID = dataReader.GetInt32("ID");
                    item.CreateDate = (DateTime)dataReader.GetDateTime("CreateDate");
                    item.CreatedBy = dataReader.GetString("CreatedBy");
                    item.TotalNumberOfQuestions = (int)dataReader.GetInt32("TotalNumberOfQuestions");

                }

                dataReader.Close();
            }
            catch
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    dataReader = null;
                }

                throw;
            }

            return item;
        }

		public int Save(ITransactionManager tm, QuantTest item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<QuantTest> queryExecutor = new QueryExecutor<QuantTest>(tm);

				queryExecutor.CreateSqlCommand(@"INSERT INTO QuantTest(ID, CreateDate, CreatedBy, TotalNumberOfQuestions) VALUES(@ID, @CreateDate, @CreatedBy, @TotalNumberOfQuestions)");

				queryExecutor.AddParameter(item.ID, DbType.Int32);
				queryExecutor.AddParameter(item.CreateDate, DbType.DateTime);
				queryExecutor.AddParameter(item.CreatedBy, DbType.String);
				queryExecutor.AddParameter(item.TotalNumberOfQuestions, DbType.Int32);

				count = queryExecutor.ExecuteNonQuery();

				string str = string.Empty;
			}
			catch
			{
				throw;
			}

			return count;
		}

		public int Update(ITransactionManager tm, QuantTest item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<QuantTest> queryExecutor = new QueryExecutor<QuantTest>(tm);

				queryExecutor.CreateSqlCommand(@"UPDATE QuantTest SET CreateDate=@CreateDate, CreatedBy=@CreatedBy, TotalNumberOfQuestions=@TotalNumberOfQuestions WHERE ID=@ID");

				queryExecutor.AddParameter(item.CreateDate, DbType.DateTime);
				queryExecutor.AddParameter(item.CreatedBy, DbType.String);
				queryExecutor.AddParameter(item.TotalNumberOfQuestions, DbType.Int32);
				queryExecutor.AddParameter(item.ID, DbType.Int32);

				count = queryExecutor.ExecuteNonQuery();

				string str = string.Empty;
			}
			catch
			{
				throw;
			}

			return count;
		}

        
    }
}
