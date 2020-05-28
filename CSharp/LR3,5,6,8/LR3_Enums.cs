using System;
using System.Collections.Generic;
using System.Text;

namespace LR3
{
    enum Specialty : byte
    {
        Archer, Swordsman, Healer, Mage
    }
    enum Item
    {
        Stick,
        WaterFlask,
        Boots,
        Skull,
        EnchantedStick = 1000,
        EnchantedWaterFlask,
        EnchantedBoots,
        EnchantedSkull
    }
}