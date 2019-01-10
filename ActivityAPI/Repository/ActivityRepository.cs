using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using ActivityAPI.Models;

namespace ActivityAPI.Repository
{
    public class ActivityRepository : IActivityRepository
    {     

        public void Add(Models.Activity activity)
        {
            InMemoryData.Activities.Add(activity);
        }

        public Models.Activity GetActivity(int id)
        {
             return InMemoryData.Activities.Find(x => x.ActivityId == id);            
        }

        public List<Models.Activity> GetAllActivity()
        {
            return InMemoryData.Activities;
        }

        public void Update(Models.Activity activity)
        {
            var updateActivity = this.GetActivity(activity.ActivityId);
            updateActivity.Name = activity.Name;
            updateActivity.ActivityDate = activity.ActivityDate;
            updateActivity.Count = activity.Count;
            updateActivity.Desc = activity.Desc;
            updateActivity.Price = activity.Price;
            updateActivity.EarlyPrice = activity.EarlyPrice;
            updateActivity.ImgUrl = activity.ImgUrl;
            updateActivity.Teacher = activity.Teacher;
            updateActivity.RegisterCount = activity.RegisterCount;            
        }


        public void Delete(Models.Activity activity)
        {
            InMemoryData.Activities.Remove(activity);
        }
    }
}