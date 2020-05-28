using System;

namespace LR3
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************");
            Unit.Info();//демонстрация статического метода
            Console.WriteLine("**********************");
            Demon Dima = new Demon("Dimas", 9, 13);//создание экземпляра Demon
            Console.WriteLine($"Dimas.HP == {Dima.HP}");
            Dima.HpIsLow += delegate (string name, int hp)//регестрация события
            {
                Console.WriteLine($"{name}'s hp is low({hp})");
            };
            Dima.HP -= 11;//изменение ХП для срабатывания события
            Console.WriteLine($"Dimas.HP == {Dima.HP}");
            Console.WriteLine($"Dimas.MaxBloodReserve == {Dima.MaxBloodReserve}");//максимальное значение резерва
            Console.WriteLine($"Dimas.BloodReserve == {Dima.BloodReserve}");//текущее значение резерва
            Dima.BloodReserve += 100000;//попытка увеличить запас выше максимального значения
            Console.WriteLine($"Dimas.BloodReserve == {Dima.BloodReserve}");
            Dima.Ritual();//вызов метода уменьш. резерв и увелич. ХП
            Console.WriteLine($"Dimas.HP == {Dima.HP}");
            Console.WriteLine($"Dimas.BloodReserve == {Dima.BloodReserve}");
            Console.WriteLine("-------------------------------");
            LightElf Artur = new LightElf { HP = 20, Name = "Artur", ManaReserve = 15 };
            Artur.TalkingWithAnimals();//демонстрация простого метода
            try
            {
                Console.WriteLine(Dima.CompareTo(new Boolean()));//сравнение несопостовимых объектов             
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("-------------------------------");
            DarkElf Corolina = new DarkElf { Name = "Corolina", HP = 14 };
            Corolina.ShowInventory();//демонстрация инвентаря
            Console.WriteLine();
            Corolina.TakeItem(Item.Skull);//добавление нового предмента в инвентарь
            Corolina.Enchanting(1);//изменение объекта в инвентаре по индексу
            Console.WriteLine();
            Corolina.ShowInventory();
            Console.WriteLine();

            Corolina.Pockets.Left = Item.Stick;//демонстрация структуры "карманов"
            Corolina.Pockets.Right = Item.WaterFlask;
            Console.WriteLine($"{Corolina.Name} have {Corolina.Pockets.Left} and {Corolina.Pockets.Right} in pockets");
            Console.WriteLine("-------------------------------");
            Unit[] array = { Dima, Artur, Corolina };//помещение всех объектов в один массив класса родителя
            foreach (Unit unit in array)//вывод имен до сортировки
            {
                Console.WriteLine(unit.Name);
            }
            Console.WriteLine();
            Array.Sort(array);//демонстация IComparable с помощью сортировки
            foreach (Unit unit in array)//вывод имен после сортировки
            {
                Console.WriteLine(unit.Name);
            }
            Console.WriteLine("--------------");
            foreach(Item i in Corolina)//вывод инвенторя с помощью IEnumerable
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------");
            ISkillsDescription[] array2 = { Dima, Artur, Corolina };//демонстрация собственного 
                                                                    //интерфейса ISkillsDescription
            foreach (ISkillsDescription isd in array2)
            {
                isd.PrintSkillsDescription();
            }
            Console.WriteLine("--------------");
            Console.WriteLine(Corolina[1]);//демонстация индексатора (завязан на инвентарь)
        }
    }
}
