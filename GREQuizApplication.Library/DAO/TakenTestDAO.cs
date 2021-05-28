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
    public class TakenTestDAO
    {
		public int Delete(ITransactionManager tm, TakenTest item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<TakenTest> queryExecutor = new QueryExecutor<TakenTest>(tm);

				queryExecutor.CreateSqlCommand(@"DELETE FROM TakenTest WHERE ID=@ID");

				queryExecutor.AddParameter(item.ID, DbType.Int32);

				count = queryExecutor.ExecuteNonQuery();
			}
			catch
			{
				throw;
			}

			return count;
		}

		public IList<TakenTest> Get(ITransactionManager tm)
		{
			IList<TakenTest> list = null;

			IQueryExecutor<TakenTest> queryExecutor = new QueryExecutor<TakenTest>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, TestID, TestTakerID, DateOfTestTaken FROM TakenTest");

			ISafeDataReader dataReader = queryExecutor.ExecuteReader();

			try
			{
				TakenTest item = null;

				while (dataReader.Read())
				{
					if (list == null)
					{
						list = new List<TakenTest>();
					}

					item = new TakenTest();

					item.ID = dataReader.GetInt32("ID");
					item.TestID = (int)dataReader.GetInt32("TestID");
					item.TestTakerID = (int)dataReader.GetInt32("TestTakerID");
					item.DateOfTestTaken = (int)dataReader.GetInt32("DateOfTestTaken");


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
			IQueryExecutor<TakenTest> queryExecutor = new QueryExecutor<TakenTest>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, TestID, TestTakerID, DateOfTestTaken FROM TakenTest");

			return queryExecutor.ExecuteDataSet();
		}

		public TakenTest Get(ITransactionManager tm, int? id)
		{
			TakenTest item = null;

			IQueryExecutor<TakenTest> queryExecutor = new QueryExecutor<TakenTest>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, TestID, TestTakerID, DateOfTestTaken FROM TakenTest WHERE ID=@ID");

      queryExecutor.AddParameter((int)id, DbType.Int32);

      ISafeDataReader dataReader = queryExecutor.ExecuteReader();

      try
      {
      while (dataReader.Read())
      {
      if (item == null)
      {
      item = new TakenTest();
					}

					item.ID = dataReader.GetInt32("ID");
					item.TestID = (int)dataReader.GetInt32("TestID");
					item.TestTakerID = (int)dataReader.GetInt32("TestTakerID");
					item.DateOfTestTaken = (int)dataReader.GetInt32("DateOfTestTaken");

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

		public int Save(ITransactionManager tm, TakenTest item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<TakenTest> queryExecutor = new QueryExecutor<TakenTest>(tm);

				queryExecutor.CreateSqlCommand(@"INSERT INTO TakenTest(ID, TestID, TestTakerID, DateOfTestTaken) VALUES(@ID, @TestID, @TestTakerID, @DateOfTestTaken)");

				queryExecutor.AddParameter(item.ID, DbType.Int32);
				queryExecutor.AddParameter(item.TestID, DbType.Int32);
				queryExecutor.AddParameter(item.TestTakerID, DbType.Int32);
				queryExecutor.AddParameter(item.DateOfTestTaken, DbType.Int32);

				count = queryExecutor.ExecuteNonQuery();

				string str = string.Empty;
			}
			catch
			{
				throw;
			}

			return count;
		}

		public int Update(ITransactionManager tm, TakenTest item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<TakenTest> queryExecutor = new QueryExecutor<TakenTest>(tm);

				queryExecutor.CreateSqlCommand(@"UPDATE TakenTest SET TestID=@TestID, TestTakerID=@TestTakerID, DateOfTestTaken=@DateOfTestTaken WHERE ID=@ID");

				queryExecutor.AddParameter(item.TestID, DbType.Int32);
				queryExecutor.AddParameter(item.TestTakerID, DbType.Int32);
				queryExecutor.AddParameter(item.DateOfTestTaken, DbType.Int32);
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
