using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_13._02
{
   
        class Program
        {
            #region 1
            class Money
            {
                public int Dollar { get; set; }
                public int DollarCent { get; set; }
                public int Euro { get; set; }
                public int EuroCent { get; set; }
                public int Grivna { get; set; }
                public int Copiyka { get; set; }
                public Money(int dollar, int dollarCent, int euro, int euroCent, int grivna, int copiyka)
                {
                    Dollar = dollar;
                    DollarCent = dollarCent;
                    Euro = euro;
                    EuroCent = euroCent;
                    Grivna = grivna;
                    Copiyka = copiyka;
                }
                public Money() : this(0, 0, 0, 0, 0, 0) { }
                public void Print()
                {
                    Console.WriteLine($"{Dollar}.{DollarCent} USD\n{Euro}.{EuroCent} EUR\n{Grivna}.{Copiyka} GRN");
                }
            }
            class Product : Money
            {
                public int Price { get; set; }
                public int PriceCent { get; set; }
                public Product(int price, int priceCent, int dollar, int dollarCent, int euro, int euroCent, int grivna, int copiyka)
                    : base(dollar, dollarCent, euro, euroCent, grivna, copiyka)
                {
                    Price = price;
                    PriceCent = priceCent;
                }
                public Product(int price, int priceCent)
                {
                    Price = price;
                    PriceCent = priceCent;
                }
                public Product() : this(0, 0, 0, 0, 0, 0, 0, 0) { }
                public void BuyDollar()
                {
                    base.Dollar -= Price;
                    base.DollarCent -= PriceCent;
                }
                public void BuyEuro()
                {
                    base.Euro -= Price;
                    base.EuroCent -= PriceCent;
                }
                public void BuyGrivna()
                {
                    base.Grivna -= Price;
                    base.Copiyka -= PriceCent;
                }
            }
            #endregion

            #region 2
            class Device
            {
                public string Name { get; set; }
                public string Description { get; set; }
                public string Sound { get; set; }
                public Device(string name, string sound, string description)
                {
                    Name = name;
                    Sound = sound;
                    Description = description;
                }
                public Device() : this("", "", "") { }
                public void Print()
                {
                    Console.WriteLine($"Device: {Name}, Sound: {Sound}, Description: {Description}");
                }
            }
            class Kettle : Device
            {
                public Kettle(string name, string sound, string desc) : base(name, sound, desc) { }
                public Kettle() : base("Чайник", "Свист", "Для подогрева воды") { }

            }
            class Microwave : Device
            {
                public Microwave(string name, string sound, string desc) : base(name, sound, desc) { }
                public Microwave() : base("Микроволновка", "Микро-шум", "Для подогрева еды") { }
            }
            class Auto : Device
            {
                public Auto(string name, string sound, string desc) : base(name, sound, desc) { }
                public Auto() : base("Автомобиль", "Работа карбюрат/диз двигателя", "Для езды по дорогам") { }
            }
            class Steamer : Device
            {
                public Steamer(string name, string sound, string desc) : base(name, sound, desc) { }
                public Steamer() : base("Пароход", "Работа парового двигателя", "Для езды по рельсам") { }
            }
            #endregion

            #region 3
            class Music
            {
                public string Name { get; set; }
                public string Description { get; set; }
                public string Sound { get; set; }
                public string History { get; set; }
                public Music(string name, string description, string sound, string history)
                {
                    Name = name;
                    Description = description;
                    Sound = sound;
                    History = history;
                }
                public Music() : this("", "", "", "") { }
                public void Print()
                {
                    Console.WriteLine($"Name: {Name}\nDescription: {Description}\nSound: {Sound}\nHistory: {History}");
                }
            }
            class Violin : Music
            {
                public Violin() : base("Violin", "Orchestra", "Creak", "16 century") { }
                public Violin(string name, string description, string sound, string history) : base(name, description, sound, history) { }
            }
            class Trombone : Music
            {
                public Trombone() : base("Trombone", "Orchestra", "Horn", "15 century") { }
                public Trombone(string name, string description, string sound, string history) : base(name, description, sound, history) { }
            }
            class Ukulele : Music
            {
                public Ukulele() : base("Ukulele", "Guitar", "String", "19 century") { }
                public Ukulele(string name, string description, string sound, string history) : base(name, description, sound, history) { }
            }
            class Cello : Music
            {
                public Cello() : base("Cello", "Orchestra", "Creak", "15 century") { }
                public Cello(string name, string description, string sound, string history) : base(name, description, sound, history) { }
            }
            #endregion

            #region 4
            abstract class Worker
            {
                virtual public void Print() { }
            }
            class President : Worker
            {
                public string Name { get; set; }
                public string Description { get; set; }
                public President(string name, string description)
                {
                    Name = name;
                    Description = description;
                }
                public override void Print()
                {
                    Console.WriteLine($"Name: {Name}\nDescription {Description}");
                }
            }
            class Security : Worker
            {
                public string Name { get; set; }
                public string Description { get; set; }
                public Security(string name, string description)
                {
                    Name = name;
                    Description = description;
                }
                public override void Print()
                {
                    Console.WriteLine($"Name: {Name}\nDescription {Description}");
                }
            }
            class Manager : Worker
            {
                public string Name { get; set; }
                public string Description { get; set; }
                public Manager(string name, string description)
                {
                    Name = name;
                    Description = description;
                }
                public override void Print()
                {
                    Console.WriteLine($"Name: {Name}\nDescription {Description}");
                }
            }
            class Engineer : Worker
            {
                public string Name { get; set; }
                public string Description { get; set; }
                public Engineer(string name, string description)
                {
                    Name = name;
                    Description = description;
                }
                public override void Print()
                {
                    Console.WriteLine($"Name: {Name}\nDescription {Description}");
                }
            }
            #endregion

    }
}
