using QuizApplicationLibrary.POCO;
using Simple.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuizApplicationLibrary.DAO
{
    class ApplicationDataDAO
    {
        private ApplicationData MapItem(ISafeDataReader dataReader)
        {
            ApplicationData item = new ApplicationData();
            item.LastEnteredWord____EntityForm = dataReader.GetString("LastEnteredWord____EntityForm");
            item.LastSelectedGroup____EntityForm = (int)dataReader.GetInt32("LastSelectedGroup____EntityForm");
            item.GroupCheckBox___CollectionForm = (bool)dataReader.GetBoolean("GroupCheckBox___CollectionForm");
            item.GroupComboBox___CollectionForm = (int)dataReader.GetInt32("GroupComboBox___CollectionForm");
            item.LearntCheckBox____CollectionForm = (bool)dataReader.GetBoolean("LearntCheckBox____CollectionForm");
            item.LearntComboBox____CollectionForm = (int)dataReader.GetInt32("LearntComboBox____CollectionForm");
            item.FilterTextBox____CollectionForm = dataReader.GetString("FilterTextBox____CollectionForm");
            item.LastSelectedGroupSelectGroupForm = (int)dataReader.GetInt32("LastSelectedGroupSelectGroupForm");
            item.LastSelectedWordLearnForm = dataReader.GetString("LastSelectedWordLearnForm");
            item.LastTopWordIndex____CollectionForm = (int)dataReader.GetInt32("LastTopWordIndex____CollectionForm");
            item.LastSelectedWordIndex____CollectionForm = (int)dataReader.GetInt32("LastSelectedWordIndex____CollectionForm");
            item.OrderBy_____CollectionForm = (int)dataReader.GetInt32("OrderBy_____CollectionForm");
            return item;
        }

        private void AddParameters(IQueryExecutor<ApplicationData> queryExecutor, ApplicationData item)
        {
            queryExecutor.AddParameter(item.LastEnteredWord____EntityForm, DbType.String);
            queryExecutor.AddParameter(item.LastSelectedGroup____EntityForm, DbType.Int32);
            queryExecutor.AddParameter(item.GroupCheckBox___CollectionForm, DbType.Boolean);
            queryExecutor.AddParameter(item.GroupComboBox___CollectionForm, DbType.Int32);
            queryExecutor.AddParameter(item.LearntCheckBox____CollectionForm, DbType.Boolean);
            queryExecutor.AddParameter(item.LearntComboBox____CollectionForm, DbType.Int32);
            queryExecutor.AddParameter(item.FilterTextBox____CollectionForm, DbType.String);
            queryExecutor.AddParameter(item.LastSelectedGroupSelectGroupForm, DbType.Int32);
            queryExecutor.AddParameter(item.LastSelectedWordLearnForm, DbType.String);
            queryExecutor.AddParameter(item.LastTopWordIndex____CollectionForm, DbType.Int32);
            queryExecutor.AddParameter(item.LastSelectedWordIndex____CollectionForm, DbType.Int32);
            queryExecutor.AddParameter(item.OrderBy_____CollectionForm, DbType.Int32);
        }

        private int GetCount(ITransactionManager tm)
        {
            int item = -99;

            IQueryExecutor<ApplicationData> queryExecutor = new QueryExecutor<ApplicationData>(tm);
            queryExecutor.CreateSqlCommand(@"select count(*) from ApplicationData");

            item = queryExecutor.ExecuteScalar();

            return item;
        }

        public ApplicationData Get(ITransactionManager tm)
        {
            ApplicationData item = null;

            IQueryExecutor<ApplicationData> queryExecutor = new QueryExecutor<ApplicationData>(tm);
            queryExecutor.CreateSqlCommand(@"select * from ApplicationData");
            
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

        public int SaveData(ITransactionManager tm, ApplicationData item)
        {
            int count = GetCount(tm);

            if(count < 1)
            {
                return Save(tm, item);
            }
            else
            {
                return Update(tm, item);
            }
        }

        private int Save(ITransactionManager tm, ApplicationData item)
        {
            int count = -1;

            try
            {
                IQueryExecutor<ApplicationData> queryExecutor = new QueryExecutor<ApplicationData>(tm);

                queryExecutor.CreateSqlCommand(@"INSERT INTO ApplicationData(LastEnteredWord____EntityForm
                                                       ,LastSelectedGroup____EntityForm                                                       
                                                       ,GroupCheckBox___CollectionForm
                                                       ,GroupComboBox___CollectionForm
                                                       ,LearntCheckBox____CollectionForm
                                                       ,LearntComboBox____CollectionForm
                                                       ,FilterTextBox____CollectionForm
                                                       ,LastSelectedGroupSelectGroupForm
                                                       ,LastSelectedWordLearnForm
                                                       ,LastTopWordIndex____CollectionForm
                                                       ,LastSelectedWordIndex____CollectionForm
                                                       ,OrderBy_____CollectionForm)
                                                 VALUES
                                                       (@LastEnteredWord____EntityForm
                                                       ,@LastSelectedGroup____EntityForm
                                                       ,@GroupCheckBox___CollectionForm
                                                       ,@GroupComboBox___CollectionForm                                                       
                                                       ,@LearntCheckBox____CollectionForm
                                                       ,@LearntComboBox____CollectionForm
                                                       ,@FilterTextBox____CollectionForm
                                                       ,@LastSelectedGroupSelectGroupForm
                                                       ,@LastSelectedWordLearnForm
                                                       ,@LastTopWordIndex____CollectionForm
                                                       ,@LastSelectedWordIndex____CollectionForm
                                                       ,@OrderBy_____CollectionForm");

                AddParameters(queryExecutor, item);

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

        private int Update(ITransactionManager tm, ApplicationData item)
        {
            int count = -1;

            try
            {
                IQueryExecutor<ApplicationData> queryExecutor = new QueryExecutor<ApplicationData>(tm);

                queryExecutor.CreateSqlCommand(@"UPDATE 
                                                      ApplicationData
                                                 SET LastEnteredWord____EntityForm=@LastEnteredWord____EntityForm
                                                      ,LastSelectedGroup____EntityForm=@LastSelectedGroup____EntityForm
                                                      ,GroupCheckBox___CollectionForm = @GroupCheckBox___CollectionForm
                                                      ,GroupComboBox___CollectionForm = @GroupComboBox___CollectionForm
                                                      ,LearntCheckBox____CollectionForm=@LearntCheckBox____CollectionForm
                                                      ,LearntComboBox____CollectionForm = @LearntComboBox____CollectionForm
                                                      ,FilterTextBox____CollectionForm = @FilterTextBox____CollectionForm
                                                      ,LastSelectedGroupSelectGroupForm = @LastSelectedGroupSelectGroupForm
                                                      ,LastSelectedWordLearnForm = @LastSelectedWordLearnForm
                                                      ,LastTopWordIndex____CollectionForm=@LastTopWordIndex____CollectionForm
                                                      ,LastSelectedWordIndex____CollectionForm = @LastSelectedWordIndex____CollectionForm
                                                      ,OrderBy_____CollectionForm=@OrderBy_____CollectionForm");
                queryExecutor.AddParameter(item.LastEnteredWord____EntityForm, DbType.String);
                queryExecutor.AddParameter(item.LastSelectedGroup____EntityForm, DbType.Int32);
                queryExecutor.AddParameter(item.GroupCheckBox___CollectionForm, DbType.Boolean);
                queryExecutor.AddParameter(item.GroupComboBox___CollectionForm, DbType.Int32);
                queryExecutor.AddParameter(item.LearntCheckBox____CollectionForm, DbType.Boolean);
                queryExecutor.AddParameter(item.LearntComboBox____CollectionForm, DbType.Int32);
                queryExecutor.AddParameter(item.FilterTextBox____CollectionForm, DbType.String);
                queryExecutor.AddParameter(item.LastSelectedGroupSelectGroupForm, DbType.Int32);
                queryExecutor.AddParameter(item.LastSelectedWordLearnForm, DbType.String);
                queryExecutor.AddParameter(item.LastTopWordIndex____CollectionForm, DbType.Int32);
                queryExecutor.AddParameter(item.LastSelectedWordIndex____CollectionForm, DbType.Int32);
                queryExecutor.AddParameter(item.OrderBy_____CollectionForm, DbType.Int32);

                count = queryExecutor.ExecuteNonQuery();

                string str = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return count;
        }
    }
}
