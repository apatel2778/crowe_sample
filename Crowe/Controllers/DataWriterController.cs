using Crowe.Api.DataWriterStrategies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Crowe.Api.Helpers;
using Microsoft.Extensions.Options;
using Crowe.Api.Factories;

namespace Crowe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataWriterController : ControllerBase
    {
        private readonly AppSettings _appSettings;

        public DataWriterController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        // GET api/datawriter/{dataToWrite}
        [HttpGet("{dataToWrite}")]
        public ActionResult<string> Get(string dataToWrite)
        {
            if (string.IsNullOrEmpty(dataToWrite))
                return BadRequest();

            try
            {
                DataWriterStrategy dataWriter = DataWriterFactory.GetDataWriterStrategy(_appSettings.DataWriterStrategyCode);
                var returnedValue = dataWriter.WriteData(dataToWrite);

                return Ok(returnedValue);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            
        }
    }
}
