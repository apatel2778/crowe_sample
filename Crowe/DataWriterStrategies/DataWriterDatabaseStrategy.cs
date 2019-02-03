
namespace Crowe.Api.DataWriterStrategies
{
    public class DataWriterDatabaseStrategy : DataWriterStrategy
    {
        public override string WriteData(string dataToWrite)
        {
            return $"Data written to Database with value of {dataToWrite}";
        }
    }
}
