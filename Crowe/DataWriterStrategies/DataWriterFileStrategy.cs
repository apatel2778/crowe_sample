
namespace Crowe.Api.DataWriterStrategies
{
    public class DataWriterFileStrategy : DataWriterStrategy
    {
        public override string WriteData(string dataToWrite)
        {
            return $"Data written to file system with value of {dataToWrite}";
        }
    }
}
