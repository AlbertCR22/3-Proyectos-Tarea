using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso3
{
    class polimorfismo
    {

        public void ponerMarca()
        {
            Console.WriteLine("Sin nada");
        }
        public void ponerMarca(int año)
        {
            Console.WriteLine("Vehículo año : "+ año);
        }
        public void ponerMarca(int año, string modelo)
        {
            Console.WriteLine("Carro año : " + año + " modelo : "+ modelo);
        }

    }
}
