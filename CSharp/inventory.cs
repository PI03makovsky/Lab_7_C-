using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp

{

    struct inventory

    {

        private int nballs; // количество мячей

        private int ngates; // количество ворот

        private String typeOFc; // тип покрытия

        player invntrP;

        public int Nballs
        {
            get => nballs;
            set => nballs = value;
        }
        public int Ngates
        {
            get => ngates;
            set => ngates = value;
        }
        public string TypeOFc
        {
            get => typeOFc;
            set => typeOFc = value;
        }

        private void init(int nb, int ng, String toc, player IP1) // Метод создания

        {

            nballs = nb;

            ngates = ng;

            typeOFc = toc;

            player invntrP = IP1;

        }

        private void enter() //Метод ввода

        {

            Console.Write("\nВведите количество мячей: ");

            nballs = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nВведите количество ворот: ");

            ngates = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nВведите тип покрытия: ");

            typeOFc = Console.ReadLine();

            Console.Write("\nВведите одного из судей, который будет обслуживать ваш матч(Лайнсмен или Судья)");

        }

        private int valueInventory() //Метод расчета цены

        {

            int rREF = 0;

            rREF = (nballs * 100) + (ngates * 75);

            Console.Write($"\nНадбавка к стоимости {rREF} ");

            return rREF;

        }

        private void print() //Метод вывода

        {

            Console.Write($"\nКоличество мячей: {nballs} ");

            Console.Write($"\nКоличество ворот: {ngates} ");

            Console.Write($"\nТип покрытия {typeOFc}");

        }

    }

}