using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4._2
{
    internal class Powerplant
    {
        private Warning _wa; //delegate instancen
        private Random _random = new Random(); //Tilfældighedsgenerator


        public void SetWarnning(Warning wa)
        {
            _wa = wa;
            //_wa += wa;

        }


        public void HeatUp()
        {
            int temperature = _random.Next(0, 101);

            Console.WriteLine($"Current Temperature: {temperature}");

            if (temperature > 50)
            {
                _wa(); // Udløser advarslen, hvis der er sat en metode til og _wa(); samme som _wa.Invoke();
            }
        }



        
    }
}
