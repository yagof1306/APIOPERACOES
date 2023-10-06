using Microsoft.AspNetCore.Mvc;
using PrimeiraAPI.BLL.Interfaces;
using PrimeiraAPI.Models;

namespace PrimeiraAPI.BLL
{
    public class OperacoesBLL : IOperacoesBLL
    {
        public float SOMA(float num1, float num2)
        {
            float valor = num1 + num2;
            return valor;
        }
    }
}
