using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace BehindGodsCards.MyGame
{
    class Div
    {
        public List<Texts> Texts;
        public List<Buttons> Buttons;

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

        public Div()
        {
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
                GeneralFunctions.SpriteBatch.Draw(ToDraw, Button.Position, Color.White);
            }
            foreach(Texts Text in Texts)
            {
                if (!Text.Hidden)
                {
                    GeneralFunctions.SpriteBatch.DrawString(Text.Font, Text.Text, Text.Position, Color.Black);
                }
            }
        }
    }
}
