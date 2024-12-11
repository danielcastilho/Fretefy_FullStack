using System;
using System.Collections.Generic;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
    }
}
