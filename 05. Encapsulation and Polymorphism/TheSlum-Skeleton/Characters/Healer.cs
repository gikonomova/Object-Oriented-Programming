﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
   class Healer : Character, IHeal
    {
        public Healer(string id, int x, int y, int healthPoints, int defensePoints, int healingPoints, Team team, int range)
            : base(id, x, y, healingPoints, defensePoints, team, range)
        {
            this.HealingPoints = healingPoints;
        }
        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var targets = from target in targetsList
                          where target.IsAlive && target.Team == this.Team && target != this
                          orderby target.HealthPoints
                          select target;
            return targetsList.FirstOrDefault();
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
                
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveFromInventory(item);
        }
    }
}
