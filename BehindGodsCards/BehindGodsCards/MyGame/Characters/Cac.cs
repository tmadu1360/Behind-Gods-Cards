﻿using System;
using System.Collections.Generic;
using System.Text;
using BehindGodsCards.MyGame;

namespace BehindGodsCards.MyGame.Characters
{
    class Cac : Units
    {
        public UnitsStats UnitsStats;
        public Cac(int UnitLvl) : base(UnitLvl)
        {
            Lvl = UnitLvl;
            UnitsStats = new UnitsStats();
            switch (Lvl)
            {
                case 1:
                    Health = UnitsStats.cac.Lvl1.Health;
                    Damage = UnitsStats.cac.Lvl1.Damage;
                    Armor = UnitsStats.cac.Lvl1.Armor;
                    Cost = UnitsStats.cac.Lvl1.Cost;
                    break;
                case 2:
                    Health = UnitsStats.cac.Lvl2.Health;
                    Damage = UnitsStats.cac.Lvl2.Damage;
                    Armor = UnitsStats.cac.Lvl2.Armor;
                    Cost = UnitsStats.cac.Lvl2.Cost;
                    break;
                case 3:
                    Health = UnitsStats.cac.Lvl3.Health;
                    Damage = UnitsStats.cac.Lvl3.Damage;
                    Armor = UnitsStats.cac.Lvl3.Armor;
                    Cost = UnitsStats.cac.Lvl3.Cost;
                    break;
            }
            Animations = new List<Animation>();
            Animations.Add(new Animation("Walk", new List<string>(){ "CharacterWalk0", "CharacterWalk1", "CharacterWalk2" }, 0.25, "Reverse"));
        }
    }
}
