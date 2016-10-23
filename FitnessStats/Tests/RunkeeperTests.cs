using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FitnessStats.Services;
using NUnit.Framework;

namespace FitnessStats.Tests
{
    [TestFixture]
    public class RunkeeperTests
    {
        private DataService dataService;
        [SetUp]
        public void Setup()
        {
            dataService = new DataService();
        }

        [Test]
        public void TestRunLog()
        {
            var runs = dataService.GetRuns();
        }
    }
}