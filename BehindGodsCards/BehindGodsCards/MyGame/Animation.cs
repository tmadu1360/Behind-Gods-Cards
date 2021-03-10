using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace BehindGodsCards.MyGame
{
    public class Animation
    {
        public string Name;
        public double Delay;
        public double DelayCount;
        public int TextureNumber;
        public List<Texture2D> Textures;
        public Animation(string name, List<string> spritesToAdd, double delay)
        {
            Name = name;
            Delay = delay;
            DelayCount = 0;
            Textures = new List<Texture2D>();
            foreach(string Sprite in spritesToAdd)
            {
                Textures.Add(GeneralFunctions.Content.Load<Texture2D>("GameContent\\" + Sprite));
            }
        }
        public void Update()
        {
            DelayCount += 1 * GeneralFunctions.GameTime.ElapsedGameTime.TotalSeconds;
            System.Diagnostics.Debug.WriteLine(DelayCount);
            if (DelayCount >= Delay)
            {
                TextureNumber++;
                DelayCount = 0;
                if (TextureNumber == Textures.Count)
                {
                    TextureNumber -=Textures.Count;
                }
            }
        }
    }
}
