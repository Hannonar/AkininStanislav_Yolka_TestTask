using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICallingLib
{
    public class OpenStreetMapAPICommand : BaseAPICommand//Класс упрощен до минимума, необходимого для демонстрации функционала
    {
        static OpenStreetMapAPICommand()
        {
            BaseURL = "https://nominatim.openstreetmap.org/";
        }

        public OpenStreetMapAPICommand(string address)
        {
            CommandURL = $"search?q={address}&format=json&polygon_geojson=1";
        }

        public string CommandURL { get;}

        public override string GetURL()
        {
            return BaseURL + CommandURL;
        }
    }
}
