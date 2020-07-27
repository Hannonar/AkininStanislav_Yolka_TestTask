using APICallingLib;
using APICallingLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkininStanislav_Yolka_TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string address, fileName;
            int pointFrequency;
            BaseAPICommand getPolygon;

            APICaller.InitializeClient();

            // TODO: Добавить валидацию вводимых значений

            Console.WriteLine("Введите адрес для поиска полигона");
            address = Console.ReadLine();

            Console.WriteLine("Введите частоту точек");
            pointFrequency = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите имя файла");
            fileName = Console.ReadLine();

            getPolygon = new OpenStreetMapAPICommand(address);

            var coordinates = RequestProcessor.LoadData<CoordinatesModel>(getPolygon);

            Console.ReadKey();
        }
    }
}
