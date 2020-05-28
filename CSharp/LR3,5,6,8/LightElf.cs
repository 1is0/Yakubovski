using System;
using System.Collections.Generic;
using System.Text;

namespace LR3
{
    class LightElf : Elf, ISkillsDescription
    {
        public void PrintSkillsDescription()
        {
            Console.WriteLine("Light elves can talk to animals");
        }

        public void TalkingWithAnimals()
        {
            if (ManaReserve >= 10)
            {
                Console.WriteLine($"{Name} speaks with animals");
                ManaReserve -= 10;
            }
            else
            {
                Console.WriteLine("Not enough mana");
            }
        }
    }
}
