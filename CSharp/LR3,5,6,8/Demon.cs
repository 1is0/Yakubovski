using System;
using System.Collections.Generic;
using System.Text;

namespace LR3
{
    class Demon : Unit, ISkillsDescription
    {
        private int bloodReserve;
        public int MaxBloodReserve;
        public int BloodReserve
        {
            get => bloodReserve;
            set
            {
                if (value < 0)
                {
                    bloodReserve = 0;
                    Console.WriteLine("Blood reserve depleted");
                }

                else if (value > MaxBloodReserve)
                {
                    bloodReserve = MaxBloodReserve;
                    Console.WriteLine("Blood reserve is full");
                }
                else bloodReserve = value;
            }
        }
        public Demon() : base()
        {
            MaxBloodReserve = 20;
            Inventory.Add(Item.Skull);
            BloodReserve = 10;
        }
        public Demon(string Name, int Money, int HP, Item[] Inventory) : base(Name, Money, HP, Inventory)
        {
            MaxBloodReserve = 20;
            this.Inventory.Add(Item.Skull);
            BloodReserve = 10;
        }
        public Demon(string Name, int Money, int HP) : base(Name, Money, HP)
        {
            MaxBloodReserve = 20;
            Inventory.Add(Item.Skull);
            BloodReserve = 10;
        }
        public Demon(string Name) : base(Name)
        {
            MaxBloodReserve = 20;
            Inventory.Add(Item.Skull);
            BloodReserve = 10;
        }
        public void DrinkBlood(int blood)
        {
            BloodReserve += blood;
        }
        public void DrinkBlood()
        {
            BloodReserve += 10;
        }

        public void Ritual()
        {
            if (BloodReserve >= 10)
            {
                Console.WriteLine($"{Name} restores HP");
                BloodReserve -= 10;
                HP += 10;
            }
            else
            {
                Console.WriteLine("Not enough blood");
            }
        }

        public void PrintSkillsDescription()
        {
            Console.WriteLine("Demons can restore health using blood");
        }
    }
}
