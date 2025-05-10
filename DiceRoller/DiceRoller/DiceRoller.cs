using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    internal class DiceRoller
    {
        private int ladoSorteado;

        public int LadoSorteado { get => ladoSorteado; set => ladoSorteado = value; }

        public DiceRoller()
        {
            LadoSorteado = 1;
        }

        public int Flip()
        {
            Random random = new Random();
            int resultado = random.Next(1,7);
            return (LadoSorteado);
        }
    }
}

