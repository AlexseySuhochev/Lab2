using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2Decorator2
{
     class Base
    {
        public String ФИО;
        public String Дата_Рождения;
        public String Пол;
        public String Место_Работы;
        //public abstract void Operation();
        //public abstract void Вывести_Паспорт();
        //public abstract void Вывести_Страховой_Полис();
        //public abstract void Вывести_Банковская_Карта();
        //public abstract void Вывести_Водительские_Права();
        public Base(string ФИО, string Дата_Рождения, string Пол, string Место_Работы)
        {
            this.ФИО = ФИО;
            this.Дата_Рождения = Дата_Рождения;
            this.Пол = Пол;
            this.Место_Работы = Место_Работы;

        }
        public void вывести_всё()
        {
            Console.WriteLine("********Graps********");
            Console.WriteLine("ФИО: {0}", ФИО);
            Console.WriteLine("Дата рождения: {0}", Дата_Рождения);
            Console.WriteLine("Пол: {0}", Пол);
            Console.WriteLine("Место работы: {0}", Место_Работы);
        }
    }
    class Decorator_Паспорт : Base
    {
        public String Серийный_Номер_Паспорта;
        public String Кем_Выдан_Паспорт;
        public String Когда_Выдан_Паспорт;

        public void Вывести_Паспорт()
        {
            base.вывести_всё();
            Console.WriteLine("Серийный Номер Паспорта: {0}", Серийный_Номер_Паспорта);
            Console.WriteLine("Кем Выдан Паспорт: {0}", Кем_Выдан_Паспорт);
            Console.WriteLine("Когда Выдан Паспорт: {0}", Когда_Выдан_Паспорт);
            Console.WriteLine("==========================");
            Console.WriteLine(" ");
        }
        public Decorator_Паспорт(string Серийный_Номер_Паспорта, string Кем_Выдан_Паспорт, string Когда_Выдан_Паспорт, string ФИО, string Дата_Рождения, string Пол, string Место_Работы)
            : base(ФИО, Дата_Рождения, Пол, Место_Работы)
        {
            this.Кем_Выдан_Паспорт = "Кем_Выдан_Паспорт";
            this.Серийный_Номер_Паспорта = "Серийный_Номер_Паспорта";
            this.Когда_Выдан_Паспорт = "Когда_Выдан_Паспорт";
            this.Кем_Выдан_Паспорт = Кем_Выдан_Паспорт;
            this.Серийный_Номер_Паспорта = Серийный_Номер_Паспорта;
            this.Когда_Выдан_Паспорт = Когда_Выдан_Паспорт;
        }
        
    }
    class Decorator_стр_полис : Base
    {
        public string Номер_сп;
        public string Срок_годности_сп;
        public void вывести_сп()
        {
            base.вывести_всё();
            Console.WriteLine("Номер страхового полиса {0}", Номер_сп);
            Console.WriteLine("Срок годности страхового полиса {0}", Срок_годности_сп);
            Console.WriteLine("==========================");
            Console.WriteLine(" ");
        }
        public Decorator_стр_полис(string Номер_сп, string Срок_годности_сп, string ФИО, string Дата_Рождения, string Пол, string Место_Работы)
            : base(ФИО, Дата_Рождения, Пол, Место_Работы)
        {
            this.Номер_сп = "Номер_сп";
            this.Срок_годности_сп = "Срок_годности_сп";
            this.Номер_сп = Номер_сп;
            this.Срок_годности_сп = Срок_годности_сп;
        }
    }
    class decorator_банк_карта : Base
    {
        public string номер_бк;
        public int код_безопастности_бк;
        public string срок_годности_бк;
        public void вывести_бк()
        {
          base.вывести_всё();
          Console.WriteLine("Номер банковской карты {0}", номер_бк);
          Console.WriteLine("код безопасности банковской карты {0}", код_безопастности_бк);
          Console.WriteLine("срок годности банковской карты {0}", срок_годности_бк);
          Console.WriteLine("==========================");
          Console.WriteLine(" ");
        }
         public decorator_банк_карта(string номер_бк, string код_безопастности_бк, string срок_годности_бк, string ФИО, string Дата_Рождения, string Пол, string Место_Работы)
            : base(ФИО, Дата_Рождения, Пол, Место_Работы)
            {
               this.номер_бк = "номер_бк";
               this.код_безопастности_бк = "код_безопастности_бк";
               this.срок_годности_бк = "срок_годности_бк";
               this.номер_бк = номер_бк;
               this.код_безопастности_бк = код_безопастности_бк;
               this.срок_годности_бк = срок_годности_бк;
            }
    }
    //class decorator_вод_права : Base
    //{
    //    public string категории_вп;
    //    public string срок_годности_вп;
    //    public void вывести_вп()
    //    {
    //        console.writeline(категории_вп);
    //        console.writeline(срок_годности_вп);
    //    }
    //}
    class Program
    {

        static void Main(string[] args)
        {
            String Серийный_Номер_Паспорта = "093456";
            String Кем_Выдан_Паспорт = "УФМС";
            String Когда_Выдан_Паспорт = "5 марта 1978 год";
            String ФИО = "Филимонько Натон Аристархович";
            String Дата_Рождения = " 1 марта 1960 год";
            String Пол = "Муж";
            String Место_Работы = "Автомастерская";
            String Номер_сп = "1432 5633 4565";
            String Срок_годности_сп = " 10 декабря 2018 год";
            String номер_бк = "2678 8754 1237 5491";
            String код_безопастности_бк = "178";
            String срок_годности_бк = "Октябрь 2025 года";
            Decorator_Паспорт obj1 = new Decorator_Паспорт(Серийный_Номер_Паспорта, Кем_Выдан_Паспорт, Когда_Выдан_Паспорт, ФИО, Дата_Рождения, Пол, Место_Работы);
            Decorator_стр_полис obj2 = new Decorator_стр_полис(Номер_сп, Срок_годности_сп, ФИО, Дата_Рождения, Пол, Место_Работы);
            decorator_банк_карта obj3 = new decorator_банк_карта(номер_бк, код_безопастности_бк, срок_годности_бк, ФИО, Дата_Рождения, Пол, Место_Работы);
            obj1.Вывести_Паспорт();
            obj2.вывести_сп();
            obj3.вывести_бк();
            Console.ReadKey();
        }
    }
}
