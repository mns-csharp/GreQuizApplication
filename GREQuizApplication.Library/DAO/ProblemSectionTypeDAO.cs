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
    public class ProblemSectionTypeDAO
    {
		public int Delete(ITransactionManager tm, ProblemSectionType item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<ProblemSectionType> queryExecutor = new QueryExecutor<ProblemSectionType>(tm);

				queryExecutor.CreateSqlCommand(@"DELETE FROM ProblemSectionType");

				

				count = queryExecutor.ExecuteNonQuery();
			}
			catch
			{
				throw;
			}

			return count;
		}

		public IList<ProblemSectionType> Get(ITransactionManager tm)
		{
			IList<ProblemSectionType> list = null;

			IQueryExecutor<ProblemSectionType> queryExecutor = new QueryExecutor<ProblemSectionType>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, Name, Description FROM ProblemSectionType");

			ISafeDataReader dataReader = queryExecutor.ExecuteReader();

			try
			{
				ProblemSectionType item = null;

				while (dataReader.Read())
				{
					if (list == null)
					{
						list = new List<ProblemSectionType>();
					}

					item = new ProblemSectionType();

										item.ID = (int)dataReader.GetInt32("ID");
					item.Name = dataReader.GetString("Name");
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
			IQueryExecutor<ProblemSectionType> queryExecutor = new QueryExecutor<ProblemSectionType>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, Name, Description FROM ProblemSectionType");

			return queryExecutor.ExecuteDataSet();
		}

		public ProblemSectionType Get(ITransactionManager tm, int? id)
		{
			ProblemSectionType item = null;

			IQueryExecutor<ProblemSectionType> queryExecutor = new QueryExecutor<ProblemSectionType>(tm);

			queryExecutor.CreateSqlCommand(@"");

      queryExecutor.AddParameter((int)id, DbType.Int32);

      ISafeDataReader dataReader = queryExecutor.ExecuteReader();

      try
      {
      while (dataReader.Read())
      {
      if (item == null)
      {
      item = new ProblemSectionType();
					}

										item.ID = (int)dataReader.GetInt32("ID");
					item.Name = dataReader.GetString("Name");
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

		public int Save(ITransactionManager tm, ProblemSectionType item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<ProblemSectionType> queryExecutor = new QueryExecutor<ProblemSectionType>(tm);

				queryExecutor.CreateSqlCommand(@"INSERT INTO ProblemSectionType(ID, Name, Description) VALUES(@ID, @Name, @Description)");

				
				queryExecutor.AddParameter(item.ID, DbType.Int32);
				queryExecutor.AddParameter(item.Name, DbType.String);
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

		public int Update(ITransactionManager tm, ProblemSectionType item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<ProblemSectionType> queryExecutor = new QueryExecutor<ProblemSectionType>(tm);

				queryExecutor.CreateSqlCommand(@"UPDATE ProblemSectionType SET ID=@ID, Name=@Name, Description=@Description");

				queryExecutor.AddParameter(item.ID, DbType.Int32);
				queryExecutor.AddParameter(item.Name, DbType.String);
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

        
    }
}
