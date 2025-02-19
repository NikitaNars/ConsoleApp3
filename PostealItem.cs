using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class PostealItem
    {
        private int index;
        private string city;
        private string street;
        private int numHouse;
        private string housing;
        private int numApartaments;
        private string mail;

        public PostealItem(int index, string city, string street, int numHouse, string housing, int numApartaments, string mail)
        {
            this.index = index;
            this.city = city;
            this.street = street;
            this.numHouse = numHouse;
            this.housing = housing;
            this.numApartaments = numApartaments;
            this.mail = mail;
        }
        public void PrintAdress()
        {
            Console.WriteLine($"Почтовый индекс: {index}, Город: {city}, Улица: {street}, Номер дома: {numHouse}, Корпус: {housing}, Квартира: {numApartaments}, Сообщение: {mail}");
        }
    }
}
