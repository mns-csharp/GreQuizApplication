using QuizApplicationLibrary.POCO;
using Simple.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuizApplicationLibrary.DAO
{
    public class WordDAO : IDisposable
    {
        private Word MapItem(ISafeDataReader dataReader)
        {
            Word item = new Word();
            item.ID = (int)dataReader.GetInt32("ID");
            Nullable<int> groupno = dataReader.GetInt32("GroupNo");
            item.GroupNo = groupno;
            item.Name = dataReader.GetString("Name");
            item.Meaning = dataReader.GetString("Meaning");
            item.Hint = dataReader.GetString("Hint");

            item.Synonyms = dataReader.GetString("Synonyms");
            item.Etymology = dataReader.GetString("Etymology");
            item.ExampleEnglishSentence = dataReader.GetString("ExampleEnglishSentence");
            item.CorrectnessCount = (int)dataReader.GetInt32("CorrectnessCount");
            item.Photo = dataReader.GetByteArray("Photo");
            
            return item;
        }

        public Word Get(ITransactionManager tm, int? id)
        {
            Word item = null;

            IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);
            queryExecutor.CreateSqlCommand(@"select * from Word where id=@id");
            queryExecutor.AddParameter(id, DbType.Int32);

            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

            try
            {
                while (dataReader.Read())
                {
                    item = MapItem(dataReader);
                }

                dataReader.Close();
            }
            catch (Exception)
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

        public IList<Word> Get(ITransactionManager tm)
        {
            IList<Word> list = null;

            IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

            queryExecutor.CreateSqlCommand(@"select 
                                                 ID, GroupNo, Name, Meaning, Etymology, CorrectnessCount
                                             from 
                                                 Word 
                                             order by Name");

            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

            try
            {
                Word item = null;

                while (dataReader.Read())
                {
                    if (list == null)
                    {
                        list = new List<Word>();
                    }
                    item = new Word();
                    item.ID = (int)dataReader.GetInt32("ID");
                    Nullable<int> groupno = dataReader.GetInt32("GroupNo");
                    item.GroupNo = groupno;
                    item.Name = dataReader.GetString("Name");
                    item.Meaning = dataReader.GetString("Meaning");
                    item.Etymology = dataReader.GetString("Etymology");
                    item.CorrectnessCount = (int)dataReader.GetInt32("CorrectnessCount");

                    //item.Synonyms = dataReader.GetString("Synonyms");
                    //item.Etymology = dataReader.GetString("Etymology");
                    //item.ExampleEnglishSentence = dataReader.GetString("ExampleEnglishSentence");                    
                    //item.Photo = dataReader.GetByteArray("Photo");

                    list.Add(item);
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    dataReader = null;
                }

                throw ex;
            }

            return list;
        }


        public DataSet GetDataSet(ITransactionManager tm)
        {
            IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

            queryExecutor.CreateSqlCommand(@"select * from Word order by Name");

            return queryExecutor.ExecuteDataSet();
        }


        public IDictionary<int, Word> GetDictionary(ITransactionManager tm)
        {
            IDictionary<int, Word> list = null;

            IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

            queryExecutor.CreateSqlCommand(@"select * from Word order by Name");

            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

            try
            {
                Word item = null;

                while (dataReader.Read())
                {
                    if (list == null)
                    {
                        list = new Dictionary<int, Word>();
                    }

                    item = MapItem(dataReader);

                    list.Add(item.ID.Value, item);
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    dataReader = null;
                }

                throw ex;
            }

            return list;
        }


        public IList<Word> GetByCorrectnessBelow(ITransactionManager tm, int corrctnessCount)
        {
            IList<Word> list = null;

            IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

            queryExecutor.CreateSqlCommand(@"SELECT 
                                                 ID, GroupNo, Name, Meaning, Etymology, CorrectnessCount
                                            FROM Word
                                            Where CorrectnessCount < @CorrectnessCount
                                            ORDER BY [Name]");

            queryExecutor.AddParameter(corrctnessCount, DbType.Int32);

            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

            try
            {
                Word item = null;

                while (dataReader.Read())
                {
                    if (list == null)
                    {
                        list = new List<Word>();
                    }
                    item = new Word();
                    item.ID = (int)dataReader.GetInt32("ID");
                    Nullable<int> groupno = dataReader.GetInt32("GroupNo");
                    item.GroupNo = groupno;
                    item.Name = dataReader.GetString("Name");
                    item.Meaning = dataReader.GetString("Meaning");
                    item.Etymology = dataReader.GetString("Etymology");
                    item.CorrectnessCount = (int)dataReader.GetInt32("CorrectnessCount");

                    //item.Synonyms = dataReader.GetString("Synonyms");
                    //item.Etymology = dataReader.GetString("Etymology");
                    //item.ExampleEnglishSentence = dataReader.GetString("ExampleEnglishSentence");                    
                    //item.Photo = dataReader.GetByteArray("Photo");

                    list.Add(item);
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    dataReader = null;
                }

                throw ex;
            }

            return list;
        }


        public IList<Word> GetByCorrectnessBelow(ITransactionManager tm, int corrctnessCount, string like)
        {
            IList<Word> list = null;

            IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

            queryExecutor.CreateSqlCommand(@"SELECT *
                                            FROM Word
                                            Where CorrectnessCount < @CorrectnessCount
                                            AND Name LIKE '" + like + @"%'
                                            ORDER BY [Name]");

            queryExecutor.AddParameter(corrctnessCount, DbType.Int32);

            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

            try
            {
                Word item = null;

                while (dataReader.Read())
                {
                    if (list == null)
                    {
                        list = new List<Word>();
                    }
                    item = new Word();
                    item.ID = (int)dataReader.GetInt32("ID");
                    Nullable<int> groupno = dataReader.GetInt32("GroupNo");
                    item.GroupNo = groupno;
                    item.Name = dataReader.GetString("Name");
                    item.Meaning = dataReader.GetString("Meaning");
                    item.CorrectnessCount = (int)dataReader.GetInt32("CorrectnessCount");

                    item.Synonyms = dataReader.GetString("Synonyms");
                    item.Etymology = dataReader.GetString("Etymology");
                    item.ExampleEnglishSentence = dataReader.GetString("ExampleEnglishSentence");
                    item.Photo = dataReader.GetByteArray("Photo");

                    list.Add(item);
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    dataReader = null;
                }

                throw ex;
            }

            return list;
        }


        public IList<Word> GetByCorrectnessBelow(ITransactionManager tm, int corrctnessCount, int group)
        {
            IList<Word> list = null;

            IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

            queryExecutor.CreateSqlCommand(@"SELECT 
                                                ID, GroupNo, Name, Meaning, Etymology, CorrectnessCount
                                            FROM Word
                                            Where CorrectnessCount < @CorrectnessCount
                                            AND GroupNo = @GroupNo
                                            ORDER BY [Name]");

            queryExecutor.AddParameter(corrctnessCount, DbType.Int32);
            queryExecutor.AddParameter(group, DbType.Int32);

            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

            try
            {
                Word item = null;

                while (dataReader.Read())
                {
                    if (list == null)
                    {
                        list = new List<Word>();
                    }
                    item = new Word();
                    item.ID = (int)dataReader.GetInt32("ID");
                    Nullable<int> groupno = dataReader.GetInt32("GroupNo");
                    item.GroupNo = groupno;
                    item.Name = dataReader.GetString("Name");
                    item.Meaning = dataReader.GetString("Meaning");
                    item.Etymology = dataReader.GetString("Etymology");
                    item.CorrectnessCount = (int)dataReader.GetInt32("CorrectnessCount");

                    //item.Synonyms = dataReader.GetString("Synonyms");
                    //item.Etymology = dataReader.GetString("Etymology");
                    //item.ExampleEnglishSentence = dataReader.GetString("ExampleEnglishSentence");                    
                    //item.Photo = dataReader.GetByteArray("Photo");

                    list.Add(item);
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    dataReader = null;
                }

                throw ex;
            }

            return list;
        }

        public IList<string> GetNamesByCorrectnessBelow(ITransactionManager tm, int corrctnessCount, int group)
        {
            IList<string> list = null;

            IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

            queryExecutor.CreateSqlCommand(@"SELECT 
                                            Names
                                            FROM Word
                                            WHERE CorrectnessCount < @CorrectnessCount
                                            AND GroupNo = @GroupNo
                                            ORDER BY [Name]");

            queryExecutor.AddParameter(corrctnessCount, DbType.Int32);
            queryExecutor.AddParameter(group, DbType.Int32);

            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

            try
            {
                string item = null;

                while (dataReader.Read())
                {
                    if (list == null)
                    {
                        list = new List<string>();
                    }

                    item = dataReader.GetString("Name");

                    list.Add(item);
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    dataReader = null;
                }

                throw ex;
            }

            return list;
        }

        public IList<Word> GetByCorrectnessBelow(ITransactionManager tm, int corrctnessCount, int group, string like)
        {
            IList<Word> list = null;

            IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

            queryExecutor.CreateSqlCommand(@"SELECT 
                                               *
                                            FROM Word
                                            Where CorrectnessCount < @CorrectnessCount
                                            AND GroupNo = @GroupNo
                                            AND Name LIKE '" + like + @"%'
                                            ORDER BY [Name]");

            queryExecutor.AddParameter(corrctnessCount, DbType.Int32);
            queryExecutor.AddParameter(group, DbType.Int32);

            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

            try
            {
                Word item = null;

                while (dataReader.Read())
                {
                    if (list == null)
                    {
                        list = new List<Word>();
                    }

                    item = MapItem(dataReader);

                    list.Add(item);
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    dataReader = null;
                }

                throw ex;
            }

            return list;
        }


        public IList<Word> GetByGroup(ITransactionManager tm, int group)
        {
            IList<Word> list = null;

            IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

            queryExecutor.CreateSqlCommand(@"SELECT 
                                               ID, GroupNo, Name, Meaning, Etymology, CorrectnessCount
                                            FROM Word
                                            Where GroupNo = @GroupNo
                                            ORDER BY [Name]");

            queryExecutor.AddParameter(group, DbType.Int32);

            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

            try
            {
                Word item = null;

                while (dataReader.Read())
                {
                    if (list == null)
                    {
                        list = new List<Word>();
                    }
                    item = new Word();
                    item.ID = (int)dataReader.GetInt32("ID");
                    Nullable<int> groupno = dataReader.GetInt32("GroupNo");
                    item.GroupNo = groupno;
                    item.Name = dataReader.GetString("Name");
                    item.Meaning = dataReader.GetString("Meaning");
                    item.Etymology = dataReader.GetString("Etymology");
                    item.CorrectnessCount = (int)dataReader.GetInt32("CorrectnessCount");

                    //item.Synonyms = dataReader.GetString("Synonyms");
                    //item.Etymology = dataReader.GetString("Etymology");
                    //item.ExampleEnglishSentence = dataReader.GetString("ExampleEnglishSentence");                    
                    //item.Photo = dataReader.GetByteArray("Photo");

                    list.Add(item);
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    dataReader = null;
                }

                throw ex;
            }

            return list;
        }

        public IList<string> GetNamesByGroup(ITransactionManager tm, int group)
        {
            IList<string> list = null;

            IQueryExecutor<string> queryExecutor = new QueryExecutor<string>(tm);

            queryExecutor.CreateSqlCommand(@"SELECT 
                                            [Name]
                                            FROM Word
                                            Where GroupNo = @GroupNo
                                            ORDER BY [Name]");

            queryExecutor.AddParameter(group, DbType.Int32);

            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

            try
            {
                string item = null;

                while (dataReader.Read())
                {
                    if (list == null)
                    {
                        list = new List<string>();
                    }

                    item = dataReader.GetString("Name");

                    list.Add(item);
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    dataReader = null;
                }

                throw ex;
            }

            return list;
        }

//        public IList<string> GetNamesByGroup(ITransactionManager tm, int group)
//        {
//            IList<string> list = null;

//            IQueryExecutor<string> queryExecutor = new QueryExecutor<string>(tm);

//            queryExecutor.CreateSqlCommand(@"SELECT Name 
//                                            FROM Word
//                                            Where GroupNo = @GroupNo
//                                            ORDER BY [Name]");

//            queryExecutor.AddParameter(group, DbType.Int32);

//            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

//            try
//            {
//                string item = null;

//                while (dataReader.Read())
//                {
//                    if (list == null)
//                    {
//                        list = new List<string>();
//                    }

//                    item = dataReader.GetString("Name");

//                    list.Add(item);
//                }

//                dataReader.Close();
//            }
//            catch (Exception ex)
//            {
//                if (dataReader != null)
//                {
//                    dataReader.Close();
//                    dataReader = null;
//                }

//                throw ex;
//            }

//            return list;
//        }

        public IList<Word> GetByGroup(ITransactionManager tm, int group, string like)
        {
            IList<Word> list = null;

            IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

            queryExecutor.CreateSqlCommand(@"SELECT 
                                                *
                                            FROM Word
                                            Where GroupNo = @GroupNo
                                            AND Name LIKE '" + like + @"%'
                                            ORDER BY [Name]");

            queryExecutor.AddParameter(group, DbType.Int32);

            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

            try
            {
                Word item = null;

                while (dataReader.Read())
                {
                    if (list == null)
                    {
                        list = new List<Word>();
                    }

                    item = MapItem(dataReader);

                    list.Add(item);
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    dataReader = null;
                }

                throw ex;
            }

            return list;
        }

        public IList<Word> GetByCorrectnessBeyond(ITransactionManager tm, int corrctnessCount)
        {
            IList<Word> list = null;

            IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

            queryExecutor.CreateSqlCommand(@"SELECT 
                                                ID, GroupNo, Name, Meaning, Etymology, CorrectnessCount
                                            FROM Word
                                            Where CorrectnessCount >= @CorrectnessCount
                                            ORDER BY [Name]");

            queryExecutor.AddParameter(corrctnessCount, DbType.Int32);

            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

            try
            {
                Word item = null;

                while (dataReader.Read())
                {
                    if (list == null)
                    {
                        list = new List<Word>();
                    }
                    item = new Word();
                    item.ID = (int)dataReader.GetInt32("ID");
                    Nullable<int> groupno = dataReader.GetInt32("GroupNo");
                    item.GroupNo = groupno;
                    item.Name = dataReader.GetString("Name");
                    item.Meaning = dataReader.GetString("Meaning");
                    item.Etymology = dataReader.GetString("Etymology");
                    item.CorrectnessCount = (int)dataReader.GetInt32("CorrectnessCount");

                    //item.Synonyms = dataReader.GetString("Synonyms");
                    //item.Etymology = dataReader.GetString("Etymology");
                    //item.ExampleEnglishSentence = dataReader.GetString("ExampleEnglishSentence");                    
                    //item.Photo = dataReader.GetByteArray("Photo");

                    list.Add(item);
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    dataReader = null;
                }

                throw ex;
            }

            return list;
        }

        public IList<Word> GetByCorrectnessBeyond(ITransactionManager tm, int corrctnessCount, string like)
        {
            IList<Word> list = null;

            IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

            queryExecutor.CreateSqlCommand(@"SELECT *
                                            FROM Word
                                            Where CorrectnessCount >= @CorrectnessCount
                                            AND Name LIKE '" + like + @"%'
                                            ORDER BY [Name]");

            queryExecutor.AddParameter(corrctnessCount, DbType.Int32);

            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

            try
            {
                Word item = null;

                while (dataReader.Read())
                {
                    if (list == null)
                    {
                        list = new List<Word>();
                    }

                    item = MapItem(dataReader);

                    list.Add(item);
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    dataReader = null;
                }

                throw ex;
            }

            return list;
        }

        public int Save(ITransactionManager tm, Word item)
        {
            int count = -1;

            try
            {
                IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

                queryExecutor.CreateSqlCommand(@"INSERT INTO Word(ID
                                                       ,GroupNo
                                                       ,Name
                                                       ,Meaning
                                                       ,Hint
                                                       ,Synonyms
                                                       ,Etymology
                                                       ,ExampleEnglishSentence
                                                       ,CorrectnessCount
                                                       ,Photo)
                                                 VALUES
                                                       (@ID
                                                       ,@GroupNo
                                                       ,@Name
                                                       ,@Meaning
                                                       ,@Hint
                                                       ,@Synonyms
                                                       ,@Etymology
                                                       ,@ExampleEnglishSentence
                                                       ,@CorrectnessCount
                                                       ,@Photo)");

                queryExecutor.AddParameter(item.ID, DbType.Int32);
                queryExecutor.AddParameter(item.GroupNo, DbType.Int32);
                queryExecutor.AddParameter(item.Name, DbType.String);
                queryExecutor.AddParameter(item.Meaning, DbType.String);
                queryExecutor.AddParameter(item.Hint, DbType.String);
                queryExecutor.AddParameter(item.Synonyms, DbType.String);
                queryExecutor.AddParameter(item.Etymology, DbType.String);
                queryExecutor.AddParameter(item.ExampleEnglishSentence, DbType.String);
                queryExecutor.AddParameter(item.CorrectnessCount, DbType.Int32);
                queryExecutor.AddParameter(item.Photo, DbType.Binary);

                count =
                    queryExecutor.
                    ExecuteNonQuery();

                string str = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return count;
        }

        public int Update(ITransactionManager tm, Word item)
        {
            int count = -1;

            try
            {
                IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

                queryExecutor.CreateSqlCommand(@"UPDATE 
                                                      Word
                                                 SET GroupNo=@GroupNo
                                                      ,Name = @Name
                                                      ,Meaning = @Meaning
                                                      ,Hint = @Hint
                                                      ,Synonyms = @Synonyms
                                                      ,Etymology = @Etymology
                                                      ,ExampleEnglishSentence = @ExampleEnglishSentence
                                                      ,CorrectnessCount=@CorrectnessCount
                                                      ,Photo=@Photo
                                                 WHERE ID = @ID");
                queryExecutor.AddParameter(item.GroupNo, DbType.Int32);
                queryExecutor.AddParameter(item.Name, DbType.String);
                queryExecutor.AddParameter(item.Meaning, DbType.String);
                queryExecutor.AddParameter(item.Hint, DbType.String);
                queryExecutor.AddParameter(item.Synonyms, DbType.String);
                queryExecutor.AddParameter(item.Etymology, DbType.String);
                queryExecutor.AddParameter(item.ExampleEnglishSentence, DbType.String);
                queryExecutor.AddParameter(item.CorrectnessCount, DbType.Int32);
                queryExecutor.AddParameter(item.Photo, DbType.Binary);
                queryExecutor.AddParameter(item.ID, DbType.Int32);

                count = queryExecutor.ExecuteNonQuery();

                string str = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return count;
        }


        public int Update(ITransactionManager tm, List<Word> items)
        {
            int count = 0;

            foreach(Word item in items)
            {
                count += Update(tm, item);
            }

            return count;
        }

        public int UpdateGroupNo(ITransactionManager tm, int GroupNo, string whereClause, IList<string> values)
        {
            int count = -1;

            try
            {
                IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

                queryExecutor.CreateSqlCommand(@"UPDATE 
                                                      Word
                                                 SET GroupNo=@GroupNo
                                                 WHERE Name IN (" + whereClause + ")");
                queryExecutor.AddParameter(GroupNo, DbType.Int32);

                for (int i = 0; i < values.Count; i++)
                {
                    queryExecutor.AddParameter(values[i], DbType.String);
                }
                
                count = queryExecutor.ExecuteNonQuery();

                string str = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return count;
        }

        public int UpdateCorrectnessCount(ITransactionManager tm, int GroupNo, int CorrectnessCount, string inClause, IList<string> names)
        {
            int count = -1;

            try
            {
                IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

                queryExecutor.CreateSqlCommand(@"UPDATE 
                                                      Word
                                                 SET CorrectnessCount=@CorrectnessCount
                                                      WHERE GroupNo=@GroupNo AND Name IN ("
                                                + inClause + ")");
                queryExecutor.AddParameter(CorrectnessCount, DbType.Int32);
                queryExecutor.AddParameter(GroupNo, DbType.Int32);

                for (int i = 0; i < names.Count; i++)
                {
                    queryExecutor.AddParameter(names[i], DbType.String);
                }                

                count = queryExecutor.ExecuteNonQuery();

                string str = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return count;
        }

        public int Delete(ITransactionManager tm, Word item)
        {
            int count = -1;

            try
            {
                IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

                queryExecutor.CreateSqlCommand(@"DELETE FROM Word
                                            where id=@id");

                queryExecutor.AddParameter(item.ID, DbType.Int32);

                count = queryExecutor.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }

            return count;
        }

        public IList<Word> GetByLike(TransactionManager tm, string text)
        {
            IList<Word> list = null;

            IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

            string comm = @"SELECT ID,GroupNo
                                                ,Name
                                                ,Meaning
                                                ,Etymology
                                                ,CorrectnessCount
                                            FROM Word
                                            WHERE Name LIKE '" + text + @"%'
                                            ORDER BY Name";

            queryExecutor.CreateSqlCommand(comm);

            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

            try
            {
                Word item = null;
                
                while (dataReader.Read())
                {
                    if (list == null)
                    {
                        list = new List<Word>();
                    }
                    item = new Word();
                    item.ID = (int)dataReader.GetInt32("ID");
                    Nullable<int> groupno = dataReader.GetInt32("GroupNo");
                    item.GroupNo = groupno;
                    item.Name = dataReader.GetString("Name");
                    item.Meaning = dataReader.GetString("Meaning");
                    item.Etymology = dataReader.GetString("Etymology");
                    item.CorrectnessCount = (int)dataReader.GetInt32("CorrectnessCount");

                    //item.Synonyms = dataReader.GetString("Synonyms");
                    //item.Etymology = dataReader.GetString("Etymology");
                    //item.ExampleEnglishSentence = dataReader.GetString("ExampleEnglishSentence");                    
                    //item.Photo = dataReader.GetByteArray("Photo");

                    list.Add(item);
                }

                dataReader.Close();
            }
            catch //(Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    dataReader = null;
                }

                throw;// ex;
            }

            return list;
        }

        public Word GetByName(TransactionManager tm, string name)
        {
            Word item = null;

            IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);
            queryExecutor.CreateSqlCommand(@"select * from Word where Name=@Name");
            queryExecutor.AddParameter(name, DbType.String);

            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

            try
            {
                while (dataReader.Read())
                {
                    item = MapItem(dataReader);
                }

                dataReader.Close();
            }
            catch (Exception)
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

        internal IList<Word> GetByCorrectnessBeyond(TransactionManager tm, int group, int correctness)
        {
            IList<Word> list = null;

            IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

            queryExecutor.CreateSqlCommand(@"SELECT 
                                                ID, GroupNo, Name, Meaning, Etymology, CorrectnessCount
                                            FROM Word
                                            Where CorrectnessCount >= @CorrectnessCount
                                            AND GroupNo=@GroupNo    
                                            ORDER BY [Name]");

            queryExecutor.AddParameter(correctness, DbType.Int32);
            queryExecutor.AddParameter(group, DbType.Int32);

            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

            try
            {
                Word item = null;

                while (dataReader.Read())
                {
                    if (list == null)
                    {
                        list = new List<Word>();
                    }
                    item = new Word();
                    item.ID = (int)dataReader.GetInt32("ID");
                    Nullable<int> groupno = dataReader.GetInt32("GroupNo");
                    item.GroupNo = groupno;
                    item.Name = dataReader.GetString("Name");
                    item.Meaning = dataReader.GetString("Meaning");
                    item.Etymology = dataReader.GetString("Etymology");
                    item.CorrectnessCount = (int)dataReader.GetInt32("CorrectnessCount");

                    //item.Synonyms = dataReader.GetString("Synonyms");
                    //item.Etymology = dataReader.GetString("Etymology");
                    //item.ExampleEnglishSentence = dataReader.GetString("ExampleEnglishSentence");                    
                    //item.Photo = dataReader.GetByteArray("Photo");

                    list.Add(item);
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    dataReader = null;
                }

                throw ex;
            }

            return list;
        }

        internal IList<string> GetNamesByCorrectnessBeyond(TransactionManager tm, int group, int correctness)
        {
            IList<string> list = null;

            IQueryExecutor<string> queryExecutor = new QueryExecutor<string>(tm);

            queryExecutor.CreateSqlCommand(@"SELECT 
                                             Name
                                            FROM Word
                                            Where CorrectnessCount >= @CorrectnessCount
                                            AND GroupNo=@GroupNo    
                                            ORDER BY [Name]");

            queryExecutor.AddParameter(correctness, DbType.Int32);
            queryExecutor.AddParameter(group, DbType.Int32);

            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

            try
            {
                string item = null;

                while (dataReader.Read())
                {
                    if (list == null)
                    {
                        list = new List<string>();
                    }

                    item = dataReader.GetString("Name");

                    list.Add(item);
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    dataReader = null;
                }

                throw ex;
            }

            return list;
        }

        internal IList<Word> GetByCorrectnessBeyond(TransactionManager tm, int group, int correctness, string like)
        {
            IList<Word> list = null;

            IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

            queryExecutor.CreateSqlCommand(@"SELECT *
                                            FROM Word
                                            Where CorrectnessCount >= @CorrectnessCount
                                            AND GroupNo=@GroupNo   
                                            AND Name LIKE '" + like + @"%' 
                                            ORDER BY [Name]");

            queryExecutor.AddParameter(correctness, DbType.Int32);
            queryExecutor.AddParameter(group, DbType.Int32);

            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

            try
            {
                Word item = null;

                while (dataReader.Read())
                {
                    if (list == null)
                    {
                        list = new List<Word>();
                    }

                    item = MapItem(dataReader);

                    list.Add(item);
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    dataReader = null;
                }

                throw ex;
            }

            return list;
        }

        public bool IsPictureAvailable(TransactionManager tm, string name)
        {
            bool isPictureAvailable = false;

            IQueryExecutor<Word> queryExecutor = new QueryExecutor<Word>(tm);

            queryExecutor.CreateSqlCommand(@"SELECT IsNull(Photo) AS IsPhotoNull
                                             FROM Word
                                             WHERE Name=@Name");

            queryExecutor.AddParameter(name, DbType.String);

            ISafeDataReader dataReader = queryExecutor.ExecuteReader();

            try
            {
                int? returns = -99;

                while (dataReader.Read())
                {
                    returns = dataReader.GetInt32("IsPhotoNull");
                }

                dataReader.Close();

                if (returns == 0)
                    isPictureAvailable = true;
                else if (returns == -1)
                    isPictureAvailable = false;
            }
            catch (Exception ex)
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    dataReader = null;
                }

                throw ex;
            }

            return isPictureAvailable;
        

        }

        #region IDisposable
        private bool disposed = false; // to detect redundant calls
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //if (_wordDAO != null)
                    //{
                    //    _wordDAO.Dispose();
                    //}
                }

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}