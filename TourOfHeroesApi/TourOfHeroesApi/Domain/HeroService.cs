using System;
using TourOfHeroesApi.Controllers;

namespace TourOfHeroesApi.Domain
{
    public class HeroService : IHeroService
    {
        public HeroService()
        {
        }

        public Task<Hero> CreateHeroAsync(CreateHeroCommand command)
        {
            throw new NotImplementedException();
        }

        public Task DeleteHeroAsync(string heroId)
        {
            throw new NotImplementedException();
        }

        public Task<Hero> GetHeroAsync(string heroId)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Hero>> GetHeroListAsync()
        {
            await Task.Delay(10);
            return new List<Hero>()
            {
                new Hero
                {
                    Id = "1",
                    Name = "アンパンマン",
                    Occupation = "ヒーロー"
                }
            };
        }

        public Task<Hero> UpdateHeroAsync(string heroId)
        {
            throw new NotImplementedException();
        }
    }
}

