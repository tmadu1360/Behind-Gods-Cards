using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace BehindGodsCards.MyGame
{
    class Buttons
    {
        public string Name;
        public Vector2 Position;

        public Texture2D Sprite;
        public Texture2D SpriteSelected;
        public Texture2D SpriteClicked;

        public bool Selected;
        public bool Clicked;

        public Buttons(string name, string texture, string textureSelected, string textureClicked)
        {
            Sprite = GeneralFunctions.Content.Load<Texture2D>(texture);
            SpriteSelected = GeneralFunctions.Content.Load<Texture2D>(textureSelected);
            SpriteClicked = GeneralFunctions.Content.Load<Texture2D>(textureClicked);

            Name = name;
        }

        public Buttons(string name, string texture, string textureSelected, string textureClicked, int X, int Y)
        {
            Sprite = GeneralFunctions.Content.Load<Texture2D>(texture);
            SpriteSelected = GeneralFunctions.Content.Load<Texture2D>(textureSelected);
            SpriteClicked = GeneralFunctions.Content.Load<Texture2D>(textureClicked);

            Name = name;
            Position = new Vector2(X, Y);
        }



        public void Draw()
        {
            Texture2D ToDraw = Sprite;
            if(Selected)
            {
                ToDraw = SpriteSelected;
                if (Clicked)
                {
                    ToDraw = SpriteClicked;
                }
                GeneralFunctions.SpriteBatch.Draw(ToDraw, Position, Color.White);
            }
        }
    }
}
