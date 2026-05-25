using System;

namespace PizzariaSemFactory
{
    public class PizzaCalabreza : Pizza
    {
        public PizzaCalabreza()
        {
            Nome = "Pizza de Calabreza";
        }
        
        public override void Preparar()
        {
            Console.WriteLine($"Preparando {Nome}");
        }

        public override void Assar(int tempo)
        {
            Console.WriteLine($"Assando {Nome} por {tempo} minutos");
        }

        public override void Embalar()
        {
            Console.WriteLine($"Embalando {Nome}");
        }

    }
}
