using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using ActivityAPI.Models;
using Dapper;
using System.Data.SqlClient;

namespace ActivityAPI.Repository
{
    public class ActivityRepository : IActivityRepository
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["sqlconn"].ToString();
        private SqlConnection _sqlconn;

        public SqlConnection sqlconn
        {
            get
            {
                return _sqlconn ?? new SqlConnection(connString);
            }
        }

        public int Add(Models.Activity activity)
        {
            var affectRows = sqlconn.Execute("insert into Activity" +
                "(Name," +
                "Description," +
                "ActivityDate," +
                "ImgUrl," +
                "Teacher," +
                "Price," +
                "EarlyPrice," +
                "RegisterCount," +
                "Count)values" +
                "(@Name," +
                "@Description," +
                "@ActivityDate," +
                "@ImgUrl," +
                "@Teacher," +
                "@Price," +
                "@EarlyPrice," +
                "@RegisterCount," +
                "@Count)", activity);
            return affectRows;
        }

        public Models.Activity GetActivity(int id)
        {
            return sqlconn.Query<Models.Activity>("select * from Activity where ActivityId = @ActivityId", new { ActivityId = id }).FirstOrDefault();
        }

        public List<Models.Activity> GetAllActivity()
        {
            return sqlconn.Query<Models.Activity>("select * from Activity").ToList();
        }

        public int Update(Models.Activity activity)
        {
            var affectRows = sqlconn.Execute("Update Activity set" +
                " Name=@Name," +
                "Description=@Description," +
                "ActivityDate=@ActivityDate," +
                "ImgUrl=@ImgUrl," +
                "Teacher=@Teacher," +
                "Price=@Price," +
                "EarlyPrice=@EarlyPrice," +
                "RegisterCount=@RegisterCount," +
                "Count=@Count" +
                " where ActivityId=@ActivityId", activity);
            return affectRows;
        }


        public int Delete(int Id)
        {
            var affectRows = sqlconn.Execute("delete from Activity where ActivityId = @ActivityId", new { ActivityId = Id });
            return affectRows;            
        }
       
    }
}