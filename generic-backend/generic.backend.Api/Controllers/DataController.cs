using Api.Datastore;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DataController : ControllerBase
{
    private readonly DataAccess _dataAccess;

    public DataController()
    {
        _dataAccess = new DataAccess();
    }
    
    [HttpGet("person")]
    public IEnumerable<Person> GetPerson()
    {
        var person = _dataAccess.Persons().Result;
        
        return person;
    }

    [HttpGet("job")]
    public async Task<IEnumerable<Job>> GetJob() => await _dataAccess.Jobs();

    [HttpGet("peoplesjobs")]
    public IEnumerable<object> GetPeoplesJobs()
    {
        return _dataAccess.PersonsJobs().Result;
    }


}