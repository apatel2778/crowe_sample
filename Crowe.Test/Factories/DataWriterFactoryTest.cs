using Crowe.Api.DataWriterStrategies;
using Crowe.Api.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crowe.Test.Factories
{
    [TestClass]
    public class DataWriterFactoryTest
    {
        [TestMethod]
        public void DataWriterFactory_Should_Create_ConsoleWriter_When_CON()
        {
            var code = "CON";
            var dataWriter = DataWriterFactory.GetDataWriterStrategy(code);

            Assert.IsTrue(dataWriter is DataWriterConsoleStrategy, $"DataWriterFactory should return Console Writer when code = '{code}'");
        }

        [TestMethod]
        public void DataWriterFactory_Should_Create_ConsoleWriter_When_Other()
        {
            var code = "OTHER_ANY_OTHER_HERE";
            var dataWriter = DataWriterFactory.GetDataWriterStrategy(code);

            Assert.IsTrue(dataWriter is DataWriterConsoleStrategy, $"DataWriterFactory should return Console Writer when code is not found");
        }

        [TestMethod]
        public void DataWriterFactory_Should_Create_DatabaseWriter_When_DAT()
        {
            var code = "DAT";
            var dataWriter = DataWriterFactory.GetDataWriterStrategy(code);

            Assert.IsTrue(dataWriter is DataWriterDatabaseStrategy, $"DataWriterFactory should return Database Writer when code = '{code}'");
        }

        [TestMethod]
        public void DataWriterFactory_Should_Create_DatabaseWriter_When_FIL()
        {
            var code = "FIL";
            var dataWriter = DataWriterFactory.GetDataWriterStrategy(code);

            Assert.IsTrue(dataWriter is DataWriterFileStrategy, $"DataWriterFactory should return File Writer when code = '{code}'");
        }

    }
}
