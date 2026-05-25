using System;

namespace PizzariaSemFactory
{
    public class Pizzaria
    {
        public static void SolicitaPizza()
        {
           
            Console.WriteLine("======Pizzaria==========");
            Console.WriteLine("Informe a Pizza (C)alabreza ou (M)ussarela \n");
            var tipo = Console.ReadLine().ToUpper();
            try 
            {
                Pizza pizza = PizzaSimpleFactory.CriaPizza(tipo);
                pizza.Preparar();
                pizza.Assar(15);
                pizza.Embalar();
                Console.WriteLine("Pizza pronta, bom apetite!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errop: " + ex.Message);
            }
            
        }
    }
}
