using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{

    [ApiController]
    [Route("[controller]")] //movie (modificacao da rota)

    public class MovieController : ControllerBase
    {
        public MovieController()      //construtor deve ter o mesmo nome da classe
        {

        }
        [HttpPost] //notacao que indica metodo post
        public string Post()
        {
            return "Put";
        }
        [HttpGet]
        public string Get()
        {
            return "Get";
        }
        [HttpDelete]
        public string Delete()
        {
            return "Delete";
        }
    }
}