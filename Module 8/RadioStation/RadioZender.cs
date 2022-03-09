using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioStation
{
    public delegate void Ontvangst(string msg);

    public class RadioZender
    {
        //private Ontvangst luisteraars;

        public event Ontvangst Zend;
        //{
        //    add
        //    {
        //        luisteraars += value;
        //    }
        //    remove
        //    {
        //        luisteraars -= value;
        //    }
        //}

        public void Broadcast()
        {
            Zend("Hallo luisteraars");
        }
    }
}
