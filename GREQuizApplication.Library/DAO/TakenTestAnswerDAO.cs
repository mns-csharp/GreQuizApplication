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
    public class TakenTestAnswerDAO
    {
		public int Delete(ITransactionManager tm, TakenTestAnswer item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<TakenTestAnswer> queryExecutor = new QueryExecutor<TakenTestAnswer>(tm);

				queryExecutor.CreateSqlCommand(@"DELETE FROM TakenTestAnswer");

				

				count = queryExecutor.ExecuteNonQuery();
			}
			catch
			{
				throw;
			}

			return count;
		}

		public IList<TakenTestAnswer> Get(ITransactionManager tm)
		{
			IList<TakenTestAnswer> list = null;

			IQueryExecutor<TakenTestAnswer> queryExecutor = new QueryExecutor<TakenTestAnswer>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT TakenTestID, QuantQuestionID, TakersWrittenAnswer FROM TakenTestAnswer");

			ISafeDataReader dataReader = queryExecutor.ExecuteReader();

			try
			{
				TakenTestAnswer item = null;

				while (dataReader.Read())
				{
					if (list == null)
					{
						list = new List<TakenTestAnswer>();
					}

					item = new TakenTestAnswer();

										item.TakenTestID = (int)dataReader.GetInt32("TakenTestID");
					item.QuantQuestionID = (int)dataReader.GetInt32("QuantQuestionID");
					item.TakersWrittenAnswer = dataReader.GetString("TakersWrittenAnswer");


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
			IQueryExecutor<TakenTestAnswer> queryExecutor = new QueryExecutor<TakenTestAnswer>(tm);

			queryExecutor.CreateSqlCommand(@"SELECT TakenTestID, QuantQuestionID, TakersWrittenAnswer FROM TakenTestAnswer");

			return queryExecutor.ExecuteDataSet();
		}

		public TakenTestAnswer Get(ITransactionManager tm, int? id)
		{
			TakenTestAnswer item = null;

			IQueryExecutor<TakenTestAnswer> queryExecutor = new QueryExecutor<TakenTestAnswer>(tm);

			queryExecutor.CreateSqlCommand(@"");

      queryExecutor.AddParameter((int)id, DbType.Int32);

      ISafeDataReader dataReader = queryExecutor.ExecuteReader();

      try
      {
      while (dataReader.Read())
      {
      if (item == null)
      {
      item = new TakenTestAnswer();
					}

										item.TakenTestID = (int)dataReader.GetInt32("TakenTestID");
					item.QuantQuestionID = (int)dataReader.GetInt32("QuantQuestionID");
					item.TakersWrittenAnswer = dataReader.GetString("TakersWrittenAnswer");

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

		public int Save(ITransactionManager tm, TakenTestAnswer item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<TakenTestAnswer> queryExecutor = new QueryExecutor<TakenTestAnswer>(tm);

				queryExecutor.CreateSqlCommand(@"INSERT INTO TakenTestAnswer(TakenTestID, QuantQuestionID, TakersWrittenAnswer) VALUES(@TakenTestID, @QuantQuestionID, @TakersWrittenAnswer)");

				
				queryExecutor.AddParameter(item.TakenTestID, DbType.Int32);
				queryExecutor.AddParameter(item.QuantQuestionID, DbType.Int32);
				queryExecutor.AddParameter(item.TakersWrittenAnswer, DbType.String);

				count = queryExecutor.ExecuteNonQuery();

				string str = string.Empty;
			}
			catch
			{
				throw;
			}

			return count;
		}

		public int Update(ITransactionManager tm, TakenTestAnswer item)
		{
			int count = -1;

			try
			{
				IQueryExecutor<TakenTestAnswer> queryExecutor = new QueryExecutor<TakenTestAnswer>(tm);

				queryExecutor.CreateSqlCommand(@"UPDATE TakenTestAnswer SET TakenTestID=@TakenTestID, QuantQuestionID=@QuantQuestionID, TakersWrittenAnswer=@TakersWrittenAnswer");

				queryExecutor.AddParameter(item.TakenTestID, DbType.Int32);
				queryExecutor.AddParameter(item.QuantQuestionID, DbType.Int32);
				queryExecutor.AddParameter(item.TakersWrittenAnswer, DbType.String);
				

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
