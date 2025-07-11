using SOLID.ISP.Violacao.Models;
using System;

namespace SOLID.ISP.Violacao.Models
{
    public class Geladeira : IEletrodomestico
    {
        public void Aquecer() { throw new NotSupportedException(); }
        public void Esfriar()
        {
            /*
                (A geladeira esta sendo forçada a depender de funções das quais ela não realmente necessita)
            */
        }
        public void Triturar() { throw new NotSupportedException(); }
    }
}