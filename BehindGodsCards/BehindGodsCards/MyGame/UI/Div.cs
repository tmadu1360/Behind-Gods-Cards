using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace BehindGodsCards.MyGame
{
    public class Div
    {
        public List<Texts> Texts;
        public List<Buttons> Buttons;
        public Vector2 Position;

        public void AddText(string text, string font)
        {
            Texts.Add(new Texts(font, text));
        }
        public void AddText(string text, string font, int X, int Y)
        {
            Texts.Add(new Texts(font, text, X, Y));
        }
        public void AddButton(string name, string sprite, string spriteSelected, string spriteClicked)
        {
            Buttons.Add(new Buttons(name, sprite, spriteSelected, spriteClicked));
        }
        public void AddButton(string name, string sprite, string spriteSelected, string spriteClicked, int X, int Y)
        {
            Buttons.Add(new Buttons(name, sprite, spriteSelected, spriteClicked, X, Y));
        }
        public void AddButton(string name, string sprite, string spriteSelected, string spriteClicked, string spriteSelectedClicked)
        {
            Buttons.Add(new Buttons(name, sprite, spriteSelected, spriteClicked, spriteSelectedClicked));
        }

        public Div()
        {
            Position = new Vector2(0, 0);
            Texts = new List<Texts>();
            Buttons = new List<Buttons>();
        }

        public void Update()
        {
            if (Buttons.Count > 0)
            {
                //Tester la collision avec la souris
            }
        }

        public void Draw()
        {
            foreach(Buttons Button in Buttons)
            {
                Texture2D ToDraw = Button.Sprite;
                if (Button.Selected)
                {
                    ToDraw = Button.SpriteSelected;
                    if (Button.Clicked)
                    {
                        ToDraw = Button.SpriteClicked;
                    }
                }
                GeneralFunctions.SpriteBatch.Draw(ToDraw, new Vector2(Button.Position.X + Position.X, Button.Position.Y + Position.Y), Color.White);
            }
            foreach(Texts Text in Texts)
            {
                if (!Text.Hidden)
                {
                    GeneralFunctions.SpriteBatch.DrawString(Text.Font, Text.Text, new Vector2(Text.Position.X + Position.X, Text.Position.Y + Position.Y), Color.Black);
                }
            }
        }
    }
}
