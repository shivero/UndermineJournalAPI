using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UndermineJournalAPI.Models;
using UndermineJournalAPI.Models.Data;
using UndermineJournalAPI.Models.Db;
using UndermineJournalAPI.Services;
namespace UndermineJournalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RealmController : Controller
    {
        private IRealmRepository _repository;
        private IMapper _mapper;
        public RealmController(IRealmRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("get-realm")]
        public IEnumerable<RealmDTO> GetRealmsByName(string query, string region)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return Enumerable.Empty<RealmDTO>();
            }
            var results = _repository.GetRealmByQuery(query, region);
            return _mapper.Map<IEnumerable<RealmDTO>>(results);
            //return results;
        }
    }
}
