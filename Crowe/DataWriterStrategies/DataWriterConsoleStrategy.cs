
namespace Crowe.Api.DataWriterStrategies
{
    public class DataWriterConsoleStrategy : DataWriterStrategy
    {
        public override string WriteData(string dataToWrite)
        {
            return $"Data written to Console with value of {dataToWrite}";
        }
    }
}
