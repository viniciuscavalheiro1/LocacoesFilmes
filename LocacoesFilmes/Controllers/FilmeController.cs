using Microsoft.AspNetCore.Mvc;

namespace LocacoesFilmes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        [HttpGet]
        public string HelloWord() => "Hello Word";
    }
}
