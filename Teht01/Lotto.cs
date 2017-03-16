using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Lotto
    {
        public int numero { get; set; }
        private List<int>lista { get; set; }
        public List<int>valmislista { get; set; }
         

        public void Arvonta()
        {
            int i = 0;
            if (i < 7) { 
                
                Random rand = new Random();
                int numero = rand.Next(1, 39 + 1);
                lista.Add(numero);
                i++;
            }
        else
            {

                lista = lista;
            
            }

        }
        
    }
}
