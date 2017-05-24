/*
 24.05.17
 Михайлов Валентин 10МИ2
 В текстовом файле хранятся данные о маршрутах движения поездов от опредленной железнодорожной станции. Понятие  "Маршрут" описывается следующими атрибутами:
 Номер поезда                     (целое число)
 Название промежуточных станций   (три строки символов)
 Скорые поезда имею двузначный номер, пассажирские - трехзначный номер, пригородные-четырехзначный. 
 При переходе на летнее расписание назначены дополнительные пригородные поезда. Дополнительные маршруты пригородных поездов вводит пользователь.
 */
using System;

namespace Mikhaylov
{
    class MainClass
    {
        class Train
        {
            private int number;
            public static Random a = new Random();
            public static Random rand = new Random();
            private string[] travel = new string[3];
            public string getcity()
            {
                return "PERM MOSKWA MINSK GOMEL UFA UXTA BISK KOROLEV".Split(' ')[rand.Next(0, 9)];
            }
            public Train()
            {
                this.number = a.Next(10, 9999);
                this.travel[0] = getcity();
                this.travel[1] = getcity();
                this.travel[2] = getcity();
            }
            public void add(int number, string[] travel)
            {
                this.number = number;
                this.travel[0] = travel[0];
                this.travel[1] = travel[1];
                this.travel[2] = travel[2];
            }
            public void print()
            {
                Console.WriteLine(number + " " + travel[0] + " "+ travel[1] + " " + travel[2]);
            }
        }
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(3, 20);
            Train[] array = new Train[a];
            for (int i = 0; i < a; i++)
            {
                array[i] = new Train();
                array[i].print();
            }
            Console.WriteLine("Добавить пригородные поезда?(Y/N)");
            string n = Console.ReadLine();
            if (n == "Y")
            {
                Console.WriteLine("Введите кол-во новых поездов");
                int f = int.Parse(Console.ReadLine());
                Array.Resize(ref array, a + f);
                for (int i = a; i < a + f;i++)
                {
                   
                }

            }
        }
    }
}


