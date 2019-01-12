using System.Collections.Generic;
using ActivityAPI.Models;

namespace ActivityAPI.Repository
{
    public interface IActivityRepository
    {
        int Add(Activity activity);
        int Delete(int Id);
        Activity GetActivity(int id);
        List<Activity> GetAllActivity();
        int Update(Activity activity);
    }
}