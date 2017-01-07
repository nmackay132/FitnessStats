using NUnit.Framework;
using WebUI.Services;

namespace WebUI.Tests
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