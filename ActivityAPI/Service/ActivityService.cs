using ActivityAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActivityAPI.Service
{
    public class ActivityService
    {
        IActivityRepository repo;

        public ActivityService(IActivityRepository _repo)
        {
            repo = _repo;
        }


    }
}