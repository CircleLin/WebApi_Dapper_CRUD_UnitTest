using System.Collections.Generic;
using ActivityAPI.Models;

namespace ActivityAPI.Repository
{
    public interface IActivityRepository
    {
        void Add(Activity activity);
        void Delete(Activity activity);
        Activity GetActivity(int id);
        List<Activity> GetAllActivity();
        void Update(Activity activity);
    }
}