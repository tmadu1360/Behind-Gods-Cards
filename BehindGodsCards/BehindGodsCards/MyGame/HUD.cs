using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using BehindGodsCards.MyGame;


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

        protected Texture2D Infobar;
        protected Texture2D Bitcoin;

        protected SpriteFont LittleFont;
        
        protected double Money;
        
        public HUD()
        {
            MainUI = new Div("MainUI");
            CreateUnit = new Div("CreateUnit");
            UnitManagment = new Div("UnitManagment");
            UpgradeBuilding = new Div("UpgradeBuilding");

            LoadContent();
            //===============\\
            //=====Main UI====\\
            //================\\
            int ButtonSpace = ((((MainUI.Buttons.Count * MainUI.Buttons[0].Sprite.Width) * 2) - MainUI.Buttons.Count * MainUI.Buttons[0].Sprite.Width) / MainUI.Buttons.Count) / 2;
            for(int I = 0; I < MainUI.Buttons.Count; I++)
            {
                MainUI.Buttons[I].Position.X = MainUI.Position.X + ((I + 1) * ButtonSpace + I * MainUI.Buttons[I].Sprite.Width);
                MainUI.Buttons[I].Position.Y = MainUI.Position.Y + 35;
            }
            MainUI.Position.X = GeneralFunctions.ScreenWidth - (MainUI.Buttons[3].Position.X + MainUI.Buttons[3].Sprite.Width + ButtonSpace);
            MainUI.Position.Y = 0;
            //===============\\
            //=UnitManagment=\\
            //===============\\
            for (int I = 0; I < UnitManagment.Buttons.Count; I++)
            {
                UnitManagment.Buttons[I].Position.X = 10;
                UnitManagment.Buttons[I].Position.Y = (I * UnitManagment.Buttons[I].Sprite.Height + (I + 1) *5);
            }
            UnitManagment.Position.X = 0;
            UnitManagment.Position.Y = 30;
            UnitManagment.Texts[0].Position.X = 60;
            UnitManagment.Texts[0].Position.Y = 6;
            UnitManagment.Texts[1].Position.X = 60;
            UnitManagment.Texts[1].Position.Y = 51;
            UnitManagment.Texts[2].Position.X = 60;
            UnitManagment.Texts[2].Position.Y = 96;
        }

        public void Update(double money)
        {
            MainUI.Update();
            CreateUnit.Update();
            UnitManagment.Update();
            UpgradeBuilding.Update();
            for (int I = 0; I < UnitManagment.Buttons.Count; I++)
            {
                if(UnitManagment.Buttons[I].Selected)
                {
                    UnitManagment.Texts[I].Hidden = false;
                }
                else
                {
                    UnitManagment.Texts[I].Hidden = true;
                }
            }
            Money = money;
        }
        public void Draw()
        {
            MainUI.Draw();
            UnitManagment.Draw();
            GeneralFunctions.SpriteBatch.Draw(Infobar, new Vector2(0, 0), Color.White);
            GeneralFunctions.SpriteBatch.Draw(Bitcoin, new Vector2(15,6),Color.White);
            GeneralFunctions.SpriteBatch.DrawString(LittleFont, Math.Round(Money).ToString(), new Vector2(45,2),Color.Cyan);
        }
        public void LoadContent()
        {
            LittleFont = GeneralFunctions.Fonts.Get("LittleFont");
            
            //MainUI---
            MainUI.AddButton("Units", "GameContent\\HUD\\Units", "GameContent\\HUD\\Units", "GameContent\\HUD\\UnitsClicked");
            MainUI.AddButton("Upgrade", "GameContent\\HUD\\Upgrade", "GameContent\\HUD\\UpgradeSelected", "GameContent\\HUD\\UpgradeClicked");
            MainUI.AddButton("Stats", "GameContent\\HUD\\Stats", "GameContent\\HUD\\StatsSelected", "GameContent\\HUD\\StatsClicked");
            MainUI.AddButton("Menu", "GameContent\\HUD\\Menu", "GameContent\\HUD\\MenuSelected", "GameContent\\HUD\\MenuClicked");

            //UnitManagment
            UnitManagment.AddButton("Attack", "GameContent\\HUD\\Attack", "GameContent\\HUD\\AttackSelected", "GameContent\\HUD\\AttackClicked", "GameContent\\HUD\\AttackSelectedClicked");
            UnitManagment.AddButton("Defend", "GameContent\\HUD\\Defend", "GameContent\\HUD\\DefendSelected", "GameContent\\HUD\\DefendClicked", "GameContent\\HUD\\DefendSelectedClicked");
            UnitManagment.AddButton("Protect", "GameContent\\HUD\\Cover", "GameContent\\HUD\\CoverSelected", "GameContent\\HUD\\CoverClicked", "GameContent\\HUD\\CoverSelectedClicked");

            UnitManagment.AddText("Attack", "Default");
            UnitManagment.AddText("Defend", "Default");
            UnitManagment.AddText("Protect", "Default");

            Infobar = GeneralFunctions.Content.Load<Texture2D>("GameContent\\HUD\\infobar");
            Bitcoin = GeneralFunctions.Content.Load<Texture2D>("GameContent\\HUD\\Bitcoin");
        }
    }
}
