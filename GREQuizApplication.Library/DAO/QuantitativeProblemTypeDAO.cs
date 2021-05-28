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
    public class QuantitativeProblemTypeDAO
    {
		public int Delete(ITransactionManager tm, QuantitativeProblemType item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<QuantitativeProblemType> queryExecutor = new QueryExecutor<QuantitativeProblemType>(tm);

				queryExecutor.CreateSqlCommand(@"DELETE FROM QuantitativeProblemType WHERE ID=@ID");

				queryExecutor.AddParameter(item.ID, DbType.Int32);

				count = queryExecutor.ExecuteNonQuery();
			}
			catch
			{
				throw;
			}

			return count;
		}

		public IList<QuantitativeProblemType> Get(ITransactionManager tm)
		{
			IList<QuantitativeProblemType> list = null;

			IQueryExecutor<QuantitativeProblemType> queryExecutor = new QueryExecutor<QuantitativeProblemType>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, TypeName, Description FROM QuantitativeProblemType");

			ISafeDataReader dataReader = queryExecutor.ExecuteReader();

			try
			{
				QuantitativeProblemType item = null;

				while (dataReader.Read())
				{
					if (list == null)
					{
						list = new List<QuantitativeProblemType>();
					}

					item = new QuantitativeProblemType();

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
			IQueryExecutor<QuantitativeProblemType> queryExecutor = new QueryExecutor<QuantitativeProblemType>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, TypeName, Description FROM QuantitativeProblemType");

			return queryExecutor.ExecuteDataSet();
		}

		public QuantitativeProblemType Get(ITransactionManager tm, int? id)
		{
			QuantitativeProblemType item = null;

			IQueryExecutor<QuantitativeProblemType> queryExecutor = new QueryExecutor<QuantitativeProblemType>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, TypeName, Description FROM QuantitativeProblemType WHERE ID=@ID");

      queryExecutor.AddParameter((int)id, DbType.Int32);

      ISafeDataReader dataReader = queryExecutor.ExecuteReader();

      try
      {
      while (dataReader.Read())
      {
      if (item == null)
      {
      item = new QuantitativeProblemType();
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

		public int Save(ITransactionManager tm, QuantitativeProblemType item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<QuantitativeProblemType> queryExecutor = new QueryExecutor<QuantitativeProblemType>(tm);

				queryExecutor.CreateSqlCommand(@"INSERT INTO QuantitativeProblemType(ID, TypeName, Description) VALUES(@ID, @TypeName, @Description)");

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

		public int Update(ITransactionManager tm, QuantitativeProblemType item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<QuantitativeProblemType> queryExecutor = new QueryExecutor<QuantitativeProblemType>(tm);

				queryExecutor.CreateSqlCommand(@"UPDATE QuantitativeProblemType SET TypeName=@TypeName, Description=@Description WHERE ID=@ID");

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
