﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Kett, Michael
//Lesson 3
//1.23.2017

namespace Lesson3Excercise
{

    public enum Flavor { REGULAR, ORANGE, LEMON }

    class Can
    {
        public readonly Flavor TheFlavor = Flavor.REGULAR;

        public Can()
        {
        }

        public Can(Flavor AFlavor)
        {
            TheFlavor = AFlavor;
        }

    }
}
