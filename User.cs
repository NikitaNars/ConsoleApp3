using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class User
    {
        private string name;
        private string surname;
        private string patronymic;

        public User(string name, string surname, string patronymic) 
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
        }
        public void SNP()
        {
            Console.WriteLine($"Фамилия: {surname}, Имя: {name}, Отчество: {patronymic}");
        }
    }
}
