using SOLID.DIP.Solucao.Models;
using System;

namespace SOLID.DIP.Solucao.Models
{
    public class Pato : IVoar
    {
        public void Voar()
        {
            Console.WriteLine("O pato está voando.");
        }
    }
}