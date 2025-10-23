using Microsoft.AspNetCore.Mvc;

namespace Persons.Service.Controllers;

[ApiController]
[Route("api/persons")]
public class PersonsConroller : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<ActionResult<Person>> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    [HttpGet()]
    public async Task<ActionResult<List<Person>>> ListAsync()
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<ActionResult<Person>> AddAsync(Person person)
    {
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Person>> UpdateByIdAsync(int id, Person person)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}
