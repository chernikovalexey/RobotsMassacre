﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory;
using Level;

namespace Entity.Particle.Bonus
{
    public class TurretBonus : Bonus
    {
        public override bool ForInventory { get { return true; } }
        public override int ImageIndex { get { return 7; } }
        public override int Type { get { return (int)BonusType.TurretBonus; } }

        public TurretBonus(int x, int y) : base(x, y, 7500) { }

		public override void PickUp(int playerId)
        {
            GameLevel.GetPlayer(playerId).AddInvItem(new TurretInv());
        }

        public override string ToString()
        {
            return "turret";
        }
    }
}