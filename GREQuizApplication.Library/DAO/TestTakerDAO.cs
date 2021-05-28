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
    public class TestTakerDAO
    {
		public int Delete(ITransactionManager tm, TestTaker item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<TestTaker> queryExecutor = new QueryExecutor<TestTaker>(tm);

				queryExecutor.CreateSqlCommand(@"DELETE FROM TestTaker WHERE ID=@ID");

				queryExecutor.AddParameter(item.ID, DbType.Int32);

				count = queryExecutor.ExecuteNonQuery();
			}
			catch
			{
				throw;
			}

			return count;
		}

		public IList<TestTaker> Get(ITransactionManager tm)
		{
			IList<TestTaker> list = null;

			IQueryExecutor<TestTaker> queryExecutor = new QueryExecutor<TestTaker>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, Usernameee, MobileNumber, EmailID, ResidenceAddress FROM TestTaker");

			ISafeDataReader dataReader = queryExecutor.ExecuteReader();

			try
			{
				TestTaker item = null;

				while (dataReader.Read())
				{
					if (list == null)
					{
						list = new List<TestTaker>();
					}

					item = new TestTaker();

					item.ID = dataReader.GetInt32("ID");
					item.Usernameee = dataReader.GetString("Usernameee");
					item.MobileNumber = dataReader.GetString("MobileNumber");
					item.EmailID = dataReader.GetString("EmailID");
					item.ResidenceAddress = dataReader.GetString("ResidenceAddress");


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
			IQueryExecutor<TestTaker> queryExecutor = new QueryExecutor<TestTaker>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, Usernameee, MobileNumber, EmailID, ResidenceAddress FROM TestTaker");

			return queryExecutor.ExecuteDataSet();
		}

		public TestTaker Get(ITransactionManager tm, int? id)
		{
			TestTaker item = null;

			IQueryExecutor<TestTaker> queryExecutor = new QueryExecutor<TestTaker>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, Usernameee, MobileNumber, EmailID, ResidenceAddress FROM TestTaker WHERE ID=@ID");

      queryExecutor.AddParameter((int)id, DbType.Int32);

      ISafeDataReader dataReader = queryExecutor.ExecuteReader();

      try
      {
      while (dataReader.Read())
      {
      if (item == null)
      {
      item = new TestTaker();
					}

					item.ID = dataReader.GetInt32("ID");
					item.Usernameee = dataReader.GetString("Usernameee");
					item.MobileNumber = dataReader.GetString("MobileNumber");
					item.EmailID = dataReader.GetString("EmailID");
					item.ResidenceAddress = dataReader.GetString("ResidenceAddress");

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

		public int Save(ITransactionManager tm, TestTaker item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<TestTaker> queryExecutor = new QueryExecutor<TestTaker>(tm);

				queryExecutor.CreateSqlCommand(@"INSERT INTO TestTaker(ID, Usernameee, MobileNumber, EmailID, ResidenceAddress) VALUES(@ID, @Usernameee, @MobileNumber, @EmailID, @ResidenceAddress)");

				queryExecutor.AddParameter(item.ID, DbType.Int32);
				queryExecutor.AddParameter(item.Usernameee, DbType.String);
				queryExecutor.AddParameter(item.MobileNumber, DbType.String);
				queryExecutor.AddParameter(item.EmailID, DbType.String);
				queryExecutor.AddParameter(item.ResidenceAddress, DbType.String);

				count = queryExecutor.ExecuteNonQuery();

				string str = string.Empty;
			}
			catch
			{
				throw;
			}

			return count;
		}

		public int Update(ITransactionManager tm, TestTaker item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<TestTaker> queryExecutor = new QueryExecutor<TestTaker>(tm);

				queryExecutor.CreateSqlCommand(@"UPDATE TestTaker SET Usernameee=@Usernameee, MobileNumber=@MobileNumber, EmailID=@EmailID, ResidenceAddress=@ResidenceAddress WHERE ID=@ID");

				queryExecutor.AddParameter(item.Usernameee, DbType.String);
				queryExecutor.AddParameter(item.MobileNumber, DbType.String);
				queryExecutor.AddParameter(item.EmailID, DbType.String);
				queryExecutor.AddParameter(item.ResidenceAddress, DbType.String);
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
