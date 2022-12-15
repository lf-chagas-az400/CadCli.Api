using Microsoft.AspNetCore.Mvc;

namespace CadCli.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientesController : ControllerBase
{
   [HttpGet]
   public IActionResult GetAll() {
    var dados = new List<Cliente> {

        new Cliente{Id=1, Nome= "Fabiano Nalin", Idade = 43},
        new Cliente{Id=2, Nome= "Priscila Mitui", Idade = 44},
        new Cliente{Id=3, Nome= "Raphael Akyu", Idade = 23},
        new Cliente {Id=4, Nome= "Nair Goes", Idade = 83},
    };

    return Ok(dados);

   }
}

public class Cliente {
    public int Id {get; set;}
    public string Nome {get; set;}
    public int Idade {get; set;}
}
