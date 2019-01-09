using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using ActivityAPI.Repository;
using ActivityAPI.Service;

namespace ActivityAPI.UnitTests.Service.Tests
{
    [TestFixture]
    public class ActivityServiceTests
    {
        IActivityRepository stubRepo;

        [SetUp]
        public void SetUp()
        {
            stubRepo = Substitute.For<IActivityRepository>();
        }

        [Test]
        public void IsFullyBooked_活動人數10報名人數6_回傳False()
        {
            ActivityService service = new ActivityService(stubRepo);

            var activity = stubRepo.GetActivity(Arg.Any<int>()).Returns(new Models.Activity() { Count = 10, RegisterCount = 6 });
                      
            bool actual = service.IsFullyBooked(Arg.Any<int>());

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsFullyBooked_活動人數10報名人數10_回傳true()
        {
            ActivityService service = new ActivityService(stubRepo);

            var activity = stubRepo.GetActivity(Arg.Any<int>()).Returns(new Models.Activity() { Count = 10, RegisterCount = 10 });

            bool actual = service.IsFullyBooked(Arg.Any<int>());

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsFullyBooked_活動人數10報名人數11_回傳true()
        {
            ActivityService service = new ActivityService(stubRepo);

            var activity = stubRepo.GetActivity(Arg.Any<int>()).Returns(new Models.Activity() { Count = 10, RegisterCount = 11 });

            bool actual = service.IsFullyBooked(Arg.Any<int>());

            Assert.IsTrue(actual);
        }
    }
}
