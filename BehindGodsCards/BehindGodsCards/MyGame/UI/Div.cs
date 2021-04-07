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
        public string Name;
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

        public Div(string name)
        {
            Name = name;
            Position = new Vector2(0, 0);
            Texts = new List<Texts>();
            Buttons = new List<Buttons>();
        }

        public void Update()
        {
            if (Buttons.Count > 0)
            {
                foreach (Buttons Button in Buttons)
                {
                    string returned = Button.Update(Position);
                    if (returned != "None" && Name == "UnitManagment")
                    {
                        foreach (Buttons button in Buttons)
                        {
                            if(button.Name != returned)
                            {
                                
                                button.Clicked = false;
                            }
                        }
                    }
                }
            }
        }
        public void Draw()
        {
            
            foreach (Buttons Button in Buttons)
            {
                Button.Draw(Position);
            }
            foreach (Texts Text in Texts)
            {
                Text.Draw(Position);
            }
        }
    }
}
