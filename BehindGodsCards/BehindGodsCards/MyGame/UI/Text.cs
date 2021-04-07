using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace BehindGodsCards.MyGame
{
    public class Texts
    {
        public Vector2 Position;
        public SpriteFont Font;
        public string Text;
        public bool Hidden;

        public Texts(string font, string text)
        {
            Font = GeneralFunctions.Fonts.Get(font);
            Text = text;
            Hidden = true;
        }
        public Texts(string font, string text, float X, float Y)
        {
            Font = GeneralFunctions.Fonts.Get(font);
            Text = text;
            Position = new Vector2(X, Y);
            Hidden = true;
        }

        public void Draw(Vector2 DivPosition)
        {
            GeneralFunctions.SpriteBatch.DrawString(Font, Text, new Vector2(DivPosition.X + Position.X, DivPosition.Y + Position.Y), Color.Aqua);
        }
    }
}

