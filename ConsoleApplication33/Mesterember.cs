using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication33
{
    public class Mesterember
    {
        private string Név;
        private int Napidij;
        private bool[] foglalt_napok = new bool[31];

        

        public Mesterember(string név, string napidij)
        {
            this.Név = név;
            this.Napidij = Napidij;

            for (int i = 0;i<31;i++)
            {
                foglalt_napok [i]= true;
            }
        }

        public virtual void mindenadat()
        {

        }

        public virtual bool munkatvallal()
        {

        }
    }
}