using System.Collections.Generic;
using ActivityAPI.Models;

namespace ActivityAPI.Service
{
    public interface IActivityService
    {
        void Add(Activity activity);
        int CheckCurrentCount(int activityId);
        void Delete(Activity activity);
        Activity Get(int activityId);
        List<Activity> GetAll();
        bool IsFullyBooked(int activityId);
        void Update(Activity activity);

        void RegActivity(int activityId);
    }
}