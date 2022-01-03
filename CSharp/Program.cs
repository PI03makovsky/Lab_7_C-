using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp

{

    class Program

    {

        static void Main(string[] args)

        {

            /*date rez = new date();

            date dataINPUT = new date();

            date dataEST = new date();

            dataINPUT.init(20, 12, 2021); // дата основания

            dataEST.init(20, 12, 2020); // дата аренды

            int a;

            a = rez.SCHET(dataINPUT, dataEST);

            Console.Write($"Разница: {a} \n");

            tenant tenantFIO = new tenant();

            date tenantFIO1 = new date();

            tenantFIO.enterT(); // ввод фио

            tenantFIO1.enterD(); // ввод даты

            tenantFIO.printer(); // ФИО арендатора

            tenantFIO1.print(); // вывод даты рождения

            orginf ofINF1 = new orginf();

            tenant ofINF2 = new tenant();

            date ofINF3 = new date();

            player playerP1 = new player();

            date playerP2 = new date();

            inventory inv1 = new inventory();

            orginf inv2 = new orginf();

            date inv3 = new date();*/

            Players();
            functionOut();
            functionRef();

            // Твой массив
            void Players()
            {
                int size;
                Console.WriteLine("  Сколько игроков вы хотите создать: ");
                while (!int.TryParse(Console.ReadLine(), out size)) { Console.WriteLine("Ошибка. Введите число: "); }
                player[] list = new player[size];
                for (int i = 0; i < size; i++)
                {
                    date playerDate = new date();
                    list[i] = new player();
                    list[i].enter();
                    playerDate.enterD();
                    list[i].PlrD = playerDate;
                }
                Console.WriteLine("  Введённые вами данные: ");
                for (int i = 0; i < size; i++)
                {
                    list[i].printForMass();
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            // Out Ref

            void functionOut()
            {
                tenant TenantOut = new tenant();
                date Date = new date();
                TenantOut.enterT(); // ввод фио
                Date.enterD(); // ввод даты

                String name;
                String surname;
                String patronymic;

                TenantOut.OutData(out name, out surname, out patronymic);

                Console.Write("\n  Имя: {0}, Фамилия {1}, Отчество {2}\n", name, surname, patronymic);
            }

            void functionRef()
            {
                tenant TenantOut = new tenant();
                date Date = new date();

                TenantOut.enterT(); // ввод фио
                Date.enterD(); // ввод даты

                String name = "";
                String surname = "";
                String patronymic = "";

                TenantOut.RefData(ref name, ref surname, ref patronymic);

                Console.Write("\n  Имя: {0}, Фамилия {1}, Отчество {2}\n", name, surname, patronymic);
            }
        }
       
    }

}