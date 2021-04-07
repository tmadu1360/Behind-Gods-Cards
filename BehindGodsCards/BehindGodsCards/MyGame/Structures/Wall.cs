using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BehindGodsCards.MyGame.Structures
{
    public class Wall : Batiments
    {
        public StructureStats StructStats;
        public int Armor;
        public int MaxUnits;
        public int Lvl;
        public int MaxUnit;
        public int UnitOnit;
        public Vector2 Position;
        public List<Texture2D> Sprites;

        public bool Opened;
        public bool Closed;
        public int SpriteState;
        public Texture2D WallOpening1;
        public Texture2D WallOpening2;
        public Texture2D WallClose;

        public Wall()
        {
            StructStats = new StructureStats();
            Lvl = 1;
            Hp = StructStats.wall.Lvl1.Health;
            Armor = StructStats.wall.Lvl1.Armor;
            Sprites = new List<Texture2D>();

            Sprites.Add(GeneralFunctions.Content.Load<Texture2D>("GameContent\\WallAnim0"));
            Sprites.Add(GeneralFunctions.Content.Load<Texture2D>("GameContent\\WallAnim1"));
            Sprites.Add(GeneralFunctions.Content.Load<Texture2D>("GameContent\\WallAnim2"));
            Closed = true;
        }
        public void Update()
        {
            
        }
        public void Load()
        {

        }
        public void LevelUp()
        {
            Lvl = Lvl + 1;
            if (Lvl == 2)
            {
                Hp = StructStats.wall.Lvl2.Health;
                Armor = StructStats.wall.Lvl2.Armor;
            }
            if (Lvl == 3)
            {
                Hp = StructStats.wall.Lvl3.Health;
                Armor = StructStats.wall.Lvl3.Armor;
            }
        }
        public void Draw()
        {
            if(!Closed)
            {
                GeneralFunctions.SpriteBatch.Draw(Sprites[SpriteState], Position, Color.White);
            }
        }
    }
}