using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace NewsGraderServer.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        protected IMapper Mapper { get; }

        protected ILogger Logger { get; }

        protected BaseController(IMapper mapper, ILogger logger)
        {
            Logger = logger;
            Mapper = mapper;
        }
    }
}
