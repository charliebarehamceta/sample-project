using System.Data.SqlClient;
using System.Reflection.PortableExecutable;
using Api.Models;
using Dapper;

namespace Api.Datastore;

public class DataAccess
{
    private readonly string _connectionString =
        "Server=localhost,1433;Database=datastore;User Id=sa;Password=test!this!Password;";
        
    public async Task<IEnumerable<Job>> Jobs()
    {
        await using var db = new SqlConnection(_connectionString);
        var jobs = await db.QueryAsync<Job>("select * from jobs");

        return jobs;
    }

    public async Task<IEnumerable<Person>> Persons()
    {
        await using var db = new SqlConnection(_connectionString);
        var people = await db.QueryAsync<Person>("select * from persons");

        return people;
    }

    public async Task<IEnumerable<object>> PersonsJobs()
    {
        await using var db = new SqlConnection(_connectionString);
        var people = await db.QueryAsync<dynamic>("select * from persons_jobs");

        var pj = new List<PersonJob>();
        
        foreach (var i in people)
        {
            var p = new Person();
            var j = new Job();
            
            p.Name = i.PersonName;
            j.Name = i.JobName;
            
            pj.Add(new PersonJob
            {
                Id = i.Id,
                Person = p,
                Job = j
            });
        }

        return pj;
    }
}