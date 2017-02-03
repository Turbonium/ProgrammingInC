using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson6ConsoleAsLibrary
{
    public class Can
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
