using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CsharpCity.Models
{
    public class Guard
    {
        //De geheime sleutel van de poort
        private Key _key;
        public Key key { get {
                return _key;
            } set {
                _key = value;
            }
        }

        //Was er maar een manier om aan de sleutel te komen.....

        public Guard()
        {
            _key = new Key("Kluis sleutel");
        }
    }
}
