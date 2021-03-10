using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace BehindGodsCards.MyGame
{
    class HUD
    {
        public bool InUnits;
        public bool InUpgrade;

        public Div UnitManagment;
        public Div MainUI;
        public Div CreateUnit;
        public Div UpgradeBuilding;

        
        public HUD()
        {
            LoadContent();

        }
        public void Update()
        {
            //Actualiser les boutons
        }

        public void Draw()
        {
            //Dessiner tout le contenu
        }
        public void LoadContent()
        {
            //simple séparation pour la propreté"
        }
    }
}
