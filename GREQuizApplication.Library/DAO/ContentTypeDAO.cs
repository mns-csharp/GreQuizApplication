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
    public class ContentTypeDAO
    {
		public int Delete(ITransactionManager tm, ContentType item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<ContentType> queryExecutor = new QueryExecutor<ContentType>(tm);

				queryExecutor.CreateSqlCommand(@"DELETE FROM ContentType WHERE ID=@ID");

				queryExecutor.AddParameter(item.ID, DbType.Int32);

				count = queryExecutor.ExecuteNonQuery();
			}
			catch
			{
				throw;
			}

			return count;
		}

		public IList<ContentType> Get(ITransactionManager tm)
		{
			IList<ContentType> list = null;

			IQueryExecutor<ContentType> queryExecutor = new QueryExecutor<ContentType>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, TypeName, Description FROM ContentType");

			ISafeDataReader dataReader = queryExecutor.ExecuteReader();

			try
			{
				ContentType item = null;

				while (dataReader.Read())
				{
					if (list == null)
					{
						list = new List<ContentType>();
					}

					item = new ContentType();

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
			IQueryExecutor<ContentType> queryExecutor = new QueryExecutor<ContentType>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, TypeName, Description FROM ContentType");

			return queryExecutor.ExecuteDataSet();
		}

		public ContentType Get(ITransactionManager tm, int? id)
		{
			ContentType item = null;

			IQueryExecutor<ContentType> queryExecutor = new QueryExecutor<ContentType>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, TypeName, Description FROM ContentType WHERE ID=@ID");

      queryExecutor.AddParameter((int)id, DbType.Int32);

      ISafeDataReader dataReader = queryExecutor.ExecuteReader();

      try
      {
      while (dataReader.Read())
      {
      if (item == null)
      {
      item = new ContentType();
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

		public int Save(ITransactionManager tm, ContentType item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<ContentType> queryExecutor = new QueryExecutor<ContentType>(tm);

				queryExecutor.CreateSqlCommand(@"INSERT INTO ContentType(ID, TypeName, Description) VALUES(@ID, @TypeName, @Description)");

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

		public int Update(ITransactionManager tm, ContentType item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<ContentType> queryExecutor = new QueryExecutor<ContentType>(tm);

				queryExecutor.CreateSqlCommand(@"UPDATE ContentType SET TypeName=@TypeName, Description=@Description WHERE ID=@ID");

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
