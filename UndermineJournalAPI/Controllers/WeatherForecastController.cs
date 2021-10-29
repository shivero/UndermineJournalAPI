using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.EntityFrameworkCore;
using MySql.Data;
using UndermineJournalAPI.Models.Db;
using AutoMapper;
using UndermineJournalAPI.Models.Data;

namespace UndermineJournalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : Controller
    {
        private readonly UndermineJournalAPI.Services.IUndermineJournalRepository _repository;
        
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, newsstandContext context, UndermineJournalAPI.Services.IUndermineJournalRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<TblDbcitem> GetItem(string searchPhrase)
        {
            var rng = new Random();

            var list = _repository.GetItemsByName(searchPhrase, "enus");
            return list;
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
        }
    }
}
