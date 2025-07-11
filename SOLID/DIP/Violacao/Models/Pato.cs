using SOLID.DIP.Violacao.Models;
using System;

namespace SOLID.DIP.Violacao.Models
{
    public class Pato : IAnimal
    {
        public void Voar() {throw new NotSupportedException(); }
        public void Nadar()
        {
            /*
                (O pato esta sendo forçado a depender de funções das quais ele não realmente necessita)
            */
        }
        public void Grasnar() {throw new NotSupportedException();}
    }
}