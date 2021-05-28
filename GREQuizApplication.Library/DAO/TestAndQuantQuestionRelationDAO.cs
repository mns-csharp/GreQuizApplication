using QuizApplicationLibrary.POCO;
using Simple.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuizApplicationLibrary.DAO
{
    public class TestAndQuantQuestionRelationDAO
    {
        public int DeleteByQuantTestID(TransactionManager tm, QuantTest item)
        {
            int count = -1;

            try
            {
                IQueryExecutor<QuantitativeProblem> queryExecutor = new QueryExecutor<QuantitativeProblem>(tm);

                queryExecutor.CreateSqlCommand(@"DELETE FROM TestAndQuantQuestionRelation WHERE TestID=@TestID");

                queryExecutor.AddParameter(item.ID, DbType.Int32);

                count = queryExecutor.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }

            return count;
        }

        public IList<QuantitativeProblem> GetByTestID(TransactionManager tm, int? id)
        {
            IList<QuantitativeProblem> list = null;

            IQueryExecutor<QuantitativeProblem> queryExecutor = new QueryExecutor<QuantitativeProblem>(tm);

            queryExecutor.CreateSqlCommand(@"select 
	                                            q.ID, 
	                                            q.ProblemText, 
	                                            q.SolutionText,
	                                            q.ProblemPhoto,
	                                            q.SolutionPhoto,
	                                            q.AnswerText,
	                                            q.QuantitativeProblemType,
	                                            q.AnswerType,
	                                            q.ContentType 
                                            from 
	                                            QuantitativeProblem q, 
	                                            TestAndQuantQuestionRelation t
                                            where 
	                                            q.ID = t.TestID AND
	                                            t.ID = @TestID");

            queryExecutor.AddParameter(id, DbType.Int32);

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

        public int Save(TransactionManager tm, int? ID, QuantitativeProblem question)
        {
            int count = -1;

            try
            {
                IQueryExecutor<QuantitativeProblem> queryExecutor = new QueryExecutor<QuantitativeProblem>(tm);

                queryExecutor.CreateSqlCommand(@"INSERT INTO 
                                                    TestAndQuantQuestionRelation(TestID, QuantQuestionID) 
                                                 VALUES
                                                    (@TestID, @QuantQuestionID)");

                queryExecutor.AddParameter(ID, DbType.Int32);
                queryExecutor.AddParameter(question.ID, DbType.Int32);

                count = queryExecutor.ExecuteNonQuery();

                string str = string.Empty;
            }
            catch
            {
                throw;
            }

            return count;
        }

        public int Save(TransactionManager tm, int? ID, IList<QuantitativeProblem> collection)
        {
            int count = 0;

            foreach (QuantitativeProblem item in collection)
            {
                count = count + this.Save(tm, ID, item);
            }

            return count;
        }
    }
}
