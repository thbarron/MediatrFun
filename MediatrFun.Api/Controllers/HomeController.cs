using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Mediatr.Services.Models;
using Mediatr.Services.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MediatrFun.Api.Controllers
{
    [ApiController]
    [Route("books")]
    public class HomeController : ControllerBase
    {
       private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Book>> Index()
        {
            return await _mediator.Send(new GetAllBooksQuery());
        }
    }
}
