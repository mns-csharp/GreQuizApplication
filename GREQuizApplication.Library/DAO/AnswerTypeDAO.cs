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
    public class AnswerTypeDAO
    {
		public int Delete(ITransactionManager tm, AnswerType item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<AnswerType> queryExecutor = new QueryExecutor<AnswerType>(tm);

				queryExecutor.CreateSqlCommand(@"DELETE FROM AnswerType WHERE ID=@ID");

				queryExecutor.AddParameter(item.ID, DbType.Int32);

				count = queryExecutor.ExecuteNonQuery();
			}
			catch
			{
				throw;
			}

			return count;
		}

		public IList<AnswerType> Get(ITransactionManager tm)
		{
			IList<AnswerType> list = null;

			IQueryExecutor<AnswerType> queryExecutor = new QueryExecutor<AnswerType>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, TypeName, Description FROM AnswerType");

			ISafeDataReader dataReader = queryExecutor.ExecuteReader();

			try
			{
				AnswerType item = null;

				while (dataReader.Read())
				{
					if (list == null)
					{
						list = new List<AnswerType>();
					}

					item = new AnswerType();

					item.ID = dataReader.GetInt32("ID");
					item.TypeName = dataReader.GetString("TypeName");
					item.Description = dataReader.GetString("Description");


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
			IQueryExecutor<AnswerType> queryExecutor = new QueryExecutor<AnswerType>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, TypeName, Description FROM AnswerType");

			return queryExecutor.ExecuteDataSet();
		}

		public AnswerType Get(ITransactionManager tm, int? id)
		{
			AnswerType item = null;

			IQueryExecutor<AnswerType> queryExecutor = new QueryExecutor<AnswerType>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, TypeName, Description FROM AnswerType WHERE ID=@ID");

      queryExecutor.AddParameter((int)id, DbType.Int32);

      ISafeDataReader dataReader = queryExecutor.ExecuteReader();

      try
      {
      while (dataReader.Read())
      {
      if (item == null)
      {
      item = new AnswerType();
					}

					item.ID = dataReader.GetInt32("ID");
					item.TypeName = dataReader.GetString("TypeName");
					item.Description = dataReader.GetString("Description");

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

		public int Save(ITransactionManager tm, AnswerType item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<AnswerType> queryExecutor = new QueryExecutor<AnswerType>(tm);

				queryExecutor.CreateSqlCommand(@"INSERT INTO AnswerType(ID, TypeName, Description) VALUES(@ID, @TypeName, @Description)");

				queryExecutor.AddParameter(item.ID, DbType.Int32);
				queryExecutor.AddParameter(item.TypeName, DbType.String);
				queryExecutor.AddParameter(item.Description, DbType.String);

				count = queryExecutor.ExecuteNonQuery();

				string str = string.Empty;
			}
			catch
			{
				throw;
			}

			return count;
		}

		public int Update(ITransactionManager tm, AnswerType item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<AnswerType> queryExecutor = new QueryExecutor<AnswerType>(tm);

				queryExecutor.CreateSqlCommand(@"UPDATE AnswerType SET TypeName=@TypeName, Description=@Description WHERE ID=@ID");

				queryExecutor.AddParameter(item.TypeName, DbType.String);
				queryExecutor.AddParameter(item.Description, DbType.String);
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
