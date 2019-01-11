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

        public void Add(Models.Activity activity)
        {
            sqlconn.Execute("insert into Activity(Name,Description,ActivityDate,ImgUrl,Teacher,Price,EarlyPrice,RegisterCount,Count)values(@Name,@Description,@ActivityDate,@ImgUrl,@Teacher,@Price,@EarlyPrice,@RegisterCount,@Count)", activity);
        }

        public Models.Activity GetActivity(int id)
        {
            return sqlconn.Query<Models.Activity>("select * from Activity where ActivityId = @ActivityId", new { ActivityId = id }).FirstOrDefault();
        }

        public List<Models.Activity> GetAllActivity()
        {
            return sqlconn.Query<Models.Activity>("select * from Activity").ToList();
        }

        public void Update(Models.Activity activity)
        {
            
        }


        public void Delete(Models.Activity activity)
        {
            
        }
    }
}