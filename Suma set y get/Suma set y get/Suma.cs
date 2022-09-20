using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_set_y_get
{
    internal class Sumaclass
    {
        
        private int N1;
        private int N2;

       
        public int N11 { get => N1; set => N1 = value; }
        public int N12 { get => N2; set=>N2 = value; }

        

        
        public int Suma()
        {
            return (N11 + N12);
        }
    }
}
