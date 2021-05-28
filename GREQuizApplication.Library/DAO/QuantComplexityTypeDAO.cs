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
    public class QuantComplexityTypeDAO
    {
		public int Delete(ITransactionManager tm, QuantComplexityType item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<QuantComplexityType> queryExecutor = new QueryExecutor<QuantComplexityType>(tm);

				queryExecutor.CreateSqlCommand(@"DELETE FROM QuantComplexityType WHERE ID=@ID");

				queryExecutor.AddParameter(item.ID, DbType.Int32);

				count = queryExecutor.ExecuteNonQuery();
			}
			catch
			{
				throw;
			}

			return count;
		}

		public IList<QuantComplexityType> Get(ITransactionManager tm)
		{
			IList<QuantComplexityType> list = null;

			IQueryExecutor<QuantComplexityType> queryExecutor = new QueryExecutor<QuantComplexityType>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, TypeName, Description FROM QuantComplexityType");

			ISafeDataReader dataReader = queryExecutor.ExecuteReader();

			try
			{
				QuantComplexityType item = null;

				while (dataReader.Read())
				{
					if (list == null)
					{
						list = new List<QuantComplexityType>();
					}

					item = new QuantComplexityType();

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
			IQueryExecutor<QuantComplexityType> queryExecutor = new QueryExecutor<QuantComplexityType>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, TypeName, Description FROM QuantComplexityType");

			return queryExecutor.ExecuteDataSet();
		}

		public QuantComplexityType Get(ITransactionManager tm, int? id)
		{
			QuantComplexityType item = null;

			IQueryExecutor<QuantComplexityType> queryExecutor = new QueryExecutor<QuantComplexityType>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, TypeName, Description FROM QuantComplexityType WHERE ID=@ID");

      queryExecutor.AddParameter((int)id, DbType.Int32);

      ISafeDataReader dataReader = queryExecutor.ExecuteReader();

      try
      {
      while (dataReader.Read())
      {
      if (item == null)
      {
      item = new QuantComplexityType();
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

		public int Save(ITransactionManager tm, QuantComplexityType item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<QuantComplexityType> queryExecutor = new QueryExecutor<QuantComplexityType>(tm);

				queryExecutor.CreateSqlCommand(@"INSERT INTO QuantComplexityType(ID, TypeName, Description) VALUES(@ID, @TypeName, @Description)");

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

		public int Update(ITransactionManager tm, QuantComplexityType item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<QuantComplexityType> queryExecutor = new QueryExecutor<QuantComplexityType>(tm);

				queryExecutor.CreateSqlCommand(@"UPDATE QuantComplexityType SET TypeName=@TypeName, Description=@Description WHERE ID=@ID");

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
