﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarcraftLibrary
{
    public class Range : Military
    {
        public int Rang;
        public int Mana;

        public Range(string name, int health, int cost, int lvl, bool isDestroyed, int speed, int damage, int attackSpeed, int armor, int range, int mana) : base(name, health, cost, lvl, isDestroyed, speed, damage, attackSpeed, armor)
        {
            this.Rang = range;
            this.Mana = mana;
        }
    }
}
