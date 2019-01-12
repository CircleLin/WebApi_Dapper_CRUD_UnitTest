using System.Collections.Generic;
using ActivityAPI.Models;

namespace ActivityAPI.Service
{
    public interface IActivityService
    {
        bool Add(Activity activity);
        int CheckRegCountNow(int activityId);
        bool Delete(int Id);
        Activity Get(int activityId);
        List<Activity> GetAll();
        bool IsFullyBooked(int activityId);
        bool Update(Activity activity);
        void RegActivity(int activityId);
    }
}