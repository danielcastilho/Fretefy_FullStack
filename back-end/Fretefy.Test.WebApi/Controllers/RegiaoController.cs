using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Fretefy.Test.Domain.Dtos;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/regiao")]
    [ApiController]
    public class RegiaoController : ControllerBase
    {
        private readonly IRegiaoService _RegiaoService;
        private readonly IMapper _mapper;

        public RegiaoController(IRegiaoService RegiaoService, AutoMapper.IMapper mapper)
        {
            _RegiaoService = RegiaoService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<RegiaoGetDto>>> List([FromQuery] string terms)
        {
            IEnumerable<Regiao> regioes;

            if (!string.IsNullOrEmpty(terms))
                regioes = await _RegiaoService.Query(terms);
            else
                regioes = await _RegiaoService.List();
            IEnumerable<RegiaoGetDto> regioesDto = _mapper.Map<IEnumerable<RegiaoGetDto>>(regioes);
            return Ok(regioesDto);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<RegiaoGetDto>> Get(Guid id)
        {
            var regiao = await _RegiaoService.Get(id);
            var regiaoDto = _mapper.Map<RegiaoGetDto>(regiao);
            return regiao != null ? Ok(regiaoDto) : NotFound();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<RegiaoGetDto>> Create([FromBody] RegiaoNewDto regiao)
        {
            var newRegiao = await _RegiaoService.Create(_mapper.Map<Regiao>(regiao));
            var newRegiaoDto = _mapper.Map<RegiaoGetDto>(newRegiao);
            return CreatedAtAction(nameof(Get), new { Id = newRegiaoDto.Id }, newRegiaoDto);
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(Guid id, [FromBody] JsonPatchDocument<Regiao> regiaoPatchDocument)
        {
            var modelState = await _RegiaoService.Update(id, regiaoPatchDocument, ModelState);
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
            var result = await _RegiaoService.Delete(id);
            return result ? Ok() : NotFound();
        }
    }
}
