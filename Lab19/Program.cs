using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    class Computer

    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string ProcessorTupe { get; set; }
        public int Frequency { get; set; }
        public int AmountMemory { get; set; }
        public int HardDisk { get; set; }
        public int VideoCard { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> listComputer = new List<Computer>()
            {
                new Computer(){Code=1, Name="Apple", ProcessorTupe="M1 Max", Frequency=2000, AmountMemory=16, HardDisk=128, VideoCard=256, Price=110000, Quantity=20},
                new Computer(){Code=2, Name="Dell", ProcessorTupe="Intel CORE i5", Frequency=3000, AmountMemory=16, HardDisk=128, VideoCard=512, Price=80000, Quantity=10},
                new Computer(){Code=3, Name="Asus", ProcessorTupe="Intel CORE i3", Frequency=2000, AmountMemory=8, HardDisk=128, VideoCard=512, Price=90000, Quantity=15},
                new Computer(){Code=4, Name="Xiaomi", ProcessorTupe="Pentium", Frequency=3200, AmountMemory=8, HardDisk=128, VideoCard=1, Price=120000, Quantity=23},
                new Computer(){Code=5, Name="Lenovo", ProcessorTupe="Intel CORE i5", Frequency=2000, AmountMemory=16, HardDisk=128, VideoCard=1, Price=100000, Quantity=100},
                new Computer(){Code=6, Name="Sony", ProcessorTupe="Celeron", Frequency=3200, AmountMemory=4, HardDisk=128, VideoCard=256, Price=60000, Quantity=12},
                new Computer(){Code=7, Name="Aser", ProcessorTupe="Intel CORE i3", Frequency=3000, AmountMemory=8, HardDisk=128, VideoCard=256, Price=75000, Quantity=33},
                new Computer(){Code=8, Name="Toshiba", ProcessorTupe="Pentium", Frequency=3000, AmountMemory=16, HardDisk=128, VideoCard=1, Price=83000, Quantity=19},
                new Computer(){Code=9, Name="HP", ProcessorTupe="Celeron", Frequency=3200, AmountMemory=8, HardDisk=128, VideoCard=1, Price=77000, Quantity=2}
            };
            // Определяем компьютеры с указанным пользователем процессором

            Console.Write("Введите тип процессора: ");
            string a = Console.ReadLine();
            List<Computer> computers = listComputer
                .Where(c => c.ProcessorTupe == a)
                .ToList();
            foreach (Computer c in computers)
                Console.WriteLine($"{c.Code} {c.Name} {c.ProcessorTupe} {c.Frequency} {c.AmountMemory} {c.HardDisk} {c.VideoCard} {c.Price} {c.Quantity} ");

            // Определяем компьютеры с указанной пользователем ОЗУ
           
            Console.WriteLine();
            Console.Write("Введите объем ОЗУ: ");
            int b = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers1 = listComputer
                .Where(c => c.AmountMemory == b)
                .ToList();
            foreach (Computer c in computers1)
                Console.WriteLine($"{c.Code} {c.Name} {c.ProcessorTupe} {c.Frequency} {c.AmountMemory} {c.HardDisk} {c.VideoCard} {c.Price} {c.Quantity} ");

            // Выведем список отсортированный по увеличению стоимости
            Console.WriteLine();
            Console.WriteLine("Сортировка по увеличению стоимости");
            var computers2 = listComputer
                .OrderBy(c => c.Price)
                .ToList();
            foreach (Computer c in computers2)
                Console.WriteLine($"{c.Code} {c.Name} {c.ProcessorTupe} {c.Frequency} {c.AmountMemory} {c.HardDisk} {c.VideoCard} {c.Price} {c.Quantity} ");

            // Выведем список сгруппированный по типу процессора
            Console.WriteLine();
            Console.WriteLine("Группировка по типу процессора");
            var computers3 = listComputer
                .GroupBy(c => c.ProcessorTupe)
                .Select(d =>
                new {
                    ProcessorTupe = d.Key,
                    })
                .ToList();
            foreach (var d in computers3)
                Console.WriteLine(d.ProcessorTupe);
            

            // Найдем самый дорогой компьютер
            Console.WriteLine();
            Console.Write("Стоимость самого дорого компьютера: ");
            var computers4 = listComputer
                .Max(c => c.Price);

            Console.WriteLine(computers4);

            // Найдем самый бюджетный компьютер
            Console.WriteLine();
            Console.Write("Стоимость бюджетного компьютера: ");
            var computers5 = listComputer
                .Min(c => c.Price);

            Console.WriteLine(computers5);

            // Определим есть ли хотя бы один компьютер в количестве не менее 30 штук
            Console.WriteLine();
            Console.WriteLine("Есть ли хотя бы один компьютер в количестве не менее 30 штук?");
            var computers6 = listComputer
                .Any(c => c.Price > 30);
            if (true)
            {
                Console.WriteLine("Да!");
            }
            else
            {
                Console.WriteLine("Y=Нет!");
            }

            Console.ReadKey();
        }
    }

}
