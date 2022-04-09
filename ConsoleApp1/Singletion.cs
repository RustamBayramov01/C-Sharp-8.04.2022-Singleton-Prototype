using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Singletion
    {
        private static Singletion instance;

        public static Singletion? getInstance()
        {
            if (Singletion.instance == null) { Singletion.instance = new Singletion(); }
            return Singletion.instance;
        }

    }
}
