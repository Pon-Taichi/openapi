using System;
using Microsoft.AspNetCore.Mvc;

namespace TourOfHeroesApi.Controllers
{
    public class Implemantation : ControllerBase, IGeneratedController
    {
        IHeroService _heroService;
        public Implemantation(IHeroService heroService)
        {
            _heroService = heroService;
        }

        public async Task<ActionResult<Hero>> CreateHeroAsync(CreateHeroCommand command)
        {
            return Created("localhost", await this._heroService.CreateHeroAsync(command));
        }

        public async Task<IActionResult> DeleteHeroAsync(string heroId)
        {
            await this._heroService.DeleteHeroAsync(heroId);
            return NoContent();
        }

        public async Task<ActionResult<Hero>> GetHeroAsync(string heroId)
        {
            return Ok(await this._heroService.GetHeroAsync(heroId));
        }

        public async Task<ActionResult<ICollection<Hero>>> GetHeroListAsync()
        {
            return Ok(await this._heroService.GetHeroListAsync());
        }

        public async Task<ActionResult<Hero>> UpdateHeroAsync(string heroId)
        {
            return Ok(await this._heroService.UpdateHeroAsync(heroId));
        }
    }

    public interface IHeroService
    {
        Task<Hero> CreateHeroAsync(CreateHeroCommand command);
        Task DeleteHeroAsync(string heroId);
        Task<ICollection<Hero>> GetHeroListAsync();
        Task<Hero> GetHeroAsync(string heroId);
        Task<Hero> UpdateHeroAsync(string heroId);
    }
}

