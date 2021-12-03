using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UndermineJournalAPI.Models.Data;
using UndermineJournalAPI.Models.Db;
using UndermineJournalAPI.Services;

namespace UndermineJournalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : Controller
    {
        private readonly IItemRepository _repository;
        private readonly ILogger<ItemController> _logger;
        private readonly IMapper _mapper;
        public ItemController(IItemRepository context, ILogger<ItemController> logger, IMapper mapper)
        {
            _repository = context;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("get-items")]
        public IEnumerable<ItemDTO> GetItems(string searchPhrase)
        {

            _logger.LogInformation($"Starting search for item name: {searchPhrase}", searchPhrase);
            var list = _repository.GetItemsByName(searchPhrase, "enus").ToList();
            _logger.LogInformation($"Found {list.Count} items");
            return _mapper.Map<IEnumerable<ItemDTO>>(list);
        }

        [HttpGet]
        [Route("daily-history")]
        public IEnumerable<ItemHistoryDailyDTO> GetItemHistoryDaily(int itemId, int realmId)
        {
            _logger.LogInformation($"Request daily history for item: {itemId} on realm {realmId}");
            var result = _repository.GetItemDailyHistory(itemId, realmId);

            return _mapper.Map<IEnumerable<ItemHistoryDailyDTO>>(result);
        }
    }
}
