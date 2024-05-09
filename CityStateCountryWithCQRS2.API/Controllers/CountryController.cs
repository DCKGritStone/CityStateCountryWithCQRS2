using CityStateCountryWithCQRS2.Application.Command._Country.CreateCountry;
using CityStateCountryWithCQRS2.Application.Command._Country.UpdateCountry;
using CityStateCountryWithCQRS2.Domain.Queries._Country;
using CountryStateCityWithCQRS.API.Controllers;
using CountryStateCityWithCQRS.Application.Command._Country.DeleteCountry;
using Microsoft.AspNetCore.Mvc;

namespace CityStateCountryWithCQRS2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ApiController
    {
        private readonly IGetCountryOuery getCountryOuery;

        public CountryController(IGetCountryOuery getCountryOuery)
        {
            this.getCountryOuery = getCountryOuery;
        }
        [HttpGet]

        public IActionResult GetAll()
        {
            var country = getCountryOuery.GetAllCountryAsync();

            return Ok(country);
        }

        [HttpGet("Id")]

        public IActionResult GetById(int id)
        {
            var country = getCountryOuery.GetCountryByIdAsync(id);

            if (country == null)
            {
                return BadRequest();
            }

            return Ok(country);
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateCountryCommand command)
        {
            var createCountry = await Mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = createCountry.Id }, createCountry);
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> Update(int id, UpdateCountryCommand command)
        {
            if (id == command.Id) { return BadRequest(); }

            await Mediator.Send(command);

            return NoContent();
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            var result = await Mediator.Send(new DeleteCountryCommand { Id = id });

            return NoContent();
        }
    }
}
