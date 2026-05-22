using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaSemFactory
{
    public sealed class PizzaSimpleFactory
    {
        public static Pizza CriaPizza(string tipo)
        {
            Pizza pizza;
            switch (tipo)
            {
                case "C":
                    pizza = new PizzaCalabreza();
                    break;
                case "M":
                    pizza = new PizzaMussarela();
                    break;
                default:
                    throw new Exception("Tipo de pizza inválida");
            }
            return pizza;
        }

    }
}
