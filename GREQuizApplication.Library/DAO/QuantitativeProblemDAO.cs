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
    public class QuantitativeProblemDAO
    {
		public int Delete(ITransactionManager tm, QuantitativeProblem item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<QuantitativeProblem> queryExecutor = new QueryExecutor<QuantitativeProblem>(tm);

				queryExecutor.CreateSqlCommand(@"DELETE FROM QuantitativeProblem WHERE ID=@ID");

				queryExecutor.AddParameter(item.ID, DbType.Int32);

				count = queryExecutor.ExecuteNonQuery();
			}
			catch
			{
				throw;
			}

			return count;
		}

		public IList<QuantitativeProblem> Get(ITransactionManager tm)
		{
			IList<QuantitativeProblem> list = null;

			IQueryExecutor<QuantitativeProblem> queryExecutor = new QueryExecutor<QuantitativeProblem>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, ProblemText, SolutionText, ProblemPhoto, SolutionPhoto, AnswerText, QuantitativeProblemType, AnswerType, ContentType FROM QuantitativeProblem");

			ISafeDataReader dataReader = queryExecutor.ExecuteReader();

			try
			{
				QuantitativeProblem item = null;

				while (dataReader.Read())
				{
					if (list == null)
					{
						list = new List<QuantitativeProblem>();
					}

					item = new QuantitativeProblem();

					item.ID = dataReader.GetInt32("ID");
					item.ProblemText = dataReader.GetString("ProblemText");
					item.SolutionText = dataReader.GetString("SolutionText");
					item.ProblemPhoto = dataReader.GetByteArray("ProblemPhoto");
					item.SolutionPhoto = dataReader.GetByteArray("SolutionPhoto");
					item.AnswerText = dataReader.GetString("AnswerText");
					item.QuantitativeProblemType = EnumConverter<QuantitativeProblemTypeEnum>.ToEnum((int)dataReader.GetInt32("QuantitativeProblemType"));
					item.AnswerType = EnumConverter<AnswerTypeEnum>.ToEnum((int)dataReader.GetInt32("AnswerType"));
                    item.ContentType = EnumConverter<ContentTypeEnum>.ToEnum((int)dataReader.GetInt32("ContentType"));
                    
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
			IQueryExecutor<QuantitativeProblem> queryExecutor = new QueryExecutor<QuantitativeProblem>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, ProblemText, SolutionText, ProblemPhoto, SolutionPhoto, AnswerText, QuantitativeProblemType, AnswerType, ContentType FROM QuantitativeProblem");

			return queryExecutor.ExecuteDataSet();
		}

		public QuantitativeProblem Get(ITransactionManager tm, int? id)
		{
			QuantitativeProblem item = null;

			IQueryExecutor<QuantitativeProblem> queryExecutor = new QueryExecutor<QuantitativeProblem>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT ID, ProblemText, SolutionText, ProblemPhoto, SolutionPhoto, AnswerText, QuantitativeProblemType, AnswerType, ContentType FROM QuantitativeProblem WHERE ID=@ID");

      queryExecutor.AddParameter((int)id, DbType.Int32);

      ISafeDataReader dataReader = queryExecutor.ExecuteReader();

      try
      {
      while (dataReader.Read())
      {
      if (item == null)
      {
      item = new QuantitativeProblem();
					}

					item.ID = dataReader.GetInt32("ID");
					item.ProblemText = dataReader.GetString("ProblemText");
					item.SolutionText = dataReader.GetString("SolutionText");
					item.ProblemPhoto = dataReader.GetByteArray("ProblemPhoto");
					item.SolutionPhoto = dataReader.GetByteArray("SolutionPhoto");
					item.AnswerText = dataReader.GetString("AnswerText");
					item.QuantitativeProblemType = EnumConverter<QuantitativeProblemTypeEnum>.ToEnum((int)dataReader.GetInt32("QuantitativeProblemType"));
                    item.AnswerType = EnumConverter<AnswerTypeEnum>.ToEnum((int)dataReader.GetInt32("AnswerType"));
                    item.ContentType = EnumConverter<ContentTypeEnum>.ToEnum((int)dataReader.GetInt32("ContentType"));

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

		public int Save(ITransactionManager tm, QuantitativeProblem item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<QuantitativeProblem> queryExecutor = new QueryExecutor<QuantitativeProblem>(tm);

				queryExecutor.CreateSqlCommand(@"INSERT INTO QuantitativeProblem(ID, ProblemText, SolutionText, ProblemPhoto, SolutionPhoto, AnswerText, QuantitativeProblemType, AnswerType, ContentType) VALUES(@ID, @ProblemText, @SolutionText, @ProblemPhoto, @SolutionPhoto, @AnswerText, @QuantitativeProblemType, @AnswerType, @ContentType)");

				queryExecutor.AddParameter(item.ID, DbType.Int32);
				queryExecutor.AddParameter(item.ProblemText, DbType.String);
				queryExecutor.AddParameter(item.SolutionText, DbType.String);
				queryExecutor.AddParameter(item.ProblemPhoto, DbType.Binary);
				queryExecutor.AddParameter(item.SolutionPhoto, DbType.Binary);
				queryExecutor.AddParameter(item.AnswerText, DbType.String);
                queryExecutor.AddParameter(item.QuantitativeProblemType, DbType.Int32);
				queryExecutor.AddParameter(item.AnswerType, DbType.Int32);
				queryExecutor.AddParameter(item.ContentType, DbType.Int32);

				count = queryExecutor.ExecuteNonQuery();

				string str = string.Empty;
			}
			catch
			{
				throw;
			}

			return count;
		}

		public int Update(ITransactionManager tm, QuantitativeProblem item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<QuantitativeProblem> queryExecutor = new QueryExecutor<QuantitativeProblem>(tm);

				queryExecutor.CreateSqlCommand(@"UPDATE QuantitativeProblem SET ProblemText=@ProblemText, SolutionText=@SolutionText, ProblemPhoto=@ProblemPhoto, SolutionPhoto=@SolutionPhoto, AnswerText=@AnswerText, QuantitativeProblemType=@QuantitativeProblemType, AnswerType=@AnswerType, ContentType=@ContentType WHERE ID=@ID");

				queryExecutor.AddParameter(item.ProblemText, DbType.String);
				queryExecutor.AddParameter(item.SolutionText, DbType.String);
				queryExecutor.AddParameter(item.ProblemPhoto, DbType.Binary);
				queryExecutor.AddParameter(item.SolutionPhoto, DbType.Binary);
				queryExecutor.AddParameter(item.AnswerText, DbType.String);
				queryExecutor.AddParameter(item.QuantitativeProblemType, DbType.Int32);
				queryExecutor.AddParameter(item.AnswerType, DbType.Int32);
				queryExecutor.AddParameter(item.ContentType, DbType.Int32);
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
