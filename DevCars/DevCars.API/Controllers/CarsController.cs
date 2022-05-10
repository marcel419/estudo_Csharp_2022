using DevCars.API.InputModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCars.API.Controllers
{
    [Route("api/cars")]
    public class CarsController : ControllerBase
    {
        //Get api/cars
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
        //Get api/cars/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //Se o ID carro não existir retorna NotFound
            //Senão  ok
            return Ok();
        }

        //Post api/cars/1
        [HttpPost]
        public IActionResult Post([FromBody] AddCarInputModel model)
        {
            //Se o cadastro funcionar, retorna created(201)
            //Se os dados de entrada estiverem incorretos, retorna BAD request(400)
            //se o cadastro funcionar, mas não tiver uma api de consulta, retorna NOContent(204)
            return Ok();
        }

        //Put api/cars/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateCarInputModel model)
        {
            // se a atulização funcionar, retorna 204 NOContent
            // se dados de entrada estiverem incorretos, retorna 400 bad Request
            // se nãoexistir, retorna Not Found 404
            return Ok();
        }

        //Delete api/cars/2
        [HttpDelete("{id}")]
       public IActionResult Delete(int id)
        {
            //se nao existir, retorna not found 404
            //se for com sucesso, retorna no content 204
            return Ok();
        }
    }
}
