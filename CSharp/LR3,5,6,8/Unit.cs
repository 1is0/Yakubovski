using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace LR3
{
    abstract class Unit : IEnumerable, IComparable
    {
        public Pockets Pockets;
        public string Name { get; set; }
        public int Money { get; set; }
        public ArrayList Inventory = new ArrayList();
        private int hp;
        public int HP
        {
            get => hp;
            set
            {
                if (value < 0) hp = 0;
                else if (value > MaxHP) hp = MaxHP;
                else hp = value;

                if (hp > 0 && hp < 5) HpIsLow?.Invoke(Name, HP);
            }
        }
        public int MaxHP { get; set; } = 100;
        public Unit()
        {
            Name = "NoName";
            Money = 10;
            HP = 1;
            Inventory.AddRange(new Item[] { Item.Stick, Item.Boots, Item.WaterFlask });
            MaxHP = 100;
        }
        public Unit(string Name, int Money, int HP, Item[] Inventory)
        {
            this.Name = Name;
            this.Money = Money;
            this.HP = HP;
            this.Inventory.AddRange(new Item[] { Item.Stick, Item.Boots, Item.WaterFlask });
            this.Inventory.AddRange(Inventory);
            MaxHP = 100;
        }

        public Unit(string Name, int Money, int HP) : this(Name, Money, HP, new Item[] { })
        {
        }
        public Unit(string Name) : this()
        {
            this.Name = Name;
        }
        public void TakeItem(Item item)
        {
            Inventory.Add(item);
            Console.WriteLine($"{item} added to inventory");
        }

        public void ShowInventory()
        {
            Console.WriteLine($"{Name}'s inventory:");
            if (Inventory.Count == 0)
            {
                Console.WriteLine("Empty");
                return;
            }
            foreach (Item i in Inventory)
            {
                Console.WriteLine(i);
            }
        }

        public Item this[int index]
        {
            get => (Item)Inventory[index];
        }

        public static void Info()
        {
            Console.WriteLine("-------------Info-------------");
            Console.WriteLine("Hierarchy:");
            Console.WriteLine("Unit => Demon,Elf");
            Console.WriteLine("Elf => LightElf,DarkElf");
            Console.WriteLine("Demons can drink blood and cast spells using it");
            Console.WriteLine("Elves can absorb mana and cast spells using it");
            Console.WriteLine("Light elves can talk to animals");
            Console.WriteLine("Dark elves can enchant items");
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)Inventory).GetEnumerator();
        }

        public int CompareTo(object obj)
        {
            Unit tmp = obj as Unit;
            if (tmp != null) return Name.CompareTo(tmp.Name);
            else throw new ArgumentException("Parameter is not a Unit");
        }

        public event Action<string, int> HpIsLow;

    }
}
