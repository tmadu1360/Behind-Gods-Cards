﻿using BehindGodsCards.MyGame.Structures;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehindGodsCards.MyGame.Characters
{
    public class HQ
    {
        public MainBase ControlCenter;
        public Wall Wall;
        public Fields Fields;
        public Barracks Barracks;
        public HQ ()
        {
            ControlCenter = new MainBase();
            Wall = new Wall();
            Fields = new Fields();
            Barracks = new Barracks();
        }
    }
}
