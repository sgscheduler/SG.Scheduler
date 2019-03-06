using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SG.Scheduler.ConfigurationExtensions;
using SG.Scheduler.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Configuration.Test
{
    [TestClass]
    public class TestConfigurationExtensions
    {
        private static IConfigurationBuilder _builder;

        [ClassInitialize]
        public static void InitTestConfigurationExtensions(TestContext context)
        {
            var configBuilder = new ConfigurationBuilder()
                .AddSchedulerConfig();
            _builder = configBuilder;
        }

        [TestMethod]
        public void TestAddSchedulerConfig()
        {
            var config = _builder
                .Build();
            var a = config.GetSchedulerConfig();
            var b = config.GetSchedulerConfig();
            Assert.AreNotEqual(a, b);
        }

        [TestMethod]
        public void TestConfigureSchedulerConfig()
        {
            var serviceCollection = new ServiceCollection();
            var config = serviceCollection
                .ConfigureSchedulerConfig(_builder.Build())
                .BuildServiceProvider();
            var a = config.GetSchedulerConfig();
            var b = config.GetSchedulerConfig();
            Assert.AreEqual(a, b);
        }
    }
}
