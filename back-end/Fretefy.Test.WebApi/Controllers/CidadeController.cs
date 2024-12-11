using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Features;
using AutoMapper.QueryableExtensions;
using Fretefy.Test.Domain.Dtos;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/cidade")]
    [ApiController]
    public class CidadeController : ControllerBase
    {
        private readonly ICidadeService _cidadeService;
        private readonly IMapper _mapper;

        public CidadeController(ICidadeService cidadeService, IMapper mapper)
        {
            _cidadeService = cidadeService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Cidade>>> List([FromQuery] string uf, [FromQuery] string terms)
        {
            IEnumerable<CidadeGetDto> cidadesDto;

            if (!string.IsNullOrEmpty(terms))
            {
                var cidades = await _cidadeService.Query(terms);
                cidadesDto = _mapper.Map<IEnumerable<CidadeGetDto>>(cidades);
            }
            else if (!string.IsNullOrEmpty(uf))
                cidadesDto = _mapper.Map<IEnumerable<CidadeGetDto>>(await _cidadeService.ListByUf(uf));
            else
                cidadesDto = _mapper.Map<IEnumerable<CidadeGetDto>>(await _cidadeService.List());

            return Ok(cidadesDto);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Cidade>> Get(Guid id)
        {
            var cidade = await _cidadeService.Get(id);
            return cidade != null ? Ok(cidade) : NotFound();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Cidade>> Create([FromBody] Cidade cidade)
        {
            var newCidade = await _cidadeService.Create(cidade);
            return CreatedAtAction(nameof(Get), new { Id = newCidade.Id }, newCidade);
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(Guid id, [FromBody] JsonPatchDocument<Cidade> cityPatchDocument)
        {
            var modelState = await _cidadeService.Update(id, cityPatchDocument, ModelState);
            if (modelState.IsValid)
                return Ok();
            else
                return BadRequest(modelState);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _cidadeService.Delete(id);
            return result ? Ok() : NotFound();
        }
    }
}
