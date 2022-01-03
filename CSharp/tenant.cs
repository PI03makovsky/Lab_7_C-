﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp

{

    struct tenant

    {

        String name; //имя

        String surname; //фамилия

        String patronymic; //отчество

        private readonly date tntD; // связка с классом дата


        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Surname
        {
            get => surname;
            set => surname = value;
        }
        public string Patronymic
        {
            get => patronymic;
            set => patronymic = value;
        }


        public void init1(String n, String s, String p, date D1) //Метод создания

        {

            name = n;

            surname = s;

            patronymic = p;

            date tndD = D1;

        }

        public void enterT() //Метод ввода

        {

            Console.Write("\nВведите имя: ");

            name = Console.ReadLine();

            Console.Write("\nВведите фамилию: ");

            surname = Console.ReadLine();

            Console.Write("\nВведите отчество: ");

            patronymic = Console.ReadLine();

            Console.Write("\nВведите день рождения\n");

        }

        public int printer() //Метод вывода

        {

            Console.WriteLine($"\nИмя: {this.Name} Фамилия: {this.Surname} Отчество: {this.Patronymic} ");

            Console.WriteLine($"\nДень рождения {tntD} ");

            return 0;

        }

        // Out ref
        public void OutData(out string name, out string surname, out string patronymic)
        {
            name = this.name;
            surname = this.surname;
            patronymic = this.patronymic;
        }
        public void RefData(ref string name, ref string surname, ref string patronymic)
        {
            name = this.name;
            surname = this.surname;
            patronymic = this.patronymic;
        }
    }

}