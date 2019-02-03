using Crowe.Api.DataWriterStrategies;

namespace Crowe.Api.Factories
{
    public static class DataWriterFactory
    {
        public static DataWriterStrategy GetDataWriterStrategy(string code)
        {
            if (code == "DAT")
                return new DataWriterDatabaseStrategy();

            if (code == "FIL")
                return new DataWriterFileStrategy();

            return new DataWriterConsoleStrategy();
        }
    }
}
