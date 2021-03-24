using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace BehindGodsCards.MyGame
{
    public class HUD
    {
        public bool InUnits;
        public bool InUpgrade;

        public Div UnitManagment;
        public Div MainUI;
        public Div CreateUnit;
        public Div UpgradeBuilding;

        public bool Selected;
        public bool Clicked;
        
        public HUD()
        {
            MainUI = new Div();
            CreateUnit = new Div();
            UnitManagment = new Div();
            UpgradeBuilding = new Div();

            LoadContent();

            //MainUI
            int ButtonSpace = ((((MainUI.Buttons.Count * MainUI.Buttons[0].Sprite.Width) * 2) - MainUI.Buttons.Count * MainUI.Buttons[0].Sprite.Width) / MainUI.Buttons.Count) / 2;
            for(int I = 0; I < MainUI.Buttons.Count; I++)
            {
                MainUI.Buttons[I].Position.X = MainUI.Position.X + ((I + 1) * ButtonSpace + I * MainUI.Buttons[I].Sprite.Width);
                MainUI.Buttons[I].Position.Y = MainUI.Position.Y + 20;
            }

            MainUI.Position.X = GeneralFunctions.ScreenWidth - ((MainUI.Buttons.Count) * (MainUI.Buttons[0].Sprite.Width + ButtonSpace) + ButtonSpace);
            MainUI.Position.Y = 0;
            //UnitManagment
            UnitManagment.Position.X = 0;
            UnitManagment.Position.Y = 0;
        }

        public void Update()
        {
            //Actualiser les boutons
            foreach (Buttons Button in MainUI.Buttons)
            {
                if (GeneralFunctions.MouseX > Button.Position.X && GeneralFunctions.MouseX < Button.Position.X + Button.Sprite.Width && GeneralFunctions.MouseY > Button.Position.X && GeneralFunctions.MouseY < Button.Position.Y + Button.Sprite.Height)
                {
                    Selected = true;
                }
                else
                {
                    Selected = false;
                }
            }
        }

        public void Draw()
        {
            MainUI.Draw();
            UnitManagment.Draw();
        }
        public void LoadContent()
        {
            //MainUI
            MainUI.AddButton("Units", "GameContent\\HUD\\Units", "GameContent\\HUD\\Units", "GameContent\\HUD\\Units");
            MainUI.AddButton("Upgrade", "GameContent\\HUD\\Upgrade", "GameContent\\HUD\\Upgrade", "GameContent\\HUD\\Upgrade");
            MainUI.AddButton("Stats", "GameContent\\HUD\\Stats", "GameContent\\HUD\\Stats", "GameContent\\HUD\\Stats");
            MainUI.AddButton("Menu", "GameContent\\HUD\\Menu", "GameContent\\HUD\\Menu", "GameContent\\HUD\\Menu");

            //UnitManagment
            UnitManagment.AddButton("Attack", "GameContent\\HUD\\Attack", "GameContent\\HUD\\AttackSelected", "GameContent\\HUD\\AttackClicked", "GameContent\\HUD\\AttackSelectedClicked");
            UnitManagment.AddButton("Defend", "GameContent\\HUD\\Defend", "GameContent\\HUD\\DefendSelected", "GameContent\\HUD\\DefendClicked", "GameContent\\HUD\\DefendSelectedClicked");
            UnitManagment.AddButton("Protect", "GameContent\\HUD\\Cover", "GameContent\\HUD\\CoverSelected", "GameContent\\HUD\\CoverClicked", "GameContent\\HUD\\CoverSelectedClicked");
        }
    }
}
