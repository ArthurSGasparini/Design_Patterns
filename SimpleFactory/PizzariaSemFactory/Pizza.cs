using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaSemFactory
{
    public abstract class Pizza
    {
        public string Nome { get; set; }
        public abstract void Preparar();
        public abstract void Assar(int tempo);
        public abstract void Embalar();

    }
}
