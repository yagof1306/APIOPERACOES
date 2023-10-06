using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using PrimeiraAPI.BLL;
using PrimeiraAPI.BLL.Interfaces;
using PrimeiraAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrimeiraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacoesController : ControllerBase
    {

        private readonly IOperacoesBLL _IOperacoesBLL;

        public OperacoesController(IOperacoesBLL _iOperacoesBLL)
        {
            _IOperacoesBLL = _iOperacoesBLL;
        }

        [HttpPost("soma")]
        public float Soma([FromBody] OperacaoModel operacao)
        {
            return _IOperacoesBLL.SOMA(2, 2);

        }

    }   
}
    