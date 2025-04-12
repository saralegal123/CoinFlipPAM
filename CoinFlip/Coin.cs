using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    //para o internal necessita de configurações pois uma hora pode quebrar
    public class Coin
    {
        //quando um atributo pode ser nulo ele receberá "?"
        private string ladoSorteado;
        public string LadoSorteado { get => ladoSorteado; set => ladoSorteado = value; }

        //metodos costuma ser public
        //metodo com o mesmo nome da classe é um construtor
        //Cachorro cachorro = new Cachorro()
        public Coin()
        {

        }

        public string Flip()
        {
            Random random = new Random();
            if (random.Next(2) == 0)
            {
                ladoSorteado = "Cara";
            }
            else
            {
                ladoSorteado = "Coroa";
            }

            //ladoSorteado = random.Next(2) == 0 ? "Cara" : "Coroa";
            return (ladoSorteado);
        }
    }
}
