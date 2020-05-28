using System;
using System.Collections.Generic;
using System.Text;

namespace LR3
{
    abstract class Elf : Unit
    {
        public int MaxManaReserve;
        private int manaReserve;
        public int ManaReserve
        {
            get => manaReserve;
            set
            {
                if (value < 0)
                {
                    manaReserve = 0;
                    Console.WriteLine("Mana reserve depleted");
                }

                else if (value > MaxManaReserve)
                {
                    manaReserve = MaxManaReserve;
                    Console.WriteLine("Mana reserve is full");
                }
                else manaReserve = value;
            }
        }
        public Elf()
        {
            MaxManaReserve = 20;
            manaReserve = 10;
        }
        public void AbsorbMana(int mana)
        {
            ManaReserve += mana;
        }
        public void AbsorbMana()
        {
            ManaReserve += 10;
        }
    }
}
