using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp

{

    struct orginf

    {

        private int price; //цена закупа еды

        private int rent; //время аренды

        tenant OIT; // связка с классом арендатор

        public int Price
        {
            get => price;
            set => price = value;
        }
        public int Rent
        {
            get => rent;
            set => rent = value;
        }

        public void init(int p, int r, tenant T1) // Метод создания

        {

            price = p;

            rent = r;

            tenant OIT = T1;

        }

        public void enterOI() //Метод ввода

        {

            Console.Write("\n\nВведите цену закупа еды: ");

            price = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\nВведите время аренды(только почасовая): ");

            rent = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\nВведите ФИО поручителя в случае форсмажора: ");

        }

        public int valueOrginf() //Метод расчета цены

        {

            int sum; // общая цена

            int fsum = 500; // фиксированная цена

            sum = fsum + price * rent;

            Console.WriteLine($"\nЦена аренды {sum} ");

            return sum;

        }

        public int printOI() //Метод вывода

        {

            Console.WriteLine($"\nЦена закупа еды {price} ");

            Console.WriteLine($"\nВремя аренды {rent} ");

            return 0;

        }

    }

}