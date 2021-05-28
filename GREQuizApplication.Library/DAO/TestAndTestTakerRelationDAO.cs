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
    public class TestAndTestTakerRelationDAO
    {
		public int Delete(ITransactionManager tm, TestAndTestTakerRelation item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<TestAndTestTakerRelation> queryExecutor = new QueryExecutor<TestAndTestTakerRelation>(tm);

				queryExecutor.CreateSqlCommand(@"DELETE FROM TestAndTestTakerRelation");

				

				count = queryExecutor.ExecuteNonQuery();
			}
			catch
			{
				throw;
			}

			return count;
		}

		public IList<TestAndTestTakerRelation> Get(ITransactionManager tm)
		{
			IList<TestAndTestTakerRelation> list = null;

			IQueryExecutor<TestAndTestTakerRelation> queryExecutor = new QueryExecutor<TestAndTestTakerRelation>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT TestID, TestTakerID FROM TestAndTestTakerRelation");

			ISafeDataReader dataReader = queryExecutor.ExecuteReader();

			try
			{
				TestAndTestTakerRelation item = null;

				while (dataReader.Read())
				{
					if (list == null)
					{
						list = new List<TestAndTestTakerRelation>();
					}

					item = new TestAndTestTakerRelation();

										item.TestID = (int)dataReader.GetInt32("TestID");
					item.TestTakerID = (int)dataReader.GetInt32("TestTakerID");


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
			IQueryExecutor<TestAndTestTakerRelation> queryExecutor = new QueryExecutor<TestAndTestTakerRelation>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT TestID, TestTakerID FROM TestAndTestTakerRelation");

			return queryExecutor.ExecuteDataSet();
		}

		public TestAndTestTakerRelation Get(ITransactionManager tm, int? id)
		{
			TestAndTestTakerRelation item = null;

			IQueryExecutor<TestAndTestTakerRelation> queryExecutor = new QueryExecutor<TestAndTestTakerRelation>(tm);

			queryExecutor.CreateSqlCommand(@"");

      queryExecutor.AddParameter((int)id, DbType.Int32);

      ISafeDataReader dataReader = queryExecutor.ExecuteReader();

      try
      {
      while (dataReader.Read())
      {
      if (item == null)
      {
      item = new TestAndTestTakerRelation();
					}

										item.TestID = (int)dataReader.GetInt32("TestID");
					item.TestTakerID = (int)dataReader.GetInt32("TestTakerID");

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

		public int Save(ITransactionManager tm, TestAndTestTakerRelation item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<TestAndTestTakerRelation> queryExecutor = new QueryExecutor<TestAndTestTakerRelation>(tm);

				queryExecutor.CreateSqlCommand(@"INSERT INTO TestAndTestTakerRelation(TestID, TestTakerID) VALUES(@TestID, @TestTakerID)");

				
				queryExecutor.AddParameter(item.TestID, DbType.Int32);
				queryExecutor.AddParameter(item.TestTakerID, DbType.Int32);

				count = queryExecutor.ExecuteNonQuery();

				string str = string.Empty;
			}
			catch
			{
				throw;
			}

			return count;
		}

		public int Update(ITransactionManager tm, TestAndTestTakerRelation item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<TestAndTestTakerRelation> queryExecutor = new QueryExecutor<TestAndTestTakerRelation>(tm);

				queryExecutor.CreateSqlCommand(@"UPDATE TestAndTestTakerRelation SET TestID=@TestID, TestTakerID=@TestTakerID");

				queryExecutor.AddParameter(item.TestID, DbType.Int32);
				queryExecutor.AddParameter(item.TestTakerID, DbType.Int32);
				

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
