using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/regiao")]
    [ApiController]
    public class RegiaoController : ControllerBase
    {
        private readonly IRegiaoService _RegiaoService;

        public RegiaoController(IRegiaoService RegiaoService)
        {
            _RegiaoService = RegiaoService;
        }

        [HttpGet]
        public IActionResult List([FromQuery] string terms)
        {
            IEnumerable<Regiao> Regioes;

            if (!string.IsNullOrEmpty(terms))
                Regioes = _RegiaoService.Query(terms);
            else
                Regioes = _RegiaoService.List();

            return Ok(Regioes);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var Regioes = _RegiaoService.Get(id);
            return Ok(Regioes);
        }
    }
}
