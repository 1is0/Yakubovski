using System;
using System.Collections.Generic;
using System.Text;

namespace LR3
{
    class DarkElf : Elf, ISkillsDescription
    {
        public void Enchanting(int index)
        {
            if ((int)Inventory[index]>=1000)
            {
                Console.WriteLine("This item ia already enchanted");
                return;
            }
            if (ManaReserve >= 10)
            {
                Item tmp = (Item)Inventory[index];
                Console.WriteLine($"{Name} enchants {tmp}");
                Inventory.RemoveAt(index);
                tmp += 1000;
                Inventory.Insert(index, tmp);
                ManaReserve -= 10;
            }
            else
            {
                Console.WriteLine("Not enough mana");
            }
        }

        public void PrintSkillsDescription()
        {
            Console.WriteLine("Dark elves can enchant items");
        }
    }
}
