using CadastroVeiculosAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroVeiculosAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculosController : ControllerBase
    {
        private static List<Veiculo> veiculos = new List<Veiculo>();
        private static int id = 1;

        [HttpPost]
        public IActionResult AdicionaVeiculo([FromBody] Veiculo veiculo)
        {
            veiculo.Id = id++;
            veiculos.Add(veiculo);
            return CreatedAtAction(nameof(RecuperarVeiculoPorId), new { Id = veiculo.Id }, veiculo);
        }

        [HttpGet]
        public IActionResult BuscaVeiculos()
        {
            return Ok(veiculos);
        }


        [HttpGet("{id}")]
        public IActionResult RecuperarVeiculoPorId(int id)
        {
            Veiculo veiculo = veiculos.FirstOrDefault(veiculo => veiculo.Id == id);
            if(veiculo != null)
            {
                return Ok(veiculo);
            }
            return NotFound();
        }


        [HttpPut("{id}")]
        public IActionResult AtualizaVeiculoPorId(int id, [FromBody] Veiculo veiculoNovo)
        {
            Veiculo veiculo = veiculos.FirstOrDefault(veiculo => veiculo.Id == id);
            if (veiculo == null)
            {
                return NotFound();
            }
            veiculo.veiculoNome = veiculoNovo.veiculoNome;
            veiculo.marca = veiculoNovo.marca;
            veiculo.ano = veiculoNovo.ano;
            veiculo.descricao = veiculoNovo.descricao;
            veiculo.updated = veiculoNovo.updated;

            return NoContent();

        }

        [HttpPatch("{id}")]
        public IActionResult AtualizaDadosVeiculoPorId(int id, [FromBody] Veiculo veiculoNovo)
        {
            //Desenvolver

            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaVeiculo(int id)
        {
            Veiculo veiculo = veiculos.FirstOrDefault(veiculo => veiculo.Id == id);
            if (veiculo == null)
            {
                return NotFound();
            }
            veiculos.Remove(veiculo);
            return NoContent();
        }

    }
}
